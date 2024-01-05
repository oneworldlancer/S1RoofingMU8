using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_GCMHandler;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_GCMManager
{
    public class SRoofing_GCMMessageManager
    {




        #region Parse_Intent


        public static async Task IntentService_ParseIntentExtras(dynamic _iJsonModel)
        {

            try
            {

                _ = Task.Run(async () =>
                {

                    //await Task.Delay ( 30000 );

                    try
                    {

                        string _ActionTag = "0";
                        string _ActionRequest = "0";

                        SRoofingUserOwnerModelManager _iOwnerModel;

                        SRoofingUserSettingModelManager _iSettingModel;

                        //, _ScreenChatShowID = "0", _ScreenChatShowTicketID = "0",

                        //_IsScreenOnline = "0", _RemoteUserName = "0", _ScreenChatShowTicketTempID = "0", _ScreenChatShowTicketLineID = "0",
                        //        _InviteOwnerUserID = "0", _InviteOwnerMobileNumberID = "0",
                        //        _FromUserID = "0", _ToUserID = "0", _FromMobileNumberID = "0", _ToMobileNumberID = "0", _InviteToListUserID = "0",
                        //        _InviteFromMobileNumberID = "0", _InviteToMobileNumberID = "0",
                        //        _InviteFromUserID = "0", _InviteToUserID = "0",
                        //        _InviteCode = "0", _InviteType = "0", _InviteID = "0", _InviteTicketID = "0",
                        //        _MessageCode = "0", _MessageType = "0", _MessageText = "0",
                        //        _SuggestContactListUserID = "0", _SuggestContactListMobileNumberID = "0",
                        //        _LocationLongitude = "0", _LocationLatitude = "0", _LocationCityName = "0",
                        //        _FileID = "0", _FileCode = "0", _FileType = "0", _FileIsViewOnly = "0", _FileState = "0";

                        //                string _CountryCode = "0";
                        //                string _CountryName = "0";
                        //                string _StateName = "0";
                        //                string _CityName = "0";
                        //                string _AddressLine = "0";
                        //                string _StaticMapURL = "0";

                        //                string _ShareFileURL, _ShareFileThumURL = "0";

                        //                string _ScreenIsOnline = "0";


                        //                string _GroupID, _GroupType, _GroupTitle,
                        //                        _RemoteUserID, _RemoteMobileNumberID = "0";

                        //                string _InviteTag = "0";

                        //                string _IsDating = "0";

                        //                string _UploadDateTimeMilliSec, _MessageTokenID = "0";

                        //                SRoofingUserSettingModelManager iSRoofingUserSettingModelManager;

                        //                bool _blnShowNotification = false;

                        //                SRoofingUserRemoteModelManager _iRemoteModel;
                        //                SRoofingUserGroupModelManager _iGroupModel;




                        //                string _Notification_SoundURI;
                        //                string _shownMessageText, _shownMessageText_Notification;

                        //TlknUserNotificationHistoryModel _iHistoryModel;



                        string _iAccountType = App.iAccountType;


                        _iOwnerModel = await
                        SRoofingSync_User_OwnerManager.Sync_User_Owner_Get_UserModel(
                     Application.Current);


                        _iSettingModel = await SRoofingSync_UserSetting_Manager
                            .Sync_Setting_Get_Setting_ByUserID(
                                Application.Current,
                               _iOwnerModel);


                        _ActionTag = _iJsonModel.tag.ToString();
                        _ActionRequest = _iJsonModel.act.ToString();

                        _ = Task.Run(async () =>
                             {

                                 //////////await Task.Delay ( 10000);
                                 if (_ActionTag == SRoofingEnum_GCM_Action_TagManager.GCMActionTag_CallMessage)
                                 {
                                     await SRoofing_GCMHandler_ScreenCallShowMessage
                                     .IntentService_ParseIntentExtras(
                                       _iAccountType,
                                       _iSettingModel,
                                       _iOwnerModel,
                                        _iJsonModel);

                                 }
                                 else
                                 {
                                     if (_ActionRequest == SRoofingEnum_GCM_Action_RequestManager.ScreenChatShow_Owner_ScreenChatShowMessage
                                     || _ActionRequest == SRoofingEnum_GCM_Action_RequestManager.ScreenChatShow_Remote_ScreenChatShowMessage)
                                     {
                                         await SRoofing_GCMHandler_ScreenChatShowMessage
                                         .IntentService_ParseIntentExtras(
                                           _iAccountType,
                                           _iSettingModel,
                                           _iOwnerModel,
                                            _iJsonModel);

                                     }
                                 }

                             }).ConfigureAwait(false);

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














    }
}
