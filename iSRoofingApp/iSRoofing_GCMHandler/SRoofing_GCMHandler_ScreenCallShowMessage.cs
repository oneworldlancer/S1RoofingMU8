

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Location;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Time;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Translation;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Document;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Giphy;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Image;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Location;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Text;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Video;

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Web;


using Microsoft.Maui.Controls;

using static System.Net.WebRequestMethods;
using System.Net.WebSockets;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Call;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_GCMHandler
{
    public class SRoofing_GCMHandler_ScreenCallShowMessage
    {


        #region Parse_Intent


        public static async Task IntentService_ParseIntentExtras(
          string iAccountType,
            SRoofingUserSettingModelManager iSettingModel,
                 SRoofingUserOwnerModelManager iOwnerModel,
                 dynamic _iJsonModel)
        {

            try
            {
                _ = Task.Run(async () =>
                         {

                             //await Task.Delay ( 30000 );

                             try
                             {

                                 string _ActionTag = "0", _ActionRequest = "0", _ScreenChatShowID = "0", _ScreenChatShowTicketID = "0",

                 _IsScreenOnline = "0", _RemoteUserName = "0", _ScreenChatShowTicketTempID = "0", _ScreenChatShowTicketLineID = "0",
                         _InviteOwnerUserID = "0", _InviteOwnerMobileNumberID = "0",
                         _FromUserID = "0", _ToUserID = "0", _FromMobileNumberID = "0", _ToMobileNumberID = "0", _InviteToListUserID = "0",
                         _InviteFromMobileNumberID = "0", _InviteToMobileNumberID = "0",
                         _InviteFromUserID = "0", _InviteToUserID = "0",
                         _InviteCode = "0", _InviteType = "0", _InviteID = "0", _InviteTicketID = "0",
                         _MessageCode = "0", _MessageType = "0", _MessageText = "0";
                                 //////////_SuggestContactListUserID = "0", _SuggestContactListMobileNumberID = "0",
                                 //////////_LocationLongitude = "0", _LocationLatitude = "0", _LocationCityName = "0",
                                 //////////_FileID = "0",
                                 //////////_FileSize = "0",
                                 //////////_FileExtension = "0",
                                 //////////_FileDuration = "0",
                                 //////////_FileThum = "0",
                                 //////////_FileCode = "0",
                                 //////////_FileName = "0", _FileType = "0", _FileIsViewOnly = "0", _FileState = "0";

                                 //////////string _CountryCode = "0";
                                 //////////string _CountryName = "0";
                                 //////////string _StateName = "0";
                                 //////////string _CityName = "0";
                                 //////////string _AddressLine = "0";
                                 //////////string _StaticMapURL = "0";

                                 //////////string _ShareFileURL, _ShareFileThumURL = "0";

                                 //////////string _ScreenIsOnline = "0";


                                 string _GroupID = "0", _CallTokenID = "0", _GroupType, _GroupTitle,
                                         _RemoteUserID = "0", _RemoteMobileNumberID = "0";

                                 string _InviteTag = "0";

                                 string _IsDating = "0";

                                 string _UploadDateTimeMilliSec = "0", _MessageTokenID = "0";

                                 SRoofingUserSettingModelManager iSRoofingUserSettingModelManager;

                                 bool _blnShowNotification = false;

                                 SRoofingUserRemoteModelManager _iRemoteModel;
                                 SRoofingUserGroupModelManager _iGroupModel;

                                 string MessageCode_Original = "0";
                                 string MessageText_Original = "0";
                                 string MessageCode_Translated = "0";
                                 string MessageText_Translated = "0";

                                 //String _iAccountType;

                                 // TlknScreenCallModel _iCallModel;

                                 //Intent intentScreenChatShowDashboard;

                                 SRoofingUserOwnerModelManager _iOwnerModel;

                                 SRoofingUserSettingModelManager _iSettingModel;

                                 string _Notification_SoundURI;
                                 string _shownMessageText, _shownMessageText_Notification;

                                 //TlknUserNotificationHistoryModel _iHistoryModel;



                                 string _iAccountType = App.iAccountType;

                                 //_iAccountType = _iJsonModel.acctyp.ToString ( );

                                 _iOwnerModel = iOwnerModel;
                                 //   await
                                 //   SRoofingSync_User_OwnerManager.Sync_User_Owner_Get_UserModel (
                                 //Application.Current );

                                 // ( SRoofingUserOwnerModelManager ) _extras.getSerializable ( "iOwnerModel" );



                                 //TlknSyncManager.Sync_Profile_GetOwnerProfileByUserID ( _context );
                                 //TlknSyncManager

                                 _iSettingModel = iSettingModel;
                                 //await SRoofingSync_UserSetting_Manager
                                 //    .Sync_Setting_Get_Setting_ByUserID (
                                 //        Application.Current ,
                                 //       _iOwnerModel );

                                 // .Sync_Profile_GetOwnerProfileByUserID ( _context );



                                 SRoofingLanguageTranslateModel _iLanguageModel =
                                 await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);



                                 _GroupID = _iJsonModel.grpid.ToString();
                                 _IsDating = _iJsonModel.isdtng.ToString();

                                 _RemoteUserID = _iJsonModel.rmtid.ToString();
                                 _RemoteMobileNumberID = _iJsonModel.rmtmobid.ToString();


                                 _iRemoteModel = await SRoofingSync_User_RemoteManager
                                 .Sync_User_Remote_Get_UserModel(
                       Application.Current,
                       _iOwnerModel,
                 _RemoteUserID,
                 _RemoteMobileNumberID);

                                 if (_iRemoteModel == null)
                                 {
                                     if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                                     {
                                         _iRemoteModel =
                                     await SRoofing_UserProfileRemoteManager.SRoofing_User_Get_Remote_Model_ByRemoteUserTokenID(
                                               Application.Current,
                                               _iOwnerModel,
                                               _RemoteUserID,
                                               _RemoteMobileNumberID);
                                     }

                                 }


                                 _iGroupModel = await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel(
                                             Application.Current,
                                             _iOwnerModel,
                                             _GroupID);


                                 if (_iGroupModel == null)
                                 {
                                     if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                                     {

                                         _iGroupModel = new SRoofingUserGroupModelManager();

                                         _iGroupModel =
                                         await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                                                     Application.Current,
                                                         _iOwnerModel,
                                                         _GroupID);
                                     }

                                 }


                                 if (_iOwnerModel != null && _iRemoteModel != null && _iGroupModel != null)
                                 {


                                     //////////MessageCode_Original = HttpUtility.UrlDecode ( _iJsonModel.msgorgcod.ToString ( ) );
                                     //////////MessageText_Original = HttpUtility.UrlDecode ( _iJsonModel.msgorgtxt.ToString ( ) );
                                     //////////MessageCode_Translated = HttpUtility.UrlDecode ( _iJsonModel.msgtrnscod.ToString ( ) );
                                     //////////MessageText_Translated = HttpUtility.UrlDecode ( _iJsonModel.msgtrnstxt.ToString ( ) );



                                     _ActionTag = _iJsonModel.tag.ToString();
                                     _ActionRequest = _iJsonModel.act.ToString();

                                     //_MessageTokenID = _iJsonModel.msgtknid.ToString ( );
                                     _MessageTokenID = _iJsonModel.caltknid.ToString();
                                     _CallTokenID = _iJsonModel.caltknid.ToString();


                                     //    return settings.GetType().GetProperty(name) != null;
                                     if (_iJsonModel.GetType().GetProperty("utctime") != null)
                                     {
                                         _UploadDateTimeMilliSec = _iJsonModel.utctime.ToString();
                                     }
                                     else
                                     {
                                         _UploadDateTimeMilliSec ="0";
                                     }




                                     _IsDating = _iJsonModel.isdtng.ToString();

                                     _InviteTag = _iJsonModel.invtag.ToString();

                                     _ScreenChatShowID = _iJsonModel.scnid.ToString();
                                     _ScreenChatShowTicketID = _iJsonModel.scntktid.ToString();


                                     _GroupType = HttpUtility.UrlDecode(_iJsonModel.grptyp.ToString());

                                     _GroupTitle = HttpUtility.UrlDecode(_iGroupModel.GroupTitle);

                                     _InviteOwnerUserID = _iJsonModel.invownid.ToString();
                                     _InviteOwnerMobileNumberID = _iJsonModel.invownmobid.ToString();

                                     //_FromUserID = "0"; //_iJsonModel.fid.ToString();
                                     //_FromMobileNumberID =  "0"; //_iJsonModel.fmobid.ToString();

                                     _FromUserID = _iJsonModel.rmtid.ToString();
                                     _FromMobileNumberID = _iJsonModel.rmtmobid.ToString();



                                     _RemoteUserID = _iJsonModel.rmtid.ToString();
                                     _RemoteMobileNumberID = _iJsonModel.rmtmobid.ToString();



                                     _MessageType = HttpUtility.UrlDecode(_iJsonModel.msgtyp.ToString());
                                     _MessageText = HttpUtility.UrlDecode(_iJsonModel.msgtxt.ToString());

                                     //////////_SuggestContactListUserID = _iJsonModel.suguid.ToString ( );
                                     //////////_SuggestContactListMobileNumberID = _iJsonModel.sugumobid.ToString ( );

                                     //////////_LocationLongitude = _iJsonModel.maplong.ToString ( );
                                     //////////_LocationLatitude = _iJsonModel.maplat.ToString ( );


                                     //////////_CountryCode = HttpUtility.UrlDecode ( _iJsonModel.mapcntrycod.ToString ( ) );
                                     //////////_CountryName = HttpUtility.UrlDecode ( _iJsonModel.mapcntryname.ToString ( ) );
                                     //////////_StateName = HttpUtility.UrlDecode ( _iJsonModel.mapstatename.ToString ( ) );
                                     //////////_CityName = HttpUtility.UrlDecode ( _iJsonModel.mapcityname.ToString ( ) );
                                     //////////_AddressLine = HttpUtility.UrlDecode ( _iJsonModel.mapaddressline.ToString ( ) );
                                     //////////_StaticMapURL = HttpUtility.UrlDecode ( _iJsonModel.mapurl.ToString ( ) );

                                     //////////_FileID = _iJsonModel.fileid.ToString ( );
                                     //////////_FileName = HttpUtility.UrlDecode ( _iJsonModel.filename.ToString ( ) );
                                     //////////_FileSize = HttpUtility.UrlDecode ( _iJsonModel.filesize.ToString ( ) );
                                     //////////_FileExtension = HttpUtility.UrlDecode ( _iJsonModel.fileext.ToString ( ) );
                                     //////////_FileDuration = HttpUtility.UrlDecode ( _iJsonModel.fileduration.ToString ( ) );
                                     //////////_FileThum = HttpUtility.UrlDecode ( _iJsonModel.filethum.ToString ( ) );

                                     //////////_FileCode = HttpUtility.UrlDecode ( _iJsonModel.filecod.ToString ( ) );
                                     //////////_FileType = HttpUtility.UrlDecode ( _iJsonModel.filetyp.ToString ( ) );

                                     //////////_FileIsViewOnly = _iJsonModel.fileisviewonly.ToString ( );
                                     //////////_FileState = _iJsonModel.filestate.ToString ( );

                                     //////////_ShareFileURL = HttpUtility.UrlDecode ( _iJsonModel.fileurl.ToString ( ) );
                                     //////////_ShareFileThumURL = HttpUtility.UrlDecode ( _iJsonModel.filethumurl.ToString ( ) );



                                     SRoofingSpeechModel _iSpeechModel_Incoming;
                                     SRoofingSpeechModel _iSpeechModel_Outgoing;


                                     _iSpeechModel_Incoming = await SRoofingSync_Speech_Manager.Sync_Speech_Get_Incoming_ByUserID(App.Current, _iOwnerModel);
                                     _iSpeechModel_Outgoing = await SRoofingSync_Speech_Manager.Sync_Speech_Get_Outgoing_ByUserID(App.Current, _iOwnerModel);


                                     string _iOwner_Incoming_LanguageCode = _iSpeechModel_Incoming.LanguageCode.ToLower();
                                     string _iOwner_Outgoing_LanguageCode = _iSpeechModel_Outgoing.LanguageCode.ToLower();



                                     string iUserType = SRoofingEnum_UserType.UserType_Remote;

                                     //////////if ( _ActionRequest == SRoofingEnum_GCM_Action_RequestManager.ScreenChatShow_Owner_ScreenChatShowMessage )
                                     //////////{
                                     //////////    iUserType = SRoofingEnum_UserType.UserType_Owner;
                                     //////////}
                                     //////////else if ( _ActionRequest == SRoofingEnum_GCM_Action_RequestManager.ScreenChatShow_Remote_ScreenChatShowMessage )
                                     //////////{
                                     //////////    iUserType = SRoofingEnum_UserType.UserType_Remote;
                                     //////////}



                                     SRoofingApplicationUtilityModelManager _iApplicationUtitlityModel = new SRoofingApplicationUtilityModelManager();
                                     _iApplicationUtitlityModel = await SRoofingSync_ApplicationUtility_Manager
                                     .Sync_Speech_Get_ApplicationUtility_ByAccountType(App.Current);


                                     await ScreenChatShow_ParseChatByMessageType(

                        App.Current,

                        _iSettingModel,

                        _iApplicationUtitlityModel,

                          _iOwner_Incoming_LanguageCode,
                                   _iOwner_Outgoing_LanguageCode,

                                   _ActionRequest,

                       _iAccountType,

                       _InviteTag,

                     _iOwnerModel,

                     _iRemoteModel,

                        _iGroupModel,

         iUserType,


                     _iLanguageModel,



                       _MessageTokenID,
                       _UploadDateTimeMilliSec,


                       _ScreenChatShowID,
                       _ScreenChatShowTicketID,

                       _CallTokenID,

                       _GroupID,

                       _GroupType,

                       _ScreenChatShowTicketTempID,

                       _ScreenChatShowTicketLineID,

                       _InviteOwnerUserID,

                       _InviteOwnerMobileNumberID,

                       _FromUserID,

                       _FromMobileNumberID,

                       _InviteToUserID,

                       _InviteToMobileNumberID,

                       _InviteToListUserID,

                       _InviteCode,

                       _InviteType,

                       _MessageType,

                       _MessageText,

                   MessageCode_Original,
                                MessageText_Original,
                                MessageCode_Translated,
                                MessageText_Translated);
                                     //,
                                     //////////       _SuggestContactListUserID ,

                                     //////////_SuggestContactListMobileNumberID ,

                                     //////////_LocationLongitude ,

                                     //////////_LocationLatitude ,

                                     //////////_CountryCode ,
                                     //////////_CountryName ,
                                     //////////_StateName ,
                                     //////////_CityName ,
                                     //////////              _AddressLine ,
                                     //////////              _StaticMapURL ,

                                     //////////_FileID ,

                                     //////////     _FileName ,
                                     //////////       _FileSize ,
                                     //////////       _FileExtension ,

                                     //////////       _FileDuration ,

                                     //////////       _FileThum ,

                                     //////////_FileCode ,

                                     //////////_FileType ,

                                     ////////// _ShareFileURL ,
                                     //////////   _ShareFileThumURL ,

                                     //////////_FileIsViewOnly ,

                                     //////////_FileState ,

                                     //////////MessageText_Translated );


                                 }
                             }
                             catch (Exception ex)
                             {

                                 SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                                 return;
                             }


                         })
                      .ConfigureAwait(false);

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }



        }



        #endregion





























        // ScreenChatShow_ParseChatByMessageType
        public static async Task ScreenChatShow_ParseChatByMessageType(

                Application context,

                SRoofingUserSettingModelManager iSettingModel,

                SRoofingApplicationUtilityModelManager iApplicationUtitlityModel,

                    string iOwner_LanguageCode_IN,
                    string iOwner_LanguageCode_OUT,

    string iActionRequest,


                string iAccountType,

                string InviteTag,

                SRoofingUserOwnerModelManager iOwnerModel,

                SRoofingUserRemoteModelManager iRemoteModel,

                   SRoofingUserGroupModelManager iGroupModel,


                    string iUserType,


                    SRoofingLanguageTranslateModel iLanguageModel,


                    string MessageTokenID,
                string UploadDateTimeMilliSec,


                string ScreenChatShowID,
                string ScreenChatShowTicketID,


                string CallTokenID,

               string GroupID,

                string GroupType,
              string ScreenChatShowTicketTempID,

                string ScreenChatShowTicketLineID,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string InviteToUserID,

                string InviteToMobileNumberID,

                string InviteToListUserID,

                string InviteCode,

                string InviteType,

                string MessageType,

                string MessageText,

                string MessageCode_Original,
        string MessageText_Original,
        string MessageCode_Translated,
        string MessageText_Translated)
        //////////string SuggestContactListUserID ,

        //////////         string SuggestContactListMobileNumberID ,

        //////////         string LocationLongitude ,

        //////////         string LocationLatitude ,

        //////////         string CountryCode ,
        //////////         string CountryName ,
        //////////         string StateName ,
        //////////         string CityName ,
        //////////         string AddressLine ,
        //////////         string StaticMapURL ,

        //////////         string FileID ,


        //////////         string FileName ,

        //////////         string FileSize ,

        //////////         string FileExtension ,


        //////////         string FileDuration ,


        //////////         string FileThum ,



        //////////         string FileCode ,

        //////////         string FileType ,

        //////////         string FileURL ,
        //////////         string FileThumURL ,

        //////////         string FileIsAllowToSave ,

        //////////         string FileState ,

        //////////         string shownMessageText 


        {

            try
            {

                if (
                       (iActionRequest ==
                                SRoofingEnum_GCM_Action_RequestManager.
                                        ScreenChatShowAction_DoCallVoiceOffer)
                                        ||   (iActionRequest ==
                                SRoofingEnum_GCM_Action_RequestManager.
                                        ScreenChatShowAction_DoCallVideoOffer))
                {


                    // Check is CALL Free
                    //bool _bln_AppCallIsFree = false;
                    bool _bln_AppCallIsFree = true;



                    ///////////////////////////////////////////

                    // show call popoup
                    /*
                     check if call is free available

                    # YES   ,   # NO
                    (YES)
                    >>> SHOW CALL POPUP


                    (NO)
                     >>> SEND WEBSOCKET-BUSY
                        
                    */

                    if (!_bln_AppCallIsFree)
                    {

                        /* CONNECT-WEBSOCKET */
                        await Initialize_Socket(
                             context,

                      iOwnerModel,

                      iRemoteModel,

                      iRemoteModel.GroupTokenID,

                         CallTokenID);

                    }
                    else
                    {

                        await SRoofing_ScreenCallShowManager
                   .Call_Initialize_Call_Show_Answer(
                        App.Current,
                          iOwnerModel,
                        iRemoteModel,
                        CallTokenID);




                        await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
                             App.Current.MainPage.Navigation,
                                typeof(Page_Call_Dashboard),
                            new Page_Call_Dashboard(),
                            false,
                            true);








                    }










                    //////////////            await ScreenChatShow_ParseChatTextTranslateMessage (

                    //////////////                         context ,

                    //////////////                         iSettingModel ,


                    //////////////           iLanguageModel ,


                    //////////////         iApplicationUtitlityModel ,



                    //////////////                         iAccountType ,

                    //////////////                         iOwnerModel ,

                    //////////////                         iRemoteModel ,

                    //////////////                         iGroupModel ,

                    //////////////                   iUserType ,

                    //////////////                   iOwner_LanguageCode_IN ,
                    //////////////                   iOwner_LanguageCode_OUT ,


                    //////////////                 MessageTokenID ,
                    //////////////                         UploadDateTimeMilliSec ,

                    //////////////                         ScreenChatShowID ,
                    //////////////                         ScreenChatShowTicketID ,
                    //////////////                         GroupID ,
                    //////////////                         GroupType ,
                    //////////////                         InviteOwnerUserID ,
                    //////////////                         InviteOwnerMobileNumberID ,
                    //////////////                         FromUserID ,
                    //////////////                         FromMobileNumberID ,
                    //////////////                         MessageType ,
                    //////////////                         MessageText ,

                    //////////////          MessageCode_Original ,
                    //////////////  MessageText_Original ,
                    //////////////  MessageCode_Translated ,
                    //////////////  MessageText_Translated ,

                    //////////////null ,
                    //////////////                         null ,
                    //////////////                         null ,
                    //////////////                         null ,
                    //////////////                         null );


                }


                /////////////////////////////////////////////////

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        //////////public static
        //////////void ScreenChatShow_ParseChatByMessageType (

        //////////        Application context ,

        //////////        string ScreenChatShowID ,

        //////////        string ScreenChatShowTicketID ,

        //////////        string GroupID ,

        //////////        string GroupType ,

        //////////        string ScreenChatShowTicketTempID ,

        //////////        string ScreenChatShowTicketLineID ,

        //////////        string InviteOwnerUserID ,

        //////////        string InviteOwnerMobileNumberID ,

        //////////        string FromUserID ,

        //////////        string FromMobileNumberID ,

        //////////        string InviteToUserID ,

        //////////        string InviteToMobileNumberID ,

        //////////        string InviteToListUserID ,

        //////////        string InviteType ,

        //////////        string MessageType ,

        //////////        string MessageText ,

        //////////        string SuggestContactListUserID ,

        //////////        string SuggestContactListMobileNumberID ,

        //////////        string LocationLongitude ,

        //////////        string LocationLatitude ,

        //////////        string LocationCityName ,

        //////////        string FileID ,

        //////////        string FileCode ,

        //////////        string FileType ,

        //////////        string FileIsAllowToSave ,

        //////////        string FileState ,

        //////////        string UploadDay ,

        //////////        string UploadMonth ,

        //////////        string UploadYear ,

        //////////        string UploadTime ,

        //////////        string UploadDateTime ,

        //////////        string MessageTextHitoryLine )
        //////////{

        //////////    /*
        //////////            try {

        //////////                if ((MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_TextMessage))
        //////////                        || (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_TextMapMessage))
        //////////                        || (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_TextDatingMessage))
        //////////                        || (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_TextBirthDayMessage))
        //////////                        || (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_TextYouTubeMessage))
        //////////                        || (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_TextWebLinkMessage))
        //////////                        || (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_TextContactMessage))) {

        //////////                    ScreenChatShow_ParseChatTextMessage(

        //////////                            context,

        //////////                            null,null,null,

        //////////                            ScreenChatShowID, ScreenChatShowTicketID, GroupID, GroupType,
        //////////                            InviteOwnerUserID, InviteOwnerMobileNumberID, FromUserID,
        //////////                            FromMobileNumberID, MessageType, MessageText, UploadDay, UploadMonth,
        //////////                            UploadYear, UploadTime, UploadDateTime);
        //////////                }

        //////////                else if ((MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_TextMessageInviteNotApproved))
        //////////                        || (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_TextMessageLogoutOwner))
        //////////                        || (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_TextMessageLogoutRemote))) {

        //////////                    ScreenChatShow_ParseChatTextInviteNotApprovedMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, GroupType, InviteOwnerUserID,
        //////////                    InviteOwnerMobileNumberID, FromUserID, FromMobileNumberID, MessageType,
        //////////                    MessageText, UploadDay, UploadMonth, UploadYear, UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_GroupNewUserToGroupInviteMessage)) {

        //////////                    ScreenChatShow_ParseChatTextStartNewUserToGroupInviteMessage(context,
        //////////                    ScreenChatShowID, ScreenChatShowTicketID, GroupID, GroupType, InviteOwnerUserID,
        //////////                    InviteOwnerMobileNumberID, FromUserID, FromMobileNumberID, InviteToUserID,
        //////////                    InviteToMobileNumberID, InviteToListUserID, InviteType, MessageType, MessageText,
        //////////                     UploadDay, UploadMonth, UploadYear, UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_GroupInviteRequestApproved)) {

        //////////                    ScreenChatShow_ParseChatTextRequestNewUserGroupInviteMessage(context,
        //////////                    ScreenChatShowID, ScreenChatShowTicketID, GroupID, GroupType, InviteOwnerUserID,
        //////////                    InviteOwnerMobileNumberID, FromUserID, FromMobileNumberID, InviteToUserID,
        //////////                    InviteToMobileNumberID, InviteToListUserID, InviteType, MessageType, MessageText,
        //////////                     UploadDay, UploadMonth, UploadYear, UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_GroupJoinUserToGroupInviteMessage)) {

        //////////                    ScreenChatShow_ParseChatTextJoinNewUserToGroupInviteMessage(context,
        //////////                    ScreenChatShowID, ScreenChatShowTicketID, GroupID, GroupType,
        //////////                    ScreenChatShowTicketTempID, ScreenChatShowTicketLineID, InviteOwnerUserID,
        //////////                    InviteOwnerMobileNumberID, FromUserID, FromMobileNumberID, MessageType,
        //////////                    MessageText, UploadDay, UploadMonth, UploadYear, UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_SuggestUserMessage)) {

        //////////                    ScreenChatShow_ParseChatShareSuggestUserMessage(context,
        //////////                            null,null,null,
        //////////                            ScreenChatShowID, ScreenChatShowTicketID, GroupID, InviteOwnerUserID,
        //////////                            InviteOwnerMobileNumberID, FromUserID, FromMobileNumberID, MessageType,
        //////////                            MessageText, SuggestContactListUserID, SuggestContactListMobileNumberID,
        //////////                            UploadDay, UploadMonth, UploadYear, UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_EmotionMessage)) {

        //////////                    ScreenChatShow_ParseChatShareEmotionMessage(context,
        //////////                            null,null,null,
        //////////                            ScreenChatShowID, ScreenChatShowTicketID, GroupID, InviteOwnerUserID,
        //////////                            InviteOwnerMobileNumberID, FromUserID, FromMobileNumberID, MessageType,
        //////////                            MessageText, UploadDay, UploadMonth, UploadYear, UploadTime,
        //////////                            UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_ShareVideoMessage)) {

        //////////                    ScreenChatShow_ParseChatShareVideoMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, FileID, FileCode,
        //////////                    FileType, FileIsAllowToSave, FileState, UploadDay, UploadMonth, UploadYear,
        //////////                    UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_ShareVideoIsUploadMessage)) {

        //////////                    ScreenChatShow_ParseChatShareVideoMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, FileID, FileCode,
        //////////                    FileType, FileIsAllowToSave, FileState, UploadDay, UploadMonth, UploadYear,
        //////////                    UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_ShareVideoViewMessage)) {

        //////////                    ScreenChatShow_ParseChatShareVideoMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, FileID, FileCode,
        //////////                    FileType, FileIsAllowToSave, FileState, UploadDay, UploadMonth, UploadYear,
        //////////                    UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_ShareVideoViewDownloadMessage)) {

        //////////                    ScreenChatShow_ParseChatShareVideoMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, FileID, FileCode,
        //////////                    FileType, FileIsAllowToSave, FileState, UploadDay, UploadMonth, UploadYear,
        //////////                    UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_ShareVideoYouTubeMessage)) {

        //////////                    ScreenChatShow_ParseChatShareVideoYouTubeMessage(
        //////////                            context,
        //////////                            null,null,null,
        //////////                            ScreenChatShowID, ScreenChatShowTicketID, GroupID, InviteOwnerUserID,
        //////////                            InviteOwnerMobileNumberID, FromUserID, FromMobileNumberID, MessageType,
        //////////                            MessageText, FileID, FileCode, FileType, FileIsAllowToSave, FileState,
        //////////                            UploadDay, UploadMonth, UploadYear, UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_SharePhotoMessage)) {

        //////////                    ScreenChatShow_ParseChatSharePhotoMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, FileID, FileCode,
        //////////                    FileType, FileIsAllowToSave, FileState, UploadDay, UploadMonth, UploadYear,
        //////////                    UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_SharePhotoIsNewTempMessage)) {

        //////////                    ScreenChatShow_ParseChatSharePhotoMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, FileID, FileCode,
        //////////                    FileType, FileIsAllowToSave, FileState, UploadDay, UploadMonth, UploadYear,
        //////////                    UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_SharePhotoViewMessage)) {

        //////////                    ScreenChatShow_ParseChatSharePhotoMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, FileID, FileCode,
        //////////                    FileType, FileIsAllowToSave, FileState, UploadDay, UploadMonth, UploadYear,
        //////////                    UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_SharePhotoViewDownloadMessage)) {

        //////////                    ScreenChatShow_ParseChatSharePhotoMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, FileID, FileCode,
        //////////                    FileType, FileIsAllowToSave, FileState, UploadDay, UploadMonth, UploadYear,
        //////////                    UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_SharePhotoCancelMessage)) {

        //////////                    ScreenChatShow_ParseChatSharePhotoMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, FileID, FileCode,
        //////////                    FileType, FileIsAllowToSave, FileState, UploadDay, UploadMonth, UploadYear,
        //////////                    UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_SharePhotoDeclineMessage)) {

        //////////                    ScreenChatShow_ParseChatSharePhotoMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, FileID, FileCode,
        //////////                    FileType, FileIsAllowToSave, FileState, UploadDay, UploadMonth, UploadYear,
        //////////                    UploadTime, UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_ShareLocationCityMessage)) {

        //////////                    ScreenChatShow_ParseChatShareLocationMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, LocationLongitude,
        //////////                    LocationLatitude, null, UploadDay, UploadMonth, UploadYear, UploadTime,
        //////////                    UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_ShareLocationPinPointMessage)) {

        //////////                    ScreenChatShow_ParseChatShareLocationMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, LocationLongitude,
        //////////                    LocationLatitude, null, UploadDay, UploadMonth, UploadYear, UploadTime,
        //////////                    UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_TextLocationNearbyMessage)) {

        //////////                    ScreenChatShow_ParseChatShareLocationMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, LocationLongitude,
        //////////                    LocationLatitude, null, UploadDay, UploadMonth, UploadYear, UploadTime,
        //////////                    UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_ShareLocationAskRemoteMessage)) {

        //////////                    ScreenChatShow_ParseChatShareLocationMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, LocationLongitude,
        //////////                    LocationLatitude, null, UploadDay, UploadMonth, UploadYear, UploadTime,
        //////////                    UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_ShareLocationAskRemoteDeclineMessage)) {

        //////////                    ScreenChatShow_ParseChatShareLocationMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, LocationLongitude,
        //////////                    LocationLatitude, null, UploadDay, UploadMonth, UploadYear, UploadTime,
        //////////                    UploadDateTime);
        //////////                } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager.
        //////////                        ScreenChatShowTextTypeMessage_CallMissedMessage)) {

        //////////                    TlknAsyncTaskScreenCallShowMessage
        //////////                            .ScreenCallShow_PostScreenCallShowOfferReceivedAction(
        //////////                                    context,
        //////////                                    String.valueOf(System.currentTimeMillis()), "invitetag", GroupID,
        //////////                                     GroupType,
        //////////                                    ScreenChatShowID, ScreenChatShowTicketID,
        //////////                                    "0", "0",
        //////////                                    InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                                    FromUserID, FromMobileNumberID,
        //////////                                    "call", InviteType,
        //////////                                    MessageType, MessageText, "busy", "answer", "in", "missed",
        //////////                                    "missed", "close", "0",
        //////////                                    1,
        //////////                                    null, null, null, null, null);


        //////////                    //ScreenChatShow_ParseChatShareLocationMessage(context, ScreenChatShowID,
        //////////                    ScreenChatShowTicketID, GroupID, InviteOwnerUserID, InviteOwnerMobileNumberID,
        //////////                    FromUserID, FromMobileNumberID, MessageType, MessageText, LocationLongitude,
        //////////                    LocationLatitude, null, UploadDay, UploadMonth, UploadYear, UploadTime,
        //////////                    UploadDateTime);


        //////////                }

        //////////            } catch (Exception ex) {
        //////////                e.printStackTrace();
        //////////                return;
        //////////            }
        //////////    */
        //////////}


        //////////// ScreenChatShow_ParseChatTextMessage
        //////////public static
        //////////void ScreenChatShow_ParseChatTextMessage (

        //////////        Application context ,

        //////////        SRoofingUserSettingModelManager iSettingModel ,

        //////////        string iAccountType ,


        //////////        SRoofingUserOwnerModelManager iOwnerModel ,

        //////////        SRoofingUserRemoteModelManager iRemoteModel ,

        //////////        string MessageTokenID ,
        //////////        string UploadDateTimeMilliSec ,

        //////////        string ScreenChatShowID ,

        //////////        string ScreenChatShowTicketID ,

        //////////        string GroupID ,

        //////////        string GroupType ,

        //////////        string InviteOwnerUserID ,

        //////////        string InviteOwnerMobileNumberID ,

        //////////        string FromUserID ,

        //////////        string FromMobileNumberID ,

        //////////        string MessageType ,

        //////////        string MessageText ,

        //////////        string UploadDay ,

        //////////        string UploadMonth ,

        //////////        string UploadYear ,

        //////////        string UploadTime ,

        //////////        string UploadDateTime )
        //////////{

        //////////    try
        //////////    {

        //////////        // TextMessage
        //////////        /*            if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager
        //////////        .ScreenChatShowTextTypeMessage_TextMessage)) {
        //////////                        MessageType = "textmessage";
        //////////                    } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager
        //////////                    .ScreenChatShowTextTypeMessage_TextMapMessage)) {
        //////////                        MessageType = "textmap";
        //////////                    } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager
        //////////                    .ScreenChatShowTextTypeMessage_TextYouTubeMessage)) {
        //////////                        MessageType = "textyoutube";
        //////////                    } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager
        //////////                    .ScreenChatShowTextTypeMessage_TextWebLinkMessage)) {
        //////////                        MessageType = "textweblink";
        //////////                    } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager
        //////////                    .ScreenChatShowTextTypeMessage_TextDatingMessage)) {
        //////////                        MessageType = "textdating";
        //////////                    } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager
        //////////                    .ScreenChatShowTextTypeMessage_TextBirthDayMessage)) {
        //////////                        MessageType = "textbirthday";
        //////////                    } else if (MessageType  ==   (TlknEnumScreenChatShowMessageTypeManager
        //////////                    .ScreenChatShowTextTypeMessage_TextContactMessage)) {
        //////////                        MessageType = "textcontact";
        //////////                    }*/

        //////////        ScreenChatShow_DatabaseSaveChatTextMessage (

        //////////                context ,

        //////////                iSettingModel ,

        //////////                iAccountType ,

        //////////                iOwnerModel ,

        //////////                iRemoteModel ,

        //////////                MessageTokenID ,
        //////////                UploadDateTimeMilliSec ,

        //////////                ScreenChatShowID ,
        //////////                ScreenChatShowTicketID ,
        //////////                GroupID ,
        //////////                GroupType ,
        //////////                InviteOwnerUserID ,
        //////////                InviteOwnerMobileNumberID ,
        //////////                FromUserID ,
        //////////                FromMobileNumberID ,
        //////////                MessageType ,
        //////////                MessageText ,
        //////////                UploadDay ,
        //////////                UploadMonth ,
        //////////                UploadYear ,
        //////////                UploadTime ,
        //////////                UploadDateTime );

        //////////    }
        //////////    catch (Exception ex)
        //////////    {
        //////////        return;
        //////////    }
        //////////}






        public static async Task ScreenChatShow_ParseChatTextMessage(

              Application context,

              SRoofingUserSettingModelManager iSettingModel,

              SRoofingLanguageTranslateModel iLanguageModel,


                      string iOwner_LanguageCode_IN,
                    string iOwner_LanguageCode_OUT,

    string iAccountType,


              SRoofingUserOwnerModelManager iOwnerModel,

              SRoofingUserRemoteModelManager iRemoteModel,

               SRoofingUserGroupModelManager iGroupModel,

        string MessageTokenID,
              string UploadDateTimeMilliSec,

              string ScreenChatShowID,

              string ScreenChatShowTicketID,

              string GroupID,

              string GroupType,

              string InviteOwnerUserID,

              string InviteOwnerMobileNumberID,

              string FromUserID,

              string FromMobileNumberID,

              string MessageType,

              string MessageText,

              string UploadDay,

              string UploadMonth,

              string UploadYear,

              string UploadTime,

              string UploadDateTime)
        {

            try
            {

                // TextMessage


                string _xMessageText = iOwner_LanguageCode_IN + "|" + MessageText;


                string DateTimeTextWS, DateTimeWS, DateTextWS, UserDateDayWS, UserDateMonthWS, UserDateYearWS;

                DateTime objNow = DateTime.Now;

                DateTimeTextWS = SRoofing_TimeManager.Time_Get_DateTimeText(objNow);

                DateTimeWS = SRoofing_TimeManager.Time_Get_DateTime(objNow);

                DateTextWS = SRoofing_TimeManager.Time_Get_DateText(objNow); ;

                UserDateDayWS = SRoofing_TimeManager.Time_Get_UploadDay(objNow);

                UserDateMonthWS = SRoofing_TimeManager.Time_Get_UploadMonth(objNow);

                UserDateYearWS = SRoofing_TimeManager.Time_Get_UploadYear(objNow);



                #region TranslationModel

                SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel();


                iTranslationModel = SRoofing_TranslationManager.Get_TranslationModel(
            SRoofingEnum_Direction.Direction_Out,
             iOwner_LanguageCode_IN,
               iOwner_LanguageCode_OUT,
             MessageText).Result;

                #endregion



                #region Post


                await Post_ScreenChatShow_Text_Translate_Pending_Message
                     .Post_ScreenChatShowTextTranslate_PendingMessageWS(

                             Application.Current,

                             iOwnerModel,

                             iSettingModel,

                             iLanguageModel,
                             iAccountType,

                             null,

                             iGroupModel,

                             MessageTokenID,
                             MessageTokenID,

                             GroupID,

                             iOwnerModel.OwnerUserTokenID,
                             iOwnerModel.OwnerMobileNumberTokenID,

                             "0",
                             SRoofingEnum_UserType.UserType_Owner,
                             SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_TextMessage_ParsePendingMessage,
                             _xMessageText,
                             MessageText,

                             iTranslationModel,

                             iOwner_LanguageCode_IN,
                             iOwner_LanguageCode_OUT,

                        "text",
                           "text",
                             SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save,

                                               DateTimeTextWS,
                DateTimeWS,
                DateTextWS,
                 UserDateDayWS,
                  UserDateMonthWS,
                  UserDateYearWS,


                             1);


                #endregion




                ////////ScreenChatShow_DatabaseSaveChatTextMessage (

                ////////        context ,

                ////////        iSettingModel ,

                ////////        iAccountType ,

                ////////        iOwnerModel ,

                ////////        iRemoteModel ,

                ////////        MessageTokenID ,
                ////////        UploadDateTimeMilliSec ,

                ////////        ScreenChatShowID ,
                ////////        ScreenChatShowTicketID ,
                ////////        GroupID ,
                ////////        GroupType ,
                ////////        InviteOwnerUserID ,
                ////////        InviteOwnerMobileNumberID ,
                ////////        FromUserID ,
                ////////        FromMobileNumberID ,
                ////////        MessageType ,
                ////////        MessageText ,
                ////////        UploadDay ,
                ////////        UploadMonth ,
                ////////        UploadYear ,
                ////////        UploadTime ,
                ////////        UploadDateTime );

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        public static
        void ScreenChatShow_ParseChatTextTranslate_PendingMessage(

                Application context,

                SRoofingUserSettingModelManager iSettingModel,

                string iAccountType,

                SRoofingUserOwnerModelManager iOwnerModel,

                SRoofingUserRemoteModelManager iRemoteModel,

                string MessageTokenID,
                string UploadDateTimeMilliSec,

                string ScreenChatShowID,

                string ScreenChatShowTicketID,

                string GroupID,

                string GroupType,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string MessageType,

                string MessageText,

                string UploadDay,

                string UploadMonth,

                string UploadYear,

                string UploadTime,

                string UploadDateTime,
                string shownMessageText)
        {

            try
            {

                // TextMessage
                ScreenChatShow_DatabaseSaveChatTextTranslate_PendingMessage(

                        context,

                        iSettingModel,

                        iAccountType,

                        iOwnerModel,

                        iRemoteModel,

                        MessageTokenID,
                        UploadDateTimeMilliSec,

                        ScreenChatShowID,
                        ScreenChatShowTicketID,
                        GroupID,
                        GroupType,
                        InviteOwnerUserID,
                        InviteOwnerMobileNumberID,
                        FromUserID,
                        FromMobileNumberID,
                        MessageType,
                        MessageText,
                        UploadDay,
                        UploadMonth,
                        UploadYear,
                        UploadTime,
                        UploadDateTime,

                        shownMessageText);

            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }





        async public static
              Task ScreenChatShow_ParseChatTextTranslateMessage(

                      Application context,

                      SRoofingUserSettingModelManager iSettingModel,


              SRoofingLanguageTranslateModel iLanguageModel,

   SRoofingApplicationUtilityModelManager iApplicationUtilityModel,

                      string iAccountType,


                      SRoofingUserOwnerModelManager iOwnerModel,

                      SRoofingUserRemoteModelManager iRemoteModel,

                    SRoofingUserGroupModelManager iGroupModel,

           string iUserType,


                      string iOwner_LanguageCode_IN,
                      string iOwner_LanguageCode_OUT,

                      string MessageTokenID,
                      string UploadDateTimeMilliSec,

                      string ScreenChatShowID,

                      string ScreenChatShowTicketID,

                      string GroupID,

                      string GroupType,

                      string InviteOwnerUserID,

                      string InviteOwnerMobileNumberID,

                      string FromUserID,

                      string FromMobileNumberID,

                      string MessageType,

                      string MessageText,


                string MessageCode_Original,
        string MessageText_Original,
        string MessageCode_Translated,
        string MessageText_Translated,

       string UploadDay,

                      string UploadMonth,

                      string UploadYear,

                      string UploadTime,

                      string UploadDateTime)
        {

            try
            {

                // TextMessage
                SRoofingTimeModel _iTimeModel = await Get_TimeModel(UploadDateTimeMilliSec);



                #region TranslationModel

                SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel();

                if (iUserType == SRoofingEnum_UserType.UserType_Owner)
                {
                    iTranslationModel = new SRoofingTranslationModel
                    {
                        MessageType = "textmessage",

                        MessageCode_Original = iOwner_LanguageCode_OUT,
                        MessageText_Original = MessageText_Original,

                        MessageCode_Translated = iOwner_LanguageCode_OUT,
                        MessageText_Translated = MessageText_Translated

                    };

                }

                else if (MessageCode_Original == iOwner_LanguageCode_IN)
                {
                    iTranslationModel = new SRoofingTranslationModel
                    {
                        MessageType = "textmessage",

                        MessageCode_Original = iOwner_LanguageCode_IN,
                        MessageText_Original = MessageText_Original,

                        MessageCode_Translated = iOwner_LanguageCode_IN,
                        MessageText_Translated = MessageText_Translated

                    };

                }
                else if (MessageCode_Original == iOwner_LanguageCode_OUT)
                {
                    iTranslationModel = new SRoofingTranslationModel
                    {
                        MessageType = "textmessage",

                        MessageCode_Original = iOwner_LanguageCode_OUT,
                        MessageText_Original = MessageText_Original,

                        MessageCode_Translated = iOwner_LanguageCode_OUT,
                        MessageText_Translated = MessageText_Translated

                    };

                }
                else
                {
                    iTranslationModel = SRoofing_TranslationManager.Get_TranslationModel(
         SRoofingEnum_Direction.Direction_In,
          iOwner_LanguageCode_IN,
            iOwner_LanguageCode_OUT,
          MessageText_Original).Result;
                }




                ////////if ( iTranslationModel.MessageText_Translated == "0" )
                ////////{
                ////////    iTranslationModel.MessageType = "textmessage";
                ////////    iTranslationModel.MessageCode_Translated = iTranslationModel.MessageCode_Original;
                ////////    iTranslationModel.MessageText_Translated = iTranslationModel.MessageText_Original;
                ////////}

                #endregion




                #region Post


                await Post_ScreenChatShow_Text_Translate_Pending_Message
                     .Post_ScreenChatShowTextTranslate_PendingMessageWS(

                             context,

                             iOwnerModel,

                             iSettingModel,


                             iLanguageModel,

                             iAccountType,

                             iRemoteModel,

                             iGroupModel,

                              MessageTokenID,
                             UploadDateTimeMilliSec,

                             GroupID,

                             iOwnerModel.OwnerUserTokenID,
                             iOwnerModel.OwnerMobileNumberTokenID,

                             "0",
                            iUserType,
                             MessageType,
                             MessageText,
                             MessageText,

                             iTranslationModel,

                             iOwner_LanguageCode_IN,
                             iOwner_LanguageCode_OUT,

                             "text",
                             "text",
                             SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save,

                                          _iTimeModel.DateTimeTextWS,
               _iTimeModel.DateTimeWS,
              _iTimeModel.DateTextWS,
               _iTimeModel.DateDayWS,
                 _iTimeModel.DateMonthWS,
                _iTimeModel.DateYearWS,


                             0);


                #endregion




            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }






        async public static
              Task ScreenChatShow_ParseChatTextWebLinkMessage(

                      Application context,

                      SRoofingUserSettingModelManager iSettingModel,


              SRoofingLanguageTranslateModel iLanguageModel,

   SRoofingApplicationUtilityModelManager iApplicationUtilityModel,

                      string iAccountType,


                      SRoofingUserOwnerModelManager iOwnerModel,

                      SRoofingUserRemoteModelManager iRemoteModel,

                    SRoofingUserGroupModelManager iGroupModel,

           string iUserType,


                      string iOwner_LanguageCode_IN,
                      string iOwner_LanguageCode_OUT,

                      string MessageTokenID,
                      string UploadDateTimeMilliSec,

                      string ScreenChatShowID,

                      string ScreenChatShowTicketID,

                      string GroupID,

                      string GroupType,

                      string InviteOwnerUserID,

                      string InviteOwnerMobileNumberID,

                      string FromUserID,

                      string FromMobileNumberID,

                      string MessageType,

                      string MessageText,


                string MessageCode_Original,
        string MessageText_Original,
        string MessageCode_Translated,
        string MessageText_Translated,

       string UploadDay,

                      string UploadMonth,

                      string UploadYear,

                      string UploadTime,

                      string UploadDateTime)
        {

            try
            {

                // TextMessage
                SRoofingTimeModel _iTimeModel = await Get_TimeModel(UploadDateTimeMilliSec);



                #region TranslationModel

                SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel();

                iTranslationModel = new SRoofingTranslationModel
                {
                    MessageType = "textweblink",

                    MessageCode_Original = "en", //iOwner_LanguageCode_OUT ,
                    MessageText_Original = MessageText_Original,

                    MessageCode_Translated = "en", //iOwner_LanguageCode_OUT ,
                    MessageText_Translated = MessageText_Translated

                };






                ////////////       if ( iUserType == SRoofingEnum_UserType.UserType_Owner )
                ////////////       {
                ////////////           iTranslationModel = new SRoofingTranslationModel
                ////////////           {
                ////////////               MessageType = "textmessage" ,

                ////////////               MessageCode_Original = iOwner_LanguageCode_OUT ,
                ////////////               MessageText_Original = MessageText_Original ,

                ////////////               MessageCode_Translated = iOwner_LanguageCode_OUT ,
                ////////////               MessageText_Translated = MessageText_Translated

                ////////////           };   

                ////////////       }

                ////////////       else if ( MessageCode_Original == iOwner_LanguageCode_IN )
                ////////////       {
                ////////////           iTranslationModel = new SRoofingTranslationModel
                ////////////           {
                ////////////               MessageType = "textmessage" ,

                ////////////               MessageCode_Original = iOwner_LanguageCode_IN ,
                ////////////               MessageText_Original = MessageText_Original ,

                ////////////               MessageCode_Translated = iOwner_LanguageCode_IN ,
                ////////////               MessageText_Translated = MessageText_Translated

                ////////////           };

                ////////////       }
                ////////////       else if ( MessageCode_Original == iOwner_LanguageCode_OUT )
                ////////////       {
                ////////////           iTranslationModel = new SRoofingTranslationModel
                ////////////           {
                ////////////               MessageType = "textmessage" ,

                ////////////               MessageCode_Original = iOwner_LanguageCode_OUT ,
                ////////////               MessageText_Original = MessageText_Original ,

                ////////////               MessageCode_Translated = iOwner_LanguageCode_OUT ,
                ////////////               MessageText_Translated = MessageText_Translated

                ////////////           };

                ////////////       }
                ////////////       else
                ////////////       {
                ////////////           iTranslationModel = SRoofing_TranslationManager.Get_TranslationModel (
                ////////////SRoofingEnum_Direction.Direction_In ,
                //////////// iOwner_LanguageCode_IN ,
                ////////////   iOwner_LanguageCode_OUT ,
                //////////// MessageText_Original ).Result;
                ////////////       }


                #endregion




                #region Post


                await Post_ScreenChatShow_Text_Translate_Pending_Message
                     .Post_ScreenChatShowTextTranslate_PendingMessageWS(

                             context,

                             iOwnerModel,

                             iSettingModel,

                             iLanguageModel,


                             iAccountType,

                             iRemoteModel,

                             iGroupModel,

                              MessageTokenID,
                             UploadDateTimeMilliSec,

                             GroupID,

                             iOwnerModel.OwnerUserTokenID,
                             iOwnerModel.OwnerMobileNumberTokenID,

                             "0",
                            iUserType,
                             MessageType,
                             MessageText,
                             MessageText,

                             iTranslationModel,

                             iOwner_LanguageCode_IN,
                             iOwner_LanguageCode_OUT,

                             "text",
                             "text",
                             SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save,

                                          _iTimeModel.DateTimeTextWS,
               _iTimeModel.DateTimeWS,
              _iTimeModel.DateTextWS,
               _iTimeModel.DateDayWS,
                 _iTimeModel.DateMonthWS,
                _iTimeModel.DateYearWS,


                             0);


                #endregion




            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        public static
        void ScreenChatShow_ParseChatTextEventMessage(

                Application context,

                SRoofingUserSettingModelManager iSettingModel,


              SRoofingLanguageTranslateModel iLanguageModel,

    string iAccountType,


                SRoofingUserOwnerModelManager iOwnerModel,

                SRoofingUserRemoteModelManager iRemoteModel,

                string MessageTokenID,
                string UploadDateTimeMilliSec,

                string ScreenChatShowID,

                string ScreenChatShowTicketID,

                string GroupID,

                string GroupType,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string MessageType,

                string MessageText,

                string UploadDay,

                string UploadMonth,

                string UploadYear,

                string UploadTime,

                string UploadDateTime)
        {

            try
            {

                // TextMessage
                ////////ScreenChatShow_DatabaseSaveChatTextEventMessage (

                ////////         context ,

                ////////         iSettingModel ,

                ////////         iAccountType ,

                ////////         iOwnerModel ,

                ////////         iRemoteModel ,

                ////////         MessageTokenID ,
                ////////         UploadDateTimeMilliSec ,

                ////////         ScreenChatShowID ,
                ////////         ScreenChatShowTicketID ,
                ////////         GroupID ,
                ////////         GroupType ,
                ////////         InviteOwnerUserID ,
                ////////         InviteOwnerMobileNumberID ,
                ////////         FromUserID ,
                ////////         FromMobileNumberID ,
                ////////         MessageType ,
                ////////         MessageText ,
                ////////         UploadDay ,
                ////////         UploadMonth ,
                ////////         UploadYear ,
                ////////         UploadTime ,
                ////////         UploadDateTime );

            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        public static
        void ScreenChatShow_ParseChatTextShopMessage(

                Application context,

                SRoofingUserSettingModelManager iSettingModel,

                string iAccountType,


                SRoofingUserOwnerModelManager iOwnerModel,

                SRoofingUserRemoteModelManager iRemoteModel,

                string MessageTokenID,
                string UploadDateTimeMilliSec,

                string ScreenChatShowID,

                string ScreenChatShowTicketID,

                string GroupID,

                string GroupType,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string MessageType,

                string MessageText,

                string UploadDay,

                string UploadMonth,

                string UploadYear,

                string UploadTime,

                string UploadDateTime)
        {

            try
            {

                // TextMessage
                //ScreenChatShow_DatabaseSaveChatTextShopMessage (

                //        context ,

                //        iSettingModel ,

                //        iAccountType ,

                //        iOwnerModel ,

                //        iRemoteModel ,

                //        MessageTokenID ,
                //        UploadDateTimeMilliSec ,

                //        ScreenChatShowID ,
                //        ScreenChatShowTicketID ,
                //        GroupID ,
                //        GroupType ,
                //        InviteOwnerUserID ,
                //        InviteOwnerMobileNumberID ,
                //        FromUserID ,
                //        FromMobileNumberID ,
                //        MessageType ,
                //        MessageText ,
                //        UploadDay ,
                //        UploadMonth ,
                //        UploadYear ,
                //        UploadTime ,
                //        UploadDateTime );

            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        public static
        void ScreenChatShow_ParseCallTextMessage(

                Application context,

                SRoofingUserSettingModelManager iSettingModel,

                string iAccountType,


                string InviteTag,

                SRoofingUserOwnerModelManager iOwnerModel,

                SRoofingUserRemoteModelManager iRemoteModel,

                string MessageTokenID,
                string UploadDateTimeMilliSec,

                string ScreenChatShowID,

                string ScreenChatShowTicketID,

                string GroupID,

                string GroupType,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string InviteCode,
                string InviteType,

                string MessageType,

                string MessageText,

                string UploadDay,

                string UploadMonth,

                string UploadYear,

                string UploadTime,

                string UploadDateTime)
        {

            try
            {

                // TextMessage

                //////        ScreenChatShow_DatabaseSaveCallTextMessage (

                //////context ,

                //////iSettingModel ,

                //////iAccountType ,

                //////iOwnerModel ,

                //////InviteTag ,

                //////iRemoteModel ,

                //////MessageTokenID ,
                //////UploadDateTimeMilliSec ,

                //////ScreenChatShowID ,
                //////ScreenChatShowTicketID ,
                //////GroupID ,
                //////GroupType ,
                //////InviteOwnerUserID ,
                //////InviteOwnerMobileNumberID ,
                //////FromUserID ,
                //////FromMobileNumberID ,

                //////InviteCode ,
                //////InviteType ,

                //////MessageType ,
                //////MessageText ,

                //////UploadDay ,
                //////UploadMonth ,
                //////UploadYear ,
                //////UploadTime ,
                //////UploadDateTime );

            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        // ScreenChatShow_ParseChatTextMessage
        public static
        void ScreenChatShow_ParseChatText_LogoutMessage(

                Application context,

                SRoofingUserSettingModelManager iSettingModel,

                string iAccountType,


                SRoofingUserOwnerModelManager iOwnerModel,

                SRoofingUserRemoteModelManager iRemoteModel,

                string MessageTokenID,
                string UploadDateTimeMilliSec,

                string ScreenChatShowID,

                string ScreenChatShowTicketID,

                string GroupID,

                string GroupType,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string MessageType,

                string MessageText,

                string UploadDay,

                string UploadMonth,

                string UploadYear,

                string UploadTime,

                string UploadDateTime)
        {

            try
            {

                //MessageType = "textmessage";

                // TextMessage
                //////                if ( (
                //////                        MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.
                //////                                                               ScreenChatShowTextTypeMessage_TextMessageLogoutOwner ) ) )
                //////                {

                //////                    MessageText = SRoofingEnum_ScreenChatShowTextParseMessageManager
                //////                            .ScreenChatShowTextParseMessage_RemoteLeaveUserInviteTextMessage ( );

                //////                }
                //////                else if ( (
                //////                        MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.
                //////                                                               ScreenChatShowTextTypeMessage_TextMessageLogin_AddMore ) ) )
                //////                {

                //////                    MessageText = "Added <b>" + MessageText + "</b> to the chat";

                //////                    /* SRoofingEnum_ScreenChatShowTextParseMessageManager
                //////                     .ScreenChatShowTextParseMessage_OwnerToRemoteLeaveUserInviteTextMessage();
                //////*/

                //////                }
                //////                else if ( (
                //////                        MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.
                //////                                                               ScreenChatShowTextTypeMessage_TextMessageLogoutRemote ) ) )
                //////                {

                //////                    MessageText = "Removed <b>" + MessageText + "</b> from the chat";

                //////                    /* SRoofingEnum_ScreenChatShowTextParseMessageManager
                //////                     .ScreenChatShowTextParseMessage_OwnerToRemoteLeaveUserInviteTextMessage();*/


                //////                }
                //////                else if ( (
                //////                        MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.
                //////                                                               ScreenChatShowTextTypeMessage_TextMessageLogoutInviteOwner ) ) )
                //////                {

                //////                    MessageText = SRoofingEnum_ScreenChatShowTextParseMessageManager
                //////                            .ScreenChatShowTextParseMessage_RemoteLeaveUserInviteOwnerTextMessage ( );


                //////                }



                //////                ScreenChatShow_DatabaseSaveChatText_LogoutMessage (

                //////                        context ,

                //////                        iSettingModel ,

                //////                        iAccountType ,

                //////                        iOwnerModel ,

                //////                        iRemoteModel ,

                //////                        MessageTokenID ,
                //////                        UploadDateTimeMilliSec ,

                //////                        ScreenChatShowID ,
                //////                        ScreenChatShowTicketID ,
                //////                        GroupID ,
                //////                        GroupType ,
                //////                        InviteOwnerUserID ,
                //////                        InviteOwnerMobileNumberID ,
                //////                        FromUserID ,
                //////                        FromMobileNumberID ,
                //////                        MessageType ,
                //////                        MessageType ,
                //////                        MessageText ,
                //////                        UploadDay ,
                //////                        UploadMonth ,
                //////                        UploadYear ,
                //////                        UploadTime ,
                //////                        UploadDateTime );

            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        public static
        void ScreenChatShow_ParseChatTextInviteNotApprovedMessage(

                Application context,

                string ScreenChatShowID,

                string ScreenChatShowTicketID,

                string GroupID,

                string GroupType,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string MessageType,

                string MessageText,

                string UploadDay,

                string UploadMonth,

                string UploadYear,

                string UploadTime,

                string UploadDateTime)
        {

            try
            {

                // TextMessage
                MessageType = "textmessage";

                //////ScreenChatShow_DatabaseSaveChatTextInviteNotApprovedMessage (
                //////        context ,
                //////        ScreenChatShowID ,
                //////        ScreenChatShowTicketID ,
                //////        GroupID ,
                //////        GroupType ,
                //////        InviteOwnerUserID ,
                //////        InviteOwnerMobileNumberID ,
                //////        FromUserID ,
                //////        FromMobileNumberID ,
                //////        MessageType ,
                //////        MessageText ,
                //////        null ,
                //////        null ,
                //////        null ,
                //////        null ,
                //////        null );

            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        // ScreenChatShow_ParseChatTextStartNewUserToGroupInviteMessage
        public static
        void ScreenChatShow_ParseChatTextStartNewUserToGroupInviteMessage(

                Application context,

                SRoofingUserSettingModelManager iSettingModel,

                string ScreenChatShowID,

                string ScreenChatShowTicketID,

                string GroupID,

                string GroupType,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string ToUserID,

                string ToMobileNumberID,

                string ToListUserID,

                string InviteType,

                string MessageType,

                string MessageText,

                string UploadDay,

                string UploadMonth,

                string UploadYear,

                string UploadTime,

                string UploadDateTime)
        {

            try
            {


                // TextMessage
                MessageType = "textgroupinvite";

                //////string InviteMessageLine;

                //////if ( InviteType == ( "one" ) )
                //////{
                //////    InviteMessageLine =
                //////            TlknChatTextParse.ChatText_GetBoldChatMessageOneUserInvitedText (
                //////                    ToUserID );
                //////}
                //////else
                //////{
                //////    ArrayList<String> arrParseInvitedUserList =
                //////            new ArrayList<String> ( Arrays.asList (
                //////                    ToListUserID.split ( "," ) ) );

                //////    InviteMessageLine =
                //////            TlknChatTextParse.ChatText_GetBoldChatMessageManyUserInvitedText (
                //////                    arrParseInvitedUserList );

                //////}


                //////ScreenChatShow_DatabaseSaveChatTextMessage (

                //////        context ,

                //////        iSettingModel ,

                //////        null ,
                //////        null ,
                //////        null ,
                //////        null ,
                //////        null ,

                //////        ScreenChatShowID ,
                //////        ScreenChatShowTicketID ,
                //////        GroupID ,
                //////        GroupType ,
                //////        InviteOwnerUserID ,
                //////        InviteOwnerMobileNumberID ,
                //////        FromUserID ,
                //////        FromMobileNumberID ,

                //////        MessageType ,
                //////        InviteMessageLine ,
                //////        UploadDay ,
                //////        UploadMonth ,
                //////        UploadYear ,
                //////        UploadTime ,
                //////        UploadDateTime );


            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        public static
        void ScreenChatShow_ParseChatTextRequestNewUserGroupInviteMessage(

                Application context,

                SRoofingUserSettingModelManager iSettingModel,

                string ScreenChatShowID,

                string ScreenChatShowTicketID,

                string GroupID,

                string GroupType,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string ToUserID,

                string ToMobileNumberID,

                string ToListUserID,

                string InviteType,

                string MessageType,

                string MessageText,

                string UploadDay,

                string UploadMonth,

                string UploadYear,

                string UploadTime,

                string UploadDateTime)
        {

            try
            {

                // TextMessage
                //////MessageType = "textgroupinvite";

                //////string InviteMessageLine;

                //////if ( InviteType == ( "one" ) )
                //////{
                //////    InviteMessageLine =
                //////            TlknChatTextParse.ChatText_GetBoldChatMessageOneUserInvitedText (
                //////                    ToUserID );
                //////}
                //////else
                //////{
                //////    ArrayList<String> arrParseInvitedUserList =
                //////            new ArrayList<String> ( Arrays.asList (
                //////                    ToListUserID.split ( "," ) ) );

                //////    InviteMessageLine =
                //////            TlknChatTextParse.ChatText_GetBoldChatMessageManyUserInvitedText (
                //////                    arrParseInvitedUserList );

                //////}


                //////ScreenChatShow_DatabaseSaveChatTextMessage (

                //////        context ,

                //////        iSettingModel ,

                //////        null ,
                //////        null ,
                //////        null ,
                //////        null ,
                //////        null ,

                //////        ScreenChatShowID ,
                //////        ScreenChatShowTicketID ,
                //////        GroupID ,
                //////        GroupType ,
                //////        InviteOwnerUserID ,
                //////        InviteOwnerMobileNumberID ,
                //////        FromUserID ,
                //////        FromMobileNumberID ,

                //////        MessageType ,
                //////        InviteMessageLine ,
                //////        UploadDay ,
                //////        UploadMonth ,
                //////        UploadYear ,
                //////        UploadTime ,
                //////        UploadDateTime );


            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        // ScreenChatShow_ParseChatTextJoinNewUserToGroupInviteMessage
        public static
        void ScreenChatShow_ParseChatTextJoinNewUserToGroupInviteMessage(

                Application context,

                SRoofingUserSettingModelManager iSettingModel,

                string ScreenChatShowID,

                string ScreenChatShowTicketID,

                string GroupID,

                string GroupType,

                string ScreenChatShowTicketTempID,

                string ScreenChatShowTicketLineID,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string MessageType,

                string MessageText,

                string UploadDay,

                string UploadMonth,

                string UploadYear,

                string UploadTime,

                string UploadDateTime)
        {

            try
            {

                //////TlknScreenChatShowMessageDatabaseAdapter dbTlknScreenChatShowMessageDatabaseAdapter =
                //////        new TlknScreenChatShowMessageDatabaseAdapter (
                //////                context );

                //////if ( dbTlknScreenChatShowMessageDatabaseAdapter
                //////             .ChatText_CheckSeparatorSpaceLineIsExist (
                //////                     ScreenChatShowID ,
                //////                     ScreenChatShowTicketID ,
                //////                     ScreenChatShowTicketLineID ,
                //////                     "spaceline" ,
                //////                     "spaceline" ) == false )
                //////{

                //////    dbTlknScreenChatShowMessageDatabaseAdapter
                //////            .ChatText_AddNewScreenChatShowSeparatorSpaceLine (

                //////                    ScreenChatShowID ,
                //////                    ScreenChatShowTicketID ,
                //////                    GroupID );
                //////}

                //////// TextMessage
                //////MessageType = "textgroupinvite";

                //////ScreenChatShow_DatabaseSaveChatTextMessage (

                //////        context ,

                //////        iSettingModel ,

                //////        null ,
                //////        null ,
                //////        null ,
                //////        null ,
                //////        null ,

                //////        ScreenChatShowID ,
                //////        ScreenChatShowTicketID ,
                //////        GroupID ,
                //////        GroupType ,
                //////        InviteOwnerUserID ,
                //////        InviteOwnerMobileNumberID ,
                //////        FromUserID ,
                //////        FromMobileNumberID ,

                //////        MessageType ,
                //////        SRoofingEnum_ScreenChatShowTextParseMessageManager
                //////                .ScreenChatShowTextParseMessage_RemoteAcceptUserInviteTextReplyByTextMessage ( ) ,
                //////        UploadDay ,
                //////        UploadMonth ,
                //////        UploadYear ,
                //////        UploadTime ,
                //////        UploadDateTime );



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        // ScreenChatShow_ParseChatShareSuggestUserMessage
        public static
        void ScreenChatShow_ParseChatShareSuggestUserMessage(

                Application context,

                SRoofingUserSettingModelManager iSettingModel,

                string iAccountType,


                SRoofingUserOwnerModelManager iOwnerModel,

                SRoofingUserRemoteModelManager iRemoteModel,

                string MessageTokenID,
                string UploadDateTimeMilliSec,

                string ScreenChatShowID,

                string ScreenChatShowTicketID,

                string GroupID,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string MessageType,

                string MessageText,

                string SuggestContactListUserID,

                string SuggestContactListMobileNumberID,

                string UploadDay,

                string UploadMonth,

                string UploadYear,

                string UploadTime,

                string UploadDateTime)
        {

            try
            {

                // SuggestUserMessage
                //////MessageType = "textsuggestuser";

                //////MessageText =
                //////        SRoofingEnum_ScreenChatShowTextParseMessageManager.ScreenChatShowTextParseMessage_RemoteSuggestUserMessage ( );

                //////ScreenChatShow_DatabaseSaveChatShareSuggestUserMessage (

                //////        context ,

                //////        iSettingModel ,

                //////        iAccountType ,

                //////        iOwnerModel ,

                //////        iRemoteModel ,

                //////        MessageTokenID ,
                //////        UploadDateTimeMilliSec ,
                //////        ScreenChatShowID ,
                //////        ScreenChatShowTicketID ,
                //////        GroupID ,
                //////        InviteOwnerUserID ,
                //////        InviteOwnerMobileNumberID ,
                //////        FromUserID ,
                //////        FromMobileNumberID ,
                //////        MessageType ,
                //////        MessageText ,
                //////        SuggestContactListUserID ,
                //////        SuggestContactListMobileNumberID ,
                //////        UploadDay ,
                //////        UploadMonth ,
                //////        UploadYear ,
                //////        UploadTime ,
                //////        UploadDateTime );

            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        // ScreenChatShow_ParseChatShareEmotionMessage
        public static
        void ScreenChatShow_ParseChatShareEmotionMessage(

                Application context,

                SRoofingUserSettingModelManager iSettingModel,

                string iAccountType,


                SRoofingUserOwnerModelManager iOwnerModel,

                SRoofingUserRemoteModelManager iRemoteModel,

                string MessageTokenID,
                string UploadDateTimeMilliSec,

                string ScreenChatShowID,

                string ScreenChatShowTicketID,

                string GroupID,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string MessageType,

                string MessageText,

                string UploadDay,

                string UploadMonth,

                string UploadYear,

                string UploadTime,

                string UploadDateTime)
        {

            try
            {

                // EmotionMessage
                //////MessageType = "textemotion";

                //////ScreenChatShow_DatabaseSaveChatShareEmotionMessage (

                //////        context ,

                //////        iSettingModel ,

                //////        iAccountType ,

                //////        iOwnerModel ,

                //////        iRemoteModel ,

                //////        MessageTokenID ,
                //////        UploadDateTimeMilliSec ,

                //////        ScreenChatShowID ,
                //////        ScreenChatShowTicketID ,
                //////        GroupID ,
                //////        InviteOwnerUserID ,
                //////        InviteOwnerMobileNumberID ,
                //////        FromUserID ,
                //////        FromMobileNumberID ,
                //////        MessageType ,
                //////        MessageText ,
                //////        UploadDay ,
                //////        UploadMonth ,
                //////        UploadYear ,
                //////        UploadTime ,
                //////        UploadDateTime );

            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        // ScreenChatShow_ParseChatShareStickerMessage
        public static
        void ScreenChatShow_ParseChatShareStickerMessage(

                Application context,

                SRoofingUserSettingModelManager iSettingModel,

                string iAccountType,


                SRoofingUserOwnerModelManager iOwnerModel,

                SRoofingUserRemoteModelManager iRemoteModel,

                string MessageTokenID,
                string UploadDateTimeMilliSec,

                string ScreenChatShowID,

                string ScreenChatShowTicketID,

                string GroupID,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string MessageType,

                string MessageText,

                string UploadDay,

                string UploadMonth,

                string UploadYear,

                string UploadTime,

                string UploadDateTime)
        {

            try
            {

                // EmotionMessage
                //////MessageType = "textsticker";

                //////ScreenChatShow_DatabaseSaveChatShareStickerMessage (

                //////        context ,

                //////        iSettingModel ,

                //////        iAccountType ,

                //////        iOwnerModel ,

                //////        iRemoteModel ,

                //////        MessageTokenID ,
                //////        UploadDateTimeMilliSec ,

                //////        ScreenChatShowID ,
                //////        ScreenChatShowTicketID ,
                //////        GroupID ,
                //////        InviteOwnerUserID ,
                //////        InviteOwnerMobileNumberID ,
                //////        FromUserID ,
                //////        FromMobileNumberID ,
                //////        MessageType ,
                //////        MessageText ,
                //////        UploadDay ,
                //////        UploadMonth ,
                //////        UploadYear ,
                //////        UploadTime ,
                //////        UploadDateTime );

            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        public static
        void ScreenChatShow_ParseChatShareGiphyMessage(

                Application context,

                SRoofingUserSettingModelManager iSettingModel,

                string iAccountType,


                SRoofingUserOwnerModelManager iOwnerModel,

                SRoofingUserRemoteModelManager iRemoteModel,

                string MessageTokenID,
                string UploadDateTimeMilliSec,

                string ScreenChatShowID,

                string ScreenChatShowTicketID,

                string GroupID,

                string InviteOwnerUserID,

                string InviteOwnerMobileNumberID,

                string FromUserID,

                string FromMobileNumberID,

                string MessageType,

                string MessageText,

                string UploadDay,

                string UploadMonth,

                string UploadYear,

                string UploadTime,

                string UploadDateTime)
        {

            try
            {

                // EmotionMessage
                //////MessageType = "textgiphy";

                //////ScreenChatShow_DatabaseSaveChatShareGiphyMessage (

                //////        context ,

                //////        iSettingModel ,

                //////        iAccountType ,

                //////        iOwnerModel ,

                //////        iRemoteModel ,

                //////        MessageTokenID ,
                //////        UploadDateTimeMilliSec ,

                //////        ScreenChatShowID ,
                //////        ScreenChatShowTicketID ,
                //////        GroupID ,
                //////        InviteOwnerUserID ,
                //////        InviteOwnerMobileNumberID ,
                //////        FromUserID ,
                //////        FromMobileNumberID ,
                //////        MessageType ,
                //////        MessageText ,
                //////        UploadDay ,
                //////        UploadMonth ,
                //////        UploadYear ,
                //////        UploadTime ,
                //////        UploadDateTime );

            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        public static
    async Task ScreenChatShow_ParseChatShareAudioMessage(

            Application context,

            SRoofingUserSettingModelManager iSettingModel,

            SRoofingApplicationUtilityModelManager iApplicationUtitlityModel,

            string iAccountType,


            SRoofingUserOwnerModelManager iOwnerModel,

            SRoofingUserRemoteModelManager iRemoteModel,

                     SRoofingUserGroupModelManager iGroupModel,


           string iUserType,



                      string iOwner_LanguageCode_IN,
                      string iOwner_LanguageCode_OUT,


                      string MessageTokenID,
            string UploadDateTimeMilliSec,

            string ScreenChatShowID,

            string ScreenChatShowTicketID,

            string GroupID,

            string InviteOwnerUserID,

            string InviteOwnerMobileNumberID,

            string FromUserID,

            string FromMobileNumberID,

            string MessageType,

            string MessageText,


                string MessageCode_Original,
        string MessageText_Original,
        string MessageCode_Translated,
        string MessageText_Translated,



                string FileID,


                string FileName,

                string FileSize,

                string FileExtension,


                string FileDuration,



            string FileCode,

            string FileType,

            string FileURL,
            string FileThumURL,

            string FileIsAllowToSave,

            string FileState,

            string UploadDay,

            string UploadMonth,

            string UploadYear,

            string UploadTime,

            string UploadDateTime)
        {

            // ShareVideoMessage
            // TextMessage
            SRoofingTimeModel _iTimeModel = await Get_TimeModel(UploadDateTimeMilliSec);



            #region TranslationModel


            SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel
            {
                MessageCode_Original = iOwner_LanguageCode_IN,
                MessageText_Original = MessageText,

                MessageCode_Translated = iOwner_LanguageCode_IN,
                MessageText_Translated = MessageText

            };



            #endregion






            //////if ( iSettingModel.Media_AutoDownloadAudio != null )
            //////{

            //////    ////                if ( iSettingModel.Media_AutoDownloadAudio  == true )
            //////    ////                {

            //////    ////                    if ( Integer.parseInt ( FileIsAllowToSave ) == 1 )
            //////    ////                    {

            //////    ////                        Intent iTlknIntentServiceScreenChatShowDownload_Audio = new Intent (
            //////    ////                                context ,
            //////    ////                                TlknIntentServiceScreenChatShowDownload_Audio.class );

            //////    ////                        iTlknIntentServiceScreenChatShowDownload_Audio.putExtra(
            //////    ////                                "GroupID" ,
            //////    ////                                GroupID );
            //////    ////                        iTlknIntentServiceScreenChatShowDownload_Audio.putExtra(
            //////    ////                                "MessageID" ,
            //////    ////                                "0" );
            //////    ////                        iTlknIntentServiceScreenChatShowDownload_Audio.putExtra(
            //////    ////                                "VideoDefaultServerID" ,
            //////    ////                                FileID );
            //////    ////                        iTlknIntentServiceScreenChatShowDownload_Audio.putExtra(
            //////    ////                                "VideoDefaultServerURL" ,
            //////    ////                                Globals.URL_TlknDownloader_VideoFileDataURL + FileID );
            //////    ////                        context.startService(iTlknIntentServiceScreenChatShowDownload_Audio );

            //////    ////                    }
            //////    ////}
            //////}

            //////MessageType = "textshareaudio";

            //////ScreenChatShow_DatabaseUpdateChatShareAudioIsUploadMessage (
            //////        context ,

            //////        iSettingModel ,

            //////        iAccountType ,

            //////        iOwnerModel ,

            //////        iRemoteModel ,

            //////        MessageTokenID ,
            //////        UploadDateTimeMilliSec ,
            //////        ScreenChatShowID ,
            //////        ScreenChatShowTicketID ,
            //////        GroupID ,
            //////        InviteOwnerUserID ,
            //////        InviteOwnerMobileNumberID ,
            //////        FromUserID ,
            //////        FromMobileNumberID ,
            //////        MessageType ,
            //////        MessageText ,
            //////        FileID ,
            //////        FileCode ,
            //////        FileType ,
            //////        FileURL ,
            //////        FileThumURL ,
            //////        FileIsAllowToSave ,
            //////        FileState ,
            //////        UploadDay ,
            //////        UploadMonth ,
            //////        UploadYear ,
            //////        UploadTime ,
            //////        UploadDateTime );




        }


        public static
  async Task ScreenChatShow_ParseChatShareDocumentMessage(

         Application context,

         SRoofingUserSettingModelManager iSettingModel,

         SRoofingApplicationUtilityModelManager iApplicationUtitlityModel,

         string iAccountType,


         SRoofingUserOwnerModelManager iOwnerModel,

         SRoofingUserRemoteModelManager iRemoteModel,

                   SRoofingUserGroupModelManager iGroupModel,


           string iUserType,


                    SRoofingLanguageTranslateModel iLanguageModel,


                      string iOwner_LanguageCode_IN,
                      string iOwner_LanguageCode_OUT,



  string MessageTokenID,
         string UploadDateTimeMilliSec,

         string ScreenChatShowID,

         string ScreenChatShowTicketID,

         string GroupID,

         string InviteOwnerUserID,

         string InviteOwnerMobileNumberID,

         string FromUserID,

         string FromMobileNumberID,

         string MessageType,

         string MessageText,



                string MessageCode_Original,
        string MessageText_Original,
        string MessageCode_Translated,
        string MessageText_Translated,





                       string FileID,

                           string FileName,
                            string FileSize,
                              string FileExtension,

                              string FileDuration,

                               string FileThum,

                         string FileCode,

                        string FileType,




         string UploadDay,

         string UploadMonth,

         string UploadYear,

         string UploadTime,

         string UploadDateTime)
        {


            try
            {

                // ShareDocumentMessage
                SRoofingTimeModel _iTimeModel = await Get_TimeModel(UploadDateTimeMilliSec);



                #region TranslationModel


                SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel
                {
                    MessageCode_Original = iOwner_LanguageCode_IN,
                    MessageText_Original = MessageText,

                    MessageCode_Translated = iOwner_LanguageCode_IN,
                    MessageText_Translated = MessageText

                };



                #endregion




                #region Media_Model

                //   FileInfo fi = new FileInfo ( fileResult.FullPath );
                //FileInfo fi = new FileInfo ( FileFullPath );


                SRoofingUserMediaModel _iUserMediaModel = new SRoofingUserMediaModel(


                   FileID,
                   null,

                  FileCode,
                   FileType,
                  FileThum,
                  FileName,
                   FileExtension,
                     FileSize,
                 FileDuration,

                   FileID,
                   FileID,
                     SRoofing_URLManager.URL_Document.Document_Get_DocumentDataByDocumentID(App.Current, FileID, FileName, FileExtension),
                     SRoofing_URLManager.URL_Document.Document_Get_DocumentDataByDocumentID(App.Current, FileID, FileName, FileExtension),
                   null,

                   FileID,
                   FileID,
                       null,
null,
                   null,

                   null,

                   null,

                   null,

                   false);


                //                                                      SRoofingUserMediaModel _iUserMediaModel = new SRoofingUserMediaModel (


                //                   FileID ,
                //                   null ,

                //                  SRoofingEnum_File_Code.FileCode_Document ,
                //                   SRoofingEnum_File_Type.ShareType_Document ,
                //                   SRoofingEnum_File_Thum.FileThum_Document_Word ,
                //                      SRoofingEnum_File_Extension.FileExtension_Document_DOC ,
                //                     FileSize ,
                //                 FileDuration ,

                //                   FileID ,
                //                   FileID ,
                //                     SRoofing_URLManager.URL_Document.Document_Get_DocumentDataByDocumentID ( App.Current , FileID , FileName , FileExtension ) ,
                //                     SRoofing_URLManager.URL_Document.Document_Get_DocumentDataByDocumentID ( App.Current , FileID , FileName , FileExtension ) ,
                //                   null ,

                //                   FileID ,
                //                   FileID ,
                //                       null ,
                //null ,
                //                   null ,

                //                   null ,

                //                   null ,

                //                   null ,

                //                   true );



                #endregion




                #region Post


                await Post_ScreenChatShow_Document_Message
                     .Post_ScreenChatShowDocument_MessageWS(

                             context,

                             iApplicationUtitlityModel,

                             iOwnerModel,

                             iSettingModel,

                              iLanguageModel,

                              iAccountType,

                             iRemoteModel,

                             iGroupModel,

                              MessageTokenID,
                             UploadDateTimeMilliSec,

                             GroupID,

                             iOwnerModel.OwnerUserTokenID,
                             iOwnerModel.OwnerMobileNumberTokenID,

                             "0",
                            iUserType,
                             MessageType,
                             iLanguageModel.lblText_ScreenChatShow_ShareDocument_Message,
                                  iLanguageModel.lblText_ScreenChatShow_ShareDocument_Message,

                             iTranslationModel,

                              iOwner_LanguageCode_IN,

                              iOwner_LanguageCode_OUT,



                            "media",
                                      "Document",

                                 //   null ,

                                 _iUserMediaModel,

             FileID,

             FileName,

             FileExtension,


             null,
                        SRoofing_URLManager.URL_Document.Document_Get_DocumentDataByDocumentID(App.Current, FileID, FileName, FileExtension),
                        SRoofing_URLManager.URL_Document.Document_Get_DocumentDataByDocumentID(App.Current, FileID, FileName, FileExtension),

             "0",

                                 SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save,

                                               _iTimeModel.DateTimeTextWS,
                  _iTimeModel.DateTimeWS,
                 _iTimeModel.DateTextWS,
                  _iTimeModel.DateDayWS,
                  _iTimeModel.DateMonthWS,
                _iTimeModel.DateYearWS,


                                 1);


                #endregion




            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());

                return;
            }


        }






        public static
      async Task ScreenChatShow_ParseChatShareVideoMessage(

            Application context,

            SRoofingUserSettingModelManager iSettingModel,

            SRoofingApplicationUtilityModelManager iApplicationUtilityModel,

            string iAccountType,


            SRoofingUserOwnerModelManager iOwnerModel,

            SRoofingUserRemoteModelManager iRemoteModel,

                     SRoofingUserGroupModelManager iGroupModel,


           string iUserType,


                    SRoofingLanguageTranslateModel iLanguageModel,


                      string iOwner_LanguageCode_IN,
                      string iOwner_LanguageCode_OUT,



   string MessageTokenID,
            string UploadDateTimeMilliSec,

            string ScreenChatShowID,

            string ScreenChatShowTicketID,

            string GroupID,

            string InviteOwnerUserID,

            string InviteOwnerMobileNumberID,

            string FromUserID,

            string FromMobileNumberID,

            string MessageType,

            string MessageText,



                string MessageCode_Original,
        string MessageText_Original,
        string MessageCode_Translated,
        string MessageText_Translated,




                string FileID,


                string FileName,

                string FileSize,

                string FileExtension,


                string FileDuration,



            string FileCode,

            string FileType,

            string FileURL,
            string FileThumURL,

            string FileIsAllowToSave,

            string FileState,

            string UploadDay,

            string UploadMonth,

            string UploadYear,

            string UploadTime,

            string UploadDateTime)
        {


            try
            {

                // ShareVideoMessage
                SRoofingTimeModel _iTimeModel = await Get_TimeModel(UploadDateTimeMilliSec);



                #region TranslationModel


                SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel
                {
                    MessageCode_Original = iOwner_LanguageCode_IN,
                    MessageText_Original = MessageText,

                    MessageCode_Translated = iOwner_LanguageCode_IN,
                    MessageText_Translated = MessageText

                };



                #endregion




                #region Media_Model

                //   FileInfo fi = new FileInfo ( fileResult.FullPath );
                //FileInfo fi = new FileInfo ( FileFullPath );


                SRoofingUserMediaModel _iUserMediaModel = new SRoofingUserMediaModel(


                   FileID,
                   null,

                  SRoofingEnum_File_Code.FileCode_Video,
                   SRoofingEnum_File_Type.ShareType_Video,
                   SRoofingEnum_File_Thum.FileThum_Video,
                      FileName,
                  SRoofingEnum_File_Extension.FileExtension_Video_MP4,
                     FileSize,
                 FileDuration,

                   FileID,
                   FileID,
                     SRoofing_URLManager.URL_Video.Video_Get_VideoDataByVideoID(App.Current, FileID),
                         SRoofing_URLManager.URL_Video.Video_Get_VideoDataByVideoID(App.Current, FileID),
                   null,

                   FileID,
                   FileID,
                          SRoofing_URLManager.URL_Video.Video_Get_VideoThumByVideoID(App.Current, FileID),
              SRoofing_URLManager.URL_Video.Video_Get_VideoDataByVideoID(App.Current, FileID),
                   null,

                   null,

                   null,

                   null,

                   true);



                #endregion




                #region Post


                await Post_ScreenChatShow_Video_Message
                     .Post_ScreenChatShowVideo_MessageWS(

                             context,

                             iApplicationUtilityModel,

                             iOwnerModel,

                             iSettingModel,


                              iLanguageModel,


                             iAccountType,

                             iRemoteModel,

                             iGroupModel,

                              MessageTokenID,
                             UploadDateTimeMilliSec,

                             GroupID,

                             iOwnerModel.OwnerUserTokenID,
                             iOwnerModel.OwnerMobileNumberTokenID,

                             "0",
                            iUserType,
                             MessageType,
                                  iLanguageModel.lblText_ScreenChatShow_ShareVideo_Message,
                                  iLanguageModel.lblText_ScreenChatShow_ShareVideo_Message,

                             iTranslationModel,

                              iOwner_LanguageCode_IN,
          iOwner_LanguageCode_OUT,



                            "media",
                                      "video",

                                 null,

                                 _iUserMediaModel,

             FileID,

            null,
                 SRoofing_URLManager.URL_Video.Video_Get_VideoThumByVideoID(App.Current, FileID),
                              SRoofing_URLManager.URL_Video.Video_Get_VideoThumByVideoID(App.Current, FileID),

             "0",

                                 SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save,

                                                _iTimeModel.DateTimeTextWS,
                 _iTimeModel.DateTimeWS,
                  _iTimeModel.DateTextWS,
                  _iTimeModel.DateDayWS,
                  _iTimeModel.DateMonthWS,
                   _iTimeModel.DateYearWS,


                                 1);


                #endregion




            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }


        public static
     void ScreenChatShow_ParseChatShareVideoYouTubeMessage(

             Application context,

             SRoofingUserSettingModelManager iSettingModel,

             string iAccountType,


             SRoofingUserOwnerModelManager iOwnerModel,

             SRoofingUserRemoteModelManager iRemoteModel,

             string MessageTokenID,
             string UploadDateTimeMilliSec,

             string ScreenChatShowID,

             string ScreenChatShowTicketID,

             string GroupID,

             string InviteOwnerUserID,

             string InviteOwnerMobileNumberID,

             string FromUserID,

             string FromMobileNumberID,

             string MessageType,

             string MessageText,

             string FileID,

             string FileCode,

             string FileType,

             string FileURL,
             string FileThumURL,

             string FileIsAllowToSave,

             string FileState,

             string UploadDay,

             string UploadMonth,

             string UploadYear,

             string UploadTime,

             string UploadDateTime)
        {

            try
            {

                // ShareVideoMessage
                //if (FileState==("upload")) {

                //////MessageType = "textsharevideoyoutube";

                //////ScreenChatShow_DatabaseUpdateChatShareVideoYouTubeMessage (

                //////        context ,

                //////        iSettingModel ,

                //////        iAccountType ,


                //////        iOwnerModel ,

                //////        iRemoteModel ,

                //////        MessageTokenID ,
                //////        UploadDateTimeMilliSec ,

                //////        ScreenChatShowID ,
                //////        ScreenChatShowTicketID ,
                //////        GroupID ,
                //////        InviteOwnerUserID ,
                //////        InviteOwnerMobileNumberID ,
                //////        FromUserID ,
                //////        FromMobileNumberID ,
                //////        MessageType ,
                //////        MessageText ,
                //////        FileID ,
                //////        FileCode ,
                //////        FileType ,
                //////        FileURL ,
                //////        FileThumURL ,
                //////        FileIsAllowToSave ,
                //////        FileState ,
                //////        UploadDay ,
                //////        UploadMonth ,
                //////        UploadYear ,
                //////        UploadTime ,
                //////        UploadDateTime );


            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }










        public static
      async Task ScreenChatShow_ParseChatSharePhotoMessage(

            Application context,

            SRoofingUserSettingModelManager iSettingModel,

            SRoofingApplicationUtilityModelManager iApplicationUtilityModel,


            string iAccountType,


            SRoofingUserOwnerModelManager iOwnerModel,

            SRoofingUserRemoteModelManager iRemoteModel,

                      SRoofingUserGroupModelManager iGroupModel,


           string iUserType,

                    SRoofingLanguageTranslateModel iLanguageModel,

                      string iOwner_LanguageCode_IN,
                      string iOwner_LanguageCode_OUT,



  string MessageTokenID,
            string UploadDateTimeMilliSec,

            string ScreenChatShowID,

            string ScreenChatShowTicketID,

            string GroupID,

            string InviteOwnerUserID,

            string InviteOwnerMobileNumberID,

            string FromUserID,

            string FromMobileNumberID,

            string MessageType,

            string MessageText,



                string MessageCode_Original,
        string MessageText_Original,
        string MessageCode_Translated,
        string MessageText_Translated,




                string FileID,


                string FileName,

                string FileSize,

                string FileExtension,

                string FileDuration,

                string FileThum,



            string FileCode,

            string FileType,

            string FileURL,
            string FileThumURL,

            string FileIsAllowToSave,

            string FileState,

            string UploadDay,

            string UploadMonth,

            string UploadYear,

            string UploadTime,

            string UploadDateTime)
        {

            try
            {

                // TextMessage
                SRoofingTimeModel _iTimeModel = await Get_TimeModel(UploadDateTimeMilliSec);



                #region TranslationModel


                SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel
                {
                    MessageCode_Original = iOwner_LanguageCode_IN,
                    MessageText_Original = MessageText,

                    MessageCode_Translated = iOwner_LanguageCode_IN,
                    MessageText_Translated = MessageText

                };


                #endregion




                #region Media_Model

                //   FileInfo fi = new FileInfo ( fileResult.FullPath );
                //FileInfo fi = new FileInfo ( FileFullPath );


                SRoofingUserMediaModel _iUserMediaModel = new SRoofingUserMediaModel(


                FileID,
                null,

               SRoofingEnum_File_Code.FileCode_Image,
                SRoofingEnum_File_Type.ShareType_Image,
              SRoofingEnum_File_Thum.FileThum_Image,
               FileName,
                    SRoofingEnum_File_Extension.FileExtension_Image_JPG,
           FileSize,
                FileDuration,

                FileID,
                FileID,
          SRoofing_URLManager.URL_Image.Image_Get_ImageByImageID(App.Current, FileID),
                  SRoofing_URLManager.URL_Image.Image_Get_ImageByImageID(App.Current, FileID),
               null,

                FileID,
                FileID,
                SRoofing_URLManager.URL_Image.Image_Get_ImageByImageID(App.Current, FileID),
                 SRoofing_URLManager.URL_Image.Image_Get_ImageByImageID(App.Current, FileID),
        null,

                null,

                null,

                null,

                true);


                #endregion




                #region Post


                await Post_ScreenChatShow_Image_Message
                     .Post_ScreenChatShowImage_MessageWS(

                             context,

                             iApplicationUtilityModel,

                             iOwnerModel,

                             iSettingModel,


                              iLanguageModel,



                             iAccountType,

                             iRemoteModel,

                             iGroupModel,

                              MessageTokenID,
                             UploadDateTimeMilliSec,

                             GroupID,

                             iOwnerModel.OwnerUserTokenID,
                             iOwnerModel.OwnerMobileNumberTokenID,

                             "0",
                            iUserType,
                             MessageType,
                             iLanguageModel.lblText_ScreenChatShow_ShareImage_Message,
                                  iLanguageModel.lblText_ScreenChatShow_ShareImage_Message,

                             iTranslationModel,

                            iOwner_LanguageCode_IN,
                            iOwner_LanguageCode_OUT,



                            "media",
                                      "image",

                                 //   null ,

                                 _iUserMediaModel,

             FileID,

            null,
                SRoofing_URLManager.URL_Image.Image_Get_ImageByImageID(App.Current, FileID),
                SRoofing_URLManager.URL_Image.Image_Get_ImageByImageID(App.Current, FileID),

             "0",

                                 SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save,

                                                _iTimeModel.DateTimeTextWS,
                 _iTimeModel.DateTimeWS,
                  _iTimeModel.DateTextWS,
                  _iTimeModel.DateDayWS,
                  _iTimeModel.DateMonthWS,
                   _iTimeModel.DateYearWS,


                                 1);


                #endregion





            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }






        public static
      async Task ScreenChatShow_ParseChatShareLocationMessage(

  Application context,

            SRoofingUserSettingModelManager iSettingModel,

            SRoofingApplicationUtilityModelManager iApplicationUtilityModel,


            string iAccountType,


            SRoofingUserOwnerModelManager iOwnerModel,

            SRoofingUserRemoteModelManager iRemoteModel,

                      SRoofingUserGroupModelManager iGroupModel,


           string iUserType,

                    SRoofingLanguageTranslateModel iLanguageModel,

                      string iOwner_LanguageCode_IN,
                      string iOwner_LanguageCode_OUT,



  string MessageTokenID,
            string UploadDateTimeMilliSec,

            string ScreenChatShowID,

            string ScreenChatShowTicketID,

            string GroupID,

            string InviteOwnerUserID,

            string InviteOwnerMobileNumberID,

            string FromUserID,

            string FromMobileNumberID,

            string MessageType,

            string MessageText,



                string MessageCode_Original,
        string MessageText_Original,
        string MessageCode_Translated,
        string MessageText_Translated,



                          string LocationLongitude,

                string LocationLatitude,

                string CountryCode,
                string CountryName,
                string StateName,
                string CityName,
                string AddressLine,
                string StaticMapURL,

            string UploadDay,

            string UploadMonth,

            string UploadYear,

            string UploadTime,

            string UploadDateTime)
        {

            try
            {

                // TextMessage
                SRoofingTimeModel _iTimeModel = await Get_TimeModel(UploadDateTimeMilliSec);



                #region TranslationModel


                SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel
                {
                    MessageCode_Original = iOwner_LanguageCode_IN,
                    MessageText_Original = MessageText,

                    MessageCode_Translated = iOwner_LanguageCode_IN,
                    MessageText_Translated = MessageText

                };


                #endregion




                #region Media_Model

                //   FileInfo fi = new FileInfo ( fileResult.FullPath );
                //FileInfo fi = new FileInfo ( FileFullPath );



                SRoofingUserMediaModel _iUserMediaModel = new SRoofingUserMediaModel();



                #endregion



                #region LocationModel

                SRoofingLocationModel _iLocationMode = new SRoofingLocationModel();

                try
                {

                    _iLocationMode.LocationLatitude = LocationLatitude;
                    _iLocationMode.LocationLongitude = LocationLongitude;
                    _iLocationMode.CountryName = CountryName;
                    _iLocationMode.CountryCode = CountryCode;
                    _iLocationMode.CityName = CityName;
                    _iLocationMode.LocationTitle = AddressLine;


                }
                catch (Exception exx)
                {
                    SRoofing_DebugManager.Debug_ShowSystemMessage(exx.Message.ToString());
                    return;
                }

                //SubLocality =SubLocality ,
                //Thoroughfare = Thoroughfare ,
                //SubThoroughfare = SubThoroughfare ,
                //AdminArea = AdminArea ,
                //SubAdminArea = SubAdminArea ,
                //PostalCode =PostalCode ,


                #endregion



                #region Post


                await Post_ScreenChatShow_Location_Message
                     .Post_ScreenChatShowLocation_MessageWS(

                             context,

                             iApplicationUtilityModel,

                             iOwnerModel,

                             iSettingModel,


                              iLanguageModel,



                             iAccountType,

                             iRemoteModel,

                             iGroupModel,

                              MessageTokenID,
                             UploadDateTimeMilliSec,

                             GroupID,

                             iOwnerModel.OwnerUserTokenID,
                             iOwnerModel.OwnerMobileNumberTokenID,

                             "0",
                            iUserType,
                             MessageType,
                             iLanguageModel.lblText_ScreenChatShow_ShareLocation_Message,
                                  iLanguageModel.lblText_ScreenChatShow_ShareLocation_Message,

                             iTranslationModel,

                            iOwner_LanguageCode_IN,
                            iOwner_LanguageCode_OUT,



                       "text",
                            "map",

                                 //   null ,

                                 _iUserMediaModel,
                                 _iLocationMode,

             "0",

            null,
            "0",
       "0",

             "0",

                                 SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save,

                                                _iTimeModel.DateTimeTextWS,
                 _iTimeModel.DateTimeWS,
                  _iTimeModel.DateTextWS,
                  _iTimeModel.DateDayWS,
                  _iTimeModel.DateMonthWS,
                   _iTimeModel.DateYearWS,


                                 1);


                #endregion





            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }







        public static
    void ScreenChatShow_DatabaseSaveChatTextTranslate_PendingMessage(

            Application context,

            SRoofingUserSettingModelManager iSettingModel,

            string iAccountType,

            SRoofingUserOwnerModelManager iOwnerModel,

            SRoofingUserRemoteModelManager iRemoteModel,

            string MessageTokenID,
            string UploadDateTimeMilliSec,

            string ScreenChatShowID,

            string ScreenChatShowTicketID,

            string GroupID,

            string GroupType,

            string InviteOwnerUserID,

            string InviteOwnerMobileNumberID,

            string FromUserID,

            string FromMobileNumberID,

            string MessageCode,

            string MessageText,

            string UploadDay,

            string UploadMonth,

            string UploadYear,

            string UploadTime,

            string UploadDateTime,
            string shownMessageText)
        {

            try
            {

                //////Post_ScreenChatShow_Text_Translate_Pending_Message
                //////        .Post_ScreenChatShowTextTranslate_PendingMessageWS (

                //////                context ,

                //////                iOwnerModel ,

                //////                iSettingModel ,

                //////                iAccountType ,

                //////                iRemoteModel ,

                //////                MessageTokenID ,
                //////                UploadDateTimeMilliSec ,

                //////                GroupID ,

                //////                FromUserID ,
                //////                FromMobileNumberID ,

                //////                "0" ,
                //////                "remote" ,
                //////                MessageCode ,
                //////                MessageText ,
                //////                shownMessageText ,
                //////                "text" ,
                //////                "text" ,
                //////                TlknEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save ,
                //////                1 );

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }


        public static
    void ScreenChatShow_DatabaseSaveChatTextMessage(

            Application context,

            SRoofingUserSettingModelManager iSettingModel,

            string iAccountType,

            SRoofingUserOwnerModelManager iOwnerModel,


            SRoofingUserRemoteModelManager iRemoteModel,

            string MessageTokenID,
            string UploadDateTimeMilliSec,

            string ScreenChatShowID,

            string ScreenChatShowTicketID,

            string GroupID,

            string GroupType,

            string InviteOwnerUserID,

            string InviteOwnerMobileNumberID,

            string FromUserID,

            string FromMobileNumberID,

            string MessageCode,

            string MessageText,

            string UploadDay,

            string UploadMonth,

            string UploadYear,

            string UploadTime,

            string UploadDateTime)
        {

            try
            {

                //////Post_ScreenChatShow_Text_Message
                //////        .Post_ScreenChatShowTextMessageWS (

                //////                context ,

                //////                iSettingModel ,

                //////                iAccountType ,


                //////                iOwnerModel ,

                //////                iRemoteModel ,

                //////                MessageTokenID ,
                //////                UploadDateTimeMilliSec ,

                //////                GroupID ,

                //////                FromUserID ,
                //////                FromMobileNumberID ,

                //////                "0" ,
                //////                "remote" ,
                //////                MessageCode ,
                //////                MessageText ,
                //////                "text" ,
                //////                "text" ,
                //////                TlknEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save ,
                //////                1 );

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }



        async public static Task<SRoofingTimeModel> Get_TimeModel(string UploadDateTimeMilliSec)
        {

            try
            {


                SRoofingTimeModel _iTimeModel = new SRoofingTimeModel();
                _iTimeModel = SRoofing_TimeManager.Time_Get_TimeModel(UploadDateTimeMilliSec);

                return await Task.FromResult(_iTimeModel);
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }
        }







        #region WebSocket


        //using var client = new ClientWebSocket();
        static ClientWebSocket client;//= new ClientWebSocket();


        public static
async Task Initialize_Socket(

               Application context,

                SRoofingUserOwnerModelManager iOwnerModel,
                SRoofingUserRemoteModelManager iRemoteModel,
            string GroupTokenID,

            string CallTokenID)
        {
            try
            {

                _=  Task.Run(async () =>
                {
                    // Create a WebSocket client
                    Uri uri = new("ws://" + App.SiteDomainURL_Socket + ":5050?"
                        + "caltknid=" +  CallTokenID
                        + "&grpid=" + GroupTokenID
                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid="  + iOwnerModel.OwnerMobileNumberTokenID
                        + "&msg="  +  SRoofingEnum_Socket_Call.SRoofingSocket_Call_Busy
                        );


                    //Uri uri = new("ws://10.0.2.2:5050?"
                    //  + "caltknid=" +  CallTokenID
                    //  + "&grpid=" + GroupTokenID
                    //  + "&uid=" + iOwnerModel.OwnerUserTokenID
                    //  + "&mobid="  + iOwnerModel.OwnerMobileNumberTokenID
                    //  );



                    client = new ClientWebSocket();


                    // Connect to the server
                    //await client.ConnectAsync(new CancellationToken());
                    await client.ConnectAsync(uri, CancellationToken.None);

                    var receiveTask = Task.Run(async () =>
                    {

                        var buffer = new byte[1024 * 4];
                        while (true)
                        {

                            var result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

                            if (result.MessageType == WebSocketMessageType.Close)
                            {
                                break;
                            }

                            var msg = Encoding.UTF8.GetString(buffer, 0, result.Count);
                            SRoofing_DebugManager.Debug_ShowSystemMessage("WebSocket-WS ::: " +  msg);
                        }

                    }

                    );


                    await receiveTask;


                    ////////////await Task.Delay(3000);


                    ////////// // Send messages to the server
                    ////////// //var message = "Hello from .NET MAUI";
                    ////////// var message = CallTokenID + "-" + GroupTokenID + "-" +  iOwnerModel.OwnerUserTokenID + "-" +  iOwnerModel.OwnerMobileNumberTokenID + "-" +
                    //////////SRoofingEnum_Socket_Call.SRoofingSocket_Call_Busy;

                    ////////// var bytesX = Encoding.UTF8.GetBytes(message);
                    ////////// await client.SendAsync(new ArraySegment<byte>(bytesX), WebSocketMessageType.Text, true, CancellationToken.None);

                    ////////// await Task.Delay(3000);
                    ////////// // Close the connection
                    ////////// await client.CloseAsync(WebSocketCloseStatus.NormalClosure, "Bye", CancellationToken.None);



                }).ConfigureAwait(false);



                _=  Task.Run(async () =>
                {

                    await SRoofing_ScreenCallShowMessageManager
                      .ScreenCallShowMessage_New_Event_Message_ByScreenCallShowID(

                App.Current,
                App.iAccountType,
                iOwnerModel,
       iRemoteModel,
          SRoofing_TimeManager.Time_GenerateToken(),
       CallTokenID,
 GroupTokenID,
         GroupTokenID,
    iRemoteModel.OwnerUserTokenID,
         iRemoteModel.OwnerMobileNumberTokenID,
          "0",
          "0",
           SRoofingEnum_Call_Code.CallCode_Voice,
          SRoofingEnum_Call_Type.CallType_Voice,
          SRoofingEnum_Call_Direction.CallDirection_In,
          SRoofingEnum_Call_State.CallState_BUSY,
          "0",
          "0",
          "1");

                })
                    .ConfigureAwait(false);







            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }





        #endregion








    }
}
