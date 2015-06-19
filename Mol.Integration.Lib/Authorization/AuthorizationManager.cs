using System.Collections.ObjectModel;
using System.IdentityModel.Policy;
using System.IdentityModel.Tokens;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml;
using System.Xml.XPath;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Mol.Integration.Lib.Authorization
{
    public class AuthorizationManager : ServiceAuthorizationManager
    {
        public override bool CheckAccess(OperationContext operationContext, ref Message message)
        {

            base.CheckAccess(operationContext, ref message);

            if (operationContext.ServiceSecurityContext.IsAnonymous)
                return true;

            //Extract the identity token of the current context user making the call to this service 
            IIdentity Identity = operationContext.ServiceSecurityContext.PrimaryIdentity;
            //Prior to proceeding, throw an exception if the user has not been authenticated at all 
            if (!Identity.IsAuthenticated)
                throw new SecurityTokenValidationException("Service Authorization can not be done for unauthenticated user.");

            //we consider using the username as the role
            return (GetPrincipal(operationContext) != null && GetPrincipal(operationContext).IsInRole("*"));
        }

        private IPrincipal GetPrincipal(OperationContext operationContext)
        {
            return operationContext.ServiceSecurityContext.AuthorizationContext.Properties["Principal"] as CustomPrincipal;
        }

        // rest omitted
    }
}
