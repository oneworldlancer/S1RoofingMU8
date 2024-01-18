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
    public interface ISRoofing_UserGroupWS
        {

        //<ObservableCollection<SRoofingLogisticsStaffModelManager>>
        Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_Group_ByGroupTokenIDWSAsync(
                               string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                              string DeviceGlobalIDWS ,
                     string AccountTypeWS ,
                      string OwnerUserTokenIDWS ,
                         string OwnerMobileNumberTokenIDWS ,
                         string GroupTokenIDWS);



           Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserCategory_Get_GroupList_ByCategoryTokenIDWSAsync (
                               string PlatformOSIDWS ,
                      string DatabaseServerTokenIDWS ,
                              string DeviceGlobalIDWS ,
                     string AccountTypeWS ,
                      string OwnerUserTokenIDWS ,
                         string OwnerMobileNumberTokenIDWS ,
                         string CategoryTokenIDWS );



        Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_List_All_ByAlphabetIndexWSAsync (
                   string PlatformOSIDWS ,
      string DatabaseServerTokenIDWS ,
       string DeviceGlobalIDWS ,
       string AccountTypeWS ,
                 string UserIDWS ,
                 string MobileNumberIDWS ,
               string iCharacterWS ,
                string IndexIDWS );





        Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_List_Private_ByAlphabetIndexWSAsync (
             string PlatformOSIDWS ,
       string DatabaseServerTokenIDWS ,
      string DeviceGlobalIDWS ,
    string AccountTypeWS ,
            string UserIDWS ,
            string MobileNumberIDWS ,
         string iCharacterWS ,
           string IndexIDWS );





        Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_List_Private_Filter_Chatter_ByAlphabetIndexWSAsync (
                 string PlatformOSIDWS ,
      string DatabaseServerTokenIDWS ,
      string DeviceGlobalIDWS ,
     string AccountTypeWS ,
             string UserIDWS ,
            string MobileNumberIDWS ,
            string GroupTokenIDWS ,
             string iCharacterWS ,
             string IndexIDWS );




        Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_List_All_Alphabet_Index_AccountTypeWSAsync (
          string PlatformOSIDWS ,
      string DatabaseServerTokenIDWS ,
      string DeviceGlobalIDWS ,
     string AccountTypeWS ,
             string UserIDWS ,
              string MobileNumberIDWS ,
             string IndexIDWS );




        Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_List_Private_Alphabet_Index_AccountTypeWSAsync (
     string PlatformOSIDWS ,
    string DatabaseServerTokenIDWS ,
     string DeviceGlobalIDWS ,
      string AccountTypeWS ,
               string UserIDWS ,
                string MobileNumberIDWS ,
             string IndexIDWS );

        

        }

    }
