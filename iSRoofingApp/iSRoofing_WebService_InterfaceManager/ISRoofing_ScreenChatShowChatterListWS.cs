
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Category;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager
    {
    public interface ISRoofing_ScreenChatShowChatterListWS
    {

        //<ObservableCollection<SRoofingLogisticsStaffModelManager>>
        Task<ObservableCollection<SRoofingUserRemoteModelManager>> SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWSAsync (
                               string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                              string DeviceGlobalIDWS ,
                     string AccountTypeWS ,
                       string GroupIDWS ,
                           string ScreenChatShowIDWS  ,
                           string ScreenChatShowTicketIDWS  ,
                           string OwnerUserTokenIDWS ,
                         string OwnerMobileNumberTokenIDWS   );


  //Task<ObservableCollection<SRoofingUserRemoteModelManager>> SRoofing_XFMobile_UserContactFriend_Get_List_Alphabet_Index_AccountTypeWSAsync(
  //                             string PlatformOSIDWS ,
  //                    string DatabaseServerTokenIDWS ,
  //                            string DeviceGlobalIDWS ,
  //                   string AccountTypeWS ,
  //                    string OwnerUserTokenIDWS ,
  //                       string OwnerMobileNumberTokenIDWS ,               
  //                       string IndexIDWS );





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
