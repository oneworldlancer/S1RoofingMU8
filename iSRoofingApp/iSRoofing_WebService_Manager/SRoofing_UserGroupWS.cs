using S1RoofingMU.iSRoofingApp.iSRoofing_HTTPManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebServiceWS;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager
{
    public class SRoofing_UserGroupWS
    {
        ISRoofing_UserGroupWS _iWebServiceWS;

        public SRoofing_UserGroupWS(ISRoofing_UserGroupWS iWebServiceWS)
        {
            _iWebServiceWS = iWebServiceWS;
        }

        #region Get_List
        //<ObservableCollection<SRoofingLogisticsStaffModelManager>> 


        public Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserCategory_Get_GroupList_ByCategoryTokenIDWSAsync(
                               string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                              string DeviceGlobalIDWS,
                     string AccountTypeWS,
                      string OwnerUserTokenIDWS,
                         string OwnerMobileNumberTokenIDWS,
                         string CategoryTokenIDWS)
        {
            return _iWebServiceWS.SRoofing_XFMobile_UserCategory_Get_GroupList_ByCategoryTokenIDWSAsync(
            PlatformOSIDWS,
                        DatabaseServerTokenIDWS,
                                DeviceGlobalIDWS,
                       AccountTypeWS,
                        OwnerUserTokenIDWS,
                           OwnerMobileNumberTokenIDWS,
                           CategoryTokenIDWS);
            //return null;//.iRefreshDataAsync();
        }




        public Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_Group_ByGroupTokenIDWSAsync(
                                                   string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                              string DeviceGlobalIDWS,
                     string AccountTypeWS,
                      string OwnerUserTokenIDWS,
                         string OwnerMobileNumberTokenIDWS,
                         string GroupTokenIDWS)
        {


            return _iWebServiceWS.SRoofing_XFMobile_UserGroup_Get_Group_ByGroupTokenIDWSAsync(
            PlatformOSIDWS,
                        DatabaseServerTokenIDWS,
                                DeviceGlobalIDWS,
                       AccountTypeWS,
                        OwnerUserTokenIDWS,
                           OwnerMobileNumberTokenIDWS,
                           GroupTokenIDWS);

            //return null;//.iRefreshDataAsync();
        }




        public Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_List_All_ByAlphabetIndexWSAsync(
                   string PlatformOSIDWS,
      string DatabaseServerTokenIDWS,
       string DeviceGlobalIDWS,
       string AccountTypeWS,
                 string UserIDWS,
                 string MobileNumberIDWS,
               string iCharacterWS,
                string IndexIDWS)
        {
            return _iWebServiceWS.SRoofing_XFMobile_UserGroup_Get_List_All_ByAlphabetIndexWSAsync(
                     PlatformOSIDWS,
        DatabaseServerTokenIDWS,
         DeviceGlobalIDWS,
         AccountTypeWS,
                   UserIDWS,
                   MobileNumberIDWS,
                 iCharacterWS,
                  IndexIDWS);
            //return null;//.iRefreshDataAsync();
        }




        public Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_List_Private_ByAlphabetIndexWSAsync(
             string PlatformOSIDWS,
       string DatabaseServerTokenIDWS,
      string DeviceGlobalIDWS,
    string AccountTypeWS,
            string UserIDWS,
            string MobileNumberIDWS,
         string iCharacterWS,
           string IndexIDWS)
        {
            return _iWebServiceWS.SRoofing_XFMobile_UserGroup_Get_List_Private_ByAlphabetIndexWSAsync(
               PlatformOSIDWS,
         DatabaseServerTokenIDWS,
        DeviceGlobalIDWS,
      AccountTypeWS,
              UserIDWS,
              MobileNumberIDWS,
           iCharacterWS,
             IndexIDWS);
            //return null;//.iRefreshDataAsync();
        }




        public static async Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_List_Private_Filter_Chatter_ByAlphabetIndexWSAsync(
                   S1RoofingMU.iSRoofingApp.iSRoofing_Model.User.SRoofingUserOwnerModelManager iOwnerModel,
                                   string PlatformOSIDWS,
      string DatabaseServerTokenIDWS,
      string DeviceGlobalIDWS,
     string AccountTypeWS,
             string UserIDWS,
            string MobileNumberIDWS,
            string GroupTokenIDWS,
             string iCharacterWS,
             string IRowIndexWS)
        {

            try
            {


                ObservableCollection<SRoofingUserGroupModelManager> arr_ItemListWS = new ObservableCollection<SRoofingUserGroupModelManager>();



                using (var _iClient = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance())
                {

                    string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_SRoofingUserGroupWS.Chatter_Get_List_Private_Filter_Chatter_ByAlphabetIndexWS;

                    string _iWebParamWS =
             "PlatformOSIDWS=" + App.iPlatformOS +"&" +
             "DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
             "DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
             "AccountTypeWS=" + App.iAccountType +"&" +
             "OwnerUserTokenIDWS=" + iOwnerModel.OwnerUserTokenID +"&" +
             "OwnerMobileNumberTokenIDWS=" + iOwnerModel.OwnerMobileNumberTokenID +"&" +


                 "GroupTokenIDWS=" + GroupTokenIDWS +"&" +
                 //"ApplicationRoleCodeWS=" + "0" +"&" +
                 //"ProjectTokenIDWS=" + "0" +"&" +
                 //"iTodayDayWS=" + DateTime.Now.Day.ToString() +"&" +
                 //"iTodayMonthWS=" +    DateTime.Now.Month.ToString() +"&" +
                 //"iTodayYearWS=" + DateTime.Now.Year.ToString() +"&" +

                 "iCharacterWS=" + iCharacterWS +"&" +
                 "IRowIndexWS=" + IRowIndexWS;

                    Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

                    _iClient.BaseAddress=  uri;

                    HttpResponseMessage response = await _iClient.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {

                        //SRoofing_DebugManager.Debug_ShowSystemMessage("IsSuccessStatusCode == "+ response.Content.ToString());
                        arr_ItemListWS= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingUserGroupModelManager>>();

                    }


                }


                if (arr_ItemListWS != null)
                {
                    //foreach (SRoofingUserGroupModelManager iOneItem in arr_ItemListWS)
                    //{
                    //    // code block to be executed
                    //    iOneItem.MessageText = WebUtility.UrlDecode(iOneItem.MessageText);

                    //    iOneItem.IsVisible = true;

                    //    //arr_ItemList.Add(iOneItem);
                    //}

                }




                if (arr_ItemListWS != null)
                {

                    await SRoofingSync_UserContactPickerManager.Sync_User_Picker_Contact_Set_List_Contact_ByCharcterID(
                           Application.Current, iOwnerModel, GroupTokenIDWS, arr_ItemListWS);

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

        }





        public Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_List_Private_Filter_Chatter_ByAlphabetIndexWSAsync_X1(
                 string PlatformOSIDWS,
      string DatabaseServerTokenIDWS,
      string DeviceGlobalIDWS,
     string AccountTypeWS,
             string UserIDWS,
            string MobileNumberIDWS,
            string GroupTokenIDWS,
             string iCharacterWS,
             string IndexIDWS)
        {


            return _iWebServiceWS.SRoofing_XFMobile_UserGroup_Get_List_Private_Filter_Chatter_ByAlphabetIndexWSAsync(
                   PlatformOSIDWS,
        DatabaseServerTokenIDWS,
        DeviceGlobalIDWS,
       AccountTypeWS,
               UserIDWS,
              MobileNumberIDWS,
              GroupTokenIDWS,
               iCharacterWS,
               IndexIDWS);
            //return null;//.iRefreshDataAsync();
        }




        public
        Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_List_All_Alphabet_Index_AccountTypeWSAsync(
          string PlatformOSIDWS,
      string DatabaseServerTokenIDWS,
      string DeviceGlobalIDWS,
     string AccountTypeWS,
             string UserIDWS,
              string MobileNumberIDWS,
             string IndexIDWS)
        {
            return _iWebServiceWS.SRoofing_XFMobile_UserGroup_Get_List_All_Alphabet_Index_AccountTypeWSAsync(
            PlatformOSIDWS,
        DatabaseServerTokenIDWS,
        DeviceGlobalIDWS,
       AccountTypeWS,
               UserIDWS,
                MobileNumberIDWS,
               IndexIDWS);
            //return null;//.iRefreshDataAsync();
        }




        public
        Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_List_Private_Alphabet_Index_AccountTypeWSAsync(
     string PlatformOSIDWS,
    string DatabaseServerTokenIDWS,
     string DeviceGlobalIDWS,
      string AccountTypeWS,
               string UserIDWS,
                string MobileNumberIDWS,
                       string IndexIDWS)
        {
            return _iWebServiceWS.SRoofing_XFMobile_UserGroup_Get_List_Private_Alphabet_Index_AccountTypeWSAsync(
       PlatformOSIDWS,
      DatabaseServerTokenIDWS,
       DeviceGlobalIDWS,
        AccountTypeWS,
                 UserIDWS,
                  MobileNumberIDWS,
               IndexIDWS);
            //return null;//.iRefreshDataAsync();
        }


        #endregion


    }
}
