using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;

namespace Mol.Integration.Lib.Binding
{
    public class ClearUsernameBinding : CustomBinding
    {
        private MessageVersion messageVersion = MessageVersion.None;

        public void SetMessageVersion(MessageVersion value)
        {
            this.messageVersion = value;
        }

        public override BindingElementCollection CreateBindingElements()
        {
            var res = new BindingElementCollection();
            res.Add(new TextMessageEncodingBindingElement() { MessageVersion = this.messageVersion });
            res.Add(SecurityBindingElement.CreateUserNameOverTransportBindingElement());
            res.Add(new AutoSecuredHttpTransportElement());
            return res;
        }

        public override string Scheme
        {
            get
            {
                return "http";
            }
        }
    }
}
