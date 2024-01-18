using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;


using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;


using Microsoft.Maui.Controls;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_UserRegisterManager
    {


        // UserProfile_Get_Owner_Profile_ByAccountTypeWS
        public static async Task SRoofing_XFMobile_UserRegister_New_UserAccountWS(
           Application context,

                         string CountryISOCodeWS,
                          string CountryNameWS,
                          string CountryCodeWS,
                          string CityNameWS,
                          string CountryMobileCodeWS,
                          string MobileNumberE164WS,
                         string MobileCodeWS,
                          string FirstNameWS,
                         string LastNameWS,
                         string BirthDayWS,
                        string BirthMonthWS,
                          string BirthYearWS,
                          string GenderWS,
                          string PasswordWS,
                          string EmailAddressWS)
        {

            try
            {


                // SRoofing_DebugManager.Debug_ShowSystemMessage("SRoofing_XFMobile_UserRegister_New_UserAccountWS");
                //  ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager> arr_ItemList = new ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>();


                await SRoofing_UserRegisterWS
              .SRoofing_XFMobile_UserRegister_New_UserAccountWSAsync(


                                                     App.iPlatformOS,
                             App.iDatabaseServerTokenID,
             Preferences.Get("DeviceGlobalID", "0"),//DeviceGlobalIDWS
             App.iAccountType,
                                      Preferences.Get("GCMID", "0"),
                              CountryISOCodeWS,
                              CountryNameWS,
                              CountryCodeWS,
                              CityNameWS,
                              CountryMobileCodeWS,
                             MobileNumberE164WS,
                             MobileCodeWS,
                              FirstNameWS,
                             LastNameWS,
                             BirthDayWS,
                            BirthMonthWS,
                              BirthYearWS,
                              GenderWS,
                              PasswordWS,
                              EmailAddressWS,
                              "0",
                              "0",
                             "0",
                             SRoofing_TimeManager.Time_GenerateToken());




                ////////   await App.svcSRoofing_UserRegisterWS
                //////// .SRoofing_XFMobile_UserRegister_New_UserAccountWSAsync (


                ////////                                        App.iPlatformOS ,
                ////////                App.iDatabaseServerTokenID ,
                ////////Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
                ////////App.iAccountType ,
                ////////                         Preferences.Get ( "GCMID" , "0" ) ,
                ////////                 CountryISOCodeWS ,
                ////////                 CountryNameWS ,
                ////////                 CountryCodeWS ,
                ////////                 CityNameWS ,
                ////////                 CountryMobileCodeWS ,
                ////////                MobileNumberE164WS ,
                ////////                MobileCodeWS ,
                ////////                 FirstNameWS ,
                ////////                LastNameWS ,
                ////////                BirthDayWS ,
                ////////               BirthMonthWS ,
                ////////                 BirthYearWS ,
                ////////                 GenderWS ,
                ////////                 PasswordWS ,
                ////////                 EmailAddressWS ,
                ////////                 "0" ,
                ////////                 "0" ,
                ////////                "0" ,
                ////////                SRoofing_TimeManager.Time_GenerateToken ( ) );






            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

    }
}
