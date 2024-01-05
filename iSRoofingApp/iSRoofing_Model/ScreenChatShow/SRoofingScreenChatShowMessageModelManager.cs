using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;

using SQLite;

using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow
{
    public class SRoofingScreenChatShowMessageModelManager
    {
        [PrimaryKey, AutoIncrement]
        public int _id { get; set; }


        /*    int _History_Message_TextColor,_History_AvatarIcon_Visibility,_History_MessageStatus_Visibility;


            string  _History_Message_TextLine,
                    _History_Message_Status,
                    _History_Message_DateTime,
                    _History_Message_AvatarIcon;*/

        public    bool IsMediaGallerySlideShow   { get; set; } = false;

         public   int IsMessageDelivered = 1;
         public   int MessageTagID = 0;
          public  string MessageSessionTagTokenID = "0";


        public int iScreenChatShow_iMedia_Width { get; set; } = 350;
        public int iScreenChatShow_iMedia_Height { get; set; } = 350;


        public string AccountType { get; set; } = App.iAccountType;

        public string MediaFile_Size { get; set; } = "0";
        public string MediaFile_Count { get; set; } = "0";
        public string MediaFile_Duration { get; set; } = "0";

        public string MediaFile_Extension { get; set; } = "0";
        public string MediaFile_Thum { get; set; } = "0";

         public string MediaFile_Name { get; set; } = "0";

         public string MediaFile_Title { get; set; } = "0";

        public string MediaFile_Code { get; set; } = "0";

        public string MediaFile_Type { get; set; } = "0";

        public string stringInviteTag { get; set; } = "0";

        public string stringImageDefaultServerThumURL { get; set; } = "0";

        public string VideoDefaultServerThumURL { get; set; } = "0";

        public string CountryCode { get; set; } = "0";
        public string CountryName { get; set; } = "0";

        public string StateName { get; set; }

        public string CityName { get; set; }

        public string AddressLine { get; set; }

        public string MessageTokenID { get; set; }

        public string StaticMapURL { get; set; }
        public string MessageTextHistoryLine { get; set; } = SRoofingEnum_MessageText_HistoryLine_Code.MessageHistoryLineCode_Default;
        public string iLinkPreviewContent { get; set; } = null;

        bool IsLinkPreviewContent { get; set; } = false;
        public string iLinkPreviewTitle { get; set; } = "0";
        public string iLinkPreviewDescription { get; set; } = "0";
        public string iLinkPreviewURL { get; set; } = "0";
        public string iLinkPreviewCanonicalURL { get; set; } = "0";
        public string iLinkPreviewSourceURL { get; set; } = "0";
        public string iLinkPreviewPosterURL { get; set; } = "0";
        public string iLinkPreviewLogoURL { get; set; } = "0";
        //string   LinkPreviewContent;
        public string iProgress { get; set; } = "0";

        public string MessageCode_Original { get; set; } = "0";
        public string MessageText_Original { get; set; } = "0";

        public string MessageCode_Translated { get; set; } = "0";
        public string MessageText_Translated { get; set; } = "0";


        public string ScreenChatShowID { get; set; } = "0";
        public string ScreenChatShowTicketID { get; set; } = "0";

        public string GroupID { get; set; }
        public string GroupType { get; set; }

        public string OwnerUserID { get; set; }
        public string OwnerMobileNumberID { get; set; }

        public string OwnerUserSessionID { get; set; }
        public string GroupShowID { get; set; }
        public string GroupShowSessionID { get; set; }
        public string GroupShowTicketID { get; set; }
        public string VoiceShowInviteID { get; set; }
        public string VideoShowInviteID { get; set; }

        public string ScreenCallShowID { get; set; }
        public string ScreenCallShowTicketID { get; set; }
        public string ScreenCallShowType { get; set; }
        public string ScreenCallShowDirection { get; set; }
        public string ScreenCallShowStatus { get; set; }
        public string ScreenCallShowState { get; set; }
        public string ScreenCallShowAction { get; set; }


        public string UserID { get; set; }
        public string UserName { get; set; }



        public string AvatarName { get; set; } = "0";


        public string NameLine { get; set; } = "0";


        public string FullName { get; set; } = "0";

        public string AvatarImageID { get; set; } = "0";
        public string AvatarColorCode { get; set; } = "#cecece";
        public string VisibleStatus { get; set; }

        public string MobileNumberID { get; set; }
        public string UserSessionID { get; set; }

        public string UserType { get; set; }
        public string MessageTag { get; set; }
        public string MessageCode { get; set; }
        public string MessageType { get; set; }


        public int IsShareLocationAskRemoteEnable { get; set; }
        public int IsNewMessage { get; set; } = 1;
        public int IsVisible { get; set; } = 0;

        public int IsCreateNewChatLine { get; set; } = 0;
        public int IsSubjectLine { get; set; } = 0;
        public int IsHistoryLine { get; set; } = 0;
        public int IsSpaceLine { get; set; } = 0;
        public int IsSessionClosedLine { get; set; } = 0;
        public int IsScreenOnline { get; set; } = 0;


        // Image Default
        public string ImageDefaultServerID { get; set; } = "0";
        public string ImageDefaultServerURL { get; set; } = "0";
        public string ImageDefaultPath { get; set; } = "0";
        public string ImageDefaultType { get; set; } = "0";
        public byte[] ImageDefaultData { get; set; } = null;


        // Image Thum
        public string ImageThumServerURL { get; set; } = "0";
        public string ImageThumPath { get; set; } = "0";
        public byte[] ImageThumData { get; set; } = null;
        public int ImageIsLoading { get; set; } = 0;
        public int ImageIsDownload { get; set; } = 0;
        public int ImageIsSaved { get; set; } = 0;
        public int ImageIsAllowToSave { get; set; } = 0;

        public string ImageFromUserID { get; set; } = "0";
        public string ImageToUserID { get; set; } = "0";


        // Video Default
        public string VideoDefaultServerID { get; set; } = "0";
        public string VideoDefaultServerURL { get; set; } = "0";
        public string VideoDefaultPath { get; set; } = "0";
        public string VideoDefaultType { get; set; } = "0";
        public byte[] VideoDefaultData { get; set; } = null;


        // Video Thum
        public string VideoThumServerURL { get; set; } = "0";
        public string VideoThumPath { get; set; } = "0";
        public byte[] VideoThumData { get; set; } = null;
        public int VideoIsLoading { get; set; } = 0;
        public int VideoIsDownload { get; set; } = 0;
        public int VideoIsSaved { get; set; } = 0;
        public int VideoIsAllowToSave { get; set; } = 0;

        public string VideoFromUserID { get; set; } = "0";
        public string VideoToUserID { get; set; } = "0";


        public string VideoThum { get; set; } = "0";
        public string ImageThum { get; set; } = "0";


        public string LocationRequestFromRemoteUserID { get; set; } = "0";
        public string LocationRequestToRemoteUserID { get; set; } = "0";
        public string LocationType { get; set; } = "0";
        public string LocationLink { get; set; } = "0";
        public string LocationLongitude { get; set; } = "0";
        public string LocationLatitude { get; set; } = "0";
        public string LocationCountryName { get; set; } = "0";
        public string LocationCountryCode { get; set; } = "0";
        public string LocationCountryFlagURL { get; set; } = "0";
        public string LocationCityName { get; set; } = "0";
        public string LocationAddress { get; set; } = "0";
        public string LocationStreet { get; set; } = "0";
        public string SuggestContactListFromRemoteUserID { get; set; } = "0";
        public string SuggestContactListToRemoteUserID { get; set; } = "0";

        public string SuggestContactListUserID { get; set; } = "0";
        public string SuggestContactListMobileNumberID { get; set; } = "0";

        public int IsActive { get; set; } = 0;
        public string UploadDay { get; set; } = "0";
        public string UploadMonth { get; set; } = "0";
        public string UploadYear { get; set; } = "0";
        public string UploadTime { get; set; } = "0";
        public string UploadTime24Hour { get; set; } = "0";
        public string UploadDateTime { get; set; } = "0";

        public string UploadDate { get; set; } = "0";


        public string ShareFileType { get; set; } = "0";
        public string ShareFileCode { get; set; } = "0";
        public string MessageText { get; set; } = "0";
        public string InviteCode { get; set; } = "0";

        public string InviteType { get; set; } = "0";

        public string InviteOwnerUserID { get; set; } = "0";
        public string InviteOwnerMobileNumberID { get; set; } = "0";
        public string FromUserID { get; set; } = "0";
        public string FromMobileNumberID { get; set; } = "0";

        public string FileID { get; set; } = "0";
        public string FileCode { get; set; } = "0";
        public string FileType { get; set; } = "0";
        public string FileIsAllowToSave { get; set; } = "0";
        public string FileState { get; set; } = "0";


        //////public string   AvatarImageID { get; set; } = "0";
        //////public string   AvatarColorCode { get; set; } = "0";

        public string MessageLineTag { get; set; } = "0";
        public string MessageLineCode { get; set; } = "0";
        public string MessageLineType { get; set; } = "0";

        public string MessageStatus { get; set; } = "0";
        public string UploadDateTimeMilliSec { get; set; } = "0";
     
        public string CommandText_View { get; set; } = "0";
        public string CommandText_Download { get; set; } = "0";
        public string CommandText_Share { get; set; } = "0";



        public int iGallery_iMedia_Width { get; set; } = 0;
        public int iGallery_iMedia_Height { get; set; } = 0;




    }
}