//// 
//// 

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Login;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Account
{
    [XamlCompilation ( XamlCompilationOptions.Compile )]
    public partial class Page_Account_Call : ContentView
    {



        #region Params

        //public Page_Login_Dashboard  (( Page_Account_Dashboard ) Parent.BindingContext) {get;set;}


        bool _bln_IsRegister_RunningNow = false;

        bool _blnIsInitializedd_Step1 = false;

        public string _register_MobileNumberE164_Clean = "0", UserLoginMobileNumberE164 = "0";
        bool _blnMobileNumber = false;

        public string _register_CountryName = "0", _register_CountryCode = "0", _register_CountryMobileCode = "0",
            _register_FirstName = "0", _register_LastName = "0",
            _register_Password = "0", _register_MobileNumberE164 = "0";

        #endregion












        bool _blnIsInitialized_Popup_IsOpen;

        public Page_Account_Call ( )
        {
            InitializeComponent ( );

            try
            {




                //Task.Run ( async ( ) =>
                //{
                //    await Initialize_AppTranslation ( );
                //} ).Wait ( );

















                MessagingCenter.Subscribe<App , SRoofingKeyValueModelManager> (
                    App.Current ,
                    SRoofingEnum_MessageCenter.MessageCenter_CALL_AUTOMESSAGE ,
                    async ( snd , arg ) =>
                    {

                        try
                        {
                            // get the value by `arg`

                            if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                            {


                                _blnIsInitialized_Popup_IsOpen = false;

                                SRoofingKeyValueModelManager _iKeyValueSpeechModel_Incoming = ( arg as SRoofingKeyValueModelManager );

                                lbl_Call_AutoMessageText.Text = "<" + ( arg as SRoofingKeyValueModelManager ).ItemText.ToString ( ) + ">";


                                _iSettingModel.Call_Auto_Message = ( arg as SRoofingKeyValueModelManager ).ItemValue;


                                ( ( Page_Account_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                                await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID (
                                    App.Current , _iOwnerModel , _iSettingModel );


                                await SRoofingSync_AutoMessage_Manager.Sync_AutoMessage_Call_Set_AutoReplyMessage_ByUserID (
                    App.Current , _iOwnerModel , ( arg as SRoofingKeyValueModelManager ).ItemValue );


                                /////////////////////////////////////////

                           _=     Task.Run ( async ( ) =>
                              {
                                  await SRoofing_UserSettingManager.UserSetting_Update_Call_Auto_Message_ByOwnerUserTokenID (
                                      App.Current ,
                   App.iAccountType ,
                   _iOwnerModel ,
                    ( arg as SRoofingKeyValueModelManager ).ItemValue );
                              } ).ConfigureAwait ( false );

                            }
                            else
                            {
                                MainThread.BeginInvokeOnMainThread (async ( ) =>
                                {
                                    //Code to run on the main thread
                                  await  ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_Account_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                                } );
                            }


                        }
                        catch ( Exception ex )
                        {
                            SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                        }

                    } );



            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }





        bool _blnIsInitialized = false;



        SRoofingApplicationUtilityModelManager _iApplicationUtilityModel;

        SRoofingUserOwnerModelManager _iOwnerModel;
        SRoofingUserSettingModelManager _iSettingModel;
        #region Initialize

        public async Task Initialize (
                  SRoofingApplicationUtilityModelManager iApplicationUtilityModel,
          SRoofingUserOwnerModelManager iOwnerModel ,
            SRoofingUserSettingModelManager iSettingModel )
        {

            try
            {


                _iApplicationUtilityModel=iApplicationUtilityModel;
                
                _iOwnerModel = iOwnerModel;
                _iSettingModel = iSettingModel;

                swtch_VoiceCommandIsEnable.OnColor = Colors.Orange;
                swtch_VoiceCommandIsEnable.ThumbColor = Colors.Gray;



                swtch_AutoAnswerIsEnable.OnColor = Colors.Orange;
                swtch_AutoAnswerIsEnable.ThumbColor = Colors.Gray;



                swtch_AutoRedialIsEnable.OnColor = Colors.Orange;
                swtch_AutoRedialIsEnable.ThumbColor = Colors.Gray;


                if ( _iSettingModel.VisibleStatus_IsEnable )
                {
                    swtch_VoiceCommandIsEnable.IsToggled = true;
                }




                if ( _iSettingModel.History_Call_SortBy == SRoofing_Enum_SortBy.SortBy_RECENT )
                {
                    rdio_ByRecent.IsChecked = true;
                }
                else
                {
                    rdio_ByName.IsChecked = true;

                }


                lbl_Call_AutoMessageText.Text = "<" + await SRoofingSync_AutoMessage_Manager.Sync_AutoMessage_Call_Get_AutoReplyMessage_ByUserID (
                        App.Current , _iOwnerModel ) + ">";

                _blnIsInitialized = true;

                //  lbl_CountryList.Text = _iOwnerModel.CountryName;

                //   txt_MobileNumber.Text = _iOwnerModel.MobileNumberE164;

                //txt_LastName.Text = _iOwnerModel.LastName;


                //if ( _iOwnerModel.Gender == SRoofingEnum_Gender.Gender_MALE )
                //{

                //    img_Male.WidthRequest = 60;
                //    img_Male.Source = "img_gender_male_select.png";

                //    img_Female.WidthRequest = 50;
                //    img_Female.Source = "img_gender_female_normal_small.png";

                //}

                //else if ( _iOwnerModel.Gender == SRoofingEnum_Gender.Gender_FEMALE )
                //{
                //    img_Female.WidthRequest = 60;
                //    img_Female.Source = "img_gender_female_select.png";

                //    img_Male.WidthRequest = 50;
                //    img_Male.Source = "img_gender_male_normal_small.png";

                //}

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }

        #endregion


        #region Switch_Toggle


        async void swtch_VoiceCommandIsEnable_Toggled ( object sender , ToggledEventArgs e )
        {
            try
            {
                if ( _blnIsInitialized )
                {

                    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                    {


                        _iSettingModel.Call_VoiceCommand_IsEnable = e.Value;



                        ( ( Page_Account_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID (
                            App.Current , _iOwnerModel , _iSettingModel );

                     _=   Task.Run ( async ( ) =>
                      {
                          await SRoofing_UserSettingManager.UserSetting_Update_Call_VoiceCommand_IsEnable_ByOwnerUserTokenID (
                              App.Current ,
           App.iAccountType ,
           _iOwnerModel ,
            e.Value );

                      } ).ConfigureAwait ( false );

                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread (async ( ) =>
                        {
                            // Code to run on the main thread
                       await     ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_Account_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                        } );
                    }

                }


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }




        async void swtch_AutoRedialIsEnable_Toggled ( object sender , ToggledEventArgs e )
        {
            try
            {
                if ( _blnIsInitialized )
                {

                    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                    {


                        _iSettingModel.Call_Auto_Redial = e.Value;



                        ( ( Page_Account_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID (
                            App.Current , _iOwnerModel , _iSettingModel );

                   _=     Task.Run ( async ( ) =>
                      {
                          await SRoofing_UserSettingManager.UserSetting_Update_Call_Auto_Redial_ByOwnerUserTokenID (
                              App.Current ,
           App.iAccountType ,
           _iOwnerModel ,
            e.Value );

                      } ).ConfigureAwait ( false );

                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread (async ( ) =>
                        {
                            // Code to run on the main thread
                        await    ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_Account_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                        } );
                    }

                }


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }

        async void swtch_AutoAnswerIsEnable_Toggled ( object sender , ToggledEventArgs e )
        {
            try
            {
                if ( _blnIsInitialized )
                {

                    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                    {


                        _iSettingModel.Call_Auto_Answer = e.Value;



                        ( ( Page_Account_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID (
                            App.Current , _iOwnerModel , _iSettingModel );

                    _=    Task.Run ( async ( ) =>
                      {
                          await SRoofing_UserSettingManager.UserSetting_Update_Call_Auto_Answer_ByOwnerUserTokenID (
                              App.Current ,
           App.iAccountType ,
           _iOwnerModel ,
            e.Value );

                      } ).ConfigureAwait ( false );

                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread (async ( ) =>
                        {
                            // Code to run on the main thread
                       await     ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_Account_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                        } );
                    }

                }


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }





        #endregion








        #region SortBy




        async void rdio_ByName_CheckedChanged ( object sender , CheckedChangedEventArgs e )
        {
            try
            {
                if ( _blnIsInitialized )
                {

                    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                    {

                        _iSettingModel.History_Call_SortBy = SRoofing_Enum_SortBy.SortBy_NAME;



                        ( ( Page_Account_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID (
                            App.Current , _iOwnerModel , _iSettingModel );

                        _ = Task.Run ( async ( ) =>
                         {
                             App._blnSyncHistory_ScreenCallShow_CALL_Landing_List = true;



                             await SRoofing_UserSettingManager.UserSetting_Update_Call_SortBy_ByOwnerUserTokenID (
                                 App.Current ,
              App.iAccountType ,
              _iOwnerModel ,
             SRoofing_Enum_SortBy.SortBy_NAME );

                         } ).ConfigureAwait ( false );

                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread (async ( ) =>
                        {
                            // Code to run on the main thread
                         await   ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_Account_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                        } );
                    }

                }


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }

        async void rdio_ByRecent_CheckedChanged ( object sender , CheckedChangedEventArgs e )
        {
            try
            {
                if ( _blnIsInitialized )
                {

                    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                    {

                        _iSettingModel.History_Call_SortBy = SRoofing_Enum_SortBy.SortBy_RECENT;

                        ( ( Page_Account_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID (
                            App.Current , _iOwnerModel , _iSettingModel );

                        _ = Task.Run ( async ( ) =>
                         {


                             App._blnSyncHistory_ScreenCallShow_CALL_Landing_List = true;


                             await SRoofing_UserSettingManager.UserSetting_Update_Call_SortBy_ByOwnerUserTokenID (
                                 App.Current ,
              App.iAccountType ,
              _iOwnerModel ,
              SRoofing_Enum_SortBy.SortBy_RECENT );

                         } ).ConfigureAwait ( false );

                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread (async ( ) =>
                        {
                            // Code to run on the main thread
                         await   ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_Account_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                        } );
                    }

                }


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }






        async void sl_Chat_SortByRecent_Tapped ( object sender , EventArgs e )
        {
            try
            {

                if ( _blnIsInitialized )
                {

                    if ( rdio_ByRecent.IsChecked )
                    {
                        rdio_ByRecent.IsChecked = false;
                    }
                    else
                    {
                        rdio_ByRecent.IsChecked = true;
                    }

                }
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }





        async void sl_Chat_SortByName_Tapped ( object sender , EventArgs e )
        {
            try
            {

                if ( _blnIsInitialized )
                {

                    if ( rdio_ByName.IsChecked )
                    {
                        rdio_ByName.IsChecked = false;
                    }
                    else
                    {
                        rdio_ByName.IsChecked = true;
                    }

                }
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }




        #endregion








        #region Register-1



        string _login_MobileNumber = "0";




        bool _bln_MobileNumber = false;
        bool _bln_Register_Step1 = false;



        async void frm_AutoMessage_Tapped ( object sender , EventArgs e )
        {
            try
            {

                ////////////////////if ( PopupNavigation.Instance.PopupStack.Count > 0 )
                ////////////////////{
                ////////////////////    await Navigation.PopAllPopupAsync ( );
                ////////////////////}


                await MauiPopup.PopupAction.DisplayPopup(
                  new iSRoofing_Popup.Popup_List_PickUp_Generic(
                      _iApplicationUtilityModel,
                      _iOwnerModel, SRoofingEnum_PopupByCodeManager.PopupByCode_CALL_AUTOMESSSAGE));

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }

        bool _bln_IsCountryName = false;
        async Task onPostExecute_LoginAsync ( )
        {

            try
            {

                ////_bln_IsRegister_RunningNow = true;

                ////_bln_MobileNumber = Register_ValidateUserLoginMobileNumberOnBlur ( );
                ////_register_Password = Get_Password ( );
                ////_bln_Register_Step1 = Register_Step1 ( );

                MainThread.BeginInvokeOnMainThread ( ( ) =>
                {
                    // Code to run on the main thread

                    //    (( Page_Account_Dashboard ) Parent.BindingContext).Lose_Focus();

                    if ( !_bln_IsCountryName )
                    {
                        frm_CountryName.BorderColor = Colors.Red;

                        _bln_IsRegister_RunningNow = false;
                        return;
                    }

                    if ( _register_Password != "0" && _bln_MobileNumber == true && _bln_IsCountryName && _bln_Register_Step1 )
                    {

                        //  ll_ProgressBar.IsVisible = true;
                        ////////////////////  (( Page_Account_Dashboard ) Parent.BindingContext).Register_Show_Step2 ( true );

                    }
                    else
                    {
                        _bln_IsRegister_RunningNow = false;

                        MainThread.BeginInvokeOnMainThread ( ( ) =>
                        {
                            // Code to run on the main thread
                            ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( "Fill in your data!" );

                        } );
                    }
                } );




                ////////////////if (_register_Password != "0" && _bln_MobileNumber == true)
                ////////////////{

                ////////////////    _iOwnerUserTokenID =
                ////////////////        await SRoofing_UserMobileNumberManager
                ////////////////                                         .UserMobileNumber_Get_OwnerUserTokenID_ByMobileNumberE164(
                ////////////////                                                 App.Current,
                ////////////////                                                 _register_MobileNumberE164_Clean);

                ////////////////    _iOwnerMobileNumberTokenID =
                ////////////////      await SRoofing_UserMobileNumberManager
                ////////////////                    .UserMobileNumber_Get_OwnerMobileNumberTokenID_ByMobileNumberE164(
                ////////////////                            App.Current,
                ////////////////                            _register_MobileNumberE164_Clean);

                ////////////////    if (_iOwnerUserTokenID != "0" && _iOwnerMobileNumberTokenID != "0")
                ////////////////    {


                ////////////////        // (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage("Loading your profile info!");

                ////////////////        // Get_Owner_Model
                ////////////////        iOwnerModel = new SRoofingUserOwnerModelManager();
                ////////////////        iOwnerModel = await SRoofing_UserProfileOwnerManager
                ////////////////            .UserProfile_Get_Owner_Profile_ByAccountTypeWS(
                ////////////////            App.Current,
                ////////////////            _iOwnerUserTokenID,
                ////////////////            _iOwnerMobileNumberTokenID);



                ////////////////        if (iOwnerModel != null)
                ////////////////        {

                ////////////////            // Get_Owner_Setting_Model

                ////////////////            //  (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage("Loading your settings!");



                ////////////////            Preferences.Set("user_IsLogin", true);

                ////////////////            MainThread.BeginInvokeOnMainThread(async () =>
                ////////////////            {
                ////////////////                // Code to run on the main thread

                ////////////////             //   ll_ProgressBar.IsVisible = false;

                ////////////////                // Code to run on the main thread
                ////////////////                await SRoofing_Page_OpenerManager
                ////////////////                         .Page_Reset_Stack(
                ////////////////                         Navigation,
                ////////////////                         new Page_Landing_Dashboard());
                ////////////////            });


                ////////////////        }
                ////////////////        else
                ////////////////        {
                ////////////////            // Toast
                ////////////////            MainThread.BeginInvokeOnMainThread(() =>
                ////////////////            {

                ////////////////              //  ll_ProgressBar.IsVisible = false;


                ////////////////                (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage("Check your mobile number and pass code!");

                ////////////////                _bln_IsRegister_RunningNow = false;

                ////////////////            });
                ////////////////        }

                ////////////////    }

                ////////////////    else
                ////////////////    {
                ////////////////        // Toast
                ////////////////        MainThread.BeginInvokeOnMainThread(() =>
                ////////////////        {

                ////////////////        //    ll_ProgressBar.IsVisible = false;

                ////////////////            (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage("Check your mobile number and pass code!");

                ////////////////            _bln_IsRegister_RunningNow = false;

                ////////////////        });
                ////////////////    }

                ////////////////}
                ////////////////else
                ////////////////{
                ////////////////    // Toast
                //////////////////    ll_ProgressBar.IsVisible = false;

                ////////////////    (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage("Check your mobile number and pass code!");

                ////////////////    _bln_IsRegister_RunningNow = false;

                ////////////////}




            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }




        #endregion











        #region Register_Step1

        bool bln_IsFirstName = false, bln_IsLastName = false, bln_IsCountry = false;

        bool Register_Step1 ( )
        {

            try
            {

                /* First-Name */
                //////if ( !string.IsNullOrWhiteSpace ( txt_FirstName.Text ) )
                //////{
                //////    sl_FirstName.BackgroundColor = Colors.White;
                //////    _register_FirstName = txt_FirstName.Text.ToString ( );
                //////    bln_IsFirstName = true;
                //////}
                //////else
                //////{
                //////    frm_FirstName.BorderColor = Colors.Red;
                //////    //txt_FirstName.Focus();
                //////    //txt_FirstName.CursorPosition = 0;
                //////    //txt_FirstName.SelectionLength = txt_FirstName.Text.Length;
                //////    (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Fill in your first name!" );
                //////    // return false;
                //////}

                ///////* Last-Name */
                //////if ( !string.IsNullOrWhiteSpace ( txt_LastName.Text ) )
                //////{
                //////    sl_LastName.BackgroundColor = Colors.White;
                //////    _register_LastName = txt_LastName.Text.ToString ( );
                //////    bln_IsLastName = true;
                //////}
                //////else
                //////{
                //////    frm_LastName.BorderColor = Colors.Red;
                //////    //txt_LastName.Focus();
                //////    //txt_LastName.CursorPosition = 0;
                //////    //txt_LastName.SelectionLength = txt_LastName.Text.Length;
                //////    (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Fill in your last name!" );
                //////    // return false;
                //////}

                if ( bln_IsFirstName && bln_IsLastName )
                {
                    return true;
                }

                return false;
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return false;
            }
        }





        #endregion






        #region Initialize_LanguageModel


        public async Task Initialize_AppTranslation ( SRoofingLanguageTranslateModel _iLanguageModel )
        {
            try
            {

                if ( _iLanguageModel == null ) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All ( App.Current );


                //////if ( _iLanguageModel.LanguageCode == "ar" )
                //////{
                //////    lbl_Title.HorizontalTextAlignment = TextAlignment.Start;
                //////    lbl_Title_Call_SortBy.HorizontalTextAlignment = TextAlignment.Start;
                //////    lbl_Title_Call_AutoAnswer.HorizontalTextAlignment = TextAlignment.Start;

                //////}
                //////else
                //////{
                //////    lbl_Title.HorizontalTextAlignment = TextAlignment.End;
                //////    lbl_Title_Call_SortBy.HorizontalTextAlignment = TextAlignment.End;
                //////    lbl_Title_Call_AutoAnswer.HorizontalTextAlignment = TextAlignment.End;

                //////}



                //////lbl_SortByRecent.HorizontalTextAlignment = TextAlignment.End;
                //////lbl_SortByName.HorizontalTextAlignment = TextAlignment.End;
                //////lbl_VoiceCommand_IsEnable.HorizontalTextAlignment = TextAlignment.End;
                //////lbl_Call_Answer.HorizontalTextAlignment = TextAlignment.End;
                //////lbl_Call_Redial.HorizontalTextAlignment = TextAlignment.End;
                // lbl_Call_AutoMessage.HorizontalTextAlignment = TextAlignment.End;
                //  lbl_Download_Document.HorizontalTextAlignment = TextAlignment.End;


                lbl_Title.Text = "S1Roofing " + _iLanguageModel.lblText_Tab_Calls;
                lbl_Title_Call_AutoAnswer.Text = _iLanguageModel.lblText_Call_AutoAnswer;


                lbl_Title_Call_SortBy.Text = _iLanguageModel.lblText_Setting_SortBy_Message;
                lbl_SortByRecent.Text = _iLanguageModel.lblText_Setting_ByRecent_Message;
                lbl_SortByName.Text = _iLanguageModel.lblText_Setting_ByName_Message;


                lbl_VoiceCommand_IsEnable.Text = _iLanguageModel.lblText_Setting_Call_VoiceCommand_Message;
                lbl_Call_Answer.Text = _iLanguageModel.lblText_Setting_Call_AutoAnswer_Message;
                lbl_Call_Redial.Text = _iLanguageModel.lblText_Setting_Call_AutoRedial_Message;

                //  lbl_Call_AutoMessage.Placeholder = _iLanguageModel.lblText_Setting_Call_AutoDecline_Message;

                lbl_Call_PickAutoMessage.Text = _iLanguageModel.lblText_Pick_FromTheList_Message;




                ////lbl_CountryList.Text = _iLanguageModel.lblText_YourCountry;
                ////txt_MobileNumber.Placeholder = _iLanguageModel.lblText_MobileNumber;
                ////txt_FirstName.Placeholder = _iLanguageModel.lblText_FirstName;
                ////txt_LastName.Placeholder = _iLanguageModel.lblText_LastName;

                btn_Submit.Text = _iLanguageModel.lblText_Command_Submit;
                ////btn_Login.Text = _iLanguageModel.lblText_Splash_SignIn;


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }


        #endregion




        async void btn_Submit_Clicked ( object sender , EventArgs e )
        {
            try
            {


                await ( ( Page_Account_Dashboard ) Parent.BindingContext ).CloseDrawer ( );


                ////////if ( !_bln_IsRegister_RunningNow )
                ////////{


                ////////    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                ////////    {
                ////////        await onPostExecute_LoginAsync ( );
                ////////    }
                ////////    else
                ////////    {
                ////////        MainThread.BeginInvokeOnMainThread ( ( ) =>
                ////////        {
                ////////            // Code to run on the main thread
                ////////            (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( SRoofingEnum_Toast_MessageManager.Message_Internet_Connection.PopupMessage_MessageConnectionFalse ( ) );

                ////////        } );
                ////////    }


                ////////}

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }

        #region frm_Toggle


        private void frm_VoiceCommand_Tapped ( object sender , EventArgs e )
        {
            try
            {

                if ( _blnIsInitialized )
                {

                    if ( swtch_VoiceCommandIsEnable.IsToggled )
                    {
                        swtch_VoiceCommandIsEnable.IsToggled = false;
                    }
                    else
                    {
                        swtch_VoiceCommandIsEnable.IsToggled = true;
                    }

                }
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }




        private void frm_CallAnswer_Tapped ( object sender , EventArgs e )
        {
            try
            {

                if ( _blnIsInitialized )
                {

                    if ( swtch_AutoAnswerIsEnable.IsToggled )
                    {
                        swtch_AutoAnswerIsEnable.IsToggled = false;
                    }
                    else
                    {
                        swtch_AutoAnswerIsEnable.IsToggled = true;
                    }

                }
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }




        private void frm_CallRedial_Tapped ( object sender , EventArgs e )
        {
            try
            {

                if ( _blnIsInitialized )
                {

                    if ( swtch_AutoRedialIsEnable.IsToggled )
                    {
                        swtch_AutoRedialIsEnable.IsToggled = false;
                    }
                    else
                    {
                        swtch_AutoRedialIsEnable.IsToggled = true;
                    }

                }
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