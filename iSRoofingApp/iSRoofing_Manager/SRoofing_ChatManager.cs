using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_ChatManager
    {




        public static
        void Chat_StartChatTicket_ToUserID (
                Application context ,
                string iAccountType ,
                string InviteDirection ,
                string InviteTag ,
                string paramstring4 ,
                string paramstring5 ,
                SRoofingUserOwnerModelManager iOwnerModel ,
                SRoofingUserRemoteModelManager iRemoteModel ,

                SRoofingUserGroupModelManager iGroupModel ,
                string iGroupTokenID ,

                string iGroupType ,
                string iGroupTitle ,
                string iNameLine ,

                string iMatchType ,
                bool iRemoteAvatarIsBlur ,

                Boolean IsChatThumReset )
        {

            try
            {

                string _iRemoteUserTokenID = "0", _iRemoteMobileNumberTokenID = "0";

                if ( iRemoteModel != null )
                {
                    _iRemoteUserTokenID = iRemoteModel.OwnerUserTokenID;
                    _iRemoteMobileNumberTokenID = iRemoteModel.OwnerMobileNumberTokenID;
                }


                ScreenChatShowLogin_SetScreenChatShowSetLoginValuesByGroupID (
                                context ,
                                iAccountType ,
                                InviteTag ,

                                iGroupTokenID ,

                                iGroupType ,
                                iGroupTitle ,
                                iNameLine ,

                                "0" ,
                                "0" ,
                                "0" ,
                                "0" ,

                                _iRemoteUserTokenID ,
                                _iRemoteMobileNumberTokenID ,

                                iOwnerModel ,
                                iRemoteModel ,
                                iGroupModel ,
                                iMatchType ,
                                iRemoteAvatarIsBlur );


                //////////SRoofing_ScreenChatShowHistoryManager
                //////////        .Logistics_ScreenChatShowHistory_New_ByGroupTokenID(
                //////////                context,
                //////////                iAccountType,
                //////////                iOwnerModel,
                //////////                iGroupModel);

                //////////SRoofing_ScreenChatShow_ThumManager
                //////////        .ScreenChatShowThum_Add_ChatThum_ByUserID(
                //////////                context,
                //////////                iAccountType,
                //////////                iOwnerModel,
                //////////                iGroupModel,
                //////////                IsChatThumReset);



            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }







        public static
        async Task<SRoofingScreenChatShowScreenModel> ScreenChatShowLogin_SetScreenChatShowSetLoginValuesByGroupID (

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

                SRoofingUserOwnerModelManager iOwnerModel ,
                SRoofingUserRemoteModelManager iRemoteModel ,

                SRoofingUserGroupModelManager iGroupModel ,
                string iMatchType ,
                bool iRemoteAvatarIsBlur )
        {
            //        string CallScreenType,

            try
            {

                int _iRemoteAvatarIsBlur = 1;

                if ( iRemoteAvatarIsBlur == true )
                {
                    _iRemoteAvatarIsBlur = 1;
                }
                else
                {
                    _iRemoteAvatarIsBlur = 0;
                }

                //            CallScreenType,
                SRoofingScreenChatShowScreenModel iSRoofingScreenChatModel = new SRoofingScreenChatShowScreenModel (
                        context ,
                        AccountType ,
                        InviteTag ,

                        GroupID ,
                        GroupType ,
                        GroupTitle ,
                        NameLine ,
                        ScreenChatShowID ,
                        ScreenChatShowTicketID ,

                        InviteOwnerUserID ,
                        InviteOwnerMobileNumberID ,

                        RemoteUserID ,
                        RemoteMobileNumberID ,

                        iRemoteModel ,
                        iGroupModel ,

                        iMatchType ,
                        _iRemoteAvatarIsBlur );


                await SRoofingSync_ScreenChatShowManager.Sync_ScreenChatShow_Set_ChatModel (
                           context ,
                           AccountType ,
                           iOwnerModel ,
                           iSRoofingScreenChatModel );


                return await Task.FromResult ( iSRoofingScreenChatModel );



            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }



    }
}
