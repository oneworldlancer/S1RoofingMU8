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
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

 
 
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Text
{
    public class Post_ScreenChatShow_Text_Translate_Pending_Message
    {


        public static async Task Post_ScreenChatShowTextTranslate_PendingMessageWS (

        Application _context ,

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


                ////////////////////////////////////////_iAvatarName = iOwnerModel.AvatarName;
                ////////////////////////////////////////_iFullName = iOwnerModel.FirstName;
                ////////////////////////////////////////_iVisibleStatus = iOwnerModel.VisibleStatus;
                ////////////////////////////////////////AvatarImageID = iOwnerModel.AvatarImageID;
                /////////////////////////////////////////*AvatarImageID = iRemoteModel.PersonalAvatarImageID ( );*/
                //////////////////////////////////////////AvatarColorCode = iOwnerModel.AvatarColorCode;

                ////////////////////////////////////////FromUserID = iOwnerModel.OwnerUserTokenID;
                ////////////////////////////////////////FromMobileNumberID = iOwnerModel.OwnerMobileNumberTokenID;




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

                iSRoofingScreenChatShowMessageDatabaseModel.MessageType = iTranslationModel.MessageType;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageText = MessageText;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageCode_Translated = iTranslationModel.MessageCode_Translated;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageText_Translated = iTranslationModel.MessageText_Translated;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageCode_Original = iTranslationModel.MessageCode_Original;
                iSRoofingScreenChatShowMessageDatabaseModel.MessageText_Original = iTranslationModel.MessageText_Original;

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

                iSRoofingScreenChatShowMessageDatabaseModel.MessageTextHistoryLine = iTranslationModel.MessageText_Translated;





                iSRoofingScreenChatShowMessageDatabaseModel.CommandText_Share = iLanguageModel.lblText_Command_SHARE_Message;
                iSRoofingScreenChatShowMessageDatabaseModel.CommandText_View = iLanguageModel.lblText_Command_VIEW_Message;
                iSRoofingScreenChatShowMessageDatabaseModel.CommandText_Download = iLanguageModel.lblText_Command_DOWNLOAD_Message;







                await App.Database.saveDataAsync ( iSRoofingScreenChatShowMessageDatabaseModel );



                //////////#region Remote

                //////////iSRoofingScreenChatShowMessageDatabaseModel.UserType = SRoofingEnum_UserType.UserType_Remote;
                //////////iSRoofingScreenChatShowMessageDatabaseModel.AvatarName = "XX"; ;
                //////////iSRoofingScreenChatShowMessageDatabaseModel.NameLine = "XUser XTest";
                //////////iSRoofingScreenChatShowMessageDatabaseModel.IsNewMessage = 1;
                //////////iSRoofingScreenChatShowMessageDatabaseModel.IsVisible = 1;
                //////////await App.Database.saveDataAsync_HistoryChat_MessageModel ( iSRoofingScreenChatShowMessageDatabaseModel );

                //////////#endregion



                App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = true;
                App._blnSyncHistory_Dating_ChatContactList = true;
                App._blnSync_Chat_IsRefreshNewMessage = true;
                App.bln_ScreenChatShow_OnAppearing_New_MessageList=true;







                #region History

                _ = Task.Run ( async ( ) =>
                              {

                                  // Save-History
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

                                      MessageText = iTranslationModel.MessageText_Translated ,


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


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }



    }
}
