using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    class SRoofing_DebugManager
    {



        public static void Debug_ShowSystemMessage(

                String MessageText)
        {

            try
            {

                Console.WriteLine("mobile.S1RoofingMU:\n\n\t\t\tMAUI: " + MessageText);

                // TlknDebugManager.Debug_ShowSystemMessage(  MessageText);


                /*            Intent iIntent = new Intent(context, Activity_Alert_Message_Option_Popup.class);

                            iIntent.putExtra("PopupCode", PopupCode);
                            iIntent.putExtra("PopupAction", PopupAction);

                          activity.startActivityForResult(

                                    iIntent,
                                    ActivityIndex);*/

            }
            catch (Exception ex)
            {
                return;
            }

        }



    }
}
