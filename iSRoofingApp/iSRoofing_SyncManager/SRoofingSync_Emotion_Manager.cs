using System;
using System.Collections.Generic;
using System.Text;
 
 
using Newtonsoft.Json;
 
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using System.Threading.Tasks;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
     class SRoofingSync_Emotion_Manager
    {


        public static       async
        Task<bool> Sync_Emotion_Set_List_All(

                Application _context,
                ObservableCollection<string> arrCountryModelList)
        {

            try
            {

                /*            ArrayObservableCollection <SRoofingCountryModel> arrSRoofingCountryModel = new ArrayObservableCollection <SRoofingCountryModel> ();

                            arrSRoofingCountryModel.add ( arrCountryModelList);*/
                string jsonList = JsonConvert.SerializeObject(arrCountryModelList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                String strToken = SRoofingEnumUserSyncManager.Sync_Emotion_List;

                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(strToken, jsonList);

                //Globals._blnSync_Setting_List = true;

              return  await Task.FromResult ( true );
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                     return   await Task.FromResult ( false );
            }

        }



                //
     public     static
      async Task<ObservableCollection<string>>   Sync_Emotion_Get_List_All(Application _context)
        {

            try
            {
                ObservableCollection<string> arrCountryModelList = new  ObservableCollection<string>();


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<string>>()
                //{
                //}.getType();

                //ArrayObservableCollection<string> arrCountryModelList = new ArrayList<>();

                String strToken = SRoofingEnumUserSyncManager.Sync_Emotion_List;
                 String   strJson = Preferences.Get(strToken, String.Empty);


                if (Preferences.Get( strToken,null) != null)
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<string>>(strJson);
                    //JsonConvert.DeserializeObject<ObservableCollection<string>>(Preferences.Get(strToken,null ).ToString);
                //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<string>)) as ObservableCollection<string>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if (arrCountryModelList != null)
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
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }


        public static
        async Task<bool> Sync_Emotion_Update_List_All(

                Application _context,
                ObservableCollection<string> arrCountryModelList)
        {

            try
            {

                /*            ArrayObservableCollection <SRoofingCountryModel> arrSRoofingCountryModel = new ArrayObservableCollection <SRoofingCountryModel> ();

                            arrSRoofingCountryModel.add ( arrCountryModelList);*/
                string jsonList = JsonConvert.SerializeObject(arrCountryModelList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                String strToken = SRoofingEnumUserSyncManager.Sync_Emotion_List;

                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(    strToken, jsonList);

                //Globals._blnSync_Setting_List = true;
             return   await Task.FromResult ( true );

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return await Task.FromResult(false);
            }

        }




    }
}
