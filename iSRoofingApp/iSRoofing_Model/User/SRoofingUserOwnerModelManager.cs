using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;

using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.User
{
    public class SRoofingUserOwnerModelManager
    {
        public SRoofingUserOwnerModelManager ( )
        {
        }



        public SRoofingUserOwnerModelManager ( string OwnerUserTokenID , string OwnerMobileNumberTokenID )
        {
            this.OwnerUserTokenID = OwnerUserTokenID;
            this.OwnerMobileNumberTokenID = OwnerMobileNumberTokenID;
        }


        ////////public SRoofingUserOwnerModelManager (
        ////////    string OwnerUserTokenID ,
        ////////    string OwnerMobileNumberTokenID ,
        ////////    string ApplicationRoleCode ,
        ////////    string ProjectRoleCode )
        ////////    {
        ////////    this.OwnerUserTokenID = OwnerUserTokenID;
        ////////    this.OwnerMobileNumberTokenID = OwnerMobileNumberTokenID;
        ////////    this.ApplicationRoleCode = ApplicationRoleCode;
        ////////    _ProjectRoleCode = ProjectRoleCode;

        ////////    this.FirstName = "1101appdriver";
        ////////    this.LastName = "1101appdriver";
        ////////    _FullName = this.FirstName + " " + this.LastName;

        ////////    }



        public string Gender { get; set; } = SRoofingEnum_Gender.Gender_MALE;



        // Public Sub New(UserID As String)
        // _UserID = UserID
        // End Sub
        // Public Sub New(UserID As String, MobileNumberID As String)
        // _UserID = UserID
        // _MobileNumberID = MobileNumberID
        // End Sub


        // Public Sub New(
        // AccountType As String,
        // OwnerUserTokenID As String,
        // OwnerMobileNumberTokenID As String,
        // ClientTokenID As String,
        // ClientName As String,
        // ProjectTokenID As String,
        // ProjectName As String,
        // AddressLine As String,
        // CityName As String,
        // CountryCode As String,
        // CountryName As String,
        // PostCode As String,
        // LastName As String,
        // FullName As String,
        // ActiveStatus As String)

        // '_AccountTypeProfile = AccountTypeProfile

        // '_UserID = UserID
        // '_MobileNumberID = MobileNumberID

        // '_FirstName = FirstName
        // '_LastName = LastName

        // '_FullName = FullName

        // '_NameLine = NameLine
        // '_LocationLine = LocationLine

        // '_FirstName = FirstName
        // '_FullName = FullName

        // End Sub


        // Public Sub New(
        // AccountTypeProfile As String,
        // OwnerUseTokenID As String,
        // UserID As String,
        // MobileNumberID As String,
        // FirstName As String,
        // LastName As String,
        // FullName As String,
        // NameLine As String,
        // LocationLine As String)

        // _AccountTypeProfile = AccountTypeProfile

        // _OwnerUseTokenID = OwnerUseTokenID

        // _UserID = UserID
        // _MobileNumberID = MobileNumberID

        // _FirstName = FirstName
        // _LastName = LastName

        // _FullName = FullName

        // _NameLine = NameLine
        // _LocationLine = LocationLine

        // '_FirstName = FirstName
        // '_FullName = FullName

        // End Sub




        // ''''Public Sub New(
        // ''''              AccountTypeProfile As String,
        // ''''              OwnerUseTokenID As String,
        // ''''              UserID As String,
        // ''''              MobileNumberID As String,
        // ''''              FirstName As String,
        // ''''              LastName As String,
        // ''''              FullName As String,
        // ''''              NameLine As String,
        // ''''              LocationLine As String,
        // ''''              LastName As String)

        // ''''    _AccountTypeProfile = AccountTypeProfile

        // ''''    _OwnerUseTokenID = OwnerUseTokenID

        // ''''    _UserID = UserID
        // ''''    _MobileNumberID = MobileNumberID

        // ''''    _FirstName = FirstName
        // ''''    _LastName = LastName

        // ''''    _FullName = FullName

        // ''''    _NameLine = NameLine
        // ''''    _LocationLine = LocationLine

        // ''''    '_LastName = LastName

        // ''''    '_FirstName = FirstName
        // ''''    '_FullName = FullName

        // ''''End Sub




        public string NameLine { get; set; } = "0";


        public string AccountType { get; set; } = App.iAccountType;



        public string RegisterInvitationTokenID { get; set; } = "0";


        public string OwnerUserTokenID { get; set; } = "0";


        // Private _IsNew As Boolean
        // Public Property IsNew() As Boolean
        // Get
        // Return _IsNew.ToString.ToLower
        // End Get
        // Set(ByVal value As Boolean)
        // _IsNew = value
        // End Set
        // End Property



        //private string _CompanyTokenID;

        //public string CompanyTokenID
        //    {
        //    get
        //        {
        //        return _CompanyTokenID;
        //        }

        //    set
        //        {
        //        _CompanyTokenID = value;
        //        }
        //    }

        //private string _SupplierCompanyTokenID;

        //public string SupplierCompanyTokenID
        //    {
        //    get
        //        {
        //        return _SupplierCompanyTokenID;
        //        }

        //    set
        //        {
        //        _SupplierCompanyTokenID = value;
        //        }
        //    }

        //private string _CompanyName;

        //public string CompanyName
        //    {
        //    get
        //        {
        //        return _CompanyName;
        //        }

        //    set
        //        {
        //        _CompanyName = value;
        //        }
        //    }

        //private string _SupplierCompanyName;

        //public string SupplierCompanyName
        //    {
        //    get
        //        {
        //        return _SupplierCompanyName;
        //        }

        //    set
        //        {
        //        _SupplierCompanyName = value;
        //        }
        //    }

        // Private _CategoryTokenID As String
        // Public Property CategoryTokenID() As String
        // Get
        // Return _CategoryTokenID
        // End Get
        // Set(ByVal value As String)
        // _CategoryTokenID = value
        // End Set
        // End Property

        // Private _CategoryTitle As String
        // Public Property CategoryTitle() As String
        // Get
        // Return _CategoryTitle
        // End Get
        // Set(ByVal value As String)
        // _CategoryTitle = value
        // End Set
        // End Property



        public string NationalCardID { get; set; } = "0";

        public string FirstName { get; set; } = "0";



        public string OwnerMobileNumberTokenID { get; set; } = "0";
        //{
        //get
        //    {
        //    return _OwnerMobileNumberTokenID;
        //    }

        //set
        //    {
        //    _OwnerMobileNumberTokenID = value;
        //    }
        //}


        public string ActiveStatus { get; set; } = "0";


        public string LastName { get; set; } = "0";

        public string FullName { get; set; } = "0";

        public string AddressLine { get; set; } = "0";


        public string PostCode { get; set; } = "0";


        public string CityName { get; set; } = "0";

        public string CountryCode { get; set; } = "0";


        public string CountryName { get; set; } = "0";


        public string ClientTokenID { get; set; } = "0";

        //private string _DeliveryBookingTokenID;

        //public string DeliveryBookingTokenID
        //    {
        //    get
        //        {
        //        return _DeliveryBookingTokenID;
        //        }

        //    set
        //        {
        //        _DeliveryBookingTokenID = value;
        //        }
        //    }

        public string ProjectTokenID { get; set; } = "0";



        // Private _ScreenChatShowGroupTokenID As String
        // Public Property ScreenChatShowGroupTokenID() As String
        // Get
        // Return _ScreenChatShowGroupTokenID
        // End Get
        // Set(ByVal value As String)
        // _ScreenChatShowGroupTokenID = value
        // End Set
        // End Property



        public string PrivateGroupTokenID { get; set; } = "0";

        public string GroupTokenID { get; set; } = "0";

        public string ProjectName { get; set; } = "0";

        //public string ProjectName
        //    {
        //    get
        //        {
        //        return _ProjectName;
        //        }

        //    set
        //        {
        //        _ProjectName = value;
        //        }
        //    }

        //private string _ClientName;

        //public string ClientName
        //    {
        //    get
        //        {
        //        return _ClientName;
        //        }

        //    set
        //        {
        //        _ClientName = value;
        //        }
        //    }


        public string OnlineStatus { get; set; } = SRoofingEnum_LoginStatus.LoginStatus_OFFLINE;


        public string LoginStatus { get; set; } = SRoofingEnum_LoginStatus.LoginStatus_OFFLINE;


        public string VisibleStatus { get; set; } = SRoofingEnum_LoginStatus.LoginStatus_OFFLINE;



        public string LocationLine { get; set; } = "0";


        public string AvatarImageID { get; set; } = "0";


        public bool IsVerifyEmailAddress { get; set; } = false;


        public string EmailTokenID { get; set; } = "0";


        public string YouTubeChannelID { get; set; } = "0";


        public string EmailAddress { get; set; } = "0";


        public string MobileNumberE164 { get; set; } = "0";


        public string ApplicationRoleTokenID { get; set; } = "0";


        public string ApplicationRoleCode { get; set; } = "0";


        public string ApplicationRoleName { get; set; } = "0";


        public string ProjectRoleTokenID { get; set; } = "0";


        public string ProjectRoleCode { get; set; } = "0";



        public string ProjectRoleName { get; set; } = "0";



        public string AvatarColorCode
        {
            get;
            set;
        } = "0";


        public string AvatarName { get; set; } = "0";

        public string BirthYearsOld { get; set; } = "0";


        public string BirthDay { get; set; } = "0";


        public string BirthMonth { get; set; } = "0";


        public string BirthYear { get; set; } = "0";


        public string StateName { get; set; } = "0";










    }
}
