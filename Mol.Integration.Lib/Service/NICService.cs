using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.ServiceModel;
using System.Text;
using Mol.Integration.IntegrationProxy.NicWebService;
using Mol.Integration.Lib.Common;
using Mol.Integration.Lib.Contract.Data;
using Mol.Integration.Lib.Contract.Fault;
using Mol.Integration.Lib.Contract.Service;

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
                    result = AlienVisitorInfoResultToDependentsData(response.GetAlienVisitorInfoResult);
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

        public string Test(string Name)
        {
            return string.Format("you name is {0}", Name);
        }

        private void HandleError(NICFaultContract err, Exception ex, FaultException<SamisWSFault> fault)
        {
            err.ErrorCode = err.RaisedBy == "NIC Service" ? "12" : "11";
            err.ErrorMessage = "message";
            throw new FaultException<NICFaultContract>(err, new FaultReason(ex.Message));
        }
        private DependentsData AlienVisitorInfoResultToDependentsData(QueryDependentsByID_NSMol data)
        {
            int entryDateHegira = 0;
            if (!string.IsNullOrEmpty(data.EntryDateHegira) && int.TryParse(data.EntryDateHegira, out entryDateHegira))
                entryDateHegira = int.Parse(data.EntryDateHegira);
            if (!string.IsNullOrEmpty(data.EntryDateHegira) && Dates.HijriToGreg(data.EntryDateHegira).HasValue && Dates.GregToHijri(Dates.HijriToGreg(data.EntryDateHegira).Value, "MM/dd/yyyy").HasValue)
                entryDateHegira = int.Parse(Dates.GregToHijri(Dates.HijriToGreg(data.EntryDateHegira).Value, "MM/dd/yyyy").Value.ToString("yyyyMMdd"));

            DateTime visaExpiryDateGreg = new DateTime();
            //if (!string.IsNullOrEmpty(data.VisaExpiryDateGreg))
            //    DateTime.TryParse(data.VisaExpiryDateGreg, out visaExpiryDateGreg);

            return new DependentsData()
            {
                BirthDate = new DateStructure()
                {
                    GregorianDate = data.BirthDateGreg,
                    HijriDate = data.BirthDateHegira.ToString()
                },
                Travel = new TravelStructure
                {
                    EntryDate = new DateStructure
                    {
                        //GregorianDate = data.EntryDateGreg.IsMinDate() ? (DateTime?)null : (DateTime?)data.EntryDateGreg,
                        GregorianDate = data.EntryDateGreg,
                        HijriDate = entryDateHegira.ToString()
                    },
                    LastEntryDate = new DateStructure
                    {
                        GregorianDate = data.LastEntryDateGreg,
                        HijriDate = data.LastEntryDateHegira
                    },
                    LastExitDate = new DateStructure
                    {
                        GregorianDate = data.LastExitDateGreg,
                        HijriDate = data.LastExitDateHegira
                    },
                    PassportExpiryDate = new DateStructure
                    {
                        GregorianDate = data.PassportExpiryDateGreg,
                        HijriDate = data.PassportExpiryDateHegira
                    },
                    TravelStatus = data.travelStatus
                },
                Residency = new ResidencyStructure
                {
                    IdNo = data.Id,
                    IdType = data.IdType,
                    ExpiryDate = new DateStructure
                    {
                        GregorianDate = data.ResidencyExpiryDateGreg,
                        HijriDate = data.ResidencyExpiryDateHegira.ToString()
                    },
                    IssueDate = new DateStructure
                    {
                        GregorianDate = data.ResidencyIssueDateGreg,
                        HijriDate = data.ResidencyIssueDateHegira.ToString()
                    },
                    IssuePlace = data.ResidencyIssuePlace
                },
                Name = new NameStructure
                {
                    FullName = !string.IsNullOrEmpty(data.Name) ? data.Name.Trim() : string.Empty,
                    FirstName = !string.IsNullOrEmpty(data.FirstName) ? data.FirstName.Trim() : string.Empty,
                    SecondName = !string.IsNullOrEmpty(data.SecondName) ? data.SecondName.Trim() : string.Empty,
                    ThirdName = !string.IsNullOrEmpty(data.ThirdName) ? data.ThirdName.Trim() : string.Empty,
                    LastName = !string.IsNullOrEmpty(data.LastName) ? data.LastName.Trim() : string.Empty,
                    TranslatedName = new NameStructure()
                    {
                        FullName = !string.IsNullOrEmpty(data.TranslatedName) ? data.TranslatedName.Trim() : string.Empty,
                        FirstName = !string.IsNullOrEmpty(data.FirstNameT) ? data.FirstNameT.Trim() : string.Empty,
                        SecondName = !string.IsNullOrEmpty(data.SecondNameT) ? data.SecondNameT.Trim() : string.Empty,
                        ThirdName = !string.IsNullOrEmpty(data.ThirdNameT) ? data.ThirdNameT.Trim() : string.Empty,
                        LastName = !string.IsNullOrEmpty(data.LastNameT) ? data.LastNameT.Trim() : string.Empty,
                    }
                },
                Religion = new LookupStructure
                {
                    Name = !string.IsNullOrEmpty(data.Religion) ? data.Religion.Trim() : string.Empty,
                    Code = data.ReligionCode
                },
                Nationality = new LookupStructure
                {
                    Name = !string.IsNullOrEmpty(data.Nationality) ? data.Nationality.Trim() : string.Empty,
                    Code = data.NationalityCode
                },
                Occupation = new LookupStructure
                {
                    Name = !string.IsNullOrEmpty(data.Occupation) ? data.Occupation.Trim() : string.Empty,
                    Code = data.OccupationCode
                },
                MaritalStatus = new LookupStructure
                {
                    Name = !string.IsNullOrEmpty(data.MaritalStatus) ? data.MaritalStatus.Trim() : string.Empty,
                    Code = data.MaritalStatusCode
                },
                Relationship = new LookupStructure
                {
                    Name = !string.IsNullOrEmpty(data.Relationship) ? data.Relationship.Trim() : string.Empty,
                    Code = data.RelationshipCode
                },
                Gender = !string.IsNullOrEmpty(data.Sex) ? data.Sex.Trim() : string.Empty,
                Sponsor = new SponsorStructure
                {
                    IdNo = data.SponsorId,
                    Name = !string.IsNullOrEmpty(data.SponsorName) ? data.SponsorName.Trim() : string.Empty,
                    Occupation = !string.IsNullOrEmpty(data.SponsorOccupation) ? data.SponsorOccupation.Trim() : string.Empty,
                    Status = !string.IsNullOrEmpty(data.SponsorStatus) ? data.SponsorStatus.Trim() : string.Empty,
                    Type = new LookupStructure
                    {
                        Name = data.SponsorType,
                        Code = data.SponsorTypeCode,
                    },
                },
                Status = new StatusStructure
                {
                    FingerPrintStatus = data.FingerPrintStatus,
                    PrisonerStatus = data.Id.ToString().StartsWith("2") && this.GetLabrorPrisonStatus(data.Id),
                    PersonStatus = new LookupStructure
                    {
                        Name = !string.IsNullOrEmpty(data.Status) ? data.Status.Trim() : string.Empty,
                        Code = data.StatusCode,
                    }
                },
                Visa = new VisaStructure
                {
                    VisaType = data.VisaType,
                    VisaExpiryDate = new DateStructure
                    {
                        GregorianDate = visaExpiryDateGreg,
                        HijriDate = data.VisaExpiryDateHegira
                    },
                    FinalExitVisaIssued = data.FinalExitViasaIssued
                },
            };
        }


    }
}
