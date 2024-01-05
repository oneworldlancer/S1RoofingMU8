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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
    class SRoofingSync_History_ScreenChatShowManager
    {





        #region User_Owner_Model



        public static
        Task<bool> Sync_History_ScreenChatShow_Set_ChatList (

                Application _context ,
                string iAccount ,
                SRoofingUserOwnerModelManager iOwnerModel ,
                ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arrSRoofingScreenChaList )
        {

            try
            {

                // ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arrSRoofingScreenChaList = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                //arrSRoofingScreenChaList.Add(iChatModel);
                string jsonList = JsonConvert.SerializeObject ( arrSRoofingScreenChaList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = iAccount
                   + iOwnerModel.OwnerMobileNumberTokenID
                   + SRoofingEnum_UserSyncManager.Sync_History_ScreenChatShowList;

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
                return Task.FromResult ( false );
            }

        }



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static async
        Task<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>> Sync_History_ScreenChatShow_Get_ChatList (
            Application _context ,
              string iAccount ,
                SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {

                ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arrCountryModelList = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();

                string strToken = iAccount
                     + iOwnerModel.OwnerMobileNumberTokenID
                     + SRoofingEnum_UserSyncManager.Sync_History_ScreenChatShowList;

                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>> ( strJson );
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


        public static
        Task Sync_History_ScreenChatShow_Update_ChatList (

                Application _context ,
                  string iAccount ,
                SRoofingUserOwnerModelManager iOwnerModel ,
                ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arrCountryModelList )
        {

            try
            {

                /*            ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> arrBashKatebLogisticsOwnerModelManager = new ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> ();

                            arrBashKatebLogisticsOwnerModelManager.add ( arrCountryModelList);*/
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = iAccount
                      + iOwnerModel.OwnerMobileNumberTokenID
                      + SRoofingEnum_UserSyncManager.Sync_History_ScreenChatShowList;

                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , jsonList );

                //Globals._blnSync_Setting_List = true;
                return null;
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }

        }



        public static
        Task Sync_History_ScreenChatShow_Reset_ChatList (

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
                      + iOwnerModel.OwnerMobileNumberTokenID
                      + SRoofingEnum_UserSyncManager.Sync_History_ScreenChatShowList;

                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set (  strToken , null );

                //Globals._blnSync_Setting_List = true;
                return null;
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
