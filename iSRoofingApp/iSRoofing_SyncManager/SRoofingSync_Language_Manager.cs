using System;
using System.Collections.Generic;
using System.Text;
 
 
using Newtonsoft.Json;
 
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
     class SRoofingSync_Language_Manager
    {


        public static   async
        Task<bool> Sync_Language_Set_LanguageList_All(

                Application _context,
                ObservableCollection<SRoofingLanguageTranslateModel> arrLanguageModelList)
        {

            try
            {

                /*            ArrayObservableCollection <SRoofingLanguageTranslateModel> arrSRoofingLanguageTranslateModel = new ArrayObservableCollection <SRoofingLanguageTranslateModel> ();

                            arrSRoofingLanguageTranslateModel.add ( arrLanguageModelList);*/
                string jsonList = JsonConvert.SerializeObject(arrLanguageModelList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrLanguageModelList);

                String strToken = SRoofingEnumUserSyncManager.Sync_Language_List_All;

                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(strToken, jsonList);

                //Globals._blnSync_Setting_List = true;

                return await Task.FromResult ( true);

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return false;
            }

        }



                //
     public     static
     async Task    <SRoofingLanguageTranslateModel> Sync_Language_Get_LanguageList_All(Application _context)
        {

            try
            {
                ObservableCollection<SRoofingLanguageTranslateModel> arrLanguageModelList = new  ObservableCollection<SRoofingLanguageTranslateModel>();


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<SRoofingLanguageTranslateModel>>()
                //{
                //}.getType();

                //ArrayObservableCollection<SRoofingLanguageTranslateModel> arrLanguageModelList = new ArrayList<>();

                String strToken = SRoofingEnumUserSyncManager.Sync_Language_List_All;
                 String   strJson = Preferences.Get(strToken, String.Empty);


                if (Preferences.Get( strToken,null) != null)
                {

                    arrLanguageModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingLanguageTranslateModel>>(strJson);
                    //JsonConvert.DeserializeObject<ObservableCollection<SRoofingLanguageTranslateModel>>(Preferences.Get(strToken,null ).ToString);
                //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<SRoofingLanguageTranslateModel>)) as ObservableCollection<SRoofingLanguageTranslateModel>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if (arrLanguageModelList != null)
                    {
                        return await Task.FromResult( arrLanguageModelList[0]);
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






    }
}
