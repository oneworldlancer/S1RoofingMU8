using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Category;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;

 
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_UserCategoryManager
    {


        // UserProfile_Get_Owner_Profile_ByAccountTypeWS
        public static async Task<ObservableCollection<SRoofingCategoryModelManager>> SRoofing_XFMobile_UserCategory_Get_List_ByOwnerUserTokenIDWS (
           Application context ,
                SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {

                ObservableCollection<SRoofingCategoryModelManager> arr_UserCategoryList = new ObservableCollection<SRoofingCategoryModelManager> ( );


                arr_UserCategoryList = await App.svcSRoofing_UserCategoryWS
        .SRoofing_XFMobile_UserCategory_Get_List_ByOwnerUserTokenIDWSAsync (

                                                App.iPlatformOS ,
                       App.iDatabaseServerTokenID ,
       Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
       App.iAccountType ,

                  iOwnerModel.OwnerUserTokenID ,
                       iOwnerModel.OwnerMobileNumberTokenID );




                if ( arr_UserCategoryList != null )
                {
                  
                    await SRoofingSync_UserCategoryManager
                                             .Sync_User_Category_Set_Category_List_ByOwnerUserTokenID (
                                          App.Current ,
                                                 iOwnerModel ,
                                          arr_UserCategoryList );




                  ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager> ( );
                    SRoofingKeyValueModelManager iItem;
                
                    for ( int i = 0 ; i < arr_UserCategoryList.Count ; i++ )
                    {

                        iItem = new SRoofingKeyValueModelManager
                        {
                            ItemText = arr_UserCategoryList[ i ].CategoryTitle ,
                            ItemValue = arr_UserCategoryList[ i ].CategoryTokenID
                        };
                     
                        arr_ItemList.Add ( iItem );
                  
                     await    SRoofingSync_UserCategoryManager
                                             .Sync_User_Category_Set_Category_List_KeyValueModel_ByOwnerUserTokenID (
                                          App.Current ,
                                                 iOwnerModel ,
                                          arr_ItemList );
                    }













                }


                return arr_UserCategoryList;


            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }

         public static async Task<ObservableCollection<SRoofingKeyValueModelManager>> SRoofing_XFMobile_UserCategory_Get_List_SRoofingKeyValueModelManager_ByOwnerUserTokenIDWS (
           Application context ,
                SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {

                ObservableCollection<SRoofingCategoryModelManager> arr_UserCategoryList = new ObservableCollection<SRoofingCategoryModelManager> ( );
                      ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager> ( );
                    SRoofingKeyValueModelManager iItem;
                

                arr_UserCategoryList = await App.svcSRoofing_UserCategoryWS
        .SRoofing_XFMobile_UserCategory_Get_List_ByOwnerUserTokenIDWSAsync (

                                                App.iPlatformOS ,
                       App.iDatabaseServerTokenID ,
       Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
       App.iAccountType ,

                  iOwnerModel.OwnerUserTokenID ,
                       iOwnerModel.OwnerMobileNumberTokenID );




                if ( arr_UserCategoryList != null )
                {
                  
                    await SRoofingSync_UserCategoryManager
                                             .Sync_User_Category_Set_Category_List_ByOwnerUserTokenID (
                                          App.Current ,
                                                 iOwnerModel ,
                                          arr_UserCategoryList );




           
                    for ( int i = 0 ; i < arr_UserCategoryList.Count ; i++ )
                    {

                        iItem = new SRoofingKeyValueModelManager
                        {
                            ItemText = arr_UserCategoryList[ i ].CategoryTitle ,
                            ItemValue = arr_UserCategoryList[ i ].CategoryTokenID
                        };
                     
                        arr_ItemList.Add ( iItem );
                  
                     await    SRoofingSync_UserCategoryManager
                                             .Sync_User_Category_Set_Category_List_KeyValueModel_ByOwnerUserTokenID (
                                          App.Current ,
                                                 iOwnerModel ,
                                          arr_ItemList );
                    }

                }


                return arr_ItemList;


            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }

    }
}
