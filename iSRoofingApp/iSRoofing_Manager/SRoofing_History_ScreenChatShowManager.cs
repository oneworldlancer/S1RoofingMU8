using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;


using Microsoft.Maui.Controls;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_HTTPManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebServiceWS;
using System.Net.Http.Json;
using System.Net;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_History_ScreenChatShowManager
    {

        public static ISRoofing_ScreenChatShowMessageWS _iWebServiceWS;

        //public SRoofing_History_ScreenChatShowManager(ISRoofing_ScreenChatShowMessageWS iWebServiceWS)
        //{
        //    _iWebServiceWS = iWebServiceWS;
        //}
        //public SRoofing_History_ScreenChatShowManager()
        //{
        //    _iWebServiceWS =App.Current.MainPage.Handler.MauiContext.Services.GetService<ISRoofing_ScreenChatShowMessageWS>();
        //    //    ser.Write("message"); ;//iWebServiceWS;
        //}

        // UserProfile_Get_Owner_Profile_ByAccountTypeWS
        public static async Task<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>> SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWS (
           Application context ,
                SRoofingUserOwnerModelManager iOwnerModel ,
                    SRoofingLanguageTranslateModel iLanguageModel )
        {

            try
            {

                // _iWebServiceWS=App.Current.MainPage.Handler.MauiContext.Services.GetService<ISRoofing_ScreenChatShowMessageWS>();


                //ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_ItemListWS = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();
                ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_ItemList = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> ( );


                arr_ItemList = await SRoofing_ScreenChatShowMessageWS
                    .SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWSAsync (
                                                           iOwnerModel ,

                                                           App.iPlatformOS ,
                                    App.iDatabaseServerTokenID ,
                    Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
                    App.iAccountType ,

                               iOwnerModel.OwnerUserTokenID ,
                                    iOwnerModel.OwnerMobileNumberTokenID ,
                                                             "0" , "0" ,
                                        DateTime.Now.Day.ToString ( ) ,
                                               DateTime.Now.Month.ToString ( ) ,
                                       DateTime.Now.Year.ToString ( ) ,
                                "1" );

                if ( arr_ItemList != null )
                {
                    //await SRoofingSync_History_ScreenChatShowManager
                    //                         .Sync_History_ScreenChatShow_Set_ChatList (
                    //                      App.Current ,
                    //                      App.iAccountType ,
                    //                       iOwnerModel ,
                    //                      arr_ItemList );


                    await App.Database.Initialize_DataAsync_HistoryChat_MessageModel (
                                   iOwnerModel , iLanguageModel ,
                         arr_ItemList );



                    //_ = Task.Run(async () =>
                    //  {

                    //      await App.Database.Initialize_DataAsync_HistoryChat_MessageModel(
                    //               iOwnerModel, iLanguageModel,
                    //     arr_ItemList);

                    //  })
                    //    .ConfigureAwait(false);



                }

                return arr_ItemList;


            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }

    }
}
