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

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
    {
  public  class SRoofingSync_User_OwnerManager
        {

        #region OwnerUserTokenID



        public static
           void Sync_Owner_Set_OwnerUserTokenID (

                   Application _context ,
                   string iOwnerUserTokenID )
            {

            try
                {

                string jsonList = JsonConvert.SerializeObject ( iOwnerUserTokenID );

                string strToken = SRoofingEnum_UserSyncManager.Sync_OwnerUserTokenID;

                Preferences.Set (  strToken , jsonList );

                }
            catch (Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
                }

            }

        public static
           string Sync_Owner_Get_OwnerUserTokenID ( Application _context )
            {

            try
                {

                string strToken = SRoofingEnum_UserSyncManager.Sync_OwnerUserTokenID;
                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                    {

                    return Preferences.Get (  strToken , null ).Replace ( "\"" , string.Empty );
                    }
                else
                    {
                    return null;
                    }
                }
            catch (Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
                }
            }

        public static
           void Sync_Owner_Reset_OwnerUserTokenID ( Application _context )
            {

            try
                {

                string strToken = SRoofingEnum_UserSyncManager.Sync_OwnerUserTokenID;
                string strJson = Preferences.Get ( strToken , string.Empty );

                if ( Preferences.Get ( strToken , null ) != null )
                    {

                    Preferences.Remove ( strToken );
                    }

                }
            catch (Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
                }
            }



        #endregion


        #region OwnerMobileNumberTokenID



        public static
        void Sync_Owner_Set_OwnerMobileNumberTokenID (

                Application _context ,
                string iOwnerMobileNumberTokenID )
            {

            try
                {

                string jsonList = JsonConvert.SerializeObject ( iOwnerMobileNumberTokenID );

                string strToken = SRoofingEnum_UserSyncManager.Sync_OwnerMobileNumberTokenID;

                Preferences.Set (  strToken , jsonList );

                }
            catch (Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
                }

            }

        public static
           string Sync_Owner_Get_OwnerMobileNumberTokenID ( Application _context )
            {

            try
                {

                string strToken = SRoofingEnum_UserSyncManager.Sync_OwnerMobileNumberTokenID;
                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                    {

                    return Preferences.Get (  strToken , null ).Replace ( "\"" , string.Empty );
                    }
                else
                    {
                    return null;
                    }
                }
            catch (Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
                }
            }

        public static
           void Sync_Owner_Reset_OwnerMobileNumberTokenID ( Application _context )
            {

            try
                {

                string strToken = SRoofingEnum_UserSyncManager.Sync_OwnerMobileNumberTokenID;
                string strJson = Preferences.Get ( strToken , string.Empty );

                if ( Preferences.Get ( strToken , null ) != null )
                    {

                    Preferences.Remove ( strToken );
                    }

                }
            catch (Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
                }
            }



        #endregion




        #region VisibleStatus



        public static
        void Sync_Owner_Set_VisibleStatus (

                Application _context ,
                string iVisibleStatus )
            {

            try
                {

                string jsonList = JsonConvert.SerializeObject ( iVisibleStatus );

                string strToken = SRoofingEnum_UserSyncManager.Sync_Owner_VisibleStatus;

                Preferences.Set (  strToken , jsonList );

                }
            catch (Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
                }

            }

        public static
           string Sync_Owner_Get_VisibleStatus ( Application _context )
            {

            try
                {

                string strToken = SRoofingEnum_UserSyncManager.Sync_Owner_VisibleStatus;
                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                    {

                    return Preferences.Get (  strToken , null ).Replace ( "\"" , string.Empty );
                    }
                else
                    {
                    return null;
                    }
                }
            catch (Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
                }
            }

        public static
           void Sync_Owner_Reset_VisibleStatus ( Application _context )
            {

            try
                {

                string strToken = SRoofingEnum_UserSyncManager.Sync_Owner_VisibleStatus;
                string strJson = Preferences.Get ( strToken , string.Empty );

                if ( Preferences.Get ( strToken , null ) != null )
                    {

                    Preferences.Remove ( strToken );
                    }

                }
            catch (Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
                }
            }



        #endregion




        #region LoginStatus



        public static
        void Sync_Owner_Set_LoginStatus (

                Application _context ,
                string iLoginStatus )
            {

            try
                {

                string jsonList = JsonConvert.SerializeObject ( iLoginStatus );

                string strToken = SRoofingEnum_UserSyncManager.Sync_Owner_LoginStatus;

                Preferences.Set (  strToken , jsonList );

                }
            catch (Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
                }

            }

        public static
           string Sync_Owner_Get_LoginStatus ( Application _context )
            {

            try
                {

                string strToken = SRoofingEnum_UserSyncManager.Sync_Owner_LoginStatus;
                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                    {

                    return Preferences.Get (  strToken , null ).Replace ( "\"" , string.Empty );
                    }
                else
                    {
                    return null;
                    }
                }
            catch (Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
                }
            }

        public static
           void Sync_Owner_Reset_LoginStatus ( Application _context )
            {

            try
                {

                string strToken = SRoofingEnum_UserSyncManager.Sync_Owner_LoginStatus;
                string strJson = Preferences.Get ( strToken , string.Empty );

                if ( Preferences.Get ( strToken , null ) != null )
                    {

                    Preferences.Remove ( strToken );
                    }

                }
            catch (Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
                }
            }



        #endregion









        #region User_Owner_Model



        public async static
        Task Sync_User_Owner_Set_UserModel (

                Application _context ,
              SRoofingUserOwnerModelManager iItem )
            {

            try
                {

            ObservableCollection<SRoofingUserOwnerModelManager> arrItemList = new ObservableCollection<SRoofingUserOwnerModelManager>();

                arrItemList.Add(iItem);
            
                string jsonList = JsonConvert.SerializeObject (arrItemList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_Profile_OwnerUserID;

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
      async Task<SRoofingUserOwnerModelManager>     Sync_User_Owner_Get_UserModel ( Application _context )
            {

            try
                {
                ObservableCollection<SRoofingUserOwnerModelManager> arrCountryModelList = new ObservableCollection<SRoofingUserOwnerModelManager> ( );


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();

                string strToken = SRoofingEnum_UserSyncManager.Sync_Profile_OwnerUserID;
                string strJson = Preferences.Get ( strToken , string.Empty );


                if ( Preferences.Get ( strToken , null ) != null )
                    {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingUserOwnerModelManager>> ( strJson );
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsOwnerModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsOwnerModelManager>)) as ObservableCollection<BashKatebLogisticsOwnerModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if ( arrCountryModelList != null )
                        {
                        return await Task.FromResult( arrCountryModelList [ 0 ]);
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
        void Sync_User_Owner_Update_UserModel (

                Application _context ,
                ObservableCollection<SRoofingUserOwnerModelManager> arrCountryModelList )
            {

            try
                {

                /*            ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> arrBashKatebLogisticsOwnerModelManager = new ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> ();

                            arrBashKatebLogisticsOwnerModelManager.add ( arrCountryModelList);*/
                string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_Profile_OwnerUserID;

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




        #endregion







        }
    }
