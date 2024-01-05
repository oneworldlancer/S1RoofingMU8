using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;

using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    class SRoofing_ScreenCallShowManager
    {



        public static async Task Call_Initialize_Call_Show_Offer(

               Application iContext,
             SRoofingUserOwnerModelManager iOwnerModedl,
          SRoofingUserRemoteModelManager iRemoteModel,
         SRoofingUserGroupModelManager iGroupModel = null)
        {

            try
            {


                //await Task.Delay(500);


                int _iRemoteAvatarIsBlur = 0;

                //if (iRemoteAvatarIsBlur == true)
                //{
                //    _iRemoteAvatarIsBlur = 1;
                //}
                //else
                //{
                //    _iRemoteAvatarIsBlur = 0;
                //}

                SRoofingScreenCallShowScreenModel iSRoofingScreenCallModel = new SRoofingScreenCallShowScreenModel(
                                App.iAccountType,
                                   SRoofing_TimeManager.Time_GenerateToken(),
                                    SRoofingEnum_ScreenShow_InviteTag.InviteTag_Chat,
                                    "call",
                                    iRemoteModel.GroupTokenID,
                                    "private",
                                    iRemoteModel.FullName,
                                    "0",
                                    "0",
                                    "0",
                                    "0",

                                       "0",
                                    "0",
                                    "0",


                                   iRemoteModel.OwnerUserTokenID,
                                   iRemoteModel.OwnerMobileNumberTokenID,

                                   "call",
                                    "call",
                                    SRoofingEnum_Call_Direction.CallDirection_Out,
                               SRoofingEnum_Call_Tag.CallTag_Offer,


                                    "pending",
                                    "pending",
                                    "0",
                                   0,
                                    false,
                                false,
                                iRemoteModel,
                                 "0",
                                                                       _iRemoteAvatarIsBlur);


                SRoofingSync_ScreenCallShowManager.Sync_ScreenCallShow_Set_CallModel(
                        App.Current,
                        iSRoofingScreenCallModel);





                App._blnSyncHistory_ScreenCallShow_List = true;
                App._blnSyncHistory_ScreenCallShow_CALL_Landing_List = true;




            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }




        public static async Task Call_Initialize_Call_Show_Answer(

               Application iContext,
             SRoofingUserOwnerModelManager iOwnerModedl,
          SRoofingUserRemoteModelManager iRemoteModel,
         string iCallTokenID)
        {

            try
            {


                //await Task.Delay(500);


                int _iRemoteAvatarIsBlur = 0;

                //if (iRemoteAvatarIsBlur == true)
                //{
                //    _iRemoteAvatarIsBlur = 1;
                //}
                //else
                //{
                //    _iRemoteAvatarIsBlur = 0;
                //}

                SRoofingScreenCallShowScreenModel iSRoofingScreenCallModel = new SRoofingScreenCallShowScreenModel(
                                App.iAccountType,
                                   iCallTokenID,
                                    SRoofingEnum_ScreenShow_InviteTag.InviteTag_Chat,
                                    "call",
                                    iRemoteModel.GroupTokenID,
                                    "private",
                                    iRemoteModel.FullName,
                                    "0",
                                    "0",
                                    "0",
                                    "0",

                                       "0",
                                    "0",
                                    "0",


                                   iRemoteModel.OwnerUserTokenID,
                                   iRemoteModel.OwnerMobileNumberTokenID,

                                   "call",
                                    "call",
                                    SRoofingEnum_Call_Direction.CallDirection_In,
                               SRoofingEnum_Call_Tag.CallTag_Answer,


                                    "pending",
                                    "pending",
                                    "0",
                                   0,
                                    false,
                                false,
                                iRemoteModel,
                                 "0",
                                                                       _iRemoteAvatarIsBlur);


                SRoofingSync_ScreenCallShowManager.Sync_ScreenCallShow_Set_CallModel(
                        App.Current,
                        iSRoofingScreenCallModel);





                App._blnSyncHistory_ScreenCallShow_List = true;
                App._blnSyncHistory_ScreenCallShow_CALL_Landing_List = true;




            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }



    }
}
