using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Mol.Integration.Lib.Common
{
    class Constants
    {
        const string NIC_CLIENTIP_KEY = "NIC_ClientIpAddress";
        const string NIC_LANG_KEY = "NIC_lang";
        const string NIC_PASSWORD_KEY = "NIC_Password";
        const string NIC_USERNAME_KEY = "NIC_UserName";


        const string NIC_AGENCYID_KEY = "NIC_AgencyId";
        const string NIC_AGENCY_PASSWORD_KEY = "NIC_AgencyPassword";
        const string NIC_LOCATIONID_KEY = "NIC_LocationId";
        const string NIC_OPERATORID_KEY = "NIC_OperatorID";
        const string NIC_SERVICEID_KEY = "NIC_ServiceID";
        const string NIC_SEVICE_PROVIDERID_KEY = "NIC_SeviceProviderID";

        public static string NIC_ClientIP
        {
            get
            {
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings[NIC_CLIENTIP_KEY]))
                    return ConfigurationManager.AppSettings[NIC_CLIENTIP_KEY];
                return "10.8.3.52";
            }
        }

        public static string NIC_Lang
        {
            get
            {
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings[NIC_LANG_KEY]))
                    return ConfigurationManager.AppSettings[NIC_LANG_KEY];
                return "ar";
            }
        }

        public static string NIC_Password
        {
            get
            {
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings[NIC_PASSWORD_KEY]))
                    return ConfigurationManager.AppSettings[NIC_PASSWORD_KEY];
                return "imol@service123user";
            }
        }

        public static string NIC_UserName
        {
            get
            {
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings[NIC_USERNAME_KEY]))
                    return ConfigurationManager.AppSettings[NIC_USERNAME_KEY];
                return "IMOL_SERVICEuser";
            }
        }



        public static double NIC_AgencyId
        {
            get
            {
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings[NIC_AGENCYID_KEY]))
                    return double.Parse(ConfigurationManager.AppSettings[NIC_AGENCYID_KEY]);
                return 7001415350;
            }
        }

        public static string NIC_AgencyPassword
        {
            get
            {
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings[NIC_AGENCY_PASSWORD_KEY]))
                    return ConfigurationManager.AppSettings[NIC_AGENCY_PASSWORD_KEY];
                return "12345678";
            }
        }

        public static int NIC_LocationID
        {
            get
            {
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings[NIC_LOCATIONID_KEY]))
                    return int.Parse(ConfigurationManager.AppSettings[NIC_LOCATIONID_KEY]);
                return 1972;
            }
        }

        public static double NIC_OperatorID
        {
            get
            {
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings[NIC_OPERATORID_KEY]))
                    return double.Parse(ConfigurationManager.AppSettings[NIC_OPERATORID_KEY]);
                return 1000151025;
            }
        }

        public static int NIC_ServiceID
        {
            get
            {
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings[NIC_SERVICEID_KEY]))
                    return int.Parse(ConfigurationManager.AppSettings[NIC_SERVICEID_KEY]);
                return 5;
            }
        }

        public static double NIC_SeviceProviderID
        {
            get
            {
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings[NIC_SEVICE_PROVIDERID_KEY]))
                    return double.Parse(ConfigurationManager.AppSettings[NIC_SEVICE_PROVIDERID_KEY]);
                return 7000986278;
            }
        }
    }
}
