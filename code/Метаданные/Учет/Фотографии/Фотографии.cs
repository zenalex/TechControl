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
using System.Threading.Tasks;
using System.Drawing.Drawing2D;



namespace TechControl.Метаданные.Учет
{
    
    public partial class Фотографии
    {
        #region Compress
        public static Dictionary<int, string> photoTypeSizes = new Dictionary<int, string>()
        {
            [150] = Фотографии.Names.ПутьМаленькийРазмер,
            [300] = Фотографии.Names.ПутьСреднийРазмер,
            [1200] = Фотографии.Names.ПутьБольшойРазмер
        };

        public static string GenerateFileNameWithSize(string origName, int width)
        {
            var origNameWOExt = Path.GetFileNameWithoutExtension(origName);
            var onExt = Path.GetExtension(origName).Trim('.');
            string name = $"{origNameWOExt}_{width}.{onExt}";
            return name;
        }

        public static MemoryStream CompressImageToMemory(MemoryStream fileStream, ref int width, ref int height, bool cropAndCenter = false)
        {
            var bytes = fileStream.ToArray();
            var mimeType = MimeSniffer.GetMime(bytes);
            if (!ImageFormatDict.ContainsKey(mimeType)) return null;

            long bytesLength = bytes.Length;
            using (var image = Image.FromStream(fileStream))
            using (Bitmap bitmap = ResizeImageKeepRatio(image, width, height, cropAndCenter, false))
            {
                height = bitmap.Height;
                width = bitmap.Width;
                image.Dispose();
                var imageFormat = GetImageFormat(mimeType, null);
                var compressed = Фотографии.Compress(bitmap, imageFormat, 50);
                return compressed;
            }
        }

        public static MemoryStream Compress(Image image, ImageFormat imageFormat, int quality)
        {
            ImageCodecInfo jpgEncoder = GetEncoder(imageFormat);
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(
                System.Drawing.Imaging.Encoder.Quality, quality);
            var stream = new MemoryStream();
            image.Save(stream, jpgEncoder, encoderParameters);
            return stream;
        }

        public static Bitmap ResizeImageKeepRatio(Image image, int width, int height, bool cropAndCenter = false, bool allowUpscale = true)
        {
            int newWidth;
            int newHeight;
            if (cropAndCenter)
            {
                if ((double)image.Width / image.Height > (double)width / height)
                {
                    newWidth = (int)(height * ((double)image.Width / image.Height));
                    newHeight = height;
                }
                else
                {
                    newWidth = width;
                    newHeight = (int)(width * ((double)image.Height / image.Width));
                }
            }
            else if ((double)image.Width / image.Height < (double)width / height)
            {
                newWidth = (int)(height * ((double)image.Width / image.Height));
                newHeight = height;
            }
            else
            {
                newWidth = width;
                newHeight = (int)(width * ((double)image.Height / image.Width));
            }
            int iWidth = image.Width;
            int iHeight = image.Height;
            Bitmap bitmap = Фотографии.ResizeImage(image, newWidth, newHeight, allowUpscale);
            if (cropAndCenter && (bitmap.Width != width || bitmap.Height != height))
            {
                width = Math.Min(bitmap.Width, width);
                height = Math.Min(bitmap.Height, height);
                var cropX = (int)((double)Math.Abs(bitmap.Width - width) / 2);
                var cropY = (int)((double)Math.Abs(bitmap.Height - height) / 2);
                var rect = new Rectangle(cropX, cropY, width, height);
                var bitmap1 = bitmap.Clone(rect, bitmap.PixelFormat);
                bitmap.Dispose();
                bitmap = bitmap1;
            }

            return bitmap;
        }

        /// <summary>
        /// Пережать изображение БЕЗ сохранения пропорции
        /// </summary>
        /// <param name="image"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="allowUpscale"></param>
        /// <returns></returns>
        public static Bitmap ResizeImage(Image image, int width, int height, bool allowUpscale = false)
        {
            if (!allowUpscale)
            {
                width = Math.Min(image.Width, width);
                height = Math.Min(image.Height, height);
            }

            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height, image.PixelFormat);
            {
                destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceOver;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }
            }

            return destImage;
        }
        #endregion Compress

        #region Download
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
        public Image ПолучитьФото(out FileAdditionalInfo info)
        {
            info = new FileAdditionalInfo();
            if (string.IsNullOrWhiteSpace(this.Путь)) return null;

            Image img = null;
            var path = this.Путь;

            try
            {
                if (!string.IsNullOrWhiteSpace(Метаданные.MinioBucketName))
                {
                    Stream stream = null;
                    try
                    {
                        var storage = new MinioFileStorage();
                        byte[] bytes = null;
                        Task.Run(async () =>
                        {
                            using (var content = await storage.DownloadFileAsync(path))
                            {
                                stream = await content.ReadAsStreamAsync();
                                img = Image.FromStream(stream);
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    stream.CopyTo(ms);
                                    bytes = ms.ToArray();
                                }
                            }
                        }).Wait();
                        info.FullPath = path;
                        info.MimeType = MimeSniffer.GetMime(bytes);
                        info.BytesLength = bytes.Length;

                        return img;
                    }
                    finally
                    {
                        stream?.Dispose();
                    }
                }
                var localPath = Path.Combine(Метаданные.FilesDirectory, path);
                if (File.Exists(localPath))
                {
                    img = Image.FromFile(localPath);
                    info.FullPath = localPath;
                    var bytes = File.ReadAllBytes(localPath);
                    info.MimeType = MimeSniffer.GetMime(bytes);
                    info.BytesLength = bytes.Length;
                }
                else if (!string.IsNullOrWhiteSpace(Метаданные.ExternalFileSource))
                {
                    var remotePath = Метаданные.ExternalFileSource + path;
                    var bytes = WebClient.DownloadData(remotePath);
                    using (MemoryStream stream = new MemoryStream(bytes))
                        img = Image.FromStream(stream);
                    info.FullPath = remotePath;
                    info.MimeType = MimeSniffer.GetMime(bytes);
                    info.BytesLength = bytes.Length;
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

        public struct FileAdditionalInfo
        {
            public string FullPath { get; set; }
            public string MimeType { get; set; }
            public long BytesLength { get; set; }
        }
        #endregion Download

        #region MimeSniffer
        public static ImageFormat GetImageFormat(string mimeType, string path)
        {
            var imageFormat = ImageFormat.Jpeg;
            if (ImageFormatDict.TryGetValue(mimeType, out ImageFormat _imageFormat))
            {
                imageFormat = _imageFormat;
            }
            else if (!string.IsNullOrWhiteSpace(path) &&
                path.Contains(".") && ImageFormatDict.TryGetValue(path.Substring(path.LastIndexOf('.') + 1), out ImageFormat _format))
            {
                imageFormat = _format;
            }
            return imageFormat;
        }

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
