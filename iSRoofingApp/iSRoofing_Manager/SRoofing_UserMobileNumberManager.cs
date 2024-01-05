using S1RoofingMU.iSRoofingApp.iSRoofing_HandlerManager;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumHandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_HandlerManager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    class SRoofing_UserMobileNumberManager
    {


        async public static
           Task<string> UserMobileNumber_Get_OwnerUserTokenID_ByMobileNumberE164(
                   Application _context,
                 String MobileNumberE164)
        {

            try
            {

                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(
                             App.SiteDomainURL + "_iWebHandler/SRoofing_UserMobileNumberHandler.ashx?"
                             + "mobnum164=" + MobileNumberE164
                             + "&req=" + SRoofing_EnumUserMobileNumberHandler.Get_OwnerUserTokenID_ByUserMobileNumberE164);


                return strResult;

                /*
                return  SRoofing_HandlerManager.Handler_GetResponse (
                        Globals.SiteDomainURL + "Handler/SRoofingUserHandler.ashx?"
                        + "mobnum164=" + MobileNumberE164.substring (
                                1,
                                MobileNumberE164.length ())
                        + "&req=" + TlknEnumUserHandler.GetUserIDByUserMobileNumberE164);
    */

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }





        async public static
        Task<string> UserMobileNumber_Get_OwnerMobileNumberTokenID_ByMobileNumberE164(
                  Application _context,
                  String MobileNumberE164)
        {

            try
            {

                var strResult = "0";
                
                strResult = await SRoofing_HandlerManager.Handler_GetResponse(
                            App.SiteDomainURL + "_iWebHandler/SRoofing_UserMobileNumberHandler.ashx?"
                            + "mobnum164=" + MobileNumberE164
                            + "&req=" + SRoofing_EnumUserMobileNumberHandler.Get_OwnerMobileNumberTokenID_ByMobileNumberE164);

                return strResult;

                /*
                return  SRoofing_HandlerManager.Handler_GetResponse (
                        Globals.SiteDomainURL + "Handler/SRoofingUserHandler.ashx?"
                        + "mobnum164=" + MobileNumberE164.substring (
                                1,
                                MobileNumberE164.length ())
                        + "&req=" + TlknEnumUserHandler.GetUserMobileNumberIDByMobileNumberE164);
    */

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }



    }
}
