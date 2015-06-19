using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace Mol.Integration.Lib.Authorization
{
    public class CustomIdentity : IIdentity
    {

        private string m_name;

        public CustomIdentity(string name)
        {
            this.m_name = name;
        }

        string IIdentity.AuthenticationType
        {
            get
            {
                return "AuthorizationPolicy";
            }
        }

        bool IIdentity.IsAuthenticated
        {
            get
            {
                return true;
            }
        }

        string IIdentity.Name
        {
            get
            {
                return m_name;
            }
        }

    }
}
