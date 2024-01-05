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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
    class SRoofingSync_UserSetting_Manager
    {





        #region Speech_Setting 



        public async static
        Task Sync_Setting_Set_Setting_ByUserID (

                Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
               SRoofingUserSettingModelManager iModelList )
        {

            try
            {

                ObservableCollection<SRoofingUserSettingModelManager> arrBashKatebLogisticsOwnerModelManager = new ObservableCollection<SRoofingUserSettingModelManager> ( );

                arrBashKatebLogisticsOwnerModelManager.Add ( iModelList );

                string jsonList = JsonConvert.SerializeObject ( arrBashKatebLogisticsOwnerModelManager );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken = SRoofingEnum_UserSyncManager.Sync_Setting_ID
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
       async Task<SRoofingUserSettingModelManager> Sync_Setting_Get_Setting_ByUserID (
            Application _context ,
              SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {
                ObservableCollection<SRoofingUserSettingModelManager> arrCountryModelList = new ObservableCollection<SRoofingUserSettingModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();


                string strToken = SRoofingEnum_UserSyncManager.Sync_Setting_ID
                    + "-"
                    + iOwnerModel.OwnerMobileNumberTokenID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingUserSettingModelManager>> ( strJson );
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
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }


        public static
        Task Sync_Speech_Update_Setting_ByUserID (

                Application _context ,
              SRoofingUserOwnerModelManager iOwnerModel ,
              SRoofingUserSettingModelManager iSettingModel )
        {

            try
            {

                ObservableCollection<SRoofingUserSettingModelManager> arrSettingModel = new ObservableCollection<SRoofingUserSettingModelManager> ( );

                arrSettingModel.Add ( iSettingModel );
                string jsonList = JsonConvert.SerializeObject ( arrSettingModel );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_Setting_ID
                    + "-"
                    + iOwnerModel.OwnerMobileNumberTokenID;

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
                return null;
            }

        }




        #endregion






    }
}
