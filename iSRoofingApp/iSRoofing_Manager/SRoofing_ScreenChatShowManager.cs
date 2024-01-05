using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_ScreenChatShowManager
    {



        public static async Task<SRoofingScreenChatShowScreenModel> Chat_Initialize_Chat_Show(

               Application iContext,
             SRoofingUserOwnerModelManager iOwnerModel,
          SRoofingUserRemoteModelManager iRemoteModel,
         SRoofingUserGroupModelManager iGroupModel)
        {

            try
            {

                //await Task.Delay(500);



                string _iRemoteUserTokenID = "0", _iRemoteMobileNumberTokenID = "0";

                if (iRemoteModel != null)
                {
                    _iRemoteUserTokenID = iRemoteModel.OwnerUserTokenID;
                    _iRemoteMobileNumberTokenID = iRemoteModel.OwnerMobileNumberTokenID;
                }




                int _iRemoteAvatarIsBlur = 0;

                //if (iRemoteAvatarIsBlur == true)
                //{
                //    _iRemoteAvatarIsBlur = 1;
                //}
                //else
                //{
                //    _iRemoteAvatarIsBlur = 0;
                //}

                //            CallScreenType,
                SRoofingScreenChatShowScreenModel iSRoofingScreenChatModel = new SRoofingScreenChatShowScreenModel(
               App.Current,
                                App.iAccountType,
                   SRoofingEnum_ScreenShow_InviteTag.InviteTag_Chat,

                      iGroupModel.GroupTokenID,
                                 iGroupModel.GroupType,
                                 iGroupModel.NameLine,
                                 iGroupModel.NameLine,

                                           "0",
                                "0",
                                "0",
                                "0",


                                _iRemoteUserTokenID,
                                _iRemoteMobileNumberTokenID,

                        iRemoteModel,
                        iGroupModel,

                        "0",
                        _iRemoteAvatarIsBlur);


              await  SRoofingSync_ScreenChatShowManager.Sync_ScreenChatShow_Set_ChatModel(
                        App.Current,
                                App.iAccountType,
                        iOwnerModel,
                        iSRoofingScreenChatModel);


       //////         await SRoofingSync_ScreenChatShowManager.Sync_ScreenChatShow_New_ChatSessionListModel (

       //////App.Current ,
       //////                         App.iAccountType ,
       //////                 iOwnerModel ,
       //////                 iSRoofingScreenChatModel );

              
                
                
                
                
                
                
                
                
                //  return iSRoofingScreenChatModel;




                //SRoofing_DebugManager.Debug_ShowSystemMessage("_blnSyncHistory_ScreenChatShow_List == " +
                //     App._blnSyncHistory_ScreenChatShow_List);

                App._blnSyncHistory_ScreenChatShow_List = true;
                App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = true;
                App.bln_ScreenChatShow_OnAppearing_New_MessageList=true;



                //SRoofing_DebugManager.Debug_ShowSystemMessage("_blnSyncHistory_ScreenChatShow_List == " +
                //     App._blnSyncHistory_ScreenChatShow_List);

                return await Task.FromResult ( iSRoofingScreenChatModel );

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }







    }
}
