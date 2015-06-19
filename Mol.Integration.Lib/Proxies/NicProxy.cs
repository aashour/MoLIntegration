namespace Mol.Integration.Lib.Proxies
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "NICHeader", Namespace = "http://NicWebServiceHeader")]
    public partial class NICHeader : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string passwordField;

        private string usernameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IstiqdamFull", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class IstiqdamFull : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.Collections.Generic.List<Mol.Integration.Lib.Proxies.IstiqdamRequestCategoryFull> IstiqdamRequestCategoryFullField;

        private Mol.Integration.Lib.Proxies.IstiqdamSummaryFull IstiqdamSummaryFullField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Mol.Integration.Lib.Proxies.IstiqdamRequestCategoryFull> IstiqdamRequestCategoryFull
        {
            get
            {
                return this.IstiqdamRequestCategoryFullField;
            }
            set
            {
                this.IstiqdamRequestCategoryFullField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mol.Integration.Lib.Proxies.IstiqdamSummaryFull IstiqdamSummaryFull
        {
            get
            {
                return this.IstiqdamSummaryFullField;
            }
            set
            {
                this.IstiqdamSummaryFullField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IstiqdamSummaryFull", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class IstiqdamSummaryFull : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.DateTime RequestDateGField;

        private string RequestDateHField;

        private string RequestIssueLocationField;

        private double RequestNumberField;

        private double RquestsponsorIdField;

        private int TotalVisaRequestedField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RequestDateG
        {
            get
            {
                return this.RequestDateGField;
            }
            set
            {
                this.RequestDateGField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequestDateH
        {
            get
            {
                return this.RequestDateHField;
            }
            set
            {
                this.RequestDateHField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequestIssueLocation
        {
            get
            {
                return this.RequestIssueLocationField;
            }
            set
            {
                this.RequestIssueLocationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RequestNumber
        {
            get
            {
                return this.RequestNumberField;
            }
            set
            {
                this.RequestNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RquestsponsorId
        {
            get
            {
                return this.RquestsponsorIdField;
            }
            set
            {
                this.RquestsponsorIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalVisaRequested
        {
            get
            {
                return this.TotalVisaRequestedField;
            }
            set
            {
                this.TotalVisaRequestedField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IstiqdamRequestCategoryFull", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class IstiqdamRequestCategoryFull : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.Collections.Generic.List<Mol.Integration.Lib.Proxies.IstiqdamRequestMemberFull> MembersListFullField;

        private double NationalityCodeField;

        private string NationalityRequestedField;

        private double OccupationCodeField;

        private string OccupationRequestedField;

        private double RequestNumberField;

        private int RequestNumberOfVisasField;

        private string RequestReasonField;

        private string SexField;

        private double SexCodeField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Mol.Integration.Lib.Proxies.IstiqdamRequestMemberFull> MembersListFull
        {
            get
            {
                return this.MembersListFullField;
            }
            set
            {
                this.MembersListFullField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double NationalityCode
        {
            get
            {
                return this.NationalityCodeField;
            }
            set
            {
                this.NationalityCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NationalityRequested
        {
            get
            {
                return this.NationalityRequestedField;
            }
            set
            {
                this.NationalityRequestedField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double OccupationCode
        {
            get
            {
                return this.OccupationCodeField;
            }
            set
            {
                this.OccupationCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OccupationRequested
        {
            get
            {
                return this.OccupationRequestedField;
            }
            set
            {
                this.OccupationRequestedField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RequestNumber
        {
            get
            {
                return this.RequestNumberField;
            }
            set
            {
                this.RequestNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RequestNumberOfVisas
        {
            get
            {
                return this.RequestNumberOfVisasField;
            }
            set
            {
                this.RequestNumberOfVisasField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequestReason
        {
            get
            {
                return this.RequestReasonField;
            }
            set
            {
                this.RequestReasonField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sex
        {
            get
            {
                return this.SexField;
            }
            set
            {
                this.SexField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SexCode
        {
            get
            {
                return this.SexCodeField;
            }
            set
            {
                this.SexCodeField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IstiqdamRequestMemberFull", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class IstiqdamRequestMemberFull : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private int ActualFeesField;

        private System.DateTime ArrivalDateGField;

        private string ArrivalDateHField;

        private string ArrivalPlaceField;

        private double BorderNumberField;

        private string NameField;

        private string RequestStatusField;

        private System.DateTime VisaDateGField;

        private string VisaDateHField;

        private string VisaIssuePlaceField;

        private double VisaNumberField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ActualFees
        {
            get
            {
                return this.ActualFeesField;
            }
            set
            {
                this.ActualFeesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ArrivalDateG
        {
            get
            {
                return this.ArrivalDateGField;
            }
            set
            {
                this.ArrivalDateGField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ArrivalDateH
        {
            get
            {
                return this.ArrivalDateHField;
            }
            set
            {
                this.ArrivalDateHField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ArrivalPlace
        {
            get
            {
                return this.ArrivalPlaceField;
            }
            set
            {
                this.ArrivalPlaceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double BorderNumber
        {
            get
            {
                return this.BorderNumberField;
            }
            set
            {
                this.BorderNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequestStatus
        {
            get
            {
                return this.RequestStatusField;
            }
            set
            {
                this.RequestStatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime VisaDateG
        {
            get
            {
                return this.VisaDateGField;
            }
            set
            {
                this.VisaDateGField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisaDateH
        {
            get
            {
                return this.VisaDateHField;
            }
            set
            {
                this.VisaDateHField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisaIssuePlace
        {
            get
            {
                return this.VisaIssuePlaceField;
            }
            set
            {
                this.VisaIssuePlaceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double VisaNumber
        {
            get
            {
                return this.VisaNumberField;
            }
            set
            {
                this.VisaNumberField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "RegisterIstiqdamRequest", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class RegisterIstiqdamRequest : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private double FollowUpNumberField;

        private string IstikdamCategioryField;

        private short IstikdamCategioryCodeField;

        private short IstikdamOfficeField;

        private short MolFileLocationField;

        private double MolFileNumberField;

        private double MolRefNumberField;

        private System.Collections.Generic.List<Mol.Integration.Lib.Proxies.RegisterIstiqdamCategory> RegisterIstiqdamCategoryField;

        private System.DateTime RequestDateGField;

        private string RequestDateHField;

        private string RequesterNameField;

        private string RequesterStatusField;

        private int RequiredAmountField;

        private short RowErrorField;

        private short TotalVisaReuqestedField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double FollowUpNumber
        {
            get
            {
                return this.FollowUpNumberField;
            }
            set
            {
                this.FollowUpNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IstikdamCategiory
        {
            get
            {
                return this.IstikdamCategioryField;
            }
            set
            {
                this.IstikdamCategioryField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short IstikdamCategioryCode
        {
            get
            {
                return this.IstikdamCategioryCodeField;
            }
            set
            {
                this.IstikdamCategioryCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short IstikdamOffice
        {
            get
            {
                return this.IstikdamOfficeField;
            }
            set
            {
                this.IstikdamOfficeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short MolFileLocation
        {
            get
            {
                return this.MolFileLocationField;
            }
            set
            {
                this.MolFileLocationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MolFileNumber
        {
            get
            {
                return this.MolFileNumberField;
            }
            set
            {
                this.MolFileNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MolRefNumber
        {
            get
            {
                return this.MolRefNumberField;
            }
            set
            {
                this.MolRefNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Mol.Integration.Lib.Proxies.RegisterIstiqdamCategory> RegisterIstiqdamCategory
        {
            get
            {
                return this.RegisterIstiqdamCategoryField;
            }
            set
            {
                this.RegisterIstiqdamCategoryField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RequestDateG
        {
            get
            {
                return this.RequestDateGField;
            }
            set
            {
                this.RequestDateGField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequestDateH
        {
            get
            {
                return this.RequestDateHField;
            }
            set
            {
                this.RequestDateHField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequesterName
        {
            get
            {
                return this.RequesterNameField;
            }
            set
            {
                this.RequesterNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequesterStatus
        {
            get
            {
                return this.RequesterStatusField;
            }
            set
            {
                this.RequesterStatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RequiredAmount
        {
            get
            {
                return this.RequiredAmountField;
            }
            set
            {
                this.RequiredAmountField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short RowError
        {
            get
            {
                return this.RowErrorField;
            }
            set
            {
                this.RowErrorField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short TotalVisaReuqested
        {
            get
            {
                return this.TotalVisaReuqestedField;
            }
            set
            {
                this.TotalVisaReuqestedField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "RegisterIstiqdamCategory", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class RegisterIstiqdamCategory : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private double ArrivalLocationCodeField;

        private double NationalityCodeField;

        private double OccupationCodeField;

        private System.Collections.Generic.List<Mol.Integration.Lib.Proxies.RegisterIstiqdamRequestMember> RegisterIstiqdamRequestMemberField;

        private int RequestNumberOfVisasField;

        private double RquestRerasonCodeField;

        private double SexCodeField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ArrivalLocationCode
        {
            get
            {
                return this.ArrivalLocationCodeField;
            }
            set
            {
                this.ArrivalLocationCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double NationalityCode
        {
            get
            {
                return this.NationalityCodeField;
            }
            set
            {
                this.NationalityCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double OccupationCode
        {
            get
            {
                return this.OccupationCodeField;
            }
            set
            {
                this.OccupationCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Mol.Integration.Lib.Proxies.RegisterIstiqdamRequestMember> RegisterIstiqdamRequestMember
        {
            get
            {
                return this.RegisterIstiqdamRequestMemberField;
            }
            set
            {
                this.RegisterIstiqdamRequestMemberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RequestNumberOfVisas
        {
            get
            {
                return this.RequestNumberOfVisasField;
            }
            set
            {
                this.RequestNumberOfVisasField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RquestRerasonCode
        {
            get
            {
                return this.RquestRerasonCodeField;
            }
            set
            {
                this.RquestRerasonCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SexCode
        {
            get
            {
                return this.SexCodeField;
            }
            set
            {
                this.SexCodeField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "RegisterIstiqdamRequestMember", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class RegisterIstiqdamRequestMember : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private double BorderNumberField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double BorderNumber
        {
            get
            {
                return this.BorderNumberField;
            }
            set
            {
                this.BorderNumberField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "RegisterIstiqdamFile", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class RegisterIstiqdamFile : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string ActionTypeField;

        private string AreaField;

        private string BusienssMainNameField;

        private short BusinessStatusField;

        private string BusinessbranchNameField;

        private short CityCodeField;

        private short CompnayNationalityField;

        private int CreateDateField;

        private string CreatedSponsorIdField;

        private string EstablishmentNameField;

        private int ExecutionReasonCodeField;

        private int ExecutionReturnCodeField;

        private double FaxField;

        private double FileNmberField;

        private short FileTypeField;

        private double MOCField;

        private short MianBranchFlagField;

        private string MocIssuePlaceField;

        private short MolFileLocationField;

        private double MolFileNumberField;

        private short MolMianActivityField;

        private short MolSubActivityField;

        private string MpNumberField;

        private short NcnCentralFileLocationField;

        private double NcnCentralFileNumberField;

        private string OtherLiceNumberField;

        private short OtherLiceTypeField;

        private double POBOXField;

        private string RequestedSponsorFirstNameField;

        private double RequestedSponsorIDField;

        private string RequestedSponsorSecondNameField;

        private string RequestedSponsorThirdNameField;

        private string SponsorActivity1Field;

        private string SponsorActivity2Field;

        private double SponsorMocField;

        private short SponsorTypeField;

        private string SponsoraddressField;

        private string SponsorbranchField;

        private string StreetField;

        private double Telephone1Field;

        private double Telephone2Field;

        private double ZipCodeField;

        private string requestedSponsorFamilyNameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ActionType
        {
            get
            {
                return this.ActionTypeField;
            }
            set
            {
                this.ActionTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Area
        {
            get
            {
                return this.AreaField;
            }
            set
            {
                this.AreaField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BusienssMainName
        {
            get
            {
                return this.BusienssMainNameField;
            }
            set
            {
                this.BusienssMainNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short BusinessStatus
        {
            get
            {
                return this.BusinessStatusField;
            }
            set
            {
                this.BusinessStatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BusinessbranchName
        {
            get
            {
                return this.BusinessbranchNameField;
            }
            set
            {
                this.BusinessbranchNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short CityCode
        {
            get
            {
                return this.CityCodeField;
            }
            set
            {
                this.CityCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short CompnayNationality
        {
            get
            {
                return this.CompnayNationalityField;
            }
            set
            {
                this.CompnayNationalityField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CreateDate
        {
            get
            {
                return this.CreateDateField;
            }
            set
            {
                this.CreateDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CreatedSponsorId
        {
            get
            {
                return this.CreatedSponsorIdField;
            }
            set
            {
                this.CreatedSponsorIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EstablishmentName
        {
            get
            {
                return this.EstablishmentNameField;
            }
            set
            {
                this.EstablishmentNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ExecutionReasonCode
        {
            get
            {
                return this.ExecutionReasonCodeField;
            }
            set
            {
                this.ExecutionReasonCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ExecutionReturnCode
        {
            get
            {
                return this.ExecutionReturnCodeField;
            }
            set
            {
                this.ExecutionReturnCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Fax
        {
            get
            {
                return this.FaxField;
            }
            set
            {
                this.FaxField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double FileNmber
        {
            get
            {
                return this.FileNmberField;
            }
            set
            {
                this.FileNmberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short FileType
        {
            get
            {
                return this.FileTypeField;
            }
            set
            {
                this.FileTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MOC
        {
            get
            {
                return this.MOCField;
            }
            set
            {
                this.MOCField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short MianBranchFlag
        {
            get
            {
                return this.MianBranchFlagField;
            }
            set
            {
                this.MianBranchFlagField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MocIssuePlace
        {
            get
            {
                return this.MocIssuePlaceField;
            }
            set
            {
                this.MocIssuePlaceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short MolFileLocation
        {
            get
            {
                return this.MolFileLocationField;
            }
            set
            {
                this.MolFileLocationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MolFileNumber
        {
            get
            {
                return this.MolFileNumberField;
            }
            set
            {
                this.MolFileNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short MolMianActivity
        {
            get
            {
                return this.MolMianActivityField;
            }
            set
            {
                this.MolMianActivityField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short MolSubActivity
        {
            get
            {
                return this.MolSubActivityField;
            }
            set
            {
                this.MolSubActivityField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MpNumber
        {
            get
            {
                return this.MpNumberField;
            }
            set
            {
                this.MpNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short NcnCentralFileLocation
        {
            get
            {
                return this.NcnCentralFileLocationField;
            }
            set
            {
                this.NcnCentralFileLocationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double NcnCentralFileNumber
        {
            get
            {
                return this.NcnCentralFileNumberField;
            }
            set
            {
                this.NcnCentralFileNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OtherLiceNumber
        {
            get
            {
                return this.OtherLiceNumberField;
            }
            set
            {
                this.OtherLiceNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short OtherLiceType
        {
            get
            {
                return this.OtherLiceTypeField;
            }
            set
            {
                this.OtherLiceTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double POBOX
        {
            get
            {
                return this.POBOXField;
            }
            set
            {
                this.POBOXField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequestedSponsorFirstName
        {
            get
            {
                return this.RequestedSponsorFirstNameField;
            }
            set
            {
                this.RequestedSponsorFirstNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RequestedSponsorID
        {
            get
            {
                return this.RequestedSponsorIDField;
            }
            set
            {
                this.RequestedSponsorIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequestedSponsorSecondName
        {
            get
            {
                return this.RequestedSponsorSecondNameField;
            }
            set
            {
                this.RequestedSponsorSecondNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequestedSponsorThirdName
        {
            get
            {
                return this.RequestedSponsorThirdNameField;
            }
            set
            {
                this.RequestedSponsorThirdNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SponsorActivity1
        {
            get
            {
                return this.SponsorActivity1Field;
            }
            set
            {
                this.SponsorActivity1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SponsorActivity2
        {
            get
            {
                return this.SponsorActivity2Field;
            }
            set
            {
                this.SponsorActivity2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SponsorMoc
        {
            get
            {
                return this.SponsorMocField;
            }
            set
            {
                this.SponsorMocField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short SponsorType
        {
            get
            {
                return this.SponsorTypeField;
            }
            set
            {
                this.SponsorTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sponsoraddress
        {
            get
            {
                return this.SponsoraddressField;
            }
            set
            {
                this.SponsoraddressField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sponsorbranch
        {
            get
            {
                return this.SponsorbranchField;
            }
            set
            {
                this.SponsorbranchField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street
        {
            get
            {
                return this.StreetField;
            }
            set
            {
                this.StreetField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Telephone1
        {
            get
            {
                return this.Telephone1Field;
            }
            set
            {
                this.Telephone1Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Telephone2
        {
            get
            {
                return this.Telephone2Field;
            }
            set
            {
                this.Telephone2Field = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ZipCode
        {
            get
            {
                return this.ZipCodeField;
            }
            set
            {
                this.ZipCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string requestedSponsorFamilyName
        {
            get
            {
                return this.requestedSponsorFamilyNameField;
            }
            set
            {
                this.requestedSponsorFamilyNameField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MolSponsorInfo", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class MolSponsorInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.Collections.Generic.List<Mol.Integration.Lib.Proxies.MOLBusinessList> MolBusinessListField;

        private System.Collections.Generic.List<Mol.Integration.Lib.Proxies.MOLSponsoreesList> MolSponsoreeListField;

        private double SponsorIdField;

        private string SponsorNameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Mol.Integration.Lib.Proxies.MOLBusinessList> MolBusinessList
        {
            get
            {
                return this.MolBusinessListField;
            }
            set
            {
                this.MolBusinessListField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Mol.Integration.Lib.Proxies.MOLSponsoreesList> MolSponsoreeList
        {
            get
            {
                return this.MolSponsoreeListField;
            }
            set
            {
                this.MolSponsoreeListField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SponsorId
        {
            get
            {
                return this.SponsorIdField;
            }
            set
            {
                this.SponsorIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SponsorName
        {
            get
            {
                return this.SponsorNameField;
            }
            set
            {
                this.SponsorNameField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MOLBusinessList", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class MOLBusinessList : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string BusinessNameField;

        private short BusinessStatusField;

        private short MoLFileLocationField;

        private double MoLFileNumberField;

        private short SequesnceNumberField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BusinessName
        {
            get
            {
                return this.BusinessNameField;
            }
            set
            {
                this.BusinessNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short BusinessStatus
        {
            get
            {
                return this.BusinessStatusField;
            }
            set
            {
                this.BusinessStatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short MoLFileLocation
        {
            get
            {
                return this.MoLFileLocationField;
            }
            set
            {
                this.MoLFileLocationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MoLFileNumber
        {
            get
            {
                return this.MoLFileNumberField;
            }
            set
            {
                this.MoLFileNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short SequesnceNumber
        {
            get
            {
                return this.SequesnceNumberField;
            }
            set
            {
                this.SequesnceNumberField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MOLSponsoreesList", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class MOLSponsoreesList : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private double SponsoreeIdField;

        private string SponsoreeNameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SponsoreeId
        {
            get
            {
                return this.SponsoreeIdField;
            }
            set
            {
                this.SponsoreeIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SponsoreeName
        {
            get
            {
                return this.SponsoreeNameField;
            }
            set
            {
                this.SponsoreeNameField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "RunAway", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class RunAway : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string ReporterInfoNameField;

        private double RequesterIDField;

        private string RequesterInfoNameField;

        private int ReturnCodeField;

        private string ReturnMessageField;

        private string RunawayDateField;

        private double RunawayIDField;

        private string RunawayInfoFirstEntryDateField;

        private string RunawayInfoNationalityDescriptionField;

        private string RunawayInfoOccupationDescriptionField;

        private string RunawayInfoPassportNoField;

        private string RunawayInfoPersonNameField;

        private string RunawayInfoResExpDateField;

        private double RunawayInfoSponsorIdField;

        private string RunawayInfoSponsorNameField;

        private double SeqNoField;

        private int TotalRunawayRecordsField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReporterInfoName
        {
            get
            {
                return this.ReporterInfoNameField;
            }
            set
            {
                this.ReporterInfoNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RequesterID
        {
            get
            {
                return this.RequesterIDField;
            }
            set
            {
                this.RequesterIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequesterInfoName
        {
            get
            {
                return this.RequesterInfoNameField;
            }
            set
            {
                this.RequesterInfoNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReturnCode
        {
            get
            {
                return this.ReturnCodeField;
            }
            set
            {
                this.ReturnCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReturnMessage
        {
            get
            {
                return this.ReturnMessageField;
            }
            set
            {
                this.ReturnMessageField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RunawayDate
        {
            get
            {
                return this.RunawayDateField;
            }
            set
            {
                this.RunawayDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RunawayID
        {
            get
            {
                return this.RunawayIDField;
            }
            set
            {
                this.RunawayIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RunawayInfoFirstEntryDate
        {
            get
            {
                return this.RunawayInfoFirstEntryDateField;
            }
            set
            {
                this.RunawayInfoFirstEntryDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RunawayInfoNationalityDescription
        {
            get
            {
                return this.RunawayInfoNationalityDescriptionField;
            }
            set
            {
                this.RunawayInfoNationalityDescriptionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RunawayInfoOccupationDescription
        {
            get
            {
                return this.RunawayInfoOccupationDescriptionField;
            }
            set
            {
                this.RunawayInfoOccupationDescriptionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RunawayInfoPassportNo
        {
            get
            {
                return this.RunawayInfoPassportNoField;
            }
            set
            {
                this.RunawayInfoPassportNoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RunawayInfoPersonName
        {
            get
            {
                return this.RunawayInfoPersonNameField;
            }
            set
            {
                this.RunawayInfoPersonNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RunawayInfoResExpDate
        {
            get
            {
                return this.RunawayInfoResExpDateField;
            }
            set
            {
                this.RunawayInfoResExpDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RunawayInfoSponsorId
        {
            get
            {
                return this.RunawayInfoSponsorIdField;
            }
            set
            {
                this.RunawayInfoSponsorIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RunawayInfoSponsorName
        {
            get
            {
                return this.RunawayInfoSponsorNameField;
            }
            set
            {
                this.RunawayInfoSponsorNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SeqNo
        {
            get
            {
                return this.SeqNoField;
            }
            set
            {
                this.SeqNoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalRunawayRecords
        {
            get
            {
                return this.TotalRunawayRecordsField;
            }
            set
            {
                this.TotalRunawayRecordsField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ServiceAuthentication", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class ServiceAuthentication : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private double AgencyIdField;

        private string AgencyPasspwordField;

        private string ClientIpAddressField;

        private string LangField;

        private int LocationIdField;

        private double OperatorIDField;

        private int ServiceIDField;

        private double SeviceProviderIDField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double AgencyId
        {
            get
            {
                return this.AgencyIdField;
            }
            set
            {
                this.AgencyIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AgencyPasspword
        {
            get
            {
                return this.AgencyPasspwordField;
            }
            set
            {
                this.AgencyPasspwordField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientIpAddress
        {
            get
            {
                return this.ClientIpAddressField;
            }
            set
            {
                this.ClientIpAddressField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lang
        {
            get
            {
                return this.LangField;
            }
            set
            {
                this.LangField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LocationId
        {
            get
            {
                return this.LocationIdField;
            }
            set
            {
                this.LocationIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double OperatorID
        {
            get
            {
                return this.OperatorIDField;
            }
            set
            {
                this.OperatorIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ServiceID
        {
            get
            {
                return this.ServiceIDField;
            }
            set
            {
                this.ServiceIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SeviceProviderID
        {
            get
            {
                return this.SeviceProviderIDField;
            }
            set
            {
                this.SeviceProviderIDField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "QueryDependentsByID_NSMol", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class QueryDependentsByID_NSMol : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.DateTime BirthDateGregField;

        private int BirthDateHegiraField;

        private System.DateTime EntryDateGregField;

        private string EntryDateHegiraField;

        private bool FinalExitViasaIssuedField;

        private bool FingerPrintStatusField;

        private string FirstNameField;

        private string FirstNameTField;

        private double IdField;

        private string IdTypeField;

        private System.DateTime LastEntryDateGregField;

        private string LastEntryDateHegiraField;

        private System.DateTime LastExitDateGregField;

        private string LastExitDateHegiraField;

        private string LastNameField;

        private string LastNameTField;

        private string MaritalStatusField;

        private int MaritalStatusCodeField;

        private string NameField;

        private string NationalityField;

        private short NationalityCodeField;

        private string OccupationField;

        private int OccupationCodeField;

        private System.DateTime PassportExpiryDateGregField;

        private string PassportExpiryDateHegiraField;

        private string RelationshipField;

        private int RelationshipCodeField;

        private string ReligionField;

        private int ReligionCodeField;

        private System.DateTime RequestTimeStampField;

        private System.DateTime ResidencyExpiryDateGregField;

        private int ResidencyExpiryDateHegiraField;

        private System.DateTime ResidencyIssueDateGregField;

        private int ResidencyIssueDateHegiraField;

        private string ResidencyIssuePlaceField;

        private System.DateTime ResponseTimeStampField;

        private string SecondNameField;

        private string SecondNameTField;

        private string SexField;

        private double SponsorIdField;

        private string SponsorNameField;

        private string SponsorOccupationField;

        private string SponsorStatusField;

        private string SponsorTypeField;

        private int SponsorTypeCodeField;

        private string StatusField;

        private short StatusCodeField;

        private string ThirdNameField;

        private string ThirdNameTField;

        private string TranslatedNameField;

        private string VisaExpiryDateGregField;

        private string VisaExpiryDateHegiraField;

        private string VisaTypeField;

        private string travelStatusField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BirthDateGreg
        {
            get
            {
                return this.BirthDateGregField;
            }
            set
            {
                this.BirthDateGregField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BirthDateHegira
        {
            get
            {
                return this.BirthDateHegiraField;
            }
            set
            {
                this.BirthDateHegiraField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EntryDateGreg
        {
            get
            {
                return this.EntryDateGregField;
            }
            set
            {
                this.EntryDateGregField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntryDateHegira
        {
            get
            {
                return this.EntryDateHegiraField;
            }
            set
            {
                this.EntryDateHegiraField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool FinalExitViasaIssued
        {
            get
            {
                return this.FinalExitViasaIssuedField;
            }
            set
            {
                this.FinalExitViasaIssuedField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool FingerPrintStatus
        {
            get
            {
                return this.FingerPrintStatusField;
            }
            set
            {
                this.FingerPrintStatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstNameT
        {
            get
            {
                return this.FirstNameTField;
            }
            set
            {
                this.FirstNameTField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdType
        {
            get
            {
                return this.IdTypeField;
            }
            set
            {
                this.IdTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastEntryDateGreg
        {
            get
            {
                return this.LastEntryDateGregField;
            }
            set
            {
                this.LastEntryDateGregField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastEntryDateHegira
        {
            get
            {
                return this.LastEntryDateHegiraField;
            }
            set
            {
                this.LastEntryDateHegiraField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastExitDateGreg
        {
            get
            {
                return this.LastExitDateGregField;
            }
            set
            {
                this.LastExitDateGregField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastExitDateHegira
        {
            get
            {
                return this.LastExitDateHegiraField;
            }
            set
            {
                this.LastExitDateHegiraField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastNameT
        {
            get
            {
                return this.LastNameTField;
            }
            set
            {
                this.LastNameTField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MaritalStatus
        {
            get
            {
                return this.MaritalStatusField;
            }
            set
            {
                this.MaritalStatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaritalStatusCode
        {
            get
            {
                return this.MaritalStatusCodeField;
            }
            set
            {
                this.MaritalStatusCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nationality
        {
            get
            {
                return this.NationalityField;
            }
            set
            {
                this.NationalityField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short NationalityCode
        {
            get
            {
                return this.NationalityCodeField;
            }
            set
            {
                this.NationalityCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Occupation
        {
            get
            {
                return this.OccupationField;
            }
            set
            {
                this.OccupationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OccupationCode
        {
            get
            {
                return this.OccupationCodeField;
            }
            set
            {
                this.OccupationCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PassportExpiryDateGreg
        {
            get
            {
                return this.PassportExpiryDateGregField;
            }
            set
            {
                this.PassportExpiryDateGregField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PassportExpiryDateHegira
        {
            get
            {
                return this.PassportExpiryDateHegiraField;
            }
            set
            {
                this.PassportExpiryDateHegiraField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Relationship
        {
            get
            {
                return this.RelationshipField;
            }
            set
            {
                this.RelationshipField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RelationshipCode
        {
            get
            {
                return this.RelationshipCodeField;
            }
            set
            {
                this.RelationshipCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Religion
        {
            get
            {
                return this.ReligionField;
            }
            set
            {
                this.ReligionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReligionCode
        {
            get
            {
                return this.ReligionCodeField;
            }
            set
            {
                this.ReligionCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RequestTimeStamp
        {
            get
            {
                return this.RequestTimeStampField;
            }
            set
            {
                this.RequestTimeStampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ResidencyExpiryDateGreg
        {
            get
            {
                return this.ResidencyExpiryDateGregField;
            }
            set
            {
                this.ResidencyExpiryDateGregField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ResidencyExpiryDateHegira
        {
            get
            {
                return this.ResidencyExpiryDateHegiraField;
            }
            set
            {
                this.ResidencyExpiryDateHegiraField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ResidencyIssueDateGreg
        {
            get
            {
                return this.ResidencyIssueDateGregField;
            }
            set
            {
                this.ResidencyIssueDateGregField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ResidencyIssueDateHegira
        {
            get
            {
                return this.ResidencyIssueDateHegiraField;
            }
            set
            {
                this.ResidencyIssueDateHegiraField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResidencyIssuePlace
        {
            get
            {
                return this.ResidencyIssuePlaceField;
            }
            set
            {
                this.ResidencyIssuePlaceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ResponseTimeStamp
        {
            get
            {
                return this.ResponseTimeStampField;
            }
            set
            {
                this.ResponseTimeStampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecondName
        {
            get
            {
                return this.SecondNameField;
            }
            set
            {
                this.SecondNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecondNameT
        {
            get
            {
                return this.SecondNameTField;
            }
            set
            {
                this.SecondNameTField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sex
        {
            get
            {
                return this.SexField;
            }
            set
            {
                this.SexField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SponsorId
        {
            get
            {
                return this.SponsorIdField;
            }
            set
            {
                this.SponsorIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SponsorName
        {
            get
            {
                return this.SponsorNameField;
            }
            set
            {
                this.SponsorNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SponsorOccupation
        {
            get
            {
                return this.SponsorOccupationField;
            }
            set
            {
                this.SponsorOccupationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SponsorStatus
        {
            get
            {
                return this.SponsorStatusField;
            }
            set
            {
                this.SponsorStatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SponsorType
        {
            get
            {
                return this.SponsorTypeField;
            }
            set
            {
                this.SponsorTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SponsorTypeCode
        {
            get
            {
                return this.SponsorTypeCodeField;
            }
            set
            {
                this.SponsorTypeCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public short StatusCode
        {
            get
            {
                return this.StatusCodeField;
            }
            set
            {
                this.StatusCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ThirdName
        {
            get
            {
                return this.ThirdNameField;
            }
            set
            {
                this.ThirdNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ThirdNameT
        {
            get
            {
                return this.ThirdNameTField;
            }
            set
            {
                this.ThirdNameTField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TranslatedName
        {
            get
            {
                return this.TranslatedNameField;
            }
            set
            {
                this.TranslatedNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisaExpiryDateGreg
        {
            get
            {
                return this.VisaExpiryDateGregField;
            }
            set
            {
                this.VisaExpiryDateGregField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisaExpiryDateHegira
        {
            get
            {
                return this.VisaExpiryDateHegiraField;
            }
            set
            {
                this.VisaExpiryDateHegiraField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisaType
        {
            get
            {
                return this.VisaTypeField;
            }
            set
            {
                this.VisaTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string travelStatus
        {
            get
            {
                return this.travelStatusField;
            }
            set
            {
                this.travelStatusField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CheckVehicleOwner", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class CheckVehicleOwner : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string ClientIpAddressField;

        private double CoOwnerIDField;

        private double OperatorIdField;

        private double OwnerIDField;

        private double PreviousOwnerIDField;

        private double VehicleSequenceNoField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientIpAddress
        {
            get
            {
                return this.ClientIpAddressField;
            }
            set
            {
                this.ClientIpAddressField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double CoOwnerID
        {
            get
            {
                return this.CoOwnerIDField;
            }
            set
            {
                this.CoOwnerIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double OperatorId
        {
            get
            {
                return this.OperatorIdField;
            }
            set
            {
                this.OperatorIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double OwnerID
        {
            get
            {
                return this.OwnerIDField;
            }
            set
            {
                this.OwnerIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PreviousOwnerID
        {
            get
            {
                return this.PreviousOwnerIDField;
            }
            set
            {
                this.PreviousOwnerIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double VehicleSequenceNo
        {
            get
            {
                return this.VehicleSequenceNoField;
            }
            set
            {
                this.VehicleSequenceNoField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "QueryWorkPermitReq", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class QueryWorkPermitReq : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string ClientIpAddressField;

        private double IDNumberField;

        private string LangField;

        private double OperatorIdField;

        private double WorkpermitLabourOfficeCodeField;

        private double WorkpermitLicenseNumberField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientIpAddress
        {
            get
            {
                return this.ClientIpAddressField;
            }
            set
            {
                this.ClientIpAddressField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double IDNumber
        {
            get
            {
                return this.IDNumberField;
            }
            set
            {
                this.IDNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lang
        {
            get
            {
                return this.LangField;
            }
            set
            {
                this.LangField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double OperatorId
        {
            get
            {
                return this.OperatorIdField;
            }
            set
            {
                this.OperatorIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double WorkpermitLabourOfficeCode
        {
            get
            {
                return this.WorkpermitLabourOfficeCodeField;
            }
            set
            {
                this.WorkpermitLabourOfficeCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double WorkpermitLicenseNumber
        {
            get
            {
                return this.WorkpermitLicenseNumberField;
            }
            set
            {
                this.WorkpermitLicenseNumberField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "QueryWorkPermitRes", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class QueryWorkPermitRes : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.DateTime RequestTimeStampField;

        private System.DateTime ResponseTimeStampField;

        private System.Collections.Generic.List<Mol.Integration.Lib.Proxies.QueryWorkPermitResList> WorkPermitListField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RequestTimeStamp
        {
            get
            {
                return this.RequestTimeStampField;
            }
            set
            {
                this.RequestTimeStampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ResponseTimeStamp
        {
            get
            {
                return this.ResponseTimeStampField;
            }
            set
            {
                this.ResponseTimeStampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Mol.Integration.Lib.Proxies.QueryWorkPermitResList> WorkPermitList
        {
            get
            {
                return this.WorkPermitListField;
            }
            set
            {
                this.WorkPermitListField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "QueryWorkPermitResList", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class QueryWorkPermitResList : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private int DurationField;

        private System.DateTime EndDateGField;

        private double IDNumberField;

        private System.DateTime StartDateGField;

        private int StatusField;

        private string StatusDescField;

        private string TimestampField;

        private double WorkpermitLabourOfficeCodeField;

        private double WorkpermitLicenseNumberField;

        private int WorkpermitTypeCodeField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Duration
        {
            get
            {
                return this.DurationField;
            }
            set
            {
                this.DurationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndDateG
        {
            get
            {
                return this.EndDateGField;
            }
            set
            {
                this.EndDateGField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double IDNumber
        {
            get
            {
                return this.IDNumberField;
            }
            set
            {
                this.IDNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDateG
        {
            get
            {
                return this.StartDateGField;
            }
            set
            {
                this.StartDateGField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatusDesc
        {
            get
            {
                return this.StatusDescField;
            }
            set
            {
                this.StatusDescField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Timestamp
        {
            get
            {
                return this.TimestampField;
            }
            set
            {
                this.TimestampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double WorkpermitLabourOfficeCode
        {
            get
            {
                return this.WorkpermitLabourOfficeCodeField;
            }
            set
            {
                this.WorkpermitLabourOfficeCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double WorkpermitLicenseNumber
        {
            get
            {
                return this.WorkpermitLicenseNumberField;
            }
            set
            {
                this.WorkpermitLicenseNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WorkpermitTypeCode
        {
            get
            {
                return this.WorkpermitTypeCodeField;
            }
            set
            {
                this.WorkpermitTypeCodeField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IssueWorkPermitReq", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class IssueWorkPermitReq : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string ClientIpAddressField;

        private int EndDateField;

        private double IDField;

        private double OperatorIdField;

        private int StartDateField;

        private int WpDurationField;

        private int WpLabOffField;

        private int WpLicenceNoField;

        private int WpTypeField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientIpAddress
        {
            get
            {
                return this.ClientIpAddressField;
            }
            set
            {
                this.ClientIpAddressField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EndDate
        {
            get
            {
                return this.EndDateField;
            }
            set
            {
                this.EndDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double OperatorId
        {
            get
            {
                return this.OperatorIdField;
            }
            set
            {
                this.OperatorIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StartDate
        {
            get
            {
                return this.StartDateField;
            }
            set
            {
                this.StartDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WpDuration
        {
            get
            {
                return this.WpDurationField;
            }
            set
            {
                this.WpDurationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WpLabOff
        {
            get
            {
                return this.WpLabOffField;
            }
            set
            {
                this.WpLabOffField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WpLicenceNo
        {
            get
            {
                return this.WpLicenceNoField;
            }
            set
            {
                this.WpLicenceNoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WpType
        {
            get
            {
                return this.WpTypeField;
            }
            set
            {
                this.WpTypeField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IssueWorkPermitRes", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class IssueWorkPermitRes : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.DateTime EndDateField;

        private double IDField;

        private string MessageField;

        private System.DateTime RequestTimeStampField;

        private System.DateTime ResponseTimeStampField;

        private System.DateTime StartDateField;

        private int StatusField;

        private System.DateTime TimestampField;

        private int WpDurationField;

        private int WpLabOffField;

        private int WpLicenceNoField;

        private int WpTypeField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndDate
        {
            get
            {
                return this.EndDateField;
            }
            set
            {
                this.EndDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RequestTimeStamp
        {
            get
            {
                return this.RequestTimeStampField;
            }
            set
            {
                this.RequestTimeStampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ResponseTimeStamp
        {
            get
            {
                return this.ResponseTimeStampField;
            }
            set
            {
                this.ResponseTimeStampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate
        {
            get
            {
                return this.StartDateField;
            }
            set
            {
                this.StartDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Timestamp
        {
            get
            {
                return this.TimestampField;
            }
            set
            {
                this.TimestampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WpDuration
        {
            get
            {
                return this.WpDurationField;
            }
            set
            {
                this.WpDurationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WpLabOff
        {
            get
            {
                return this.WpLabOffField;
            }
            set
            {
                this.WpLabOffField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WpLicenceNo
        {
            get
            {
                return this.WpLicenceNoField;
            }
            set
            {
                this.WpLicenceNoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WpType
        {
            get
            {
                return this.WpTypeField;
            }
            set
            {
                this.WpTypeField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MOLLaborBySponsorID", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class MOLLaborBySponsorID : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.Collections.Generic.List<double> IDField;

        private System.DateTime RequestTimeStampField;

        private System.DateTime ResponseTimeStampField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<double> ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RequestTimeStamp
        {
            get
            {
                return this.RequestTimeStampField;
            }
            set
            {
                this.RequestTimeStampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ResponseTimeStamp
        {
            get
            {
                return this.ResponseTimeStampField;
            }
            set
            {
                this.ResponseTimeStampField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MOL_Business_Info", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class MOL_Business_Info : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.Collections.Generic.List<Mol.Integration.Lib.Proxies.MOL_Business_list> BusinessInfoField;

        private System.DateTime RequestTimeStampField;

        private System.DateTime ResponseTimeStampField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Mol.Integration.Lib.Proxies.MOL_Business_list> BusinessInfo
        {
            get
            {
                return this.BusinessInfoField;
            }
            set
            {
                this.BusinessInfoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RequestTimeStamp
        {
            get
            {
                return this.RequestTimeStampField;
            }
            set
            {
                this.RequestTimeStampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ResponseTimeStamp
        {
            get
            {
                return this.ResponseTimeStampField;
            }
            set
            {
                this.ResponseTimeStampField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MOL_Business_list", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class MOL_Business_list : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private int CommercialRegistryNoField;

        private double CompanyEstablishmentIDField;

        private string CompanyEstablishmentNameField;

        private int MOLfileLocationField;

        private double MOLfileNumberField;

        private int MainActivityCodeField;

        private string MainActivityDescriptionField;

        private string MunicipalityPermissionNoField;

        private string OtherLicenseNoField;

        private int OtherLicenseTypeCodeField;

        private string OtherLicenseTypeDescriptionField;

        private int StatusCodeField;

        private string StatusDescriptionField;

        private int SubActivityCodeField;

        private string SubActivityDescriptionField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CommercialRegistryNo
        {
            get
            {
                return this.CommercialRegistryNoField;
            }
            set
            {
                this.CommercialRegistryNoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double CompanyEstablishmentID
        {
            get
            {
                return this.CompanyEstablishmentIDField;
            }
            set
            {
                this.CompanyEstablishmentIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyEstablishmentName
        {
            get
            {
                return this.CompanyEstablishmentNameField;
            }
            set
            {
                this.CompanyEstablishmentNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MOLfileLocation
        {
            get
            {
                return this.MOLfileLocationField;
            }
            set
            {
                this.MOLfileLocationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MOLfileNumber
        {
            get
            {
                return this.MOLfileNumberField;
            }
            set
            {
                this.MOLfileNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MainActivityCode
        {
            get
            {
                return this.MainActivityCodeField;
            }
            set
            {
                this.MainActivityCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MainActivityDescription
        {
            get
            {
                return this.MainActivityDescriptionField;
            }
            set
            {
                this.MainActivityDescriptionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MunicipalityPermissionNo
        {
            get
            {
                return this.MunicipalityPermissionNoField;
            }
            set
            {
                this.MunicipalityPermissionNoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OtherLicenseNo
        {
            get
            {
                return this.OtherLicenseNoField;
            }
            set
            {
                this.OtherLicenseNoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OtherLicenseTypeCode
        {
            get
            {
                return this.OtherLicenseTypeCodeField;
            }
            set
            {
                this.OtherLicenseTypeCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OtherLicenseTypeDescription
        {
            get
            {
                return this.OtherLicenseTypeDescriptionField;
            }
            set
            {
                this.OtherLicenseTypeDescriptionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StatusCode
        {
            get
            {
                return this.StatusCodeField;
            }
            set
            {
                this.StatusCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatusDescription
        {
            get
            {
                return this.StatusDescriptionField;
            }
            set
            {
                this.StatusDescriptionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SubActivityCode
        {
            get
            {
                return this.SubActivityCodeField;
            }
            set
            {
                this.SubActivityCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubActivityDescription
        {
            get
            {
                return this.SubActivityDescriptionField;
            }
            set
            {
                this.SubActivityDescriptionField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MOLLaborVisa", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class MOLLaborVisa : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.Collections.Generic.List<Mol.Integration.Lib.Proxies.MOLLaborVisaList> LaborVisaField;

        private System.DateTime RequestTimeStampField;

        private System.DateTime ResponseTimeStampField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Mol.Integration.Lib.Proxies.MOLLaborVisaList> LaborVisa
        {
            get
            {
                return this.LaborVisaField;
            }
            set
            {
                this.LaborVisaField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RequestTimeStamp
        {
            get
            {
                return this.RequestTimeStampField;
            }
            set
            {
                this.RequestTimeStampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ResponseTimeStamp
        {
            get
            {
                return this.ResponseTimeStampField;
            }
            set
            {
                this.ResponseTimeStampField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MOLLaborVisaList", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class MOLLaborVisaList : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private double BorderIDField;

        private double CompanyIDField;

        private string NationalityField;

        private int NationalityCodeField;

        private string OccupationField;

        private int OccupationCodeField;

        private string ReligionField;

        private int ReligionCodeField;

        private string SexField;

        private string SexCodeField;

        private string VisaIssuePlaceField;

        private int VisaIssuePlaceCodeField;

        private double VisaNoField;

        private string VisaStatusField;

        private int VisaStatusCodeField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double BorderID
        {
            get
            {
                return this.BorderIDField;
            }
            set
            {
                this.BorderIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double CompanyID
        {
            get
            {
                return this.CompanyIDField;
            }
            set
            {
                this.CompanyIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nationality
        {
            get
            {
                return this.NationalityField;
            }
            set
            {
                this.NationalityField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NationalityCode
        {
            get
            {
                return this.NationalityCodeField;
            }
            set
            {
                this.NationalityCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Occupation
        {
            get
            {
                return this.OccupationField;
            }
            set
            {
                this.OccupationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OccupationCode
        {
            get
            {
                return this.OccupationCodeField;
            }
            set
            {
                this.OccupationCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Religion
        {
            get
            {
                return this.ReligionField;
            }
            set
            {
                this.ReligionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReligionCode
        {
            get
            {
                return this.ReligionCodeField;
            }
            set
            {
                this.ReligionCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sex
        {
            get
            {
                return this.SexField;
            }
            set
            {
                this.SexField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SexCode
        {
            get
            {
                return this.SexCodeField;
            }
            set
            {
                this.SexCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisaIssuePlace
        {
            get
            {
                return this.VisaIssuePlaceField;
            }
            set
            {
                this.VisaIssuePlaceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int VisaIssuePlaceCode
        {
            get
            {
                return this.VisaIssuePlaceCodeField;
            }
            set
            {
                this.VisaIssuePlaceCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double VisaNo
        {
            get
            {
                return this.VisaNoField;
            }
            set
            {
                this.VisaNoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VisaStatus
        {
            get
            {
                return this.VisaStatusField;
            }
            set
            {
                this.VisaStatusField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int VisaStatusCode
        {
            get
            {
                return this.VisaStatusCodeField;
            }
            set
            {
                this.VisaStatusCodeField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "AddMolApprovalForChangeSponsorReq", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class AddMolApprovalForChangeSponsorReq : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string ClientIpAddressField;

        private int CompanyNumberField;

        private int EffectiveDateField;

        private double EstablishmentOrCompanyIDField;

        private int ExpirationDateField;

        private double IDNumberField;

        private int LabourOfficeCodeField;

        private int LabourOfficeCompanyField;

        private System.DateTime MolTimestampField;

        private double OperatorIdField;

        private int SerialNumberField;

        private int SerialYearField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientIpAddress
        {
            get
            {
                return this.ClientIpAddressField;
            }
            set
            {
                this.ClientIpAddressField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CompanyNumber
        {
            get
            {
                return this.CompanyNumberField;
            }
            set
            {
                this.CompanyNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EffectiveDate
        {
            get
            {
                return this.EffectiveDateField;
            }
            set
            {
                this.EffectiveDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double EstablishmentOrCompanyID
        {
            get
            {
                return this.EstablishmentOrCompanyIDField;
            }
            set
            {
                this.EstablishmentOrCompanyIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ExpirationDate
        {
            get
            {
                return this.ExpirationDateField;
            }
            set
            {
                this.ExpirationDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double IDNumber
        {
            get
            {
                return this.IDNumberField;
            }
            set
            {
                this.IDNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LabourOfficeCode
        {
            get
            {
                return this.LabourOfficeCodeField;
            }
            set
            {
                this.LabourOfficeCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LabourOfficeCompany
        {
            get
            {
                return this.LabourOfficeCompanyField;
            }
            set
            {
                this.LabourOfficeCompanyField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime MolTimestamp
        {
            get
            {
                return this.MolTimestampField;
            }
            set
            {
                this.MolTimestampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double OperatorId
        {
            get
            {
                return this.OperatorIdField;
            }
            set
            {
                this.OperatorIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SerialNumber
        {
            get
            {
                return this.SerialNumberField;
            }
            set
            {
                this.SerialNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SerialYear
        {
            get
            {
                return this.SerialYearField;
            }
            set
            {
                this.SerialYearField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "AddMolApprovalForChangeSponsorRes", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class AddMolApprovalForChangeSponsorRes : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private int CompanyNumberField;

        private double EstablishmentOrCompanyIDField;

        private double IDNumberField;

        private int LabourOfficeCodeField;

        private int LabourOfficeCompanyField;

        private string MessageField;

        private System.DateTime RequestTimestampField;

        private System.DateTime ResponseTimestampField;

        private int SerialNumberField;

        private int SerialYearField;

        private System.DateTime TimestampField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CompanyNumber
        {
            get
            {
                return this.CompanyNumberField;
            }
            set
            {
                this.CompanyNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double EstablishmentOrCompanyID
        {
            get
            {
                return this.EstablishmentOrCompanyIDField;
            }
            set
            {
                this.EstablishmentOrCompanyIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double IDNumber
        {
            get
            {
                return this.IDNumberField;
            }
            set
            {
                this.IDNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LabourOfficeCode
        {
            get
            {
                return this.LabourOfficeCodeField;
            }
            set
            {
                this.LabourOfficeCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LabourOfficeCompany
        {
            get
            {
                return this.LabourOfficeCompanyField;
            }
            set
            {
                this.LabourOfficeCompanyField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RequestTimestamp
        {
            get
            {
                return this.RequestTimestampField;
            }
            set
            {
                this.RequestTimestampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ResponseTimestamp
        {
            get
            {
                return this.ResponseTimestampField;
            }
            set
            {
                this.ResponseTimestampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SerialNumber
        {
            get
            {
                return this.SerialNumberField;
            }
            set
            {
                this.SerialNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SerialYear
        {
            get
            {
                return this.SerialYearField;
            }
            set
            {
                this.SerialYearField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Timestamp
        {
            get
            {
                return this.TimestampField;
            }
            set
            {
                this.TimestampField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "AddMolApprovalForChangeOccupationReq", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class AddMolApprovalForChangeOccupationReq : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string ClientIpAddressField;

        private int EffectiveDateField;

        private int ExpirationDateField;

        private double IDNumberField;

        private int JobCodeField;

        private int LabourOfficeCodeField;

        private System.DateTime MolTimestampField;

        private double OperatorIdField;

        private int SerialNumberField;

        private int SerialYearField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientIpAddress
        {
            get
            {
                return this.ClientIpAddressField;
            }
            set
            {
                this.ClientIpAddressField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EffectiveDate
        {
            get
            {
                return this.EffectiveDateField;
            }
            set
            {
                this.EffectiveDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ExpirationDate
        {
            get
            {
                return this.ExpirationDateField;
            }
            set
            {
                this.ExpirationDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double IDNumber
        {
            get
            {
                return this.IDNumberField;
            }
            set
            {
                this.IDNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int JobCode
        {
            get
            {
                return this.JobCodeField;
            }
            set
            {
                this.JobCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LabourOfficeCode
        {
            get
            {
                return this.LabourOfficeCodeField;
            }
            set
            {
                this.LabourOfficeCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime MolTimestamp
        {
            get
            {
                return this.MolTimestampField;
            }
            set
            {
                this.MolTimestampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double OperatorId
        {
            get
            {
                return this.OperatorIdField;
            }
            set
            {
                this.OperatorIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SerialNumber
        {
            get
            {
                return this.SerialNumberField;
            }
            set
            {
                this.SerialNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SerialYear
        {
            get
            {
                return this.SerialYearField;
            }
            set
            {
                this.SerialYearField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "AddMolApprovalForChangeOccupationRes", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class AddMolApprovalForChangeOccupationRes : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private double IDNumberField;

        private int LabourOfficeCodeField;

        private string MessageField;

        private System.DateTime RequestTimestampField;

        private System.DateTime ResponseTimestampField;

        private int SerialNumberField;

        private int SerialYearField;

        private System.DateTime TimestampField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double IDNumber
        {
            get
            {
                return this.IDNumberField;
            }
            set
            {
                this.IDNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LabourOfficeCode
        {
            get
            {
                return this.LabourOfficeCodeField;
            }
            set
            {
                this.LabourOfficeCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RequestTimestamp
        {
            get
            {
                return this.RequestTimestampField;
            }
            set
            {
                this.RequestTimestampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ResponseTimestamp
        {
            get
            {
                return this.ResponseTimestampField;
            }
            set
            {
                this.ResponseTimestampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SerialNumber
        {
            get
            {
                return this.SerialNumberField;
            }
            set
            {
                this.SerialNumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SerialYear
        {
            get
            {
                return this.SerialYearField;
            }
            set
            {
                this.SerialYearField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Timestamp
        {
            get
            {
                return this.TimestampField;
            }
            set
            {
                this.TimestampField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
    public partial class SamisWSFault : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private int ErrorCodeField;

        private Mol.Integration.Lib.Proxies.SamisWSFaultType ErrorTypeField;

        private string MessageField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ErrorCode
        {
            get
            {
                return this.ErrorCodeField;
            }
            set
            {
                this.ErrorCodeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mol.Integration.Lib.Proxies.SamisWSFaultType ErrorType
        {
            get
            {
                return this.ErrorTypeField;
            }
            set
            {
                this.ErrorTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SamisWSFaultType", Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public enum SamisWSFaultType : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        System = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Functional = 1,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "urn:MOI.NIC.eServices-V1", ConfigurationName = "Mol.Integration.Lib.Proxies.IMOL_SERVICE")]
    public interface IMOL_SERVICE
    {

        // CODEGEN: Generating message contract since message GetLabourFullRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetLabourFull", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetLabourFullResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetLabourFullSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.GetLabourFullResponse GetLabourFull(Mol.Integration.Lib.Proxies.GetLabourFullRequest request);

        // CODEGEN: Generating message contract since message ReportEscapeSponsoreesRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ReportEscapeSponsorees", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ReportEscapeSponsoreesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ReportEscapeSponsoreesSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.ReportEscapeSponsoreesResponse ReportEscapeSponsorees(Mol.Integration.Lib.Proxies.ReportEscapeSponsoreesRequest request);

        // CODEGEN: Generating message contract since message IssueLaborVisaRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/IssueLaborVisa", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/IssueLaborVisaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/IssueLaborVisaSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.IssueLaborVisaResponse IssueLaborVisa(Mol.Integration.Lib.Proxies.IssueLaborVisaRequest request);

        // CODEGEN: Generating message contract since message OpenSponsorFileRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/OpenSponsorFile", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/OpenSponsorFileResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/OpenSponsorFileSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.OpenSponsorFileResponse OpenSponsorFile(Mol.Integration.Lib.Proxies.OpenSponsorFileRequest request);

        // CODEGEN: Generating message contract since message UpdateSponsorFileRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/UpdateSponsorFile", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/UpdateSponsorFileResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/UpdateSponsorFileSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.UpdateSponsorFileResponse UpdateSponsorFile(Mol.Integration.Lib.Proxies.UpdateSponsorFileRequest request);

        // CODEGEN: Generating message contract since message UpdateLaborVisaRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/UpdateLaborVisa", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/UpdateLaborVisaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/UpdateLaborVisaSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.UpdateLaborVisaResponse UpdateLaborVisa(Mol.Integration.Lib.Proxies.UpdateLaborVisaRequest request);

        // CODEGEN: Generating message contract since message ListSponsoreesForTransferRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ListSponsoreesForTransfer", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ListSponsoreesForTransferResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ListSponsoreesForTransferSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.ListSponsoreesForTransferResponse ListSponsoreesForTransfer(Mol.Integration.Lib.Proxies.ListSponsoreesForTransferRequest request);

        // CODEGEN: Generating message contract since message ListSponsoreesForTransferNextRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ListSponsoreesForTransferNext", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ListSponsoreesForTransferNextResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ListSponsoreesForTransferNextSamisWSFaultFa" +
            "ult", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.ListSponsoreesForTransferNextResponse ListSponsoreesForTransferNext(Mol.Integration.Lib.Proxies.ListSponsoreesForTransferNextRequest request);

        // CODEGEN: Generating message contract since message TransferSponsoreesRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/TransferSponsorees", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/TransferSponsoreesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/TransferSponsoreesSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.TransferSponsoreesResponse TransferSponsorees(Mol.Integration.Lib.Proxies.TransferSponsoreesRequest request);

        // CODEGEN: Generating message contract since message ValidateAlienSponsorBusinessRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ValidateAlienSponsorBusiness", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ValidateAlienSponsorBusinessResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ValidateAlienSponsorBusinessSamisWSFaultFau" +
            "lt", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.ValidateAlienSponsorBusinessResponse ValidateAlienSponsorBusiness(Mol.Integration.Lib.Proxies.ValidateAlienSponsorBusinessRequest request);

        // CODEGEN: Generating message contract since message UpdateAlienSponsorBusinessRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/UpdateAlienSponsorBusiness", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/UpdateAlienSponsorBusinessResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/UpdateAlienSponsorBusinessSamisWSFaultFault" +
            "", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.UpdateAlienSponsorBusinessResponse UpdateAlienSponsorBusiness(Mol.Integration.Lib.Proxies.UpdateAlienSponsorBusinessRequest request);

        // CODEGEN: Generating message contract since message ValidateCancelRunAWayReportRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ValidateCancelRunAWayReport", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ValidateCancelRunAWayReportResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ValidateCancelRunAWayReportSamisWSFaultFaul" +
            "t", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.ValidateCancelRunAWayReportResponse ValidateCancelRunAWayReport(Mol.Integration.Lib.Proxies.ValidateCancelRunAWayReportRequest request);

        // CODEGEN: Generating message contract since message ConfirmCancelRunAwayReportRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ConfirmCancelRunAwayReport", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ConfirmCancelRunAwayReportResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ConfirmCancelRunAwayReportSamisWSFaultFault" +
            "", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.ConfirmCancelRunAwayReportResponse ConfirmCancelRunAwayReport(Mol.Integration.Lib.Proxies.ConfirmCancelRunAwayReportRequest request);

        // CODEGEN: Generating message contract since message ValidateCreateRunAwayReportRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ValidateCreateRunAwayReport", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ValidateCreateRunAwayReportResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ValidateCreateRunAwayReportSamisWSFaultFaul" +
            "t", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.ValidateCreateRunAwayReportResponse ValidateCreateRunAwayReport(Mol.Integration.Lib.Proxies.ValidateCreateRunAwayReportRequest request);

        // CODEGEN: Generating message contract since message ConfirmCreateRunAwayReportRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ConfirmCreateRunAwayReport", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ConfirmCreateRunAwayReportResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/ConfirmCreateRunAwayReportSamisWSFaultFault" +
            "", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.ConfirmCreateRunAwayReportResponse ConfirmCreateRunAwayReport(Mol.Integration.Lib.Proxies.ConfirmCreateRunAwayReportRequest request);

        // CODEGEN: Generating message contract since message GetAlienVisitorInfoRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetAlienVisitorInfo", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetAlienVisitorInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetAlienVisitorInfoSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.GetAlienVisitorInfoResponse GetAlienVisitorInfo(Mol.Integration.Lib.Proxies.GetAlienVisitorInfoRequest request);

        // CODEGEN: Generating message contract since message GetAlienPrisonStatusRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetAlienPrisonStatus", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetAlienPrisonStatusResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetAlienPrisonStatusSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.GetAlienPrisonStatusResponse GetAlienPrisonStatus(Mol.Integration.Lib.Proxies.GetAlienPrisonStatusRequest request);

        // CODEGEN: Generating message contract since message CheckvehicleOwnerRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/CheckvehicleOwner", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/CheckvehicleOwnerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/CheckvehicleOwnerSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.CheckvehicleOwnerResponse CheckvehicleOwner(Mol.Integration.Lib.Proxies.CheckvehicleOwnerRequest request);

        // CODEGEN: Generating message contract since message QueryWorkPermitRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/QueryWorkPermit", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/QueryWorkPermitResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/QueryWorkPermitSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.QueryWorkPermitResponse QueryWorkPermit(Mol.Integration.Lib.Proxies.QueryWorkPermitRequest request);

        // CODEGEN: Generating message contract since message AuthenticateUserByMobileRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/AuthenticateUserByMobile", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/AuthenticateUserByMobileResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/AuthenticateUserByMobileSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.AuthenticateUserByMobileResponse AuthenticateUserByMobile(Mol.Integration.Lib.Proxies.AuthenticateUserByMobileRequest request);

        // CODEGEN: Generating message contract since message IssueWorkPermitRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/IssueWorkPermit", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/IssueWorkPermitResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/IssueWorkPermitSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.IssueWorkPermitResponse IssueWorkPermit(Mol.Integration.Lib.Proxies.IssueWorkPermitRequest request);

        // CODEGEN: Generating message contract since message GetLaborBySponsorIDRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetLaborBySponsorID", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetLaborBySponsorIDResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetLaborBySponsorIDSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.GetLaborBySponsorIDResponse GetLaborBySponsorID(Mol.Integration.Lib.Proxies.GetLaborBySponsorIDRequest request);

        // CODEGEN: Generating message contract since message GetEstablishmentCompanyInfoRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetEstablishmentCompanyInfo", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetEstablishmentCompanyInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetEstablishmentCompanyInfoSamisWSFaultFaul" +
            "t", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.GetEstablishmentCompanyInfoResponse GetEstablishmentCompanyInfo(Mol.Integration.Lib.Proxies.GetEstablishmentCompanyInfoRequest request);

        // CODEGEN: Generating message contract since message GetLaborVisaListRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetLaborVisaList", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetLaborVisaListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/GetLaborVisaListSamisWSFaultFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.GetLaborVisaListResponse GetLaborVisaList(Mol.Integration.Lib.Proxies.GetLaborVisaListRequest request);

        // CODEGEN: Generating message contract since message AddMolApprovalForChangeSponsorRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/AddMolApprovalForChangeSponsor", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/AddMolApprovalForChangeSponsorResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/AddMolApprovalForChangeSponsorSamisWSFaultF" +
            "ault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.AddMolApprovalForChangeSponsorResponse AddMolApprovalForChangeSponsor(Mol.Integration.Lib.Proxies.AddMolApprovalForChangeSponsorRequest request);

        // CODEGEN: Generating message contract since message AddMolApprovalForChangeOccupationRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/AddMolApprovalForChangeOccupation", ReplyAction = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/AddMolApprovalForChangeOccupationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Mol.Integration.Lib.Proxies.SamisWSFault), Action = "urn:MOI.NIC.eServices-V1/IMOL_SERVICE/AddMolApprovalForChangeOccupationSamisWSFau" +
            "ltFault", Name = "SamisWSFault", Namespace = "http://schemas.datacontract.org/2004/07/SamisFullServiceLibrary")]
        Mol.Integration.Lib.Proxies.AddMolApprovalForChangeOccupationResponse AddMolApprovalForChangeOccupation(Mol.Integration.Lib.Proxies.AddMolApprovalForChangeOccupationRequest request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetLabourFull", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class GetLabourFullRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double RquestsponsorId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public double RequestNumber;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public string lang;

        public GetLabourFullRequest()
        {
        }

        public GetLabourFullRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double RquestsponsorId, double RequestNumber, string ClientIpAddress, string lang)
        {
            this.NICHeader = NICHeader;
            this.RquestsponsorId = RquestsponsorId;
            this.RequestNumber = RequestNumber;
            this.ClientIpAddress = ClientIpAddress;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetLabourFullResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class GetLabourFullResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.IstiqdamFull GetLabourFullResult;

        public GetLabourFullResponse()
        {
        }

        public GetLabourFullResponse(Mol.Integration.Lib.Proxies.IstiqdamFull GetLabourFullResult)
        {
            this.GetLabourFullResult = GetLabourFullResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ReportEscapeSponsorees", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ReportEscapeSponsoreesRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double EscapeID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public double createdBy;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public System.DateTime ReportDate;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 4)]
        public string lang;

        public ReportEscapeSponsoreesRequest()
        {
        }

        public ReportEscapeSponsoreesRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double EscapeID, double createdBy, System.DateTime ReportDate, string ClientIpAddress, string lang)
        {
            this.NICHeader = NICHeader;
            this.EscapeID = EscapeID;
            this.createdBy = createdBy;
            this.ReportDate = ReportDate;
            this.ClientIpAddress = ClientIpAddress;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ReportEscapeSponsoreesResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ReportEscapeSponsoreesResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double ReportEscapeSponsoreesResult;

        public ReportEscapeSponsoreesResponse()
        {
        }

        public ReportEscapeSponsoreesResponse(double ReportEscapeSponsoreesResult)
        {
            this.ReportEscapeSponsoreesResult = ReportEscapeSponsoreesResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "IssueLaborVisa", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class IssueLaborVisaRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.RegisterIstiqdamRequest _IstiqdamData;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public double RequesterID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public string CallingMode;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 4)]
        public string lang;

        public IssueLaborVisaRequest()
        {
        }

        public IssueLaborVisaRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.RegisterIstiqdamRequest _IstiqdamData, double RequesterID, string CallingMode, string ClientIpAddress, string lang)
        {
            this.NICHeader = NICHeader;
            this._IstiqdamData = _IstiqdamData;
            this.RequesterID = RequesterID;
            this.CallingMode = CallingMode;
            this.ClientIpAddress = ClientIpAddress;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "IssueLaborVisaResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class IssueLaborVisaResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.RegisterIstiqdamRequest IssueLaborVisaResult;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public Mol.Integration.Lib.Proxies.RegisterIstiqdamRequest _IstiqdamData;

        public IssueLaborVisaResponse()
        {
        }

        public IssueLaborVisaResponse(Mol.Integration.Lib.Proxies.RegisterIstiqdamRequest IssueLaborVisaResult, Mol.Integration.Lib.Proxies.RegisterIstiqdamRequest _IstiqdamData)
        {
            this.IssueLaborVisaResult = IssueLaborVisaResult;
            this._IstiqdamData = _IstiqdamData;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "OpenSponsorFile", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class OpenSponsorFileRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.RegisterIstiqdamFile _FileData;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public string lang;

        public OpenSponsorFileRequest()
        {
        }

        public OpenSponsorFileRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.RegisterIstiqdamFile _FileData, string ClientIpAddress, string lang)
        {
            this.NICHeader = NICHeader;
            this._FileData = _FileData;
            this.ClientIpAddress = ClientIpAddress;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "OpenSponsorFileResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class OpenSponsorFileResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.RegisterIstiqdamFile OpenSponsorFileResult;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public Mol.Integration.Lib.Proxies.RegisterIstiqdamFile _FileData;

        public OpenSponsorFileResponse()
        {
        }

        public OpenSponsorFileResponse(Mol.Integration.Lib.Proxies.RegisterIstiqdamFile OpenSponsorFileResult, Mol.Integration.Lib.Proxies.RegisterIstiqdamFile _FileData)
        {
            this.OpenSponsorFileResult = OpenSponsorFileResult;
            this._FileData = _FileData;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateSponsorFile", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class UpdateSponsorFileRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.RegisterIstiqdamFile _FileData;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public string lang;

        public UpdateSponsorFileRequest()
        {
        }

        public UpdateSponsorFileRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.RegisterIstiqdamFile _FileData, string ClientIpAddress, string lang)
        {
            this.NICHeader = NICHeader;
            this._FileData = _FileData;
            this.ClientIpAddress = ClientIpAddress;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateSponsorFileResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class UpdateSponsorFileResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.RegisterIstiqdamFile UpdateSponsorFileResult;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public Mol.Integration.Lib.Proxies.RegisterIstiqdamFile _FileData;

        public UpdateSponsorFileResponse()
        {
        }

        public UpdateSponsorFileResponse(Mol.Integration.Lib.Proxies.RegisterIstiqdamFile UpdateSponsorFileResult, Mol.Integration.Lib.Proxies.RegisterIstiqdamFile _FileData)
        {
            this.UpdateSponsorFileResult = UpdateSponsorFileResult;
            this._FileData = _FileData;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateLaborVisa", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class UpdateLaborVisaRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double requestNumber;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public double borderNumber;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public string lang;

        public UpdateLaborVisaRequest()
        {
        }

        public UpdateLaborVisaRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double requestNumber, double borderNumber, string ClientIpAddress, string lang)
        {
            this.NICHeader = NICHeader;
            this.requestNumber = requestNumber;
            this.borderNumber = borderNumber;
            this.ClientIpAddress = ClientIpAddress;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateLaborVisaResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class UpdateLaborVisaResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public bool UpdateLaborVisaResult;

        public UpdateLaborVisaResponse()
        {
        }

        public UpdateLaborVisaResponse(bool UpdateLaborVisaResult)
        {
            this.UpdateLaborVisaResult = UpdateLaborVisaResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ListSponsoreesForTransfer", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ListSponsoreesForTransferRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double SponsorID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public double MolFileNumber;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public short MolFileLocation;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 4)]
        public string lang;

        public ListSponsoreesForTransferRequest()
        {
        }

        public ListSponsoreesForTransferRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double SponsorID, double MolFileNumber, short MolFileLocation, string ClientIpAddress, string lang)
        {
            this.NICHeader = NICHeader;
            this.SponsorID = SponsorID;
            this.MolFileNumber = MolFileNumber;
            this.MolFileLocation = MolFileLocation;
            this.ClientIpAddress = ClientIpAddress;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ListSponsoreesForTransferResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ListSponsoreesForTransferResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.MolSponsorInfo ListSponsoreesForTransferResult;

        public ListSponsoreesForTransferResponse()
        {
        }

        public ListSponsoreesForTransferResponse(Mol.Integration.Lib.Proxies.MolSponsorInfo ListSponsoreesForTransferResult)
        {
            this.ListSponsoreesForTransferResult = ListSponsoreesForTransferResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ListSponsoreesForTransferNext", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ListSponsoreesForTransferNextRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double SponsorID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public double MolFileNumber;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public short MolFileLocation;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public double NextSponsorID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 4)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 5)]
        public string lang;

        public ListSponsoreesForTransferNextRequest()
        {
        }

        public ListSponsoreesForTransferNextRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double SponsorID, double MolFileNumber, short MolFileLocation, double NextSponsorID, string ClientIpAddress, string lang)
        {
            this.NICHeader = NICHeader;
            this.SponsorID = SponsorID;
            this.MolFileNumber = MolFileNumber;
            this.MolFileLocation = MolFileLocation;
            this.NextSponsorID = NextSponsorID;
            this.ClientIpAddress = ClientIpAddress;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ListSponsoreesForTransferNextResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ListSponsoreesForTransferNextResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.MolSponsorInfo ListSponsoreesForTransferNextResult;

        public ListSponsoreesForTransferNextResponse()
        {
        }

        public ListSponsoreesForTransferNextResponse(Mol.Integration.Lib.Proxies.MolSponsorInfo ListSponsoreesForTransferNextResult)
        {
            this.ListSponsoreesForTransferNextResult = ListSponsoreesForTransferNextResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "TransferSponsorees", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class TransferSponsoreesRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.MolSponsorInfo _TransferList;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public double CrrBusinessFileNumber;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public short CrrBusinessFileLocation;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public double SponsorID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 4)]
        public double MolFileNumber;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 5)]
        public short MolFileLocation;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 6)]
        public string TransferAll;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 7)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 8)]
        public string lang;

        public TransferSponsoreesRequest()
        {
        }

        public TransferSponsoreesRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.MolSponsorInfo _TransferList, double CrrBusinessFileNumber, short CrrBusinessFileLocation, double SponsorID, double MolFileNumber, short MolFileLocation, string TransferAll, string ClientIpAddress, string lang)
        {
            this.NICHeader = NICHeader;
            this._TransferList = _TransferList;
            this.CrrBusinessFileNumber = CrrBusinessFileNumber;
            this.CrrBusinessFileLocation = CrrBusinessFileLocation;
            this.SponsorID = SponsorID;
            this.MolFileNumber = MolFileNumber;
            this.MolFileLocation = MolFileLocation;
            this.TransferAll = TransferAll;
            this.ClientIpAddress = ClientIpAddress;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "TransferSponsoreesResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class TransferSponsoreesResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public bool TransferSponsoreesResult;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public Mol.Integration.Lib.Proxies.MolSponsorInfo _TransferList;

        public TransferSponsoreesResponse()
        {
        }

        public TransferSponsoreesResponse(bool TransferSponsoreesResult, Mol.Integration.Lib.Proxies.MolSponsorInfo _TransferList)
        {
            this.TransferSponsoreesResult = TransferSponsoreesResult;
            this._TransferList = _TransferList;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ValidateAlienSponsorBusiness", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ValidateAlienSponsorBusinessRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double AlienID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public double SponsorID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public double MOlFileNumber;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public short MOLFileNumberLoc;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 4)]
        public short privateFlag;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 5)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 6)]
        public string Lang;

        public ValidateAlienSponsorBusinessRequest()
        {
        }

        public ValidateAlienSponsorBusinessRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double AlienID, double SponsorID, double MOlFileNumber, short MOLFileNumberLoc, short privateFlag, string ClientIpAddress, string Lang)
        {
            this.NICHeader = NICHeader;
            this.AlienID = AlienID;
            this.SponsorID = SponsorID;
            this.MOlFileNumber = MOlFileNumber;
            this.MOLFileNumberLoc = MOLFileNumberLoc;
            this.privateFlag = privateFlag;
            this.ClientIpAddress = ClientIpAddress;
            this.Lang = Lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ValidateAlienSponsorBusinessResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ValidateAlienSponsorBusinessResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public bool ValidateAlienSponsorBusinessResult;

        public ValidateAlienSponsorBusinessResponse()
        {
        }

        public ValidateAlienSponsorBusinessResponse(bool ValidateAlienSponsorBusinessResult)
        {
            this.ValidateAlienSponsorBusinessResult = ValidateAlienSponsorBusinessResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateAlienSponsorBusiness", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class UpdateAlienSponsorBusinessRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double AlienID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public double SponsorID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public double MOlFileNumber;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public short MOLFileNumberLoc;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 4)]
        public short privateFlag;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 5)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 6)]
        public string Lang;

        public UpdateAlienSponsorBusinessRequest()
        {
        }

        public UpdateAlienSponsorBusinessRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double AlienID, double SponsorID, double MOlFileNumber, short MOLFileNumberLoc, short privateFlag, string ClientIpAddress, string Lang)
        {
            this.NICHeader = NICHeader;
            this.AlienID = AlienID;
            this.SponsorID = SponsorID;
            this.MOlFileNumber = MOlFileNumber;
            this.MOLFileNumberLoc = MOLFileNumberLoc;
            this.privateFlag = privateFlag;
            this.ClientIpAddress = ClientIpAddress;
            this.Lang = Lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateAlienSponsorBusinessResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class UpdateAlienSponsorBusinessResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public bool UpdateAlienSponsorBusinessResult;

        public UpdateAlienSponsorBusinessResponse()
        {
        }

        public UpdateAlienSponsorBusinessResponse(bool UpdateAlienSponsorBusinessResult)
        {
            this.UpdateAlienSponsorBusinessResult = UpdateAlienSponsorBusinessResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ValidateCancelRunAWayReport", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ValidateCancelRunAWayReportRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double OPREATOR_ID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public double RunAwayID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public double RequesterID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 4)]
        public string CancelRemarks;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 5)]
        public string lang;

        public ValidateCancelRunAWayReportRequest()
        {
        }

        public ValidateCancelRunAWayReportRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double OPREATOR_ID, string ClientIpAddress, double RunAwayID, double RequesterID, string CancelRemarks, string lang)
        {
            this.NICHeader = NICHeader;
            this.OPREATOR_ID = OPREATOR_ID;
            this.ClientIpAddress = ClientIpAddress;
            this.RunAwayID = RunAwayID;
            this.RequesterID = RequesterID;
            this.CancelRemarks = CancelRemarks;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ValidateCancelRunAWayReportResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ValidateCancelRunAWayReportResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.RunAway ValidateCancelRunAWayReportResult;

        public ValidateCancelRunAWayReportResponse()
        {
        }

        public ValidateCancelRunAWayReportResponse(Mol.Integration.Lib.Proxies.RunAway ValidateCancelRunAWayReportResult)
        {
            this.ValidateCancelRunAWayReportResult = ValidateCancelRunAWayReportResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ConfirmCancelRunAwayReport", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ConfirmCancelRunAwayReportRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double OPREATOR_ID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public double RunAwayID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public double RequesterID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 4)]
        public string CancelRemarks;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 5)]
        public string lang;

        public ConfirmCancelRunAwayReportRequest()
        {
        }

        public ConfirmCancelRunAwayReportRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double OPREATOR_ID, string ClientIpAddress, double RunAwayID, double RequesterID, string CancelRemarks, string lang)
        {
            this.NICHeader = NICHeader;
            this.OPREATOR_ID = OPREATOR_ID;
            this.ClientIpAddress = ClientIpAddress;
            this.RunAwayID = RunAwayID;
            this.RequesterID = RequesterID;
            this.CancelRemarks = CancelRemarks;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ConfirmCancelRunAwayReportResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ConfirmCancelRunAwayReportResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.RunAway ConfirmCancelRunAwayReportResult;

        public ConfirmCancelRunAwayReportResponse()
        {
        }

        public ConfirmCancelRunAwayReportResponse(Mol.Integration.Lib.Proxies.RunAway ConfirmCancelRunAwayReportResult)
        {
            this.ConfirmCancelRunAwayReportResult = ConfirmCancelRunAwayReportResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ValidateCreateRunAwayReport", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ValidateCreateRunAwayReportRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double OPREATOR_ID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public double RunAwayID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public double ReporterID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 4)]
        public int RunAwayDate;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 5)]
        public string lang;

        public ValidateCreateRunAwayReportRequest()
        {
        }

        public ValidateCreateRunAwayReportRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double OPREATOR_ID, string ClientIpAddress, double RunAwayID, double ReporterID, int RunAwayDate, string lang)
        {
            this.NICHeader = NICHeader;
            this.OPREATOR_ID = OPREATOR_ID;
            this.ClientIpAddress = ClientIpAddress;
            this.RunAwayID = RunAwayID;
            this.ReporterID = ReporterID;
            this.RunAwayDate = RunAwayDate;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ValidateCreateRunAwayReportResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ValidateCreateRunAwayReportResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.RunAway ValidateCreateRunAwayReportResult;

        public ValidateCreateRunAwayReportResponse()
        {
        }

        public ValidateCreateRunAwayReportResponse(Mol.Integration.Lib.Proxies.RunAway ValidateCreateRunAwayReportResult)
        {
            this.ValidateCreateRunAwayReportResult = ValidateCreateRunAwayReportResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ConfirmCreateRunAwayReport", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ConfirmCreateRunAwayReportRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double OPREATOR_ID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public double RunAwayID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public double ReporterID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 4)]
        public int RunAwayDate;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 5)]
        public string lang;

        public ConfirmCreateRunAwayReportRequest()
        {
        }

        public ConfirmCreateRunAwayReportRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double OPREATOR_ID, string ClientIpAddress, double RunAwayID, double ReporterID, int RunAwayDate, string lang)
        {
            this.NICHeader = NICHeader;
            this.OPREATOR_ID = OPREATOR_ID;
            this.ClientIpAddress = ClientIpAddress;
            this.RunAwayID = RunAwayID;
            this.ReporterID = ReporterID;
            this.RunAwayDate = RunAwayDate;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "ConfirmCreateRunAwayReportResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class ConfirmCreateRunAwayReportResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.RunAway ConfirmCreateRunAwayReportResult;

        public ConfirmCreateRunAwayReportResponse()
        {
        }

        public ConfirmCreateRunAwayReportResponse(Mol.Integration.Lib.Proxies.RunAway ConfirmCreateRunAwayReportResult)
        {
            this.ConfirmCreateRunAwayReportResult = ConfirmCreateRunAwayReportResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetAlienVisitorInfo", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class GetAlienVisitorInfoRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double id;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public Mol.Integration.Lib.Proxies.ServiceAuthentication AuthenticationInfo;

        public GetAlienVisitorInfoRequest()
        {
        }

        public GetAlienVisitorInfoRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double id, Mol.Integration.Lib.Proxies.ServiceAuthentication AuthenticationInfo)
        {
            this.NICHeader = NICHeader;
            this.id = id;
            this.AuthenticationInfo = AuthenticationInfo;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetAlienVisitorInfoResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class GetAlienVisitorInfoResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.QueryDependentsByID_NSMol GetAlienVisitorInfoResult;

        public GetAlienVisitorInfoResponse()
        {
        }

        public GetAlienVisitorInfoResponse(Mol.Integration.Lib.Proxies.QueryDependentsByID_NSMol GetAlienVisitorInfoResult)
        {
            this.GetAlienVisitorInfoResult = GetAlienVisitorInfoResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetAlienPrisonStatus", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class GetAlienPrisonStatusRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double Iqama_ID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public double OPREATOR_ID;

        public GetAlienPrisonStatusRequest()
        {
        }

        public GetAlienPrisonStatusRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double Iqama_ID, string ClientIpAddress, double OPREATOR_ID)
        {
            this.NICHeader = NICHeader;
            this.Iqama_ID = Iqama_ID;
            this.ClientIpAddress = ClientIpAddress;
            this.OPREATOR_ID = OPREATOR_ID;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetAlienPrisonStatusResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class GetAlienPrisonStatusResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public bool GetAlienPrisonStatusResult;

        public GetAlienPrisonStatusResponse()
        {
        }

        public GetAlienPrisonStatusResponse(bool GetAlienPrisonStatusResult)
        {
            this.GetAlienPrisonStatusResult = GetAlienPrisonStatusResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CheckvehicleOwner", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class CheckvehicleOwnerRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.CheckVehicleOwner req;

        public CheckvehicleOwnerRequest()
        {
        }

        public CheckvehicleOwnerRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.CheckVehicleOwner req)
        {
            this.NICHeader = NICHeader;
            this.req = req;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CheckvehicleOwnerResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class CheckvehicleOwnerResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public bool CheckvehicleOwnerResult;

        public CheckvehicleOwnerResponse()
        {
        }

        public CheckvehicleOwnerResponse(bool CheckvehicleOwnerResult)
        {
            this.CheckvehicleOwnerResult = CheckvehicleOwnerResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "QueryWorkPermit", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class QueryWorkPermitRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.QueryWorkPermitReq req;

        public QueryWorkPermitRequest()
        {
        }

        public QueryWorkPermitRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.QueryWorkPermitReq req)
        {
            this.NICHeader = NICHeader;
            this.req = req;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "QueryWorkPermitResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class QueryWorkPermitResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.QueryWorkPermitRes QueryWorkPermitResult;

        public QueryWorkPermitResponse()
        {
        }

        public QueryWorkPermitResponse(Mol.Integration.Lib.Proxies.QueryWorkPermitRes QueryWorkPermitResult)
        {
            this.QueryWorkPermitResult = QueryWorkPermitResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "AuthenticateUserByMobile", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class AuthenticateUserByMobileRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double SamisID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public string OneTimePAssword;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public string lang;

        public AuthenticateUserByMobileRequest()
        {
        }

        public AuthenticateUserByMobileRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double SamisID, string OneTimePAssword, string ClientIpAddress, string lang)
        {
            this.NICHeader = NICHeader;
            this.SamisID = SamisID;
            this.OneTimePAssword = OneTimePAssword;
            this.ClientIpAddress = ClientIpAddress;
            this.lang = lang;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "AuthenticateUserByMobileResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class AuthenticateUserByMobileResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public bool AuthenticateUserByMobileResult;

        public AuthenticateUserByMobileResponse()
        {
        }

        public AuthenticateUserByMobileResponse(bool AuthenticateUserByMobileResult)
        {
            this.AuthenticateUserByMobileResult = AuthenticateUserByMobileResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "IssueWorkPermit", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class IssueWorkPermitRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.IssueWorkPermitReq req;

        public IssueWorkPermitRequest()
        {
        }

        public IssueWorkPermitRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.IssueWorkPermitReq req)
        {
            this.NICHeader = NICHeader;
            this.req = req;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "IssueWorkPermitResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class IssueWorkPermitResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.IssueWorkPermitRes IssueWorkPermitResult;

        public IssueWorkPermitResponse()
        {
        }

        public IssueWorkPermitResponse(Mol.Integration.Lib.Proxies.IssueWorkPermitRes IssueWorkPermitResult)
        {
            this.IssueWorkPermitResult = IssueWorkPermitResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetLaborBySponsorID", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class GetLaborBySponsorIDRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double id;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public double lastID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public double Operator_ID;

        public GetLaborBySponsorIDRequest()
        {
        }

        public GetLaborBySponsorIDRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double id, double lastID, string ClientIpAddress, double Operator_ID)
        {
            this.NICHeader = NICHeader;
            this.id = id;
            this.lastID = lastID;
            this.ClientIpAddress = ClientIpAddress;
            this.Operator_ID = Operator_ID;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetLaborBySponsorIDResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class GetLaborBySponsorIDResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.MOLLaborBySponsorID GetLaborBySponsorIDResult;

        public GetLaborBySponsorIDResponse()
        {
        }

        public GetLaborBySponsorIDResponse(Mol.Integration.Lib.Proxies.MOLLaborBySponsorID GetLaborBySponsorIDResult)
        {
            this.GetLaborBySponsorIDResult = GetLaborBySponsorIDResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetEstablishmentCompanyInfo", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class GetEstablishmentCompanyInfoRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double CompID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public double Operator_ID;

        public GetEstablishmentCompanyInfoRequest()
        {
        }

        public GetEstablishmentCompanyInfoRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double CompID, string ClientIpAddress, double Operator_ID)
        {
            this.NICHeader = NICHeader;
            this.CompID = CompID;
            this.ClientIpAddress = ClientIpAddress;
            this.Operator_ID = Operator_ID;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetEstablishmentCompanyInfoResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class GetEstablishmentCompanyInfoResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.MOL_Business_Info GetEstablishmentCompanyInfoResult;

        public GetEstablishmentCompanyInfoResponse()
        {
        }

        public GetEstablishmentCompanyInfoResponse(Mol.Integration.Lib.Proxies.MOL_Business_Info GetEstablishmentCompanyInfoResult)
        {
            this.GetEstablishmentCompanyInfoResult = GetEstablishmentCompanyInfoResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetLaborVisaList", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class GetLaborVisaListRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public double BorderID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 1)]
        public double VisaNo;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 2)]
        public double LastBorderID;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 3)]
        public string ClientIpAddress;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 4)]
        public double Operator_ID;

        public GetLaborVisaListRequest()
        {
        }

        public GetLaborVisaListRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double BorderID, double VisaNo, double LastBorderID, string ClientIpAddress, double Operator_ID)
        {
            this.NICHeader = NICHeader;
            this.BorderID = BorderID;
            this.VisaNo = VisaNo;
            this.LastBorderID = LastBorderID;
            this.ClientIpAddress = ClientIpAddress;
            this.Operator_ID = Operator_ID;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetLaborVisaListResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class GetLaborVisaListResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.MOLLaborVisa GetLaborVisaListResult;

        public GetLaborVisaListResponse()
        {
        }

        public GetLaborVisaListResponse(Mol.Integration.Lib.Proxies.MOLLaborVisa GetLaborVisaListResult)
        {
            this.GetLaborVisaListResult = GetLaborVisaListResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "AddMolApprovalForChangeSponsor", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class AddMolApprovalForChangeSponsorRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.AddMolApprovalForChangeSponsorReq req;

        public AddMolApprovalForChangeSponsorRequest()
        {
        }

        public AddMolApprovalForChangeSponsorRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.AddMolApprovalForChangeSponsorReq req)
        {
            this.NICHeader = NICHeader;
            this.req = req;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "AddMolApprovalForChangeSponsorResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class AddMolApprovalForChangeSponsorResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.AddMolApprovalForChangeSponsorRes AddMolApprovalForChangeSponsorResult;

        public AddMolApprovalForChangeSponsorResponse()
        {
        }

        public AddMolApprovalForChangeSponsorResponse(Mol.Integration.Lib.Proxies.AddMolApprovalForChangeSponsorRes AddMolApprovalForChangeSponsorResult)
        {
            this.AddMolApprovalForChangeSponsorResult = AddMolApprovalForChangeSponsorResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "AddMolApprovalForChangeOccupation", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class AddMolApprovalForChangeOccupationRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://NicWebServiceHeader")]
        public Mol.Integration.Lib.Proxies.NICHeader NICHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.AddMolApprovalForChangeOccupationReq req;

        public AddMolApprovalForChangeOccupationRequest()
        {
        }

        public AddMolApprovalForChangeOccupationRequest(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.AddMolApprovalForChangeOccupationReq req)
        {
            this.NICHeader = NICHeader;
            this.req = req;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "AddMolApprovalForChangeOccupationResponse", WrapperNamespace = "urn:MOI.NIC.eServices-V1", IsWrapped = true)]
    public partial class AddMolApprovalForChangeOccupationResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:MOI.NIC.eServices-V1", Order = 0)]
        public Mol.Integration.Lib.Proxies.AddMolApprovalForChangeOccupationRes AddMolApprovalForChangeOccupationResult;

        public AddMolApprovalForChangeOccupationResponse()
        {
        }

        public AddMolApprovalForChangeOccupationResponse(Mol.Integration.Lib.Proxies.AddMolApprovalForChangeOccupationRes AddMolApprovalForChangeOccupationResult)
        {
            this.AddMolApprovalForChangeOccupationResult = AddMolApprovalForChangeOccupationResult;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IMOL_SERVICEChannel : Mol.Integration.Lib.Proxies.IMOL_SERVICE, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class MOL_SERVICEClient : System.ServiceModel.ClientBase<Mol.Integration.Lib.Proxies.IMOL_SERVICE>, Mol.Integration.Lib.Proxies.IMOL_SERVICE
    {

        public MOL_SERVICEClient()
        {
        }

        public MOL_SERVICEClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public MOL_SERVICEClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public MOL_SERVICEClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public MOL_SERVICEClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.GetLabourFullResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.GetLabourFull(Mol.Integration.Lib.Proxies.GetLabourFullRequest request)
        {
            return base.Channel.GetLabourFull(request);
        }

        public Mol.Integration.Lib.Proxies.IstiqdamFull GetLabourFull(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double RquestsponsorId, double RequestNumber, string ClientIpAddress, string lang)
        {
            Mol.Integration.Lib.Proxies.GetLabourFullRequest inValue = new Mol.Integration.Lib.Proxies.GetLabourFullRequest();
            inValue.NICHeader = NICHeader;
            inValue.RquestsponsorId = RquestsponsorId;
            inValue.RequestNumber = RequestNumber;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.GetLabourFullResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).GetLabourFull(inValue);
            return retVal.GetLabourFullResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.ReportEscapeSponsoreesResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.ReportEscapeSponsorees(Mol.Integration.Lib.Proxies.ReportEscapeSponsoreesRequest request)
        {
            return base.Channel.ReportEscapeSponsorees(request);
        }

        public double ReportEscapeSponsorees(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double EscapeID, double createdBy, System.DateTime ReportDate, string ClientIpAddress, string lang)
        {
            Mol.Integration.Lib.Proxies.ReportEscapeSponsoreesRequest inValue = new Mol.Integration.Lib.Proxies.ReportEscapeSponsoreesRequest();
            inValue.NICHeader = NICHeader;
            inValue.EscapeID = EscapeID;
            inValue.createdBy = createdBy;
            inValue.ReportDate = ReportDate;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.ReportEscapeSponsoreesResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).ReportEscapeSponsorees(inValue);
            return retVal.ReportEscapeSponsoreesResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.IssueLaborVisaResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.IssueLaborVisa(Mol.Integration.Lib.Proxies.IssueLaborVisaRequest request)
        {
            return base.Channel.IssueLaborVisa(request);
        }

        public Mol.Integration.Lib.Proxies.RegisterIstiqdamRequest IssueLaborVisa(Mol.Integration.Lib.Proxies.NICHeader NICHeader, ref Mol.Integration.Lib.Proxies.RegisterIstiqdamRequest _IstiqdamData, double RequesterID, string CallingMode, string ClientIpAddress, string lang)
        {
            Mol.Integration.Lib.Proxies.IssueLaborVisaRequest inValue = new Mol.Integration.Lib.Proxies.IssueLaborVisaRequest();
            inValue.NICHeader = NICHeader;
            inValue._IstiqdamData = _IstiqdamData;
            inValue.RequesterID = RequesterID;
            inValue.CallingMode = CallingMode;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.IssueLaborVisaResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).IssueLaborVisa(inValue);
            _IstiqdamData = retVal._IstiqdamData;
            return retVal.IssueLaborVisaResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.OpenSponsorFileResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.OpenSponsorFile(Mol.Integration.Lib.Proxies.OpenSponsorFileRequest request)
        {
            return base.Channel.OpenSponsorFile(request);
        }

        public Mol.Integration.Lib.Proxies.RegisterIstiqdamFile OpenSponsorFile(Mol.Integration.Lib.Proxies.NICHeader NICHeader, ref Mol.Integration.Lib.Proxies.RegisterIstiqdamFile _FileData, string ClientIpAddress, string lang)
        {
            Mol.Integration.Lib.Proxies.OpenSponsorFileRequest inValue = new Mol.Integration.Lib.Proxies.OpenSponsorFileRequest();
            inValue.NICHeader = NICHeader;
            inValue._FileData = _FileData;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.OpenSponsorFileResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).OpenSponsorFile(inValue);
            _FileData = retVal._FileData;
            return retVal.OpenSponsorFileResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.UpdateSponsorFileResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.UpdateSponsorFile(Mol.Integration.Lib.Proxies.UpdateSponsorFileRequest request)
        {
            return base.Channel.UpdateSponsorFile(request);
        }

        public Mol.Integration.Lib.Proxies.RegisterIstiqdamFile UpdateSponsorFile(Mol.Integration.Lib.Proxies.NICHeader NICHeader, ref Mol.Integration.Lib.Proxies.RegisterIstiqdamFile _FileData, string ClientIpAddress, string lang)
        {
            Mol.Integration.Lib.Proxies.UpdateSponsorFileRequest inValue = new Mol.Integration.Lib.Proxies.UpdateSponsorFileRequest();
            inValue.NICHeader = NICHeader;
            inValue._FileData = _FileData;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.UpdateSponsorFileResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).UpdateSponsorFile(inValue);
            _FileData = retVal._FileData;
            return retVal.UpdateSponsorFileResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.UpdateLaborVisaResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.UpdateLaborVisa(Mol.Integration.Lib.Proxies.UpdateLaborVisaRequest request)
        {
            return base.Channel.UpdateLaborVisa(request);
        }

        public bool UpdateLaborVisa(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double requestNumber, double borderNumber, string ClientIpAddress, string lang)
        {
            Mol.Integration.Lib.Proxies.UpdateLaborVisaRequest inValue = new Mol.Integration.Lib.Proxies.UpdateLaborVisaRequest();
            inValue.NICHeader = NICHeader;
            inValue.requestNumber = requestNumber;
            inValue.borderNumber = borderNumber;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.UpdateLaborVisaResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).UpdateLaborVisa(inValue);
            return retVal.UpdateLaborVisaResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.ListSponsoreesForTransferResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.ListSponsoreesForTransfer(Mol.Integration.Lib.Proxies.ListSponsoreesForTransferRequest request)
        {
            return base.Channel.ListSponsoreesForTransfer(request);
        }

        public Mol.Integration.Lib.Proxies.MolSponsorInfo ListSponsoreesForTransfer(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double SponsorID, double MolFileNumber, short MolFileLocation, string ClientIpAddress, string lang)
        {
            Mol.Integration.Lib.Proxies.ListSponsoreesForTransferRequest inValue = new Mol.Integration.Lib.Proxies.ListSponsoreesForTransferRequest();
            inValue.NICHeader = NICHeader;
            inValue.SponsorID = SponsorID;
            inValue.MolFileNumber = MolFileNumber;
            inValue.MolFileLocation = MolFileLocation;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.ListSponsoreesForTransferResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).ListSponsoreesForTransfer(inValue);
            return retVal.ListSponsoreesForTransferResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.ListSponsoreesForTransferNextResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.ListSponsoreesForTransferNext(Mol.Integration.Lib.Proxies.ListSponsoreesForTransferNextRequest request)
        {
            return base.Channel.ListSponsoreesForTransferNext(request);
        }

        public Mol.Integration.Lib.Proxies.MolSponsorInfo ListSponsoreesForTransferNext(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double SponsorID, double MolFileNumber, short MolFileLocation, double NextSponsorID, string ClientIpAddress, string lang)
        {
            Mol.Integration.Lib.Proxies.ListSponsoreesForTransferNextRequest inValue = new Mol.Integration.Lib.Proxies.ListSponsoreesForTransferNextRequest();
            inValue.NICHeader = NICHeader;
            inValue.SponsorID = SponsorID;
            inValue.MolFileNumber = MolFileNumber;
            inValue.MolFileLocation = MolFileLocation;
            inValue.NextSponsorID = NextSponsorID;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.ListSponsoreesForTransferNextResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).ListSponsoreesForTransferNext(inValue);
            return retVal.ListSponsoreesForTransferNextResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.TransferSponsoreesResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.TransferSponsorees(Mol.Integration.Lib.Proxies.TransferSponsoreesRequest request)
        {
            return base.Channel.TransferSponsorees(request);
        }

        public bool TransferSponsorees(Mol.Integration.Lib.Proxies.NICHeader NICHeader, ref Mol.Integration.Lib.Proxies.MolSponsorInfo _TransferList, double CrrBusinessFileNumber, short CrrBusinessFileLocation, double SponsorID, double MolFileNumber, short MolFileLocation, string TransferAll, string ClientIpAddress, string lang)
        {
            Mol.Integration.Lib.Proxies.TransferSponsoreesRequest inValue = new Mol.Integration.Lib.Proxies.TransferSponsoreesRequest();
            inValue.NICHeader = NICHeader;
            inValue._TransferList = _TransferList;
            inValue.CrrBusinessFileNumber = CrrBusinessFileNumber;
            inValue.CrrBusinessFileLocation = CrrBusinessFileLocation;
            inValue.SponsorID = SponsorID;
            inValue.MolFileNumber = MolFileNumber;
            inValue.MolFileLocation = MolFileLocation;
            inValue.TransferAll = TransferAll;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.TransferSponsoreesResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).TransferSponsorees(inValue);
            _TransferList = retVal._TransferList;
            return retVal.TransferSponsoreesResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.ValidateAlienSponsorBusinessResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.ValidateAlienSponsorBusiness(Mol.Integration.Lib.Proxies.ValidateAlienSponsorBusinessRequest request)
        {
            return base.Channel.ValidateAlienSponsorBusiness(request);
        }

        public bool ValidateAlienSponsorBusiness(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double AlienID, double SponsorID, double MOlFileNumber, short MOLFileNumberLoc, short privateFlag, string ClientIpAddress, string Lang)
        {
            Mol.Integration.Lib.Proxies.ValidateAlienSponsorBusinessRequest inValue = new Mol.Integration.Lib.Proxies.ValidateAlienSponsorBusinessRequest();
            inValue.NICHeader = NICHeader;
            inValue.AlienID = AlienID;
            inValue.SponsorID = SponsorID;
            inValue.MOlFileNumber = MOlFileNumber;
            inValue.MOLFileNumberLoc = MOLFileNumberLoc;
            inValue.privateFlag = privateFlag;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.Lang = Lang;
            Mol.Integration.Lib.Proxies.ValidateAlienSponsorBusinessResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).ValidateAlienSponsorBusiness(inValue);
            return retVal.ValidateAlienSponsorBusinessResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.UpdateAlienSponsorBusinessResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.UpdateAlienSponsorBusiness(Mol.Integration.Lib.Proxies.UpdateAlienSponsorBusinessRequest request)
        {
            return base.Channel.UpdateAlienSponsorBusiness(request);
        }

        public bool UpdateAlienSponsorBusiness(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double AlienID, double SponsorID, double MOlFileNumber, short MOLFileNumberLoc, short privateFlag, string ClientIpAddress, string Lang)
        {
            Mol.Integration.Lib.Proxies.UpdateAlienSponsorBusinessRequest inValue = new Mol.Integration.Lib.Proxies.UpdateAlienSponsorBusinessRequest();
            inValue.NICHeader = NICHeader;
            inValue.AlienID = AlienID;
            inValue.SponsorID = SponsorID;
            inValue.MOlFileNumber = MOlFileNumber;
            inValue.MOLFileNumberLoc = MOLFileNumberLoc;
            inValue.privateFlag = privateFlag;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.Lang = Lang;
            Mol.Integration.Lib.Proxies.UpdateAlienSponsorBusinessResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).UpdateAlienSponsorBusiness(inValue);
            return retVal.UpdateAlienSponsorBusinessResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.ValidateCancelRunAWayReportResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.ValidateCancelRunAWayReport(Mol.Integration.Lib.Proxies.ValidateCancelRunAWayReportRequest request)
        {
            return base.Channel.ValidateCancelRunAWayReport(request);
        }

        public Mol.Integration.Lib.Proxies.RunAway ValidateCancelRunAWayReport(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double OPREATOR_ID, string ClientIpAddress, double RunAwayID, double RequesterID, string CancelRemarks, string lang)
        {
            Mol.Integration.Lib.Proxies.ValidateCancelRunAWayReportRequest inValue = new Mol.Integration.Lib.Proxies.ValidateCancelRunAWayReportRequest();
            inValue.NICHeader = NICHeader;
            inValue.OPREATOR_ID = OPREATOR_ID;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.RunAwayID = RunAwayID;
            inValue.RequesterID = RequesterID;
            inValue.CancelRemarks = CancelRemarks;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.ValidateCancelRunAWayReportResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).ValidateCancelRunAWayReport(inValue);
            return retVal.ValidateCancelRunAWayReportResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.ConfirmCancelRunAwayReportResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.ConfirmCancelRunAwayReport(Mol.Integration.Lib.Proxies.ConfirmCancelRunAwayReportRequest request)
        {
            return base.Channel.ConfirmCancelRunAwayReport(request);
        }

        public Mol.Integration.Lib.Proxies.RunAway ConfirmCancelRunAwayReport(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double OPREATOR_ID, string ClientIpAddress, double RunAwayID, double RequesterID, string CancelRemarks, string lang)
        {
            Mol.Integration.Lib.Proxies.ConfirmCancelRunAwayReportRequest inValue = new Mol.Integration.Lib.Proxies.ConfirmCancelRunAwayReportRequest();
            inValue.NICHeader = NICHeader;
            inValue.OPREATOR_ID = OPREATOR_ID;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.RunAwayID = RunAwayID;
            inValue.RequesterID = RequesterID;
            inValue.CancelRemarks = CancelRemarks;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.ConfirmCancelRunAwayReportResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).ConfirmCancelRunAwayReport(inValue);
            return retVal.ConfirmCancelRunAwayReportResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.ValidateCreateRunAwayReportResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.ValidateCreateRunAwayReport(Mol.Integration.Lib.Proxies.ValidateCreateRunAwayReportRequest request)
        {
            return base.Channel.ValidateCreateRunAwayReport(request);
        }

        public Mol.Integration.Lib.Proxies.RunAway ValidateCreateRunAwayReport(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double OPREATOR_ID, string ClientIpAddress, double RunAwayID, double ReporterID, int RunAwayDate, string lang)
        {
            Mol.Integration.Lib.Proxies.ValidateCreateRunAwayReportRequest inValue = new Mol.Integration.Lib.Proxies.ValidateCreateRunAwayReportRequest();
            inValue.NICHeader = NICHeader;
            inValue.OPREATOR_ID = OPREATOR_ID;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.RunAwayID = RunAwayID;
            inValue.ReporterID = ReporterID;
            inValue.RunAwayDate = RunAwayDate;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.ValidateCreateRunAwayReportResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).ValidateCreateRunAwayReport(inValue);
            return retVal.ValidateCreateRunAwayReportResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.ConfirmCreateRunAwayReportResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.ConfirmCreateRunAwayReport(Mol.Integration.Lib.Proxies.ConfirmCreateRunAwayReportRequest request)
        {
            return base.Channel.ConfirmCreateRunAwayReport(request);
        }

        public Mol.Integration.Lib.Proxies.RunAway ConfirmCreateRunAwayReport(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double OPREATOR_ID, string ClientIpAddress, double RunAwayID, double ReporterID, int RunAwayDate, string lang)
        {
            Mol.Integration.Lib.Proxies.ConfirmCreateRunAwayReportRequest inValue = new Mol.Integration.Lib.Proxies.ConfirmCreateRunAwayReportRequest();
            inValue.NICHeader = NICHeader;
            inValue.OPREATOR_ID = OPREATOR_ID;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.RunAwayID = RunAwayID;
            inValue.ReporterID = ReporterID;
            inValue.RunAwayDate = RunAwayDate;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.ConfirmCreateRunAwayReportResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).ConfirmCreateRunAwayReport(inValue);
            return retVal.ConfirmCreateRunAwayReportResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.GetAlienVisitorInfoResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.GetAlienVisitorInfo(Mol.Integration.Lib.Proxies.GetAlienVisitorInfoRequest request)
        {
            return base.Channel.GetAlienVisitorInfo(request);
        }

        public Mol.Integration.Lib.Proxies.QueryDependentsByID_NSMol GetAlienVisitorInfo(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double id, Mol.Integration.Lib.Proxies.ServiceAuthentication AuthenticationInfo)
        {
            Mol.Integration.Lib.Proxies.GetAlienVisitorInfoRequest inValue = new Mol.Integration.Lib.Proxies.GetAlienVisitorInfoRequest();
            inValue.NICHeader = NICHeader;
            inValue.id = id;
            inValue.AuthenticationInfo = AuthenticationInfo;
            Mol.Integration.Lib.Proxies.GetAlienVisitorInfoResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).GetAlienVisitorInfo(inValue);
            return retVal.GetAlienVisitorInfoResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.GetAlienPrisonStatusResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.GetAlienPrisonStatus(Mol.Integration.Lib.Proxies.GetAlienPrisonStatusRequest request)
        {
            return base.Channel.GetAlienPrisonStatus(request);
        }

        public bool GetAlienPrisonStatus(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double Iqama_ID, string ClientIpAddress, double OPREATOR_ID)
        {
            Mol.Integration.Lib.Proxies.GetAlienPrisonStatusRequest inValue = new Mol.Integration.Lib.Proxies.GetAlienPrisonStatusRequest();
            inValue.NICHeader = NICHeader;
            inValue.Iqama_ID = Iqama_ID;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.OPREATOR_ID = OPREATOR_ID;
            Mol.Integration.Lib.Proxies.GetAlienPrisonStatusResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).GetAlienPrisonStatus(inValue);
            return retVal.GetAlienPrisonStatusResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.CheckvehicleOwnerResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.CheckvehicleOwner(Mol.Integration.Lib.Proxies.CheckvehicleOwnerRequest request)
        {
            return base.Channel.CheckvehicleOwner(request);
        }

        public bool CheckvehicleOwner(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.CheckVehicleOwner req)
        {
            Mol.Integration.Lib.Proxies.CheckvehicleOwnerRequest inValue = new Mol.Integration.Lib.Proxies.CheckvehicleOwnerRequest();
            inValue.NICHeader = NICHeader;
            inValue.req = req;
            Mol.Integration.Lib.Proxies.CheckvehicleOwnerResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).CheckvehicleOwner(inValue);
            return retVal.CheckvehicleOwnerResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.QueryWorkPermitResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.QueryWorkPermit(Mol.Integration.Lib.Proxies.QueryWorkPermitRequest request)
        {
            return base.Channel.QueryWorkPermit(request);
        }

        public Mol.Integration.Lib.Proxies.QueryWorkPermitRes QueryWorkPermit(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.QueryWorkPermitReq req)
        {
            Mol.Integration.Lib.Proxies.QueryWorkPermitRequest inValue = new Mol.Integration.Lib.Proxies.QueryWorkPermitRequest();
            inValue.NICHeader = NICHeader;
            inValue.req = req;
            Mol.Integration.Lib.Proxies.QueryWorkPermitResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).QueryWorkPermit(inValue);
            return retVal.QueryWorkPermitResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.AuthenticateUserByMobileResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.AuthenticateUserByMobile(Mol.Integration.Lib.Proxies.AuthenticateUserByMobileRequest request)
        {
            return base.Channel.AuthenticateUserByMobile(request);
        }

        public bool AuthenticateUserByMobile(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double SamisID, string OneTimePAssword, string ClientIpAddress, string lang)
        {
            Mol.Integration.Lib.Proxies.AuthenticateUserByMobileRequest inValue = new Mol.Integration.Lib.Proxies.AuthenticateUserByMobileRequest();
            inValue.NICHeader = NICHeader;
            inValue.SamisID = SamisID;
            inValue.OneTimePAssword = OneTimePAssword;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.lang = lang;
            Mol.Integration.Lib.Proxies.AuthenticateUserByMobileResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).AuthenticateUserByMobile(inValue);
            return retVal.AuthenticateUserByMobileResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.IssueWorkPermitResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.IssueWorkPermit(Mol.Integration.Lib.Proxies.IssueWorkPermitRequest request)
        {
            return base.Channel.IssueWorkPermit(request);
        }

        public Mol.Integration.Lib.Proxies.IssueWorkPermitRes IssueWorkPermit(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.IssueWorkPermitReq req)
        {
            Mol.Integration.Lib.Proxies.IssueWorkPermitRequest inValue = new Mol.Integration.Lib.Proxies.IssueWorkPermitRequest();
            inValue.NICHeader = NICHeader;
            inValue.req = req;
            Mol.Integration.Lib.Proxies.IssueWorkPermitResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).IssueWorkPermit(inValue);
            return retVal.IssueWorkPermitResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.GetLaborBySponsorIDResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.GetLaborBySponsorID(Mol.Integration.Lib.Proxies.GetLaborBySponsorIDRequest request)
        {
            return base.Channel.GetLaborBySponsorID(request);
        }

        public Mol.Integration.Lib.Proxies.MOLLaborBySponsorID GetLaborBySponsorID(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double id, double lastID, string ClientIpAddress, double Operator_ID)
        {
            Mol.Integration.Lib.Proxies.GetLaborBySponsorIDRequest inValue = new Mol.Integration.Lib.Proxies.GetLaborBySponsorIDRequest();
            inValue.NICHeader = NICHeader;
            inValue.id = id;
            inValue.lastID = lastID;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.Operator_ID = Operator_ID;
            Mol.Integration.Lib.Proxies.GetLaborBySponsorIDResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).GetLaborBySponsorID(inValue);
            return retVal.GetLaborBySponsorIDResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.GetEstablishmentCompanyInfoResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.GetEstablishmentCompanyInfo(Mol.Integration.Lib.Proxies.GetEstablishmentCompanyInfoRequest request)
        {
            return base.Channel.GetEstablishmentCompanyInfo(request);
        }

        public Mol.Integration.Lib.Proxies.MOL_Business_Info GetEstablishmentCompanyInfo(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double CompID, string ClientIpAddress, double Operator_ID)
        {
            Mol.Integration.Lib.Proxies.GetEstablishmentCompanyInfoRequest inValue = new Mol.Integration.Lib.Proxies.GetEstablishmentCompanyInfoRequest();
            inValue.NICHeader = NICHeader;
            inValue.CompID = CompID;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.Operator_ID = Operator_ID;
            Mol.Integration.Lib.Proxies.GetEstablishmentCompanyInfoResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).GetEstablishmentCompanyInfo(inValue);
            return retVal.GetEstablishmentCompanyInfoResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.GetLaborVisaListResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.GetLaborVisaList(Mol.Integration.Lib.Proxies.GetLaborVisaListRequest request)
        {
            return base.Channel.GetLaborVisaList(request);
        }

        public Mol.Integration.Lib.Proxies.MOLLaborVisa GetLaborVisaList(Mol.Integration.Lib.Proxies.NICHeader NICHeader, double BorderID, double VisaNo, double LastBorderID, string ClientIpAddress, double Operator_ID)
        {
            Mol.Integration.Lib.Proxies.GetLaborVisaListRequest inValue = new Mol.Integration.Lib.Proxies.GetLaborVisaListRequest();
            inValue.NICHeader = NICHeader;
            inValue.BorderID = BorderID;
            inValue.VisaNo = VisaNo;
            inValue.LastBorderID = LastBorderID;
            inValue.ClientIpAddress = ClientIpAddress;
            inValue.Operator_ID = Operator_ID;
            Mol.Integration.Lib.Proxies.GetLaborVisaListResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).GetLaborVisaList(inValue);
            return retVal.GetLaborVisaListResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.AddMolApprovalForChangeSponsorResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.AddMolApprovalForChangeSponsor(Mol.Integration.Lib.Proxies.AddMolApprovalForChangeSponsorRequest request)
        {
            return base.Channel.AddMolApprovalForChangeSponsor(request);
        }

        public Mol.Integration.Lib.Proxies.AddMolApprovalForChangeSponsorRes AddMolApprovalForChangeSponsor(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.AddMolApprovalForChangeSponsorReq req)
        {
            Mol.Integration.Lib.Proxies.AddMolApprovalForChangeSponsorRequest inValue = new Mol.Integration.Lib.Proxies.AddMolApprovalForChangeSponsorRequest();
            inValue.NICHeader = NICHeader;
            inValue.req = req;
            Mol.Integration.Lib.Proxies.AddMolApprovalForChangeSponsorResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).AddMolApprovalForChangeSponsor(inValue);
            return retVal.AddMolApprovalForChangeSponsorResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mol.Integration.Lib.Proxies.AddMolApprovalForChangeOccupationResponse Mol.Integration.Lib.Proxies.IMOL_SERVICE.AddMolApprovalForChangeOccupation(Mol.Integration.Lib.Proxies.AddMolApprovalForChangeOccupationRequest request)
        {
            return base.Channel.AddMolApprovalForChangeOccupation(request);
        }

        public Mol.Integration.Lib.Proxies.AddMolApprovalForChangeOccupationRes AddMolApprovalForChangeOccupation(Mol.Integration.Lib.Proxies.NICHeader NICHeader, Mol.Integration.Lib.Proxies.AddMolApprovalForChangeOccupationReq req)
        {
            Mol.Integration.Lib.Proxies.AddMolApprovalForChangeOccupationRequest inValue = new Mol.Integration.Lib.Proxies.AddMolApprovalForChangeOccupationRequest();
            inValue.NICHeader = NICHeader;
            inValue.req = req;
            Mol.Integration.Lib.Proxies.AddMolApprovalForChangeOccupationResponse retVal = ((Mol.Integration.Lib.Proxies.IMOL_SERVICE)(this)).AddMolApprovalForChangeOccupation(inValue);
            return retVal.AddMolApprovalForChangeOccupationResult;
        }
    }

}
