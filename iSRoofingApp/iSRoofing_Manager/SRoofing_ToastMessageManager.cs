using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;


using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;


namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
    {
    public class SRoofing_ToastMessageManager
        {

        public static void ToastMessage_Show_Message (
         SnackBar iSnackBar ,
         string strMessage )
            {

            try
                {
                //SnackB.Message = "I'm a snack bar... I love showing my self.";
                //iSnackBar.Message =strMessage ;
                iSnackBar.Open ( strMessage );
                //SnackB.IsOpen = !SnackB.IsOpen;
                }
            catch ( Exception ex )
                {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );

                }
            }

     
    
    
    
    
      public static async  Task ToastMessage_Show_Message (
         //SnackBar iSnackBar ,
         string strMessage )
            {

            try
                {


                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    // Code to run on the main thread
                 
                //  iSnackBar.Open ( strMessage );

                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                await Toast.Make(strMessage,
                          ToastDuration.Long,
                          15)
                    .Show(cancellationTokenSource.Token);

                });



            }
            catch ( Exception ex )
                {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );

                }
            }

     
    
    
    
    
    
    
    
    
    }
    }
