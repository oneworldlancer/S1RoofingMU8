//using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
//using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Account;
////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Call;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_Screen_OpenerManager
    {



        #region Page_Opener


        public static async Task Screen_Opener_Page_Account_Dashboard (

            INavigation Navigation ,
        SRoofingLanguageTranslateModel iLanguageModel ,
            string iPageCode ,
           string iPageType ,
           string iPageTarget ,
            bool blnIsTimeDelay ,
            bool blnIsAnimated )
        {

            try
            {

                //////////await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener_WithChecker (
                //////////        Navigation ,
                //////////        typeof ( Page_Account_Dashboard ) ,
                //////////    new Page_Account_Dashboard ( iLanguageModel ) ,
                //////////    false ,
                //////////    true );

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
