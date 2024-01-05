using Newtonsoft.Json;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
 
using Microsoft.Maui.Controls;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using System.ComponentModel;
using System.Linq;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
    class SRoofingSync_UserGroupManager
    {




        #region User_Group_Model



        public async static
        Task Sync_User_Group_Set_UserModel (

                Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
                SRoofingUserGroupModelManager iItem )
        {

            try
            {

                ObservableCollection<SRoofingUserGroupModelManager> arrItemList = new ObservableCollection<SRoofingUserGroupModelManager> ( );

                arrItemList.Add ( iItem );

                string jsonList = JsonConvert.SerializeObject ( arrItemList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken =
                SRoofingEnum_UserSyncManager.Sync_Profile_GroupID
                  + "-"
                  + iOwnerModel.OwnerMobileNumberTokenID
                  + "-"
                  + iItem.GroupTokenID;



                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Group_Get_UserModel(Application _context)

        public static
      async Task<SRoofingUserGroupModelManager> Sync_User_Group_Get_UserModel (
            Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
               string GroupTokenID )
        {

            try
            {
                ObservableCollection<SRoofingUserGroupModelManager> arrCountryModelList = new ObservableCollection<SRoofingUserGroupModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsGroupModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsGroupModelManager> arrCountryModelList = new ArrayList<>();


                string strToken =
                SRoofingEnum_UserSyncManager.Sync_Profile_GroupID
                  + "-"
                  + iOwnerModel.OwnerMobileNumberTokenID
                  + "-"
                  + GroupTokenID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingUserGroupModelManager>> ( strJson );
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsGroupModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsGroupModelManager>)) as ObservableCollection<BashKatebLogisticsGroupModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if ( arrCountryModelList != null )
                    {
                        return await Task.FromResult ( arrCountryModelList[ 0 ] );
                    }
                    else
                    {
                        return null;
                    }

                }
                else
                {
                    return null;
                }

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }


        public static
        void Sync_User_Group_Update_UserModel (

                Application _context ,
                 SRoofingUserOwnerModelManager iOwnerModel ,
                 SRoofingUserGroupModelManager iItem )
        {

            try
            {

                ObservableCollection<SRoofingUserGroupModelManager> arrItemList = new ObservableCollection<SRoofingUserGroupModelManager> ( );

                arrItemList.Add ( iItem );

                string jsonList = JsonConvert.SerializeObject ( arrItemList );





                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken =
                SRoofingEnum_UserSyncManager.Sync_Profile_GroupID
                  + "-"
                  + iOwnerModel.OwnerMobileNumberTokenID
                  + "-"
                  + iItem.GroupTokenID;



                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }




        #endregion



        #region User_Group_List_ByCategoryTokenID



        public async static
        Task Sync_User_Group_Set_List_ByCategoryTokenID (

                Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
               string CategoryTokenID ,
                    ObservableCollection<SRoofingUserGroupModelManager> arrItemList )
        {

            try
            {

                //ObservableCollection<SRoofingUserGroupModelManager> arrItemList = new ObservableCollection<SRoofingUserGroupModelManager>();

                //    arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject ( arrItemList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken =
                SRoofingEnum_UserSyncManager.Sync_Contact_List_CategoryGroup_ID
                  + "-"
                  + iOwnerModel.OwnerMobileNumberTokenID
                  + "-"
                  + CategoryTokenID;



                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Group_GetByCategoryTokenID(Application _context)

        public static
          async Task<ObservableCollection<SRoofingUserGroupModelManager>> Sync_User_Group_Get_List_ByCategoryTokenID (
            Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
               string CategoryTokenID )
        {

            try
            {
                ObservableCollection<SRoofingUserGroupModelManager> arrCountryModelList = new ObservableCollection<SRoofingUserGroupModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsGroupModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsGroupModelManager> arrCountryModelList = new ArrayList<>();


                string strToken =
                      SRoofingEnum_UserSyncManager.Sync_Contact_List_CategoryGroup_ID
                        + "-"
                        + iOwnerModel.OwnerMobileNumberTokenID
                        + "-"
                        + CategoryTokenID;





                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingUserGroupModelManager>> ( strJson );
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsGroupModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsGroupModelManager>)) as ObservableCollection<BashKatebLogisticsGroupModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if ( arrCountryModelList != null )
                    {
                        return await Task.FromResult ( arrCountryModelList );
                    }
                    else
                    {
                        return ( null );
                    }

                }
                else
                {
                    return ( null );
                }

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return ( null );
            }
        }


        public static
        Task<bool> Sync_User_Group_Update_ByCategoryTokenID (

                Application _context ,
                 SRoofingUserOwnerModelManager iOwnerModel ,
                 string CategoryTokenID ,
                   ObservableCollection<SRoofingUserGroupModelManager> arrItemList )
        {

            try
            {

                //ObservableCollection<SRoofingUserGroupModelManager> arrItemList = new ObservableCollection<SRoofingUserGroupModelManager>();

                //arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject ( arrItemList );





                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken =
                              SRoofingEnum_UserSyncManager.Sync_Contact_List_CategoryGroup_ID
                                + "-"
                                + iOwnerModel.OwnerMobileNumberTokenID
                                + "-"
                                + CategoryTokenID;






                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;
                return Task.FromResult ( true );
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return Task.FromResult ( false );
            }

        }




        #endregion







    }
}
