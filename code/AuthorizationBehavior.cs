using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace TechControl
{
    public class AuthorizationBehavior : IEndpointBehavior
	{
		private readonly AuthorizationMessageInspector _authorizationMessageInspector;

		public AuthorizationBehavior()
		{
			_authorizationMessageInspector = new AuthorizationMessageInspector();
		}

		public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
		{
		}

		public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
		{
			clientRuntime.MessageInspectors.Add(_authorizationMessageInspector);
		}

		public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
		{
		}

		public void Validate(ServiceEndpoint endpoint)
		{
		}
	}
}