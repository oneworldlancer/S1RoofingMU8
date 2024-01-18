using S1RoofingMU.iSRoofingApp.iSRoofing_HTTPManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Category;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebServiceWS;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager
{
    public class SRoofing_ScreenChatShowChatterListWS
    {
        //      ISRoofing_ScreenChatShowChatterListWS _iWebServiceWS;

        //public SRoofing_ScreenChatShowChatterListWS ( ISRoofing_ScreenChatShowChatterListWS iWebServiceWS )
        //{
        //	_iWebServiceWS = iWebServiceWS;
        //}

        #region Get_List


        public static async Task<ObservableCollection<SRoofingUserRemoteModelManager>> SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWSAsync(
                                   S1RoofingMU.iSRoofingApp.iSRoofing_Model.User.SRoofingUserOwnerModelManager iOwnerModel,
                                      string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                              string DeviceGlobalIDWS,
                     string AccountTypeWS,
                       string GroupTokenIDWS,
          string ScreenChatShowIDWS,
         string ScreenChatShowTicketIDWS,

                           string OwnerUserTokenIDWS,
                         string OwnerMobileNumberTokenIDWS,
                      string iCharacterWS,
               string IRowIndexWS)
        {



            ObservableCollection<SRoofingUserRemoteModelManager> arr_ItemListWS = new ObservableCollection<SRoofingUserRemoteModelManager>();



            using (var _iClient = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance())
            {

                string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_ScreenChatShowChatterListWS.Chatter_Get_List_ChatterList_Category_ByGroupTokenIDWS;

                string _iWebParamWS =
         "PlatformOSIDWS=" + App.iPlatformOS +"&" +
         "DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
         "DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
         "AccountTypeWS=" + App.iAccountType +"&" +
        
         "OwnerUserTokenIDWS=" + iOwnerModel.OwnerUserTokenID +"&" +
         "OwnerMobileNumberTokenIDWS=" + iOwnerModel.OwnerMobileNumberTokenID +"&" +

   "GroupTokenIDWS=" + GroupTokenIDWS +"&" +
          
   "iCharacterWS=" + iCharacterWS +"&" +

             "ScreenChatShowIDWS=" + "0" +"&" +
             "ScreenChatShowTicketIDWS=" + "0" +"&" +

             //"iTodayDayWS=" + DateTime.Now.Day.ToString() +"&" +
             //"iTodayMonthWS=" +    DateTime.Now.Month.ToString() +"&" +
             //"iTodayYearWS=" + DateTime.Now.Year.ToString() +"&" +
             //"IsHistoryMessageLineWS=" + "1" +"&" +
             "IRowIndexWS=" + IRowIndexWS;

                Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

                _iClient.BaseAddress=  uri;

                HttpResponseMessage response = await _iClient.GetAsync("");
                if (response.IsSuccessStatusCode)
                {

                    //SRoofing_DebugManager.Debug_ShowSystemMessage("IsSuccessStatusCode == "+ response.Content.ToString());
                    arr_ItemListWS= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingUserRemoteModelManager>>();

                }


            }


            if (arr_ItemListWS != null)
            {
                //foreach (SRoofingUserRemoteModelManager iOneItem in arr_ItemListWS)
                //{
                //    // code block to be executed
                //    iOneItem.MessageText = WebUtility.UrlDecode(iOneItem.MessageText);

                //    iOneItem.IsVisible = true;

                //    //arr_ItemList.Add(iOneItem);
                //}

            }




            if (arr_ItemListWS != null)
            {
                return arr_ItemListWS;
            }

            return new ObservableCollection<SRoofingUserRemoteModelManager>() ;




            //return _iWebServiceWS.SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWSAsync (
            //                                 PlatformOSIDWS ,
            //            DatabaseServerTokenIDWS ,
            //                    DeviceGlobalIDWS ,
            //           AccountTypeWS ,
            //             GroupIDWS ,
            //                 ScreenChatShowIDWS ,
            //                 ScreenChatShowTicketIDWS ,
            //                 OwnerUserTokenIDWS ,
            //               OwnerMobileNumberTokenIDWS );


            //return null;//.iRefreshDataAsync();


        }





        public Task<ObservableCollection<SRoofingUserRemoteModelManager>> SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWSAsync_X1(
                                               string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                              string DeviceGlobalIDWS,
                     string AccountTypeWS,
                       string GroupIDWS,
                           string ScreenChatShowIDWS,
                           string ScreenChatShowTicketIDWS,
                           string OwnerUserTokenIDWS,
                         string OwnerMobileNumberTokenIDWS)
        {

            //return _iWebServiceWS.SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWSAsync (
            //                                 PlatformOSIDWS ,
            //            DatabaseServerTokenIDWS ,
            //                    DeviceGlobalIDWS ,
            //           AccountTypeWS ,
            //             GroupIDWS ,
            //                 ScreenChatShowIDWS ,
            //                 ScreenChatShowTicketIDWS ,
            //                 OwnerUserTokenIDWS ,
            //               OwnerMobileNumberTokenIDWS );

            return null;//.iRefreshDataAsync();
        }





        //////public Task<ObservableCollection<SRoofingUserRemoteModelManager>> SRoofing_XFMobile_UserContactFriend_Get_List_Alphabet_Index_AccountTypeWSAsync(
        //////                       string PlatformOSIDWS ,
        //////              string DatabaseServerTokenIDWS ,
        //////                      string DeviceGlobalIDWS ,
        //////             string AccountTypeWS ,
        //////              string OwnerUserTokenIDWS ,
        //////                 string OwnerMobileNumberTokenIDWS ,
        //////                                 string IndexIDWS )
        //////    {

        //////    return _iWebServiceWS.SRoofing_XFMobile_UserContactFriend_Get_List_Alphabet_Index_AccountTypeWSAsync(
        //////                         PlatformOSIDWS ,
        //////                DatabaseServerTokenIDWS ,
        //////                        DeviceGlobalIDWS ,
        //////               AccountTypeWS ,
        //////                OwnerUserTokenIDWS ,
        //////                   OwnerMobileNumberTokenIDWS ,
        //////                                            IndexIDWS );
        //////    //return null;//.iRefreshDataAsync();
        //////    }




        //<ObservableCollection<SRoofingLogisticsStaffModelManager>> 
        //public Task Task<ObservableCollection<SRoofingUserRemoteModelManager>> SRoofing_ScreenCallShow_Get_List_All_Call_ByOwnerUserTokenIDWSAsync (
        //                       string PlatformOSIDWS,
        //              string DatabaseServerTokenIDWS,
        //                      string DeviceGlobalIDWS,
        //             string AccountTypeWS,
        //              string OwnerUserTokenIDWS,
        //                 string OwnerMobileNumberTokenIDWS,
        //              string ApplicationRoleCodeWS,
        //               string ProjectTokenIDWS,
        //                string iTodayDayWS,
        //              string iTodayMonthWS,
        //                string iTodayYearWS,
        //              string IsHistoryMessageLineWS)
        //    {

        //    return _iWebServiceWS.SRoofing_ScreenCallShow_Get_List_All_Call_ByOwnerUserTokenIDWSAsync (
        //                         PlatformOSIDWS ,
        //                DatabaseServerTokenIDWS ,
        //                        DeviceGlobalIDWS ,
        //               AccountTypeWS ,
        //                OwnerUserTokenIDWS ,
        //                   OwnerMobileNumberTokenIDWS ,
        //                ApplicationRoleCodeWS ,
        //                 ProjectTokenIDWS ,
        //                  iTodayDayWS ,
        //                iTodayMonthWS ,
        //                  iTodayYearWS ,
        //                IsHistoryMessageLineWS );

        //    }


        #endregion


    }

}
