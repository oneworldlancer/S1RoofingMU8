using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumGlobalManager;
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
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Chatter;

public partial class Picker_Chatter_Dashboard : ContentPage
{



    public SRoofingApplicationUtilityModelManager _iApplicationUtilityModel;
    public SRoofingUserSettingModelManager _iSettingModel;
    public SRoofingSpeechModel _iSpeechModel;
    public SRoofingLanguageTranslateModel _iLanguageModel;
    public string _iOwner_Incoming_LanguageCode;
    public string _iOwner_Outgoing_LanguageCode;
    public SRoofingScreenChatShowScreenModel _iChatScreenModel;
    public SRoofingScreenChatShowMessageModelManager _iMessageModel;

    public SRoofingUserOwnerModelManager _iOwnerModel;

    public string _iActionRequest = "0";


    public Picker_Chatter_Dashboard(
        SRoofingApplicationUtilityModelManager iApplicationUtilityModel,
     SRoofingUserSettingModelManager iSettingModel,
     SRoofingLanguageTranslateModel iLanguageModel,
  SRoofingUserOwnerModelManager iOwnerModel,
    SRoofingSpeechModel iSpeechModel,
        string iOwner_Incoming_LanguageCode,
          string iOwner_Outgoing_LanguageCode,
        SRoofingScreenChatShowScreenModel iChatScreenModel,
        string iActionRequest,
  SRoofingScreenChatShowMessageModelManager iMessageModel = null)
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

            _iMessageModel= iMessageModel;
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




    #region Initialize



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

                    await vw_ChattersList.Initialize();

                }
                else if (_iActionRequest == "chat_share")
                {
                    await vw_ShareList.Initialize();

                }
                //////////else if (_iActionRequest == "chatter_picker")
                //////////{

                //////////    ////////await vw_PickerContactList.Initialize(this, _iOwnerModel);

                //////////}



            })
                   .ConfigureAwait(false);

            //await Close_LoadingScreen();

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

            MainThread.BeginInvokeOnMainThread(async () =>
          {


              vw_ChattersList.IsVisible = true;

              await iSnackBar_ConfirmOption.OpenLoader(
                  typeof(Picker_Chatter_Dashboard),
                  _iLanguageModel,
    _iOwnerModel,
    _iChatScreenModel.GroupTokenID);

          });


            if (_iActionRequest == "chat_share")
            {
                MainThread.BeginInvokeOnMainThread(async () =>
                          {
                              vw_ShareList.IsVisible = true;

                          });
            }



        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }


    public async Task snackBar_Open(Type iParentView,
          string iViewCode, object iViewValue)
    {
        try
        {

            await iSnackBar_ConfirmOption.Open(iParentView, iViewCode, iViewValue);

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }



    public async Task snackBar_Action_ContactRemove(Type iParentView,
          string iViewCode, object iViewValue)
    {
        try
        {
            //iParentView, iViewCode, iViewValue
            await vw_ChattersList.Action_Chatter_Remove_One(
                iParentView,
           iViewCode, iViewValue);

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }



    public async Task snackBar_Action_ContactAdd(Type iParentView,
          string iViewCode, object iViewValue)
    {
        try
        {

            //iParentView, iViewCode, iViewValue
            await vw_PickerChattersList.Action_Chatter_Add_One(
                iParentView,
           iViewCode, iViewValue);

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }



    public async Task snackBar_Action_ShareMessage(Type iParentView,
          string iViewCode, object iViewValue)
    {
        try
        {
            await vw_ShareList.Action_Share_Media(
                 iParentView,
           iViewCode, iViewValue);

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
                        //////////           //vw_PickerContactList.IsVisible = false;
                        //////////         vw_ChattersList.IsVisible = true;


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



    #endregion












    bool _bln_IsInitialized_Picker_Contact_Dashboard = false;


    private void Page_ChatterPickerDashboard_Loaded(object sender, EventArgs e)
    {
        try
        {

            SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == Picker_Chatter_Dashboard");

            //await Task.Delay ( 0 );

            if (!_bln_IsInitialized_Picker_Contact_Dashboard)
            {
                _bln_IsInitialized_Picker_Contact_Dashboard = true;

                _=   Task.Run(async () =>
                {
                    await Task.Delay(SRoofing_EnumGlobalPreference.Global_SCREEN_LOAD_DELAY);

                    await Initialize();

                }).ConfigureAwait(false);

            }


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        }
    }

    async void btn_Close_Window_Clicked(object sender, EventArgs e)
    {


        try
        {
            await Navigation.PopAsync();


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




    public async Task Show_PickerContactList()
    {

        try
        {

            MainThread.BeginInvokeOnMainThread(() =>
                       {
                           // Code to run on the main thread
                           vw_ChattersList.IsVisible = false;
                           vw_PickerChattersList.IsVisible = true;


                       });


            _ = Task.Run(async () =>
            {

                await vw_PickerChattersList.Initialize();


            }).ConfigureAwait(false);












        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;

        }
    }


    protected override bool OnBackButtonPressed()
    {

        try
        {

            if (vw_PickerChattersList.IsVisible== true)
            {
                vw_PickerChattersList.IsVisible=false;
                vw_ChattersList.IsVisible=true;

                return true;
            }

            return base.OnBackButtonPressed();
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return false;

        }
        //return base.OnBackButtonPressed();  



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