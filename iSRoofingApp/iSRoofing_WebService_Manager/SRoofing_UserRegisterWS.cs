using S1RoofingMU.iSRoofingApp.iSRoofing_HTTPManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebServiceWS;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager
{
    public class SRoofing_UserRegisterWS
    {
        ////////ISRoofing_UserRegisterWS _iWebServiceWS;

        ////////public SRoofing_UserRegisterWS(ISRoofing_UserRegisterWS iWebServiceWS)
        ////////{
        ////////    _iWebServiceWS = iWebServiceWS;
        ////////}

        #region Get_List
        //<ObservableCollection<SRoofingLogisticsStaffModelManager>> 
        public static async Task<bool> SRoofing_XFMobile_UserRegister_New_UserAccountWSAsync(
                        string PlatformOSIDWS,
            string DatabaseServerTokenIDWS,
            string DeviceGlobalIDWS,
            string AccountTypeWS,
                          //string MembershipTypeWS,
                          string GCMIDWS,
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
                          string EmailAddressWS,
                          string ListUserMobileNumberE164WS,
                          string LocationLatitudeWS,
                         string LocationLongitudeWS,
                         string UploadDateTimeMilliSecWS)
        {


            try
            {

                //  ObservableCollection<SRoofingUserGroupModelManager> arr_ItemListWS = new ObservableCollection<SRoofingUserGroupModelManager>();
                string arr_ItemListWS = string.Empty;//= new ObservableCollection<SRoofingUserGroupModelManager>();

                using (var _iClient = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance())
                {


                    string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_SRoofingUserRegisterWS.Register_New_ByAccounTypeWS;


                    string _iWebParamWS =
             "PlatformOSIDWS=" + App.iPlatformOS +"&" +
             "DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
             "DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
             "AccountTypeWS=" + App.iAccountType +"&" +

                     //"OwnerUserTokenIDWS=" + iOwnerModel.OwnerUserTokenID +"&" +
                     // "OwnerMobileNumberTokenIDWS=" + iOwnerModel.OwnerMobileNumberTokenID +"&" +






                     "GCMIDWS="     +  GCMIDWS  +"&" +
                        "CountryISOCodeWS="      +   CountryISOCodeWS +"&" +
                        "CountryNameWS="      +  CountryNameWS  +"&" +
                        "CountryCodeWS="       +  CountryCodeWS  +"&" +
                        "CityNameWS="      +  CityNameWS  +"&" +
                       "CountryMobileCodeWS="        +  CountryMobileCodeWS  +"&" +
                         "MobileNumberE164WS="      +   MobileNumberE164WS +"&" +
                         "MobileCodeWS="      +  MobileCodeWS  +"&" +
                         "FirstNameWS="       +  FirstNameWS  +"&" +
                         "LastNameWS="       +  LastNameWS  +"&" +
                        "BirthDayWS="        +  BirthDayWS  +"&" +
                         "BirthMonthWS="       +   BirthMonthWS +"&" +
                         "BirthYearWS="       +  BirthYearWS  +"&" +
                         "GenderWS="       +  GenderWS  +"&" +
                         "PasswordWS="       +  PasswordWS  +"&" +
                        "EmailAddressWS="        +  EmailAddressWS  +"&" +
                          "ListUserMobileNumberE164WS="      +  ListUserMobileNumberE164WS  +"&" +
                          "LocationLatitudeWS="      + LocationLatitudeWS   +"&" +
                         "LocationLongitudeWS="       +  LocationLongitudeWS  +"&" +
                         "UploadDateTimeMilliSecWS="  +  UploadDateTimeMilliSecWS;

                    //       string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_SRoofingUserRegisterWS.Register_New_ByAccounTypeWS;

                    //       string _iWebParamWS =
                    //"PlatformOSIDWS=" + App.iPlatformOS +"&" +
                    //"DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
                    //"DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
                    //"AccountTypeWS=" + App.iAccountType +"&" +
                    //"OwnerUserTokenIDWS=" + iOwnerModel.OwnerUserTokenID +"&" +
                    //"OwnerMobileNumberTokenIDWS=" + iOwnerModel.OwnerMobileNumberTokenID +"&" +


                    //    "GroupTokenIDWS=" + GroupTokenIDWS +"&" +
                    //    //"ApplicationRoleCodeWS=" + "0" +"&" +
                    //    //"ProjectTokenIDWS=" + "0" +"&" +
                    //    //"iTodayDayWS=" + DateTime.Now.Day.ToString() +"&" +
                    //    //"iTodayMonthWS=" +    DateTime.Now.Month.ToString() +"&" +
                    //    //"iTodayYearWS=" + DateTime.Now.Year.ToString() +"&" +

                    //    "iCharacterWS=" + iCharacterWS +"&" +
                    //    "IRowIndexWS=" + IRowIndexWS;

                    Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

                    _iClient.BaseAddress=  uri;

                    HttpResponseMessage response = await _iClient.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {

                        //SRoofing_DebugManager.Debug_ShowSystemMessage("IsSuccessStatusCode == "+ response.Content.ToString());
                        // arr_ItemListWS= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingUserGroupModelManager>>();
                        //arr_ItemListWS= await response.Content.ReadFromJsonAsync<string>();
                        //arr_ItemListWS= await response.Content.ReadFromJsonAsync<string>();

                        arr_ItemListWS=response.Content.ToString();
                    }


                }

                if (arr_ItemListWS != null)
                {
                    return true;
                }

                //  return new ObservableCollection<SRoofingUserGroupModelManager>();

                return false;



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;

            }


            //////////////////////////try
            //////////////////////////{


            ////////////////////////// ////////////////////   using (var _iClient = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance())
            ////////////////////////// ////////////////////   {

            ////////////////////////// ////////////////////       string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_SRoofingUserRegisterWS.Register_New_ByAccounTypeWS;

            ////////////////////////// ////////////////////       string _iWebParamWS =
            ////////////////////////// ////////////////////"PlatformOSIDWS=" + App.iPlatformOS +"&" +
            ////////////////////////// ////////////////////"DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
            ////////////////////////// ////////////////////"DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
            ////////////////////////// ////////////////////"AccountTypeWS=" + App.iAccountType +"&" +

            ////////////////////////// ////////////////////        //"OwnerUserTokenIDWS=" + iOwnerModel.OwnerUserTokenID +"&" +
            ////////////////////////// ////////////////////        // "OwnerMobileNumberTokenIDWS=" + iOwnerModel.OwnerMobileNumberTokenID +"&" +






            ////////////////////////// ////////////////////        "GCMIDWS="     +  GCMIDWS  +"&" +
            ////////////////////////// ////////////////////           "CountryISOCodeWS="      +   CountryISOCodeWS +"&" +
            ////////////////////////// ////////////////////           "CountryNameWS="      +  CountryNameWS  +"&" +
            ////////////////////////// ////////////////////           "CountryCodeWS="       +  CountryCodeWS  +"&" +
            ////////////////////////// ////////////////////           "CityNameWS="      +  CityNameWS  +"&" +
            ////////////////////////// ////////////////////          "CountryMobileCodeWS="        +  CountryMobileCodeWS  +"&" +
            ////////////////////////// ////////////////////            "MobileNumberE164WS="      +   MobileNumberE164WS +"&" +
            ////////////////////////// ////////////////////            "MobileCodeWS="      +  MobileCodeWS  +"&" +
            ////////////////////////// ////////////////////            "FirstNameWS="       +  FirstNameWS  +"&" +
            ////////////////////////// ////////////////////            "LastNameWS="       +  LastNameWS  +"&" +
            ////////////////////////// ////////////////////           "BirthDayWS="        +  BirthDayWS  +"&" +
            ////////////////////////// ////////////////////            "BirthMonthWS="       +   BirthMonthWS +"&" +
            ////////////////////////// ////////////////////            "BirthYearWS="       +  BirthYearWS  +"&" +
            ////////////////////////// ////////////////////            "GenderWS="       +  GenderWS  +"&" +
            ////////////////////////// ////////////////////            "PasswordWS="       +  PasswordWS  +"&" +
            ////////////////////////// ////////////////////           "EmailAddressWS="        +  EmailAddressWS  +"&" +
            ////////////////////////// ////////////////////             "ListUserMobileNumberE164WS="      +  ListUserMobileNumberE164WS  +"&" +
            ////////////////////////// ////////////////////             "LocationLatitudeWS="      + LocationLatitudeWS   +"&" +
            ////////////////////////// ////////////////////            "LocationLongitudeWS="       +  LocationLongitudeWS  +"&" +
            ////////////////////////// ////////////////////            "UploadDateTimeMilliSecWS="  +  UploadDateTimeMilliSecWS;

















            ////////////////////////// ////////////////////       //"ApplicationRoleCodeWS=" + "0" +"&" +
            ////////////////////////// ////////////////////       //"ProjectTokenIDWS=" + "0" +"&" +
            ////////////////////////// ////////////////////       //"iTodayDayWS=" + DateTime.Now.Day.ToString() +"&" +
            ////////////////////////// ////////////////////       //"iTodayMonthWS=" +    DateTime.Now.Month.ToString() +"&" +
            ////////////////////////// ////////////////////       //"iTodayYearWS=" + DateTime.Now.Year.ToString() +"&" +
            ////////////////////////// ////////////////////       //"IsHistoryMessageLineWS=" + "1" +"&" +
            ////////////////////////// ////////////////////       //"IRowIndexWS=0";

            ////////////////////////// ////////////////////       Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

            ////////////////////////// ////////////////////       _iClient.BaseAddress=  uri;

            ////////////////////////// ////////////////////       HttpResponseMessage response = await _iClient.PostAsync(uri.ToString(), null);

            ////////////////////////// ////////////////////       if (response.IsSuccessStatusCode)
            ////////////////////////// ////////////////////       {

            ////////////////////////// ////////////////////           //SRoofing_DebugManager.Debug_ShowSystemMessage("IsSuccessStatusCode == "+ response.Content.ToString());
            ////////////////////////// ////////////////////           // arr_ItemListWS= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>>();
            ////////////////////////// ////////////////////           var xResult = await response.Content.ReadFromJsonAsync<string>();

            ////////////////////////// ////////////////////       }


            ////////////////////////// ////////////////////   }


            //////////////////////////    //   SRoofing_DebugManager.Debug_ShowSystemMessage("***************SRoofing_UserRegisterWSSoapClient***************"+ xxx2[0].FullName.ToString());

            //////////////////////////    return "true";
            //////////////////////////}
            //////////////////////////catch (Exception ex)
            //////////////////////////{
            //////////////////////////    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            //////////////////////////    return null;

            //////////////////////////}





            //////////       return _iWebServiceWS.SRoofing_XFMobile_UserRegister_New_UserAccountWSAsync(

            //////////PlatformOSIDWS,
            //////////DatabaseServerTokenIDWS,
            //////////DeviceGlobalIDWS,
            //////////AccountTypeWS,
            ////////////MembershipTypeWS,
            //////////	     GCMIDWS,
            //////////	     CountryISOCodeWS,
            //////////	     CountryNameWS,
            //////////	     CountryCodeWS,
            //////////	     CityNameWS,
            //////////	     CountryMobileCodeWS,
            //////////	     MobileNumberE164WS,
            //////////	     MobileCodeWS,
            //////////	     FirstNameWS,
            //////////	     LastNameWS,
            //////////	     BirthDayWS,
            //////////	     BirthMonthWS,
            //////////	     BirthYearWS,
            //////////	     GenderWS,
            //////////	     PasswordWS,
            //////////	     EmailAddressWS,
            //////////	     ListUserMobileNumberE164WS,
            //////////	     LocationLatitudeWS,
            //////////	     LocationLongitudeWS,
            //////////	     UploadDateTimeMilliSecWS);
            //return null;//.iRefreshDataAsync();
        }


        #endregion


    }
}
