using System;
using System.Collections.Generic;
using System.Text;


using Newtonsoft.Json;

using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
    class SRoofingSync_Country_Manager
    {


        public static
        void Sync_Country_Set_CountryList_All (

                Application _context ,
                ObservableCollection<SRoofingCountryModel> arrCountryModelList )
        {

            try
            {

                /*            ArrayObservableCollection <SRoofingCountryModel> arrSRoofingCountryModel = new ArrayObservableCollection <SRoofingCountryModel> ();

                            arrSRoofingCountryModel.add ( arrCountryModelList);*/
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                String strToken = SRoofingEnumUserSyncManager.Sync_Country_List_All;

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



        //
        public static async Task<ObservableCollection<SRoofingCountryModel>>
            Sync_Country_Get_CountryList_All ( Application _context )
        {

            try
            {
                ObservableCollection<SRoofingCountryModel> arrCountryModelList = new ObservableCollection<SRoofingCountryModel> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<SRoofingCountryModel>>()
                //{
                //}.getType();

                //ArrayObservableCollection<SRoofingCountryModel> arrCountryModelList = new ArrayList<>();

                String strToken = SRoofingEnumUserSyncManager.Sync_Country_List_All;
                String strJson = Preferences.Get ( strToken , String.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingCountryModel>> ( strJson );
                    //JsonConvert.DeserializeObject<ObservableCollection<SRoofingCountryModel>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<SRoofingCountryModel>)) as ObservableCollection<SRoofingCountryModel>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if ( arrCountryModelList != null )
                    {
                        return await Task.FromResult(arrCountryModelList) ;
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


        public static
        void Sync_Country_Update_CountryList_All (

                Application _context ,
                ObservableCollection<SRoofingCountryModel> arrCountryModelList )
        {

            try
            {

                /*            ArrayObservableCollection <SRoofingCountryModel> arrSRoofingCountryModel = new ArrayObservableCollection <SRoofingCountryModel> ();

                            arrSRoofingCountryModel.add ( arrCountryModelList);*/
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                String strToken = SRoofingEnumUserSyncManager.Sync_Country_List_All;

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




    }
}
