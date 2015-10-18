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
using Mol.Integration.Lib.Common;
using System.IO;
using Mol.Integration.Lib.Data;

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
            IIdentity identity = operationContext.ServiceSecurityContext.PrimaryIdentity;

            //Prior to proceeding, throw an exception if the user has not been authenticated at all 
            if (!identity.IsAuthenticated)
                throw new SecurityTokenValidationException("Service Authorization can not be done for unauthenticated user.");

            //we consider using the username as the role
            var authorized = (GetPrincipal(operationContext) != null && GetPrincipal(operationContext).IsInRole("*"));

            if (Constants.LoggingEnabled)
                LogUserAction(operationContext, identity, message, authorized);

            return authorized;
        }

        private void LogUserAction(OperationContext operationContext, IIdentity identity, Message message, bool authorized)
        {

            string contract = OperationContext.Current.EndpointDispatcher.ContractName;
            string operation = string.Empty;
            foreach (var item in OperationContext.Current.EndpointDispatcher.DispatchRuntime.Operations)
            {
                if (item.Action == OperationContext.Current.IncomingMessageHeaders.Action)
                {
                    operation = item.Name;
                    break;
                }
            }
            string msg = string.Empty;
            XmlDocument doc = new XmlDocument();
            using (MemoryStream ms = new MemoryStream())
            {
                using (XmlWriter w = XmlWriter.Create(ms, new XmlWriterSettings { Indent = true, IndentChars = "  ", OmitXmlDeclaration = true }))
                {
                    using (XmlDictionaryReader bodyReader = message.GetReaderAtBodyContents())
                    {
                        w.WriteStartElement("s", "Body", "http://schemas.xmlsoap.org/soap/envelope/");
                        while (bodyReader.NodeType != XmlNodeType.EndElement && !bodyReader.LocalName.Equals("body", System.StringComparison.InvariantCultureIgnoreCase) && !bodyReader.NamespaceURI.Equals("http://schemas.xmlsoap.org/soap/envelope/", System.StringComparison.InvariantCultureIgnoreCase))
                        {
                            if (bodyReader.NodeType != XmlNodeType.Whitespace)
                                w.WriteNode(bodyReader, true);
                            else
                                bodyReader.Read(); // ignore whitespace; maintain if you want
                        }
                        w.WriteEndElement();
                        w.Flush();
                        ms.Position = 0;
                        doc.Load(ms);
                    }
                }
            }
            IntegrationServiceRepo repo = new IntegrationServiceRepo();
            repo.InsertLog(identity.Name, authorized, operation, contract, doc.InnerXml);
        }

        private IPrincipal GetPrincipal(OperationContext operationContext)
        {
            return operationContext.ServiceSecurityContext.AuthorizationContext.Properties["Principal"] as CustomPrincipal;
        }
    }
}
