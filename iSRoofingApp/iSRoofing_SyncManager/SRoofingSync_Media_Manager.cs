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
    class SRoofingSync_Media_Manager
    {

        #region Image_ByImageTokenID



        public static
           void Sync_Media_Set_Image_ByImageTokenID(

                   Application _context,
                   string MediaTokenID,
                   string MediaDataBase64)
        {

            try
            {

                string jsonList = JsonConvert.SerializeObject(MediaDataBase64);

                string strToken = SRoofingEnum_UserSyncManager.Sync_Media_Image_ByImageTokenID
                    + "-"
                    + "img_" + MediaTokenID;

                Preferences.Set(strToken, jsonList);

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }

        public static
           string Sync_Media_Get_Image_ByImageTokenID(Application _context,
                   string MediaTokenID)
        {

            try
            {

                string strToken = SRoofingEnum_UserSyncManager.Sync_Media_Image_ByImageTokenID
                   + "-"
                   + "img_" + MediaTokenID;


                string strJson = Preferences.Get(strToken, string.Empty);


                if (Preferences.Get(strToken, null) != null)
                {

                    return Preferences.Get(strToken, null).Replace("\"", string.Empty);
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

        public static
           void Sync_Media_Reset_Image_ByImageTokenID(Application _context,
                   string MediaTokenID)
        {

            try
            {

                string strToken = SRoofingEnum_UserSyncManager.Sync_Media_Image_ByImageTokenID
                   + "-"
                   + "img_" + MediaTokenID;

                string strJson = Preferences.Get(strToken, string.Empty);

                if (Preferences.Get(strToken, null) != null)
                {

                    Preferences.Remove(strToken);
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        #endregion



        #region Video_ByVideoTokenID



        public static
           void Sync_Media_Set_Video_ByVideoTokenID(

                   Application _context,
                   string MediaTokenID,
                   string MediaDataBase64)
        {

            try
            {

                string jsonList = JsonConvert.SerializeObject(MediaDataBase64);

                string strToken = SRoofingEnum_UserSyncManager.Sync_Media_Video_ByVideoTokenID
                    + "-"
                    + "vid_" + MediaTokenID;

                Preferences.Set(strToken, jsonList);

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }

        public static
           string Sync_Media_Get_Video_ByVideoTokenID(Application _context,
                   string MediaTokenID)
        {

            try
            {

                string strToken = SRoofingEnum_UserSyncManager.Sync_Media_Video_ByVideoTokenID
                   + "-"
                   +  "vid_" + MediaTokenID;


                string strJson = Preferences.Get(strToken, string.Empty);


                if (Preferences.Get(strToken, null) != null)
                {

                    return Preferences.Get(strToken, null).Replace("\"", string.Empty);
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

        public static
           void Sync_Media_Reset_Video_ByVideoTokenID(Application _context,
                   string MediaTokenID)
        {

            try
            {

                string strToken = SRoofingEnum_UserSyncManager.Sync_Media_Video_ByVideoTokenID
                   + "-"
                   +  "vid_" + MediaTokenID;

                string strJson = Preferences.Get(strToken, string.Empty);

                if (Preferences.Get(strToken, null) != null)
                {

                    Preferences.Remove(strToken);
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        #endregion



        #region Document_ByDocumentTokenID



        public static
           void Sync_Media_Set_Document_ByDocumentTokenID(

                   Application _context,
                   string MediaTokenID,
                   string MediaDataBase64)
        {

            try
            {

                string jsonList = JsonConvert.SerializeObject(MediaDataBase64);

                string strToken = SRoofingEnum_UserSyncManager.Sync_Media_Document_ByDocumentTokenID
                    + "-"
                    +  "doc_" + MediaTokenID;

                Preferences.Set(strToken, jsonList);

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }

        public static
           string Sync_Media_Get_Document_ByDocumentTokenID(Application _context,
                   string MediaTokenID)
        {

            try
            {

                string strToken = SRoofingEnum_UserSyncManager.Sync_Media_Document_ByDocumentTokenID
                   + "-"
                   +   "doc_" + MediaTokenID;


                string strJson = Preferences.Get(strToken, string.Empty);


                if (Preferences.Get(strToken, null) != null)
                {

                    return Preferences.Get(strToken, null).Replace("\"", string.Empty);
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

        public static
           void Sync_Media_Reset_Document_ByDocumentTokenID(Application _context,
                   string MediaTokenID)
        {

            try
            {

                string strToken = SRoofingEnum_UserSyncManager.Sync_Media_Document_ByDocumentTokenID
                   + "-"
                   +   "doc_" + MediaTokenID;

                string strJson = Preferences.Get(strToken, string.Empty);

                if (Preferences.Get(strToken, null) != null)
                {

                    Preferences.Remove(strToken);
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        #endregion




    }
}
