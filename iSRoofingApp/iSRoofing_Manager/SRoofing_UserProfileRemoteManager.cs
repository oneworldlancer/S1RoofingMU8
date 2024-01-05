using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;


using Microsoft.Maui.Controls;
using S1RoofingMU.iSRoofingApp.iSRoofing_HTTPManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebServiceWS;
using System.Net.Http.Json;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_UserProfileRemoteManager
    {


        // SRoofing_User_Get_Remote_Model_ByRemoteUserTokenID
        public static async Task<SRoofingUserRemoteModelManager> SRoofing_User_Get_Remote_Model_ByRemoteUserTokenID(
           Application context,
                   SRoofingUserOwnerModelManager iOwnerModel,
               string RemoteUserTokenID,
                string RemoteMobileNumberTokenID)
        {


            try
            {

                ObservableCollection<SRoofingUserRemoteModelManager> arr_ItemList = new ObservableCollection<SRoofingUserRemoteModelManager>();


                //////////////////            arr_ItemList = await App.svcSRoofing_UserProfileWS
                ////////////////// .SRoofing_XFMobile_UserProfile_Get_Owner_Profile_ByAccountTypeWSAsync(

                //////////////////                                         App.iPlatformOS,
                //////////////////                App.iDatabaseServerTokenID,
                //////////////////Preferences.Get("DeviceGlobalID", "0"),//DeviceGlobalIDWS
                //////////////////App.iAccountType,
                //////////////////OwnerUserTokenID,
                //////////////////OwnerMobileNumberTokenID);

                ////////


                using (var _iClient = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance())
                {

                    string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_SRoofingUserProfileWS.Profile_Get_Remote;

                    string _iWebParamWS =
             "PlatformOSIDWS=" + App.iPlatformOS +"&" +
             "DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
             "DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
             "AccountTypeWS=" + App.iAccountType +"&" +
             "UserIDWS=" + iOwnerModel.OwnerUserTokenID +"&" +
             "MobileNumberIDWS=" +  iOwnerModel.OwnerMobileNumberTokenID +"&" +
             "RemoteUserIDWS=" +  RemoteUserTokenID +"&" +
             "RemoteMobileNumberIDWS=" +   RemoteMobileNumberTokenID;

                    Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

                    _iClient.BaseAddress=  uri;

                    HttpResponseMessage response = await _iClient.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {

                        arr_ItemList= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingUserRemoteModelManager>>();

                    }

                }



                if (arr_ItemList != null)
                {

                    await SRoofingSync_User_RemoteManager.Sync_User_Remote_Set_UserModel(
                                        context,
                                iOwnerModel,
                                arr_ItemList[0]);

                    return arr_ItemList[0];


                }

                return null;

            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }




            //        try
            //        {

            //            ObservableCollection<SRoofingUserRemoteModelManager> arr_ItemList = new ObservableCollection<SRoofingUserRemoteModelManager>();


            //            arr_ItemList = await App.svcSRoofing_UserProfileWS
            // .SRoofing_XFMobile_UserProfile_Get_Remote_Profile_ByAccountTypeWSAsync(

            //                                         App.iPlatformOS,
            //                App.iDatabaseServerTokenID,
            //Preferences.Get("DeviceGlobalID", "0"),//DeviceGlobalIDWS
            //App.iAccountType,
            //iOwnerModel.OwnerUserTokenID,
            //iOwnerModel.OwnerMobileNumberTokenID,
            //              RemoteUserTokenID,
            //              RemoteMobileNumberTokenID);


            //            if (arr_ItemList != null)
            //            {
            //                SRoofingSync_User_RemoteManager.Sync_User_Remote_Set_UserModel(
            //                            context,
            //                            iOwnerModel,
            //                            arr_ItemList[0]);
            //            }



            //            return arr_ItemList[0];


            //        }
            //        catch (Exception ex)
            //        {

            //            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            //            return null;
            //        }


        }







        public static async Task SRoofing_UserProfile_Open_Remote_Profile_ByRemoteUserTokenID(
Application context,
  INavigation Navigation,
       SRoofingUserOwnerModelManager iOwnerModel,
       SRoofingUserRemoteModelManager iRemoteModel,
   string RemoteUserTokenID,
    string RemoteMobileNumberTokenID)
        {
            try
            {


                if (iRemoteModel == null)
                {
                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {
                        iRemoteModel =
                    await SRoofing_UserProfileRemoteManager.SRoofing_User_Get_Remote_Model_ByRemoteUserTokenID(
                              App.Current,
                              iOwnerModel,
                              RemoteUserTokenID,
                             RemoteMobileNumberTokenID);
                    }


                }


                await SRoofingSync_User_RemoteManager
                    .Sync_User_Remote_Set_Current_Profile_UserModel(

                 context,
                iOwnerModel,
           iRemoteModel);


                MainThread.BeginInvokeOnMainThread(async () =>
         {
             // Code to run on the main thread



             //////////await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener (
             //////////         Navigation ,
             //////////    new Page_Profile_Remote_Dashboard ( ) ,
             //////////    false ,
             //////////    true );



         });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }






    }
}
