using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Category;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager
{
    public interface ISRoofing_UserProfileWS
    {

        //<ObservableCollection<SRoofingLogisticsStaffModelManager>>
        Task<ObservableCollection<SRoofingUserOwnerModelManager>> SRoofing_XFMobile_UserProfile_Get_Owner_Profile_ByAccountTypeWSAsync(
                               string PlatformOSIDWS,
                      string DatabaseServerTokenIDWS,
                              string DeviceGlobalIDWS,
                     string AccountTypeWS,
                      string OwnerUserTokenIDWS,
                         string OwnerMobileNumberTokenIDWS);



        Task<ObservableCollection<SRoofingUserRemoteModelManager>> SRoofing_XFMobile_UserProfile_Get_Remote_Profile_ByAccountTypeWSAsync(
                            string PlatformOSIDWS,
                   string DatabaseServerTokenIDWS,
                           string DeviceGlobalIDWS,
                  string AccountTypeWS,
                   string OwnerUserTokenIDWS,
                      string OwnerMobileNumberTokenIDWS,
                   string RemoteUserIDWS,
                     string RemoteMobileNumberIDWS);


    }

}
