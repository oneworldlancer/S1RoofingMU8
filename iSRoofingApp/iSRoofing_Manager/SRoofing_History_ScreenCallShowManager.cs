using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;

 
using Microsoft.Maui.Controls;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_History_ScreenCallShowManager
    {


        // UserProfile_Get_Owner_Profile_ByAccountTypeWS
        public static async Task<ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>> SRoofing_ScreenCallShow_Get_List_All_Call_ByOwnerUserTokenIDWS (
           Application context ,
                SRoofingUserOwnerModelManager iOwnerModel,
                    SRoofingLanguageTranslateModel iLanguageModel   )
        {

            try
            {

                ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager> arr_ItemList = new ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager> ( );


                arr_ItemList=await SRoofing_ScreenCallShowMessageWS
                         .SRoofing_ScreenCallShow_Get_List_All_Call_ByOwnerUserTokenIDWSAsync(
                                                                iOwnerModel,

                                                                App.iPlatformOS,
                                         App.iDatabaseServerTokenID,
                         Preferences.Get("DeviceGlobalID", "0"),//DeviceGlobalIDWS
                         App.iAccountType,

                                    iOwnerModel.OwnerUserTokenID,
                                         iOwnerModel.OwnerMobileNumberTokenID,
                                                                  "0", "0",
                                             DateTime.Now.Day.ToString(),
                                                    DateTime.Now.Month.ToString(),
                                            DateTime.Now.Year.ToString(),
                                     "1");

                ////     arr_ItemList = await App.svcSRoofing_ScreenCallShowMessageWS
                //// .SRoofing_ScreenCallShow_Get_List_All_Call_ByOwnerUserTokenIDWSAsync (

                ////                                         App.iPlatformOS ,
                ////                App.iDatabaseServerTokenID ,
                ////Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
                ////App.iAccountType ,

                ////           iOwnerModel.OwnerUserTokenID ,
                ////                iOwnerModel.OwnerMobileNumberTokenID ,
                ////                                         "0" , "0" ,
                ////                    DateTime.Now.Day.ToString ( ) ,
                ////                           DateTime.Now.Month.ToString ( ) ,
                ////                   DateTime.Now.Year.ToString ( ) ,
                ////            "1" );










                //SRoofingScreenCallShowHistoryMessageModelManager iInfoTutorial = new SRoofingScreenCallShowHistoryMessageModelManager ( )
                //{

                //    //NameLine = strCharacter.ToUpper ( ) ,
                //    iViewCodeType = SRoofingEnum_Generic_RowView_AdapterType.RowView_InfoTutorial

                //};

                //arr_ItemList.Insert ( 0 , iInfoTutorial );




                if ( arr_ItemList != null )
                {
                    //await SRoofingSync_History_ScreenCallShowManager
                    //                         .Sync_History_ScreenCallShow_Set_CallList(
                    //                      App.Current,
                    //                      App.iAccountType,
                    //                       iOwnerModel,
                    //                      arr_ItemList);


                              await App.Database.Initialize_DataAsync_HistoryCall_MessageModel (
                                         iOwnerModel , iLanguageModel,
                                         arr_ItemList );

                

                    //_ = Task.Run ( async ( ) =>
                    //      {

                    //          await App.Database.Initialize_DataAsync_HistoryCall_MessageModel (
                    //                     iOwnerModel , iLanguageModel,
                    //                     arr_ItemList );

                    //      } ).ConfigureAwait ( false );






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
