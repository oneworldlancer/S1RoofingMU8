using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumGlobalManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Account;

//////[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Page_Account_Dashboard : ContentPage
{
    //public Page_Account_Dashboard()
    //{
    //    InitializeComponent();


    //    ////////Task.Run(function: async () =>
    //    ////////{

    //    ////////    await Initialize();

    //    ////////}).Wait();

    //    BindingContext = this;



    //}

    bool _blnIsInitialized_BroadcastReceiver = false;
    bool _bln_IsInitialized_Page_Account_Dashboard = false;


    Page_Account_Username vw_Page_Account_Username = new Page_Account_Username();
    Page_Account_About vw_Page_Account_About = new Page_Account_About();
    Page_Account_Call vw_Page_Account_Call = new Page_Account_Call();
    Page_Account_Chat vw_Page_Account_Chat = new Page_Account_Chat();
    Page_Account_ContactUs vw_Page_Account_ContactUs = new Page_Account_ContactUs();
    Page_Account_EmailAddress vw_Page_Account_EmailAddress = new Page_Account_EmailAddress();
    Page_Account_FAQ vw_Page_Account_FAQ = new Page_Account_FAQ();
    Page_Account_MobileNumber vw_Page_Account_MobileNumber = new Page_Account_MobileNumber();
    Page_Account_Notifications vw_Page_Account_Notifications = new Page_Account_Notifications();
    Page_Account_Password vw_Page_Account_Password = new Page_Account_Password();
    Page_Account_Privacy vw_Page_Account_Privacy = new Page_Account_Privacy();
    Page_Account_RateUs vw_Page_Account_RateUs = new Page_Account_RateUs();
    Page_Account_Sound vw_Page_Account_Sound = new Page_Account_Sound();
    Page_Account_Speech vw_Page_Account_Speech = new Page_Account_Speech();



    public Page_Account_Dashboard(
         SRoofingApplicationUtilityModelManager iApplicationUtilityModel,
         SRoofingUserSettingModelManager iSettingModel,
            //SRoofingSpeechModel iSpeechModel,
            SRoofingLanguageTranslateModel iLanguageModel,
        SRoofingUserOwnerModelManager iOwnerModel)
    {
        try
        {
            InitializeComponent();



            try
            {


                _iOwnerModel = iOwnerModel;

                _iApplicationUtilityModel = iApplicationUtilityModel;

                _iSettingModel =  iSettingModel;

                //_iSpeechModel=iSpeechModel;

                //_iSpeechModel_Incoming = await SRoofingSync_Speech_Manager.Sync_Speech_Get_Incoming_ByUserID(App.Current, _iOwnerModel);
                //_iSpeechModel_Outgoing = await SRoofingSync_Speech_Manager.Sync_Speech_Get_Outgoing_ByUserID(App.Current, _iOwnerModel);



                _iLanguageModel = iLanguageModel;


                //if (!_blnIsInitialized_BroadcastReceiver)
                //{

                //    _blnIsInitialized_BroadcastReceiver = true;

                //    MessagingCenter.Subscribe<App, Type>(App.Current, "Page_Load", async (snd, arg) =>
                //    {

                //        try
                //        {

                //            if (arg == typeof(Page_Account_Dashboard))
                //            {


                //                //get the value by `arg`

                //                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == " + arg.ToString());

                //                //await Task.Delay ( 0 );

                //                if (!_bln_IsInitialized_Page_Account_Dashboard)
                //                {
                //                    _bln_IsInitialized_Page_Account_Dashboard = true;


                //                    _iLanguageModel = iLanguageModel;


                //                    Task.Run(async () =>
                //                    {
                //                        // await CloseDrawer ( );
                //                        await Initialize();
                //                    }).Wait();


                //                }



                //            }






                //        }
                //        catch (Exception ex)
                //        {
                //            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                //        }

                //    });

                //}


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


            BindingContext = this;


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public SRoofingApplicationUtilityModelManager _iApplicationUtilityModel { get; set; }
    public SRoofingUserOwnerModelManager _iOwnerModel { get; set; }
    public SRoofingUserSettingModelManager _iSettingModel { get; set; } = new SRoofingUserSettingModelManager();

    //public SRoofingApplicationUtilityModelManager _iApplicationUtilityModel { get; set; } = new SRoofingApplicationUtilityModelManager ( );
    public SRoofingSpeechModel _iSpeechModel_Incoming { get; set; } = new SRoofingSpeechModel();
    public SRoofingSpeechModel _iSpeechModel_Outgoing { get; set; } = new SRoofingSpeechModel();
    public SRoofingLanguageTranslateModel _iLanguageModel { get; set; }

    async Task Initialize()
    {
        try
        {

            _iSpeechModel_Incoming = await SRoofingSync_Speech_Manager.Sync_Speech_Get_Incoming_ByUserID(App.Current, _iOwnerModel);
            _iSpeechModel_Outgoing = await SRoofingSync_Speech_Manager.Sync_Speech_Get_Outgoing_ByUserID(App.Current, _iOwnerModel);



            //////////_iOwnerModel = await
            //////////    SRoofingSync_User_OwnerManager.Sync_User_Owner_Get_UserModel(
            ////////// App.Current);

            //////////_iApplicationUtilityModel = await SRoofingSync_ApplicationUtility_Manager
            //////////            .Sync_Speech_Get_ApplicationUtility_ByAccountType(App.Current);

            //////////_iSettingModel = await SRoofingSync_UserSetting_Manager.Sync_Setting_Get_Setting_ByUserID(
            //////////    App.Current, _iOwnerModel); ;

            //////////_iSpeechModel_Incoming = await SRoofingSync_Speech_Manager.Sync_Speech_Get_Incoming_ByUserID(App.Current, _iOwnerModel);
            //////////_iSpeechModel_Outgoing = await SRoofingSync_Speech_Manager.Sync_Speech_Get_Outgoing_ByUserID(App.Current, _iOwnerModel);



            MainThread.BeginInvokeOnMainThread(async () =>
            {


                // Code to run on the main thread

                if (!load_ProfileList.HasLazyViewLoaded)
                {
                    await load_ProfileList.LoadViewAsync();
                }


                lbl_TabAccount.Text = _iLanguageModel.lblText_Title_Account;
                lbl_TabSetting.Text =  _iLanguageModel.lblText_Title_Settings;

                btn_Close_Window.Text = _iLanguageModel.lblText_Command_CLOSE_Message;

                load_ProfileList.IsVisible=true;
                grd_Loading.IsVisible=false;

            });
            //////////MainThread.BeginInvokeOnMainThread(async () =>
            //////////{
            //////////    // Code to run on the main thread
            //////////    lbl_TabAccount.Text = _iLanguageModel.lblText_Title_Account;
            //////////    lbl_TabSetting.Text =  _iLanguageModel.lblText_Title_Settings;

            //////////    btn_Close_Window.Text = _iLanguageModel.lblText_Command_CLOSE_Message;

            //////////    load_ProfileList.IsVisible=true;
            //////////    grd_Loading.IsVisible=false;
            //////////});

            //////////await vw_AccountList.Initialize(_iOwnerModel, _iSettingModel,
            //////////        _iSpeechModel_Incoming, _iSpeechModel_Outgoing);


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async void imgBtn_ContactList_Clicked(object sender, EventArgs e)
    {

        try
        {

            //var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

            //if (objService != null)
            //{
            //    objService.KeyboardClick();
            //}


            //   await Task.Delay ( 100 );


            //   await Navigation.PopModalAsync ( );
            await Navigation.PopModalAsync();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }







    #region Initialize_LanguageModel


    async Task Initialize_AppTranslation()
    {
        try
        {

            if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);

            // lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;
            ////btn_Register.Text = _iLanguageModel.lblText_Splash_CreateAccount;
            ////btn_Login.Text = _iLanguageModel.lblText_Splash_SignIn;

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                //////////await vw_AccountList.Initialize_AppTranslation(_iLanguageModel);
            });

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }


    #endregion


    #region Bottom_Sheet



    uint duration = 100;
    //double openY = (DeviceInfo.Current.Platform.ToString() == "Android") ? 20 : 60;
    double openY = (DeviceInfo.Current.Platform.ToString() == "Android") ? 0 : 0;

    async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
    {
        if (isBackdropTapEnabled)
        {
            await CloseDrawer();
        }
    }

    double lastPanY = 0;
    bool isBackdropTapEnabled = true;
    public bool blnIsExpanded = false;
    async void PanGestureRecognizer_PanUpdated(System.Object sender, PanUpdatedEventArgs e)
    {
        if (e.StatusType == GestureStatus.Running)
        {
            //isBackdropTapEnabled = false;
            lastPanY = e.TotalY;
            //Debug.WriteLine($"Running: {e.TotalY}");
            //if (e.TotalY > 0)
            //{
            //    BottomToolbar.TranslationY = openY + e.TotalY;
            //}
        }
        else if (e.StatusType == GestureStatus.Completed)
        {
            //Debug.WriteLine($"Completed: {e.TotalY}");
            if (lastPanY < 110)
            {
                await OpenDrawer();
            }
            else
            {
                await CloseDrawer();
            }

            isBackdropTapEnabled = true;
        }
    }

    async Task OpenDrawer()
    {
        MainThread.BeginInvokeOnMainThread(async () =>
        {

            BottomToolbar.IsVisible= true;
            BottomToolbar.TranslateTo(0, openY, length: duration, easing: Easing.SinIn);


        });

        //await Task.WhenAll
        //(

        //);

        //if ( child_Menu_List.IsVisible == true )
        //    {
        //    BottomToolbar.BackgroundColor = ColorConverters.FromHex ( "#454545" );

        //    }

        //else if ( child_Marshal_List.IsVisible == true )
        //    {
        //    BottomToolbar.BackgroundColor = Colors.White;

        //    }
        //else
        //    {
        //    BottomToolbar.BackgroundColor = Colors.WhiteSmoke;
        //    }

        blnIsExpanded = true;

    }

    public async Task CloseDrawer()
    {
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            BottomToolbar.TranslateTo(0, (DeviceDisplay.MainDisplayInfo.Height), length: duration, easing: Easing.SinIn);
            BottomToolbar.IsVisible= false;

        });
        //await Task.WhenAll
        //(

        //  //   BottomToolbar.TranslateTo ( 0 , ( DeviceDisplay.MainDisplayInfo.Height ) * 0.20 , length: duration , easing: Easing.SinIn )

        //  ) ;

        //BottomToolbar.BackgroundColor = Colors.Transparent;
        blnIsExpanded = false;
    }

    async Task CloseDrawerX()
    {
        await Task.WhenAll
        (
            //   BottomToolbar.TranslateTo ( 0 , ( DeviceDisplay.MainDisplayInfo.Height ) * 0.20 , length: duration , easing: Easing.SinIn )
            );

        BottomToolbar.BackgroundColor = Colors.Transparent;
        blnIsExpanded = false;
    }




    #endregion





    #region SnackBar


    public async Task Snack_ShowMessage(string strMessage)
    {

        try
        {

            // iSnackBar.BackgroundColor = Colors.Red;

            await SRoofing_ToastMessageManager.ToastMessage_Show_Message(strMessage);


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }





    #endregion

    async void imgBtn_AccountOverlay_Close_Clicked(object sender, EventArgs e)
    {
        try
        {

            if (vw_Page_Account_Chat.IsVisible == true)
            {
                if (vw_Page_Account_Chat.close_List() == true)
                {
                    await CloseDrawer();
                }
            }
            else
            {
                await CloseDrawer();


            }

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }




    #region Navigation


    public async Task PersonalInfo_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_Username.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_Username.Initialize(_iOwnerModel, _iSettingModel);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_Username);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }



    public async Task Avatar_Tapped()
    {

    }

    public async Task MobileNumber_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_MobileNumber.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_MobileNumber.Initialize(_iApplicationUtilityModel, _iOwnerModel, _iSettingModel);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_MobileNumber);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async Task Password_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_Password.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_Password.Initialize(_iOwnerModel, _iSettingModel);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_Password);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async Task EmailAddress_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_EmailAddress.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_EmailAddress.Initialize(_iOwnerModel, _iSettingModel);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_EmailAddress);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async Task Privacy_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_Privacy.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_Privacy.Initialize(_iOwnerModel, _iSettingModel);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_Privacy);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async Task Speech_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_Speech.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_Speech.Initialize(
                    _iApplicationUtilityModel,
                    _iOwnerModel, _iSettingModel, _iSpeechModel_Incoming, _iSpeechModel_Outgoing);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_Speech);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async Task Sounds_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_Sound.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_Sound.Initialize(_iApplicationUtilityModel,
                 _iOwnerModel, _iSettingModel);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_Sound);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async Task Chats_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_Chat.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_Chat.Initialize(typeof(Page_Account_Dashboard), _iApplicationUtilityModel, _iOwnerModel, _iSettingModel);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_Chat);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async Task Calls_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_Call.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_Call.Initialize(_iApplicationUtilityModel,
                 _iOwnerModel, _iSettingModel);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_Call);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async Task Notifications_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_Notifications.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_Notifications.Initialize(_iOwnerModel, _iSettingModel);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_Notifications);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async Task RateUs_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_RateUs.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_RateUs.Initialize(_iOwnerModel, _iSettingModel);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_RateUs);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async Task ContactUs_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_ContactUs.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_ContactUs.Initialize(_iOwnerModel, _iSettingModel);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_ContactUs);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async Task About_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_About.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_About.Initialize(_iOwnerModel, _iSettingModel);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_About);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async Task FAQ_Tapped()
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                sl_AccountContentOverlay.Children.Clear();

                await vw_Page_Account_FAQ.Initialize_AppTranslation(_iLanguageModel);
                await vw_Page_Account_FAQ.Initialize(_iOwnerModel, _iSettingModel);
                sl_AccountContentOverlay.Children.Add(vw_Page_Account_FAQ);

                await OpenDrawer();

            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }














    #endregion







    #region Back-Button


    protected override bool OnBackButtonPressed()
    {

        try
        {
            if (blnIsExpanded == true)
            {

                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    // Code to run on the main thread

                    if (vw_Page_Account_Sound.IsVisible == true)
                    {
                        await vw_Page_Account_Sound.Player_Stop();
                    }



                    if (vw_Page_Account_Chat.IsVisible == true)
                    {
                        if (vw_Page_Account_Chat.close_List() == false)
                        {
                            return;
                        }
                        else
                        {
                            await CloseDrawer(); ;
                            sl_AccountContentOverlay.Children.Clear();

                        }
                    }

                    await CloseDrawer(); ;
                    sl_AccountContentOverlay.Children.Clear();


                });
                return true;
            }
            else if (load_ProfileList.IsVisible== false)
            {
                MainThread.BeginInvokeOnMainThread(async () =>
               {

                   // Code to run on the main thread
                   ll_TabChat.IsVisible = false;
                   ll_TabCall.IsVisible = false;

                   load_AccountList.IsVisible= false;
                   load_SettingList.IsVisible= false;
                   load_ProfileList.IsVisible= true;

               });
                return true;
            }



            Task.Run(async () =>
            {
                await Navigation.PopModalAsync();


            }).Wait();

            return false;
 
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return false;
        }

        //return base.OnBackButtonPressed ( );
    }










    #endregion

    private void page_AccountDashboard_Loaded(object sender, EventArgs e)
    {

        try
        {

            SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == Page_Account_Dashboard");

            //await Task.Delay ( 0 );

            if (!_bln_IsInitialized_Page_Account_Dashboard)
            {
                _bln_IsInitialized_Page_Account_Dashboard = true;


                //_iLanguageModel = iLanguageModel;


                _=    Task.Run(async () =>
                {
                    // await CloseDrawer ( );
                    await Task.Delay(SRoofing_EnumGlobalPreference.Global_SCREEN_LOAD_DELAY);

                    await Initialize();

                }).ConfigureAwait(false);


            }

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

            vw_Page_Account_Sound.player?.Dispose();
            vw_Page_Account_Sound.player = null;

            //((MusicPlayerPageViewModel)BindingContext).TidyUp();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;

        }
    }

    private void page_AccountDashboard_Unloaded(object sender, EventArgs e)
    {
        try
        {

            vw_Page_Account_Sound.player?.Dispose();
            vw_Page_Account_Sound.player = null;

            //((MusicPlayerPageViewModel)BindingContext).TidyUp();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;

        }
    }

    public async Task Hide_Loading()
    {

        try
        {

            //////////await Task.Delay(500);

            await Initialize_AppTranslation();


            MainThread.BeginInvokeOnMainThread(async () =>
            {
                // Code to run on the main thread
                //await Task.Delay(500);

                ////////BottomToolbar.TranslationY = (DeviceDisplay.MainDisplayInfo.Height);//Convert.ToInt32(DeviceDisplay.MainDisplayInfo.Height) - Convert.ToInt32(btmMargin.HeightRequest);//(DeviceDisplay.MainDisplayInfo.Height) - 100;

                //////////await Task.Delay(500);

                grd_Loading.IsVisible = false;

            });

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;

        }

    }

    async void btn_Close_Window_Clicked(object sender, EventArgs e)
    {

        try
        {
            await Navigation.PopModalAsync();


            //var objService = DependencyService.Get<iSRoofing_DependencyService_SoundClick> ( );

            //if ( objService != null )
            //{
            //    objService.KeyboardClick ( );
            //}


            //await Task.Delay ( 500 );

            //await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener (
            //        Navigation ,
            //    new Page_Contact_List_Dashboard ( ) ,
            //    false ,
            //    true );

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async void lbl_TabAccount_Tapped(object sender, TappedEventArgs e)
    {
        try
        {

            await iProgress_Start();

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                //Code to run on the main thread

                if (!load_AccountList.HasLazyViewLoaded)
                {

                    await load_AccountList.LoadViewAsync();


                }

                //ll_ProgressBar.IsVisible = false;

                ll_TabCall.IsVisible = false;
                ll_TabChat.IsVisible = true;

                load_ProfileList.IsVisible = false;
                load_SettingList.IsVisible = false;
                load_AccountList.IsVisible = true;


                await iProgress_Stop();
            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    async void lbl_TabSetting_Tapped(object sender, TappedEventArgs e)
    {
        try
        {

            await iProgress_Start();

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                //Code to run on the main thread

                if (!load_SettingList.HasLazyViewLoaded)
                {

                    await load_SettingList.LoadViewAsync();
   }

                ll_TabChat.IsVisible = false;
                ll_TabCall.IsVisible = true;

                load_ProfileList.IsVisible = false;
                load_AccountList.IsVisible = false;
                load_SettingList.IsVisible = true;

                await iProgress_Stop();

            });

            //_ = Task.Run(async () =>
            //{
            //    await vw_CallHistoryList.Initialize(this, false);


            //}).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    async void load_ProfileList_Loaded(object sender, EventArgs e)
    {
        try
        {


            MainThread.BeginInvokeOnMainThread(async () =>
            {
                // Code to run on the main thread
                lbl_TabAccount.Text = _iLanguageModel.lblText_Title_Account;
                lbl_TabSetting.Text =  _iLanguageModel.lblText_Title_Settings;

                btn_Close_Window.Text = _iLanguageModel.lblText_Command_CLOSE_Message;

                load_ProfileList.IsVisible=true;
                grd_Loading.IsVisible=false;
            });
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;

        }
    }







    #region ProgressBar


    public bool _bln_IsBusyOnProgress = false;


    public async Task<bool> iProgress_Start()
    {
        try
        {


            return await ll_ProgressBar.Progress_Start();


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return false;

        }

    }



    public async Task<bool> iProgress_Stop()
    {

        try
        {

            return await ll_ProgressBar.Progress_Stop();


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return false;

        }
    }






    #endregion






}