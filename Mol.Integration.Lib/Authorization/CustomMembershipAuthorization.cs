using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading;

namespace Mol.Integration.Lib.Authorization
{
    public class CustomMembershipAuthorization : Attribute, IOperationBehavior, IParameterInspector
    {
        public string AllowedRole { get; set; }

        public CustomMembershipAuthorization()
        {
        }

        public CustomMembershipAuthorization(string allowedRole)
        {
            AllowedRole = allowedRole;
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        {
            dispatchOperation.ParameterInspectors.Add(this);
        }

        public void AfterCall(string operationName, object[] outputs,
                              object returnValue, object correlationState)
        {
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            if (!Thread.CurrentPrincipal.IsInRole(AllowedRole))
            {
                //if (WebOperationContext.Current != null)
                //    WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Unauthorized;

                //throw new WebFaultException<string>("Unauthorized", HttpStatusCode.Unauthorized);
            }

            return null;
        }

        public void AddBindingParameters(OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        {
        }

        public void Validate(OperationDescription operationDescription)
        {
        }

    }
}
