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
using System.ComponentModel;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
    class SRoofingSync_User_RemoteManager
    {



        #region User_Remote_Model



        public async static
        Task Sync_User_Remote_Set_UserModel (

                Application _context ,
                SRoofingUserOwnerModelManager iOwnerModel ,
              SRoofingUserRemoteModelManager iItem )
        {

            try
            {

                ObservableCollection<SRoofingUserRemoteModelManager> arrItemList = new ObservableCollection<SRoofingUserRemoteModelManager> ( );

                arrItemList.Add ( iItem );

                string jsonList = JsonConvert.SerializeObject ( arrItemList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);
                string strToken =
                             SRoofingEnum_UserSyncManager.Sync_Profile_RemoteUserID
                               + "-"
                               + iOwnerModel.OwnerMobileNumberTokenID
                               + "-"
                               + iItem.OwnerMobileNumberTokenID;




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



        //     ObservableCollection<BashKatebLogisticsRemoteModelManager> Sync_User_Remote_Get_UserModel(Application _context)

        public static
       async Task<SRoofingUserRemoteModelManager> Sync_User_Remote_Get_UserModel (
            Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
                string RemoteUserTokenID ,
                string RemoteMobileNumberTokenID )
        {

            try
            {
                ObservableCollection<SRoofingUserRemoteModelManager> arrCountryModelList = new ObservableCollection<SRoofingUserRemoteModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsRemoteModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsRemoteModelManager> arrCountryModelList = new ArrayList<>();

                string strToken =
               SRoofingEnum_UserSyncManager.Sync_Profile_RemoteUserID
                 + "-"
                 + iOwnerModel.OwnerMobileNumberTokenID
                 + "-"
                 + RemoteMobileNumberTokenID;



                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingUserRemoteModelManager>> ( strJson );
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsRemoteModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsRemoteModelManager>)) as ObservableCollection<BashKatebLogisticsRemoteModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

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
        void Sync_User_Remote_Update_UserModel (

                Application _context ,
                 SRoofingUserOwnerModelManager iOwnerModel ,
                SRoofingUserRemoteModelManager iItem )
        {

            try
            {

                ObservableCollection<SRoofingUserRemoteModelManager> arrItemList = new ObservableCollection<SRoofingUserRemoteModelManager> ( );

                arrItemList.Add ( iItem );

                string jsonList = JsonConvert.SerializeObject ( arrItemList );



                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken =
                  SRoofingEnum_UserSyncManager.Sync_Profile_RemoteUserID
                    + "-"
                    + iOwnerModel.OwnerMobileNumberTokenID
                    + "-"
                    + iItem.OwnerMobileNumberTokenID;


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




        #region User_Remote_Model



        public async static
        Task Sync_User_Remote_Set_Current_Profile_UserModel (

                Application _context ,
                SRoofingUserOwnerModelManager iOwnerModel ,
              SRoofingUserRemoteModelManager iItem )
        {

            try
            {

                ObservableCollection<SRoofingUserRemoteModelManager> arrItemList = new ObservableCollection<SRoofingUserRemoteModelManager> ( );

                arrItemList.Add ( iItem );

                string jsonList = JsonConvert.SerializeObject ( arrItemList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);
                string strToken =
                             SRoofingEnum_UserSyncManager.Sync_Profile_Current_RemoteUserID
                               + "-"
                               + iOwnerModel.OwnerMobileNumberTokenID
                               + "-"
                               + iItem.OwnerMobileNumberTokenID;




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



        //     ObservableCollection<BashKatebLogisticsRemoteModelManager> Sync_User_Remote_Get_UserModel(Application _context)

        public static
        async Task<SRoofingUserRemoteModelManager> Sync_User_Remote_Get_Current_UserModel (
            Application _context ,
               SRoofingUserOwnerModelManager iOwnerModel ,
                string RemoteUserTokenID ,
                string RemoteMobileNumberTokenID )
        {

            try
            {
                ObservableCollection<SRoofingUserRemoteModelManager> arrCountryModelList = new ObservableCollection<SRoofingUserRemoteModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsRemoteModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsRemoteModelManager> arrCountryModelList = new ArrayList<>();

                string strToken =
               SRoofingEnum_UserSyncManager.Sync_Profile_Current_RemoteUserID
                 + "-"
                 + iOwnerModel.OwnerMobileNumberTokenID
                 + "-"
                 + RemoteMobileNumberTokenID;



                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingUserRemoteModelManager>> ( strJson );
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsRemoteModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsRemoteModelManager>)) as ObservableCollection<BashKatebLogisticsRemoteModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

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
                return null;
            }
        }


        public static
        void Sync_User_Remote_Update_Current_UserModel (

                Application _context ,
                 SRoofingUserOwnerModelManager iOwnerModel ,
                SRoofingUserRemoteModelManager iItem )
        {

            try
            {

                ObservableCollection<SRoofingUserRemoteModelManager> arrItemList = new ObservableCollection<SRoofingUserRemoteModelManager> ( );

                arrItemList.Add ( iItem );

                string jsonList = JsonConvert.SerializeObject ( arrItemList );



                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken =
                  SRoofingEnum_UserSyncManager.Sync_Profile_Current_RemoteUserID
                    + "-"
                    + iOwnerModel.OwnerMobileNumberTokenID
                    + "-"
                    + iItem.OwnerMobileNumberTokenID;


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







    }
}
