using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;
using System.Net;
using System.Drawing;



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
    }

}
