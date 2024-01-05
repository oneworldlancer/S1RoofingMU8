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

using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;


namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
    class SRoofingSync_ImageBackground_Manager
    {

        //   SRoofingUserOwnerModelManager iOwnerModel ,



        #region  System_Chat_LightList


        public async static
        Task Sync_ImageBackground_Set_System_Chat_LightList(

                Application _context,

              ObservableCollection<SRoofingKeyValueModelManager> arrBackgroundImageList)
        {

            try
            {

                //   ObservableCollection<SRoofingKeyValueModelManager> arrBackgroundImageList = new ObservableCollection<SRoofingKeyValueModelManager> ( );

                //  arrBackgroundImageList.Add ( iSpeechModel );
                string jsonList = JsonConvert.SerializeObject(arrBackgroundImageList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_BackgroundImage_System_Chat_Light_List;


                //string strToken = SRoofingEnum_UserSyncManager.Sync_BackgroundImage_System_Chat_Light_List
                //               + "-"
                //               + iOwnerModel.OwnerMobileNumberTokenID;


                Preferences.Set(strToken, jsonList);


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static
       Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_ImageBackground_Get_System_Chat_LightList(
            Application _context)
        {

            try
            {
                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager>();


                string strToken = SRoofingEnum_UserSyncManager.Sync_BackgroundImage_System_Chat_Light_List;


                string strJson = Preferences.Get(strToken, string.Empty);


                if (Preferences.Get(strToken, null) != null)
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingKeyValueModelManager>>(strJson);

                    if (arrCountryModelList != null)
                    {
                        return Task.FromResult(arrCountryModelList );
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
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }
        }


        #endregion





        #region  System_Chat_DarkList


        public async static
        Task Sync_ImageBackground_Set_System_Chat_DarkList(

                Application _context,

              ObservableCollection<SRoofingKeyValueModelManager> arrBackgroundImageList)
        {

            try
            {

                // ObservableCollection<SRoofingKeyValueModelManager> arrBackgroundImageList = new ObservableCollection<SRoofingKeyValueModelManager> ( );

                // arrBackgroundImageList.Add ( iSpeechModel );
                string jsonList = JsonConvert.SerializeObject(arrBackgroundImageList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = SRoofingEnum_UserSyncManager.Sync_BackgroundImage_System_Chat_Dark_List;


                //string strToken = SRoofingEnum_UserSyncManager.Sync_BackgroundImage_System_Chat_Dark_List
                //               + "-"
                //               + iOwnerModel.OwnerMobileNumberTokenID;


                Preferences.Set(strToken, jsonList);


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static
       Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_ImageBackground_Get_System_Chat_DarkList(
            Application _context)
        {

            try
            {
                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager>();


                string strToken = SRoofingEnum_UserSyncManager.Sync_BackgroundImage_System_Chat_Dark_List;


                string strJson = Preferences.Get(strToken, string.Empty);


                if (Preferences.Get(strToken, null) != null)
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingKeyValueModelManager>>(strJson);

                    if (arrCountryModelList != null)
                    {
                        return Task.FromResult(arrCountryModelList );
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
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }
        }


        #endregion




        #region  User_Chat_List


        public async static
        Task Sync_ImageBackground_Set_User_Chat_List(

                Application _context,
             SRoofingUserOwnerModelManager iOwnerModel,
             SRoofingKeyValueModelManager iSpeechModel)
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arrBackgroundImageList = new ObservableCollection<SRoofingKeyValueModelManager>();

                arrBackgroundImageList.Add(iSpeechModel);
                string jsonList = JsonConvert.SerializeObject(arrBackgroundImageList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);


                string strToken = SRoofingEnum_UserSyncManager.Sync_BackgroundImage_User_Chat_List
                               + "-"
                               + iOwnerModel.OwnerMobileNumberTokenID;


                Preferences.Set(strToken, jsonList);


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static
       Task<ObservableCollection<SRoofingKeyValueModelManager>> Sync_ImageBackground_Get_User_Chat_List(
            Application _context,
              SRoofingUserOwnerModelManager iOwnerModel)
        {

            try
            {
                ObservableCollection<SRoofingKeyValueModelManager> arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager>();


                string strToken = SRoofingEnum_UserSyncManager.Sync_BackgroundImage_User_Chat_List
                               + "-"
                               + iOwnerModel.OwnerMobileNumberTokenID;



                string strJson = Preferences.Get(strToken, string.Empty);


                if (Preferences.Get(strToken, null) != null)
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingKeyValueModelManager>>(strJson);

                    if (arrCountryModelList != null)
                    {
                        return Task.FromResult(arrCountryModelList );
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
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }
        }


        #endregion








    }
}
