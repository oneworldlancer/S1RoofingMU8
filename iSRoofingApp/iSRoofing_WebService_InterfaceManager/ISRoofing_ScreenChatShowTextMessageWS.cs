
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Category;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager
{
    public interface ISRoofing_ScreenChatShowTextMessageWS
    {

        //<ObservableCollection<SRoofingLogisticsStaffModelManager>>
        Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowTextMessageWSAsync (
                              string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                              string DeviceGlobalIDWS ,
                      string AccountTypeWS ,
                   string MessageTokenIDWS ,
                   string UploadDateTimeMilliSecWS ,
                    string GroupIDWS ,
                   string ScreenChatShowIDWS ,
                  string ScreenChatShowTicketIDWS ,
                   string InviteOwnerUserIDWS ,
                     string InviteOwnerMobileNumberIDWS ,
                    string FromUserIDWS ,
                     string FromMobileNumberIDWS ,
                    string InviteTagWS ,
                    string InviteCodeWS ,
                     string MessageCodeWS ,
                     string MessageTypeWS ,
                   string MessageTextWS ,
                             string MessageOriginalCodeWS ,
                           string MessageOriginalTextWS ,
                           string MessageTranslateCodeWS ,
                           string MessageTranslateTextWS ,
                   string DateTimeTextWS ,
               string DateTimeWS ,
                string DateTextWS ,
                string UserDateDayWS ,
                string UserDateMonthWS ,
               string UserDateYearWS ,
                     string DateTimeMilliSecWS );



        Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowTextTranslateMessageWSAsync (
                                     string PlatformOSIDWS ,
                       string DatabaseServerTokenIDWS ,
                              string DeviceGlobalIDWS ,
                     string AccountTypeWS ,
                        string MessageTokenIDWS ,
                       string UploadDateTimeMilliSecWS ,
                      string GroupIDWS ,
                        string ScreenChatShowIDWS ,
                       string ScreenChatShowTicketIDWS ,
                       string InviteOwnerUserIDWS ,
                      string InviteOwnerMobileNumberIDWS ,
                      string FromUserIDWS ,
                        string FromMobileNumberIDWS ,
                      string InviteTagWS ,
                        string InviteCodeWS ,
                        string MessageCodeWS ,
                        string MessageTypeWS ,
                      string MessageTextWS ,
                            string MessageOriginalCodeWS ,
                           string MessageOriginalTextWS ,
                           string MessageTranslateCodeWS ,
                           string MessageTranslateTextWS ,
                    string DateTimeTextWS ,
                  string DateTimeWS ,
                  string DateTextWS ,
                   string UserDateDayWS ,
                    string UserDateMonthWS ,
                    string UserDateYearWS ,
                                    string DateTimeMilliSecWS );




        Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareEmotionMessageWSAsync (
                     string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                           string DeviceGlobalIDWS ,
                      string AccountTypeWS ,
                       string MessageTokenIDWS ,
                       string UploadDateTimeMilliSecWS ,
                      string GroupIDWS ,
                       string ScreenChatShowIDWS ,
                       string ScreenChatShowTicketIDWS ,
                       string InviteOwnerUserIDWS ,
                       string InviteOwnerMobileNumberIDWS ,
                      string FromUserIDWS ,
                         string FromMobileNumberIDWS ,
                        string InviteTagWS ,
                         string InviteCodeWS ,
                        string MessageCodeWS ,
                        string MessageTypeWS ,
                      string MessageTextWS ,
                                 string MessageOriginalCodeWS ,
                           string MessageOriginalTextWS ,
                           string MessageTranslateCodeWS ,
                           string MessageTranslateTextWS ,
                   string DateTimeTextWS ,
                   string DateTimeWS ,
                   string DateTextWS ,
                    string UserDateDayWS ,
                   string UserDateMonthWS ,
                   string UserDateYearWS ,
                                      string DateTimeMilliSecWS );






        Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareGiphyMessageWSAsync (
                     string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                           string DeviceGlobalIDWS ,
                      string AccountTypeWS ,
                       string MessageTokenIDWS ,
                       string UploadDateTimeMilliSecWS ,
                      string GroupIDWS ,
                       string ScreenChatShowIDWS ,
                       string ScreenChatShowTicketIDWS ,
                       string InviteOwnerUserIDWS ,
                       string InviteOwnerMobileNumberIDWS ,
                      string FromUserIDWS ,
                         string FromMobileNumberIDWS ,
                        string InviteTagWS ,
                         string InviteCodeWS ,
                        string MessageCodeWS ,
                        string MessageTypeWS ,
                      string MessageTextWS ,
                                 string MessageOriginalCodeWS ,
                           string MessageOriginalTextWS ,
                           string MessageTranslateCodeWS ,
                           string MessageTranslateTextWS ,
                  string GiphyImageCategoryWS ,
                        string GiphyImageURLWS ,
                           string GiphyImageTokenIDWS ,
                     string DateTimeTextWS ,
                   string DateTimeWS ,
                   string DateTextWS ,
                    string UserDateDayWS ,
                   string UserDateMonthWS ,
                   string UserDateYearWS ,
                                      string DateTimeMilliSecWS );






        Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareUploadImageMessageWSAsync (
                     string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                           string DeviceGlobalIDWS ,
                      string AccountTypeWS ,
                       string MessageTokenIDWS ,
                       string UploadDateTimeMilliSecWS ,
                      string GroupIDWS ,
                       string ScreenChatShowIDWS ,
                       string ScreenChatShowTicketIDWS ,
                       string InviteOwnerUserIDWS ,
                       string InviteOwnerMobileNumberIDWS ,
                      string FromUserIDWS ,
                         string FromMobileNumberIDWS ,
                        string InviteTagWS ,
                         string InviteCodeWS ,
                        string MessageCodeWS ,
                        string MessageTypeWS ,
                      string MessageTextWS ,
                                 string MessageOriginalCodeWS ,
                           string MessageOriginalTextWS ,
                           string MessageTranslateCodeWS ,
                           string MessageTranslateTextWS ,
                                    string FileIDWS ,
     string FileTitleWS ,
    string FileExtensionWS ,
    string FileThumWS ,
     string FileSizeWS ,
    string FileDurationDWS ,
                         string ShareFileIDWS ,
                           string ShareFileCodeWS ,
                               string ShareFileTypeWS ,
                               string ShareFileDataWS ,
                              string ShareFileURLWS ,
                              string ImageIsViewOnlyWS ,
                               string ToContactListUserIDWS ,
                              string ToContactListMobileNumberIDWS ,
                    string DateTimeTextWS ,
                   string DateTimeWS ,
                   string DateTextWS ,
                    string UserDateDayWS ,
                   string UserDateMonthWS ,
                   string UserDateYearWS ,
                                      string DateTimeMilliSecWS );






        Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareUploadVideoMessageWSAsync (
                     string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                           string DeviceGlobalIDWS ,
                      string AccountTypeWS ,
                       string MessageTokenIDWS ,
                       string UploadDateTimeMilliSecWS ,
                      string GroupIDWS ,
                       string ScreenChatShowIDWS ,
                       string ScreenChatShowTicketIDWS ,
                       string InviteOwnerUserIDWS ,
                       string InviteOwnerMobileNumberIDWS ,
                      string FromUserIDWS ,
                         string FromMobileNumberIDWS ,
                        string InviteTagWS ,
                         string InviteCodeWS ,
                        string MessageCodeWS ,
                        string MessageTypeWS ,
                      string MessageTextWS ,
                                 string MessageOriginalCodeWS ,
                           string MessageOriginalTextWS ,
                           string MessageTranslateCodeWS ,
                           string MessageTranslateTextWS ,
                               string FileIDWS ,
     string FileTitleWS ,
    string FileExtensionWS ,
    string FileThumWS ,
     string FileSizeWS ,
    string FileDurationDWS ,
                          string ShareFileIDWS ,
                        string ShareFileCodeWS ,
                          string ShareFileTypeWS ,
                           string ShareFileThumDataWS ,
                          string ShareFileDataWS ,
                          string ShareFileURLWS ,
                          string ShareFileThumURLWS ,
                           string VideoIsViewOnlyWS ,
                          string ToContactListUserIDWS ,
                         string ToContactListMobileNumberIDWS ,
                    string DateTimeTextWS ,
                   string DateTimeWS ,
                   string DateTextWS ,
                    string UserDateDayWS ,
                   string UserDateMonthWS ,
                   string UserDateYearWS ,
                                      string DateTimeMilliSecWS );






        Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareVideoYouTubeMessageWSAsync (
                     string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                           string DeviceGlobalIDWS ,
                      string AccountTypeWS ,
                       string MessageTokenIDWS ,
                       string UploadDateTimeMilliSecWS ,
                      string GroupIDWS ,
                       string ScreenChatShowIDWS ,
                       string ScreenChatShowTicketIDWS ,
                       string InviteOwnerUserIDWS ,
                       string InviteOwnerMobileNumberIDWS ,
                      string FromUserIDWS ,
                         string FromMobileNumberIDWS ,
                        string InviteTagWS ,
                         string InviteCodeWS ,
                        string MessageCodeWS ,
                        string MessageTypeWS ,
                      string MessageTextWS ,
                                 string MessageOriginalCodeWS ,
                           string MessageOriginalTextWS ,
                           string MessageTranslateCodeWS ,
                           string MessageTranslateTextWS ,
                     string ShareFileIDWS ,
                          string ShareFileCodeWS ,
                              string ShareFileTypeWS ,
                               string ShareFileTitleWS ,
                               string ShareFileDescriptionWS ,
                              string ShareFileURLWS ,
                              string ShareFileThumURLWS ,
                             string VideoIsViewOnlyWS ,
                             string ToContactListUserIDWS ,
                             string ToContactListMobileNumberIDWS ,
                     string DateTimeTextWS ,
                   string DateTimeWS ,
                   string DateTextWS ,
                    string UserDateDayWS ,
                   string UserDateMonthWS ,
                   string UserDateYearWS ,
                                      string DateTimeMilliSecWS );






        Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareUploadDocumentMessageWSAsync (
                     string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                           string DeviceGlobalIDWS ,
                      string AccountTypeWS ,
                       string MessageTokenIDWS ,
                       string UploadDateTimeMilliSecWS ,
                      string GroupIDWS ,
                       string ScreenChatShowIDWS ,
                       string ScreenChatShowTicketIDWS ,
                       string InviteOwnerUserIDWS ,
                       string InviteOwnerMobileNumberIDWS ,
                      string FromUserIDWS ,
                         string FromMobileNumberIDWS ,
                        string InviteTagWS ,
                         string InviteCodeWS ,
                        string MessageCodeWS ,
                        string MessageTypeWS ,
                      string MessageTextWS ,
                                 string MessageOriginalCodeWS ,
                           string MessageOriginalTextWS ,
                           string MessageTranslateCodeWS ,
                           string MessageTranslateTextWS ,
                                string FileIDWS ,
     string FileTitleWS ,
    string FileExtensionWS ,
    string FileThumWS ,
     string FileSizeWS ,
    string FileDurationDWS ,
                          string DateTimeTextWS ,
                   string DateTimeWS ,
                   string DateTextWS ,
                    string UserDateDayWS ,
                   string UserDateMonthWS ,
                   string UserDateYearWS ,
                                      string DateTimeMilliSecWS );






        Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareUploadAudioMessageWSAsync (
                     string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                           string DeviceGlobalIDWS ,
                      string AccountTypeWS ,
                       string MessageTokenIDWS ,
                       string UploadDateTimeMilliSecWS ,
                      string GroupIDWS ,
                       string ScreenChatShowIDWS ,
                       string ScreenChatShowTicketIDWS ,
                       string InviteOwnerUserIDWS ,
                       string InviteOwnerMobileNumberIDWS ,
                      string FromUserIDWS ,
                         string FromMobileNumberIDWS ,
                        string InviteTagWS ,
                         string InviteCodeWS ,
                        string MessageCodeWS ,
                        string MessageTypeWS ,
                      string MessageTextWS ,
                                 string MessageOriginalCodeWS ,
                           string MessageOriginalTextWS ,
                           string MessageTranslateCodeWS ,
                           string MessageTranslateTextWS ,
                                      string FileIDWS ,
     string FileTitleWS ,
    string FileExtensionWS ,
    string FileThumWS ,
     string FileSizeWS ,
    string FileDurationDWS ,
                          string ShareFileIDWS ,
                              string ShareFileCodeWS ,
                                 string ShareFileTypeWS ,
                                 string ShareFileThumDataWS ,
                                string ShareFileDataWS ,
                                string ShareFileURLWS ,
                                string ShareFileThumURLWS ,
                                string VideoIsViewOnlyWS ,
                                string ToContactListUserIDWS ,
                                string ToContactListMobileNumberIDWS ,
                   string DateTimeTextWS ,
                   string DateTimeWS ,
                   string DateTextWS ,
                    string UserDateDayWS ,
                   string UserDateMonthWS ,
                   string UserDateYearWS ,
                                      string DateTimeMilliSecWS );







        Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareLocationMessageWSAsync (
                     string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                           string DeviceGlobalIDWS ,
                      string AccountTypeWS ,
                       string MessageTokenIDWS ,
                       string UploadDateTimeMilliSecWS ,
                      string GroupIDWS ,
                       string ScreenChatShowIDWS ,
                       string ScreenChatShowTicketIDWS ,
                       string InviteOwnerUserIDWS ,
                       string InviteOwnerMobileNumberIDWS ,
                      string FromUserIDWS ,
                         string FromMobileNumberIDWS ,
                        string InviteTagWS ,
                         string InviteCodeWS ,
                        string MessageCodeWS ,
                        string MessageTypeWS ,
                      string MessageTextWS ,
                                 string MessageOriginalCodeWS ,
                           string MessageOriginalTextWS ,
                           string MessageTranslateCodeWS ,
                           string MessageTranslateTextWS ,
                   string LocationLongitudeWS ,
                       string LocationLatitudeWS ,
                         string CountryCodeWS ,
                         string CountryNameWS ,
                          string StateNameWS ,
                         string CityNameWS ,
                         string AddressLineWS ,
                        string StaticMapURLWS ,
                        string ToContactListUserIDWS ,
                       string ToContactListMobileNumberIDWS ,
                     string DateTimeTextWS ,
                   string DateTimeWS ,
                   string DateTextWS ,
                    string UserDateDayWS ,
                   string UserDateMonthWS ,
                   string UserDateYearWS ,
                                      string DateTimeMilliSecWS );






        Task SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareStickerMessageWSAsync (
                     string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                           string DeviceGlobalIDWS ,
                      string AccountTypeWS ,
                       string MessageTokenIDWS ,
                       string UploadDateTimeMilliSecWS ,
                      string GroupIDWS ,
                       string ScreenChatShowIDWS ,
                       string ScreenChatShowTicketIDWS ,
                       string InviteOwnerUserIDWS ,
                       string InviteOwnerMobileNumberIDWS ,
                      string FromUserIDWS ,
                         string FromMobileNumberIDWS ,
                        string InviteTagWS ,
                         string InviteCodeWS ,
                        string MessageCodeWS ,
                        string MessageTypeWS ,
                      string MessageTextWS ,
                                 string MessageOriginalCodeWS ,
                           string MessageOriginalTextWS ,
                           string MessageTranslateCodeWS ,
                           string MessageTranslateTextWS ,
                   string DateTimeTextWS ,
                   string DateTimeWS ,
                   string DateTextWS ,
                    string UserDateDayWS ,
                   string UserDateMonthWS ,
                   string UserDateYearWS ,
                                      string DateTimeMilliSecWS );





        //       Task Logistics_XFMobile_UserRegister_New_ByAccountTypeWSAsync (
        //         string PlatformOSIDWS ,
        //         string DatabaseServerTokenIDWS ,
        //         string DeviceGlobalIDWS ,
        //         string AccountTypeWS ,
        //string MembershipTypeWS ,
        //                       string GCMIDWS ,
        //                       string CountryISOCodeWS ,
        //                       string CountryNameWS ,
        //                       string CountryCodeWS ,
        //                       string CityNameWS ,
        //                       string CountryMobileCodeWS ,
        //                       string MobileNumberE164WS ,
        //                      string MobileCodeWS ,
        //                       string FirstNameWS ,
        //                      string LastNameWS ,
        //                      string BirthDayWS ,
        //                     string BirthMonthWS ,
        //                       string BirthYearWS ,
        //                       string GenderWS ,
        //                       string PasswordWS ,
        //                       string EmailAddressWS ,
        //                       string ListUserMobileNumberE164WS ,
        //                       string LocationLatitudeWS ,
        //                      string LocationLongitudeWS ,
        //                      string UploadDateTimeMilliSecWS );


    }
}
