using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.Chat
{
    public class SRoofingScreenChatShowScreenModel
    {



        public string AccountType
        {
            get; set;
        }

        //int RemoteAvatarIsBlur { get; set; } = 1;

        //        public   string  CallScreenType{ get; set; }

        //public string DatingImageID
        //{
        //    get; set;
        //}

        //public string UserRole
        //{
        //    get; set;
        //}

        //int  IsDating{ get; set; }

        //public string Orientation
        //{
        //    get; set;
        //}

        //public string YouTubeChannelID
        //{
        //    get; set;
        //}

        //public string IsAvatar
        //{
        //    get; set;
        //}

        //public string GalleryList
        //{
        //    get; set;
        //}

        //public string Longitude
        //{
        //    get; set;
        //}
        //public string Latitude
        //{
        //    get; set;
        //}
        //public string Distance
        //{
        //    get; set;
        //}

        //public string UserStats
        //{
        //    get; set;
        //}
        //public string UserStatus
        //{
        //    get; set;
        //}

        //public string AboutMe
        //{
        //    get; set;
        //}
        //public string ThingLike
        //{
        //    get; set;
        //}

        //public string Gender
        //{
        //    get; set;
        //}

        //public string ProfileVisible
        //{
        //    get; set;
        //}
        //public string IsUserFilter
        //{
        //    get; set;
        //}

        //public string ProfileVisibleOnContact
        //{
        //    get; set;
        //}
        //public string ProfileVisibleOnCustom
        //{
        //    get; set;
        //}
        //public string ProfileOnlineTime
        //{
        //    get; set;
        //}

        //public string InviteTag
        //{
        //    get; set;
        //}

        // TlknGroupModel  iTlknGroupModel{ get; set; }

        public string GroupTokenID
        {
            get; set;
        } = "0";
        public string GroupType
        {
            get; set;
        }
        public string GroupTitle
        {
            get; set;
        }
        //public string IsOpen
        //{
        //    get; set;
        //}
        //public string IsTemp
        //{
        //    get; set;
        //}

        public string RemoteUserID
        {
            get; set;
        } = "0";
        public string RemoteMobileNumberID { get; set; } = "0";

        //public string CategoryID { get; set; } = "0";
        //public string ScreenChatShowID { get; set; } = "0";
        //public string ScreenChatShowTicketID { get; set; } = "0";

        //public string InviteOwnerUserID { get; set; } = "0";
        //public string InviteOwnerMobileNumberID { get; set; } = "0";

        //public string CountryISOCode { get; set; } = "0";
        //public string CountryMobileCode
        //{
        //    get; set;
        //}

        //public string SIMSerialNumber { get; set; } = "0";
        public string MobileNumberE164 { get; set; } = "0";
        //    public   string  MobileNumberID{ get; set; }

        public string AvatarImageID { get; set; } = "0";

        public string AvatarName { get; set; } = "0";

        //public string ScreenChatShowStatus
        //{
        //    get; set;
        //}

        //int AddDeviceToList
        //{
        //    get; set;
        //}
        //int IsAutoLogin
        //{
        //    get; set;
        //}

        //public string UserName
        //{
        //    get; set;
        //}
        //public string Password
        //{
        //    get; set;
        //}

        //public string FirstName { get; set; } = "0";
        //public string LastName { get; set; } = "0";

        //public string MobileNumber { get; set; } = "0";
        //public string EmailAddress { get; set; } = "0";


        //public string EmailAddressIDPersonal
        //{
        //    get; set;
        //}
        //public string EmailAddressIDBusiness
        //{
        //    get; set;
        //}

        //public string EmailAddressPersonal
        //{
        //    get; set;
        //}
        //public string EmailAddressBusiness
        //{
        //    get; set;
        //}

        //public string MobileNumberIDPersonal
        //{
        //    get; set;
        //}
        //public string MobileNumberIDBusiness
        //{
        //    get; set;
        //}

        //public string MobileNumberE164Personal
        //{
        //    get; set;
        //}
        //public string MobileNumberE164Business
        //{
        //    get; set;
        //}

        //public string IsDefaultEmailAddressFamily
        //{
        //    get; set;
        //}
        //public string IsDefaultEmailAddressBusiness
        //{
        //    get; set;
        //}

        //public string ActiveStatus
        //{
        //    get; set;
        //}
        //public string MoodStatus
        //{
        //    get; set;
        //}

        //public int IsIsAutoLogin
        //{
        //    get; set;
        //}
        //public int IsFirstLogin
        //{
        //    get; set;
        //}
        //public int IsVaildMobileNumber
        //{
        //    get; set;
        //}
        //public int IsVaildEmailAddress
        //{
        //    get; set;
        //}

        //public string BirthDay
        //{
        //    get; set;
        //}
        //public string BirthMonth
        //{
        //    get; set;
        //}
        //public string BirthYear
        //{
        //    get; set;
        //}

        //public string Country
        //{
        //    get; set;
        //}

        public string NameLine
        {
            get; set;
        } = "0";
    
        
        //public string LocationLine
        //{
        //    get; set;
        //}
        //public string City
        //{
        //    get; set;
        //}
        //public string Street
        //{
        //    get; set;
        //}
        //public string ZipCode
        //{
        //    get; set;
        //}
        //public string Address
        //{
        //    get; set;
        //}

        //public string SecurityQuestion
        //{
        //    get; set;
        //}
        //public string SecurityAnswer
        //{
        //    get; set;
        //}


        //public string ProfileImageURL
        //{
        //    get; set;
        //}
        //public string CountryName
        //{
        //    get; set;
        //}
        //public string CityName
        //{
        //    get; set;
        //}
        //public string LastActivityAction
        //{
        //    get; set;
        //}
        //public string CountryCode
        //{
        //    get; set;
        //}
        //public string CountryFlagURL
        //{
        //    get; set;
        //}
        //public string UserZodiac
        //{
        //    get; set;
        //}
        //public string OnlineStatus
        //{
        //    get; set;
        //}
        //public string LoginStatus
        //{
        //    get; set;
        //}
        //public string VisibleStatus
        //{
        //    get; set;
        //}

        public string FullName
        {
            get; set;
        } = "0";


        //public string BirthYearsOld
        //{
        //    get; set;
        //}

        //public string UserBlockYou
        //{
        //    get; set;
        //}
        //public string UserBlockMe
        //{
        //    get; set;
        //}

        //Bitmap  UserAvatar{ get; set; }

        /*
            TlknUserDatingModelManager  iRemoteModel=null{ get; set; }
        */


        /// <summary>
    ////////public SRoofingUserRemoteModelManager iRemoteModel { get; set; } = null;
        /// </summary>


        //   public string MatchType = "0";// TlknEnum Dating MatchType.DatingMatchType LikeYou{ get; set; }
        public SRoofingUserGroupModelManager iGroupModel
        {
            get; set;
        } = null;


        //////public SRoofingScreenChatShowScreenModel (

        //////        string AccountType ,
        //////        string InviteTag ,


        //////        string GroupID ,
        //////        string GroupType ,
        //////        string GroupTitle ,
        //////        string NameLine ,

        //////        string ScreenChatShowID ,
        //////        string ScreenChatShowTicketID ,
        //////        string InviteOwnerUserID ,
        //////        string InviteOwnerMobileNumberID ,
        //////        string RemoteUserID ,
        //////        string RemoteMobileNumberID ,
        //////        SRoofingUserRemoteModelManager iRemoteModel )
        //////{

        //////    iRemoteModel = iRemoteModel;

        //////    AccountType = AccountType;
        //////    InviteTag = InviteTag;

        //////    //         CallScreenType=CallScreenType;

        //////    this.GroupTokenID = GroupID;
        //////    this.GroupType = GroupType;
        //////    this.GroupTitle = GroupTitle;

        //////    this.NameLine = NameLine;

        //////    //  CategoryID = CategoryID;

        //////    this.RemoteUserID = RemoteUserID;
        //////    this.RemoteMobileNumberID = RemoteMobileNumberID;

        //////    this.ScreenChatShowID = ScreenChatShowID;
        //////    this.ScreenChatShowTicketID = ScreenChatShowTicketID;

        //////    this.InviteOwnerUserID = InviteOwnerUserID;
        //////    this.InviteOwnerMobileNumberID = InviteOwnerMobileNumberID;

        //////    //  ScreenChatShowStatus=ScreenChatShowStatus;

        //////    //  IsDating = IsDating;

        //////}


        public SRoofingScreenChatShowScreenModel (

                Application context ,
                string AccountType ,
                string InviteTag ,


                string GroupID ,
                string GroupType ,
                string GroupTitle ,
                string NameLine ,

                string ScreenChatShowID ,
                string ScreenChatShowTicketID ,
                string InviteOwnerUserID ,
                string InviteOwnerMobileNumberID ,
                string RemoteUserID ,
                string RemoteMobileNumberID ,

                SRoofingUserRemoteModelManager iRemoteModel ,
                SRoofingUserGroupModelManager iGroupModel ,

                string MatchType ,
                int RemoteAvatarIsBlur )
        {
         
          ///////////////////  this.MatchType = MatchType;

         //   this.RemoteAvatarIsBlur = RemoteAvatarIsBlur;


this.iGroupModel = iGroupModel;
            /*,
            int IsDating,
            TlknGroupModel iTlknGroupModel*/
            //string ScreenChatShowStatus,
            //        string CategoryID,


            //  iTlknGroupModel=iTlknGroupModel;

  ////////////////////////////////////////////////////////////// this.iRemoteModel = iRemoteModel;

            this.AccountType = AccountType;
       //     this.InviteTag = InviteTag;

            //         CallScreenType=CallScreenType;

            this.GroupTokenID = GroupID;
            this.GroupType = GroupType;
            this.GroupTitle = GroupTitle;

            this.NameLine = NameLine;
          
            this.AvatarName = AvatarName;

            //  CategoryID = CategoryID;

            this.RemoteUserID = RemoteUserID;
            this.RemoteMobileNumberID = RemoteMobileNumberID;

            //this.ScreenChatShowID = ScreenChatShowID;
            //this.ScreenChatShowTicketID = ScreenChatShowTicketID;

            //this.InviteOwnerUserID = InviteOwnerUserID;
            //this.InviteOwnerMobileNumberID = InviteOwnerMobileNumberID;

            if ( iGroupModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE )
            {
                this.FullName = iRemoteModel.FullName;
                this.MobileNumberE164 = iRemoteModel.MobileNumberE164;
           
                this.AvatarName = iRemoteModel.AvatarName;
            }
            else
            {

                this.AvatarName = iGroupModel.AvatarName;

            }

            //  ScreenChatShowStatus=ScreenChatShowStatus;

            //  IsDating = IsDating;

        }

        public SRoofingScreenChatShowScreenModel ( )
        {
        }
    }
}
