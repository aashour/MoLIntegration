using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.ServiceModel;
using System.Text;

using Mol.Integration.Lib.Common;
using Mol.Integration.Lib.Contract.Data;
using Mol.Integration.Lib.Contract.Fault;
using Mol.Integration.Lib.Contract.Service;
using Mol.Integration.Lib.Proxies;

namespace Mol.Integration.Lib.Service
{
    public class NICService : INICService
    {
        public bool CancelVisa(double requestNumber, double borderNumber)
        {
            UpdateLaborVisaResponse response = null;
            try
            {
                ServicePointManager.ServerCertificateValidationCallback += 
                    (sender, certificate, chain, sslPolicyErrors) => { return true; };
                ServiceUtilities<IMOL_SERVICEChannel>.Use(
                    client => response = client.UpdateLaborVisa(
                        new UpdateLaborVisaRequest(
                        new NICHeader()
                        {
                            password = Constants.NIC_Password,
                            username = Constants.NIC_UserName
                        }
                        , requestNumber
                        , borderNumber
                        , Constants.NIC_ClientIP
                        , Constants.NIC_Lang)));

                return response != null ? response.UpdateLaborVisaResult : false;
            }
            catch (FaultException<SamisWSFault> fault)
            {
                NICFaultContract err = new NICFaultContract();
                err.RaisedBy = "NIC Service";
                if (fault.CreateMessageFault().HasDetail)
                {
                    if (fault.Detail.ErrorCode == 25)
                        return true;
                }
                HandleError(err, null, fault);

            }
            catch (Exception ex)
            {
                NICFaultContract err = new NICFaultContract();
                err.RaisedBy = "MOL NIC Service";
                HandleError(err, ex, null);

            }
            return false;
        }

        public DependentsData QueryDependentsByID(double IdNo)
        {
            DependentsData result = new DependentsData();
            try
            {
                GetAlienVisitorInfoResponse response = null;
                ServiceAuthentication auth = new ServiceAuthentication()
                {
                    AgencyId = Constants.NIC_AgencyId,
                    ExtensionData = null,
                    AgencyPasspword = Constants.NIC_AgencyPassword,
                    ClientIpAddress = Constants.NIC_ClientIP,
                    Lang = Constants.NIC_Lang,
                    LocationId = Constants.NIC_LocationID,
                    OperatorID = Constants.NIC_OperatorID,
                    ServiceID = Constants.NIC_ServiceID,
                    SeviceProviderID = Constants.NIC_SeviceProviderID
                };

                NICHeader header = new NICHeader()
                {
                    password = Constants.NIC_Password,
                    username = Constants.NIC_UserName
                };

                ServiceUtilities<IMOL_SERVICEChannel>.Use(client => response = client.GetAlienVisitorInfo(new GetAlienVisitorInfoRequest(header, IdNo, auth)));

                if (null != response)
                {
                    result = response.GetAlienVisitorInfoResult.ToDependentsData();
                }
            }
            catch (FaultException<SamisWSFault> fault)
            {
                NICFaultContract err = new NICFaultContract();
                err.RaisedBy = "NIC Service";
                if (fault.CreateMessageFault().HasDetail)
                {
                    if (fault.Detail.ErrorCode == 25)
                        return result;
                }
                HandleError(err, null, fault);
            }
            catch (Exception ex)
            {
                NICFaultContract err = new NICFaultContract();
                err.RaisedBy = "MOL NIC Service";
                HandleError(err, ex, null);
            }
            return result;
        }

        public bool GetLabrorPrisonStatus(double IdNo)
        {
            bool result = false;
            try
            {
                GetAlienPrisonStatusResponse response = null;
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => { return true; };

                ServiceUtilities<IMOL_SERVICEChannel>.Use(client => response = client.GetAlienPrisonStatus(new GetAlienPrisonStatusRequest(new NICHeader()
                        {
                            username = Constants.NIC_UserName,
                            password = Constants.NIC_Password
                        },
                        IdNo,
                        Constants.NIC_ClientIP,
                        Constants.NIC_OperatorID)));

                result = response.GetAlienPrisonStatusResult;
            }
            catch (FaultException<SamisWSFault> fault)
            {
                NICFaultContract err = new NICFaultContract();
                err.RaisedBy = "NIC Service";
                HandleError(err, null, fault);
            }
            catch (Exception ex)
            {
                NICFaultContract err = new NICFaultContract();
                err.RaisedBy = "MOL NIC Service";
                HandleError(err, ex, null);
            }
            return result;
        }

        public bool AuthenticateUserByMobile(double IdNo, string smsCode)
        {
            bool result = false;
            try
            {

                AuthenticateUserByMobileResponse response = null;
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => { return true; };
                ServiceUtilities<IMOL_SERVICEChannel>.Use(client => response = client.AuthenticateUserByMobile(new AuthenticateUserByMobileRequest(
                     new NICHeader()
                     {
                         username = Constants.NIC_UserName,
                         password = Constants.NIC_Password
                     },
                        IdNo, smsCode,
                        Constants.NIC_ClientIP,
                        Constants.NIC_Lang
                    )));

                result = response.AuthenticateUserByMobileResult;
            }
            catch (FaultException<SamisWSFault> fault)
            {
                NICFaultContract err = new NICFaultContract();
                err.RaisedBy = "NIC Service";
                HandleError(err, null, fault);
            }
            catch (Exception ex)
            {
                NICFaultContract err = new NICFaultContract();
                err.RaisedBy = "MOL NIC Service";
                HandleError(err, ex, null);
            }
            return result;
        }

        private void HandleError(NICFaultContract err, Exception ex, FaultException<SamisWSFault> fault)
        {
            err.ErrorCode = err.RaisedBy == "NIC Service" ? "12" : "11";
            err.ErrorMessage = "message";
            throw new FaultException<NICFaultContract>(err, new FaultReason(ex.Message));
        }
       

    }
}
