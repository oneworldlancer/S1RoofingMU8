using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumHandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_HandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Time;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;

 
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_UserManager
    {




        async public static Task<string> Initialize_User_User_GetUserPasswordByUserID (

    Application _context ,
    string iAccountType ,
    SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse (

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserHandler.ashx?"

                        + "acctyp=" + iAccountType

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                      //  + "&tuid=" + ToUserTokenID
                       // + "&tmobid=" + ToMobileNumberTokenID

                        + "&grpid=" + "0"
                        + "&grptyp=" + SRoofingEnum_GroupType.GroupType_PRIVATE

                        + "&projid=" + "0"
                        + "&bktknid=" + "0"

                        + "&fprojrolcod=" + "0"
                        + "&tprojrolcod=" + "0"

                        + "&isadmin=" + "0"

                        + "&req=" + SRoofingEnumHandler_UserHandler.Get_UserPassword_ByUserID );


                return strResult;


          
            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return "0";
            }
        }



    
    }
}
