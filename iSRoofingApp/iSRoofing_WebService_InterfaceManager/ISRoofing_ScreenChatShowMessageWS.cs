using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager
{
    public interface ISRoofing_ScreenChatShowMessageWS
    {

        //<ObservableCollection<SRoofingLogisticsStaffModelManager>>
        Task<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>> SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWSAsync(

            SRoofingUserOwnerModelManager iOwnerModel,

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
                      string IsHistoryMessageLineWS);

    }
}
