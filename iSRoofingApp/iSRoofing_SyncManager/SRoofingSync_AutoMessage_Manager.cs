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
    class SRoofingSync_AutoMessage_Manager
    {





        #region Speech_Incoming 



        public async static
        Task<bool> Sync_AutoMessage_Call_Set_AutoReplyMessage_ByUserID (

                Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
             string iSpeechModel )
        {

            try
            {

                ObservableCollection<string> arriSpeechModelList = new ObservableCollection<string> ( );

                arriSpeechModelList.Add ( iSpeechModel );
                string jsonList = JsonConvert.SerializeObject ( arriSpeechModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_AutoMessage_CallAutoMessageID
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
       Task<string> Sync_AutoMessage_Call_Get_AutoReplyMessage_ByUserID (
            Application _context ,
              SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {
                ObservableCollection<string> arrCountryModelList = new ObservableCollection<string> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();

                string strToken = SRoofingEnum_UserSyncManager.Sync_AutoMessage_CallAutoMessageID
                    + "-"
                    + iOwnerModel.OwnerMobileNumberTokenID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<string>> ( strJson );
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


        #region Call_AutoMessageList 
       

        public async static
        Task<bool> Sync_AutoMessage_Call_Set_AutoReplyMessageList_ByAccountType (

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


                string strToken = SRoofingEnum_UserSyncManager.Sync_AutoMessage_CallAutoMessageList;


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
        Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_AutoMessage_Call_Get_AutoReplyMessageList_ByAccountType (
            Application _context   )
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();


                string strToken = SRoofingEnum_UserSyncManager.Sync_AutoMessage_CallAutoMessageList;


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






        
        public async static
        Task Sync_AutoMessage_Call_New_AutoReplyMessageList_ByAccountType (

                Application _context ,
                SRoofingUserOwnerModelManager iOwnerModel,
             SRoofingKeyValueModelManager arrCountryModelList )
        {

            try
            {

             ObservableCollection <SRoofingKeyValueModelManager> arrBashKatebLogisticsOwnerModelManager = new ObservableCollection <SRoofingKeyValueModelManager> ();
                arrBashKatebLogisticsOwnerModelManager =await Sync_AutoMessage_Call_Get_AutoReplyMessageList_ByAccountType(_context);

                          arrBashKatebLogisticsOwnerModelManager.Insert (0, arrCountryModelList);
            
                //string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                string strToken = SRoofingEnum_UserSyncManager.Sync_AutoMessage_CallAutoMessageList;


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

   

        #region Gallery_PickerList 
       

        public async static
        Task<bool> Sync_AutoMessage_Gallery_Set_PickerMessageList_ByAccountType (

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


                string strToken = SRoofingEnum_UserSyncManager.Sync_AutoMessage_Gallery_PickerMessageList;


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
        Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_AutoMessage_Gallery_Get_PickerMessageList_ByAccountType (
            Application _context   )
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();


                string strToken = SRoofingEnum_UserSyncManager.Sync_AutoMessage_Gallery_PickerMessageList;


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
