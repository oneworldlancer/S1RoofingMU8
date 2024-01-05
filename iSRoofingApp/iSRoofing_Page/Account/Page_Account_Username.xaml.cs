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
    public partial class Page_Account_Username : ContentView
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














        public Page_Account_Username ( )
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

                    try
                    {
                        //get the value by `arg`
                        //////////frm_CountryName.BorderColor = Colors.White;

                        //////////lbl_CountryList.Text = ( arg as SRoofingCountryModel ).CountryName.ToString ( );
                        //////////txt_MobileNumber.Text = "+" + ( arg as SRoofingCountryModel ).CountryMobileCode;// (arg as Employee).m
                        //////////txt_MobileNumber.IsEnabled = true;


                        //////////_register_CountryName = ( arg as SRoofingCountryModel ).CountryName;
                        //////////_register_CountryCode = ( arg as SRoofingCountryModel ).CountryCode;
                        //////////_register_CountryMobileCode = ( arg as SRoofingCountryModel ).CountryMobileCode;

                        ////////////txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;

                        _bln_IsCountryName = true;
                    }
                    catch ( Exception ex )
                    {
                        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                    }

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


                lbl_BirthDate.Text = _iOwnerModel.BirthDay + "-" + _iOwnerModel.BirthMonth + "-" + _iOwnerModel.BirthYear;

                txt_FirstName.Text = _iOwnerModel.FirstName;
                txt_LastName.Text = _iOwnerModel.LastName;


                if ( _iOwnerModel.Gender == SRoofingEnum_Gender.Gender_MALE )
                {

                    img_Male.WidthRequest = 60;
                    img_Male.Source = "img_gender_male_select.png";

                    img_Female.WidthRequest = 50;
                    img_Female.Source = "img_gender_female_normal_small.png";

                }

                else if ( _iOwnerModel.Gender == SRoofingEnum_Gender.Gender_FEMALE )
                {
                    img_Female.WidthRequest = 60;
                    img_Female.Source = "img_gender_female_select.png";

                    img_Male.WidthRequest = 50;
                    img_Male.Source = "img_gender_male_normal_small.png";

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

            //////////try
            //////////{

            //////////    _bln_IsRegister_RunningNow = true;

            //////////    _bln_MobileNumber = Register_ValidateUserLoginMobileNumberOnBlur ( );
            //////////    _register_Password = Get_Password_Current ( );
            //////////    _bln_Register_Step1 = Register_Step1 ( );

            //////////    MainThread.BeginInvokeOnMainThread ( ( ) =>
            //////////    {
            //////////        // Code to run on the main thread

            //////////        //    (( Page_Account_Dashboard ) Parent.BindingContext).Lose_Focus();

            //////////        if ( !_bln_IsCountryName )
            //////////        {
            //////////            frm_CountryName.BorderColor = Colors.Red;

            //////////            _bln_IsRegister_RunningNow = false;
            //////////            return;
            //////////        }

            //////////        if ( _register_Password != "0" && _bln_MobileNumber == true && _bln_IsCountryName && _bln_Register_Step1 )
            //////////        {

            //////////            //  ll_ProgressBar.IsVisible = true;
            //////////          ////////////////////  (( Page_Account_Dashboard ) Parent.BindingContext).Register_Show_Step2 ( true );

            //////////        }
            //////////        else
            //////////        {
            //////////            _bln_IsRegister_RunningNow = false;

            //////////            MainThread.BeginInvokeOnMainThread ( ( ) =>
            //////////            {
            //////////                // Code to run on the main thread
            //////////                (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Fill in your data!" );

            //////////            } );
            //////////        }
            //////////    } );




            //////////    ////////////////if (_register_Password != "0" && _bln_MobileNumber == true)
            //////////    ////////////////{

            //////////    ////////////////    _iOwnerUserTokenID =
            //////////    ////////////////        await SRoofing_UserMobileNumberManager
            //////////    ////////////////                                         .UserMobileNumber_Get_OwnerUserTokenID_ByMobileNumberE164(
            //////////    ////////////////                                                 App.Current,
            //////////    ////////////////                                                 _register_MobileNumberE164_Clean);

            //////////    ////////////////    _iOwnerMobileNumberTokenID =
            //////////    ////////////////      await SRoofing_UserMobileNumberManager
            //////////    ////////////////                    .UserMobileNumber_Get_OwnerMobileNumberTokenID_ByMobileNumberE164(
            //////////    ////////////////                            App.Current,
            //////////    ////////////////                            _register_MobileNumberE164_Clean);

            //////////    ////////////////    if (_iOwnerUserTokenID != "0" && _iOwnerMobileNumberTokenID != "0")
            //////////    ////////////////    {


            //////////    ////////////////        // (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage("Loading your profile info!");

            //////////    ////////////////        // Get_Owner_Model
            //////////    ////////////////        iOwnerModel = new SRoofingUserOwnerModelManager();
            //////////    ////////////////        iOwnerModel = await SRoofing_UserProfileOwnerManager
            //////////    ////////////////            .UserProfile_Get_Owner_Profile_ByAccountTypeWS(
            //////////    ////////////////            App.Current,
            //////////    ////////////////            _iOwnerUserTokenID,
            //////////    ////////////////            _iOwnerMobileNumberTokenID);



            //////////    ////////////////        if (iOwnerModel != null)
            //////////    ////////////////        {

            //////////    ////////////////            // Get_Owner_Setting_Model

            //////////    ////////////////            //  (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage("Loading your settings!");



            //////////    ////////////////            Preferences.Set("user_IsLogin", true);

            //////////    ////////////////            MainThread.BeginInvokeOnMainThread(async () =>
            //////////    ////////////////            {
            //////////    ////////////////                // Code to run on the main thread

            //////////    ////////////////             //   ll_ProgressBar.IsVisible = false;

            //////////    ////////////////                // Code to run on the main thread
            //////////    ////////////////                await SRoofing_Page_OpenerManager
            //////////    ////////////////                         .Page_Reset_Stack(
            //////////    ////////////////                         Navigation,
            //////////    ////////////////                         new Page_Landing_Dashboard());
            //////////    ////////////////            });


            //////////    ////////////////        }
            //////////    ////////////////        else
            //////////    ////////////////        {
            //////////    ////////////////            // Toast
            //////////    ////////////////            MainThread.BeginInvokeOnMainThread(() =>
            //////////    ////////////////            {

            //////////    ////////////////              //  ll_ProgressBar.IsVisible = false;


            //////////    ////////////////                (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage("Check your mobile number and pass code!");

            //////////    ////////////////                _bln_IsRegister_RunningNow = false;

            //////////    ////////////////            });
            //////////    ////////////////        }

            //////////    ////////////////    }

            //////////    ////////////////    else
            //////////    ////////////////    {
            //////////    ////////////////        // Toast
            //////////    ////////////////        MainThread.BeginInvokeOnMainThread(() =>
            //////////    ////////////////        {

            //////////    ////////////////        //    ll_ProgressBar.IsVisible = false;

            //////////    ////////////////            (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage("Check your mobile number and pass code!");

            //////////    ////////////////            _bln_IsRegister_RunningNow = false;

            //////////    ////////////////        });
            //////////    ////////////////    }

            //////////    ////////////////}
            //////////    ////////////////else
            //////////    ////////////////{
            //////////    ////////////////    // Toast
            //////////    //////////////////    ll_ProgressBar.IsVisible = false;

            //////////    ////////////////    (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage("Check your mobile number and pass code!");

            //////////    ////////////////    _bln_IsRegister_RunningNow = false;

            //////////    ////////////////}




            //////////}
            //////////catch ( Exception ex )
            //////////{
            //////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            //////////    return;
            //////////}

        }




        #endregion











        #region Password

        string strPassword = "0";

        bool bln_txt_Pswd1, bln_txt_Pswd2, bln_txt_Pswd3, bln_txt_Pswd4, bln_txt_Pswd5;



        bool _bln_IsPasswordVisible = false;
        int iTxtFocused = 0;



        async void lblCountryList_Clicked ( object sender , EventArgs e )
        {
            try
            {

                ////////////////////_blnIsInitialized_Step1 = true;

                ////////////////////await MauiPopup.PopupAction.DisplayPopup (
                ////////////////////  new iSRoofing_Popup.Popup_List_PickUp ( SRoofingEnum_PopupByCodeManager.PopupByCode_COUNTRY_LIST ) );



            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }


        private void txt_FirstName_Completed ( object sender , EventArgs e )
        {
            try
            {

                txt_LastName.Focus ( );

                if ( !string.IsNullOrWhiteSpace ( txt_LastName.Text ) )
                {
                    txt_LastName.CursorPosition = 0;
                    txt_LastName.SelectionLength = txt_LastName.Text.Length;

                }



            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }

        private void txt_LastName_Completed ( object sender , EventArgs e )
        {
            try
            {

                //////txt_Pswd1.Focus ( );

                //////if ( !string.IsNullOrWhiteSpace ( txt_Pswd1.Text ) )
                //////{
                //////    txt_Pswd1.CursorPosition = 0;
                //////    txt_Pswd1.SelectionLength = txt_Pswd1.Text.Length;

                //////}



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

                if ( !string.IsNullOrWhiteSpace ( txt_FirstName.Text )
                    && !string.IsNullOrWhiteSpace ( txt_LastName.Text ) )
                {
                    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                    {


                        _iOwnerModel.FirstName = txt_FirstName.Text;
                        _iOwnerModel.LastName = txt_LastName.Text;

                        await SRoofingSync_User_Owner_Manager.Sync_User_Owner_Update_UserModel (
                            App.Current , _iOwnerModel );

                        _ = Task.Run ( async ( ) =>
                        {
                            await SRoofing_UserSettingManager.UserSetting_Update_FullName_ByOwnerUserTokenID (
                                App.Current ,
             App.iAccountType ,
             _iOwnerModel ,
              txt_FirstName.Text ,
             txt_LastName.Text );

                        } ).ConfigureAwait ( false );


                    }


                    else
                    {
                        MainThread.BeginInvokeOnMainThread ( ( ) =>
                        {
                            // Code to run on the main thread
                            ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_Account_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                        } );
                    }

                }

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


        #endregion



        #region MobileNumber






        #endregion



        #region Register_Step1

        bool bln_IsFirstName = false, bln_IsLastName = false, bln_IsCountry = false;

        bool Register_Step1 ( )
        {

            try
            {

                /* First-Name */
                if ( !string.IsNullOrWhiteSpace ( txt_FirstName.Text ) )
                {
                    sl_FirstName.BackgroundColor = Colors.White;
                    _register_FirstName = txt_FirstName.Text.ToString ( );
                    bln_IsFirstName = true;
                }
                else
                {
                    frm_FirstName.BorderColor = Colors.Red;
                    //txt_FirstName.Focus();
                    //txt_FirstName.CursorPosition = 0;
                    //txt_FirstName.SelectionLength = txt_FirstName.Text.Length;
                    ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( "Fill in your first name!" );
                    // return false;
                }

                /* Last-Name */
                if ( !string.IsNullOrWhiteSpace ( txt_LastName.Text ) )
                {
                    sl_LastName.BackgroundColor = Colors.White;
                    _register_LastName = txt_LastName.Text.ToString ( );
                    bln_IsLastName = true;
                }
                else
                {
                    frm_LastName.BorderColor = Colors.Red;
                    //txt_LastName.Focus();
                    //txt_LastName.CursorPosition = 0;
                    //txt_LastName.SelectionLength = txt_LastName.Text.Length;
                    ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( "Fill in your last name!" );
                    // return false;
                }

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



        #region Gender


        async void img_Male_Clicked ( object sender , EventArgs e )
        {
            try
            {



                if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                {

                    img_Male.WidthRequest = 60;
                    img_Male.Source = "img_gender_male_select.png";

                    img_Female.WidthRequest = 50;
                    img_Female.Source = "img_gender_female_normal_small.png";

                    _register_Gender = "male";

                    //   _bln_IsGender = true;


                    _iOwnerModel.Gender = SRoofingEnum_Gender.Gender_MALE;

                    await SRoofingSync_User_Owner_Manager.Sync_User_Owner_Update_UserModel (
                        App.Current , _iOwnerModel );

                    _ = Task.Run ( async ( ) =>
                    {
                        await SRoofing_UserSettingManager.UserSetting_Update_Gender_ByOwnerUserTokenID (
                            App.Current ,
         App.iAccountType ,
         _iOwnerModel ,
          _register_Gender );

                    } ).ConfigureAwait ( false );


                }
                else
                {
                    MainThread.BeginInvokeOnMainThread ( ( ) =>
                    {
                        // Code to run on the main thread
                        ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_Account_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                    } );
                }



            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }

        async void img_Female_Clicked ( object sender , EventArgs e )
        {
            try
            {
                if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                {

                    img_Female.WidthRequest = 60;
                    img_Female.Source = "img_gender_female_select.png";

                    img_Male.WidthRequest = 50;
                    img_Male.Source = "img_gender_male_normal_small.png";

                    _register_Gender = "female";

                    //  _bln_IsGender = true;


                    _iOwnerModel.Gender = SRoofingEnum_Gender.Gender_FEMALE;

                    await SRoofingSync_User_Owner_Manager.Sync_User_Owner_Update_UserModel (
                        App.Current , _iOwnerModel );

                    _ = Task.Run ( async ( ) =>
                    {
                        await SRoofing_UserSettingManager.UserSetting_Update_Gender_ByOwnerUserTokenID (
                            App.Current ,
         App.iAccountType ,
         _iOwnerModel ,
          _register_Gender );

                    } ).ConfigureAwait ( false );

                }
                else
                {
                    MainThread.BeginInvokeOnMainThread ( ( ) =>
                    {
                        // Code to run on the main thread
                        ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_Account_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                    } );
                }







            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }


        //
        #endregion



        #region Initialize_LanguageModel


        public async Task Initialize_AppTranslation ( SRoofingLanguageTranslateModel _iLanguageModel )
        {
            try
            {

                if ( _iLanguageModel == null ) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All ( App.Current );


                //////if ( _iLanguageModel.LanguageCode == "ar" )
                //////{
                //////    // lbl_Title.HorizontalTextAlignment = TextAlignment.Start;
                //////    lbl_Title_BirthDate.HorizontalTextAlignment = TextAlignment.Start;
                //////    lbl_Title_FullName.HorizontalTextAlignment = TextAlignment.Start;
                //////    lbl_Title_Gender.HorizontalTextAlignment = TextAlignment.Start;

                //////}
                //////else
                //////{
                //////    // lbl_Title.HorizontalTextAlignment = TextAlignment.End;

                //////    lbl_Title_BirthDate.HorizontalTextAlignment = TextAlignment.End;
                //////    lbl_Title_FullName.HorizontalTextAlignment = TextAlignment.End;
                //////    lbl_Title_Gender.HorizontalTextAlignment = TextAlignment.End;
                //////}

                lbl_Title.Text = _iLanguageModel.lblText_PersonalInfo;
                lbl_Title_BirthDate.Text = _iLanguageModel.lblText_BirthDate;
                lbl_Title_FullName.Text = _iLanguageModel.lblText_FullName;
                lbl_Title_Gender.Text = _iLanguageModel.lblText_Gender;



                //   lbl_CountryList.Text = _iLanguageModel.lblText_YourCountry;
                //    txt_MobileNumber.Placeholder = _iLanguageModel.lblText_MobileNumber;
                txt_FirstName.Placeholder = _iLanguageModel.lblText_FirstName;
                txt_LastName.Placeholder = _iLanguageModel.lblText_LastName;

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



        #region BirthDate


        public string _register_BirthDay = "0", _register_BirthMonth = "0", _register_BirthYear = "0",
               _register_EmailAddress = "0", _register_Gender = "male";



        private async void dt_BirthDate_DateSelected ( object sender , DateChangedEventArgs e )
        {
            try
            {



                if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                {

                    //string strDay, strMonth, strYear;
                    _register_BirthDay = e.NewDate.Day.ToString ( );
                    _register_BirthMonth = e.NewDate.Month.ToString ( );
                    _register_BirthYear = e.NewDate.Year.ToString ( );

                    lbl_BirthDate.Text = _register_BirthDay + "-" + _register_BirthMonth + "-" + _register_BirthYear;

                    _iOwnerModel.BirthDay = _register_BirthDay;
                    _iOwnerModel.BirthMonth = _register_BirthMonth;
                    _iOwnerModel.BirthYear = _register_BirthYear;

                    _iOwnerModel.BirthYearsOld = ( DateTime.Now.Year - int.Parse ( _register_BirthYear ) ).ToString ( );

                    await SRoofingSync_User_Owner_Manager.Sync_User_Owner_Update_UserModel (
                        App.Current , _iOwnerModel );

                    _ = Task.Run ( async ( ) =>
               {
                   await SRoofing_UserSettingManager.UserSetting_Update_BirthDate_ByOwnerUserTokenID (
                       App.Current ,
    App.iAccountType ,
    _iOwnerModel ,
     _register_BirthDay ,
      _register_BirthMonth ,
    _register_BirthYear );

               } ).ConfigureAwait ( false );

                }
                else
                {
                    MainThread.BeginInvokeOnMainThread ( ( ) =>
                    {
                        // Code to run on the main thread
                        ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_Account_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                    } );
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