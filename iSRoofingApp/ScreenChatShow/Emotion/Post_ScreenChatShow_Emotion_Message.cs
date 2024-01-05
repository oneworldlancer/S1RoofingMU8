using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Translation;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

 
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Emotion
{
    public class Post_ScreenChatShow_Emotion_Message
    {


        public static async Task Post_ScreenChatShowEmotion_MessageWS(

        Application _context,

        SRoofingUserOwnerModelManager iOwnerModel,

        SRoofingUserSettingModelManager iSettingModel,

        string iAccountType,

        SRoofingUserRemoteModelManager iRemoteModel,

        string MessageTokenID,
        string UploadDateTimeMilliSec,

        string GroupID,

        string UserID,
        string MobileNumberID,
        string UserSessionID,

        string UserType,

        string MessageCode,

        string MessageText,

        string shownMessageText,


                 SRoofingTranslationModel iTranslationModel ,

        string iOwner_LanguageCode_IN ,
         string iOwner_LanguageCode_OUT ,

        string MessageLineCode,
        string MessageLineType,

        string MessageStatus,



                        string DateTimeTextWS,
                  string DateTimeWS,
                  string DateTextWS,
                   string UserDateDayWS,
                    string UserDateMonthWS,
                    string UserDateYearWS,

                    int IsNewMessage)
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



                if (Connectivity.NetworkAccess != NetworkAccess.Internet)
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
                        new SRoofingScreenChatShowMessageModelManager();


                iSRoofingScreenChatShowMessageDatabaseModel.UserType = UserType;


                iSRoofingScreenChatShowMessageDatabaseModel.OwnerUserID = iOwnerModel.OwnerUserTokenID;
                iSRoofingScreenChatShowMessageDatabaseModel.OwnerMobileNumberID = iOwnerModel.OwnerMobileNumberTokenID;
                iSRoofingScreenChatShowMessageDatabaseModel.AvatarName = iOwnerModel.AvatarName;
                iSRoofingScreenChatShowMessageDatabaseModel.NameLine = iOwnerModel.NameLine;
                iSRoofingScreenChatShowMessageDatabaseModel.FullName = iOwnerModel.FullName;
                iSRoofingScreenChatShowMessageDatabaseModel.AvatarImageID = iOwnerModel.AvatarImageID;
                iSRoofingScreenChatShowMessageDatabaseModel.AvatarColorCode = "#cecece";

                iSRoofingScreenChatShowMessageDatabaseModel.MessageTokenID = MessageTokenID;
                //  iSRoofingScreenChatShowMessageDatabaseModel.MessageTextHistoryLine = MessageTextHistoryLine;

                iSRoofingScreenChatShowMessageDatabaseModel.MessageType = "textemotion";//iTranslationModel.MessageType;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageText = MessageText;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageCode_Translated = "en";//iTranslationModel.MessageCode_Translated;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageText_Translated = MessageText;// iTranslationModel.MessageText_Translated;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageCode_Original = "en";//iTranslationModel.MessageCode_Original;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageText_Original = MessageText;//iTranslationModel.MessageText_Original;

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

                iSRoofingScreenChatShowMessageDatabaseModel.MessageTextHistoryLine = MessageText;






                await App.Database.saveDataAsync(iSRoofingScreenChatShowMessageDatabaseModel);


                #region Remote

                iSRoofingScreenChatShowMessageDatabaseModel.UserType = SRoofingEnum_UserType.UserType_Remote;
                iSRoofingScreenChatShowMessageDatabaseModel.AvatarName = "XX"; ;
                iSRoofingScreenChatShowMessageDatabaseModel.NameLine = "XUser XTest";
                iSRoofingScreenChatShowMessageDatabaseModel.IsNewMessage = 1;
                iSRoofingScreenChatShowMessageDatabaseModel.IsVisible = 1;
                await App.Database.saveDataAsync(iSRoofingScreenChatShowMessageDatabaseModel);

                #endregion

                App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = true;
                App._blnSyncHistory_Dating_ChatContactList = true;
                App._blnSync_Chat_IsRefreshNewMessage = true;
                App.bln_ScreenChatShow_OnAppearing_New_MessageList=true;


                #region Broadcast_Sender

                SRoofingKeyValueModelManager iBroadcastModel = new SRoofingKeyValueModelManager()
                {

                    ItemText = "new_message",
                    ItemValue = UserType

                };

                MessagingCenter.Send<App, object>(
        App.Current as App,
      SRoofingEnum_MessageCenter.MessageCenter_CHAT_NEW_SCREENCHATSHOW_MESSAGE , iBroadcastModel);


                #endregion




            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



    }
}
