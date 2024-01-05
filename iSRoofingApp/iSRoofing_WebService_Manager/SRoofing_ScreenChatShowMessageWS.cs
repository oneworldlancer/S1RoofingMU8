

using S1RoofingMU.iSRoofingApp.iSRoofing_HTTPManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;

using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebServiceWS;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http.Json;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager
{
    public class SRoofing_ScreenChatShowMessageWS //: ISRoofing_ScreenChatShowMessageWS
    {

        //ISRoofing_ScreenChatShowMessageWS _iWebServiceWS;

        //public SRoofing_ScreenChatShowMessageWS(ISRoofing_ScreenChatShowMessageWS iWebServiceWS)
        //{
        //    _iWebServiceWS = iWebServiceWS;
        //}

        #region Get_List


        public static async Task<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>> SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWSAsync(
                         S1RoofingMU.iSRoofingApp.iSRoofing_Model.User.SRoofingUserOwnerModelManager iOwnerModel,
                         string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                              string DeviceGlobalIDWS,
                     string AccountTypeWS,
                      string OwnerUserTokenIDWS,
                         string OwnerMobileNumberTokenIDWS,
                      string ApplicationRoleCodeWS,
                       string ProjectTokenIDWS,
                        string iTodayDayWS,
                      string iTodayMonthWS,
                        string iTodayYearWS,
                      string IsHistoryMessageLineWS)
        {


            try
            {


                ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_ItemListWS = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();



                using (var _iClient = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance())
                {

                    string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_SRoofingUserScreenChatShowMessageWS.History_Chat_ByOwnerUserTokenIDWS;

                    string _iWebParamWS =
             "PlatformOSIDWS=" + App.iPlatformOS +"&" +
             "DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
             "DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
             "AccountTypeWS=" + App.iAccountType +"&" +
             "OwnerUserTokenIDWS=" + iOwnerModel.OwnerUserTokenID +"&" +
             "OwnerMobileNumberTokenIDWS=" + iOwnerModel.OwnerMobileNumberTokenID +"&" +


             "ApplicationRoleCodeWS=" + "0" +"&" +
             "ProjectTokenIDWS=" + "0" +"&" +
             "iTodayDayWS=" + DateTime.Now.Day.ToString() +"&" +
             "iTodayMonthWS=" +    DateTime.Now.Month.ToString() +"&" +
             "iTodayYearWS=" + DateTime.Now.Year.ToString() +"&" +
             "IsHistoryMessageLineWS=" + "1" +"&" +
             "IRowIndexWS=0";

                    Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

                    _iClient.BaseAddress=  uri;

                    HttpResponseMessage response = await _iClient.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {

                        //SRoofing_DebugManager.Debug_ShowSystemMessage("IsSuccessStatusCode == "+ response.Content.ToString());
                        arr_ItemListWS= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>>();

                    }


                }


                if (arr_ItemListWS != null)
                {
                    foreach (SRoofingScreenChatShowHistoryMessageModelManager iOneItem in arr_ItemListWS)
                    {
                        // code block to be executed
                        iOneItem.MessageText = WebUtility.UrlDecode(iOneItem.MessageText);

                        iOneItem.IsVisible = true;

                        //arr_ItemList.Add(iOneItem);
                    }

                }











                //////////////////////////////////////////    //////SRoofingScreenChatShowHistoryMessageModelManager oneItem;

                //////////////////////////////////////////    ////for (int i = 0; i < arr_ItemListWS.Count(); i++)
                //////////////////////////////////////////    ////{

                //////////////////////////////////////////    ////    oneItem =  new SRoofingScreenChatShowHistoryMessageModelManager
                //////////////////////////////////////////    ////    {

                //////////////////////////////////////////    ////        AccountType = arr_ItemListWS[i].AccountType,


                //////////////////////////////////////////    ////        GroupTitle = arr_ItemListWS[i].GroupTitle,

                //////////////////////////////////////////    ////        OwnerUserTokenID = iOwnerModel.OwnerUserTokenID,//arr_ItemListWS[i].OwnerUserTokenID ,

                //////////////////////////////////////////    ////        OwnerMobileNumberTokenID = iOwnerModel.OwnerMobileNumberTokenID,// arr_ItemListWS[i].OwnerMobileNumberTokenID ,

                //////////////////////////////////////////    ////        VisibleOnlineDateTimeMilliSec = arr_ItemListWS[i].VisibleOnlineDateTimeMilliSec,

                //////////////////////////////////////////    ////        CategoryTitle = "0",//WebUtility.UrlDecode(arr_ItemListWS[i].CategoryTitle),


                //////////////////////////////////////////    ////        ChatterListCount = arr_ItemListWS[i].ChatterListCount,

                //////////////////////////////////////////    ////        AvatarImageID = arr_ItemListWS[i].AvatarImageID,

                //////////////////////////////////////////    ////        MessageType = arr_ItemListWS[i].MessageType,

                //////////////////////////////////////////    ////        RemoteMobileNumberE164 = arr_ItemListWS[i].RemoteMobileNumberE164,

                //////////////////////////////////////////    ////        //   IsNewMessage = Boolean.Parse(arr_ItemListWS[i].IsNewMessage.ToString()),
                //////////////////////////////////////////    ////        IsNewMessage =arr_ItemListWS[i].IsNewMessage,

                //////////////////////////////////////////    ////        DateTimeText = arr_ItemListWS[i].DateTimeText,

                //////////////////////////////////////////    ////        MessageText = WebUtility.UrlDecode(arr_ItemListWS[i].MessageText),

                //////////////////////////////////////////    ////        PrivateGroupTokenID = arr_ItemListWS[i].PrivateGroupTokenID,

                //////////////////////////////////////////    ////        GroupTokenID = arr_ItemListWS[i].GroupTokenID,

                //////////////////////////////////////////    ////        GroupType = arr_ItemListWS[i].GroupType,

                //////////////////////////////////////////    ////        NameLine = arr_ItemListWS[i].NameLine,

                //////////////////////////////////////////    ////        AvatarName = arr_ItemListWS[i].AvatarName,

                //////////////////////////////////////////    ////        RemoteUserTokenID = arr_ItemListWS[i].RemoteUserTokenID,

                //////////////////////////////////////////    ////        RemoteMobileNumberTokenID = arr_ItemListWS[i].RemoteMobileNumberTokenID,

                //////////////////////////////////////////    ////        RemoteFullName = arr_ItemListWS[i].RemoteFullName,

                //////////////////////////////////////////    ////        RemoteVisibleStatus = arr_ItemListWS[i].RemoteVisibleStatus,

                //////////////////////////////////////////    ////        MessageTokenID = arr_ItemListWS[i].MessageTokenID,

                //////////////////////////////////////////    ////        DateTime = arr_ItemListWS[i].DateTime,

                //////////////////////////////////////////    ////        DateTimeMilliSec = arr_ItemListWS[i].DateTimeMilliSec,

                //////////////////////////////////////////    ////        GroupCode = arr_ItemListWS[i].GroupCode,

                //////////////////////////////////////////    ////        GroupTag = arr_ItemListWS[i].GroupTag,

                //////////////////////////////////////////    ////        iViewCodeType = arr_ItemListWS[i].iViewCodeType,

                //////////////////////////////////////////    ////        IsVisible = true,

                //////////////////////////////////////////    ////    };

                //////////////////////////////////////////    ////    arr_ItemList.Add(oneItem);

                //////////////////////////////////////////    ////}

                //////////////////////////////////////////}




                //////////////////////////////////////////SRoofing_UserProfileWSSoapClient.EndpointConfiguration endpoint2 = new SRoofing_UserProfileWSSoapClient.EndpointConfiguration();


                //////////////////////////////////////////// SRoofing_UserRegisterWSSoapClient objService = new SRoofing_UserRegisterWSSoapClient(endpoint, "https://oneworldlancer.ddns.net/S1Roofing/SRoofing_UserRegisterWS.asmx");
                //////////////////////////////////////////SRoofing_UserProfileWSSoapClient objService2 = new SRoofing_UserProfileWSSoapClient(endpoint2);

                //////////////////////////////////////////var xxx2 = await objService2.SRoofing_XFMobile_UserProfile_Get_Owner_Profile_ByAccountTypeWSAsync("0", "0", "0", App.iAccountType, "2148", "38");

                //////////////////////////////////////////SRoofing_DebugManager.Debug_ShowSystemMessage("***************SRoofing_UserRegisterWSSoapClient*************** == "+ xxx2[0].FullName.ToString());
























                //////////////////////////////////////////SRoofing_ScreenChatShowMessageWSSoapClient.EndpointConfiguration endpoint = new SRoofing_ScreenChatShowMessageWSSoapClient.EndpointConfiguration();


                //////////////////////////////////////////// SRoofing_UserRegisterWSSoapClient objService = new SRoofing_UserRegisterWSSoapClient(endpoint, "https://oneworldlancer.ddns.net/S1Roofing/SRoofing_UserRegisterWS.asmx");
                ////////////////////////////////////////////SRoofing_ScreenChatShowMessageWSSoapClient objService = new SRoofing_ScreenChatShowMessageWSSoapClient(endpoint, App.SiteDomainURL + "SRoofing_ScreenChatShowMessageWS.asmx");
                //////////////////////////////////////////SRoofing_ScreenChatShowMessageWSSoapClient objService = new SRoofing_ScreenChatShowMessageWSSoapClient(endpoint);


                ////////////////////////////////////////////SRoofing_XFMobile_UserProfile_Get_Owner_Profile_ByAccountTypeWSRequest req2 = new SRoofing_XFMobile_UserProfile_Get_Owner_Profile_ByAccountTypeWSRequest();
                ////////////////////////////////////////////req.UserIDWS = "0";
                ////////////////////////////////////////////req.MobileNumberIDWS = "0";
                ////////////////////////////////////////////req.MobileNumberE164WS =  "0";
                ////////////////////////////////////////////req.CountryCodeWS = "0";
                ////////////////////////////////////////////req.CountryMobileCodeWS =  "0";
                ////////////////////////////////////////////req.ListUserIDWS = "0";

                //////////////////////////////////////////SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWSRequest req = new SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWSRequest();
                //////////////////////////////////////////req.PlatformOSIDWS = PlatformOSIDWS;
                //////////////////////////////////////////req.DatabaseServerTokenIDWS = DatabaseServerTokenIDWS;
                //////////////////////////////////////////req.DeviceGlobalIDWS = DeviceGlobalIDWS;
                //////////////////////////////////////////req.AccountTypeWS = AccountTypeWS;
                //////////////////////////////////////////req.OwnerUserTokenIDWS = OwnerUserTokenIDWS;
                //////////////////////////////////////////req.OwnerMobileNumberTokenIDWS = OwnerMobileNumberTokenIDWS;
                //////////////////////////////////////////req.ApplicationRoleCodeWS = ApplicationRoleCodeWS;
                //////////////////////////////////////////req.ProjectTokenIDWS = ProjectTokenIDWS;
                //////////////////////////////////////////req.iTodayDayWS = iTodayDayWS;
                //////////////////////////////////////////req.iTodayMonthWS = iTodayMonthWS;
                //////////////////////////////////////////req.iTodayYearWS = iTodayYearWS;
                //////////////////////////////////////////req.IsHistoryMessageLineWS = IsHistoryMessageLineWS;

                //////////////////////////////////////////var _arrWebServiceResultListWS = await objService.SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWSAsync(req);


                //////////////////////////////////////////SRoofing_DebugManager.Debug_ShowSystemMessage("***************SRoofing_UserRegisterWSSoapClient*************** == "+ _arrWebServiceResultListWS.SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWSResult.Count().ToString());




                ////////////////////////////////////////////  Task<SRoofingScreenChatShowMessageModelManager[ ]> _arrParseResult = Task.FromResult(_arrResultListWS);

                ////////////////////////////////////////////////ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> _arrUserResult = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();


                //////if (_arrParseResult != null)
                //////{

                //////    ////////////////////if (_arrParseResult )
                //////    ////////////////////{

                //////    ////////////////////    SRoofingScreenChatShowHistoryMessageModelManager oneItem;
                //////    ////////////////////    for (int i = 0; i < _arrResultListWS.Count(); i++)
                //////    ////////////////////    {

                //////    ////////////////////        oneItem =  new SRoofingScreenChatShowHistoryMessageModelManager
                //////    ////////////////////        {

                //////    ////////////////////            AccountType = _arrResultListWS[i].AccountType,


                //////    ////////////////////            GroupTitle = _arrResultListWS[i].GroupTitle,

                //////    ////////////////////            OwnerUserTokenID = iOwnerModel.OwnerUserTokenID,//_arrResultListWS[i].OwnerUserTokenID ,

                //////    ////////////////////            OwnerMobileNumberTokenID = iOwnerModel.OwnerMobileNumberTokenID,// _arrResultListWS[i].OwnerMobileNumberTokenID ,

                //////    ////////////////////            VisibleOnlineDateTimeMilliSec = _arrResultListWS[i].VisibleOnlineDateTimeMilliSec,

                //////    ////////////////////            CategoryTitle = WebUtility.UrlDecode(_arrResultListWS[i].CategoryTitle),


                //////    ////////////////////            ChatterListCount = _arrResultListWS[i].ChatterListCount,

                //////    ////////////////////            AvatarImageID = _arrResultListWS[i].AvatarImageID,

                //////    ////////////////////            MessageType = _arrResultListWS[i].MessageType,

                //////    ////////////////////            RemoteMobileNumberE164 = _arrResultListWS[i].RemoteMobileNumberE164,

                //////    ////////////////////            IsNewMessage = Boolean.Parse(_arrResultListWS[i].IsNewMessage),

                //////    ////////////////////            DateTimeText = _arrResultListWS[i].DateTimeText,

                //////    ////////////////////            MessageText = WebUtility.UrlDecode(_arrResultListWS[i].MessageText),
                //////    ////////////////////            // SRoofing_ScreenChatShowTextMessageManager
                //////    ////////////////////            // .ScreenChatShowMessage_Get_Translated(
                //////    ////////////////////            //     App.Current, _arrResultListWS[i].AccountType,   _iOwnerModel,
                //////    ////////////////////            //_arrResultListWS[i].MessageType,
                //////    ////////////////////            //WebUtility.UrlDecode ( _arrResultListWS[i].MessageText )).Result.ToString(),

                //////    ////////////////////            //////MessageText = SRoofing_ScreenChatShowTextMessageManager
                //////    ////////////////////            //////   .ScreenChatShowMessage_Get_Translated(
                //////    ////////////////////            //////       App.Current, _arrResultListWS[i].AccountType,   _iOwnerModel,
                //////    ////////////////////            //////  _arrResultListWS[i].MessageType,
                //////    ////////////////////            //////  WebUtility.UrlDecode ( _arrResultListWS[i].MessageText )).Result.ToString(),

                //////    ////////////////////            //////   CategoryTokenID = _arrResultListWS[i].CategoryTokenID ,

                //////    ////////////////////            PrivateGroupTokenID = _arrResultListWS[i].PrivateGroupTokenID,

                //////    ////////////////////            GroupTokenID = _arrResultListWS[i].GroupTokenID,

                //////    ////////////////////            GroupType = _arrResultListWS[i].GroupType,

                //////    ////////////////////            NameLine = _arrResultListWS[i].NameLine,

                //////    ////////////////////            AvatarName = _arrResultListWS[i].AvatarName,

                //////    ////////////////////            RemoteUserTokenID = _arrResultListWS[i].RemoteUserTokenID,

                //////    ////////////////////            RemoteMobileNumberTokenID = _arrResultListWS[i].RemoteMobileNumberTokenID,

                //////    ////////////////////            RemoteFullName = _arrResultListWS[i].RemoteFullName,

                //////    ////////////////////            RemoteVisibleStatus = _arrResultListWS[i].RemoteVisibleStatus,

                //////    ////////////////////            MessageTokenID = _arrResultListWS[i].MessageTokenID,

                //////    ////////////////////            DateTime = _arrResultListWS[i].DateTime,

                //////    ////////////////////            DateTimeMilliSec = _arrResultListWS[i].DateTimeMilliSec,

                //////    ////////////////////            //IsOpen = _arrResultListWS[i].IsOpen ,

                //////    ////////////////////            GroupCode = _arrResultListWS[i].GroupCode,

                //////    ////////////////////            GroupTag = _arrResultListWS[i].GroupTag,

                //////    ////////////////////            iViewCodeType = _arrResultListWS[i].iViewCodeType,


                //////    ////////////////////            IsVisible = true,

                //////    ////////////////////        };

                //////    ////////////////////        _arrUserResult.Add(oneItem);

                //////    ////////////////////    }


                //////    ////////////////////}
                //////}

                if (arr_ItemListWS != null)
                {
                    return arr_ItemListWS;
                }

                return null;

                //return new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>() ;

                //   SRoofing_DebugManager.Debug_ShowSystemMessage("***************SRoofing_UserRegisterWSSoapClient***************"+ xxx2[0].FullName.ToString());

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;

            }










            //return _iWebServiceWS.SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWSAsync (
            //                     PlatformOSIDWS ,
            //            DatabaseServerTokenIDWS ,
            //                    DeviceGlobalIDWS ,
            //           AccountTypeWS ,
            //            OwnerUserTokenIDWS ,
            //               OwnerMobileNumberTokenIDWS ,
            //            ApplicationRoleCodeWS ,
            //             ProjectTokenIDWS ,
            //              iTodayDayWS ,
            //            iTodayMonthWS ,
            //              iTodayYearWS ,
            //            IsHistoryMessageLineWS );


        }



        //<ObservableCollection<SRoofingLogisticsStaffModelManager>> 
        //public Task Task<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>> SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWSAsync (
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

        //    return _iWebServiceWS.SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWSAsync (
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
