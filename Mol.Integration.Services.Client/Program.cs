using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using Mol.Integration.Services.Client.NICServiceReference;

namespace Mol.Integration.Services.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var directive = string.Empty;
            do
            {
                try
                {
                    Console.WriteLine("Enter method number:");
                    directive = Console.ReadLine();
                    DependentsData name = null;
                    switch (directive)
                    {
                        case "1":
                            Console.WriteLine("from configuration:\n");
                            NICServiceClient c = new NICServiceClient();
                            //c.ClientCredentials.UserName.UserName = "tamkeen";
                            //c.ClientCredentials.UserName.Password = "123";
                            //c.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
                            name = c.QueryDependentsByID(2337528299);
                            Console.WriteLine("Name:{0}", name.Name.FullName);
                            break;
                        case "2":
                            Console.WriteLine("Creating the client by creating endpoint and binding through coding:\n");
                            var ServiceendPoint = new EndpointAddress(new Uri("http://172.26.20.52:9510/NICService.svc"),
                                                  EndpointIdentity.CreateDnsIdentity("biztalk-srv3"));
                            var binding = new WSHttpBinding();
                            binding.Security.Mode = SecurityMode.Message;
                            binding.Security.Message.ClientCredentialType = MessageCredentialType.UserName;

                            var result = new NICServiceClient(binding, ServiceendPoint);
                            result.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
                            result.ClientCredentials.UserName.UserName = "tamkeen";
                            result.ClientCredentials.UserName.Password = "123";
                            name = result.QueryDependentsByID(2337528299);
                            Console.WriteLine("Name:{0}", name.Name.FullName);
                            break;
                        case "3":
                            Console.WriteLine("Creating the client by creating endpoint and binding through coding:\n");
                            name = NewClient().QueryDependentsByID(2337528299);
                            Console.WriteLine("Name:{0}", name.Name.FullName);
                            break;
                        default:
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine(ex.InnerException.Message);
                    }
                }
                Console.ReadLine();
            } while (directive != "0");
        }

        public static INICService NewClient()
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Message.ClientCredentialType = MessageCredentialType.UserName;

            //EndpointIdentity identity = EndpointIdentity.CreateDnsIdentity("biztalk-srv3");
            EndpointIdentity identity = EndpointIdentity.CreateDnsIdentity("biztalk-srv3");
            EndpointAddress address = new EndpointAddress(new Uri("http://172.26.20.52:9510/NICService.svc"), identity);
            ChannelFactory<INICService> factory = new ChannelFactory<INICService>(binding, address);
            factory.Credentials.UserName.UserName = "tamkeen";
            factory.Credentials.UserName.Password = "123";
            factory.Credentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;

            return factory.CreateChannel();
        }
    }
}
