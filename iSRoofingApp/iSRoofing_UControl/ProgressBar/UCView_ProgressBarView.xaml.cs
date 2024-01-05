using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_UControl.ProgressBar
{
    //[XamlCompilation ( XamlCompilationOptions.Compile )]
    public partial class UCView_ProgressBarView : ContentView
    {
        public UCView_ProgressBarView ( )
        {
            InitializeComponent ( );
           
            try
            {

                var lowerAnimation = new Animation(v => ll_ProgressBar.LowerRangeValue = (float)v, -0.4, 1.0);
                var upperAnimation = new Animation(v => ll_ProgressBar.UpperRangeValue = (float)v, 0.0, 1.4);

                ////////////lowerAnimation.Commit(this, "lower", length: 1000, easing: Easing.CubicInOut, repeat: () => true);
                ////////////upperAnimation.Commit(this, "upper", length: 1000, easing: Easing.CubicInOut, repeat: () => true);
              
                //////////////https://learn.microsoft.com/en-us/dotnet/maui/user-interface/animation/custom
                ////////////this.AbortAnimation("SimpleAnimation");

                //Task.Run ( async ( ) =>
                //{
                //    await Initialize ( );
                //} ).ConfigureAwait ( false );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }


        Animation lowerAnimation;
        Animation upperAnimation;



        public async Task<bool> Progress_Start() { 
        try
            {

               MainThread.BeginInvokeOnMainThread(async () =>
                               {
                // Code to run on the main thread
               
              
                ll_ProgressBar.IsVisible=true;


                lowerAnimation = new Animation(v => ll_ProgressBar.LowerRangeValue = (float)v, -0.4, 1.0);
                upperAnimation = new Animation(v => ll_ProgressBar.UpperRangeValue = (float)v, 0.0, 1.4);

                lowerAnimation.Commit(this, "lower", length: 1000, easing: Easing.SinInOut, repeat: () => true);
                upperAnimation.Commit(this, "upper", length: 1000, easing: Easing.SinInOut, repeat: () => true);

        
                               
                               });

        return true;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;

            }
        
        }



        public async Task<bool> Progress_Stop() { 
        
        try
            {

                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    // Code to run on the main thread

                this.AbortAnimation("lower");
                this.AbortAnimation("upper");

                ll_ProgressBar.IsVisible=false;

                });


                return true;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;

            }
        }



        private Random rnd = new Random ( );

        bool bln_IsNotFull = false;
        double iProgress = 0.10;
    public    async Task Initialize ( )
        {
            try
            { 
              
                MainThread.BeginInvokeOnMainThread ( async ( ) =>
                {

                     while ( true )
                {

                        //  await    ll_ProgressBar.ProgressTo ( 0.75 , 500 , Easing.Linear );


                        // await animateMe ( box1 );
                        //// await Task.Delay ( 3500 );
                        // await animateMe ( box2 );
                        //// await Task.Delay ( 7000 );
                        // await animateMe ( box3 );


                    }

                    //await  animateMe ( box4);
                    //await  animateMe ( box5);
                    //await  animateMe ( box6);
                    //await  animateMe ( box7);
                    //await  animateMe ( box8);
                    //await  animateMe ( box9);
                    //await  animateMe ( box10);



                    //for ( int i = 0 ; i < length ; i++ )
                    //{

                    //}

                    //////                    while ( !bln_IsNotFull )
                    //////{

                    //////    //   await    ll_ProgressBar.ProgressTo ( 0.75 , 500 , Easing.Linear );
                    //////    Color randomColor = Colors.FromRgb ( rnd.Next ( 256 ) , rnd.Next ( 256 ) , rnd.Next ( 256 ) );

                    //////    //   BackColor = randomColor;

                    //////    ll_ProgressBar.ProgressColor = randomColor;

                    //////    await ll_ProgressBar.ProgressTo ( iProgress , 500 , Easing.Linear );

                    //////    await Task.Delay ( 100 );

                    //////    if ( iProgress == 1.0 )
                    //////    {

                    //////        bln_IsNotFull = true;
                    //////        //    iProgress = 0.10;

                    //////        //    await Task.Delay ( 100 );

                    //////        //    ll_ProgressBar.ProgressColor = randomColor;

                    //////        //    await ll_ProgressBar.ProgressTo ( iProgress , 100 , Easing.Linear );

                    //////    }

                    //////    iProgress += 0.10;

                    //////}


                } );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }


        }



        async Task animateMe ( BoxView objBoxView )
        {

            try
            {
                MainThread.BeginInvokeOnMainThread ( async ( ) =>
                {
                    // Fade out over 3 seconds
                    await objBoxView.FadeTo ( 0.5 , 100 );
                    await Task.Delay ( 100 );
                    // Fade in over 1 second
                    await objBoxView.FadeTo ( 1 , 100 );

                } );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }
    }
}