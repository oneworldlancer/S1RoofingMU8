//using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
//////////////////////////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
////////////////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Login;
////////////////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Register;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Splash
{
    //////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Splash_DashboardX1 : ContentPage
    {
        public SRoofingLanguageTranslateModel _iLanguageModel { get; set; } = new SRoofingLanguageTranslateModel();

        public Page_Splash_DashboardX1()
        {

            InitializeComponent();


            try
            {

                //MainThread.BeginInvokeOnMainThread(async () =>
                //{

                //    //IconTintColorEffect.SetTintColor ( img_Register , Colors.White );
                //    //IconTintColorEffect.SetTintColor ( img_Login , Colors.White );
                //});


                //    var current = Connectivity.NetworkAccess;
                //Connectivity_Get_Status ( current );


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }

        public Page_Splash_DashboardX1(SRoofingLanguageTranslateModel iLanguageModel)
        {
            InitializeComponent();


            try
            {

                //_iLanguageModel = iLanguageModel;

                //Task.Run(async () =>
                //{
                //    await Initialize();

                //}).Wait();

              
                
                
                
                /////////////////////////
                
                
                
                
                
                
                
                
                
                
                //////MainThread.BeginInvokeOnMainThread(async () =>
                //////  {

                //////      //// IconTintColorEffect.SetTintColor ( img_Register , Colors.White );
                //////      //IconTintColorEffect.SetTintColor ( img_Login , Colors.White );
                //////  });


                //    var current = Connectivity.NetworkAccess;
                //Connectivity_Get_Status ( current );


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }



        }



        async Task Initialize()
        {
            try
            {

                await Initialize_AppTranslation();


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }




        #region Navigation

        async private void btn_PageDashboard_Clicked(object sender, EventArgs e)
        {

            try
            {

                ////////await SRoofing_Page_OpenerManager.Page_Opener (
                ////////                       Navigation ,
                ////////                   new Page_Dashboard ( ) ,
                ////////                   false ,
                ////////                   true );


                //await SRoofing_Page_OpenerManager.Page_Opener(
                //                                 Navigation ,
                //                             new Page_Landing_Dashboard ( ) ,
                //                             false ,
                //                             true);


                //await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener (
                //                       Navigation ,
                //                   new Register.Marshal.Page_Marshal_Login_Dashboard ("login") ,
                //                   false ,
                //                   true);
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }




        async void btn_Login_Clicked(object sender, EventArgs e)
        {
            ////////////////////try
            ////////////////////{


            ////////////////////    await SRoofing_Page_OpenerManager.Page_Opener (
            ////////////////////            Navigation ,
            ////////////////////        new Page_Login_Dashboard ( _iLanguageModel ) ,
            ////////////////////        false ,
            ////////////////////        true );

            ////////////////////}
            ////////////////////catch ( Exception ex )
            ////////////////////{
            ////////////////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            ////////////////////    return;
            ////////////////////}


        }

        async void btn_Register_Clicked(object sender, EventArgs e)
        {
            ////////////////////try
            ////////////////////{


            ////////////////////    await SRoofing_Page_OpenerManager.Page_Opener (
            ////////////////////            Navigation ,
            ////////////////////        new Page_Register_Dashboard ( _iLanguageModel ) ,
            ////////////////////        false ,
            ////////////////////        true );

            ////////////////////}
            ////////////////////catch ( Exception ex )
            ////////////////////{
            ////////////////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            ////////////////////    return;
            ////////////////////}

        }
      
        #endregion


        #region Initialize


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                StartListening();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            try
            {

                //MessagingCenter.Unsubscribe<App , string> ( App.Current as App , "tracking" );

                StopListening();
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }
        }



        #endregion


        #region Connectivity_Internet

        public void StartListening()
        {
            // Register for connectivity changes
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        public void StopListening()
        {
            // Un-register listener for changes
            Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;
        }

        void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {

            try
            {


                //var access = e.NetworkAccess;
                //// Update UI or notify the user

                var current = Connectivity.NetworkAccess;
                Connectivity_Get_Status(current);
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }




        private void Connectivity_Get_Status(NetworkAccess networkAccess)
        {

            try
            {

                //lbl_Message.Text = networkAccess.ToString();

                switch (networkAccess)
                {
                    case NetworkAccess.Internet:
                        // Connected to internet
                        //   //ll_NetConnection.Color = ColorConverters.FromHex ( "#d9a700" );
                        //  ll_NetConnection.Color = Colors.Black;// ColorConverters.FromHex ( "#d9a700" );
                        break;
                    case NetworkAccess.Local:
                        // Only local network access
                        //   //ll_NetConnection.Color = ColorConverters.FromHex ( "#d9a700" );
                        // ll_NetConnection.Color = Colors.Black;
                        break;
                    case NetworkAccess.ConstrainedInternet:
                        // Connected, but limited internet access such as behind a network login page
                        // //ll_NetConnection.Color = ColorConverters.FromHex ( "#d9a700" );
                        //  ll_NetConnection.Color = Colors.Black;
                        break;
                    case NetworkAccess.None:
                        // No internet available
                        // ll_NetConnection.Color = Colors.Red;
                      ////////////////////////  SRoofing_ToastMessageManager.ToastMessage_Show_Message(iSnackBar, SRoofingEnum_Toast_MessageManager.Message_Internet_Connection.PopupMessage_MessageConnectionFalse());

                        break;
                    case NetworkAccess.Unknown:
                        // Internet access is unknown
                        // //ll_NetConnection.Color = ColorConverters.FromHex ( "#d9a700" );
                        break;
                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }






        #endregion



        #region Initialize_LanguageModel


        async Task Initialize_AppTranslation()
        {
          
   //////////         try
   //////////         {
   //////////             MainThread.BeginInvokeOnMainThread(async () =>
   //////////{


   //////////    if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);

   //////////    if (_iLanguageModel.LanguageCode=="ar")
   //////////    {
   //////////        lbl_WelcomeTo_RTL.Text = _iLanguageModel.lblText_Splash_WelcomeTo;
   //////////        lbl_WelcomeTo_RTL.IsVisible = true;
   //////////        lbl_WelcomeTo_LTR.IsVisible = false;
   //////////    }
   //////////    else
   //////////    {
   //////////        lbl_WelcomeTo_LTR.Text = _iLanguageModel.lblText_Splash_WelcomeTo;
   //////////        lbl_WelcomeTo_RTL.IsVisible =false;
   //////////        lbl_WelcomeTo_LTR.IsVisible = true;

   //////////    }


   //////////    btn_Register.Text = _iLanguageModel.lblText_Splash_CreateAccount;
   //////////    btn_Login.Text = _iLanguageModel.lblText_Splash_SignIn;

   //////////});


   //////////         }
   //////////         catch (Exception ex)
   //////////         {
   //////////             SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
   //////////             return;
   //////////         }
       
        
        }





        #endregion

        //private void page_SplashDashboard_Loaded(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        Task.Run(async () =>
        //        {
        //            await Initialize();

        //        }).Wait();


        //    }
        //    catch (Exception ex)
        //    {
        //        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //        return;

        //    }
        //}
    }
}