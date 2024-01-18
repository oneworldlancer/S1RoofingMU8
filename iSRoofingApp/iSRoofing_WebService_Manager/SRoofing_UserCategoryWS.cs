using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Category;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager
{
	public class SRoofing_UserCategoryWS
        {
        ISRoofing_UserCategoryWS _iWebServiceWS;

		public SRoofing_UserCategoryWS ( ISRoofing_UserCategoryWS iWebServiceWS )
		{
			_iWebServiceWS = iWebServiceWS;
		}

        #region Get_List


        public Task<ObservableCollection<SRoofingCategoryModelManager>> SRoofing_XFMobile_UserCategory_Get_List_ByOwnerUserTokenIDWSAsync (
                               string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                              string DeviceGlobalIDWS ,
                     string AccountTypeWS ,
                      string OwnerUserTokenIDWS ,
                         string OwnerMobileNumberTokenIDWS )
            {
        
            return _iWebServiceWS.SRoofing_XFMobile_UserCategory_Get_List_ByOwnerUserTokenIDWSAsync (
                                 PlatformOSIDWS ,
                        DatabaseServerTokenIDWS ,
                                DeviceGlobalIDWS ,
                       AccountTypeWS ,
                        OwnerUserTokenIDWS ,
                           OwnerMobileNumberTokenIDWS );
            //return null;//.iRefreshDataAsync();
            }



        //<ObservableCollection<SRoofingLogisticsStaffModelManager>> 
        //public Task Task<ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>> SRoofing_ScreenCallShow_Get_List_All_Call_ByOwnerUserTokenIDWSAsync (
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

        //    return _iWebServiceWS.SRoofing_ScreenCallShow_Get_List_All_Call_ByOwnerUserTokenIDWSAsync (
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
