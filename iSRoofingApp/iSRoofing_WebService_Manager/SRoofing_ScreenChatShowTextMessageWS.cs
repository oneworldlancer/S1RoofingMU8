using S1RoofingMU.iSRoofingApp.iSRoofing_HTTPManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebServiceWS;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager
{
    public class SRoofing_ScreenChatShowTextMessageWS
    {
        //ISRoofing_ScreenChatShowTextMessageWS _iWebServiceWS;

        //public SRoofing_ScreenChatShowTextMessageWS ( ISRoofing_ScreenChatShowTextMessageWS iWebServiceWS )
        //{
        //    _iWebServiceWS = iWebServiceWS;
        //}

        #region Get_List
        //<ObservableCollection<SRoofingLogisticsStaffModelManager>> 

        public static async Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowTextMessageWSAsync(
                              string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                              string DeviceGlobalIDWS,
                      string AccountTypeWS,
                   string MessageTokenIDWS,
                   string UploadDateTimeMilliSecWS,
                    string GroupIDWS,
                   string ScreenChatShowIDWS,
                  string ScreenChatShowTicketIDWS,
                   string InviteOwnerUserIDWS,
                     string InviteOwnerMobileNumberIDWS,
                    string FromUserIDWS,
                     string FromMobileNumberIDWS,
                    string InviteTagWS,
                    string InviteCodeWS,
                     string MessageCodeWS,
                     string MessageTypeWS,
                   string MessageTextWS,
                            string MessageOriginalCodeWS,
                           string MessageOriginalTextWS,
                           string MessageTranslateCodeWS,
                           string MessageTranslateTextWS,
                    string DateTimeTextWS,
               string DateTimeWS,
                string DateTextWS,
                string UserDateDayWS,
                string UserDateMonthWS,
               string UserDateYearWS,
                     string DateTimeMilliSecWS)
        {



            try
            {
                //ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_ItemListWS = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                using (var _iClient = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance())
                {

                    string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_ScreenChatShowTextMessageWS.ScreenChatShowMessage_SendScreenChatShowTextMessageWS;

                    string _iWebParamWS =
             "PlatformOSIDWS=" + App.iPlatformOS +"&" +
             "DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
             "DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
             "AccountTypeWS=" + App.iAccountType +"&" +


                   "MessageTokenIDWS="   +     MessageTokenIDWS  +  "&" +
                     "UploadDateTimeMilliSecWS="   +     UploadDateTimeMilliSecWS  +  "&" +
                   "GroupIDWS="   +     GroupIDWS  +  "&" +
                   "ScreenChatShowIDWS="   +     ScreenChatShowIDWS  +  "&" +
                     "ScreenChatShowTicketIDWS="   +     ScreenChatShowTicketIDWS  +  "&" +
                      "InviteOwnerUserIDWS="   +     InviteOwnerUserIDWS  +  "&" +
                     "InviteOwnerMobileNumberIDWS="   +     InviteOwnerMobileNumberIDWS  +  "&" +
                      "FromUserIDWS="   +     FromUserIDWS  +  "&" +
                      "FromMobileNumberIDWS="   +     FromMobileNumberIDWS  +  "&" +
                    "InviteTagWS="   +     InviteTagWS  +  "&" +
                      "InviteCodeWS="   +     InviteCodeWS  +  "&" +
                    "MessageCodeWS="   +     MessageCodeWS  +  "&" +
                   "MessageTypeWS="   +     MessageTypeWS  +  "&" +
                    "MessageTextWS="   +     MessageTextWS  +  "&" +
                     "MessageOriginalCodeWS="   +     MessageOriginalCodeWS  +  "&" +
                    "MessageOriginalTextWS="   +     MessageOriginalTextWS  +  "&" +
                     "MessageTranslateCodeWS="   +     MessageTranslateCodeWS  +  "&" +
                     "MessageTranslateTextWS="   +     MessageTranslateTextWS  +  "&" +
                 "DateTimeTextWS="   +     DateTimeTextWS  +  "&" +
                "DateTimeWS="   +     DateTimeWS  +  "&" +
                "DateTextWS="   +     DateTextWS  +  "&" +
                  "UserDateDayWS="   +     UserDateDayWS  +  "&" +
                 "UserDateMonthWS="   +     UserDateMonthWS  +  "&" +
                "UserDateYearWS="   +     UserDateYearWS  +  "&" +
                  "DateTimeMilliSecWS="   +     DateTimeMilliSecWS;


                    Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

                    _iClient.BaseAddress=  uri;

                    HttpResponseMessage response = await _iClient.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {

                        //SRoofing_DebugManager.Debug_ShowSystemMessage("IsSuccessStatusCode == "+ response.Content.ToString());
                        //arr_ItemListWS= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>>();

                    }


                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }





            //////////return _iWebServiceWS.SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowTextMessageWSAsync (
            //////////                    PlatformOSIDWS ,
            //////////            DatabaseServerTokenIDWS ,
            //////////                    DeviceGlobalIDWS ,
            //////////            AccountTypeWS ,
            //////////         MessageTokenIDWS ,
            //////////         UploadDateTimeMilliSecWS ,
            //////////          GroupIDWS ,
            //////////         ScreenChatShowIDWS ,
            //////////        ScreenChatShowTicketIDWS ,
            //////////         InviteOwnerUserIDWS ,
            //////////           InviteOwnerMobileNumberIDWS ,
            //////////          FromUserIDWS ,
            //////////           FromMobileNumberIDWS ,
            //////////          InviteTagWS ,
            //////////          InviteCodeWS ,
            //////////           MessageCodeWS ,
            //////////           MessageTypeWS ,
            //////////         MessageTextWS ,
            //////////                      MessageOriginalCodeWS ,
            //////////                   MessageOriginalTextWS ,
            //////////                   MessageTranslateCodeWS ,
            //////////                   MessageTranslateTextWS ,
            //////////       DateTimeTextWS ,
            //////////     DateTimeWS ,
            //////////      DateTextWS ,
            //////////      UserDateDayWS ,
            //////////      UserDateMonthWS ,
            //////////     UserDateYearWS ,
            //////////           DateTimeMilliSecWS );
            //return null;//.iRefreshDataAsync();
        }



        public static async Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowTextTranslateMessageWSAsync(
                                     string PlatformOSIDWS,
                       string DatabaseServerTokenIDWS,
                              string DeviceGlobalIDWS,
                     string AccountTypeWS,
                        string MessageTokenIDWS,
                       string UploadDateTimeMilliSecWS,
                      string GroupIDWS,
                        string ScreenChatShowIDWS,
                       string ScreenChatShowTicketIDWS,
                       string InviteOwnerUserIDWS,
                      string InviteOwnerMobileNumberIDWS,
                      string FromUserIDWS,
                        string FromMobileNumberIDWS,
                      string InviteTagWS,
                        string InviteCodeWS,
                        string MessageCodeWS,
                        string MessageTypeWS,
                      string MessageTextWS,
                               string MessageOriginalCodeWS,
                           string MessageOriginalTextWS,
                           string MessageTranslateCodeWS,
                           string MessageTranslateTextWS,
                    string DateTimeTextWS,
                  string DateTimeWS,
                  string DateTextWS,
                   string UserDateDayWS,
                    string UserDateMonthWS,
                    string UserDateYearWS,
                                    string DateTimeMilliSecWS)
        {


            try
            {
                //ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_ItemListWS = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                using (var _iClient = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance())
                {

                    string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_ScreenChatShowTextMessageWS.ScreenChatShowMessage_SendScreenChatShowTextTranslateMessageWS;

                    string _iWebParamWS =
             "PlatformOSIDWS=" + App.iPlatformOS +"&" +
             "DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
             "DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
             "AccountTypeWS=" + App.iAccountType +"&" +


                   "MessageTokenIDWS="   +     MessageTokenIDWS  +  "&" +
                     "UploadDateTimeMilliSecWS="   +     UploadDateTimeMilliSecWS  +  "&" +
                   "GroupIDWS="   +     GroupIDWS  +  "&" +
                   "ScreenChatShowIDWS="   +     ScreenChatShowIDWS  +  "&" +
                     "ScreenChatShowTicketIDWS="   +     ScreenChatShowTicketIDWS  +  "&" +
                      "InviteOwnerUserIDWS="   +     InviteOwnerUserIDWS  +  "&" +
                     "InviteOwnerMobileNumberIDWS="   +     InviteOwnerMobileNumberIDWS  +  "&" +
                      "FromUserIDWS="   +     FromUserIDWS  +  "&" +
                      "FromMobileNumberIDWS="   +     FromMobileNumberIDWS  +  "&" +
                    "InviteTagWS="   +     InviteTagWS  +  "&" +
                      "InviteCodeWS="   +     InviteCodeWS  +  "&" +
                    "MessageCodeWS="   +     MessageCodeWS  +  "&" +
                   "MessageTypeWS="   +     MessageTypeWS  +  "&" +
                    "MessageTextWS="   +     MessageTextWS  +  "&" +
                     "MessageOriginalCodeWS="   +     MessageOriginalCodeWS  +  "&" +
                    "MessageOriginalTextWS="   +     MessageOriginalTextWS  +  "&" +
                     "MessageTranslateCodeWS="   +     MessageTranslateCodeWS  +  "&" +
                     "MessageTranslateTextWS="   +     MessageTranslateTextWS  +  "&" +
                 "DateTimeTextWS="   +     DateTimeTextWS  +  "&" +
                "DateTimeWS="   +     DateTimeWS  +  "&" +
                "DateTextWS="   +     DateTextWS  +  "&" +
                  "UserDateDayWS="   +     UserDateDayWS  +  "&" +
                 "UserDateMonthWS="   +     UserDateMonthWS  +  "&" +
                "UserDateYearWS="   +     UserDateYearWS  +  "&" +
                  "DateTimeMilliSecWS="   +     DateTimeMilliSecWS;


                    Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

                    _iClient.BaseAddress=  uri;

                    HttpResponseMessage response = await _iClient.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {

                        //SRoofing_DebugManager.Debug_ShowSystemMessage("IsSuccessStatusCode == "+ response.Content.ToString());
                        //arr_ItemListWS= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>>();

                    }


                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }




            //////////return _iWebServiceWS.SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowTextTranslateMessageWSAsync(
            //////////                           PlatformOSIDWS,
            //////////             DatabaseServerTokenIDWS,
            //////////                    DeviceGlobalIDWS,
            //////////           AccountTypeWS,
            //////////              MessageTokenIDWS,
            //////////             UploadDateTimeMilliSecWS,
            //////////            GroupIDWS,
            //////////              ScreenChatShowIDWS,
            //////////             ScreenChatShowTicketIDWS,
            //////////             InviteOwnerUserIDWS,
            //////////            InviteOwnerMobileNumberIDWS,
            //////////            FromUserIDWS,
            //////////              FromMobileNumberIDWS,
            //////////            InviteTagWS,
            //////////              InviteCodeWS,
            //////////              MessageCodeWS,
            //////////              MessageTypeWS,
            //////////            MessageTextWS,
            //////////                        MessageOriginalCodeWS,
            //////////                   MessageOriginalTextWS,
            //////////                   MessageTranslateCodeWS,
            //////////            MessageTranslateTextWS,
            //////////        DateTimeTextWS,
            //////////        DateTimeWS,
            //////////        DateTextWS,
            //////////         UserDateDayWS,
            //////////          UserDateMonthWS,
            //////////          UserDateYearWS,
            //////////                          DateTimeMilliSecWS);
            //return null;//.iRefreshDataAsync();
        }





        public Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareEmotionMessageWSAsync(
                     string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                           string DeviceGlobalIDWS,
                      string AccountTypeWS,
                       string MessageTokenIDWS,
                       string UploadDateTimeMilliSecWS,
                      string GroupIDWS,
                       string ScreenChatShowIDWS,
                       string ScreenChatShowTicketIDWS,
                       string InviteOwnerUserIDWS,
                       string InviteOwnerMobileNumberIDWS,
                      string FromUserIDWS,
                         string FromMobileNumberIDWS,
                        string InviteTagWS,
                         string InviteCodeWS,
                        string MessageCodeWS,
                        string MessageTypeWS,
                      string MessageTextWS,
                              string MessageOriginalCodeWS,
                           string MessageOriginalTextWS,
                           string MessageTranslateCodeWS,
                           string MessageTranslateTextWS,
                      string DateTimeTextWS,
                   string DateTimeWS,
                   string DateTextWS,
                    string UserDateDayWS,
                   string UserDateMonthWS,
                   string UserDateYearWS,
                                      string DateTimeMilliSecWS)
        {

            //////////return _iWebServiceWS.SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareEmotionMessageWSAsync(
            //////////           PlatformOSIDWS,
            //////////            DatabaseServerTokenIDWS,
            //////////                 DeviceGlobalIDWS,
            //////////            AccountTypeWS,
            //////////             MessageTokenIDWS,
            //////////             UploadDateTimeMilliSecWS,
            //////////            GroupIDWS,
            //////////             ScreenChatShowIDWS,
            //////////             ScreenChatShowTicketIDWS,
            //////////             InviteOwnerUserIDWS,
            //////////             InviteOwnerMobileNumberIDWS,
            //////////            FromUserIDWS,
            //////////               FromMobileNumberIDWS,
            //////////              InviteTagWS,
            //////////               InviteCodeWS,
            //////////              MessageCodeWS,
            //////////              MessageTypeWS,
            //////////            MessageTextWS,
            //////////                         MessageOriginalCodeWS,
            //////////                   MessageOriginalTextWS,
            //////////                   MessageTranslateCodeWS,
            //////////                MessageTranslateTextWS,
            //////////        DateTimeTextWS,
            //////////         DateTimeWS,
            //////////         DateTextWS,
            //////////          UserDateDayWS,
            //////////         UserDateMonthWS,
            //////////         UserDateYearWS,
            //////////                            DateTimeMilliSecWS);
            return null;//.iRefreshDataAsync();
        }




        public Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareGiphyMessageWSAsync(
                     string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                           string DeviceGlobalIDWS,
                      string AccountTypeWS,
                       string MessageTokenIDWS,
                       string UploadDateTimeMilliSecWS,
                      string GroupIDWS,
                       string ScreenChatShowIDWS,
                       string ScreenChatShowTicketIDWS,
                       string InviteOwnerUserIDWS,
                       string InviteOwnerMobileNumberIDWS,
                      string FromUserIDWS,
                         string FromMobileNumberIDWS,
                        string InviteTagWS,
                         string InviteCodeWS,
                        string MessageCodeWS,
                        string MessageTypeWS,
                      string MessageTextWS,
                                 string MessageOriginalCodeWS,
                           string MessageOriginalTextWS,
                           string MessageTranslateCodeWS,
                           string MessageTranslateTextWS,
                  string GiphyImageCategoryWS,
                        string GiphyImageURLWS,
                           string GiphyImageTokenIDWS,
                     string DateTimeTextWS,
                   string DateTimeWS,
                   string DateTextWS,
                    string UserDateDayWS,
                   string UserDateMonthWS,
                   string UserDateYearWS,
                                      string DateTimeMilliSecWS)
        {

            //////////return _iWebServiceWS.SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareGiphyMessageWSAsync(
            //////////           PlatformOSIDWS,
            //////////            DatabaseServerTokenIDWS,
            //////////                 DeviceGlobalIDWS,
            //////////            AccountTypeWS,
            //////////             MessageTokenIDWS,
            //////////             UploadDateTimeMilliSecWS,
            //////////            GroupIDWS,
            //////////             ScreenChatShowIDWS,
            //////////             ScreenChatShowTicketIDWS,
            //////////             InviteOwnerUserIDWS,
            //////////             InviteOwnerMobileNumberIDWS,
            //////////            FromUserIDWS,
            //////////               FromMobileNumberIDWS,
            //////////              InviteTagWS,
            //////////               InviteCodeWS,
            //////////              MessageCodeWS,
            //////////              MessageTypeWS,
            //////////            MessageTextWS,
            //////////                       MessageOriginalCodeWS,
            //////////                 MessageOriginalTextWS,
            //////////                 MessageTranslateCodeWS,
            //////////                 MessageTranslateTextWS,
            //////////        GiphyImageCategoryWS,
            //////////              GiphyImageURLWS,
            //////////                 GiphyImageTokenIDWS,
            //////////           DateTimeTextWS,
            //////////         DateTimeWS,
            //////////         DateTextWS,
            //////////          UserDateDayWS,
            //////////         UserDateMonthWS,
            //////////         UserDateYearWS,
            //////////                            DateTimeMilliSecWS);
            return null;//.iRefreshDataAsync();
        }




        public static async Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareUploadImageMessageWSAsync(
                     string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                           string DeviceGlobalIDWS,
                      string AccountTypeWS,
                       string MessageTokenIDWS,
                       string UploadDateTimeMilliSecWS,
                      string GroupIDWS,
                       string ScreenChatShowIDWS,
                       string ScreenChatShowTicketIDWS,
                       string InviteOwnerUserIDWS,
                       string InviteOwnerMobileNumberIDWS,
                      string FromUserIDWS,
                         string FromMobileNumberIDWS,
                        string InviteTagWS,
                         string InviteCodeWS,
                        string MessageCodeWS,
                        string MessageTypeWS,
                      string MessageTextWS,
                                 string MessageOriginalCodeWS,
                           string MessageOriginalTextWS,
                           string MessageTranslateCodeWS,
                           string MessageTranslateTextWS,
                string FileIDWS,
     string FileTitleWS,
    string FileExtensionWS,
    string FileThumWS,
     string FileSizeWS,
    string FileDurationDWS,
                        string ShareFileIDWS,
                           string ShareFileCodeWS,
                               string ShareFileTypeWS,
                               string ShareFileDataWS,
                              string ShareFileURLWS,
                              string ImageIsViewOnlyWS,
                               string ToContactListUserIDWS,
                              string ToContactListMobileNumberIDWS,
                    string DateTimeTextWS,
                   string DateTimeWS,
                   string DateTextWS,
                    string UserDateDayWS,
                   string UserDateMonthWS,
                   string UserDateYearWS,
                                      string DateTimeMilliSecWS)
        {




            try
            {
                //ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_ItemListWS = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                using (var _iClient = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance())
                {

                    string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_ScreenChatShowTextMessageWS.ScreenChatShowMessage_SendScreenChatShowShareUploadImageMessageWS;

                    string _iWebParamWS =
             "PlatformOSIDWS=" + App.iPlatformOS +"&" +
             "DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
             "DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
             "AccountTypeWS=" + App.iAccountType +"&" +


                   "MessageTokenIDWS="   +     MessageTokenIDWS  +  "&" +
                     "UploadDateTimeMilliSecWS="   +     UploadDateTimeMilliSecWS  +  "&" +
                   "GroupIDWS="   +     GroupIDWS  +  "&" +
                   "ScreenChatShowIDWS="   +     ScreenChatShowIDWS  +  "&" +
                     "ScreenChatShowTicketIDWS="   +     ScreenChatShowTicketIDWS  +  "&" +
                      "InviteOwnerUserIDWS="   +     InviteOwnerUserIDWS  +  "&" +
                     "InviteOwnerMobileNumberIDWS="   +     InviteOwnerMobileNumberIDWS  +  "&" +
                      "FromUserIDWS="   +     FromUserIDWS  +  "&" +
                      "FromMobileNumberIDWS="   +     FromMobileNumberIDWS  +  "&" +
                    "InviteTagWS="   +     InviteTagWS  +  "&" +
                      "InviteCodeWS="   +     InviteCodeWS  +  "&" +
                    "MessageCodeWS="   +     MessageCodeWS  +  "&" +
                   "MessageTypeWS="   +     MessageTypeWS  +  "&" +
                    "MessageTextWS="   +     MessageTextWS  +  "&" +
                     "MessageOriginalCodeWS="   +     MessageOriginalCodeWS  +  "&" +
                    "MessageOriginalTextWS="   +     MessageOriginalTextWS  +  "&" +
                     "MessageTranslateCodeWS="   +     MessageTranslateCodeWS  +  "&" +
                     "MessageTranslateTextWS="   +     MessageTranslateTextWS  +  "&" +



                     "FileIDWS="   +   FileIDWS     +  "&" +
                     "FileTitleWS="   +   FileTitleWS     +  "&" +
                     "FileExtensionWS="   +   FileExtensionWS     +  "&" +
                     "FileThumWS="   +   FileThumWS     +  "&" +
                     "FileSizeWS="   +   FileSizeWS     +  "&" +
                     "FileDurationDWS="   +   FileDurationDWS     +  "&" +
                     "ShareFileIDWS="   +   ShareFileIDWS     +  "&" +
                     "ShareFileCodeWS="   +   ShareFileCodeWS     +  "&" +
                     "ShareFileTypeWS="   +   ShareFileTypeWS     +  "&" +
                     "ShareFileDataWS="   +   ShareFileDataWS     +  "&" +
                     "ShareFileURLWS="   +   ShareFileURLWS     +  "&" +
                     "ImageIsViewOnlyWS="   +   ImageIsViewOnlyWS     +  "&" +
                     "ToContactListUserIDWS="   +   ToContactListUserIDWS     +  "&" +
                     "ToContactListMobileNumberIDWS="   +   ToContactListMobileNumberIDWS     +  "&" +








                     "DateTimeTextWS="   +     DateTimeTextWS  +  "&" +
                "DateTimeWS="   +     DateTimeWS  +  "&" +
                "DateTextWS="   +     DateTextWS  +  "&" +
                  "UserDateDayWS="   +     UserDateDayWS  +  "&" +
                 "UserDateMonthWS="   +     UserDateMonthWS  +  "&" +
                "UserDateYearWS="   +     UserDateYearWS  +  "&" +
                  "DateTimeMilliSecWS="   +     DateTimeMilliSecWS;


                    Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

                    _iClient.BaseAddress=  uri;

                    HttpResponseMessage response = await _iClient.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {

                        //SRoofing_DebugManager.Debug_ShowSystemMessage("IsSuccessStatusCode == "+ response.Content.ToString());
                        //arr_ItemListWS= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>>();

                    }


                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }




            //////////     return _iWebServiceWS.SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareUploadImageMessageWSAsync(
            //////////                PlatformOSIDWS,
            //////////                 DatabaseServerTokenIDWS,
            //////////                      DeviceGlobalIDWS,
            //////////                 AccountTypeWS,
            //////////                  MessageTokenIDWS,
            //////////                  UploadDateTimeMilliSecWS,
            //////////                 GroupIDWS,
            //////////                  ScreenChatShowIDWS,
            //////////                  ScreenChatShowTicketIDWS,
            //////////                  InviteOwnerUserIDWS,
            //////////                  InviteOwnerMobileNumberIDWS,
            //////////                 FromUserIDWS,
            //////////                    FromMobileNumberIDWS,
            //////////                   InviteTagWS,
            //////////                    InviteCodeWS,
            //////////                   MessageCodeWS,
            //////////                   MessageTypeWS,
            //////////                 MessageTextWS,
            //////////                            MessageOriginalCodeWS,
            //////////                      MessageOriginalTextWS,
            //////////                      MessageTranslateCodeWS,
            //////////                      MessageTranslateTextWS,
            //////////                                      FileIDWS,
            //////////FileTitleWS,
            //////////FileExtensionWS,
            //////////FileThumWS,
            //////////FileSizeWS,
            //////////FileDurationDWS,
            //////////                   ShareFileIDWS,
            //////////                      ShareFileCodeWS,
            //////////                          ShareFileTypeWS,
            //////////                          ShareFileDataWS,
            //////////                         ShareFileURLWS,
            //////////                         ImageIsViewOnlyWS,
            //////////                          ToContactListUserIDWS,
            //////////                         ToContactListMobileNumberIDWS,
            //////////               DateTimeTextWS,
            //////////              DateTimeWS,
            //////////              DateTextWS,
            //////////               UserDateDayWS,
            //////////              UserDateMonthWS,
            //////////              UserDateYearWS,
            //////////                                 DateTimeMilliSecWS);
            //return null;//.iRefreshDataAsync();
        }




        public static async Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareUploadVideoMessageWSAsync(
                     string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                           string DeviceGlobalIDWS,
                      string AccountTypeWS,
                       string MessageTokenIDWS,
                       string UploadDateTimeMilliSecWS,
                      string GroupIDWS,
                       string ScreenChatShowIDWS,
                       string ScreenChatShowTicketIDWS,
                       string InviteOwnerUserIDWS,
                       string InviteOwnerMobileNumberIDWS,
                      string FromUserIDWS,
                         string FromMobileNumberIDWS,
                        string InviteTagWS,
                         string InviteCodeWS,
                        string MessageCodeWS,
                        string MessageTypeWS,
                      string MessageTextWS,
                                 string MessageOriginalCodeWS,
                           string MessageOriginalTextWS,
                           string MessageTranslateCodeWS,
                           string MessageTranslateTextWS,
                                string FileIDWS,
     string FileTitleWS,
    string FileExtensionWS,
    string FileThumWS,
     string FileSizeWS,
    string FileDurationDWS,
                         string ShareFileIDWS,
                        string ShareFileCodeWS,
                          string ShareFileTypeWS,
                           string ShareFileThumDataWS,
                          string ShareFileDataWS,
                          string ShareFileURLWS,
                          string ShareFileThumURLWS,
                           string VideoIsViewOnlyWS,
                          string ToContactListUserIDWS,
                         string ToContactListMobileNumberIDWS,
                    string DateTimeTextWS,
                   string DateTimeWS,
                   string DateTextWS,
                    string UserDateDayWS,
                   string UserDateMonthWS,
                   string UserDateYearWS,
                                      string DateTimeMilliSecWS)
        {




            try
            {
                //ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_ItemListWS = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                using (var _iClient = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance())
                {

                    string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_ScreenChatShowTextMessageWS.ScreenChatShowMessage_SendScreenChatShowShareUploadVideoMessageWS;

                    string _iWebParamWS =
             "PlatformOSIDWS=" + App.iPlatformOS +"&" +
             "DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
             "DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
             "AccountTypeWS=" + App.iAccountType +"&" +


                   "MessageTokenIDWS="   +     MessageTokenIDWS  +  "&" +
                     "UploadDateTimeMilliSecWS="   +     UploadDateTimeMilliSecWS  +  "&" +
                   "GroupIDWS="   +     GroupIDWS  +  "&" +
                   "ScreenChatShowIDWS="   +     ScreenChatShowIDWS  +  "&" +
                     "ScreenChatShowTicketIDWS="   +     ScreenChatShowTicketIDWS  +  "&" +
                      "InviteOwnerUserIDWS="   +     InviteOwnerUserIDWS  +  "&" +
                     "InviteOwnerMobileNumberIDWS="   +     InviteOwnerMobileNumberIDWS  +  "&" +
                      "FromUserIDWS="   +     FromUserIDWS  +  "&" +
                      "FromMobileNumberIDWS="   +     FromMobileNumberIDWS  +  "&" +
                    "InviteTagWS="   +     InviteTagWS  +  "&" +
                      "InviteCodeWS="   +     InviteCodeWS  +  "&" +
                    "MessageCodeWS="   +     MessageCodeWS  +  "&" +
                   "MessageTypeWS="   +     MessageTypeWS  +  "&" +
                    "MessageTextWS="   +     MessageTextWS  +  "&" +
                     "MessageOriginalCodeWS="   +     MessageOriginalCodeWS  +  "&" +
                    "MessageOriginalTextWS="   +     MessageOriginalTextWS  +  "&" +
                     "MessageTranslateCodeWS="   +     MessageTranslateCodeWS  +  "&" +
                     "MessageTranslateTextWS="   +     MessageTranslateTextWS  +  "&" +



                     "FileIDWS="   +   FileIDWS     +  "&" +
                     "FileTitleWS="   +   FileTitleWS     +  "&" +
                     "FileExtensionWS="   +   FileExtensionWS     +  "&" +
                     "FileThumWS="   +   FileThumWS     +  "&" +
                     "FileSizeWS="   +   FileSizeWS     +  "&" +
                     "FileDurationDWS="   +   FileDurationDWS     +  "&" +
                     "ShareFileIDWS="   +   ShareFileIDWS     +  "&" +
                     "ShareFileCodeWS="   +   ShareFileCodeWS     +  "&" +
                     "ShareFileTypeWS="   +   ShareFileTypeWS     +  "&" +
                     "ShareFileThumDataWS="   +   ShareFileThumDataWS     +  "&" +
                     "ShareFileDataWS="   +   ShareFileDataWS     +  "&" +
                     "ShareFileURLWS="   +   ShareFileURLWS     +  "&" +
                     "ShareFileThumURLWS="   +   ShareFileThumURLWS     +  "&" +
                     "VideoIsViewOnlyWS="   +   VideoIsViewOnlyWS     +  "&" +
                     "ToContactListUserIDWS="   +   ToContactListUserIDWS     +  "&" +
                     "ToContactListMobileNumberIDWS="   +   ToContactListMobileNumberIDWS     +  "&" +








                     "DateTimeTextWS="   +     DateTimeTextWS  +  "&" +
                "DateTimeWS="   +     DateTimeWS  +  "&" +
                "DateTextWS="   +     DateTextWS  +  "&" +
                  "UserDateDayWS="   +     UserDateDayWS  +  "&" +
                 "UserDateMonthWS="   +     UserDateMonthWS  +  "&" +
                "UserDateYearWS="   +     UserDateYearWS  +  "&" +
                  "DateTimeMilliSecWS="   +     DateTimeMilliSecWS;


                    Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

                    _iClient.BaseAddress=  uri;

                    HttpResponseMessage response = await _iClient.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {

                        //SRoofing_DebugManager.Debug_ShowSystemMessage("IsSuccessStatusCode == "+ response.Content.ToString());
                        //arr_ItemListWS= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>>();

                    }


                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }





            //////////     return _iWebServiceWS.SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareUploadVideoMessageWSAsync(
            //////////                PlatformOSIDWS,
            //////////                 DatabaseServerTokenIDWS,
            //////////                      DeviceGlobalIDWS,
            //////////                 AccountTypeWS,
            //////////                  MessageTokenIDWS,
            //////////                  UploadDateTimeMilliSecWS,
            //////////                 GroupIDWS,
            //////////                  ScreenChatShowIDWS,
            //////////                  ScreenChatShowTicketIDWS,
            //////////                  InviteOwnerUserIDWS,
            //////////                  InviteOwnerMobileNumberIDWS,
            //////////                 FromUserIDWS,
            //////////                    FromMobileNumberIDWS,
            //////////                   InviteTagWS,
            //////////                    InviteCodeWS,
            //////////                   MessageCodeWS,
            //////////                   MessageTypeWS,
            //////////                 MessageTextWS,
            //////////                            MessageOriginalCodeWS,
            //////////                      MessageOriginalTextWS,
            //////////                      MessageTranslateCodeWS,
            //////////                      MessageTranslateTextWS,
            //////////                                  FileIDWS,
            //////////FileTitleWS,
            //////////FileExtensionWS,
            //////////FileThumWS,
            //////////FileSizeWS,
            //////////FileDurationDWS,
            //////////                   ShareFileIDWS,
            //////////                   ShareFileCodeWS,
            //////////                     ShareFileTypeWS,
            //////////                      ShareFileThumDataWS,
            //////////                     ShareFileDataWS,
            //////////                     ShareFileURLWS,
            //////////                     ShareFileThumURLWS,
            //////////                      VideoIsViewOnlyWS,
            //////////                     ToContactListUserIDWS,
            //////////                    ToContactListMobileNumberIDWS,
            //////////               DateTimeTextWS,
            //////////              DateTimeWS,
            //////////              DateTextWS,
            //////////               UserDateDayWS,
            //////////              UserDateMonthWS,
            //////////              UserDateYearWS,
            //////////                                 DateTimeMilliSecWS);
            //return null;//.iRefreshDataAsync();
        }




        public Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareVideoYouTubeMessageWSAsync(
                     string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                           string DeviceGlobalIDWS,
                      string AccountTypeWS,
                       string MessageTokenIDWS,
                       string UploadDateTimeMilliSecWS,
                      string GroupIDWS,
                       string ScreenChatShowIDWS,
                       string ScreenChatShowTicketIDWS,
                       string InviteOwnerUserIDWS,
                       string InviteOwnerMobileNumberIDWS,
                      string FromUserIDWS,
                         string FromMobileNumberIDWS,
                        string InviteTagWS,
                         string InviteCodeWS,
                        string MessageCodeWS,
                        string MessageTypeWS,
                      string MessageTextWS,
                                 string MessageOriginalCodeWS,
                           string MessageOriginalTextWS,
                           string MessageTranslateCodeWS,
                           string MessageTranslateTextWS,
                     string ShareFileIDWS,
                          string ShareFileCodeWS,
                              string ShareFileTypeWS,
                               string ShareFileTitleWS,
                               string ShareFileDescriptionWS,
                              string ShareFileURLWS,
                              string ShareFileThumURLWS,
                             string VideoIsViewOnlyWS,
                             string ToContactListUserIDWS,
                             string ToContactListMobileNumberIDWS,
                     string DateTimeTextWS,
                   string DateTimeWS,
                   string DateTextWS,
                    string UserDateDayWS,
                   string UserDateMonthWS,
                   string UserDateYearWS,
                                      string DateTimeMilliSecWS)
        {

            //return _iWebServiceWS.SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareVideoYouTubeMessageWSAsync(
            //           PlatformOSIDWS,
            //            DatabaseServerTokenIDWS,
            //                 DeviceGlobalIDWS,
            //            AccountTypeWS,
            //             MessageTokenIDWS,
            //             UploadDateTimeMilliSecWS,
            //            GroupIDWS,
            //             ScreenChatShowIDWS,
            //             ScreenChatShowTicketIDWS,
            //             InviteOwnerUserIDWS,
            //             InviteOwnerMobileNumberIDWS,
            //            FromUserIDWS,
            //               FromMobileNumberIDWS,
            //              InviteTagWS,
            //               InviteCodeWS,
            //              MessageCodeWS,
            //              MessageTypeWS,
            //            MessageTextWS,
            //                       MessageOriginalCodeWS,
            //                 MessageOriginalTextWS,
            //                 MessageTranslateCodeWS,
            //                 MessageTranslateTextWS,
            //           ShareFileIDWS,
            //                ShareFileCodeWS,
            //                    ShareFileTypeWS,
            //                     ShareFileTitleWS,
            //                     ShareFileDescriptionWS,
            //                    ShareFileURLWS,
            //                    ShareFileThumURLWS,
            //                   VideoIsViewOnlyWS,
            //                   ToContactListUserIDWS,
            //                   ToContactListMobileNumberIDWS,
            //           DateTimeTextWS,
            //         DateTimeWS,
            //         DateTextWS,
            //          UserDateDayWS,
            //         UserDateMonthWS,
            //         UserDateYearWS,
            //                            DateTimeMilliSecWS);
            return null;//.iRefreshDataAsync();
        }




        public static async Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareUploadDocumentMessageWSAsync(
                     string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                           string DeviceGlobalIDWS,
                      string AccountTypeWS,
                       string MessageTokenIDWS,
                       string UploadDateTimeMilliSecWS,
                      string GroupIDWS,
                       string ScreenChatShowIDWS,
                       string ScreenChatShowTicketIDWS,
                       string InviteOwnerUserIDWS,
                       string InviteOwnerMobileNumberIDWS,
                      string FromUserIDWS,
                         string FromMobileNumberIDWS,
                        string InviteTagWS,
                         string InviteCodeWS,
                        string MessageCodeWS,
                        string MessageTypeWS,
                      string MessageTextWS,
                                 string MessageOriginalCodeWS,
                           string MessageOriginalTextWS,
                           string MessageTranslateCodeWS,
                           string MessageTranslateTextWS,
                                string FileIDWS,
     string FileTitleWS,
    string FileExtensionWS,
    string FileThumWS,
     string FileSizeWS,
    string FileDurationDWS,
                          string DateTimeTextWS,
                   string DateTimeWS,
                   string DateTextWS,
                    string UserDateDayWS,
                   string UserDateMonthWS,
                   string UserDateYearWS,
                                      string DateTimeMilliSecWS)
        {




            try
            {
                //ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_ItemListWS = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                using (var _iClient = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance())
                {

                    string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_ScreenChatShowTextMessageWS.ScreenChatShowMessage_SendScreenChatShowShareUploadDocumentMessageWS;

                    string _iWebParamWS =
             "PlatformOSIDWS=" + App.iPlatformOS +"&" +
             "DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
             "DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
             "AccountTypeWS=" + App.iAccountType +"&" +


                   "MessageTokenIDWS="   +     MessageTokenIDWS  +  "&" +
                     "UploadDateTimeMilliSecWS="   +     UploadDateTimeMilliSecWS  +  "&" +
                   "GroupIDWS="   +     GroupIDWS  +  "&" +
                   "ScreenChatShowIDWS="   +     ScreenChatShowIDWS  +  "&" +
                     "ScreenChatShowTicketIDWS="   +     ScreenChatShowTicketIDWS  +  "&" +
                      "InviteOwnerUserIDWS="   +     InviteOwnerUserIDWS  +  "&" +
                     "InviteOwnerMobileNumberIDWS="   +     InviteOwnerMobileNumberIDWS  +  "&" +
                      "FromUserIDWS="   +     FromUserIDWS  +  "&" +
                      "FromMobileNumberIDWS="   +     FromMobileNumberIDWS  +  "&" +
                    "InviteTagWS="   +     InviteTagWS  +  "&" +
                      "InviteCodeWS="   +     InviteCodeWS  +  "&" +
                    "MessageCodeWS="   +     MessageCodeWS  +  "&" +
                   "MessageTypeWS="   +     MessageTypeWS  +  "&" +
                    "MessageTextWS="   +     MessageTextWS  +  "&" +
                     "MessageOriginalCodeWS="   +     MessageOriginalCodeWS  +  "&" +
                    "MessageOriginalTextWS="   +     MessageOriginalTextWS  +  "&" +
                     "MessageTranslateCodeWS="   +     MessageTranslateCodeWS  +  "&" +
                     "MessageTranslateTextWS="   +     MessageTranslateTextWS  +  "&" +



                     "FileIDWS="   +   FileIDWS     +  "&" +
                     "FileTitleWS="   +   FileTitleWS     +  "&" +
                     "FileExtensionWS="   +   FileExtensionWS     +  "&" +
                     "FileThumWS="   +   FileThumWS     +  "&" +
                     "FileSizeWS="   +   FileSizeWS     +  "&" +
                     "FileDurationDWS="   +   FileDurationDWS     +  "&" +
                     //"ShareFileIDWS="   +   ShareFileIDWS     +  "&" +
                     //"ShareFileCodeWS="   +   ShareFileCodeWS     +  "&" +
                     //"ShareFileTypeWS="   +   ShareFileTypeWS     +  "&" +
                     //"ShareFileThumDataWS="   +   ShareFileThumDataWS     +  "&" +
                     //"ShareFileDataWS="   +   ShareFileDataWS     +  "&" +
                     //"ShareFileURLWS="   +   ShareFileURLWS     +  "&" +
                     //"ShareFileThumURLWS="   +   ShareFileThumURLWS     +  "&" +
                     //"VideoIsViewOnlyWS="   +   VideoIsViewOnlyWS     +  "&" +
                     //"ToContactListUserIDWS="   +   ToContactListUserIDWS     +  "&" +
                     //"ToContactListMobileNumberIDWS="   +   ToContactListMobileNumberIDWS     +  "&" +








                     "DateTimeTextWS="   +     DateTimeTextWS  +  "&" +
                "DateTimeWS="   +     DateTimeWS  +  "&" +
                "DateTextWS="   +     DateTextWS  +  "&" +
                  "UserDateDayWS="   +     UserDateDayWS  +  "&" +
                 "UserDateMonthWS="   +     UserDateMonthWS  +  "&" +
                "UserDateYearWS="   +     UserDateYearWS  +  "&" +
                  "DateTimeMilliSecWS="   +     DateTimeMilliSecWS;


                    Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

                    _iClient.BaseAddress=  uri;

                    HttpResponseMessage response = await _iClient.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {

                        //SRoofing_DebugManager.Debug_ShowSystemMessage("IsSuccessStatusCode == "+ response.Content.ToString());
                        //arr_ItemListWS= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>>();

                    }


                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }





            //////////     return _iWebServiceWS.SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareUploadDocumentMessageWSAsync(
            //////////                PlatformOSIDWS,
            //////////                 DatabaseServerTokenIDWS,
            //////////                      DeviceGlobalIDWS,
            //////////                 AccountTypeWS,
            //////////                  MessageTokenIDWS,
            //////////                  UploadDateTimeMilliSecWS,
            //////////                 GroupIDWS,
            //////////                  ScreenChatShowIDWS,
            //////////                  ScreenChatShowTicketIDWS,
            //////////                  InviteOwnerUserIDWS,
            //////////                  InviteOwnerMobileNumberIDWS,
            //////////                 FromUserIDWS,
            //////////                    FromMobileNumberIDWS,
            //////////                   InviteTagWS,
            //////////                    InviteCodeWS,
            //////////                   MessageCodeWS,
            //////////                   MessageTypeWS,
            //////////                 MessageTextWS,
            //////////                            MessageOriginalCodeWS,
            //////////                      MessageOriginalTextWS,
            //////////                      MessageTranslateCodeWS,
            //////////                      MessageTranslateTextWS,
            //////////                                  FileIDWS,
            //////////FileTitleWS,
            //////////FileExtensionWS,
            //////////FileThumWS,
            //////////FileSizeWS,
            //////////FileDurationDWS,
            //////////                    DateTimeTextWS,
            //////////              DateTimeWS,
            //////////              DateTextWS,
            //////////               UserDateDayWS,
            //////////              UserDateMonthWS,
            //////////              UserDateYearWS,
            //////////                                 DateTimeMilliSecWS);
            //return null;//.iRefreshDataAsync();
        }




        public Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareUploadAudioMessageWSAsync(
                     string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                           string DeviceGlobalIDWS,
                      string AccountTypeWS,
                       string MessageTokenIDWS,
                       string UploadDateTimeMilliSecWS,
                      string GroupIDWS,
                       string ScreenChatShowIDWS,
                       string ScreenChatShowTicketIDWS,
                       string InviteOwnerUserIDWS,
                       string InviteOwnerMobileNumberIDWS,
                      string FromUserIDWS,
                         string FromMobileNumberIDWS,
                        string InviteTagWS,
                         string InviteCodeWS,
                        string MessageCodeWS,
                        string MessageTypeWS,
                      string MessageTextWS,
                                 string MessageOriginalCodeWS,
                           string MessageOriginalTextWS,
                           string MessageTranslateCodeWS,
                           string MessageTranslateTextWS,
                                      string FileIDWS,
     string FileTitleWS,
    string FileExtensionWS,
    string FileThumWS,
     string FileSizeWS,
    string FileDurationDWS,
                          string ShareFileIDWS,
                              string ShareFileCodeWS,
                                 string ShareFileTypeWS,
                                 string ShareFileThumDataWS,
                                string ShareFileDataWS,
                                string ShareFileURLWS,
                                string ShareFileThumURLWS,
                                string VideoIsViewOnlyWS,
                                string ToContactListUserIDWS,
                                string ToContactListMobileNumberIDWS,
                   string DateTimeTextWS,
                   string DateTimeWS,
                   string DateTextWS,
                    string UserDateDayWS,
                   string UserDateMonthWS,
                   string UserDateYearWS,
                                      string DateTimeMilliSecWS)
        {

            //     return _iWebServiceWS.SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareUploadAudioMessageWSAsync(
            //                PlatformOSIDWS,
            //                 DatabaseServerTokenIDWS,
            //                      DeviceGlobalIDWS,
            //                 AccountTypeWS,
            //                  MessageTokenIDWS,
            //                  UploadDateTimeMilliSecWS,
            //                 GroupIDWS,
            //                  ScreenChatShowIDWS,
            //                  ScreenChatShowTicketIDWS,
            //                  InviteOwnerUserIDWS,
            //                  InviteOwnerMobileNumberIDWS,
            //                 FromUserIDWS,
            //                    FromMobileNumberIDWS,
            //                   InviteTagWS,
            //                    InviteCodeWS,
            //                   MessageCodeWS,
            //                   MessageTypeWS,
            //                 MessageTextWS,
            //                            MessageOriginalCodeWS,
            //                      MessageOriginalTextWS,
            //                      MessageTranslateCodeWS,
            //                      MessageTranslateTextWS,
            //                                         FileIDWS,
            //FileTitleWS,
            //FileExtensionWS,
            //FileThumWS,
            //FileSizeWS,
            //FileDurationDWS,
            //                   ShareFileIDWS,
            //                         ShareFileCodeWS,
            //                            ShareFileTypeWS,
            //                            ShareFileThumDataWS,
            //                           ShareFileDataWS,
            //                           ShareFileURLWS,
            //                           ShareFileThumURLWS,
            //                           VideoIsViewOnlyWS,
            //                           ToContactListUserIDWS,
            //                           ToContactListMobileNumberIDWS,
            //              DateTimeTextWS,
            //              DateTimeWS,
            //              DateTextWS,
            //               UserDateDayWS,
            //              UserDateMonthWS,
            //              UserDateYearWS,
            //                                 DateTimeMilliSecWS);
            return null;//.iRefreshDataAsync();
        }




        public static async Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareLocationMessageWSAsync(
                     string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                           string DeviceGlobalIDWS,
                      string AccountTypeWS,
                       string MessageTokenIDWS,
                       string UploadDateTimeMilliSecWS,
                      string GroupIDWS,
                       string ScreenChatShowIDWS,
                       string ScreenChatShowTicketIDWS,
                       string InviteOwnerUserIDWS,
                       string InviteOwnerMobileNumberIDWS,
                      string FromUserIDWS,
                         string FromMobileNumberIDWS,
                        string InviteTagWS,
                         string InviteCodeWS,
                        string MessageCodeWS,
                        string MessageTypeWS,
                      string MessageTextWS,
                                 string MessageOriginalCodeWS,
                           string MessageOriginalTextWS,
                           string MessageTranslateCodeWS,
                           string MessageTranslateTextWS,
                   string LocationLongitudeWS,
                       string LocationLatitudeWS,
                         string CountryCodeWS,
                         string CountryNameWS,
                          string StateNameWS,
                         string CityNameWS,
                         string AddressLineWS,
                        string StaticMapURLWS,
                        string ToContactListUserIDWS,
                       string ToContactListMobileNumberIDWS,
                     string DateTimeTextWS,
                   string DateTimeWS,
                   string DateTextWS,
                    string UserDateDayWS,
                   string UserDateMonthWS,
                   string UserDateYearWS,
                                      string DateTimeMilliSecWS)
        {



            try
            {
                //ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_ItemListWS = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                using (var _iClient = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance())
                {

                    string _iWebURLWS = App.SiteDomainAPIWSURL +  SRoofingWS_ScreenChatShowTextMessageWS.ScreenChatShowMessage_SendScreenChatShowShareLocationMessageWS;

                    string _iWebParamWS =
             "PlatformOSIDWS=" + App.iPlatformOS +"&" +
             "DatabaseServerTokenIDWS=" + App.iDatabaseServerTokenID +"&" +
             "DeviceGlobalIDWS=" + Preferences.Get("DeviceGlobalID", "0") +"&" +
             "AccountTypeWS=" + App.iAccountType +"&" +


                   "MessageTokenIDWS="   +     MessageTokenIDWS  +  "&" +
                     "UploadDateTimeMilliSecWS="   +     UploadDateTimeMilliSecWS  +  "&" +
                   "GroupIDWS="   +     GroupIDWS  +  "&" +
                   "ScreenChatShowIDWS="   +     ScreenChatShowIDWS  +  "&" +
                     "ScreenChatShowTicketIDWS="   +     ScreenChatShowTicketIDWS  +  "&" +
                      "InviteOwnerUserIDWS="   +     InviteOwnerUserIDWS  +  "&" +
                     "InviteOwnerMobileNumberIDWS="   +     InviteOwnerMobileNumberIDWS  +  "&" +
                      "FromUserIDWS="   +     FromUserIDWS  +  "&" +
                      "FromMobileNumberIDWS="   +     FromMobileNumberIDWS  +  "&" +
                    "InviteTagWS="   +     InviteTagWS  +  "&" +
                      "InviteCodeWS="   +     InviteCodeWS  +  "&" +
                    "MessageCodeWS="   +     MessageCodeWS  +  "&" +
                   "MessageTypeWS="   +     MessageTypeWS  +  "&" +
                    "MessageTextWS="   +     MessageTextWS  +  "&" +
                     "MessageOriginalCodeWS="   +     MessageOriginalCodeWS  +  "&" +
                    "MessageOriginalTextWS="   +     MessageOriginalTextWS  +  "&" +
                     "MessageTranslateCodeWS="   +     MessageTranslateCodeWS  +  "&" +
                     "MessageTranslateTextWS="   +     MessageTranslateTextWS  +  "&" +



                     "LocationLongitudeWS="   +   LocationLongitudeWS     +  "&" +
                     "LocationLatitudeWS="   +   LocationLatitudeWS     +  "&" +
                     "CountryCodeWS="   +   CountryCodeWS     +  "&" +
                     "CountryNameWS="   +   CountryNameWS     +  "&" +
                     "StateNameWS="   +   StateNameWS     +  "&" +
                     "CityNameWS="   +   CityNameWS     +  "&" +
                     //"ShareFileIDWS="   +   ShareFileIDWS     +  "&" +
                     //"ShareFileCodeWS="   +   ShareFileCodeWS     +  "&" +
                     //"ShareFileTypeWS="   +   ShareFileTypeWS     +  "&" +
                     //"ShareFileThumDataWS="   +   ShareFileThumDataWS     +  "&" +
                     "AddressLineWS="   +   AddressLineWS     +  "&" +
                     "StaticMapURLWS="   +   StaticMapURLWS     +  "&" +
                     //"ShareFileThumURLWS="   +   ShareFileThumURLWS     +  "&" +
                     //"VideoIsViewOnlyWS="   +   VideoIsViewOnlyWS     +  "&" +
                     "ToContactListUserIDWS="   +   ToContactListUserIDWS     +  "&" +
                     "ToContactListMobileNumberIDWS="   +   ToContactListMobileNumberIDWS     +  "&" +








                     "DateTimeTextWS="   +     DateTimeTextWS  +  "&" +
                "DateTimeWS="   +     DateTimeWS  +  "&" +
                "DateTextWS="   +     DateTextWS  +  "&" +
                  "UserDateDayWS="   +     UserDateDayWS  +  "&" +
                 "UserDateMonthWS="   +     UserDateMonthWS  +  "&" +
                "UserDateYearWS="   +     UserDateYearWS  +  "&" +
                  "DateTimeMilliSecWS="   +     DateTimeMilliSecWS;


                    Uri uri = new Uri(_iWebURLWS + _iWebParamWS);

                    _iClient.BaseAddress=  uri;

                    HttpResponseMessage response = await _iClient.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {

                        //SRoofing_DebugManager.Debug_ShowSystemMessage("IsSuccessStatusCode == "+ response.Content.ToString());
                        //arr_ItemListWS= await response.Content.ReadFromJsonAsync<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>>();

                    }


                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }






            //////////return _iWebServiceWS.SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareLocationMessageWSAsync(
            //////////           PlatformOSIDWS,
            //////////            DatabaseServerTokenIDWS,
            //////////                 DeviceGlobalIDWS,
            //////////            AccountTypeWS,
            //////////             MessageTokenIDWS,
            //////////             UploadDateTimeMilliSecWS,
            //////////            GroupIDWS,
            //////////             ScreenChatShowIDWS,
            //////////             ScreenChatShowTicketIDWS,
            //////////             InviteOwnerUserIDWS,
            //////////             InviteOwnerMobileNumberIDWS,
            //////////            FromUserIDWS,
            //////////               FromMobileNumberIDWS,
            //////////              InviteTagWS,
            //////////               InviteCodeWS,
            //////////              MessageCodeWS,
            //////////              MessageTypeWS,
            //////////            MessageTextWS,
            //////////                       MessageOriginalCodeWS,
            //////////                 MessageOriginalTextWS,
            //////////                 MessageTranslateCodeWS,
            //////////                 MessageTranslateTextWS,
            //////////         LocationLongitudeWS,
            //////////             LocationLatitudeWS,
            //////////               CountryCodeWS,
            //////////               CountryNameWS,
            //////////                StateNameWS,
            //////////               CityNameWS,
            //////////               AddressLineWS,
            //////////              StaticMapURLWS,
            //////////              ToContactListUserIDWS,
            //////////             ToContactListMobileNumberIDWS,
            //////////           DateTimeTextWS,
            //////////         DateTimeWS,
            //////////         DateTextWS,
            //////////          UserDateDayWS,
            //////////         UserDateMonthWS,
            //////////         UserDateYearWS,
            //////////                            DateTimeMilliSecWS);
            //return null;//.iRefreshDataAsync();
        }




        public Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareStickerMessageWSAsync(
                     string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                           string DeviceGlobalIDWS,
                      string AccountTypeWS,
                       string MessageTokenIDWS,
                       string UploadDateTimeMilliSecWS,
                      string GroupIDWS,
                       string ScreenChatShowIDWS,
                       string ScreenChatShowTicketIDWS,
                       string InviteOwnerUserIDWS,
                       string InviteOwnerMobileNumberIDWS,
                      string FromUserIDWS,
                         string FromMobileNumberIDWS,
                        string InviteTagWS,
                         string InviteCodeWS,
                        string MessageCodeWS,
                        string MessageTypeWS,
                      string MessageTextWS,
                                 string MessageOriginalCodeWS,
                           string MessageOriginalTextWS,
                           string MessageTranslateCodeWS,
                           string MessageTranslateTextWS,
                   string DateTimeTextWS,
                   string DateTimeWS,
                   string DateTextWS,
                    string UserDateDayWS,
                   string UserDateMonthWS,
                   string UserDateYearWS,
                                      string DateTimeMilliSecWS)
        {

            //////////return _iWebServiceWS.SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareStickerMessageWSAsync(
            //////////           PlatformOSIDWS,
            //////////            DatabaseServerTokenIDWS,
            //////////                 DeviceGlobalIDWS,
            //////////            AccountTypeWS,
            //////////             MessageTokenIDWS,
            //////////             UploadDateTimeMilliSecWS,
            //////////            GroupIDWS,
            //////////             ScreenChatShowIDWS,
            //////////             ScreenChatShowTicketIDWS,
            //////////             InviteOwnerUserIDWS,
            //////////             InviteOwnerMobileNumberIDWS,
            //////////            FromUserIDWS,
            //////////               FromMobileNumberIDWS,
            //////////              InviteTagWS,
            //////////               InviteCodeWS,
            //////////              MessageCodeWS,
            //////////              MessageTypeWS,
            //////////            MessageTextWS,
            //////////                       MessageOriginalCodeWS,
            //////////                 MessageOriginalTextWS,
            //////////                 MessageTranslateCodeWS,
            //////////                 MessageTranslateTextWS,
            //////////         DateTimeTextWS,
            //////////         DateTimeWS,
            //////////         DateTextWS,
            //////////          UserDateDayWS,
            //////////         UserDateMonthWS,
            //////////         UserDateYearWS,
            //////////                            DateTimeMilliSecWS);
            return null;//.iRefreshDataAsync();
        }


        #endregion


    }
}
