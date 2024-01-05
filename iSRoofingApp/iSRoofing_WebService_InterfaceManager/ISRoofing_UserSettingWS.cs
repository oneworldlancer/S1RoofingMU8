using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager
{
    public interface ISRoofing_UserSettingWS
    {

        //<ObservableCollection<SRoofingLogisticsStaffModelManager>>
        Task SRoofing_XFMobile_UserSetting_Initialize_Setting_ByOwnerUserTokenIDWSAsync (
            string PlatformOSIDWS ,
            string DatabaseServerTokenIDWS ,
            string DeviceGlobalIDWS ,
            string AccountTypeWS ,
   string UserIDWS ,
                          string MobileNumberIDWS );


        //<ObservableCollection<SRoofingLogisticsStaffModelManager>>   
        Task<ObservableCollection<SRoofingUserSettingModelManager>> SRoofing_XFMobile_UserSetting_Get_Setting_ByOwnerUserTokenIDWSAsync (
            string PlatformOSIDWS ,
            string DatabaseServerTokenIDWS ,
            string DeviceGlobalIDWS ,
            string AccountTypeWS ,
   string UserIDWS ,
                          string MobileNumberIDWS );







        //<ObservableCollection<SRoofingLogisticsStaffModelManager>>
        Task SRoofing_XFMobile_UserSetting_Reset_Setting_ByOwnerUserTokenIDWSAsync (
            string PlatformOSIDWS ,
            string DatabaseServerTokenIDWS ,
            string DeviceGlobalIDWS ,
            string AccountTypeWS ,
   string UserIDWS ,
                          string MobileNumberIDWS );





    }
}
