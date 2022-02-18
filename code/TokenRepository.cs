using System;
using TechControl.ServiceReferenceAuthorization;

namespace TechControl
{
    public static class TokenRepository
	{
		private static string _token;
		private static readonly SpicAuthorizationSoapServiceClient ServiceClient;

		static TokenRepository()
		{
			ServiceClient = new SpicAuthorizationSoapServiceClient();
		}

		//пробуем авторизоваться по данным в запросе. 
		private static void Login()
		{
			var authRequest = new SpicAuthorizationRequest
			{
				Login = "skvortsov@titan002.ru",
				Password = "skvortsov@titan002.ru",
				TimeStampUtc = DateTime.UtcNow,
				CultureName = "ru-RU",
				TimeZoneOlsonId = "Europe/Moscow",
				UiCultureName = "ru-RU"
			};

			SpicAuthorizationResponse authResponse = ServiceClient.LoginAsync(authRequest).GetAwaiter().GetResult();
			if (authResponse == null) throw new Exception("Unauthorized");

			_token = authResponse.SessionId;
		}

		//Если токен уже есть - логинимся. 
		public static string GetToken()
		{
			if (string.IsNullOrEmpty(_token))
				Login();

			return _token;
		}
	}
}