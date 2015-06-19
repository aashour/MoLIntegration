using System;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ComponentModel;
using System.ServiceModel.Configuration;
using System.Globalization;


namespace Mol.Integration.Lib.Binding
{
    class ClearUsernameBindingElement : StandardBindingElement
    {
        private ConfigurationPropertyCollection properties;

        protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding)
        {
            ClearUsernameBinding b = binding as ClearUsernameBinding;
            b.SetMessageVersion(MessageVersion);
        }

        protected override Type BindingElementType
        {
            get { return typeof(ClearUsernameBinding); }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get
            {
                if (this.properties == null)
                {
                    ConfigurationPropertyCollection properties = base.Properties;
                    properties.Add(new ConfigurationProperty("messageVersion", typeof(MessageVersion), MessageVersion.Soap11, new MessageVersionConverter(), null, ConfigurationPropertyOptions.None));
                    this.properties = properties;
                }
                return this.properties;
            }
        }

        public MessageVersion MessageVersion
        {
            get
            {
                return (MessageVersion)base["messageVersion"];
            }
            set
            {
                base["messageVersion"] = value;
            }
        }
    }

    internal class ClearUsernameCollectionElement : StandardBindingCollectionElement<ClearUsernameBinding, ClearUsernameBindingElement>
    {
    }
}
