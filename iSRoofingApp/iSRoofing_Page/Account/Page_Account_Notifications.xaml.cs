﻿//// 

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
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
    public partial class Page_Account_Notifications : ContentView
    {



        #region Params

        //public Page_Login_Dashboard  (( Page_Account_Dashboard ) Parent.BindingContext) {get;set;}


        bool _bln_IsRegister_RunningNow = false;

        bool _blnIsInitialized_Step1 = false;

        public string _register_MobileNumberE164_Clean = "0", UserLoginMobileNumberE164 = "0";
        bool _blnMobileNumber = false;

        public string _register_CountryName = "0", _register_CountryCode = "0", _register_CountryMobileCode = "0",
            _register_FirstName = "0", _register_LastName = "0",
            _register_Password = "0", _register_MobileNumberE164 = "0";

        #endregion














        public Page_Account_Notifications ( )
        {
            InitializeComponent ( );

            try
            {




                //Task.Run ( async ( ) =>
                //{
                //    await Initialize_AppTranslation ( );
                //} ).Wait ( );











            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }


        bool _blnIsInitialized = false;

        SRoofingUserOwnerModelManager _iOwnerModel;
        SRoofingUserSettingModelManager _iSettingModel;
        #region Initialize

        public async Task Initialize (
            SRoofingUserOwnerModelManager iOwnerModel ,
            SRoofingUserSettingModelManager iSettingModel )
        {

            try
            {

                _iOwnerModel = iOwnerModel;
                _iSettingModel = iSettingModel;

                swtch_Notify_UpdateNewIsEnable.OnColor = Colors.Orange;
                swtch_Notify_UpdateNewIsEnable.ThumbColor = Colors.Gray;



                swtch_Notify_UpdateWIFIIsEnable.OnColor = Colors.Orange;
                swtch_Notify_UpdateWIFIIsEnable.ThumbColor = Colors.Gray;






                if ( _iSettingModel.Notification_Update_New )
                {
                    swtch_Notify_UpdateNewIsEnable.IsToggled = true;
                }



                if ( _iSettingModel.Notification_Update_WIFI )
                {
                    swtch_Notify_UpdateWIFIIsEnable.IsToggled = true;
                }


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


        async void swtch_Notify_UpdateNewIsEnable_Toggled ( object sender , ToggledEventArgs e )
        {
            try
            {
                if ( _blnIsInitialized )
                {

                    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                    {


                        _iSettingModel.Notification_Update_New = e.Value;
                        _iSettingModel.Notification_Update_Auto = e.Value;


                        ( ( Page_Account_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID (
                                    App.Current , _iOwnerModel , _iSettingModel );

                        _ = Task.Run ( async ( ) =>
                         {
                             await SRoofing_UserSettingManager.UserSetting_Update_Notification_Update_IsEnable_ByOwnerUserTokenID (
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




        async void swtch_Notify_UpdateWIFIIsEnable_Toggled ( object sender , ToggledEventArgs e )
        {

            try
            {
                if ( _blnIsInitialized )
                {

                    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                    {


                        _iSettingModel.Notification_Update_WIFI = e.Value;


                        ( ( Page_Account_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID (
                            App.Current , _iOwnerModel , _iSettingModel );

                   _ =      Task.Run ( async ( ) =>
                      {
                          await SRoofing_UserSettingManager.UserSetting_Update_Notification_Update_WIFI_ByOwnerUserTokenID (
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




        private void swtch_DownloadVideo_Toggled ( object sender , ToggledEventArgs e )
        {
            try
            {
                if ( e.Value == true )
                {

                }

                else if ( e.Value == false )
                {

                }

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }




        private void swtch_DownloadDocument_Toggled ( object sender , ToggledEventArgs e )
        {
            try
            {
                if ( e.Value == true )
                {

                }

                else if ( e.Value == false )
                {

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
        bool _bln_IsCountryName = false;
        async Task onPostExecute_LoginAsync ( )
        {

            try
            {

                _bln_IsRegister_RunningNow = true;

                //////_bln_MobileNumber = Register_ValidateUserLoginMobileNumberOnBlur ( );
                //////_register_Password = Get_Password_Current ( );
                //////_bln_Register_Step1 = Register_Step1 ( );

                //////MainThread.BeginInvokeOnMainThread ( ( ) =>
                //////{
                //////    // Code to run on the main thread

                //////    //    (( Page_Account_Dashboard ) Parent.BindingContext).Lose_Focus();

                //////    if ( !_bln_IsCountryName )
                //////    {
                //////        frm_CountryName.BorderColor = Colors.Red;

                //////        _bln_IsRegister_RunningNow = false;
                //////        return;
                //////    }

                //////    if ( _register_Password != "0" && _bln_MobileNumber == true && _bln_IsCountryName && _bln_Register_Step1 )
                //////    {

                //////        //  ll_ProgressBar.IsVisible = true;
                //////      ////////////////////  (( Page_Account_Dashboard ) Parent.BindingContext).Register_Show_Step2 ( true );

                //////    }
                //////    else
                //////    {
                //////        _bln_IsRegister_RunningNow = false;

                //////        MainThread.BeginInvokeOnMainThread ( ( ) =>
                //////        {
                //////            // Code to run on the main thread
                //////            (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Fill in your data!" );

                //////        } );
                //////    }
                //////} );




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

                /////////* First-Name */
                ////////if ( !string.IsNullOrWhiteSpace ( txt_FirstName.Text ) )
                ////////{
                ////////    sl_FirstName.BackgroundColor = Colors.White;
                ////////    _register_FirstName = txt_FirstName.Text.ToString ( );
                ////////    bln_IsFirstName = true;
                ////////}
                ////////else
                ////////{
                ////////    frm_FirstName.BorderColor = Colors.Red;
                ////////    //txt_FirstName.Focus();
                ////////    //txt_FirstName.CursorPosition = 0;
                ////////    //txt_FirstName.SelectionLength = txt_FirstName.Text.Length;
                ////////    (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Fill in your first name!" );
                ////////    // return false;
                ////////}

                /////////* Last-Name */
                ////////if ( !string.IsNullOrWhiteSpace ( txt_LastName.Text ) )
                ////////{
                ////////    sl_LastName.BackgroundColor = Colors.White;
                ////////    _register_LastName = txt_LastName.Text.ToString ( );
                ////////    bln_IsLastName = true;
                ////////}
                ////////else
                ////////{
                ////////    frm_LastName.BorderColor = Colors.Red;
                ////////    //txt_LastName.Focus();
                ////////    //txt_LastName.CursorPosition = 0;
                ////////    //txt_LastName.SelectionLength = txt_LastName.Text.Length;
                ////////    (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Fill in your last name!" );
                ////////    // return false;
                ////////}

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

                //////}
                //////else
                //////{
                //////    lbl_Title.HorizontalTextAlignment = TextAlignment.End;

                //////}

                //lbl_Notification_Auto.HorizontalTextAlignment = TextAlignment.End;
                //lbl_Notification_WIFI.HorizontalTextAlignment = TextAlignment.End;









                lbl_Title.Text = "S1Roofing " + _iLanguageModel.lblText_Notifications;

                lbl_Notification_Auto.Text = _iLanguageModel.lblText_Setting_Notification_AutoUpdate_Message;
                lbl_Notification_WIFI.Text = _iLanguageModel.lblText_Setting_Notification_AutoWIFIf_Message;



                //lbl_CountryList.Text = _iLanguageModel.lblText_YourCountry;
                //txt_MobileNumber.Placeholder = _iLanguageModel.lblText_MobileNumber;
                //txt_FirstName.Placeholder = _iLanguageModel.lblText_FirstName;
                //txt_LastName.Placeholder = _iLanguageModel.lblText_LastName;

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



            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }




        #region frm_Toggle


        private void frm_NotificationUpdate_Tapped ( object sender , EventArgs e )
        {
            try
            {

                if ( _blnIsInitialized )
                {

                    if ( swtch_Notify_UpdateNewIsEnable.IsToggled )
                    {
                        swtch_Notify_UpdateNewIsEnable.IsToggled = false;
                    }
                    else
                    {
                        swtch_Notify_UpdateNewIsEnable.IsToggled = true;
                    }

                }
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }


        private void frm_NotificationWIFI_Tapped ( object sender , EventArgs e )
        {
            try
            {

                if ( _blnIsInitialized )
                {

                    if ( swtch_Notify_UpdateWIFIIsEnable.IsToggled )
                    {
                        swtch_Notify_UpdateWIFIIsEnable.IsToggled = false;
                    }
                    else
                    {
                        swtch_Notify_UpdateWIFIIsEnable.IsToggled = true;
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