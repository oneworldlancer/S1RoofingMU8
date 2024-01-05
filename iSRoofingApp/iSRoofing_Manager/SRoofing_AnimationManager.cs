using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    class SRoofing_AnimationManager
    {



        public async static Task Animation_FadeInOut (
                       Application context ,
                View objView)
        {

            try
            {
               
                //await objView.FadeTo ( .3 , 1000 );
                //await objView.FadeTo ( .6 , 1000 );
                //await objView.FadeTo ( 1 , 1000 );


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return ;
            }

        }



    }
}
