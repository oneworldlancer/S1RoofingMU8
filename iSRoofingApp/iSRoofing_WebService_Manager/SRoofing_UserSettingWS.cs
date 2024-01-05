using S1RoofingMU.iSRoofingApp.iSRoofing_HTTPManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
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
	public class SRoofing_UserSettingWS
	{
		ISRoofing_UserSettingWS _iWebServiceWS;

		public SRoofing_UserSettingWS(ISRoofing_UserSettingWS iWebServiceWS)
		{
			_iWebServiceWS = iWebServiceWS;
		}

		#region Get_List


		public Task SRoofing_XFMobile_UserSetting_Initialize_Setting_ByOwnerUserTokenIDWSAsync (
						string PlatformOSIDWS,
			string DatabaseServerTokenIDWS,
			string DeviceGlobalIDWS,
			string AccountTypeWS  ,
   string UserIDWS ,
                          string MobileNumberIDWS )
        {
			return _iWebServiceWS.SRoofing_XFMobile_UserSetting_Initialize_Setting_ByOwnerUserTokenIDWSAsync(

			  PlatformOSIDWS,
			  DatabaseServerTokenIDWS,
			  DeviceGlobalIDWS,
              AccountTypeWS ,
     UserIDWS ,
                            MobileNumberIDWS );
 
		}



        public static async Task<ObservableCollection<SRoofingUserSettingModelManager>> SRoofing_XFMobile_UserSetting_Get_Setting_ByOwnerUserTokenIDWSAsync (
						string PlatformOSIDWS,
			string DatabaseServerTokenIDWS,
			string DeviceGlobalIDWS,
			string AccountTypeWS  ,
   string UserIDWS ,
                          string MobileNumberIDWS )
        {



            try
            {


                ObservableCollection<SRoofingUserSettingModelManager> arr_ItemListWS = new ObservableCollection<SRoofingUserSettingModelManager>();



                using (var _iClient = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance())
                {

                    string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_SRoofingUserSettingWS.Setting_Get_List_ByOwnerUserTokenIDWS;

                    string _iWebParamWS =
             "PlatformOSIDWS=" + App.iPlatformOS +"&" +
             "DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
             "DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
             "AccountTypeWS=" + App.iAccountType +"&" +
             "OwnerUserTokenIDWS=" + "xxx" +"&" +
             "OwnerMobileNumberTokenIDWS=" + "xxx";


                 //"GroupTokenIDWS=" + GroupTokenIDWS +"&" +
                 //"ApplicationRoleCodeWS=" + "0" +"&" +
                 //"ProjectTokenIDWS=" + "0" +"&" +
                 //"iTodayDayWS=" + DateTime.Now.Day.ToString() +"&" +
                 //"iTodayMonthWS=" +    DateTime.Now.Month.ToString() +"&" +
                 //"iTodayYearWS=" + DateTime.Now.Year.ToString() +"&" +

                 //"iCharacterWS=" + iCharacterWS +"&" +
                 //"IRowIndexWS=" + IRowIndexWS;

                    Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

                    _iClient.BaseAddress=  uri;

                    HttpResponseMessage response = await _iClient.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {

                        //SRoofing_DebugManager.Debug_ShowSystemMessage("IsSuccessStatusCode == "+ response.Content.ToString());
                        arr_ItemListWS= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingUserSettingModelManager>>();

                    }


                }

 

                if (arr_ItemListWS != null)
                {
                    return arr_ItemListWS;
                }

                //  return new ObservableCollection<SRoofingUserGroupModelManager>();

                return null;



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;

            }













            //return _iWebServiceWS.SRoofing_XFMobile_UserSetting_Get_Setting_ByOwnerUserTokenIDWSAsync (

            //  PlatformOSIDWS,
            //  DatabaseServerTokenIDWS,
            //  DeviceGlobalIDWS,
            //           AccountTypeWS ,
            //  UserIDWS ,
            //                         MobileNumberIDWS );

        }



        public Task SRoofing_XFMobile_UserSetting_Reset_Setting_ByOwnerUserTokenIDWSAsync (
						string PlatformOSIDWS,
			string DatabaseServerTokenIDWS,
			string DeviceGlobalIDWS,
			string AccountTypeWS  ,
   string UserIDWS ,
                          string MobileNumberIDWS )
        {
			return _iWebServiceWS.SRoofing_XFMobile_UserSetting_Reset_Setting_ByOwnerUserTokenIDWSAsync (

			  PlatformOSIDWS,
			  DatabaseServerTokenIDWS,
			  DeviceGlobalIDWS,
              AccountTypeWS ,
     UserIDWS ,
                            MobileNumberIDWS );
 
		}


		#endregion


	}
}
