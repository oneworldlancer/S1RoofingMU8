using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager
{
    public class SRoofing_UserProfileWS
    {
        ISRoofing_UserProfileWS _iWebServiceWS;

        public SRoofing_UserProfileWS(ISRoofing_UserProfileWS iWebServiceWS)
        {
            _iWebServiceWS = iWebServiceWS;
        }

        #region Get_List
        //<ObservableCollection<SRoofingLogisticsStaffModelManager>> 


        public Task<ObservableCollection<SRoofingUserOwnerModelManager>> SRoofing_XFMobile_UserProfile_Get_Owner_Profile_ByAccountTypeWSAsync(
                               string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                              string DeviceGlobalIDWS,
                     string AccountTypeWS,
                      string OwnerUserTokenIDWS,
                         string OwnerMobileNumberTokenIDWS)
        {
            return _iWebServiceWS.SRoofing_XFMobile_UserProfile_Get_Owner_Profile_ByAccountTypeWSAsync(
            PlatformOSIDWS,
                        DatabaseServerTokenIDWS,
                                DeviceGlobalIDWS,
                       AccountTypeWS,
                        OwnerUserTokenIDWS,
                           OwnerMobileNumberTokenIDWS);

        }




        public Task<ObservableCollection<SRoofingUserRemoteModelManager>> SRoofing_XFMobile_UserProfile_Get_Remote_Profile_ByAccountTypeWSAsync(
                                                   string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                              string DeviceGlobalIDWS,
                     string AccountTypeWS,
                      string OwnerUserTokenIDWS,
                         string OwnerMobileNumberTokenIDWS,
                      string RemoteUserIDWS,
                        string RemoteMobileNumberIDWS)
        {
            return _iWebServiceWS.SRoofing_XFMobile_UserProfile_Get_Remote_Profile_ByAccountTypeWSAsync(
            PlatformOSIDWS,
                        DatabaseServerTokenIDWS,
                                DeviceGlobalIDWS,
                       AccountTypeWS,
                        OwnerUserTokenIDWS,
                           OwnerMobileNumberTokenIDWS,
                           RemoteUserIDWS,
                        RemoteMobileNumberIDWS);
            //return null;//.iRefreshDataAsync();
        }


        #endregion


    }
}
