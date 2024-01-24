using S1RoofingMU.iSRoofingApp.iSRoofing_DownloaderManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Translation;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

 
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Image
{
    public class Post_ScreenChatShow_Image_Message
    {


        public static async Task Post_ScreenChatShowImage_MessageWS (

        Application _context ,

       SRoofingApplicationUtilityModelManager iApplicationUtilityModel ,

       SRoofingUserOwnerModelManager iOwnerModel ,

        SRoofingUserSettingModelManager iSettingModel ,

        SRoofingLanguageTranslateModel iLanguageModel ,


        string iAccountType ,

        SRoofingUserRemoteModelManager iRemoteModel ,

              SRoofingUserGroupModelManager iGroupModel ,

       string MessageTokenID ,
        string UploadDateTimeMilliSec ,

        string GroupID ,

        string UserID ,
        string MobileNumberID ,
        string UserSessionID ,

        string UserType ,

        string MessageCode ,

        string MessageText ,

        string shownMessageText ,


                 SRoofingTranslationModel iTranslationModel ,

        string iOwner_LanguageCode_IN ,
         string iOwner_LanguageCode_OUT ,

        string MessageLineCode ,
        string MessageLineType ,

             //  FileResult fileResult ,


             SRoofingUserMediaModel iUserMediaModel ,


            string ImageID ,
            Uri ImageURI ,
            string ImagePathURL ,
            string ImageServerURL ,
            string ImageIsViewOnly ,

        string MessageStatus ,



                        string DateTimeTextWS ,
                  string DateTimeWS ,
                  string DateTextWS ,
                   string UserDateDayWS ,
                    string UserDateMonthWS ,
                    string UserDateYearWS ,

                    int IsNewMessage )
        {

            try
            {

                /*
                            SRoofingUserModel _iOwnerModel = SRoofingSyncManager.Sync_Profile_GetOwnerProfileByUserID (
                                    _context);
                */



                string FromUserID = "0";
                string FromMobileNumberID = "0";

                string AvatarImageID = "0";
                string AvatarColorCode = "#cecece";

                string _iAvatarName = "0";
                string _iNameLine = "0";
                string _iFullName = "0";
                string _iVisibleStatus = SRoofingEnum_LoginStatus.LoginStatus_OFFLINE;



                bool _isNewMessage = false;




                if ( UserType == SRoofingEnum_UserType.UserType_Owner )
                {



                    _iAvatarName = iOwnerModel.AvatarName;
                    _iNameLine = iOwnerModel.NameLine;
                    _iFullName = iOwnerModel.FullName;
                    _iVisibleStatus = iOwnerModel.VisibleStatus;
                    AvatarImageID = iOwnerModel.AvatarImageID;
                    /*AvatarImageID = iRemoteModel.PersonalAvatarImageID ( );*/
                    //AvatarColorCode = iOwnerModel.AvatarColorCode;

                    FromUserID = iOwnerModel.OwnerUserTokenID;
                    FromMobileNumberID = iOwnerModel.OwnerMobileNumberTokenID;


                    _isNewMessage = false;

                }
                else if ( UserType == SRoofingEnum_UserType.UserType_Remote )
                {
                    _iAvatarName = iRemoteModel.AvatarName;
                    _iNameLine = iRemoteModel.NameLine;
                    _iFullName = iRemoteModel.FullName;
                    _iVisibleStatus = iRemoteModel.VisibleStatus;
                    AvatarImageID = iRemoteModel.AvatarImageID;
                    /*AvatarImageID = iRemoteModel.PersonalAvatarImageID ( );*/
                    //AvatarColorCode = iRemoteModel.AvatarColorCode;

                    FromUserID = iRemoteModel.OwnerUserTokenID;
                    FromMobileNumberID = iRemoteModel.OwnerMobileNumberTokenID;


                    _isNewMessage = true;

                }


                ///////////////////////////////////////////////////
                //////////////////////////////////////////////////
                /////////////////////////////////////////////////


                //////_iAvatarName = iOwnerModel.AvatarName;
                //////_iFirstName = iOwnerModel.FirstName;
                //////_iVisibleStatus = iOwnerModel.VisibleStatus;
                //////AvatarImageID = iOwnerModel.AvatarImageID;
                ///////*AvatarImageID = iRemoteModel.PersonalAvatarImageID ( );*/
                ////////AvatarColorCode = iOwnerModel.AvatarColorCode;


                //////FromUserID = iOwnerModel.OwnerUserTokenID;
                //////FromMobileNumberID = iOwnerModel.OwnerMobileNumberTokenID;



                if ( Connectivity.NetworkAccess != NetworkAccess.Internet )
                {

                    MessageStatus =
                            SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Offline;
                }


                // string MessageType = "textmessagetranslate";
                /*
                string MessageType = "textmessagetranslate_pending";
 */

                /////////////////////////////////////////
                //////////////////////////////////////////
                ///////////////////////////////////////////


                ////////////////SRoofingScreenChatShowMessageDatabaseAdapter dbSRoofingScreenChatShowMessageDatabaseAdapter =
                ////////////////        new SRoofingScreenChatShowMessageDatabaseAdapter(
                ////////////////                _context);


                // SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel();


                //////    //string strDay, strMonth, strYear, strTimeZone;

                //////    //string MessageCode_Original,MessageText_Original,MessageCode_Translated,MessageText_Translated ;


                //////    //strDay = SRoofing_TimeManager.Time_GetUploadDay();
                //////    //strMonth = SRoofing_TimeManager.Time_Get_UploadMonth();
                //////    //strYear = SRoofing_TimeManager.Time_GetUploadYear();
                //////    //strTimeZone = SRoofing_TimeManager.Time_Get_UploadTime();


                //////    // Return translation

                //////    iTranslationModel = SRoofing_TranslationManager.Get_TranslationModel(
                //////SRoofingEnum_Direction.Direction_Out,
                //////    iOwner_LanguageCode_IN,
                //////   iOwner_LanguageCode_OUT,
                ////// shownMessageText).Result;



                SRoofingScreenChatShowMessageModelManager iSRoofingScreenChatShowMessageDatabaseModel =
                        new SRoofingScreenChatShowMessageModelManager ( );


                iSRoofingScreenChatShowMessageDatabaseModel.UserType = UserType;


                iSRoofingScreenChatShowMessageDatabaseModel.OwnerUserID = iOwnerModel.OwnerUserTokenID;
                iSRoofingScreenChatShowMessageDatabaseModel.OwnerMobileNumberID = iOwnerModel.OwnerMobileNumberTokenID;

                iSRoofingScreenChatShowMessageDatabaseModel.AvatarName = _iAvatarName;
                iSRoofingScreenChatShowMessageDatabaseModel.NameLine = _iNameLine;
                iSRoofingScreenChatShowMessageDatabaseModel.FullName = _iFullName;
                iSRoofingScreenChatShowMessageDatabaseModel.AvatarImageID = AvatarImageID;
                iSRoofingScreenChatShowMessageDatabaseModel.AvatarColorCode = AvatarColorCode;

                iSRoofingScreenChatShowMessageDatabaseModel.MessageTokenID = MessageTokenID;
                //  iSRoofingScreenChatShowMessageDatabaseModel.MessageTextHistoryLine = MessageTextHistoryLine;

                iSRoofingScreenChatShowMessageDatabaseModel.MessageType = "textsharephoto";//iTranslationModel.MessageType;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageText = iLanguageModel.lblText_ScreenChatShow_ShareImage_Message; //MessageText;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageCode_Translated = iTranslationModel.MessageCode_Translated;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageText_Translated = iLanguageModel.lblText_ScreenChatShow_ShareImage_Message;// iTranslationModel.MessageText_Translated;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageCode_Original = iTranslationModel.MessageCode_Original;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageText_Original = iLanguageModel.lblText_ScreenChatShow_ShareImage_Message;//iTranslationModel.MessageText_Original;

                //string strUploadTime = SRoofing_TimeManager.Time_Get_UploadTime();


                iSRoofingScreenChatShowMessageDatabaseModel.GroupID = GroupID;

                iSRoofingScreenChatShowMessageDatabaseModel.FromUserID = FromUserID;
                iSRoofingScreenChatShowMessageDatabaseModel.FromMobileNumberID = FromMobileNumberID;





                iSRoofingScreenChatShowMessageDatabaseModel.UploadTime = DateTimeWS;
                iSRoofingScreenChatShowMessageDatabaseModel.UploadTime24Hour = DateTimeWS;

                iSRoofingScreenChatShowMessageDatabaseModel.IsNewMessage = 1;
                iSRoofingScreenChatShowMessageDatabaseModel.IsVisible = 1;

                iSRoofingScreenChatShowMessageDatabaseModel.MessageStatus = MessageStatus;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageLineCode = MessageLineCode;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageLineType = MessageLineType;

                iSRoofingScreenChatShowMessageDatabaseModel.MessageTextHistoryLine = SRoofingEnum_MessageText_HistoryLine_Code.MessageHistoryLineCode_Image;


                iSRoofingScreenChatShowMessageDatabaseModel.ImageDefaultServerID = ImageID;
                iSRoofingScreenChatShowMessageDatabaseModel.ImageDefaultServerURL = SRoofing_URLManager.URL_Image.Image_Get_ImageByImageID ( App.Current , ImageID );
                iSRoofingScreenChatShowMessageDatabaseModel.ImageThumServerURL = SRoofing_URLManager.URL_Image.Image_Get_ImageByImageID ( App.Current , ImageID );
                iSRoofingScreenChatShowMessageDatabaseModel.ImageThumPath = "0";
                iSRoofingScreenChatShowMessageDatabaseModel.ImageThumData = null;
                iSRoofingScreenChatShowMessageDatabaseModel.ImageDefaultPath = iUserMediaModel.MediaFile_LocalPathURL; //fileResult.FullPath;


                iSRoofingScreenChatShowMessageDatabaseModel.MediaFile_Code = SRoofingEnum_File_Code.FileCode_Image; //"0";
                iSRoofingScreenChatShowMessageDatabaseModel.MediaFile_Type = SRoofingEnum_File_Type.ShareType_Image; //"0";
                iSRoofingScreenChatShowMessageDatabaseModel.MediaFile_Size = iUserMediaModel.MediaFile_Size;
                iSRoofingScreenChatShowMessageDatabaseModel.MediaFile_Duration = "0";
                iSRoofingScreenChatShowMessageDatabaseModel.MediaFile_Extension = SRoofingEnum_File_Extension.FileExtension_Image_JPG; //"0";
                iSRoofingScreenChatShowMessageDatabaseModel.MediaFile_Thum = SRoofingEnum_File_Thum.FileThum_Image; //"0";

                iSRoofingScreenChatShowMessageDatabaseModel.MediaFileMetaData = iUserMediaModel.MediaFile_Size ; //"0";



                iSRoofingScreenChatShowMessageDatabaseModel.iScreenChatShow_iMedia_Width = iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                iSRoofingScreenChatShowMessageDatabaseModel.iScreenChatShow_iMedia_Height = iApplicationUtilityModel.iScreenChatShow_iMedia_Height;




                iSRoofingScreenChatShowMessageDatabaseModel.iGallery_iMedia_Width = iApplicationUtilityModel.iGallery_iMedia_Width;
                iSRoofingScreenChatShowMessageDatabaseModel.iGallery_iMedia_Height = iApplicationUtilityModel.iGallery_iMedia_Height;

                iSRoofingScreenChatShowMessageDatabaseModel.IsMediaGallerySlideShow = true;




                iSRoofingScreenChatShowMessageDatabaseModel.CommandText_Share = iLanguageModel.lblText_Command_SHARE_Message;
                iSRoofingScreenChatShowMessageDatabaseModel.CommandText_View = iLanguageModel.lblText_Command_VIEW_Message;
                iSRoofingScreenChatShowMessageDatabaseModel.CommandText_Download = iLanguageModel.lblText_Command_DOWNLOAD_Message;





                await App.Database.saveDataAsync ( iSRoofingScreenChatShowMessageDatabaseModel );


                //////////#region Remote

                //////iSRoofingScreenChatShowMessageDatabaseModel.UserType = SRoofingEnum_UserType.UserType_Remote;
                //////iSRoofingScreenChatShowMessageDatabaseModel.AvatarName = "XX"; ;
                //////iSRoofingScreenChatShowMessageDatabaseModel.NameLine = "XUser XTest";
                //////iSRoofingScreenChatShowMessageDatabaseModel.IsNewMessage = 1;
                //////iSRoofingScreenChatShowMessageDatabaseModel.IsVisible = 1;
                //////await App.Database.saveDataAsync ( iSRoofingScreenChatShowMessageDatabaseModel );

                //////////#endregion

                App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = true;
                App._blnSyncHistory_Dating_ChatContactList = true;
                App._blnSync_Chat_IsRefreshNewMessage = true;
                App.bln_ScreenChatShow_OnAppearing_New_MessageList=true;




                #region History

                _ = Task.Run ( async ( ) =>
                {

                    SRoofingScreenChatShowHistoryMessageModelManager _iHistoryChatMessageModel = new SRoofingScreenChatShowHistoryMessageModelManager
                    {

                        AccountType = App.iAccountType ,

                        OwnerUserTokenID = iOwnerModel.OwnerUserTokenID ,

                        OwnerMobileNumberTokenID = iOwnerModel.OwnerMobileNumberTokenID ,

                        VisibleOnlineDateTimeMilliSec = "0" ,

                        CategoryTitle = "0" ,


                        ChatterListCount = iGroupModel.ChatterListCount ,

                        AvatarImageID = iGroupModel.AvatarImageID ,

                        MessageType = MessageCode ,

                        RemoteMobileNumberE164 = iGroupModel.RemoteMobileNumberE164 ,
                        DateTimeText = DateTimeTextWS ,

                        MessageText = iLanguageModel.lblText_ScreenChatShow_ShareImage_Message ,


                        PrivateGroupTokenID = iGroupModel.PrivateGroupTokenID ,

                        GroupTokenID = GroupID ,

                        GroupType = iGroupModel.GroupType ,

                        NameLine = iGroupModel.NameLine ,



                        GroupTitle = iGroupModel.GroupTitle ,

                        AvatarName = iGroupModel.AvatarName ,

                        RemoteUserTokenID = iGroupModel.RemoteUserTokenID ,

                        RemoteMobileNumberTokenID = iGroupModel.RemoteMobileNumberTokenID ,

                        RemoteFullName = iGroupModel.RemoteFullName ,

                        RemoteVisibleStatus = iGroupModel.RemoteVisibleStatus ,

                        MessageTokenID = MessageTokenID ,

                        DateTime = DateTimeWS ,

                        DateTimeMilliSec = UploadDateTimeMilliSec ,

                        //IsOpen = false ,
                        GroupCode = iGroupModel.GroupCode ,

                        GroupTag = SRoofingEnum_RowModelGroupTagManager.GroupTag_ITEM ,

                        UploadDateTimeMilliSec = long.Parse ( UploadDateTimeMilliSec ) ,

                        iViewCodeType = SRoofingEnum_Generic_RowView_AdapterType.RowView_Item ,

                        IsVisible = true ,

                        IsNewMessage = _isNewMessage ,


                    };

                    //await App.Database.deleteDataAsync_HistoryChat_MessageModel ( GroupID );
                    //await App.Database.saveDataAsync_HistoryChat_MessageModel ( iHistoryChatMessageModel );

                    await App.Database.updateDataAsync_HistoryChat_MessageModel (
                        iOwnerModel ,
                        _iHistoryChatMessageModel );





                    #region Broadcast_Sender

                    // Send-Broadcast
                    SRoofingKeyValueModelManager iBroadcastModel = new SRoofingKeyValueModelManager ( )
                    {


                        ItemText = "new_message" ,
                        ItemCode = GroupID ,
                        ItemValue = UserType ,

                        iHistoryChatMessageModel = _iHistoryChatMessageModel


                    };

                    MessagingCenter.Send<App , object> (
            App.Current as App ,
            SRoofingEnum_MessageCenter.MessageCenter_CHAT_NEW_SCREENCHATSHOW_MESSAGE , iBroadcastModel );


                    #endregion








                } ).ConfigureAwait ( false );


                #endregion



                #region Download


                _ = Task.Run ( async ( ) =>
                {
                    if ( iSettingModel.Media_DownloadImage_IsEnable
                        && iSRoofingScreenChatShowMessageDatabaseModel.ImageDefaultPath == "0" )
                    {
                        await SRoofing_DownloaderManager.Downloader_File_ByFileTokenID (
                              App.Current , App.iAccountType , null ,
                              "0" ,
                        iSRoofingScreenChatShowMessageDatabaseModel.MediaFile_Code ,
                             iSRoofingScreenChatShowMessageDatabaseModel.MediaFile_Type ,
                             iSRoofingScreenChatShowMessageDatabaseModel );
                    }

                } ).ConfigureAwait ( false );


                #endregion


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }



    }
}
