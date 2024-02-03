//using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_Page_OpenerManager
    {



        #region Page_Opener


        public static async Task Page_Opener_WithChecker (

            INavigation Navigation ,
            Type iPageType ,
            ContentPage iPageConstructor ,
            bool blnIsTimeDelay ,
            bool blnIsAnimated )
        {

            try
            {

                MainThread.BeginInvokeOnMainThread ( async ( ) =>
        {
            // Code to run on the main thread

            if ( Navigation.NavigationStack.Count == 0 ||
Navigation.NavigationStack.Last ( ).GetType ( ) != ( iPageType ) )

            {
                //
                //                    if ( Navigation.NavigationStack.Count == 0 ||
                //Navigation.NavigationStack.Last ( ).GetType ( ) != typeof ( iPageConstructor ) )
                //                    {
                await Navigation.PushAsync ( iPageConstructor , true );

                //  await Navigation.PushAsync ( new CustomerPage ( ) , true );
            }


        } );



                //                        MainThread.BeginInvokeOnMainThread(async() =>
                //                {
                //                    // Code to run on the main thread
                //                    if ( Navigation.NavigationStack.Count == 0 ||
                //Navigation.NavigationStack.Last ( ).GetType ( ) != typeof ( CustomerPage ) )
                //                    {
                //                          await Navigation.PushAsync ( iPageConstructor , false );

                // //  await Navigation.PushAsync ( new CustomerPage ( ) , true );
                //                    }


                //                });


                //await Navigation.PopToRootAsync();
                //await Navigation.PushModalAsync(iPageConstructor, true);

                //         if (Navigation.NavigationStack.Count == 0 ||
                //Navigation.NavigationStack.Last().GetType() != typeof(iPage))
                //         {
                //             await Navigation.PushModalAsync(  iPageConstructor, true);

                //         }
                //         else
                //         {

                //             Navigation.RemovePage(  iPage );
                //             await Navigation.PushModalAsync(iPageConstructor, true);

                //         }

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }





        public static async Task Page_Opener (

            INavigation Navigation ,
            ContentPage iPageConstructor ,
            bool blnIsTimeDelay ,
            bool blnIsAnimated )
        {

            try
            {

                MainThread.BeginInvokeOnMainThread ( async ( ) =>
        {
            // Code to run on the main thread
            await Navigation.PushAsync ( iPageConstructor , true );


        } );



                //await Navigation.PopToRootAsync();
                //await Navigation.PushModalAsync(iPageConstructor, true);

                //         if (Navigation.NavigationStack.Count == 0 ||
                //Navigation.NavigationStack.Last().GetType() != typeof(iPage))
                //         {
                //             await Navigation.PushModalAsync(  iPageConstructor, true);

                //         }
                //         else
                //         {

                //             Navigation.RemovePage(  iPage );
                //             await Navigation.PushModalAsync(iPageConstructor, true);

                //         }

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }




        public static async Task Page_ModalOpener (

            INavigation Navigation ,
            ContentPage iPageConstructor ,
            bool blnIsTimeDelay ,
            bool blnIsAnimated )
        {

            try
            {

                MainThread.BeginInvokeOnMainThread ( async ( ) =>
        {
            // Code to run on the main thread

            await Navigation.PushModalAsync ( iPageConstructor , false );

        } );


                //await Navigation.PopToRootAsync();
                //await Navigation.PushModalAsync(iPageConstructor, true);

                //         if (Navigation.NavigationStack.Count == 0 ||
                //Navigation.NavigationStack.Last().GetType() != typeof(iPage))
                //         {
                //             await Navigation.PushModalAsync(  iPageConstructor, true);

                //         }
                //         else
                //         {

                //             Navigation.RemovePage(  iPage );
                //             await Navigation.PushModalAsync(iPageConstructor, true);

                //         }

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }




        public static async Task Page_Reset_Stack (

            INavigation Navigation ,
            ContentPage iPageConstructor )
        {

            try
            {
                MainThread.BeginInvokeOnMainThread ( async ( ) =>
                  {
                      // Code to run on the main thread

                      //ContentPage page = new S1RoofingMU.iSRoofingApp.iSRoofing_Page.Access.Page_Driver_Access_Code_View(); //replace 'page' with the page you want to reset to
                      //if (page == null) return;

                      //Task.Run ( async ( ) =>
                      //{
                      //} ).Wait ( );

                      ////////////////Navigation.InsertPageBefore ( iPageConstructor , Navigation.NavigationStack.FirstOrDefault ( ) );

                      ////////////////await Navigation.PopToRootAsync ( );

                      var existingPages = Navigation.NavigationStack.ToList ( );
                      foreach ( var page in existingPages )
                      {
                          if ( page != null )
                          {
                              Navigation.RemovePage ( page );
                          }
                      }


                      await Navigation.PushAsync ( iPageConstructor , true );

                  } );


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
