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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Chat;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
    class SRoofingSync_ScreenChatShowManager
    {





        #region User_Owner_Model



        public async static
        Task<bool> Sync_ScreenChatShow_Set_ChatModel (

                Application _context ,
                string iAccount ,
                SRoofingUserOwnerModelManager iOwnerModel ,
               SRoofingScreenChatShowScreenModel iChatModel )
        {

            try
            {

                ObservableCollection<SRoofingScreenChatShowScreenModel> arrSRoofingScreenChaList = new ObservableCollection<SRoofingScreenChatShowScreenModel> ( );

                arrSRoofingScreenChaList.Add ( iChatModel );
                string jsonList = JsonConvert.SerializeObject ( arrSRoofingScreenChaList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken = iAccount
                    + SRoofingEnum_UserSyncManager.Sync_ChatID
                    + "-" + iOwnerModel.OwnerMobileNumberTokenID;



                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;
                return await Task.FromResult ( true );
            }
            catch (Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return await Task.FromResult ( false );
            }

        }



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static
      async Task<SRoofingScreenChatShowScreenModel> Sync_ScreenChatShow_Get_ChatModel (
            Application _context ,
              string iAccount ,
                SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {
                ObservableCollection<SRoofingScreenChatShowScreenModel> arrCountryModelList = new ObservableCollection<SRoofingScreenChatShowScreenModel> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();


                string strToken = iAccount
                    + SRoofingEnum_UserSyncManager.Sync_ChatID
                    + "-" + iOwnerModel.OwnerMobileNumberTokenID;



                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingScreenChatShowScreenModel>> ( strJson );
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsOwnerModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsOwnerModelManager>)) as ObservableCollection<BashKatebLogisticsOwnerModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

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
            catch (Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }


        public static
        void Sync_ScreenChatShow_Update_ChatModel (

                Application _context ,
                  string iAccount ,
                SRoofingUserOwnerModelManager iOwnerModel ,
                ObservableCollection<SRoofingScreenChatShowScreenModel> arrCountryModelList )
        {

            try
            {

                /*            ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> arrBashKatebLogisticsOwnerModelManager = new ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> ();

                            arrBashKatebLogisticsOwnerModelManager.add ( arrCountryModelList);*/
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken = iAccount
                    + SRoofingEnum_UserSyncManager.Sync_ChatID
                    + "-" + iOwnerModel.OwnerMobileNumberTokenID;



                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;

            }
            catch (Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }



        public static
        void Sync_ScreenChatShow_Reset_ChatModel (

                Application _context ,
                  string iAccount ,
                SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {


                //  string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = iAccount
                    + SRoofingEnum_UserSyncManager.Sync_ChatID
                    + "-" + iOwnerModel.OwnerMobileNumberTokenID;


                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , null );

                //Globals._blnSync_Setting_List = true;

            }
            catch (Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }




        #endregion





        #region User_Owner_Model



        public async static
        Task<bool> Sync_ScreenChatShow_Set_ChatSessionListModel (

                Application _context ,
                string iAccount ,
                SRoofingUserOwnerModelManager iOwnerModel ,
               SRoofingScreenChatShowScreenModel iChatModel )
        {

            try
            {

                ObservableCollection<SRoofingScreenChatShowScreenModel> arrSRoofingScreenChaList = new ObservableCollection<SRoofingScreenChatShowScreenModel> ( );

                arrSRoofingScreenChaList.Add ( iChatModel );
                string jsonList = JsonConvert.SerializeObject ( arrSRoofingScreenChaList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken = iAccount
                      + SRoofingEnum_UserSyncManager.Sync_ChatSessionListID
                      + "-"
                       + iOwnerModel.OwnerMobileNumberTokenID;

                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;
                return await Task.FromResult ( true );
            }
            catch (Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return await Task.FromResult ( false );
            }

        }



        public async static
        Task<bool> Sync_ScreenChatShow_New_ChatSessionListModel (

                Application _context ,
                string iAccount ,
                SRoofingUserOwnerModelManager iOwnerModel ,
               SRoofingScreenChatShowScreenModel iChatModel )
        {

            try
            {

                ObservableCollection<SRoofingScreenChatShowScreenModel> arrSRoofingScreenChaList = new ObservableCollection<SRoofingScreenChatShowScreenModel> ( );

                arrSRoofingScreenChaList = await Sync_ScreenChatShow_Get_ChatSessionListModel (
            _context ,
              iAccount ,
                iOwnerModel );

                if ( arrSRoofingScreenChaList == null )
                {
                    arrSRoofingScreenChaList = new ObservableCollection<SRoofingScreenChatShowScreenModel> ( );
                }

                arrSRoofingScreenChaList.Add ( iChatModel );
               
                string jsonList = JsonConvert.SerializeObject ( arrSRoofingScreenChaList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken = iAccount
                      + SRoofingEnum_UserSyncManager.Sync_ChatSessionListID
                      + "-"
                       + iOwnerModel.OwnerMobileNumberTokenID;

                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;
                return await Task.FromResult ( true );
            }
            catch (Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return await Task.FromResult ( false );
            }

        }



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static
     async Task<ObservableCollection<SRoofingScreenChatShowScreenModel>> Sync_ScreenChatShow_Get_ChatSessionListModel (
            Application _context ,
              string iAccount ,
                SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {
                ObservableCollection<SRoofingScreenChatShowScreenModel> arrCountryModelList = new ObservableCollection<SRoofingScreenChatShowScreenModel> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();


                string strToken = iAccount
                      + SRoofingEnum_UserSyncManager.Sync_ChatSessionListID
                      + "-"
                       + iOwnerModel.OwnerMobileNumberTokenID;

                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingScreenChatShowScreenModel>> ( strJson );
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsOwnerModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsOwnerModelManager>)) as ObservableCollection<BashKatebLogisticsOwnerModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if ( arrCountryModelList != null )
                    {
                        return await Task.FromResult ( arrCountryModelList );
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
            catch (Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }


        public static
     async Task<bool> Sync_ScreenChatShow_Update_ChatSessionListModel (

                Application _context ,
                  string iAccount ,
                SRoofingUserOwnerModelManager iOwnerModel ,
                ObservableCollection<SRoofingScreenChatShowScreenModel> arrCountryModelList )
        {

            try
            {

                /*            ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> arrBashKatebLogisticsOwnerModelManager = new ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> ();

                            arrBashKatebLogisticsOwnerModelManager.add ( arrCountryModelList);*/
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken = iAccount
                      + SRoofingEnum_UserSyncManager.Sync_ChatSessionListID
                      + "-"
                       + iOwnerModel.OwnerMobileNumberTokenID;

                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;
                return await Task.FromResult ( true );

            }
            catch (Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return await Task.FromResult ( false );
            }

        }



        public static
        async Task<bool> Sync_ScreenChatShow_Reset_ChatSessionListModel (

                Application _context ,
                  string iAccount ,
                SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {


                //  string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = iAccount
                      + SRoofingEnum_UserSyncManager.Sync_ChatSessionListID
                      + "-"
                       + iOwnerModel.OwnerMobileNumberTokenID;

                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , null );

                //Globals._blnSync_Setting_List = true;
                return await Task.FromResult ( true );

            }
            catch (Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return await Task.FromResult ( false );
            }

        }




        #endregion







    }
}
