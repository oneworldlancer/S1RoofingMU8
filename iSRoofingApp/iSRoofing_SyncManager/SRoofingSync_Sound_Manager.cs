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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
    class SRoofingSync_Sound_Manager
    {





        #region Chat_Incoming_ByUserID 



        public async static
         Task<bool> Sync_Sound_Set_Chat_Incoming_ByUserID (

                Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
             SRoofingKeyValueModelManager iSpeechModel )
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arriSpeechModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );

                arriSpeechModelList.Add ( iSpeechModel );
                string jsonList = JsonConvert.SerializeObject ( arriSpeechModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Chat_Incoming_UserID
                    + "-"
                    + iOwnerModel.OwnerMobileNumberTokenID;

                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;

                return await Task.FromResult ( true);

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return  false;
            }

        }



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static
       Task<SRoofingKeyValueModelManager> Sync_Sound_Get_Chat_Incoming_ByUserID (
            Application _context ,
              SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {
                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();

                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Chat_Incoming_UserID
                    + "-"
                    + iOwnerModel.OwnerMobileNumberTokenID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingKeyValueModelManager>> ( strJson );
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsOwnerModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsOwnerModelManager>)) as ObservableCollection<BashKatebLogisticsOwnerModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if ( arrCountryModelList != null )
                    {
                        return Task.FromResult ( arrCountryModelList[ 0 ] );
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
                return null;
            }
        }




        #endregion



        #region Chat_Outgoing_ByUserID 



        public async static
         Task<bool> Sync_Sound_Set_Chat_Outgoing_ByUserID (

                Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
             SRoofingKeyValueModelManager iSpeechModel )
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arriSpeechModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );

                arriSpeechModelList.Add ( iSpeechModel );
                string jsonList = JsonConvert.SerializeObject ( arriSpeechModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Chat_Outgoing_UserID
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
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return false;
            }

        }



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static
       Task<SRoofingKeyValueModelManager> Sync_Sound_Get_Chat_Outgoing_ByUserID (
            Application _context ,
              SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {
                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();

                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Chat_Outgoing_UserID
                    + "-"
                    + iOwnerModel.OwnerMobileNumberTokenID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingKeyValueModelManager>> ( strJson );
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsOwnerModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsOwnerModelManager>)) as ObservableCollection<BashKatebLogisticsOwnerModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if ( arrCountryModelList != null )
                    {
                        return Task.FromResult ( arrCountryModelList[ 0 ] );
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
                return null;
            }
        }




        #endregion



        

        #region Call_Incoming_ByUserID 



        public async static
        Task<bool> Sync_Sound_Set_Call_Incoming_ByUserID (

                Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
             SRoofingKeyValueModelManager iSpeechModel )
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arriSpeechModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );

                arriSpeechModelList.Add ( iSpeechModel );
                string jsonList = JsonConvert.SerializeObject ( arriSpeechModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Call_Incoming_UserID
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
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return false;
            }

        }



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static
       Task<SRoofingKeyValueModelManager> Sync_Sound_Get_Call_Incoming_ByUserID (
            Application _context ,
              SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {
                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();

                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Call_Incoming_UserID
                    + "-"
                    + iOwnerModel.OwnerMobileNumberTokenID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingKeyValueModelManager>> ( strJson );
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsOwnerModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsOwnerModelManager>)) as ObservableCollection<BashKatebLogisticsOwnerModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if ( arrCountryModelList != null )
                    {
                        return Task.FromResult ( arrCountryModelList[ 0 ] );
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
                return null;
            }
        }




        #endregion



        #region Call_Outgoing_ByUserID 



        public async static
         Task<bool> Sync_Sound_Set_Call_Outgoing_ByUserID (

                Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
             SRoofingKeyValueModelManager iSpeechModel )
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arriSpeechModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );

                arriSpeechModelList.Add ( iSpeechModel );
                string jsonList = JsonConvert.SerializeObject ( arriSpeechModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Call_Outgoing_UserID
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
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return false;
            }

        }



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static
       Task<SRoofingKeyValueModelManager> Sync_Sound_Get_Call_Outgoing_ByUserID (
            Application _context ,
              SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {
                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();

                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Call_Outgoing_UserID
                    + "-"
                    + iOwnerModel.OwnerMobileNumberTokenID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingKeyValueModelManager>> ( strJson );
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsOwnerModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsOwnerModelManager>)) as ObservableCollection<BashKatebLogisticsOwnerModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if ( arrCountryModelList != null )
                    {
                        return Task.FromResult ( arrCountryModelList[ 0 ] );
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
                return null;
            }
        }




        #endregion







        #region Sound_Chat_Incoming_List 



        public async static
        Task<bool> Sync_Sound_Set_Chat_Incoming_List (

                Application _context ,
             ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList )
        {

            try
            {

                //     ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> arrBashKatebLogisticsOwnerModelManager = new ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> ();

                //            arrBashKatebLogisticsOwnerModelManager.add ( arrCountryModelList);*/
                //string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Chat_Incoming_ListID;


                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;

                return await Task.FromResult ( true );
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return false;
            }

        }





        public static async
        Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_Sound_Get_Chat_Incoming_List (
            Application _context )
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();


                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Chat_Incoming_ListID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingKeyValueModelManager>> ( strJson );
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
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }




        #endregion


        #region Sound_Chat_Outgoing_List 



        public async static
        Task<bool> Sync_Sound_Set_Chat_Outgoing_List (

                Application _context ,
             ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList )
        {

            try
            {

                //     ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> arrBashKatebLogisticsOwnerModelManager = new ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> ();

                //            arrBashKatebLogisticsOwnerModelManager.add ( arrCountryModelList);*/
                //string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Chat_Outgoing_ListID;


                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;

                return await Task.FromResult ( true );
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return false;
            }

        }





        public static async
        Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_Sound_Get_Chat_Outgoing_List (
            Application _context )
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();


                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Chat_Outgoing_ListID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingKeyValueModelManager>> ( strJson );
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
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }




        #endregion






        #region Sound_Call_Incoming_List 



        public async static
        Task<bool> Sync_Sound_Set_Call_Incoming_List (

                Application _context ,
             ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList )
        {

            try
            {

                //     ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> arrBashKatebLogisticsOwnerModelManager = new ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> ();

                //            arrBashKatebLogisticsOwnerModelManager.add ( arrCountryModelList);*/
                //string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Call_Incoming_ListID;


                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;

                return await Task.FromResult ( true );
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return false;
            }

        }





        public static async
        Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_Sound_Get_Call_Incoming_List (
            Application _context )
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();


                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Call_Incoming_ListID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingKeyValueModelManager>> ( strJson );
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
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }




        #endregion


        #region Sound_Call_Outgoing_List 



        public async static
        Task<bool> Sync_Sound_Set_Call_Outgoing_List (

                Application _context ,
             ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList )
        {

            try
            {

                //     ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> arrBashKatebLogisticsOwnerModelManager = new ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> ();

                //            arrBashKatebLogisticsOwnerModelManager.add ( arrCountryModelList);*/
                //string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Call_Outgoing_ListID;


                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;
         
                return await Task.FromResult ( true );
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return false;
            }

        }





        public static async
        Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_Sound_Get_Call_Outgoing_List (
            Application _context )
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();


                string strToken = SRoofingEnum_UserSyncManager.Sync_Sound_Call_Outgoing_ListID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingKeyValueModelManager>> ( strJson );
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
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }




        #endregion







    }
}
