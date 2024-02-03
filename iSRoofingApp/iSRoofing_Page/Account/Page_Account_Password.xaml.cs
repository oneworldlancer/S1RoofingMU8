//// 

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
    public partial class Page_Account_Password : ContentView
    {



        #region Params

        //public Page_Login_Dashboard  (( Page_Account_Dashboard ) Parent.BindingContext) {get;set;}


        bool _bln_IsRegister_RunningNow = false;

        bool _blnIsInitialized_Step1 = false;

        public string _register_MobileNumberE164_Clean = "0", UserLoginMobileNumberE164 = "0";
        bool _blnMobileNumber = false;

        public string _register_CountryName = "0", _register_CountryCode = "0", _register_CountryMobileCode = "0",
            _register_FirstName = "0", _register_LastName = "0",
            _register_Password_Current = "0", _register_Password_New = "0", _register_MobileNumberE164 = "0";

        #endregion














        public Page_Account_Password ( )
        {
            InitializeComponent ( );

            try
            {




                //Task.Run ( async ( ) =>
                //{
                //    await Initialize_AppTranslation ( );
                //} ).Wait ( );












                MessagingCenter.Subscribe<App , SRoofingCountryModel> ( App.Current , "OpenPage" , ( snd , arg ) =>
                {

                    //////try
                    //////{
                    //////    //get the value by `arg`
                    //////    frm_CountryName.BorderColor = Colors.White;

                    //////    lbl_CountryList.Text = ( arg as SRoofingCountryModel ).CountryName.ToString ( );
                    //////    txt_MobileNumber.Text = "+" + ( arg as SRoofingCountryModel ).CountryMobileCode;// (arg as Employee).m
                    //////    txt_MobileNumber.IsEnabled = true;


                    //////    _register_CountryName = ( arg as SRoofingCountryModel ).CountryName;
                    //////    _register_CountryCode = ( arg as SRoofingCountryModel ).CountryCode;
                    //////    _register_CountryMobileCode = ( arg as SRoofingCountryModel ).CountryMobileCode;

                    //////    //txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;
                    //////    //txt_MobileNumber.Focus();

                    //////    //////   lbl_SignUp.IsEnabled = true;
                    //////    _bln_IsCountryName = true;
                    //////}
                    //////catch ( Exception ex )
                    //////{
                    //////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                    //////}

                } );



                ////this.txt_MobileNumber.Completed += async (object sender, EventArgs e) =>
                ////{

                ////    //await iApp_Login ( );
                ////   //////// await onPostExecute_LoginAsync();
                ////};






            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }




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



                //  lbl_CountryList.Text = _iOwnerModel.CountryName;

                txt_MobileNumber.Text = _iOwnerModel.MobileNumberE164;

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

                _bln_MobileNumber = Register_ValidateUserLoginMobileNumberOnBlur ( );
                _register_Password_Current = Get_Password_Current ( );
                _bln_Register_Step1 = Register_Step1 ( );

                MainThread.BeginInvokeOnMainThread ( ( ) =>
                {
                    // Code to run on the main thread

                    //    (( Page_Account_Dashboard ) Parent.BindingContext).Lose_Focus();

                    //////if ( !_bln_IsCountryName )
                    //////{
                    //////    frm_CountryName.BorderColor = Colors.Red;

                    //////    _bln_IsRegister_RunningNow = false;
                    //////    return;
                    //////}

                    if ( _register_Password_Current != "0" && _bln_MobileNumber == true && _bln_IsCountryName && _bln_Register_Step1 )
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
                            (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Fill in your data!" );

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











        #region Password

        string strPassword_Current = "0";
        string strPassword_New = "0";

        bool bln_txt_PswdCurrent1, bln_txt_PswdCurrent2, bln_txt_PswdCurrent3, bln_txt_PswdCurrent4, bln_txt_PswdCurrent5;



        bool bln_txt_PswdNew1, bln_txt_PswdNew2, bln_txt_PswdNew3, bln_txt_PswdNew4, bln_txt_PswdNew5;





        bool _bln_IsPasswordVisible_Current = false;
        bool _bln_IsPasswordVisible_New = false;
        int iTxtFocused = 0;


        #region Password_Current


        string Get_Password_Current ( )
        {

            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent1.Text ) )
                {
                    bln_txt_PswdCurrent1 = true;
                    frm_PswdCurrent1.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_PswdCurrent1.BorderColor = Colors.Red;
                }

                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent2.Text ) )
                {
                    bln_txt_PswdCurrent2 = true;
                    frm_PswdCurrent2.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_PswdCurrent2.BorderColor = Colors.Red;
                }

                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent3.Text ) )
                {
                    bln_txt_PswdCurrent3 = true;
                    frm_PswdCurrent3.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_PswdCurrent3.BorderColor = Colors.Red;
                }

                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent4.Text ) )
                {
                    bln_txt_PswdCurrent4 = true;
                    frm_PswdCurrent4.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_PswdCurrent4.BorderColor = Colors.Red;
                }

                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent5.Text ) )
                {
                    bln_txt_PswdCurrent5 = true;
                    frm_PswdCurrent5.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_PswdCurrent5.BorderColor = Colors.Red;
                }

                if ( bln_txt_PswdCurrent1 && bln_txt_PswdCurrent2 && bln_txt_PswdCurrent3 && bln_txt_PswdCurrent4 && bln_txt_PswdCurrent5 )
                {
                    strPassword_Current =
                        txt_PswdCurrent1.Text
                        + txt_PswdCurrent2.Text
                        + txt_PswdCurrent3.Text
                        + txt_PswdCurrent4.Text
                        + txt_PswdCurrent5.Text;
                }
                else
                {
                    (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Check your pass code!" );

                    return "0";
                }

                return strPassword_Current;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return "0";
            }
        }






        private void img_VisibleCurrent_Tapped ( object sender , EventArgs e )
        {

            try
            {

                if ( _bln_IsPasswordVisible_Current )
                {

                    img_VisibleCurrent.Source = "img_dating_eye_close.png";

                    txt_PswdCurrent1.IsPassword = true;
                    txt_PswdCurrent2.IsPassword = true;
                    txt_PswdCurrent3.IsPassword = true;
                    txt_PswdCurrent4.IsPassword = true;
                    txt_PswdCurrent5.IsPassword = true;

                    //if ( iTxtFocused == 1 )
                    //{
                    //    txt_PswdCurrent1.Focus ( );
                    //}
                    //else if ( iTxtFocused == 2 )
                    //{
                    //    txt_PswdCurrent2.Focus ( );
                    //}
                    //else if ( iTxtFocused == 3 )
                    //{
                    //    txt_PswdCurrent3.Focus ( );
                    //}
                    //else if ( iTxtFocused == 4 )
                    //{
                    //    txt_PswdCurrent4.Focus ( );
                    //}
                    //else if ( iTxtFocused == 5 )
                    //{
                    //    txt_PswdCurrent5.Focus ( );
                    //}

                    _bln_IsPasswordVisible_Current = false;
                }
                else
                {

                    img_VisibleCurrent.Source = "img_dating_eye_open.png";

                    txt_PswdCurrent1.IsPassword = false;
                    txt_PswdCurrent2.IsPassword = false;
                    txt_PswdCurrent3.IsPassword = false;
                    txt_PswdCurrent4.IsPassword = false;
                    txt_PswdCurrent5.IsPassword = false;


                    //if ( iTxtFocused == 1 )
                    //{
                    //    txt_PswdCurrent1.Focus ( );
                    //}
                    //else if ( iTxtFocused == 2 )
                    //{
                    //    txt_PswdCurrent2.Focus ( );
                    //}
                    //else if ( iTxtFocused == 3 )
                    //{
                    //    txt_PswdCurrent3.Focus ( );
                    //}
                    //else if ( iTxtFocused == 4 )
                    //{
                    //    txt_PswdCurrent4.Focus ( );
                    //}
                    //else if ( iTxtFocused == 5 )
                    //{
                    //    txt_PswdCurrent5.Focus ( );
                    //}

                    _bln_IsPasswordVisible_Current = true;
                }

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }


        protected void txt_PswdCurrent1_Focussed ( object sender , FocusEventArgs e )
        {
            try
            {
                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent1.Text ) )
                {
                    txt_PswdCurrent1.CursorPosition = 0;
                    txt_PswdCurrent1.SelectionLength = txt_PswdCurrent1.Text.Length;


                }


                iTxtFocused = 1;
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }


        protected void txt_PswdCurrent2_Focussed ( object sender , FocusEventArgs e )
        {
            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent2.Text ) )
                {
                    txt_PswdCurrent2.CursorPosition = 0;
                    txt_PswdCurrent2.SelectionLength = txt_PswdCurrent2.Text.Length;

                }



                iTxtFocused = 2;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }


        protected void txt_PswdCurrent3_Focussed ( object sender , FocusEventArgs e )
        {
            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent3.Text ) )
                {
                    txt_PswdCurrent3.CursorPosition = 0;
                    txt_PswdCurrent3.SelectionLength = txt_PswdCurrent3.Text.Length;

                }



                iTxtFocused = 3;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }


        protected void txt_PswdCurrent4_Focussed ( object sender , FocusEventArgs e )
        {
            try
            {
                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent4.Text ) )
                {
                    txt_PswdCurrent4.CursorPosition = 0;
                    txt_PswdCurrent4.SelectionLength = txt_PswdCurrent4.Text.Length;


                }



                iTxtFocused = 4;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }



        protected void txt_PswdCurrent5_Focussed ( object sender , FocusEventArgs e )
        {
            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent5.Text ) )
                {
                    txt_PswdCurrent5.CursorPosition = 0;
                    txt_PswdCurrent5.SelectionLength = txt_PswdCurrent5.Text.Length;

                }


                iTxtFocused = 5;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }



        private void txt_PswdCurrent1_TextChanged ( object sender , TextChangedEventArgs e )
        {

            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent1.Text ) )
                {
                    frm_PswdCurrent1.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }

                txt_PswdCurrent2.Focus ( );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }


        async void txt_PswdCurrent5_Completed ( object sender , EventArgs e )
        {
            try
            {


                //  cnt_Login_View.Focus();


                await Task.Delay ( 500 );

                if ( !_bln_IsRegister_RunningNow )
                {


                    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                    {
                        await onPostExecute_LoginAsync ( );
                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread ( ( ) =>
                        {
                            // Code to run on the main thread
                            (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( SRoofingEnum_Toast_MessageManager.Message_Internet_Connection.PopupMessage_MessageConnectionFalse ( ) );

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

        private void txt_PswdCurrent5_TextChanged ( object sender , TextChangedEventArgs e )
        {
            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent5.Text ) )
                {
                    frm_PswdCurrent5.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }

                //  btn_LogIn_Clicked(sender,e);

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }

        private void txt_PswdCurrent2_TextChanged ( object sender , TextChangedEventArgs e )
        {

            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent2.Text ) )
                {
                    frm_PswdCurrent2.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                txt_PswdCurrent3.Focus ( );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }
        private void txt_PswdCurrent3_TextChanged ( object sender , TextChangedEventArgs e )
        {

            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent3.Text ) )
                {
                    frm_PswdCurrent3.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                txt_PswdCurrent4.Focus ( );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }
        private void txt_PswdCurrent4_TextChanged ( object sender , TextChangedEventArgs e )
        {

            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdCurrent4.Text ) )
                {
                    frm_PswdCurrent4.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                txt_PswdCurrent5.Focus ( );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }



        #endregion










        #region Password_New


        string Get_Password_New ( )
        {

            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew1.Text ) )
                {
                    bln_txt_PswdNew1 = true;
                    frm_PswdNew1.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_PswdNew1.BorderColor = Colors.Red;
                }

                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew2.Text ) )
                {
                    bln_txt_PswdNew2 = true;
                    frm_PswdNew2.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_PswdNew2.BorderColor = Colors.Red;
                }

                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew3.Text ) )
                {
                    bln_txt_PswdNew3 = true;
                    frm_PswdNew3.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_PswdNew3.BorderColor = Colors.Red;
                }

                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew4.Text ) )
                {
                    bln_txt_PswdNew4 = true;
                    frm_PswdNew4.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_PswdNew4.BorderColor = Colors.Red;
                }

                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew5.Text ) )
                {
                    bln_txt_PswdNew5 = true;
                    frm_PswdNew5.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_PswdNew5.BorderColor = Colors.Red;
                }

                if ( bln_txt_PswdNew1 && bln_txt_PswdNew2 && bln_txt_PswdNew3 && bln_txt_PswdNew4 && bln_txt_PswdNew5 )
                {
                    strPassword_New =
                        txt_PswdNew1.Text
                        + txt_PswdNew2.Text
                        + txt_PswdNew3.Text
                        + txt_PswdNew4.Text
                        + txt_PswdNew5.Text;
                }
                else
                {
                    (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Check your pass code!" );

                    return "0";
                }

                return strPassword_New;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return "0";
            }
        }






        private void img_VisibleNew_Tapped ( object sender , EventArgs e )
        {

            try
            {

                if ( _bln_IsPasswordVisible_New )
                {

                    img_VisibleNew.Source = "img_dating_eye_close.png";

                    txt_PswdNew1.IsPassword = true;
                    txt_PswdNew2.IsPassword = true;
                    txt_PswdNew3.IsPassword = true;
                    txt_PswdNew4.IsPassword = true;
                    txt_PswdNew5.IsPassword = true;

                    //if ( iTxtFocused == 1 )
                    //{
                    //    txt_PswdNew1.Focus ( );
                    //}
                    //else if ( iTxtFocused == 2 )
                    //{
                    //    txt_PswdNew2.Focus ( );
                    //}
                    //else if ( iTxtFocused == 3 )
                    //{
                    //    txt_PswdNew3.Focus ( );
                    //}
                    //else if ( iTxtFocused == 4 )
                    //{
                    //    txt_PswdNew4.Focus ( );
                    //}
                    //else if ( iTxtFocused == 5 )
                    //{
                    //    txt_PswdNew5.Focus ( );
                    //}

                    _bln_IsPasswordVisible_New = false;
                }
                else
                {

                    img_VisibleNew.Source = "img_dating_eye_open.png";

                    txt_PswdNew1.IsPassword = false;
                    txt_PswdNew2.IsPassword = false;
                    txt_PswdNew3.IsPassword = false;
                    txt_PswdNew4.IsPassword = false;
                    txt_PswdNew5.IsPassword = false;


                    //if ( iTxtFocused == 1 )
                    //{
                    //    txt_PswdNew1.Focus ( );
                    //}
                    //else if ( iTxtFocused == 2 )
                    //{
                    //    txt_PswdNew2.Focus ( );
                    //}
                    //else if ( iTxtFocused == 3 )
                    //{
                    //    txt_PswdNew3.Focus ( );
                    //}
                    //else if ( iTxtFocused == 4 )
                    //{
                    //    txt_PswdNew4.Focus ( );
                    //}
                    //else if ( iTxtFocused == 5 )
                    //{
                    //    txt_PswdNew5.Focus ( );
                    //}

                    _bln_IsPasswordVisible_New = true;
                }

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }


        protected void txt_PswdNew1_Focussed ( object sender , FocusEventArgs e )
        {
            try
            {
                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew1.Text ) )
                {
                    txt_PswdNew1.CursorPosition = 0;
                    txt_PswdNew1.SelectionLength = txt_PswdNew1.Text.Length;


                }


                iTxtFocused = 1;
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }


        protected void txt_PswdNew2_Focussed ( object sender , FocusEventArgs e )
        {
            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew2.Text ) )
                {
                    txt_PswdNew2.CursorPosition = 0;
                    txt_PswdNew2.SelectionLength = txt_PswdNew2.Text.Length;

                }



                iTxtFocused = 2;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }


        protected void txt_PswdNew3_Focussed ( object sender , FocusEventArgs e )
        {
            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew3.Text ) )
                {
                    txt_PswdNew3.CursorPosition = 0;
                    txt_PswdNew3.SelectionLength = txt_PswdNew3.Text.Length;

                }



                iTxtFocused = 3;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }


        protected void txt_PswdNew4_Focussed ( object sender , FocusEventArgs e )
        {
            try
            {
                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew4.Text ) )
                {
                    txt_PswdNew4.CursorPosition = 0;
                    txt_PswdNew4.SelectionLength = txt_PswdNew4.Text.Length;


                }



                iTxtFocused = 4;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }

     
        protected void txt_PswdNew5_Focussed ( object sender , FocusEventArgs e )
        {
            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew5.Text ) )
                {
                    txt_PswdNew5.CursorPosition = 0;
                    txt_PswdNew5.SelectionLength = txt_PswdNew5.Text.Length;

                }


                iTxtFocused = 5;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }



        private void txt_PswdNew1_TextChanged ( object sender , TextChangedEventArgs e )
        {

            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew1.Text ) )
                {
                    frm_PswdNew1.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }

                txt_PswdNew2.Focus ( );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }


        async void txt_PswdNew5_Completed ( object sender , EventArgs e )
        {
            try
            {


                //  cnt_Login_View.Focus();


                await Task.Delay ( 500 );

                if ( !_bln_IsRegister_RunningNow )
                {


                    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                    {
                        await onPostExecute_LoginAsync ( );
                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread ( ( ) =>
                        {
                            // Code to run on the main thread
                            (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( SRoofingEnum_Toast_MessageManager.Message_Internet_Connection.PopupMessage_MessageConnectionFalse ( ) );

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

        private void txt_PswdNew5_TextChanged ( object sender , TextChangedEventArgs e )
        {
            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew5.Text ) )
                {
                    frm_PswdNew5.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }

                //  btn_LogIn_Clicked(sender,e);

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }

        private void txt_PswdNew2_TextChanged ( object sender , TextChangedEventArgs e )
        {

            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew2.Text ) )
                {
                    frm_PswdNew2.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                txt_PswdNew3.Focus ( );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }
        private void txt_PswdNew3_TextChanged ( object sender , TextChangedEventArgs e )
        {

            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew3.Text ) )
                {
                    frm_PswdNew3.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                txt_PswdNew4.Focus ( );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }
        private void txt_PswdNew4_TextChanged ( object sender , TextChangedEventArgs e )
        {

            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_PswdNew4.Text ) )
                {
                    frm_PswdNew4.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                txt_PswdNew5.Focus ( );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }



        #endregion













        async void lblCountryList_Clicked ( object sender , EventArgs e )
        {
            try
            {

                _blnIsInitialized_Step1 = true;

                ////////////////////await MauiPopup.PopupAction.DisplayPopup (
                ////////////////////  new iSRoofing_Popup.Popup_List_PickUp ( SRoofingEnum_PopupByCodeManager.PopupByCode_COUNTRY_LIST ) );



            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }

        private void txt_MobileNumber_TextChanged ( object sender , TextChangedEventArgs e )
        {
            try
            {
                frm_MobileNumber.BorderColor = Colors.White;
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }


        async void btn_Submit_Clicked ( object sender , EventArgs e )
        {
            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_MobileNumber.Text ) )
                {

                    _register_Password_Current = Get_Password_Current ( );


                    _register_Password_New = Get_Password_New ( );


                    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                    {
                        string _iOwnerPassword = await SRoofing_UserManager.Initialize_User_User_GetUserPasswordByUserID (
                            App.Current , App.iAccountType , _iOwnerModel );


                        if ( _register_Password_Current != "0"
                            && _register_Password_New != "0"
                            && _register_Password_Current == _iOwnerPassword
                            && _iOwnerModel.MobileNumberE164 == txt_MobileNumber.Text )
                        {

                            //   _iOwnerModel.Pass = _register_CountryCode;
                            //_iOwnerModel.CountryName = _register_CountryName;
                            //_iOwnerModel.MobileNumberE164 = _register_MobileNumberE164;

                            //await SRoofingSync_User_Owner_Manager.Sync_User_Owner_Update_UserModel (
                            //    App.Current , _iOwnerModel );

                              Task.Run ( async ( ) =>
                            {
                                await SRoofing_UserSettingManager.UserSetting_Update_Password_ByOwnerUserTokenID (
                                    App.Current ,
                 App.iAccountType ,
                 _iOwnerModel ,
                 _register_Password_New );
                            } ).ConfigureAwait ( false );

                        }
                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread ( ( ) =>
                        {
                            // Code to run on the main thread
                            (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( (( Page_Account_Dashboard ) Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message );

                        } );
                    }

                }

                await (( Page_Account_Dashboard ) Parent.BindingContext).CloseDrawer ( );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }

        private void txt_MobileNumber_Focussed ( object sender , FocusEventArgs e )
        {
            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_MobileNumber.Text ) )
                {
                    txt_MobileNumber.CursorPosition = 0;
                    txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;


                }

                //txt_MobileNumber.IsEnabled = true;
                //txt_MobileNumber.Focus();

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }



        private void txt_MobileNumber_Completed ( object sender , EventArgs e )
        {
            try
            {

                ////txt_FirstName.Focus ( );
                ////if ( !string.IsNullOrWhiteSpace ( txt_FirstName.Text ) )
                ////{
                ////    txt_FirstName.CursorPosition = 0;
                ////    txt_FirstName.SelectionLength = txt_FirstName.Text.Length;

                ////}



            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }

        #endregion


        #region MobileNumber



        bool Register_ValidateUserLoginMobileNumberOnBlur ( )
        {

            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_MobileNumber.Text ) )
                {

                    if ( txt_MobileNumber.Text.Length > 0 )
                    {

                        // get numE164 from edtNmuber , and check if valid
                        /*  UserLoginCountryCode = tvCountryCodeList.Text.ToString().toUpperCase();
                          UserLoginCountryMobileCode = TlknMobileNumberManager
                                  .MobileNumber_GetCountryMobileCodeFromCountryCode(

                                          getActivity(), UserLoginCountryCode);*/


                        if ( txt_MobileNumber.Text
                                             .ToString ( )
                                             .Substring ( 0 , 1 ) == ( "+" ) )
                        {

                            _register_MobileNumberE164_Clean = txt_MobileNumber.Text.ToString ( ).Substring (
                                    1 ,
                                    txt_MobileNumber.Text.ToString ( ).Length - 1 );
                        }
                        else
                        {
                            _register_MobileNumberE164_Clean = txt_MobileNumber.Text.ToString ( );
                        }

                        frm_MobileNumber.BorderColor = Colors.White;


                        UserLoginMobileNumberE164 = SRoofing_MobileNumberManager
                                .MobileNumber_ValidateMobileNumberE164FromMobileNumberRaw (
                                        App.Current ,
                                        "+" + _register_MobileNumberE164_Clean );

                        _register_MobileNumberE164 = UserLoginMobileNumberE164;

                        SRoofing_DebugManager.Debug_ShowSystemMessage ( "_MobileNumberE164_New: " + UserLoginMobileNumberE164 );

                        if ( ( UserLoginMobileNumberE164 == ( "0" ) )
                             || ( UserLoginMobileNumberE164 == ( "false" ) ) )
                        {
                            // this invalid number , we do error message
                            ////lbl_ErrorMessage.Text = ("This\'s NOT a valid number!");
                            MainThread.BeginInvokeOnMainThread ( ( ) =>
                            {
                                frm_MobileNumber.BorderColor = Colors.Red;
                                (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "This\'s NOT a valid number!" );
                                return;
                            } );
                            //txt_MobileNumber.selectAll();


                        }
                        else
                        {

                            //lbl_ErrorMessage.Text = (null);

                            /*   txt_MobileNumber.setText(TlknMobileNumberManager
                                       .MobileNumber_GetMobileNumberInternationalFromMobileNumberE164(
                                               getActivity(), "+" +
                                               txt_MobileNumber.Text.ToString()));*/

                            _blnMobileNumber = true;

                        }

                    }
                    else
                    {
                        frm_MobileNumber.BorderColor = Colors.Red;
                        (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Fill in your mobile number!" );
                        return false;
                        //lbl_ErrorMessage.Text = ("Fill in your mobile number!");
                    }
                }
                else
                {
                    frm_MobileNumber.BorderColor = Colors.Red;

                    (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Fill in your mobile number!" );
                    return false;

                }



                return _blnMobileNumber;
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return false;
            }
        }




        #endregion



        #region Register_Step1

        bool bln_IsFirstName = false, bln_IsLastName = false, bln_IsCountry = false;

        bool Register_Step1 ( )
        {

            try
            {

                //////    /* First-Name */
                //////    if ( !string.IsNullOrWhiteSpace ( txt_FirstName.Text ) )
                //////    {
                //////        sl_FirstName.BackgroundColor = Colors.White;
                //////        _register_FirstName = txt_FirstName.Text.ToString ( );
                //////        bln_IsFirstName = true;
                //////    }
                //////    else
                //////    {
                //////        frm_FirstName.BorderColor = Colors.Red;
                //////        //txt_FirstName.Focus();
                //////        //txt_FirstName.CursorPosition = 0;
                //////        //txt_FirstName.SelectionLength = txt_FirstName.Text.Length;
                //////        (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Fill in your first name!" );
                //////        // return false;
                //////    }

                //////    /* Last-Name */
                //////    if ( !string.IsNullOrWhiteSpace ( txt_LastName.Text ) )
                //////    {
                //////        sl_LastName.BackgroundColor = Colors.White;
                //////        _register_LastName = txt_LastName.Text.ToString ( );
                //////        bln_IsLastName = true;
                //////    }
                //////    else
                //////    {
                //////        frm_LastName.BorderColor = Colors.Red;
                //////        //txt_LastName.Focus();
                //////        //txt_LastName.CursorPosition = 0;
                //////        //txt_LastName.SelectionLength = txt_LastName.Text.Length;
                //////        (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Fill in your last name!" );
                //////        // return false;
                //////    }

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
                //////    lbl_Title_Password_Current.HorizontalTextAlignment = TextAlignment.Start;
                //////    lbl_Title_Password_New.HorizontalTextAlignment = TextAlignment.Start;

                //////}
                //////else
                //////{
                //////    lbl_Title.HorizontalTextAlignment = TextAlignment.End;
                //////    lbl_Title_Password_Current.HorizontalTextAlignment = TextAlignment.End;
                //////    lbl_Title_Password_New.HorizontalTextAlignment = TextAlignment.End;

                //////}
                //"S1Roofing " +

                lbl_Title.Text = _iLanguageModel.lblText_Password;
                lbl_Title_Password_Current.Text = _iLanguageModel.lblText_Password_Current;
                lbl_Title_Password_New.Text = _iLanguageModel.lblText_Password_New;



                //lbl_CountryList.Text = _iLanguageModel.lblText_YourCountry;
                txt_MobileNumber.Placeholder = _iLanguageModel.lblText_MobileNumber;
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











    }
}