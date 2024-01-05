
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;


using Microsoft.Maui.Controls;
using System.Net.Http.Json;
using S1RoofingMU.iSRoofingApp.iSRoofing_HTTPManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebServiceWS;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_UserProfileOwnerManager
    {


        // UserProfile_Get_Owner_Profile_ByAccountTypeWS
        public static async Task<SRoofingUserOwnerModelManager> UserProfile_Get_Owner_Profile_ByAccountTypeWS(
           Application context,
                string OwnerUserTokenID,
                string OwnerMobileNumberTokenID)
        {

            try
            {

                ObservableCollection<SRoofingUserOwnerModelManager> arr_ItemList = new ObservableCollection<SRoofingUserOwnerModelManager>();


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

                    string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_SRoofingUserProfileWS.Profile_Get_Owner;

                    string _iWebParamWS =
             "PlatformOSIDWS=" + App.iPlatformOS +"&" +
             "DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
             "DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
             "AccountTypeWS=" + App.iAccountType +"&" +
             "UserIDWS=" + OwnerUserTokenID +"&" +
             "MobileNumberIDWS=" + OwnerMobileNumberTokenID;

                    Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

                    _iClient.BaseAddress=  uri;

                    HttpResponseMessage response = await _iClient.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {

                        arr_ItemList= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingUserOwnerModelManager>>();

                    }

                    //   lbl_Result.Text += " , " + arrProfileList.Count().ToString();


                    //for (int i = 0; i < arrProfileList.Count(); i++)
                    //{

                    //    //WeatherForecast? weatherForecast =
                    //    //    JsonSerializer.Deserialize<WeatherForecast>(Items[i].ToString(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    //    ////////Console.WriteLine($"Date: {weatherForecast?.Date}");
                    //    lbl_Result.Text += " , " + arrProfileList[i].FullName;
                    //}






                    //for (int i = 0; i<10; i++)
                    //{
                    //    var result = Client.GetAsync("http://aspnetmonsters.com").Result;
                    //    Console.WriteLine(result.StatusCode);
                    //}
                }



                if (arr_ItemList != null)
                {

                    await SRoofingSync_User_OwnerManager.Sync_User_Owner_Set_UserModel(
                                    context, arr_ItemList[0]);






                    /* Speech */
                    await SRoofingSync_Speech_Manager.Sync_Speech_Set_Incoming_ByUserID(
                               App.Current,
                               arr_ItemList[0], new iSRoofing_Model.Speech.SRoofingSpeechModel
                               {
                                   LanguageName = "English",
                                   LanguageValue = "en",
                                   LanguageCode = "en"
                               });


                    await SRoofingSync_Speech_Manager.Sync_Speech_Set_Outgoing_ByUserID(
                     App.Current,
                     arr_ItemList[0], new iSRoofing_Model.Speech.SRoofingSpeechModel
                     {
                         LanguageName = "English",
                         LanguageValue = "en",
                         LanguageCode = "en"
                     });



                    /* Settings */
                    await SRoofingSync_UserSetting_Manager.Sync_Setting_Set_Setting_ByUserID(
                                          App.Current, arr_ItemList[0],
                                          new iSRoofing_Model.Setting.SRoofingUserSettingModelManager());


                    /* Call_AutoMessage */
                    SRoofingLanguageTranslateModel _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);

                    await SRoofingSync_AutoMessage_Manager.Sync_AutoMessage_Call_Set_AutoReplyMessage_ByUserID(
                        App.Current, arr_ItemList[0],
                        _iLanguageModel.lblText_Call_AutoMessage_SorryImBusyCanYouCallLater);


                    /* Sound */
                    //////SRoofingKeyValueModelManager _iSoundModel= new SRoofingKeyValueModelManager();// = await SRoofingSync_Sound_Manager.Sync_Sound_Get_Chat_Outgoing_ByUserID ( App.Current , arr_ItemList[ 0 ] );

                    //////if ( _iSoundModel == await SRoofingSync_Sound_Manager.Sync_Sound_Get_Chat_Outgoing_ByUserID ( App.Current , arr_ItemList[ 0 ] ) )
                    //////{
                    //////    await SRoofing_SoundManager.Initilalize_Sound_List_ByUserModel ( arr_ItemList[ 0 ] );
                    //////}
                    await SRoofing_SoundManager.Initilalize_Sound_List_ByUserModel(arr_ItemList[0]);


                return arr_ItemList[0];


                }
             
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
