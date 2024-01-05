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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Category;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
    class SRoofingSync_UserContactPickerManager
    {




        #region History_ContactAlphabetID_Selected



        public async static
        Task<bool> Sync_User_Picker_Contact_Set_History_Selected_CharacterModel(

                Application _context,
               SRoofingUserOwnerModelManager iOwnerModel,
                SRoofingKeyValueModelManager iItem)
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arrItemList = new ObservableCollection<SRoofingKeyValueModelManager>();

                arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken =
                SRoofingEnum_UserSyncManager.Sync_History_Picker_ContactAlphabetID_Selected
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



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Picker_Category_Get_CategoryModel(Application _context)

        public static async
        Task<SRoofingKeyValueModelManager> Sync_User_Picker_Contact_Get_History_Selected_CharacterModel (
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
                       SRoofingEnum_UserSyncManager.Sync_History_Picker_ContactAlphabetID_Selected
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
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }


        public static
        void Sync_User_Picker_Contact_Update_History_Selected_CharacterModel (

                Application _context,
                 SRoofingUserOwnerModelManager iOwnerModel,
                 SRoofingKeyValueModelManager iItem)
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arrItemList = new ObservableCollection<SRoofingKeyValueModelManager>();

                arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);





                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken =
                             SRoofingEnum_UserSyncManager.Sync_History_Picker_ContactAlphabetID_Selected
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



        #region History_ContactList_AlphabetID_Selected



        public async static
        Task Sync_User_Picker_Contact_Set_History_Selected_Contact_List_ByCharacterID (

                Application _context,
               SRoofingUserOwnerModelManager iOwnerModel,
               string strCharacter,
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
                SRoofingEnum_UserSyncManager.Sync_History_Picker_ContactListByAlphabetID_Selected
                  + "-"
                  + iOwnerModel.OwnerMobileNumberTokenID
                  + "-"
                  + strCharacter;



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



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Picker_Category_GetBystrCharacter(Application _context)

        public static async
          Task<ObservableCollection<SRoofingUserGroupModelManager>> Sync_User_Picker_Contact_Get_History_Selected_Contact_List_ByCharacterID (
            Application _context,
               SRoofingUserOwnerModelManager iOwnerModel,
               string strCharacter)
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
                      SRoofingEnum_UserSyncManager.Sync_History_Picker_ContactListByAlphabetID_Selected
                        + "-"
                        + iOwnerModel.OwnerMobileNumberTokenID
                        + "-"
                        + strCharacter;





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
        Task<bool> Sync_User_Picker_Contact_Update_History_Selected_Contact_List_ByCharacterID (

                Application _context,
                 SRoofingUserOwnerModelManager iOwnerModel,
                 string strCharacter,
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
                              SRoofingEnum_UserSyncManager.Sync_History_Picker_ContactListByAlphabetID_Selected
                                + "-"
                                + iOwnerModel.OwnerMobileNumberTokenID
                                + "-"
                                + strCharacter;






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




        #region User_Contact_List_ByCharacterID



        public async static
        Task<bool> Sync_User_Picker_Contact_Set_List_Contact_ByCharcterID (

                Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
               string strCharacter ,
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
                SRoofingEnum_UserSyncManager.Sync_Contact_List_Contact_ByCharacterID
                  + "-"
                  + iOwnerModel.OwnerMobileNumberTokenID
                  + "-"
                  + strCharacter;



                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;

                return await Task.FromResult(true);
            }
            catch (Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return false;
            }

        }



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Group_GetBystrCharacter(Application _context)

        public static
          async Task<ObservableCollection<SRoofingUserGroupModelManager>> Sync_User_Picker_Contact_Get_List_Contact_ByCharcterID (
            Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
               string strCharacter )
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
                      SRoofingEnum_UserSyncManager.Sync_Contact_List_Contact_ByCharacterID
                        + "-"
                        + iOwnerModel.OwnerMobileNumberTokenID
                        + "-"
                        + strCharacter;





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
            catch (Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return ( null );
            }
        }


        public static
        Task<bool> Sync_User_Picker_Contact_Update_List_Contact_ByCharcterID (

                Application _context ,
                 SRoofingUserOwnerModelManager iOwnerModel ,
                 string strCharacter ,
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
                              SRoofingEnum_UserSyncManager.Sync_Contact_List_Contact_ByCharacterID
                                + "-"
                                + iOwnerModel.OwnerMobileNumberTokenID
                                + "-"
                                + strCharacter;






                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;
                return Task.FromResult ( true );
            }
            catch (Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return Task.FromResult ( false );
            }

        }




        #endregion




         /// <summary>
         /// 
         /// </summary>
         /// <param name="_context"></param>
         /// <param name="iOwnerModel"></param>
         /// <param name="arrItemList"></param>
         /// <returns></returns>









        #region User_Alphabet_Initialize_List_ByOwnerUserTokenID



        public async static
        Task<bool> Sync_User_Picker_Category_Set_Alphabet_Initialize_List_ByOwnerUserTokenID(

                Application _context,
               ObservableCollection<SRoofingKeyValueModelManager> arrItemList)
        {

            try
            {

                //ObservableCollection<SRoofingKeyValueModelManager> arrItemList = new ObservableCollection<SRoofingKeyValueModelManager>();

                //    arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken =           SRoofingEnum_UserSyncManager.Sync_History_Picker_ContactAlphabetID_Initialize  ;



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



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Picker_Category_GetBystrCharacter(Application _context)

        public static async
          Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_User_Picker_Category_Get_Alphabet_Initialize_List_ByOwnerUserTokenID(
            Application _context )
        {

            try
            {
                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager>();


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsGroupModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsGroupModelManager> arrCountryModelList = new ArrayList<>();


                string strToken =     SRoofingEnum_UserSyncManager.Sync_History_Picker_ContactAlphabetID_Initialize ;





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
        Task<bool> Sync_User_Picker_Category_Update_Alphabet_Initialize_List_ByOwnerUserTokenID(

                Application _context,
              
                ObservableCollection<SRoofingKeyValueModelManager> arrItemList)
        {

            try
            {

                //ObservableCollection<SRoofingKeyValueModelManager> arrItemList = new ObservableCollection<SRoofingKeyValueModelManager>();

                //arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);





                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken =    SRoofingEnum_UserSyncManager.Sync_History_Picker_ContactAlphabetID_Initialize  ;






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





        #region User_Alphabet_List_ByOwnerUserTokenID



        public async static
        Task<bool> Sync_User_Picker_Category_Set_Alphabet_List_ByOwnerUserTokenID(

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
                SRoofingEnum_UserSyncManager.Sync_History_Picker_ContactAlphabetID
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



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Picker_Category_GetBystrCharacter(Application _context)

        public static async
          Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_User_Picker_Category_Get_Alphabet_List_ByOwnerUserTokenID(
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
                      SRoofingEnum_UserSyncManager.Sync_History_Picker_ContactAlphabetID
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
        Task<bool> Sync_User_Picker_Category_Update_Alphabet_List_ByOwnerUserTokenID(

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
                              SRoofingEnum_UserSyncManager.Sync_History_Picker_ContactAlphabetID
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





        #region User_Alphabet_List_ByOwnerUserTokenID



        public async static
        Task Sync_User_Picker_Category_Set_Alphabet_List_ByOwnerUserTokenID(

                Application _context,
               SRoofingUserOwnerModelManager iOwnerModel,
               string strCharacter,
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
                SRoofingEnum_UserSyncManager.Sync_History_Picker_AlphabetList_ByOwnerUserTokenID
                  + "-"
                  + iOwnerModel.OwnerMobileNumberTokenID
                  + "-"
                  + strCharacter;



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



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Picker_Category_GetBystrCharacter(Application _context)

        public static async
          Task<ObservableCollection<SRoofingUserGroupModelManager>> Sync_User_Picker_Category_Get_Alphabet_List_ByOwnerUserTokenID(
            Application _context,
               SRoofingUserOwnerModelManager iOwnerModel,
               string strCharacter)
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
                      SRoofingEnum_UserSyncManager.Sync_History_Picker_AlphabetList_ByOwnerUserTokenID
                        + "-"
                        + iOwnerModel.OwnerMobileNumberTokenID
                        + "-"
                        + strCharacter;





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
        Task<bool> Sync_User_Picker_Category_Update_Alphabet_List_ByOwnerUserTokenID(

                Application _context,
                 SRoofingUserOwnerModelManager iOwnerModel,
                 string strCharacter,
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
                              SRoofingEnum_UserSyncManager.Sync_History_Picker_AlphabetList_ByOwnerUserTokenID
                                + "-"
                                + iOwnerModel.OwnerMobileNumberTokenID
                                + "-"
                                + strCharacter;






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




        #region User_Alphabet_List_Active_ByOwnerUserTokenID



        public async static
        Task Sync_User_Picker_Category_Set_Alphabet_List_Active_ByOwnerUserTokenID(

                Application _context,
               SRoofingUserOwnerModelManager iOwnerModel,
               string strCharacter,
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
                SRoofingEnum_UserSyncManager.Sync_History_Picker_AlphabetList_Active_ByOwnerUserTokenID
                  + "-"
                  + iOwnerModel.OwnerMobileNumberTokenID
                  + "-"
                  + strCharacter;



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



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Picker_Category_GetBystrCharacter(Application _context)

        public static async
          Task<ObservableCollection<SRoofingUserGroupModelManager>> Sync_User_Picker_Category_Get_Alphabet_List_Active_ByOwnerUserTokenID(
            Application _context,
               SRoofingUserOwnerModelManager iOwnerModel,
               string strCharacter)
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
                      SRoofingEnum_UserSyncManager.Sync_History_Picker_AlphabetList_Active_ByOwnerUserTokenID
                        + "-"
                        + iOwnerModel.OwnerMobileNumberTokenID
                        + "-"
                        + strCharacter;





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
        Task<bool> Sync_User_Picker_Category_Update_Alphabet_List_Active_ByOwnerUserTokenID(

                Application _context,
                 SRoofingUserOwnerModelManager iOwnerModel,
                 string strCharacter,
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
                              SRoofingEnum_UserSyncManager.Sync_History_Picker_AlphabetList_Active_ByOwnerUserTokenID
                                + "-"
                                + iOwnerModel.OwnerMobileNumberTokenID
                                + "-"
                                + strCharacter;






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




        #region _Alphabet_List_Active_Index_ByOwnerUserTokenID



        public async static
        Task Sync_User_Picker_Category_Set_Alphabet_List_Active_Index_ByOwnerUserTokenID(

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
                SRoofingEnum_UserSyncManager.Sync_History_Picker_AlphabetList_Active_Index_ByOwnerUserTokenID
                  + "-"
                  + iOwnerModel.OwnerMobileNumberTokenID ;



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




        public static async
          Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_User_Picker_Category_Get_Alphabet_List_Active_Index_ByOwnerUserTokenID(
            Application _context,
               SRoofingUserOwnerModelManager iOwnerModel )
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
                SRoofingEnum_UserSyncManager.Sync_History_Picker_AlphabetList_Active_Index_ByOwnerUserTokenID
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
        Task<bool> Sync_User_Picker_Category_Update_Alphabet_List_Active_Index_ByOwnerUserTokenID(

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
                 SRoofingEnum_UserSyncManager.Sync_History_Picker_AlphabetList_Active_Index_ByOwnerUserTokenID
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



        #region User_Alphabet_List_Active_Chars_ByOwnerUserTokenID



        public async static
        Task Sync_User_Picker_Category_Set_Alphabet_List_Active_Chars_ByOwnerUserTokenID(

                Application _context,
               SRoofingUserOwnerModelManager iOwnerModel,
                              ObservableCollection<string> arrItemList)
        {

            try
            {

                //ObservableCollection<string> arrItemList = new ObservableCollection<string>();

                //    arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken =
                              SRoofingEnum_UserSyncManager.Sync_History_Picker_AlphabetList_Active_Chars_ByOwnerUserTokenID
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



        //     ObservableCollection<BashKatebLogisticsGroupModelManager> Sync_User_Picker_Category_GetBystrCharacter(Application _context)

        public static async
          Task<ObservableCollection<string>> Sync_User_Picker_Category_Get_Alphabet_List_Active_Chars_ByOwnerUserTokenID(
            Application _context,
               SRoofingUserOwnerModelManager iOwnerModel)
        {

            try
            {
                ObservableCollection<string> arrCountryModelList = new ObservableCollection<string>();


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsGroupModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsGroupModelManager> arrCountryModelList = new ArrayList<>();



                string strToken =
                              SRoofingEnum_UserSyncManager.Sync_History_Picker_AlphabetList_Active_Chars_ByOwnerUserTokenID
                                + "-"
                                + iOwnerModel.OwnerMobileNumberTokenID;





                string strJson = Preferences.Get(strToken, string.Empty);


                if (Preferences.Get(strToken, null) != null)
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<string>>(strJson);
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
                 return null;
            }
        }


        public static async
        Task<bool> Sync_User_Picker_Category_Update_Alphabet_List_Active_Chars_ByOwnerUserTokenID(

                Application _context,
                 SRoofingUserOwnerModelManager iOwnerModel,
             
                   ObservableCollection<string> arrItemList)
        {

            try
            {

                //ObservableCollection<string> arrItemList = new ObservableCollection<string>();

                //arrItemList.Add(iItem);

                string jsonList = JsonConvert.SerializeObject(arrItemList);





                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken =
                              SRoofingEnum_UserSyncManager.Sync_History_Picker_AlphabetList_Active_Chars_ByOwnerUserTokenID
                                + "-"
                                + iOwnerModel.OwnerMobileNumberTokenID ;






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
