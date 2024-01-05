
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;

using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
//////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Splash;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UploaderManager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Launcher;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Login;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Register
{
    //////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Register_Dashboard : ContentPage
    {
        public Page_Register_Dashboard()
        {
            InitializeComponent();
            BindingContext = this;
        }


        public SRoofingApplicationUtilityModelManager _iApplicationUtilityModel;
     
        public Page_Register_Dashboard(SRoofingLanguageTranslateModel iLanguageModel)
        {

            try
            {

                InitializeComponent();


                _iLanguageModel = iLanguageModel;


                Task.Run(async () =>
                {

                    _iApplicationUtilityModel = await SRoofingSync_ApplicationUtility_Manager
                              .Sync_Speech_Get_ApplicationUtility_ByAccountType(App.Current);

                    await Initialize();

                }).Wait();












                BindingContext = this;
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




        #region SnackBar


        public async Task Snack_ShowMessage(string strMessage)
        {

            try
            {

                // iSnackBar.BackgroundColor = Colors.Red;

                //   SRoofing_ToastMessageManager.ToastMessage_Show_Message ( iSnackBar , strMessage );
                await SRoofing_ToastMessageManager.ToastMessage_Show_Message(strMessage);


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }

        #endregion


        #region Step2

        SRoofingUserOwnerModelManager iOwnerModel = null;

        string _iOwnerUserTokenID = "0", _iOwnerMobileNumberTokenID = "0";

        public SRoofingLanguageTranslateModel _iLanguageModel { get; set; }

        public async Task UserRegister_New_UserAccount()
        {
            try
            {

                await Snack_ShowMessage(_iLanguageModel.lblText_Wait_RegisterAccount_Message);

                await Task.Delay(1000);

                await SRoofing_UserRegisterManager
                                    .SRoofing_XFMobile_UserRegister_New_UserAccountWS(
                     App.Current,

                                              vw_Register_Step1._register_CountryCode,
                           vw_Register_Step1._register_CountryName,
 vw_Register_Step1._register_CountryCode,
                           "0",
                          vw_Register_Step1._register_CountryMobileCode,
                           vw_Register_Step1._register_MobileNumberE164_Clean,
                         vw_Register_Step1._register_CountryMobileCode,
                          vw_Register_Step1._register_FirstName,
                      vw_Register_Step1._register_LastName,
                          vw_Register_Step2._register_BirthDay,
                         vw_Register_Step2._register_BirthMonth,
                        vw_Register_Step2._register_BirthYear,
                        vw_Register_Step2._register_Gender,
                          vw_Register_Step1._register_Password,
                           vw_Register_Step2._register_EmailAddress);

                await Task.Delay(3000);



                await Snack_ShowMessage(_iLanguageModel.lblText_Wait_SetupAccount_Message);

                await Task.Delay(3000);


                _iOwnerUserTokenID =
                    await SRoofing_UserMobileNumberManager
                                                     .UserMobileNumber_Get_OwnerUserTokenID_ByMobileNumberE164(
                                                             App.Current,
                                                             vw_Register_Step1._register_MobileNumberE164_Clean);

                _iOwnerMobileNumberTokenID =
                  await SRoofing_UserMobileNumberManager
                                .UserMobileNumber_Get_OwnerMobileNumberTokenID_ByMobileNumberE164(
                                        App.Current,
                                        vw_Register_Step1._register_MobileNumberE164_Clean);






                if (_iOwnerUserTokenID != "0" && _iOwnerMobileNumberTokenID != "0")
                {

                    /* Avatar */
                    if (vw_Register_Step2.register_fileResult != null)
                    {
                        SRoofingUserMediaModel iUserMediaModel = new SRoofingUserMediaModel
                        {
                            MediaFile_ServerID = SRoofing_TimeManager.Time_GenerateToken(),
                            fileResult = vw_Register_Step2.register_fileResult
                        };

                        await SRoofing_UploadMediaManager
                                       .Uploader_MediaFile_AvatarWS(
                    App.Current,
                    App.iAccountType,
                    _iOwnerUserTokenID,
                    _iOwnerMobileNumberTokenID,
                    null,
                    iUserMediaModel);
                    }


                    // Get_Owner_Model
                    iOwnerModel = new SRoofingUserOwnerModelManager();
                    iOwnerModel = await SRoofing_UserProfileOwnerManager
                        .UserProfile_Get_Owner_Profile_ByAccountTypeWS(
                        App.Current,
                        _iOwnerUserTokenID,
                        _iOwnerMobileNumberTokenID);



                    if (iOwnerModel != null)
                    {

                        // Get_Owner_Setting_Model

                        //  iParent.Snack_ShowMessage("Loading your settings!");

                        await Go_Page_LandingDashboard();


                        ////////////////////_ = Task.Run(async () =>
                        ////////////////////    {
                        ////////////////////        await SRoofing_UserAccountManager.UserAccount_UserAccountLoginSystem(
                        ////////////////////                App.Current,

                        ////////////////////                _iOwnerUserTokenID,
                        ////////////////////                _iOwnerMobileNumberTokenID,
                        ////////////////////                vw_Register_Step1._register_MobileNumberE164_Clean,
                        ////////////////////                SRoofingEnum_LoginStatus.LoginStatus_ONLINE,
                        ////////////////////                SRoofingEnum_VisibleStatus.VisibleStatus_ONLINE,
                        ////////////////////                "member");
                        ////////////////////    });

                        ////////////////////Preferences.Set("user_IsLogin", true);


                        ////////////////////MainThread.BeginInvokeOnMainThread(async () =>
                        ////////////////////{
                        ////////////////////    // Code to run on the main thread

                        ////////////////////    //ll_ProgressBar.IsVisible = false;


                        ////////////////////    Preferences.Set("user_IsLogin", true);


                        ////////////////////    // Code to run on the main thread

                        ////////////////////    await Go_Page_LandingDashboard();


                        ////////////////////    ////////////////////Navigation.InsertPageBefore(new Page_Landing_Dashboard(_iLanguageModel), this);

                        ////////////////////    ////////////////////await Navigation.PopToRootAsync();




                        ////////////////////    //Application.Current.MainPage = new NavigationPage(new Page_Landing_Dashboard(_iLanguageModel));

                        ////////////////////    //await Navigation.PopToRootAsync();



                        ////////////////////});


                        vw_Register_Step2._bln_IsRegister_RunningNow = false;

                        // _bln_IsLogin_RunningNow = false;

                    }
                    else
                    {
                        // Toast
                        MainThread.BeginInvokeOnMainThread(async () =>
                        {

                            //  ll_ProgressBar.IsVisible = false;

                            vw_Register_Step2._bln_IsRegister_RunningNow = false;


                            await Snack_ShowMessage(_iLanguageModel.lblText_TryAgainLater_Message);

                            //    _bln_IsLogin_RunningNow = false;

                        });
                    }

                }

                else
                {
                    // Toast
                    MainThread.BeginInvokeOnMainThread(async () =>
                    {

                        //  ll_ProgressBar.IsVisible = false;

                        vw_Register_Step2._bln_IsRegister_RunningNow = false;


                        await Snack_ShowMessage(_iLanguageModel.lblText_TryAgainLater_Message);

                        //    _bln_IsLogin_RunningNow = false;

                    });
                }







            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }



        }
        public void Register_Show_Step2(bool bln_InNewInitialize)
        {
            try
            {

                vw_Register_Step1.IsVisible = false;
                vw_Register_Step2.IsVisible = true;
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
            try
            {

                MainThread.BeginInvokeOnMainThread(async () =>
                  {
                      if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);

                      lbl_Title.Text = _iLanguageModel.lblText_Splash_CreateAccount;
                      btn_Close_Window.Text = _iLanguageModel.lblText_Command_CANCEL_Message;
                      //btn_Login.Text = _iLanguageModel.lblText_Splash_SignIn;

                      //btn.Text = _iLanguageModel.lblText_Splash_CreateAccount;

                      await vw_Register_Step1.Initialize_AppTranslation(_iLanguageModel);

                      await vw_Register_Step2.Initialize_AppTranslation(_iLanguageModel);


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



                //await SRoofing_Page_OpenerManager.Page_Reset_Stack(
                //        Navigation,
                //    new Page_Splash_Dashboard(_iLanguageModel));

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


                    //Navigation.InsertPageBefore(new Page_Landing_Dashboard(_iLanguageModel), this);

                    //await Navigation.PopToRootAsync();


                    //Application.Current.MainPage =new NavigationPage(new Page_Launcher());
                    Application.Current.MainPage =new NavigationPage(new Page_Login_Dashboard(_iLanguageModel));
                    await Navigation.PopToRootAsync();

                    //////////////Application.Current.MainPage=new Page_Landing_Dashboard(_iLanguageModel);




                    ////////////////////Application.Current.MainPage = new NavigationPage(new Page_Landing_Dashboard(_iLanguageModel));

                    ////////////////////await Navigation.PopToRootAsync();

                });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }
        }


    }
}