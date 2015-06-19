using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;

namespace Mol.Integration.Lib.Binding
{
    public class AutoSecuredHttpTransportElement : HttpTransportBindingElement,
                         ITransportTokenAssertionProvider
    {
        public override T GetProperty<T>(BindingContext context)
        {
            if (typeof(T) == typeof(ISecurityCapabilities))
                return (T)(ISecurityCapabilities)new AutoSecuredHttpSecurityCapabilities();

            return base.GetProperty<T>(context);
        }

        public System.Xml.XmlElement GetTransportTokenAssertion()
        {
            return null;
        }
    }
}
