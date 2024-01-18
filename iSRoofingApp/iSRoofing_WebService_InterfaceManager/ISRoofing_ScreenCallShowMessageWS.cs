 
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager
    {
    public interface ISRoofing_ScreenCallShowMessageWS
        {

        //<ObservableCollection<SRoofingLogisticsStaffModelManager>>
        Task<ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>> SRoofing_ScreenCallShow_Get_List_All_Call_ByOwnerUserTokenIDWSAsync (
                               string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                              string DeviceGlobalIDWS ,
                     string AccountTypeWS ,
                      string OwnerUserTokenIDWS ,
                         string OwnerMobileNumberTokenIDWS ,
                      string ApplicationRoleCodeWS ,
                       string ProjectTokenIDWS ,
                        string iTodayDayWS ,
                      string iTodayMonthWS ,
                        string iTodayYearWS ,
                      string IsHistoryMessageLineWS );

        }
    }
