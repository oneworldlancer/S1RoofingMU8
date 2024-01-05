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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager
{
    class SRoofingSync_ScreenChatShowMessageManager
    {





        #region User_Owner_Model



        public async static
        void Sync_ScreenChatShow_Add_ChatMessage_ByGroupTokenID(

                Application _context,
                string iAccount,
                SRoofingUserOwnerModelManager iOwnerModel,
                string GroupTokenID,
               SRoofingScreenChatShowMessageModelManager iChatMessageModel)
        {

            try
            {

                ObservableCollection<SRoofingScreenChatShowMessageModelManager> arrSRoofingScreenChaList = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();

                arrSRoofingScreenChaList= Sync_ScreenChatShow_Get_ChatMessage_ByGroupTokenID(
             _context,
               iAccount,
                iOwnerModel,
               GroupTokenID);


                arrSRoofingScreenChaList.Add(iChatMessageModel);


                string jsonList = JsonConvert.SerializeObject(arrSRoofingScreenChaList);


                string strToken = iAccount
                      + "-"
                      + SRoofingEnum_UserSyncManager.Sync_ChatMessageListByGroupTokenID
                     + "-"
                     + iOwnerModel.OwnerMobileNumberTokenID
                    + "-"
                    + GroupTokenID;

                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(strToken, jsonList);

                //Globals._blnSync_Setting_List = true;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }



        //     ObservableCollection<BashKatebLogisticsOwnerModelManager> Sync_User_Owner_Get_UserModel(Application _context)

        public static
       ObservableCollection<SRoofingScreenChatShowMessageModelManager> Sync_ScreenChatShow_Get_ChatMessage_ByGroupTokenID(
            Application _context,
              string iAccount,
                SRoofingUserOwnerModelManager iOwnerModel,
                string GroupTokenID)
        {

            try
            {
                ObservableCollection<SRoofingScreenChatShowMessageModelManager> arrCountryModelList = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();


                //Gson gson = new Gson();

                //Type type = new TypeToken<ArrayObservableCollection<BashKatebLogisticsOwnerModelManager>>()
                //{
                //}.getType();

                //ArrayObservableCollection<BashKatebLogisticsOwnerModelManager> arrCountryModelList = new ArrayList<>();

                string strToken = iAccount
                      + "-"
                      + SRoofingEnum_UserSyncManager.Sync_ChatMessageListByGroupTokenID
                     + "-"
                     + iOwnerModel.OwnerMobileNumberTokenID
                    + "-"
                    + GroupTokenID;

                string strJson = Preferences.Get(strToken, string.Empty);


                if (Preferences.Get(strToken, null) != null)
                {

                    arrCountryModelList =
                        JsonConvert.DeserializeObject<ObservableCollection<SRoofingScreenChatShowMessageModelManager>>(strJson);
                    //JsonConvert.DeserializeObject<ObservableCollection<BashKatebLogisticsOwnerModelManager>>(Preferences.Get(strToken,null ).ToString);
                    //new Newtonsoft.Json.JsonSerializer().Deserialize(reader, typeof(ObservableCollection<BashKatebLogisticsOwnerModelManager>)) as ObservableCollection<BashKatebLogisticsOwnerModelManager>; gson.fromJson(Preferences.Get(strToken, null), type);

                    if (arrCountryModelList != null)
                    {
                        return arrCountryModelList;
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
        void Sync_ScreenChatShow_Update_ChatMessage_ByGroupTokenID(

                Application _context,
                  string iAccount,
                SRoofingUserOwnerModelManager iOwnerModel,
                string GroupTokenID,
                ObservableCollection<SRoofingScreenChatShowMessageModelManager> arrCountryModelList)
        {

            try
            {

                /*            ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> arrBashKatebLogisticsOwnerModelManager = new ArrayObservableCollection <BashKatebLogisticsOwnerModelManager> ();

                            arrBashKatebLogisticsOwnerModelManager.add ( arrCountryModelList);*/
                string jsonList = JsonConvert.SerializeObject(arrCountryModelList);


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = iAccount
       + "-"
       + SRoofingEnum_UserSyncManager.Sync_ChatMessageListByGroupTokenID
      + "-"
      + iOwnerModel.OwnerMobileNumberTokenID
     + "-"
     + GroupTokenID;

                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(strToken, jsonList);

                //Globals._blnSync_Setting_List = true;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }



        public static
        void Sync_ScreenChatShow_Reset_ChatMessage_ByGroupTokenID(

                Application _context,
                  string iAccount,
                SRoofingUserOwnerModelManager iOwnerModel,
                string GroupTokenID)
        {

            try
            {


                //  string jsonList = JsonConvert.SerializeObject ( arrCountryModelList );


                //Gson gson = new Gson();
                //String jsonList = gson.toJson(arrCountryModelList);

                string strToken = iAccount
                      + "-"
                      + SRoofingEnum_UserSyncManager.Sync_ChatMessageListByGroupTokenID
                     + "-"
                     + iOwnerModel.OwnerMobileNumberTokenID
                    + "-"
                    + GroupTokenID;

                //TlknSharedPreference.SharedPreference_SetStringValue(

                //        _context,
                //        TlknSharedPreference.shared_SyncManager,
                //        strToken, jsonList);

                Preferences.Set(strToken, null);

                //Globals._blnSync_Setting_List = true;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }




        #endregion







    }
}
