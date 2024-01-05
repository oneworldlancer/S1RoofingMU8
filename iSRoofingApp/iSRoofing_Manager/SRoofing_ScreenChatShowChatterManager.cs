using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager;



using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_ScreenChatShowChatterManager
    {


        // UserProfile_Get_Owner_Profile_ByAccountTypeWS
        public static async Task<ObservableCollection<SRoofingUserRemoteModelManager>> SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWS(
           Application context,
                SRoofingUserOwnerModelManager iOwnerModel,
                   string GroupTokenIDWS,
         string iCharacterWS,
               string IRowIndexWS)
        {

            try
            {

                ObservableCollection<SRoofingUserRemoteModelManager> arr_ItemList = new ObservableCollection<SRoofingUserRemoteModelManager>();


                arr_ItemList = await SRoofing_ScreenChatShowChatterListWS
            .SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWSAsync(

                                         iOwnerModel,
                                         App.iPlatformOS,
                           App.iDatabaseServerTokenID,
           Preferences.Get("DeviceGlobalID", "0"),//DeviceGlobalIDWS
           App.iAccountType,
                    GroupTokenIDWS,
                    "0", "0",
                      iOwnerModel.OwnerUserTokenID,
                           iOwnerModel.OwnerMobileNumberTokenID,
                           iCharacterWS,
                           IRowIndexWS);

                //SRoofingUserRemoteModelManager iInfoTutorial = new SRoofingUserRemoteModelManager ( )
                //{

                //    //NameLine = strCharacter.ToUpper ( ) ,
                //    iViewCodeType = SRoofingEnum_Generic_RowView_AdapterType.RowView_InfoTutorial

                //};

                //arr_ItemList.Insert ( 0 , iInfoTutorial );




                if (arr_ItemList != null)
                {
                    await SRoofingSync_ScreenChatShowChatterManager
                                             .Sync_History_ScreenChatShow_Set_ChatterList_ByGroupTokenID(
                                          App.Current,
                                          App.iAccountType,
                                           iOwnerModel,
                                           GroupTokenIDWS,
                                          arr_ItemList);




                    //////////     _=    Task.Run ( async ( ) =>
                    //////////{

                    //////////  //  await App.Database.Initialize_DataAsync_HistoryChat_MessageModel ( arr_ItemList );

                    //////////} ).ConfigureAwait ( false );








                }

                return arr_ItemList;


            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }
        }






        public static async Task<ObservableCollection<SRoofingUserRemoteModelManager>> SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWS_X1(
               Application context,
                    SRoofingUserOwnerModelManager iOwnerModel,
                       string GroupTokenIDWS)
        {

            try
            {

                ////////////     ObservableCollection<SRoofingUserRemoteModelManager> arr_ItemList = new ObservableCollection<SRoofingUserRemoteModelManager>();


                ////////////     arr_ItemList = await App.svcSRoofing_ScreenChatShowChatterListWS
                //////////// .SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWSAsync(

                ////////////                                         App.iPlatformOS,
                ////////////                App.iDatabaseServerTokenID,
                ////////////Preferences.Get("DeviceGlobalID", "0"),//DeviceGlobalIDWS
                ////////////App.iAccountType,
                ////////////         GroupTokenIDWS,
                ////////////         "0", "0",
                ////////////           iOwnerModel.OwnerUserTokenID,
                ////////////                iOwnerModel.OwnerMobileNumberTokenID);

                ////////////     SRoofingUserRemoteModelManager iInfoTutorial = new SRoofingUserRemoteModelManager()
                ////////////     {

                ////////////         //NameLine = strCharacter.ToUpper ( ) ,
                ////////////         iViewCodeType = SRoofingEnum_Generic_RowView_AdapterType.RowView_InfoTutorial

                ////////////     };

                ////////////     arr_ItemList.Insert(0, iInfoTutorial);




                ////////////     if (arr_ItemList != null)
                ////////////     {
                ////////////         await SRoofingSync_ScreenChatShowChatterManager
                ////////////                                  .Sync_History_ScreenChatShow_Set_ChatterList_ByGroupTokenID(
                ////////////                               App.Current,
                ////////////                               App.iAccountType,
                ////////////                                iOwnerModel,
                ////////////                                GroupTokenIDWS,
                ////////////                               arr_ItemList);




                ////////////         _=    Task.Run(async () =>
                ////////////    {

                ////////////        await App.Database.Initialize_DataAsync_HistoryChat_MessageModel(arr_ItemList);

                ////////////    }).ConfigureAwait(false);








                ////////////     }

                ////////////     return arr_ItemList;

                return null;
            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }
        }
















    }
}
