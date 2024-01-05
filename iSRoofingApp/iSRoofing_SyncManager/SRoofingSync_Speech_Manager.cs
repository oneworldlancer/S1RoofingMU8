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
    class SRoofingSync_Speech_Manager
    {





        #region Speech_Incoming 



        public async static
        Task Sync_Speech_Set_Incoming_ByUserID (

                Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
             SRoofingSpeechModel iSpeechModel )
        {

            try
            {

                ObservableCollection<SRoofingSpeechModel> arriSpeechModelList = new ObservableCollection<SRoofingSpeechModel> ( );

                arriSpeechModelList.Add ( iSpeechModel );
                string jsonList = JsonConvert.SerializeObject ( arriSpeechModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_Speech_Incoming_UserID
                    + "-"
                    + iOwnerModel.OwnerMobileNumberTokenID;

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



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static
       Task<SRoofingSpeechModel> Sync_Speech_Get_Incoming_ByUserID (
            Application _context ,
              SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {
                ObservableCollection<SRoofingSpeechModel> arrCountryModelList = new ObservableCollection<SRoofingSpeechModel> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();

                string strToken = SRoofingEnum_UserSyncManager.Sync_Speech_Incoming_UserID
                    + "-"
                    + iOwnerModel.OwnerMobileNumberTokenID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingSpeechModel>> ( strJson );
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



        #region Speech_Outgoing 



        public async static
        Task Sync_Speech_Set_Outgoing_ByUserID (

                Application _context ,
                SRoofingUserOwnerModelManager iOwnerModel ,
            SRoofingSpeechModel iSpeechModel )
        {

            try
            {

                ObservableCollection<SRoofingSpeechModel> arrSpeechModelList = new ObservableCollection<SRoofingSpeechModel> ( );

                arrSpeechModelList.Add ( iSpeechModel );

                string jsonList = JsonConvert.SerializeObject ( arrSpeechModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_Speech_Outgoing_UserID
                      + "-"
                      + iOwnerModel.OwnerMobileNumberTokenID;

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



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static
             Task<SRoofingSpeechModel> Sync_Speech_Get_Outgoing_ByUserID (
            Application _context ,
              SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {
                ObservableCollection<SRoofingSpeechModel> arrCountryModelList = new ObservableCollection<SRoofingSpeechModel> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();

                string strToken = SRoofingEnum_UserSyncManager.Sync_Speech_Outgoing_UserID
                       + "-"
                       + iOwnerModel.OwnerMobileNumberTokenID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingSpeechModel>> ( strJson );
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


        //////public static
        //////Task Sync_Speech_Update_Outgoing_ByUserID (

        //////        Application _context ,
        //////   SRoofingUserOwnerModelManager iOwnerModel ,
        //////         ObservableCollection<SRoofingSpeechModel> arrCountryModelList )
        //////    {

        //////    try
        //////        {

        //////        /*            ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> arrBashKatebLogisticsOwnerModelManager = new ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> ();

        //////                    arrBashKatebLogisticsOwnerModelManager.add ( arrCountryModelList);*/
        //////        string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


        //////        //Gson gson = new Gson();
        //////        //String jsonList = gson.toJson(arrCountryModelList);

        //////        string strToken = SRoofingEnum_UserSyncManager.Sync_Speech_Outgoing_UserID
        //////                  + "-"
        //////                  + iOwnerModel.OwnerMobileNumberTokenID;


        //////        //TlknSharedPreference.SharedPreference_SetStringValue(

        //////        //        _context,
        //////        //        TlknSharedPreference.shared_SyncManager,
        //////        //        strToken, jsonList);

        //////        Preferences.Set (  strToken , jsonList );

        //////        //Globals._blnSync_Setting_List = true;

        //////        }
        //////    catch (Exception ex )
        //////        {
        //////        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //////        return;
        //////        }

        //////    }




        #endregion



        #region Speech_SpeechList 



        public async static
        Task Sync_Speech_Set_SpeechList (

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


                string strToken = SRoofingEnum_UserSyncManager.Sync_Speech_ListID;


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





        public static async
        Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_Speech_Get_SpeechList (
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


                string strToken = SRoofingEnum_UserSyncManager.Sync_Speech_ListID;


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
