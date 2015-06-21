using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Text;

namespace Mol.Integration.Lib.Binding
{
    public class UserNameClientCredentialsElement : ClientCredentialsElement
    {
        private ConfigurationPropertyCollection properties;

        public override Type BehaviorType
        {
            get { return typeof(ClientCredentials); }
        }


        /// <summary>
        /// Username (required)
        /// </summary>
        [Description(""), Category("(General)")]
        [ConfigurationProperty("UserName", DefaultValue = "")]
        [StringValidator(MinLength = 1)]
        public string UserName
        {
            get { return (string)base["userName"]; }
            set { base["userName"] = value; }
        }

        /// <summary>
        /// Password (optional)
        /// </summary>
        [ConfigurationProperty("Password", DefaultValue = "")]
        [Browsable(true)]
        public string Password
        {
            get { return (string)base["password"]; }
            set { base["password"] = value; }
        }


        public override void CopyFrom(ServiceModelExtensionElement from)
        {
            base.CopyFrom(from);
            UserNameClientCredentialsElement source = (UserNameClientCredentialsElement)from;
            this.UserName = source.UserName;
            this.Password = source.Password;

        }
        protected override ConfigurationPropertyCollection Properties
        {
            get
            {
                if (properties == null)
                {
                    ConfigurationPropertyCollection baseProps = base.Properties;
                    baseProps.Add(new ConfigurationProperty(
                                      "userName",
                                      typeof(String),
                                      null,
                                      null,
                                      new StringValidator(1),
                                      ConfigurationPropertyOptions.IsRequired));
                    baseProps.Add(new ConfigurationProperty(
                                      "password",
                                      typeof(String),
                                      ""));
                    properties = baseProps;
                }
                return properties;
            }
        }


        protected override object CreateBehavior()
        {
            var creds = (ClientCredentials)base.CreateBehavior();
            creds.UserName.UserName = UserName;
            if (Password != null)
                creds.UserName.Password = Password;
            ApplyConfiguration(creds);
            return creds;
        }
    }

}
