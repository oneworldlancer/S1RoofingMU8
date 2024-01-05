
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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Category;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using Newtonsoft.Json;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
    class SRoofingSync_UserCategoryManager
    {




        #region User_Group_Model



        public async static
        Task<bool> Sync_User_Category_Set_History_CategoryModel(

                Application _context,
               SRoofingUserOwnerModelManager iOwnerModel,
                SRoofingCategoryModelManager iItem)
        {

            try
            {

                ObservableCollection<SRoofingCategoryModelManager> arrItemList = new ObservableCollection<SRoofingCategoryModelManager>();

                arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken =
                SRoofingEnum_UserSyncManager.Sync_History_CategoryTokenID
                  + "-"
                  + iOwnerModel.OwnerMobileNumberTokenID;



                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(strToken, jsonList);

                //Globals._blnSync_Setting_List = true;
                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return await Task.FromResult(false);
            }

        }



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Category_Get_CategoryModel(Application _context)

        public static async
        Task<SRoofingCategoryModelManager> Sync_User_Category_Get_History_CategoryModel(
            Application _context,
               SRoofingUserOwnerModelManager iOwnerModel)
        {

            try
            {
                ObservableCollection<SRoofingCategoryModelManager> arrCountryModelList = new ObservableCollection<SRoofingCategoryModelManager>();


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsGroupModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsGroupModelManager> arrCountryModelList = new ArrayList<>();


                string strToken =
                       SRoofingEnum_UserSyncManager.Sync_History_CategoryTokenID
                         + "-"
                         + iOwnerModel.OwnerMobileNumberTokenID;




                string strJson = Preferences.Get(strToken, string.Empty);


                if (Preferences.Get(strToken, null) != null)
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingCategoryModelManager>>(strJson);
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsGroupModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsGroupModelManager>)) as ObservableCollection<BashKatebLogisticsGroupModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if (arrCountryModelList != null)
                    {
                        return arrCountryModelList[0];
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
            catch (Exception ex)
            {
                 SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }


        public static
        void Sync_User_Category_Update_History_CategoryModel(

                Application _context,
                 SRoofingUserOwnerModelManager iOwnerModel,
                 SRoofingCategoryModelManager iItem)
        {

            try
            {

                ObservableCollection<SRoofingCategoryModelManager> arrItemList = new ObservableCollection<SRoofingCategoryModelManager>();

                arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);





                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken =
                             SRoofingEnum_UserSyncManager.Sync_History_CategoryTokenID
                               + "-"
                               + iOwnerModel.OwnerMobileNumberTokenID;





                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(strToken, jsonList);

                //Globals._blnSync_Setting_List = true;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }




        #endregion



        #region User_Group_List_ByCategoryTokenID



        public async static
        Task Sync_User_Category_Set_History_Group_List_ByCategoryTokenID(

                Application _context,
               SRoofingUserOwnerModelManager iOwnerModel,
               string CategoryTokenID,
                    ObservableCollection<SRoofingUserGroupModelManager> arrItemList)
        {

            try
            {

                //ObservableCollection<SRoofingUserGroupModelManager> arrItemList = new ObservableCollection<SRoofingUserGroupModelManager>();

                //    arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken =
                SRoofingEnum_UserSyncManager.Sync_History_GroupListByCategoryTokenID
                  + "-"
                  + iOwnerModel.OwnerMobileNumberTokenID
                  + "-"
                  + CategoryTokenID;



                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(strToken, jsonList);

                //Globals._blnSync_Setting_List = true;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Category_GetByCategoryTokenID(Application _context)

        public static async
          Task<ObservableCollection<SRoofingUserGroupModelManager>> Sync_User_Category_Get_History_Group_List_ByCategoryTokenID(
            Application _context,
               SRoofingUserOwnerModelManager iOwnerModel,
               string CategoryTokenID)
        {

            try
            {
                ObservableCollection<SRoofingUserGroupModelManager> arrCountryModelList = new ObservableCollection<SRoofingUserGroupModelManager>();


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsGroupModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsGroupModelManager> arrCountryModelList = new ArrayList<>();


                string strToken =
                      SRoofingEnum_UserSyncManager.Sync_History_GroupListByCategoryTokenID
                        + "-"
                        + iOwnerModel.OwnerMobileNumberTokenID
                        + "-"
                        + CategoryTokenID;





                string strJson = Preferences.Get(strToken, string.Empty);


                if (Preferences.Get(strToken, null) != null)
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingUserGroupModelManager>>(strJson);
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsGroupModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsGroupModelManager>)) as ObservableCollection<BashKatebLogisticsGroupModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if (arrCountryModelList != null)
                    {
                        return await Task.FromResult(arrCountryModelList);
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
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }


        public static async
        Task<bool> Sync_User_Category_Update_History_Group_List_ByCategoryTokenID(

                Application _context,
                 SRoofingUserOwnerModelManager iOwnerModel,
                 string CategoryTokenID,
                   ObservableCollection<SRoofingUserGroupModelManager> arrItemList)
        {

            try
            {

                //ObservableCollection<SRoofingUserGroupModelManager> arrItemList = new ObservableCollection<SRoofingUserGroupModelManager>();

                //arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);





                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken =
                              SRoofingEnum_UserSyncManager.Sync_History_GroupListByCategoryTokenID
                                + "-"
                                + iOwnerModel.OwnerMobileNumberTokenID
                                + "-"
                                + CategoryTokenID;






                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(strToken, jsonList);

                //Globals._blnSync_Setting_List = true;
                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return await Task.FromResult(false);
            }

        }




        #endregion




        #region User_Group_List_ByCategoryTokenID



        public async static
        Task<bool> Sync_User_Category_Set_Category_List_ByOwnerUserTokenID(

                Application _context,
               SRoofingUserOwnerModelManager iOwnerModel,
               ObservableCollection<SRoofingCategoryModelManager> arrItemList)
        {

            try
            {

                //ObservableCollection<SRoofingCategoryModelManager> arrItemList = new ObservableCollection<SRoofingCategoryModelManager>();

                //    arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken =
                SRoofingEnum_UserSyncManager.Sync_Category_List
                  + "-"
                  + iOwnerModel.OwnerMobileNumberTokenID;



                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(strToken, jsonList);

                //Globals._blnSync_Setting_List = true;
           
                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return await Task.FromResult(false);
            }

        }



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Category_GetByCategoryTokenID(Application _context)

        public static async
          Task<ObservableCollection<SRoofingCategoryModelManager>> Sync_User_Category_Get_Category_List_ByOwnerUserTokenID(
            Application _context,
               SRoofingUserOwnerModelManager iOwnerModel)
        {

            try
            {
                ObservableCollection<SRoofingCategoryModelManager> arrCountryModelList = new ObservableCollection<SRoofingCategoryModelManager>();


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsGroupModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsGroupModelManager> arrCountryModelList = new ArrayList<>();


                string strToken =
                      SRoofingEnum_UserSyncManager.Sync_Category_List
                        + "-"
                        + iOwnerModel.OwnerMobileNumberTokenID;





                string strJson = Preferences.Get(strToken, string.Empty);


                if (Preferences.Get(strToken, null) != null)
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingCategoryModelManager>>(strJson);
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsGroupModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsGroupModelManager>)) as ObservableCollection<BashKatebLogisticsGroupModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if (arrCountryModelList != null)
                    {
                        return await Task.FromResult(arrCountryModelList);
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
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }


        public static async
        Task<bool> Sync_User_Category_Update_Category_List_ByOwnerUserTokenID(

                Application _context,
                 SRoofingUserOwnerModelManager iOwnerModel,
                ObservableCollection<SRoofingCategoryModelManager> arrItemList)
        {

            try
            {

                //ObservableCollection<SRoofingCategoryModelManager> arrItemList = new ObservableCollection<SRoofingCategoryModelManager>();

                //arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);





                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken =
                              SRoofingEnum_UserSyncManager.Sync_Category_List
                                + "-"
                                + iOwnerModel.OwnerMobileNumberTokenID;






                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(strToken, jsonList);

                //Globals._blnSync_Setting_List = true;
                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return await Task.FromResult(false);
            }

        }




        #endregion




        #region User_Category_SRoofingKeyValueModelManager_List



        public async static
        Task<bool> Sync_User_Category_Set_Category_List_KeyValueModel_ByOwnerUserTokenID (

                Application _context,
               SRoofingUserOwnerModelManager iOwnerModel,
               ObservableCollection<SRoofingKeyValueModelManager> arrItemList)
        {

            try
            {

                //ObservableCollection<SRoofingKeyValueModelManager> arrItemList = new ObservableCollection<SRoofingKeyValueModelManager>();

                //    arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken =
                SRoofingEnum_UserSyncManager.Sync_Category_List_KeyValueModel
                  + "-"
                  + iOwnerModel.OwnerMobileNumberTokenID;



                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(strToken, jsonList);

                //Globals._blnSync_Setting_List = true;
           
                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return await Task.FromResult(false);
            }

        }



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Category_GetByCategoryTokenID(Application _context)

        public static async
          Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_User_Category_Get_Category_List_KeyValueModel_ByOwnerUserTokenID (
            Application _context,
               SRoofingUserOwnerModelManager iOwnerModel)
        {

            try
            {
                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager>();


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsGroupModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsGroupModelManager> arrCountryModelList = new ArrayList<>();


                string strToken =
                      SRoofingEnum_UserSyncManager.Sync_Category_List_KeyValueModel
                        + "-"
                        + iOwnerModel.OwnerMobileNumberTokenID;





                string strJson = Preferences.Get(strToken, string.Empty);


                if (Preferences.Get(strToken, null) != null)
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingKeyValueModelManager>>(strJson);
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsGroupModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsGroupModelManager>)) as ObservableCollection<BashKatebLogisticsGroupModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if (arrCountryModelList != null)
                    {
                        return await Task.FromResult(arrCountryModelList);
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
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }


        public static async
        Task<bool> Sync_User_Category_Update_Category_List_KeyValueModel_ByOwnerUserTokenID (

                Application _context,
                 SRoofingUserOwnerModelManager iOwnerModel,
                ObservableCollection<SRoofingKeyValueModelManager> arrItemList)
        {

            try
            {

                //ObservableCollection<SRoofingKeyValueModelManager> arrItemList = new ObservableCollection<SRoofingKeyValueModelManager>();

                //arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);





                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken =
                              SRoofingEnum_UserSyncManager.Sync_Category_List_KeyValueModel
                                + "-"
                                + iOwnerModel.OwnerMobileNumberTokenID;






                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(strToken, jsonList);

                //Globals._blnSync_Setting_List = true;
                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return await Task.FromResult(false);
            }

        }




        #endregion







    }
}
