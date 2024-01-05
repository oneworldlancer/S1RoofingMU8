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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
    class SRoofingSync_ScreenChatShowChatterManager
    {





        #region User_Owner_Model



        public static
        Task<bool> Sync_History_ScreenChatShow_Set_ChatterList_ByGroupTokenID (

                Application _context ,
                string iAccountType ,
                SRoofingUserOwnerModelManager iOwnerModel ,
                  string GroupTokenID ,
               ObservableCollection<SRoofingUserRemoteModelManager> arrSRoofingScreenChaList )
        {

            try
            {

                // ObservableCollection<SRoofingUserRemoteModelManager> arrSRoofingScreenChaList = new ObservableCollection<SRoofingUserRemoteModelManager>();

                //arrSRoofingScreenChaList.Add(iChatModel);
                string jsonList = JsonConvert.SerializeObject ( arrSRoofingScreenChaList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = iAccountType
       + "-"
         + iOwnerModel.OwnerMobileNumberTokenID
          + "-"
          + GroupTokenID
          + "-"
         + SRoofingEnum_UserSyncManager.Sync_ChatterList_User_All_Group_ID;


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
        Task<ObservableCollection<SRoofingUserRemoteModelManager>> Sync_History_ScreenChatShow_Get_ChatterList_ByGroupTokenID (
            Application _context ,
              string iAccountType ,
                SRoofingUserOwnerModelManager iOwnerModel ,
                   string GroupTokenID )
        {

            try
            {

                ObservableCollection<SRoofingUserRemoteModelManager> arrCountryModelList = new ObservableCollection<SRoofingUserRemoteModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();


                string strToken = iAccountType
       + "-"
         + iOwnerModel.OwnerMobileNumberTokenID
          + "-"
          + GroupTokenID
          + "-"
         + SRoofingEnum_UserSyncManager.Sync_ChatterList_User_All_Group_ID;



                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingUserRemoteModelManager>> ( strJson );
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
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }


        public static
        Task Sync_History_ScreenChatShow_Update_ChatterList_ByGroupTokenID (

                Application _context ,
                  string iAccountType ,
                SRoofingUserOwnerModelManager iOwnerModel ,
                string GroupTokenID ,
                ObservableCollection<SRoofingUserRemoteModelManager> arrCountryModelList )
        {

            try
            {

                /*            ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> arrBashKatebLogisticsOwnerModelManager = new ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> ();

                            arrBashKatebLogisticsOwnerModelManager.add ( arrCountryModelList);*/
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken = iAccountType
       + "-"
         + iOwnerModel.OwnerMobileNumberTokenID
          + "-"
          + GroupTokenID
          + "-"
         + SRoofingEnum_UserSyncManager.Sync_ChatterList_User_All_Group_ID;



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
        Task Sync_History_ScreenChatShow_Reset_ChatterList_ByGroupTokenID (

                Application _context ,
                  string iAccountType ,
                SRoofingUserOwnerModelManager iOwnerModel ,
                   string GroupTokenID )
        {

            try
            {


                //  string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken = iAccountType
       + "-"
         + iOwnerModel.OwnerMobileNumberTokenID
          + "-"
          + GroupTokenID
          + "-"
         + SRoofingEnum_UserSyncManager.Sync_ChatterList_User_All_Group_ID;



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






        #region User_Owner_Model



        public static
        Task<bool> Sync_History_ScreenChatShow_Set_Filter_ChatterList_ByGroupTokenID (

                Application _context ,
                string iAccountType ,
                SRoofingUserOwnerModelManager iOwnerModel ,
                string GroupTokenID ,
                ObservableCollection<SRoofingUserGroupModelManager> arrSRoofingScreenChaList )
        {

            try
            {

                // ObservableCollection<SRoofingUserGroupModelManager> arrSRoofingScreenChaList = new ObservableCollection<SRoofingUserGroupModelManager>();

                //arrSRoofingScreenChaList.Add(iChatModel);
                string jsonList = JsonConvert.SerializeObject ( arrSRoofingScreenChaList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = iAccountType
        + "-"
          + iOwnerModel.OwnerMobileNumberTokenID
           + "-"
           + GroupTokenID
           + "-"
          + SRoofingEnum_UserSyncManager.Sync_ChatterList_User_Filter_Group_ID;


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
        Task<ObservableCollection<SRoofingUserGroupModelManager>> Sync_History_ScreenChatShow_Get_Filter_ChatterList_ByGroupTokenID (
            Application _context ,
              string iAccountType ,
                SRoofingUserOwnerModelManager iOwnerModel ,
                  string GroupTokenID )
        {

            try
            {

                ObservableCollection<SRoofingUserGroupModelManager> arrCountryModelList = new ObservableCollection<SRoofingUserGroupModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();

                string strToken = iAccountType
      + "-"
        + iOwnerModel.OwnerMobileNumberTokenID
         + "-"
         + GroupTokenID
         + "-"
        + SRoofingEnum_UserSyncManager.Sync_ChatterList_User_Filter_Group_ID;


                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingUserGroupModelManager>> ( strJson );
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
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }


        public static
        Task Sync_History_ScreenChatShow_Update_Filter_ChatterList_ByGroupTokenID (

                Application _context ,
                  string iAccountType ,
                SRoofingUserOwnerModelManager iOwnerModel ,
               string GroupTokenID ,
                  ObservableCollection<SRoofingUserGroupModelManager> arrCountryModelList )
        {

            try
            {

                /*            ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> arrBashKatebLogisticsOwnerModelManager = new ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> ();

                            arrBashKatebLogisticsOwnerModelManager.add ( arrCountryModelList);*/
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = iAccountType
      + "-"
        + iOwnerModel.OwnerMobileNumberTokenID
         + "-"
         + GroupTokenID
         + "-"
        + SRoofingEnum_UserSyncManager.Sync_ChatterList_User_Filter_Group_ID;


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
        Task Sync_History_ScreenChatShow_Reset_Filter_ChatterList_ByGroupTokenID (

                Application _context ,
                  string iAccountType ,
                SRoofingUserOwnerModelManager iOwnerModel ,
                  string GroupTokenID )
        {

            try
            {


                //  string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = iAccountType
                    + "-"
                      + iOwnerModel.OwnerMobileNumberTokenID
                       + "-"
                       + GroupTokenID
                       + "-"
                      + SRoofingEnum_UserSyncManager.Sync_ChatterList_User_Filter_Group_ID;

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
