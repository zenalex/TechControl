using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TechControl
{
    public class MinioFileStorage
    {
        private readonly HttpClient _httpClient;
        private readonly string _endpoint;
        private readonly string _accessKey;
        private readonly string _secretKey;
        private readonly string _bucketName;
        private readonly string _region;

        public MinioFileStorage() : this(
            System.Configuration.ConfigurationManager.AppSettings["MinioEndpoint"],
            System.Configuration.ConfigurationManager.AppSettings["MinioLogin"],
            System.Configuration.ConfigurationManager.AppSettings["MinioPassword"],
            System.Configuration.ConfigurationManager.AppSettings["MinioBucketName"],
            "us-east-1")
        { }

        public MinioFileStorage(string bucketName, string region = "us-east-1") : this(
            System.Configuration.ConfigurationManager.AppSettings["MinioEndpoint"],
            System.Configuration.ConfigurationManager.AppSettings["MinioLogin"],
            System.Configuration.ConfigurationManager.AppSettings["MinioPassword"],
            bucketName, region)
        { }

        public MinioFileStorage(string endpoint, string accessKey, string secretKey, string bucketName, string region = "us-east-1")
        {
            _endpoint = endpoint.TrimEnd('/');
            _accessKey = accessKey;
            _secretKey = secretKey;
            _bucketName = bucketName;
            _region = region;
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        /// <summary>
        /// Составление словаря заголовков
        /// </summary>
        /// <param name="amzDate"></param>
        /// <param name="payloadHash"></param>
        /// <returns></returns>
        private Dictionary<string, string> GenerateHeadersForSignature(string amzDate, string payloadHash = null)
        {
            return new Dictionary<string, string>
            {
                { "host", new Uri(_endpoint).Host },
                { "x-amz-date", amzDate },
                { "x-amz-content-sha256", payloadHash ?? "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855" }
            };
        }

        /// <summary>
        /// Вычисление подписи AWS Signature Version 2
        /// </summary>
        /// <param name="method"></param>
        /// <param name="bucket"></param>
        /// <param name="objectName"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        private string GenerateSignatureV2(string method, string bucket, string objectName, string date)
        {
            // Формируем каноническую строку для подписи
            string resource = $"/{bucket}/{objectName}";
            string stringToSign = $"{method}\n\n\n{date}\n{resource}";

            using (var hmac = new HMACSHA1(Encoding.UTF8.GetBytes(_secretKey)))
            {
                byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign));
                return Convert.ToBase64String(hash);
            }
        }

        /// <summary>
        /// Вычисление подписи AWS Signature Version 4
        /// </summary>
        /// <param name="method"></param>
        /// <param name="bucket"></param>
        /// <param name="objectName"></param>
        /// <param name="date"></param>
        /// <param name="amzDate"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private string GenerateSignatureV4(string method, string bucket, string objectName, string date, string amzDate, Dictionary<string, string> headers)
        {
            try
            {
                // Формируем канонический запрос
                string resource = string.IsNullOrEmpty(objectName) ? $"/{bucket}" : $"/{bucket}/{objectName}";
                string canonicalUri = Uri.EscapeDataString(resource).Replace("%2F", "/"); // Корректное экранирование пути
                string canonicalQueryString = "";
                string host = new Uri(_endpoint).Host;

                // Сортируем заголовки
                var sortedHeaders = headers.OrderBy(h => h.Key.ToLower()).ToDictionary(h => h.Key.ToLower(), h => h.Value.Trim());
                string canonicalHeaders = string.Join("", sortedHeaders.Select(h => $"{h.Key}:{h.Value}\n"));
                string signedHeaders = string.Join(";", sortedHeaders.Keys);

                // Для GET/HEAD-запросов payload пустой
                string payloadHash = sortedHeaders.ContainsKey("x-amz-content-sha256")
                    ? sortedHeaders["x-amz-content-sha256"]
                    : "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855";

                // Канонический запрос
                string canonicalRequest = $"{method}\n{canonicalUri}\n{canonicalQueryString}\n{canonicalHeaders}\n{signedHeaders}\n{payloadHash}";

                // Строка для подписи
                string algorithm = "AWS4-HMAC-SHA256";
                string credentialScope = $"{date}/{_region}/s3/aws4_request";
                string stringToSign = $"{algorithm}\n{amzDate}\n{credentialScope}\n" + ComputeSha256(canonicalRequest);

                // Вычисление подписи
                byte[] dateKey = ComputeHmacSha256(Encoding.UTF8.GetBytes($"AWS4{_secretKey}"), date);
                byte[] dateRegionKey = ComputeHmacSha256(dateKey, _region);
                byte[] dateRegionServiceKey = ComputeHmacSha256(dateRegionKey, "s3");
                byte[] signingKey = ComputeHmacSha256(dateRegionServiceKey, "aws4_request");
                byte[] signatureBytes = ComputeHmacSha256(signingKey, stringToSign);
                string signature = BitConverter.ToString(signatureBytes).Replace("-", "").ToLower();

                // Формируем строку авторизации
                string authHeader = $"{algorithm} Credential={_accessKey}/{credentialScope},SignedHeaders={signedHeaders},Signature={signature}";

                return authHeader;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при генерации подписи: {ex.Message}");
            }
        }

        /// <summary>
        /// Вычисление SHA256 хэша
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string ComputeSha256(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        /// <summary>
        /// Вычисление HMAC-SHA256
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private byte[] ComputeHmacSha256(byte[] key, string data)
        {
            using (var hmac = new HMACSHA256(key))
            {
                return hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
            }
        }

        /// <summary>
        /// Проверка и создание бакета
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private async Task EnsureBucketExistsAsync()
        {
            try
            {
                string date = DateTime.UtcNow.ToString("yyyyMMdd");
                string amzDate = DateTime.UtcNow.ToString("yyyyMMdd'T'HHmmss'Z'");
                var headers = GenerateHeadersForSignature(amzDate);
                string signature = GenerateSignatureV4("HEAD", _bucketName, "", date, amzDate, headers);

                var request = new HttpRequestMessage(HttpMethod.Head, $"{_endpoint}/{_bucketName}");
                request.Headers.TryAddWithoutValidation("Authorization", signature); // Используем TryAddWithoutValidation
                request.Headers.Add("x-amz-date", amzDate);
                request.Headers.Add("Host", headers["host"]);
                request.Headers.Add("x-amz-content-sha256", headers["x-amz-content-sha256"]);

                var response = await _httpClient.SendAsync(request);

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    // Создание бакета
                    date = DateTime.UtcNow.ToString("yyyyMMdd");
                    amzDate = DateTime.UtcNow.ToString("yyyyMMdd'T'HHmmss'Z'");
                    headers = GenerateHeadersForSignature(amzDate);
                    signature = GenerateSignatureV4("PUT", _bucketName, "", date, amzDate, headers);

                    request = new HttpRequestMessage(HttpMethod.Put, $"{_endpoint}/{_bucketName}");
                    request.Headers.TryAddWithoutValidation("Authorization", signature);
                    request.Headers.Add("x-amz-date", amzDate);
                    request.Headers.Add("Host", headers["host"]);
                    request.Headers.Add("x-amz-content-sha256", headers["x-amz-content-sha256"]);

                    string xml = "<CreateBucketConfiguration xmlns=\"http://s3.amazonaws.com/doc/2006-03-01/\"></CreateBucketConfiguration>";
                    request.Content = new StringContent(xml, Encoding.UTF8, "application/xml");

                    response = await _httpClient.SendAsync(request);
                    response.EnsureSuccessStatusCode();
                }
                else
                {
                    response.EnsureSuccessStatusCode();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при создании/проверке бакета: {ex.Message}");
            }
        }

        /// <summary>
        /// Проверка наличия бакета
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task CheckBucketExistsAsync()
        {
            try
            {
                string date = DateTime.UtcNow.ToString("yyyyMMdd");
                string amzDate = DateTime.UtcNow.ToString("yyyyMMdd'T'HHmmss'Z'");
                var headers = GenerateHeadersForSignature(amzDate);
                string signature = GenerateSignatureV4("HEAD", _bucketName, "", date, amzDate, headers);

                var request = new HttpRequestMessage(HttpMethod.Head, $"{_endpoint}/{_bucketName}");
                request.Headers.TryAddWithoutValidation("Authorization", signature); // Используем TryAddWithoutValidation
                request.Headers.Add("x-amz-date", amzDate);
                request.Headers.Add("Host", headers["host"]);
                request.Headers.Add("x-amz-content-sha256", headers["x-amz-content-sha256"]);

                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при создании/проверке бакета: {ex.Message}");
            }
        }

        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task UploadFileAsync(string objectName, string filePath)
        {
            try
            {
                await EnsureBucketExistsAsync();

                string date = DateTime.UtcNow.ToString("yyyyMMdd");
                string amzDate = DateTime.UtcNow.ToString("yyyyMMdd'T'HHmmss'Z'");
                string payloadHash;
                using (var fileStream = File.OpenRead(filePath))
                {
                    using (var sha256 = SHA256.Create())
                    {
                        byte[] hash = sha256.ComputeHash(fileStream);
                        payloadHash = BitConverter.ToString(hash).Replace("-", "").ToLower();
                    }
                }
                var headers = GenerateHeadersForSignature(amzDate, payloadHash);
                string signature = GenerateSignatureV4("PUT", _bucketName, objectName, date, amzDate, headers);

                using (var fileStream = File.OpenRead(filePath))
                {
                    var request = new HttpRequestMessage(HttpMethod.Put, $"{_endpoint}/{_bucketName}/{objectName}");
                    request.Headers.TryAddWithoutValidation("Authorization", signature);
                    request.Headers.Add("x-amz-date", amzDate);
                    request.Headers.Add("Host", headers["host"]);
                    request.Headers.Add("x-amz-content-sha256", payloadHash);
                    request.Content = new StreamContent(fileStream);
                    request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                    var response = await _httpClient.SendAsync(request);
                    if (!response.IsSuccessStatusCode)
                    {
                        string errorContent = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Ошибка HTTP: {response.StatusCode}, Сообщение: {errorContent}");
                    }
                    response.EnsureSuccessStatusCode();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при загрузке файла: {ex.Message}");
            }
        }

        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="bytes"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task UploadFileAsync(string objectName, byte[] bytes)
        {
            try
            {
                await EnsureBucketExistsAsync();

                string date = DateTime.UtcNow.ToString("yyyyMMdd");
                string amzDate = DateTime.UtcNow.ToString("yyyyMMdd'T'HHmmss'Z'");
                string payloadHash;
                using (var fileStream = new MemoryStream(bytes))
                {
                    using (var sha256 = SHA256.Create())
                    {
                        byte[] hash = sha256.ComputeHash(fileStream);
                        payloadHash = BitConverter.ToString(hash).Replace("-", "").ToLower();
                    }
                }
                var headers = GenerateHeadersForSignature(amzDate, payloadHash);
                string signature = GenerateSignatureV4("PUT", _bucketName, objectName, date, amzDate, headers);

                using (var fileStream = new MemoryStream(bytes))
                {
                    var request = new HttpRequestMessage(HttpMethod.Put, $"{_endpoint}/{_bucketName}/{objectName}");
                    request.Headers.TryAddWithoutValidation("Authorization", signature);
                    request.Headers.Add("x-amz-date", amzDate);
                    request.Headers.Add("Host", headers["host"]);
                    request.Headers.Add("x-amz-content-sha256", payloadHash);
                    request.Content = new StreamContent(fileStream);
                    request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                    var response = await _httpClient.SendAsync(request);
                    if (!response.IsSuccessStatusCode)
                    {
                        string errorContent = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Ошибка HTTP: {response.StatusCode}, Сообщение: {errorContent}");
                    }
                    response.EnsureSuccessStatusCode();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при загрузке файла: {ex.Message}");
            }
        }

        /// <summary>
        /// Получение файла
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task DownloadFileAsync(string objectName, string filePath)
        {
            try
            {
                var content = await DownloadFileAsync(objectName);
                using (var fileStream = File.Create(filePath))
                {
                    await content.CopyToAsync(fileStream);
                }
            }
            catch (HttpRequestException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Общая ошибка при скачивании файла: {ex.Message}");
            }
        }

        /// <summary>
        /// Получение файла
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<HttpContent> DownloadFileAsync(string objectName)
        {
            try
            {
                string date = DateTime.UtcNow.ToString("yyyyMMdd");
                string amzDate = DateTime.UtcNow.ToString("yyyyMMdd'T'HHmmss'Z'");
                var headers = GenerateHeadersForSignature(amzDate);
                string signature = GenerateSignatureV4("GET", _bucketName, objectName, date, amzDate, headers);

                var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}/{_bucketName}/{objectName}");
                request.Headers.TryAddWithoutValidation("Authorization", signature);
                request.Headers.Add("x-amz-date", amzDate);
                request.Headers.Add("Host", headers["host"]);
                request.Headers.Add("x-amz-content-sha256", headers["x-amz-content-sha256"]);

                var response = await _httpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Ошибка HTTP: {response.StatusCode}, Сообщение: {errorContent}");
                }

                response.EnsureSuccessStatusCode();

                return response.Content;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Ошибка при скачивании файла: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Общая ошибка при скачивании файла: {ex.Message}");
            }
        }

        public static async Task ExampleUsage()
        {
            try
            {
                string bucketName = "sasha";
                string region = "us-east-1";

                var storage = new MinioFileStorage(bucketName, region);

                // Загрузка файла
                string fileToUpload = "file_in.txt";
                string objectName = "file.txt";
                await storage.UploadFileAsync(objectName, fileToUpload);

                // Скачивание файла
                string downloadPath = "file_out.txt";
                await storage.DownloadFileAsync(objectName, downloadPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
