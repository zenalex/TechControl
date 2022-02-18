using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;

namespace TechControl
{
    public class AuthorizationMessageInspector : IClientMessageInspector
	{
		public void AfterReceiveReply(ref Message reply, object correlationState)
		{
		}

		/// <summary>
		///     Производим добавление хэдеров перед тем, как отправить запрос.
		/// </summary>
		public object BeforeSendRequest(ref Message request, System.ServiceModel.IClientChannel channel)
		{
			if (!request.Properties.ContainsKey("httpRequest"))
			{
				request.Properties.Add("httpRequest", new HttpRequestMessageProperty());
			}

			var token = TokenRepository.GetToken();

			var httpHeader = request.Properties["httpRequest"] as HttpRequestMessageProperty;
			if (httpHeader != null && !string.IsNullOrEmpty(token))
			{
				httpHeader.Headers.Add("ScoutAuthorization", token);
			}

			return null;
		}
	}
}