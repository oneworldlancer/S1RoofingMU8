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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Chat;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
    {
    class SRoofingSync_ScreenCallShowManager
        {
   




        #region User_Owner_Model



        public async static
        void Sync_ScreenCallShow_Set_CallModel (

                Application _context ,
                SRoofingScreenCallShowScreenModel  iCallModel)
            {

            try
                {


                ObservableCollection<SRoofingScreenCallShowScreenModel> arrSRoofingScreenChaList = new ObservableCollection<SRoofingScreenCallShowScreenModel>();

                arrSRoofingScreenChaList.Add(iCallModel);
                string jsonList = JsonConvert.SerializeObject(arrSRoofingScreenChaList);



                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_CallSessionListID;

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



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static
          SRoofingScreenCallShowScreenModel Sync_ScreenCallShow_Get_CallModel ( Application _context )
            {

            try
                {
                ObservableCollection<SRoofingScreenCallShowScreenModel> arrCountryModelList = new ObservableCollection<SRoofingScreenCallShowScreenModel> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();

                string strToken = SRoofingEnum_UserSyncManager.Sync_CallSessionListID;
                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                    {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingScreenCallShowScreenModel>> ( strJson );
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsOwnerModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsOwnerModelManager>)) as ObservableCollection<BashKatebLogisticsOwnerModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if ( arrCountryModelList != null )
                        {
                        return arrCountryModelList [ 0 ];
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
        void Sync_ScreenCallShow_Update_CallModel (

                Application _context ,
                ObservableCollection<SRoofingScreenCallShowScreenModel> arrCountryModelList )
            {

            try
                {

                /*            ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> arrBashKatebLogisticsOwnerModelManager = new ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> ();

                            arrBashKatebLogisticsOwnerModelManager.add ( arrCountryModelList);*/
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_CallSessionListID;

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
        async Task<bool> Sync_ScreenCallShow_Reset_CallSessionListModel (

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
                      + SRoofingEnum_UserSyncManager.Sync_CallSessionListID
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
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return await Task.FromResult ( false );
            }

        }
















        #endregion







    }
}
