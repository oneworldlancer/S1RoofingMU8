using S1RoofingMU.iSRoofingApp.iSRoofing_HandlerManager;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumHandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_HandlerManager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;


namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    class SRoofing_UserAccountManager
    {


        async public static
           Task<string> UserAccount_UserAccountLoginSystem(
                   Application _context,

                    string UserID,
                     string MobileNumberID,
                     string MobileNumberE164,
                     string LoginStatus,
                    string VisibleStatus,
                   string LoginType)
        {

            try
            {

                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(
                             App.SiteDomainURL + "_iWebHandler/SRoofing_UserAccountHandler.ashx?"
                             + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")
                        + "&uid=" + UserID
                        + "&mobid=" + MobileNumberID
                        + "&mobnum164=" + MobileNumberE164
                        // + "&=" + 
                        + "&ltyp=" + LoginType
                        + "&vstatus=" + VisibleStatus
                        + "&lstatus=" + LoginStatus
                        + "&millisec=" + SRoofing_TimeManager.Time_GenerateToken()
                          + "&req=" + SRoofingEnumHandler_UserAccountHandler.UserAccount_User_LogIn);


                return strResult;


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static
           Task<string> UserAccount_UserAccountLogoutSystem(
                   Application _context,

                    string UserID,
                     string MobileNumberID,
                     string MobileNumberE164,
                     string LoginStatus,
                    string VisibleStatus,
                   string LoginType)
        {

            try
            {

                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(
                             App.SiteDomainURL + "_iWebHandler/SRoofing_UserAccountHandler.ashx?"
                             + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")
                        + "&uid=" + UserID
                        + "&mobid=" + MobileNumberID
                         + "&mobnum164=" + MobileNumberE164
                        // + "&=" + 
                        + "&ltyp=" + LoginType
                        + "&vstatus=" + VisibleStatus
                        + "&lstatus=" + LoginStatus
                        + "&millisec=" + SRoofing_TimeManager.Time_GenerateToken()
                          + "&req=" + SRoofingEnumHandler_UserAccountHandler.UserAccount_User_LogOut);


                return strResult;


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }



    }
}
