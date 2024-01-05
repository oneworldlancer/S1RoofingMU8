using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
//using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Register;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Splash;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.Xaml;

using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Launcher;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Login
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Login_Dashboard : ContentPage
    {
        public SRoofingLanguageTranslateModel _iLanguageModel { get; set; }

        public Page_Login_Dashboard()
        {
            InitializeComponent();

            //  img_Logo.Focus();

            // TapGestureRecognizer_Tapped(this,null);
            //if (DeviceInfo.Current.Platform.ToString()== Device.Android)
            //{

            //}


            BindingContext = this;
        }

        public Page_Login_Dashboard(SRoofingLanguageTranslateModel iLanguageModel)
        {

            InitializeComponent();

            _iLanguageModel = iLanguageModel;


            Task.Run(async () =>
                 {
                     await Initialize();

                 }).Wait();










            //  img_Logo.Focus();

            // TapGestureRecognizer_Tapped(this,null);
            //if (DeviceInfo.Current.Platform.ToString()== Device.Android)
            //{

            //}


            BindingContext = this;
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













        #region SnackBar


        public async Task Snack_ShowMessage(string strMessage)
        {

            try
            {

                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    // Code to run on the main thread
                    // iSnackBar.BackgroundColor = Colors.Red;

                    //  SRoofing_ToastMessageManager.ToastMessage_Show_Message ( iSnackBar , strMessage );
                    await SRoofing_ToastMessageManager.ToastMessage_Show_Message(strMessage);

                    //////CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                    //////await Toast.Make(strMessage,
                    //////          ToastDuration.Long,
                    //////          15)
                    //////    .Show(cancellationTokenSource.Token);

                });
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }
        #endregion

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }


        public void Lose_Focus()
        {

            img_Logo.Focus();
        }





        #region Initialize_LanguageModel


        async Task Initialize_AppTranslation()
        {
            try
            {

                MainThread.BeginInvokeOnMainThread(async () =>
                   {
                       if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);


                       lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;
                       btn_Close_Window.Text = _iLanguageModel.lblText_Command_CANCEL_Message;


                       ////btn_Register.Text = _iLanguageModel.lblText_Splash_CreateAccount;
                       ////btn_Login.Text = _iLanguageModel.lblText_Splash_SignIn;

                       await vw_LogIn_View.Initialize_AppTranslation(_iLanguageModel);
                       await vw_Password_View.Initialize_AppTranslation(_iLanguageModel);


                   });
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        public async Task Initialize_AppTranslation_Title_Password()
        {
            try
            {

                MainThread.BeginInvokeOnMainThread(async () =>
                   {
                       if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);


                       lbl_Title.Text = _iLanguageModel.lblText_Title_Password;

                       //btn_Close_Window.Text = _iLanguageModel.lblText_Command_CANCEL_Message;


                       //////btn_Register.Text = _iLanguageModel.lblText_Splash_CreateAccount;
                       //////btn_Login.Text = _iLanguageModel.lblText_Splash_SignIn;

                       //await vw_LogIn_View.Initialize_AppTranslation(_iLanguageModel);
                       //await vw_Password_View.Initialize_AppTranslation(_iLanguageModel);


                   });
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        public async Task Initialize_AppTranslation_Title_LoginView()
        {
            try
            {

                MainThread.BeginInvokeOnMainThread(async () =>
                   {
                       if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);


                       lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;

                       //btn_Close_Window.Text = _iLanguageModel.lblText_Command_CANCEL_Message;


                       //////btn_Register.Text = _iLanguageModel.lblText_Splash_CreateAccount;
                       //////btn_Login.Text = _iLanguageModel.lblText_Splash_SignIn;

                       //await vw_LogIn_View.Initialize_AppTranslation(_iLanguageModel);
                       //await vw_Password_View.Initialize_AppTranslation(_iLanguageModel);


                   });
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }






        #endregion


        async void btn_Close_Window_Clicked(object sender, EventArgs e)
        {
            try
            {

                Navigation.InsertPageBefore(new Page_Splash(_iLanguageModel), this);

                await Navigation.PopToRootAsync();



                //await SRoofing_Page_OpenerManager.Page_Reset_Stack (
                //        Navigation ,
                //    new Page_Splash_Dashboard( _iLanguageModel )  );

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }







        public async Task Show_PasswordView()
        {

            try
            {


                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    // Code to run on the main thread
                    await Initialize_AppTranslation_Title_Password();

                    vw_LogIn_View.IsVisible= false;
                    vw_Password_View.IsVisible= true;

                    //await   Navigation.PushAsync(new Page_Landing_Dashboard(_iLanguageModel), this);

                    //Navigation.InsertPageBefore(new Page_Landing_Dashboard(_iLanguageModel), this);

                    //await Navigation.PopToRootAsync();

                    //   Application.Current.MainPage=new Page_Landing_Dashboard(_iLanguageModel);
                    //  Application.Current.MainPage=new Page_Launcher();


                    ////////////////////Application.Current.MainPage = new NavigationPage(new Page_Landing_Dashboard(_iLanguageModel));

                    //  await Navigation.PushAsync(new Page_Launcher(), true);
                    ////await Navigation.PopToRootAsync();

                    //App.Current.MainPage = new NavigationPage(new Page2());

                    //Application.Current.MainPage =new NavigationPage(new Page_Launcher());
                    //await Navigation.PopToRootAsync();
                });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }
        }




        public async Task Show_LoginView()
        {

            try
            {


                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    // Code to run on the main thread

                    await Initialize_AppTranslation_Title_LoginView();

                    vw_Password_View.IsVisible= false;

                    vw_LogIn_View.IsVisible=true;

                    //await   Navigation.PushAsync(new Page_Landing_Dashboard(_iLanguageModel), this);

                    //Navigation.InsertPageBefore(new Page_Landing_Dashboard(_iLanguageModel), this);

                    //await Navigation.PopToRootAsync();

                    //   Application.Current.MainPage=new Page_Landing_Dashboard(_iLanguageModel);
                    //  Application.Current.MainPage=new Page_Launcher();


                    ////////////////////Application.Current.MainPage = new NavigationPage(new Page_Landing_Dashboard(_iLanguageModel));

                    //  await Navigation.PushAsync(new Page_Launcher(), true);
                    ////await Navigation.PopToRootAsync();

                    //App.Current.MainPage = new NavigationPage(new Page2());

                    //Application.Current.MainPage =new NavigationPage(new Page_Launcher());
                    //await Navigation.PopToRootAsync();
                });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }
        }






        public async Task Go_Page_LandingDashboard()
        {

            try
            {


                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    // Code to run on the main thread


                    //await   Navigation.PushAsync(new Page_Landing_Dashboard(_iLanguageModel), this);

                    //Navigation.InsertPageBefore(new Page_Landing_Dashboard(_iLanguageModel), this);

                    //await Navigation.PopToRootAsync();

                    //   Application.Current.MainPage=new Page_Landing_Dashboard(_iLanguageModel);
                    //  Application.Current.MainPage=new Page_Launcher();


                    ////////////////////Application.Current.MainPage = new NavigationPage(new Page_Landing_Dashboard(_iLanguageModel));

                    //  await Navigation.PushAsync(new Page_Launcher(), true);
                    ////await Navigation.PopToRootAsync();

                    //App.Current.MainPage = new NavigationPage(new Page2());

                    Application.Current.MainPage =new NavigationPage(new Page_Launcher());
                    await Navigation.PopToRootAsync();
                });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }
        }



        protected override bool OnBackButtonPressed()
        {

            if (vw_Password_View.IsVisible)
            {


                Task.Run(async () =>
              {
                  MainThread.BeginInvokeOnMainThread(async () =>
                  {
                      // Code to run on the main thread
                      await Show_LoginView();

                  });

              }).ConfigureAwait(true);

                //return base.OnBackButtonPressed();
                return true;

            }


            //return base.OnBackButtonPressed();
            return false;


        }


    }
}