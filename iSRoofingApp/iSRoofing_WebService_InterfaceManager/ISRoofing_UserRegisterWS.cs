using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager
    {
    public interface ISRoofing_UserRegisterWS
        {

        //<ObservableCollection<SRoofingLogisticsStaffModelManager>>
        Task SRoofing_XFMobile_UserRegister_New_UserAccountWSAsync (
            string PlatformOSIDWS ,
            string DatabaseServerTokenIDWS ,
            string DeviceGlobalIDWS ,
            string AccountTypeWS ,
   //string MembershipTypeWS ,
                          string GCMIDWS ,
                          string CountryISOCodeWS ,
                          string CountryNameWS ,
                          string CountryCodeWS ,
                          string CityNameWS ,
                          string CountryMobileCodeWS ,
                          string MobileNumberE164WS ,
                         string MobileCodeWS ,
                          string FirstNameWS ,
                         string LastNameWS ,
                         string BirthDayWS ,
                        string BirthMonthWS ,
                          string BirthYearWS ,
                          string GenderWS ,
                          string PasswordWS ,
                          string EmailAddressWS ,
                          string ListUserMobileNumberE164WS ,
                          string LocationLatitudeWS ,
                         string LocationLongitudeWS ,
                         string UploadDateTimeMilliSecWS );

        }
    }
