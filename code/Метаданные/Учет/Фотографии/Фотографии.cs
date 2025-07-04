using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using System.Net;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;



namespace TechControl.Метаданные.Учет
{
    
    public partial class Фотографии
    {
        #region Данные
        #endregion //Данные

        #region Конструкторы
        #endregion //Конструкторы

        #region Свойства
        #endregion //Свойства

        #region Методы
        private static WebClient _webClient;
        public WebClient WebClient
        {
            get
            {
                _webClient = _webClient != null ? _webClient : new WebClient();
                ServicePointManager.SecurityProtocol =
                    SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                return _webClient;
            }
        }
        public Image ПолучитьФото() => ПолучитьФото(out _);
        public Image ПолучитьФото(out string fullPath)
        {
            fullPath = null;
            if (string.IsNullOrWhiteSpace(this.Путь)) return null;

            Image img = null;
            var path = this.Путь;

            try
            {
                var localPath = Path.Combine(Метаданные.FilesDirectory, path);
                if (File.Exists(localPath))
                {
                    img = Image.FromFile(localPath);
                    fullPath = localPath;
                }
                else if (!string.IsNullOrWhiteSpace(Метаданные.ExternalFileSource))
                {
                    var remotePath = Метаданные.ExternalFileSource + path;
                    var bytes = WebClient.DownloadData(remotePath);
                    using (MemoryStream stream = new MemoryStream(bytes))
                    {
                        img = Image.FromStream(stream);
                        fullPath = remotePath;
                    }
                }
            }
            catch
            {
                var message = "Не удалось загрузить файл: " + path;
                NsgSettings.MainForm?.ShowMessage(message);
                Console.WriteLine(message);
            }

            return img;
        }
        #endregion //Методы

        #region MimeSniffer
        public static Dictionary<string, ImageFormat> ImageFormatDict = new Dictionary<string, ImageFormat>
        {
            ["jpg"] = ImageFormat.Jpeg,
            ["jpeg"] = ImageFormat.Jpeg,
            ["image/jpeg"] = ImageFormat.Jpeg,
            ["image/pjpeg"] = ImageFormat.Jpeg,
            ["png"] = ImageFormat.Png,
            ["image/png"] = ImageFormat.Png,
            ["image/x-png"] = ImageFormat.Png,
            ["bmp"] = ImageFormat.Bmp,
            ["image/bmp"] = ImageFormat.Bmp,
            ["gif"] = ImageFormat.Gif,
            ["image/gif"] = ImageFormat.Gif,
            ["tif"] = ImageFormat.Tiff,
            ["image/tif"] = ImageFormat.Tiff,
            ["tiff"] = ImageFormat.Tiff,
            ["image/tiff"] = ImageFormat.Tiff,
        };

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            return Array.Find(ImageCodecInfo.GetImageDecoders(), codec => codec.FormatID == format.Guid);
        }

        /// <summary>
        /// Helper class to detect the MIME type based on the file header signature.
        /// </summary>
        public static class MimeSniffer
        {
            /// <summary>
            /// Internet Explorer 9. Returns image/png and image/jpeg instead of 
            /// image/x-png and image/pjpeg.
            /// </summary>
            private const int FMFD_RETURNUPDATEDIMGMIMES = 0x20;

            /// <summary>
            /// The zero (0) value for Reserved parameters.
            /// </summary>
            private const int RESERVED = 0;

            /// <summary>
            /// The value that is returned when the MIME type cannot be recognized.
            /// </summary>
            private const string UNKNOWN = "unknown/unknown";

            /// <summary>
            /// The return value which indicates that the operation completed successfully.
            /// </summary>
            private const int S_OK = 0;


            /// <summary>
            /// Determines the MIME type from the data provided.
            /// </summary>
            /// <param name="pBC">A pointer to the IBindCtx interface. Can be set to NULL.</param>
            /// <param name="pwzUrl">A pointer to a string value that contains the URL of the data. Can be set to NULL if <paramref name="pBuffer"/> contains the data to be sniffed.</param>
            /// <param name="pBuffer">A pointer to the buffer that contains the data to be sniffed. Can be set to NULL if <paramref name="pwzUrl"/> contains a valid URL.</param>
            /// <param name="cbSize">An unsigned long integer value that contains the size of the buffer.</param>
            /// <param name="pwzMimeProposed">A pointer to a string value that contains the proposed MIME type. This value is authoritative if type cannot be determined from the data. If the proposed type contains a semi-colon (;) it is removed. This parameter can be set to NULL.</param>
            /// <param name="dwMimeFlags">The flags which modifies the behavior of the function.</param>
            /// <param name="ppwzMimeOut">The address of a string value that receives the suggested MIME type.</param>
            /// <param name="dwReserverd">Reserved. Must be set to 0.</param>
            /// <returns>S_OK, E_FAIL, E_INVALIDARG or E_OUTOFMEMORY.</returns>
            /// <remarks>
            /// Read more: http://msdn.microsoft.com/en-us/library/ms775107(v=vs.85).aspx
            /// </remarks>
            //[DllImport(@"urlmon.dll", CharSet = CharSet.Auto)]
            //private extern static uint FindMimeFromData(
            //    uint pBC,
            //    [MarshalAs(UnmanagedType.LPStr)] string pwzUrl,
            //    [MarshalAs(UnmanagedType.LPArray)] byte[] pBuffer,
            //    uint cbSize,//int
            //    [MarshalAs(UnmanagedType.LPStr)] string pwzMimeProposed,//
            //    uint dwMimeFlags,//int
            //    out uint ppwzMimeOut,//IntPtr
            //    uint dwReserverd//int
            //    );
            [DllImport("urlmon.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = false)]
            static extern int FindMimeFromData(
                IntPtr pBC,
                [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl,
                [MarshalAs(UnmanagedType.LPArray, ArraySubType=UnmanagedType.I1, SizeParamIndex=3)]
                byte[] pBuffer,
                int cbSize,
                [MarshalAs(UnmanagedType.LPWStr)] string pwzMimeProposed,
                int dwMimeFlags,
                out IntPtr ppwzMimeOut,
                int dwReserved
                );


            /// <summary>
            /// Returns the MIME type for the specified file header.
            /// </summary>
            /// <param name="header">The header to examine.</param>
            /// <returns>The MIME type or "unknown/unknown" if the type cannot be recognized.</returns>
            /// <remarks>
            /// NOTE: This method recognizes only 26 types used by IE.
            /// http://msdn.microsoft.com/en-us/library/ms775147(VS.85).aspx#Known_MimeTypes
            /// </remarks>
            public static string GetMime(byte[] header)
            {
                try
                {
                    IntPtr mimeTypePtr;
                    var result = FindMimeFromData(new IntPtr(0),
                                                    null,
                                                    header,
                                                    header.Length,
                                                    null,
                                                    FMFD_RETURNUPDATEDIMGMIMES,
                                                    out mimeTypePtr,
                                                    RESERVED);
                    if (result != S_OK)
                    {
                        return UNKNOWN;
                    }

                    string mime = Marshal.PtrToStringUni(mimeTypePtr);
                    Marshal.FreeCoTaskMem(mimeTypePtr);
                    return mime;
                }
                catch
                {
                    return UNKNOWN;
                }
            }

        }
        #endregion MimeSniffer
    }

}
