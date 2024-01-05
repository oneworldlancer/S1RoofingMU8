using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.User
{
    public class SRoofingUserRemoteModelManager
    {
        public SRoofingUserRemoteModelManager()
        {
        }



        // public SRoofingUserRemoteModelManager ( string RemoteUserTokenID , string RemoteMobileNumberTokenID )
        //     {
        //this.    RemoteUserTokenID = RemoteUserTokenID;
        //    this.    RemoteMobileNumberTokenID = RemoteMobileNumberTokenID;
        //     }


        // public SRoofingUserRemoteModelManager (
        //     string RemoteUserTokenID ,
        //     string RemoteMobileNumberTokenID ,
        //     string ApplicationRoleCode ,
        //     string ProjectRoleCode )
        //     {
        //     this.   RemoteUserTokenID = RemoteUserTokenID;
        //      this.  RemoteMobileNumberTokenID = RemoteMobileNumberTokenID;


        //     }



        //public bool IsOpen { get; set; }



        public string iViewCodeType { get; set; } = SRoofingEnum_Generic_RowView_AdapterType.RowView_Header;





        public string GroupTag { get; set; } = SRoofingEnum_RowModelGroupTagManager.GroupTag_ITEM;

        //done
        public bool IsUNewJoinContact { get; set; } = false;
        
        public bool IsNewRemote { get; set; } = false;


        public string CategoryTokenID { get; set; } = "0";

        public string MessageDateTime { get; set; } = "0";


        //done
        public string OwnerUserTokenID { get; set; } = "0";



        //done
        public string OwnerMobileNumberTokenID { get; set; } = "0";



        public string Gender { get; set; } = SRoofingEnum_Gender.Gender_MALE;




        //done
        public string AvatarImageID { get; set; } = "0";


        //done
        public string YouTubeChannelID { get; set; } = "0";


        public string LocationLine { get; set; } = "0";

        
        //public string DistanceLine { get; set; } = "0";




        //done
        public string NameLine { get; set; } = "0";


        //done
        public string AccountType { get; set; } = App.iAccountType;


        //public string RegisterInvitationTokenID { get; set; } = "0";


        public string RemoteUserTokenID { get; set; } = "0";




        //public string CompanyTokenID { get; set; } = "0";

        //public string SupplierCompanyTokenID { get; set; } = "0";


        //public string CompanyName { get; set; } = "0";


        //public string SupplierCompanyName { get; set; } = "0";




        //public string CategoryTitle { get; set; } = "0";




        //public string NationalCardID { get; set; } = "0";


        //done
        public string FirstName { get; set; } = "0";

        public string RemoteMobileNumberTokenID { get; set; } = "0";


        //done
        public string ActiveStatus { get; set; } = "0";


        //done
        public string LastName { get; set; } = "0";

        //done
        public string FullName { get; set; } = "0";



      //  public string AddressLine { get; set; } = "0";



       // public string PostCode { get; set; } = "0";

        //public string CityName { get; set; } = "0";


        //public string CountryCode { get; set; } = "0";


        //public string CountryName { get; set; } = "0";


        //public string ClientTokenID { get; set; } = "0";


        //public string DeliveryBookingTokenID { get; set; } = "0";


        //public string ProjectTokenID { get; set; } = "0";



        //done
        public string PrivateGroupTokenID { get; set; } = "0";

        //done
        public string GroupTokenID { get; set; } = "0";


        public string ProjectName { get; set; } = "0";


        //public string ClientName { get; set; } = "0";


        //done
        public string EmailAddress { get; set; } = "0";


        //done
        public string MobileNumberE164 { get; set; } = "0";


        //public string ApplicationRoleTokenID { get; set; } = "0";


       // public string ApplicationRoleCode { get; set; } = "0";


       // public string ApplicationRoleName { get; set; } = "0";


      //  public string ProjectRoleTokenID { get; set; } = "0";


        //public string ProjectRoleCode { get; set; } = "0";

        //public string ProjectRoleName { get; set; } = "0";


       //public string AvatarColorCode { get; set; } = "0";


        public string AvatarName { get; set; } = "0";








        //public string CategoryName { get; set; } = "0";


        //   public string   RemoteSupervisorUserTokenID { get; set; } ="0";


        //   public string   RemoteSupervisorMobileNumberTokenID { get; set; } ="0";


        //   public string   RemoteSupervisorFullName { get; set; } ="0";

        //public string BirthYearsOld { get; set; } = "0";


        //done
        public string LoginStatus { get; set; } = SRoofingEnum_LoginStatus.LoginStatus_OFFLINE;


        //done
        public string VisibleStatus { get; set; } = SRoofingEnum_LoginStatus.LoginStatus_OFFLINE;


        //done
        public string VisibleStatusMilliSec { get; set; } = "0";

        //  private bool _IsFormSigned;

        //  private bool _IsOwnerFormSupervisor;

        //public bool IsOwnerFormSupervisor
        //{
        //    get
        //    {
        //        return Conversions.ToBoolean(_IsOwnerFormSupervisor.ToString().ToLower());
        //    }

        //    set
        //    {
        //        _IsOwnerFormSupervisor = value;
        //    }
        //}

        //private bool _IsFormForwarded;

        //public bool IsFormForwarded
        //{
        //    get
        //    {
        //        return Conversions.ToBoolean(_IsFormForwarded.ToString().ToLower()); // "true"
        //    }

        //    set
        //    {
        //        _IsFormForwarded = value;
        //    }
        //}
    }
}
