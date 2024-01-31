//using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Account;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
// 
//////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Contact;
// 
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Launcher;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Login;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;





namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;

////////[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Page_Landing_Dashboard : ContentPage
{

    bool _blnIsInitialized_BroadcastReceiver = false;
    public SRoofingLanguageTranslateModel _iLanguageModel { get; set; } = new SRoofingLanguageTranslateModel();
    public SRoofingApplicationUtilityModelManager _iApplicationUtitlityModel;



    public static string iLng_Chats { get; set; } = "0";
    //= (from item in _arrLanguageModelList
    //  where item.LanguageText == "chats"
    //  select item.LanguageTextTranslated).First ( ).ToString ( ) ;

    public Page_Landing_Dashboard()
    {

        InitializeComponent();

        //cmd_OpenAccountDashboard = new Command ( async ( ) =>
        //{
        //    await open_AccountDashboard ( );
        //} );


        try
        {

            if (!_blnIsInitialized_BroadcastReceiver)
            {

                _blnIsInitialized_BroadcastReceiver = true;

                MessagingCenter.Subscribe<App, Type>(App.Current, "Page_Load", async (snd, arg) =>
                {

                    try
                    {


                        if (arg == typeof(Page_Landing_Dashboard))
                        {


                            //get the value by `arg`

                            SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == " + arg.ToString());

                            //await Task.Delay ( 0 );

                            if (!_bln_IsInitialized_Page_Landing_Dashboard)
                            {
                                _bln_IsInitialized_Page_Landing_Dashboard = true;

                                //  Task.Run ( async ( ) =>
                                //{
                                await Initialize();
                                //} );

                            }







                            //////_iCurrent_CategoryModel = ( arg as SRoofingKeyValueModelManager );
                            //////lblCategoryList.Text = ( arg as SRoofingKeyValueModelManager ).ItemText.ToString ( );

                            //////Task.Run ( async ( ) =>
                            //////{
                            //////    await Initialize_Get_List_Group_ByCategoryTokenID (
                            //////        _iCurrent_CategoryModel.ItemValue ,
                            //////        _iCurrent_CategoryModel.ItemText ,
                            //////        false );
                            //////} ).Wait ( );
                            //_blnIsInitialized_Popup_IsOpen = false;

                            //txt_MobileNumber.Text = "+" + ( arg as SRoofingKeyValueModelManager ).CountryMobileCode;// (arg as Employee).m
                            // txt_MobileNumber.IsEnabled = true;
                            //txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;
                            //txt_MobileNumber.Focus();

                            //lbl_SignUp.IsEnabled = true;

                        }






                    }
                    catch (Exception ex)
                    {
                        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    }

                });










            }


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

        BindingContext = this;


    }

    public Page_Landing_Dashboard(SRoofingLanguageTranslateModel iLanguageModel)
    {

        InitializeComponent();

        try
        {

            //var lowerAnimation = new Animation(v => ll_ProgressBar.LowerRangeValue = (float)v, -0.4, 1.0);
            //var upperAnimation = new Animation(v => ll_ProgressBar.UpperRangeValue = (float)v, 0.0, 1.4);

            //lowerAnimation.Commit(this, "lower", length: 1000, easing: Easing.CubicInOut, repeat: () => true);
            //upperAnimation.Commit(this, "upper", length: 1000, easing: Easing.CubicInOut, repeat: () => true);


            _iLanguageModel = iLanguageModel;

            ////////if (!_blnIsInitialized_BroadcastReceiver)
            ////////{

            ////////    _blnIsInitialized_BroadcastReceiver = true;
            ////////    MessagingCenter.Subscribe<App, Type>(App.Current, "Page_Load", async (snd, arg) =>
            ////////    {

            ////////        try
            ////////        {


            ////////            if (arg == typeof(Page_Landing_Dashboard))
            ////////            {
            ////////                //get the value by `arg`

            ////////                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == " + arg.ToString());

            ////////                //await Task.Delay ( 0 );

            ////////                if (!_bln_IsInitialized_Page_Landing_Dashboard)
            ////////                {
            ////////                    _bln_IsInitialized_Page_Landing_Dashboard = true;

            ////////                    //  Task.Run ( async ( ) =>
            ////////                    //{
            ////////                    await Initialize();
            ////////                    //} );

            ////////                }







            ////////                //////_iCurrent_CategoryModel = ( arg as SRoofingKeyValueModelManager );
            ////////                //////lblCategoryList.Text = ( arg as SRoofingKeyValueModelManager ).ItemText.ToString ( );

            ////////                //////Task.Run ( async ( ) =>
            ////////                //////{
            ////////                //////    await Initialize_Get_List_Group_ByCategoryTokenID (
            ////////                //////        _iCurrent_CategoryModel.ItemValue ,
            ////////                //////        _iCurrent_CategoryModel.ItemText ,
            ////////                //////        false );
            ////////                //////} ).Wait ( );
            ////////                //_blnIsInitialized_Popup_IsOpen = false;

            ////////                //txt_MobileNumber.Text = "+" + ( arg as SRoofingKeyValueModelManager ).CountryMobileCode;// (arg as Employee).m
            ////////                // txt_MobileNumber.IsEnabled = true;
            ////////                //txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;
            ////////                //txt_MobileNumber.Focus();

            ////////                //lbl_SignUp.IsEnabled = true;

            ////////            }
            ////////        }
            ////////        catch (Exception ex)
            ////////        {
            ////////            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            ////////        }

            ////////    });


            ////////}

            BindingContext = this;

            //var current = Connectivity.NetworkAccess;
            //Connectivity_Get_Status ( current );


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    public SRoofingUserSettingModelManager _iSettingModel;
    public SRoofingUserOwnerModelManager _iOwnerModel;

    async Task Initialize()
    {

        try
        {

            await Initialize_AppTranslation();


            _iOwnerModel = await
                SRoofingSync_User_OwnerManager.Sync_User_Owner_Get_UserModel(
             App.Current);



            _iSettingModel = await
                SRoofingSync_UserSetting_Manager.Sync_Setting_Get_Setting_ByUserID(
             App.Current, _iOwnerModel);



            _iApplicationUtitlityModel = await SRoofingSync_ApplicationUtility_Manager
                              .Sync_Speech_Get_ApplicationUtility_ByAccountType(App.Current);

            MainThread.BeginInvokeOnMainThread(async () =>
                {
                    // Code to run on the main thread
                    lbl_Avatar.Text = _iOwnerModel.AvatarName;
                    img_Avatar.IsVisible = false;
                    lbl_Avatar.IsVisible = true;



                    await vw_ChatHistoryList.Preload(this);
                    await vw_CallHistoryList.Preload(this);








                    //////if ( _iOwnerModel.AvatarImageID == "0" )
                    //////{
                    //////    lbl_Avatar.Text = _iOwnerModel.AvatarName;
                    //////    img_Avatar.IsVisible = false;
                    //////    lbl_Avatar.IsVisible = true;
                    //////}
                    //////else
                    //////{
                    //////    img_Avatar.Source = _iOwnerModel.AvatarImageID;
                    //////    lbl_Avatar.IsVisible = false;
                    //////    img_Avatar.IsVisible = true;
                    //////}
                });

            /////////////////////////////////////////////////////

            _ = Task.Run(async () =>
             {
                 await vw_ChatHistoryList.Initialize(this, false);
             });



            //.Wait ( );//.ConfigureAwait ( false );//.Wait ( );;


            //await TextToSpeech.SpeakAsync("Hello World  Hello World  Hello World  Hello World");

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }



    public async Task<List<SRoofingScreenChatShowMessageModelManager>> GETAll()
    {

        try
        {


            SRoofingScreenChatShowMessageModelManager x = new SRoofingScreenChatShowMessageModelManager()
            {

                InviteOwnerUserID = "2148",
                InviteOwnerMobileNumberID = "38"
            };

            await App.Database.saveDataAsync(x);

            //List<SRoofingScreenChatShowMessageModelManager> arr = await App.Database.getAllAsync ( );

            //SRoofing_DebugManager.Debug_ShowSystemMessage ( "arr-Count== " + arr.Count.ToString ( ) );

            //SRoofing_DebugManager.Debug_ShowSystemMessage ( "arr-InviteOwnerUserID== " + arr[ 0 ].InviteOwnerUserID.ToString ( ) );
            //return arr;
            return null;
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return null;
        }

    }



    #region Navigation






    private async void imgBtn_CategoryList_Clicked(object sender, EventArgs e)
    {


        //try
        //{

        //    await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener (
        //            Navigation ,
        //        new Page_Category_List_New ( ) ,
        //        false ,
        //        true );

        //}
        //catch ( Exception ex )
        //{
        //    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //    return;
        //}


    }

    private async void imgBtn_ContactList_Clicked(object sender, EventArgs e)
    {
        try
        {
            var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

            if (objService != null)
            {
                objService.KeyboardClick();
            }


            //  await Task.Delay ( 100 );

            ////////            if ( Navigation.NavigationStack.Count == 0 ||
            ////////Navigation.NavigationStack.Last ( ).GetType ( ) != typeof ( Page_Contact_List_Dashboard ) )
            ////////            {
            ////////                await Navigation.PushAsync ( new Page_Contact_List_Dashboard ( ) , true );
            ////////            }



            var currentPage = Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

            if (currentPage != null)
            {

                if (currentPage.GetType() != typeof(Page_Contact_List_Dashboard))
                {


                    await iSRoofing_Manager.SRoofing_Page_OpenerManager
                        .Page_Opener_WithChecker(
                            Navigation,
                       typeof(Page_Contact_List_Dashboard),
                       new Page_Contact_List_Dashboard(),
                        false,
                        true);


                }
            }
            else
            {
                await iSRoofing_Manager.SRoofing_Page_OpenerManager
                    .Page_Opener_WithChecker(
                        Navigation,
                   typeof(Page_Contact_List_Dashboard),
                   new Page_Contact_List_Dashboard(),
                    false,
                    true);

            }



            //await iSRoofing_Manager.SRoofing_Page_OpenerManager
            //    .Page_Opener_WithChecker (
            //        Navigation ,
            //   typeof ( Page_Contact_List_Dashboard ) ,
            //   new Page_Contact_List_Dashboard ( ) ,
            //    false ,
            //    true );

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }



    #endregion


    #region Initialize


    bool _bln_IsInitialized_Page_Landing_Dashboard = false;

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        try
        {

            if (!_bln_IsInitialized_Page_Landing_Dashboard)
            {
                //  Task.Run ( async ( ) =>
                //  {
                //      await Initialize ( );
                //  } );
                //_bln_IsInitialized_Page_Landing_Dashboard = true;
            }
            else
            {
                if (vw_ChatHistoryList.IsVisible == true)
                {
                    if (App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List)
                    {
                        _ = Task.Run(async () =>
                         {
                             await vw_ChatHistoryList.Sync_IsExist_NewList();
                         }).ConfigureAwait(false);//.Wait ( );;//.Wait ( );

                    }
                }

                else if (vw_CallHistoryList.IsVisible == true)
                {
                    if (App._blnSyncHistory_ScreenCallShow_CALL_Landing_List)
                    {
                        _ = Task.Run(async () =>
                      {
                          await vw_CallHistoryList.Sync_IsExist_NewList();
                      }).ConfigureAwait(false);//.Wait ( );;//.Wait ( );
                    }

                }

            }

            var current = Connectivity.NetworkAccess;
            Connectivity_Get_Status(current);


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




    async void Connectivity_Get_Status(NetworkAccess networkAccess)
    {

        try
        {

            //lbl_Message.Text = networkAccess.ToString();

            switch (networkAccess)
            {
                case NetworkAccess.Internet:
                    // Connected to internet
                    ll_NetConnection.Color = Color.FromArgb("#000000"); ;
                    break;
                case NetworkAccess.Local:
                    // Only local network access
                    ll_NetConnection.Color = Color.FromArgb("#000000"); ;
                    break;
                case NetworkAccess.ConstrainedInternet:
                    // Connected, but limited internet access such as behind a network login page
                    ll_NetConnection.Color = Color.FromArgb("#000000"); ;
                    break;
                case NetworkAccess.None:
                    // No internet available
                    ll_NetConnection.Color = Colors.Red;
                    // SRoofing_ToastMessageManager.ToastMessage_Show_Message ( iSnackBar , SRoofingEnum_Toast_MessageManager.Message_Internet_Connection.PopupMessage_MessageConnectionFalse ( ) );
                    await SRoofing_ToastMessageManager.ToastMessage_Show_Message(_iLanguageModel.lblText_Connection_CheckOnline_Message);

                    break;
                case NetworkAccess.Unknown:
                    // Internet access is unknown
                    ll_NetConnection.Color = Color.FromArgb("#000000"); ;
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



    public async void lbl_TabChat_Tapped(object sender, EventArgs e)
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
                            {
                                //Code to run on the main thread

                                //ll_ProgressBar.IsVisible = false;

                                ll_TabCall.IsVisible = false;
                                ll_TabChat.IsVisible = true;
                                vw_CallHistoryList.IsVisible = false;
                                vw_ChatHistoryList.IsVisible = true;

                            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async void llProgress_ToggleVisible_ChatList(bool blnIsVisible_ChatTab, bool blnIsVisible)
    {
        try
        {
            //ll_ProgressBar.IsVisible = blnIsVisible;
            vw_ChatHistoryList.IsVisible = blnIsVisible_ChatTab;
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }


    public async void llProgress_ToggleVisible_CallList(bool blnIsVisible_CallTab, bool blnIsVisible)
    {
        try
        {
            //ll_ProgressBar.IsVisible = blnIsVisible;
            vw_CallHistoryList.IsVisible = blnIsVisible_CallTab;
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }



    public async void llProgress_ToggleVisible(bool blnIsVisible)
    {
        try
        {
            //ll_ProgressBar.IsVisible = blnIsVisible;
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async void lbl_TabCall_Tapped(object sender, EventArgs e)
    {
        try
        {

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                //Code to run on the main thread

                ll_TabChat.IsVisible = false;
                ll_TabCall.IsVisible = true;

                vw_ChatHistoryList.IsVisible = false;
                vw_CallHistoryList.IsVisible = true;



            });

            _ = Task.Run(async () =>
            {
                await vw_CallHistoryList.Initialize(this, false);


            }).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }


    #region Account

    public ICommand LongPressCommand { get; set; }
    public object ILanguageModel { get; }


    #endregion



    async void imgAvatar_ClickGestureRecognizer_Clicked(object sender, EventArgs e)
    {
        try
        {

            //MainThread.BeginInvokeOnMainThread(async () =>
            //                {
            // Code to run on the main thread
            await SRoofing_Page_OpenerManager.Page_Opener(
                Navigation,
            new Page_Account_Dashboard(

                      _iApplicationUtitlityModel,
_iSettingModel,
           //_iSpeechModel,
           _iLanguageModel,
      _iOwnerModel),
            false,
            true);

            //});

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }





    #region Avatar
    public ICommand cmd_OpenAccountDashboard { get; set; }

    //cmd_OpenAccountDashboard = new Command ( async ( ) =>
    //  {
    //                   try
    //      {

    //          await open_AccountDashboard ( );
    //      }
    //      catch ( Exception ex )
    //      {
    //          SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
    //          return;
    //      }


    //  } );


    async void frm_Avatar_Tapped(object sender, EventArgs e)
    {
        try
        {

            await open_AccountDashboard();

            ////////////              var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick> ( );

            ////////////              if ( objService != null )
            ////////////              {
            ////////////                  objService.KeyboardClick ( );
            ////////////              }


            ////////////              await Task.Delay ( 100 );


            ////////////              var currentPage = Application.Current.MainPage.Navigation.ModalStack.LastOrDefault ( );

            ////////////              if ( currentPage != null )
            ////////////              {

            ////////////                  if ( currentPage.GetType ( ) != typeof ( Page_Account_Dashboard ) )
            ////////////                  {

            ////////////                      await Navigation.PushModalAsync ( new Page_Account_Dashboard ( _iLanguageModel ) , true );

            ////////////                  }
            ////////////              }
            ////////////              else
            ////////////              {

            ////////////                  await Navigation.PushModalAsync (new  Page_Account_Dashboard ( _iLanguageModel ) ,true  );
            ////////////}


            //await SRoofing_Page_OpenerManager.Page_Opener (
            //                         Navigation ,
            //                     new Page_Account_Dashboard ( _iLanguageModel ) ,
            //                     false ,
            //                     true );
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }



    public async Task open_AccountDashboard()
    {
        try
        {

            var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

            if (objService != null)
            {
                objService.KeyboardClick();
            }


            //  await Task.Delay ( 100 );

            //await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
            //     Navigation,
            //     typeof(Page_Account_Dashboard),
            // new Page_Account_Dashboard(_iLanguageModel),
            // false,
            //true);

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                // Code to run on the main thread

                await Navigation.PushModalAsync(new Page_Account_Dashboard(

                      _iApplicationUtitlityModel,
_iSettingModel,
           //_iSpeechModel,
           _iLanguageModel,
      _iOwnerModel), true);


            });





            //var currentPage = Application.Current.MainPage.Navigation.ModalStack.LastOrDefault ( );

            //if ( currentPage != null )
            //{

            //    if ( currentPage.GetType ( ) != typeof ( Page_Account_Dashboard ) )
            //    {

            //        await Navigation.PushModalAsync ( new Page_Account_Dashboard ( _iLanguageModel ) , true );

            //    }
            //}
            //else
            //{

            //    await Navigation.PushModalAsync ( new Page_Account_Dashboard ( _iLanguageModel ) , true );
            //}


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }




    #endregion





    #region SnackBar



    public async Task Snack_ShowMessage(string strMessage)
    {

        try
        {

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                // Code to run on the main thread
                // iSnackBar.BackgroundColor = Colors.Red;

                await SRoofing_ToastMessageManager.ToastMessage_Show_Message(strMessage);



            });
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    #endregion



    #region AppTranslation

    async Task Initialize_AppTranslation()
    {
        try
        {
            //_iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All ( App.Current );


            if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);


            lbl_TabChat.Text = _iLanguageModel.lblText_Tab_Chats;
            lbl_TabCall.Text = _iLanguageModel.lblText_Tab_Calls;



        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    #endregion






    #region Chat_Opener


    public async Task Chat_Opener(iSRoofing_Model.History.Chat.SRoofingScreenChatShowHistoryMessageModelManager _iNew_HistoryChatMessageModel)
    {

        try
        {

            if (_iNew_HistoryChatMessageModel!= null)
            {
                await vw_ChatHistoryList.Add_NewGroup(_iNew_HistoryChatMessageModel);

                ////////////////await Task.Delay(2000);

            }

            ////////////////////SRoofingScreenChatShowScreenModel _iChatScreenModel = new SRoofingScreenChatShowScreenModel();
            ////////////////////_iChatScreenModel = await SRoofingSync_ScreenChatShowManager.Sync_ScreenChatShow_Get_ChatModel(
            ////////////////////     App.Current,
            ////////////////////     App.iAccountType,
            ////////////////////     _iOwnerModel);


            ////////////////////if (_iChatScreenModel != null)
            ////////////////////{

            ////////////////////    await iProgress_Stop();


            ////////////////////    //MainThread.BeginInvokeOnMainThread(async () =>
            ////////////////////    //{
            ////////////////////    //    // Code to run on the main thread
            ////////////////////    //    await Navigation.PushAsync(new Page_ScreenChatShow_Dashboard(), true);

            ////////////////////    //});

            ////////////////////    await SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
            ////////////////////       Navigation,
            ////////////////////   typeof(Page_ScreenChatShow_Dashboard),
            ////////////////////   new Page_ScreenChatShow_Dashboard(), false, true);


            ////////////////////    _bln_IsBusyOnProgress= false;

            ////////////////////    //////////            await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
            ////////////////////    //////////    Navigation,
            ////////////////////    //////////    typeof(Page_ScreenChatShow_Dashboard),
            ////////////////////    //////////new Page_ScreenChatShow_Dashboard(),
            ////////////////////    //////////false,
            ////////////////////    //////////true);


            ////////////////////}



            //////
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }




    public async Task Chat_Opener(SRoofingScreenChatShowScreenModel _iChatScreenModel, bool blnLoader)
    {

        try
        {

            //if (_iNew_HistoryChatMessageModel!= null)
            //{
            //    await vw_ChatHistoryList.Add_NewGroup(_iNew_HistoryChatMessageModel);

            //    ////////////////await Task.Delay(2000);

            //}

            //SRoofingScreenChatShowScreenModel _iChatScreenModel = new SRoofingScreenChatShowScreenModel();
            //_iChatScreenModel = await SRoofingSync_ScreenChatShowManager.Sync_ScreenChatShow_Get_ChatModel(
            //     App.Current,
            //     App.iAccountType,
            //     _iOwnerModel);


            if (_iChatScreenModel != null)
            {

                await iProgress_Stop();


                //MainThread.BeginInvokeOnMainThread(async () =>
                //{
                //    // Code to run on the main thread
                //    await Navigation.PushAsync(new Page_ScreenChatShow_Dashboard(), true);

                //});

                await SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
                   Navigation,
               typeof(Page_ScreenChatShow_Dashboard),
               new Page_ScreenChatShow_Dashboard(), false, true);


                _bln_IsBusyOnProgress= false;

                //////////            await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
                //////////    Navigation,
                //////////    typeof(Page_ScreenChatShow_Dashboard),
                //////////new Page_ScreenChatShow_Dashboard(),
                //////////false,
                //////////true);


            }



            //////
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }





    #endregion

    private void page_LandingDashboard_Loaded(object sender, EventArgs e)
    {


        try
        {

            SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == page_LandingDashboard_Loaded");

            //await Task.Delay ( 0 );

            if (!_bln_IsInitialized_Page_Landing_Dashboard)
            {
                _bln_IsInitialized_Page_Landing_Dashboard = true;

                Task.Run(async () =>
              {
                  await Initialize();
              });

            }



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