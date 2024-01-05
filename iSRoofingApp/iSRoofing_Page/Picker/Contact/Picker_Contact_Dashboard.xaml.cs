//using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Account;

using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Contact;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Login;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;





namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Contact;

////[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Picker_Contact_Dashboard : ContentPage
{

    bool _blnIsInitialized_BroadcastReceiver = false;
    //   public static SRoofingLanguageTranslateModel _iLanguageModel { get; set; } = new SRoofingLanguageTranslateModel ( );


    public static string iLng_Chats { get; set; } = "0";
    //= (from item in _arrLanguageModelList
    //  where item.LanguageText == "chats"
    //  select item.LanguageTextTranslated).First ( ).ToString ( ) ;



    public SRoofingApplicationUtilityModelManager _iApplicationUtilityModel;
    public SRoofingUserSettingModelManager _iSettingModel;
    public SRoofingSpeechModel _iSpeechModel;
    public SRoofingLanguageTranslateModel _iLanguageModel;
    public string _iOwner_Incoming_LanguageCode;
    public string _iOwner_Outgoing_LanguageCode;
    public SRoofingScreenChatShowScreenModel _iChatScreenModel;
    public string _iActionRequest = "0";

    public Picker_Contact_Dashboard(
        SRoofingApplicationUtilityModelManager iApplicationUtilityModel,
     SRoofingUserSettingModelManager iSettingModel,
     SRoofingLanguageTranslateModel iLanguageModel,
  SRoofingUserOwnerModelManager iOwnerModel,
    SRoofingSpeechModel iSpeechModel,
        string iOwner_Incoming_LanguageCode,
          string iOwner_Outgoing_LanguageCode,
        SRoofingScreenChatShowScreenModel iChatScreenModel,
        string iActionRequest)
    {

        InitializeComponent();

        try
        {
            _iApplicationUtilityModel = iApplicationUtilityModel;

            _iSettingModel = iSettingModel;

            _iLanguageModel = iLanguageModel;
            _iOwnerModel = iOwnerModel;
            _iSpeechModel = iSpeechModel;

            _iOwner_Incoming_LanguageCode = iOwner_Incoming_LanguageCode;
            _iOwner_Outgoing_LanguageCode = iOwner_Outgoing_LanguageCode;

            _iChatScreenModel = iChatScreenModel;

            _iActionRequest= iActionRequest;

            //if ( !_blnIsInitialized_BroadcastReceiver )
            //{

            //    _blnIsInitialized_BroadcastReceiver = true;
            //    MessagingCenter.Subscribe<App , Type> ( App.Current , "Page_Load" , async ( snd , arg ) =>
            //    {

            //        try
            //        {

            //            if ( arg == typeof ( Picker_Contact_Dashboard ) )
            //            {
            //                //get the value by `arg`

            //                SRoofing_DebugManager.Debug_ShowSystemMessage ( "Page_Load == " + arg.ToString ( ) );

            //                //await Task.Delay ( 0 );

            //                if ( !_bln_IsInitialized_Picker_Contact_Dashboard )
            //                {
            //                    _bln_IsInitialized_Picker_Contact_Dashboard = true;

            //                    //  Task.Run ( async ( ) =>
            //                    //{
            //                    await Initialize ( );
            //                    //} );

            //                }







            //                //////_iCurrent_CategoryModel = ( arg as SRoofingKeyValueModelManager );
            //                //////lblCategoryList.Text = ( arg as SRoofingKeyValueModelManager ).ItemText.ToString ( );

            //                //////Task.Run ( async ( ) =>
            //                //////{
            //                //////    await Initialize_Get_List_Group_ByCategoryTokenID (
            //                //////        _iCurrent_CategoryModel.ItemValue ,
            //                //////        _iCurrent_CategoryModel.ItemText ,
            //                //////        false );
            //                //////} ).Wait ( );
            //                //_blnIsInitialized_Popup_IsOpen = false;

            //                //txt_MobileNumber.Text = "+" + ( arg as SRoofingKeyValueModelManager ).CountryMobileCode;// (arg as Employee).m
            //                // txt_MobileNumber.IsEnabled = true;
            //                //txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;
            //                //txt_MobileNumber.Focus();

            //                //lbl_SignUp.IsEnabled = true;

            //            }
            //        }
            //        catch ( Exception ex )
            //        {
            //            SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            //        }

            //    } );


            //}


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

        BindingContext = this;


    }






    //public Picker_Contact_Dashboard(SRoofingLanguageTranslateModel iLanguageModel)
    //{

    //    InitializeComponent();

    //    try
    //    {

    //        _iLanguageModel = iLanguageModel;

    //        if (!_blnIsInitialized_BroadcastReceiver)
    //        {

    //            _blnIsInitialized_BroadcastReceiver = true;
    //            MessagingCenter.Subscribe<App, string>(App.Current, "Page_Load", async (snd, arg) =>
    //            {

    //                try
    //                {
    //                    //get the value by `arg`

    //                    SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == " + arg.ToString());

    //                    //await Task.Delay ( 0 );

    //                    if (!_bln_IsInitialized_Picker_Contact_Dashboard)
    //                    {
    //                        _bln_IsInitialized_Picker_Contact_Dashboard = true;

    //                        //  Task.Run ( async ( ) =>
    //                        //{
    //                        await Initialize();
    //                        //} );

    //                    }







    //                    //////_iCurrent_CategoryModel = ( arg as SRoofingKeyValueModelManager );
    //                    //////lblCategoryList.Text = ( arg as SRoofingKeyValueModelManager ).ItemText.ToString ( );

    //                    //////Task.Run ( async ( ) =>
    //                    //////{
    //                    //////    await Initialize_Get_List_Group_ByCategoryTokenID (
    //                    //////        _iCurrent_CategoryModel.ItemValue ,
    //                    //////        _iCurrent_CategoryModel.ItemText ,
    //                    //////        false );
    //                    //////} ).Wait ( );
    //                    //_blnIsInitialized_Popup_IsOpen = false;

    //                    //txt_MobileNumber.Text = "+" + ( arg as SRoofingKeyValueModelManager ).CountryMobileCode;// (arg as Employee).m
    //                    // txt_MobileNumber.IsEnabled = true;
    //                    //txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;
    //                    //txt_MobileNumber.Focus();

    //                    //lbl_SignUp.IsEnabled = true;

    //                }
    //                catch (Exception ex)
    //                {
    //                    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
    //                }

    //            });


    //        }

    //        BindingContext = this;

    //    }
    //    catch (Exception ex)
    //    {
    //        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
    //        return;
    //    }

    //}



    public SRoofingUserOwnerModelManager _iOwnerModel;

    async Task Initialize()
    {

        try
        {

            //await Initialize_AppTranslation ( );


            //_iOwnerModel = await
            //    SRoofingSync_User_OwnerManager.Sync_User_Owner_Get_UserModel(
            // App.Current);

            _ = Task.Run(async () =>
               {

                   if (_iActionRequest == "chatter_list")
                   {

                       //MainThread.BeginInvokeOnMainThread(async () =>
                       //                {
                       //                    // Code to run on the main thread
                       //                    await vw_ChattersList.Preload(this);
                       //                    //vw_PickerContactList.IsVisible = false;
                       //                    vw_ChattersList.IsVisible = true;


                       //                });

                       await vw_ChattersList.Initialize();

                   }
                   else if (_iActionRequest == "chatter_picker")
                   {
                       ////////MainThread.BeginInvokeOnMainThread(async () =>
                       ////////                                       {
                       ////////                                           // Code to run on the main thread
                       ////////                                           vw_ChattersList.IsVisible = false;
                       ////////                                           await vw_PickerContactList.Preload(this);
                       ////////                                           vw_PickerContactList.IsVisible = true;


                       ////////                                       });

                       ////////await vw_PickerContactList.Initialize(this, _iOwnerModel);

                   }



               })
                   .ConfigureAwait(false);

            ////.Wait ( );;


            //////  Task.Run ( async ( ) =>
            ////// {
            //////     await vw_PickerContactList.Initialize ( this , false );
            ////// } );


            //////  await vw_CallHistoryList.Initialize ( this );
            //////MainThread.BeginInvokeOnMainThread ( ( ) =>
            //////                {
            //////                    // Code to run on the main thread
            //////                    vw_PickerContactList.IsVisible = true;


            //////                } );
            //vw_PickerContactList.IsVisible = true;

            // Task.WaitAll( 

            //      vw_PickerContactList.Initialize ( this ),
            //vw_CallHistoryList.Initialize ( this ) 

            //     );
            //await TextToSpeech.SpeakAsync("Hello World  Hello World  Hello World  Hello World");

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }

    public async Task Close_LoadingScreen()
    {


        try
        {

            if (grd_Loading.IsVisible == true)
            {

                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    //// Code to run on the main thread

                    if (_iActionRequest == "chatter_list")
                    {

                        // Code to run on the main thread
                        await vw_ChattersList.Preload(this);
                        //vw_PickerContactList.IsVisible = false;
                        vw_ChattersList.IsVisible = true;


                    }
                    else if (_iActionRequest == "chatter_picker")
                    {


                        ////////                                           // Code to run on the main thread
                        ////////                                           vw_ChattersList.IsVisible = false;
                        ////////                                           await vw_PickerContactList.Preload(this);
                        ////////                                           vw_PickerContactList.IsVisible = true;




                        ////////await vw_PickerContactList.Initialize(this, _iOwnerModel);

                    }


                    btn_Close_Window.Text = _iLanguageModel.lblText_Command_CLOSE_Message;

                    grd_Loading.IsVisible= false;

                    //lbl_Avatar.Text = _iOwnerModel.AvatarName;
                    //img_Avatar.IsVisible = false;
                    //lbl_Avatar.IsVisible = true;


                });



            }

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }


    #region Navigation


    private async void imgBtn_CategoryList_Clicked(object sender, EventArgs e)
    {


        try
        {

            //await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener (
            //        Navigation ,
            //    new Page_Category_List_New ( ) ,
            //    false ,
            //    true );

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }

    private async void imgBtn_ContactList_Clicked(object sender, EventArgs e)
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



    #endregion


    #region Initialize


    bool _bln_IsInitialized_Picker_Contact_Dashboard = false;

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        //////try
        //////{

        //////    if ( !_bln_IsInitialized_Picker_Contact_Dashboard )
        //////    {
        //////        //  Task.Run ( async ( ) =>
        //////        //  {
        //////        //      await Initialize ( );
        //////        //  } );
        //////        //_bln_IsInitialized_Picker_Contact_Dashboard = true;
        //////    }
        //////    else
        //////    {
        //////        if ( vw_PickerContactList.IsVisible == true )
        //////        {
        //////            if ( App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List )
        //////            {
        //////                  Task.Run ( async ( ) =>
        //////                {
        //////                    await vw_PickerContactList.Sync_IsExist_NewList ( );
        //////                } ).ConfigureAwait ( false );//.Wait ( );;//.Wait ( );

        //////            }
        //////        }

        //////        else if ( vw_CallHistoryList.IsVisible == true )
        //////        {
        //////            if ( App._blnSyncHistory_ScreenCallShow_CALL_Landing_List )
        //////            {
        //////                  Task.Run ( async ( ) =>
        //////                {
        //////                    await vw_CallHistoryList.Sync_IsExist_NewList ( );
        //////                } ).ConfigureAwait ( false );//.Wait ( );;//.Wait ( );
        //////            }

        //////        }

        //////    }


        //////    StartListening ( );

        //////}
        //////catch ( Exception ex )
        //////{
        //////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //////    return;
        //////}

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
                    ll_NetConnection.Color = (Color)Application.Current.Resources["iAppColor_Black"];
                    break;
                case NetworkAccess.Local:
                    // Only local network access
                    ll_NetConnection.Color = (Color)Application.Current.Resources["iAppColor_Black"];
                    break;
                case NetworkAccess.ConstrainedInternet:
                    // Connected, but limited internet access such as behind a network login page
                    ll_NetConnection.Color = (Color)Application.Current.Resources["iAppColor_Black"];
                    break;
                case NetworkAccess.None:
                    // No internet available
                    ll_NetConnection.Color = Colors.Red;
                    SRoofing_ToastMessageManager.ToastMessage_Show_Message(iSnackBar, SRoofingEnum_Toast_MessageManager.Message_Internet_Connection.PopupMessage_MessageConnectionFalse());

                    break;
                case NetworkAccess.Unknown:
                    // Internet access is unknown
                    ll_NetConnection.Color = (Color)Application.Current.Resources["iAppColor_Black"];
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

            //ll_ProgressBar.IsVisible = false;

            //ll_TabCall.IsVisible = false;
            //ll_TabChat.IsVisible = true;
            //vw_CallHistoryList.IsVisible = false;
            //vw_PickerContactList.IsVisible = true;

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
            //vw_PickerContactList.IsVisible = blnIsVisible_ChatTab;
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
            //vw_CallHistoryList.IsVisible = blnIsVisible_CallTab;
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
            // ll_ProgressBar.IsVisible = blnIsVisible;
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    public async void lbl_TabCall_Tapped(object sender, EventArgs e)
    {
        //try
        //{

        //    ll_TabChat.IsVisible = false;
        //    ll_TabCall.IsVisible = true;

        //    vw_PickerContactList.IsVisible = false;
        //    vw_CallHistoryList.IsVisible = true;

        //    await vw_CallHistoryList.Initialize ( this , false );

        //}
        //catch ( Exception ex )
        //{
        //    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //    return;
        //}
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
            new Page_Account_Dashboard(_iLanguageModel),
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


    async void frm_Avatar_Tapped(object sender, EventArgs e)
    {
        try
        {
            await SRoofing_Page_OpenerManager.Page_Opener(
                                     Navigation,
                                 new Page_Account_Dashboard(_iLanguageModel),
                                 false,
                                 true);
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }

    #endregion





    #region SnackBar


    public void Snack_ShowMessage(string strMessage)
    {

        try
        {

            Device.BeginInvokeOnMainThread(() =>
            {
                // Code to run on the main thread
                // iSnackBar.BackgroundColor = Colors.Red;

                SRoofing_ToastMessageManager.ToastMessage_Show_Message(iSnackBar, strMessage);



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


            //if ( _iLanguageModel == null ) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All ( App.Current );


            //lbl_TabChat.Text = _iLanguageModel.lblText_Tab_Chats;
            //lbl_TabCall.Text = _iLanguageModel.lblText_Tab_Calls;


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    #endregion

    async void Page_ContactPickerDashboard_Loaded(object sender, EventArgs e)
    {


        try
        {

            SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == Picker_Contact_Dashboard");

            //await Task.Delay ( 0 );

            if (!_bln_IsInitialized_Picker_Contact_Dashboard)
            {
                _bln_IsInitialized_Picker_Contact_Dashboard = true;

                _=   Task.Run(async () =>
                 {
                     //await Task.Delay(5000);

                     await Initialize();

                 }).ConfigureAwait(false);

            }


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        }

    }

    public async Task Show_PickerContactList()
    {

        try
        {

            //_ = Task.Run(async () =>
            //{

            //    await vw_PickerContactList.Initialize(this, _iOwnerModel);

            //    MainThread.BeginInvokeOnMainThread(() =>
            //    {
            //        // Code to run on the main thread
            //        vw_ChattersList.IsVisible = false;
            //        vw_PickerContactList.IsVisible = true;


            //    });



            //}).ConfigureAwait(false);












        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;

        }
    }

}