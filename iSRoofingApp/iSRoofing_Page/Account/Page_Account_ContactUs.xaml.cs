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
    public partial class Page_Account_ContactUs : ContentView
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














        public Page_Account_ContactUs ( )
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

                    //try
                    //{
                    //    //get the value by `arg`
                    //    frm_CountryName.BorderColor = Colors.White;

                    //    lbl_CountryList.Text = ( arg as SRoofingCountryModel ).CountryName.ToString ( );
                    //    txt_ContactUs_Message.Text = "+" + ( arg as SRoofingCountryModel ).CountryMobileCode;// (arg as Employee).m
                    //    txt_ContactUs_Message.IsEnabled = true;


                    //    _register_CountryName = ( arg as SRoofingCountryModel ).CountryName;
                    //    _register_CountryCode = ( arg as SRoofingCountryModel ).CountryCode;
                    //    _register_CountryMobileCode = ( arg as SRoofingCountryModel ).CountryMobileCode;

                    //    //txt_ContactUs_Message.SelectionLength = txt_ContactUs_Message.Text.Length;
                    //    //txt_ContactUs_Message.Focus();

                    //    //////   lbl_SignUp.IsEnabled = true;
                    //    _bln_IsCountryName = true;
                    //}
                    //catch ( Exception ex )
                    //{
                    //    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                    //}

                } );



                ////this.txt_ContactUs_Message.Completed += async (object sender, EventArgs e) =>
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


                //lbl_BirthDate.Text = _iOwnerModel.BirthDay + "-" + _iOwnerModel.BirthMonth + "-" + _iOwnerModel.BirthYearsOld;

                //txt_FirstName.Text = _iOwnerModel.FirstName;
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

                ////////_bln_MobileNumber = Register_ValidateUserLoginMobileNumberOnBlur ( );
                ////////_register_Password = Get_Password_Current ( );
                ////////_bln_Register_Step1 = Register_Step1 ( );

                ////////MainThread.BeginInvokeOnMainThread ( ( ) =>
                ////////{
                ////////    // Code to run on the main thread

                ////////    //    (( Page_Account_Dashboard ) Parent.BindingContext).Lose_Focus();

                ////////    if ( !_bln_IsCountryName )
                ////////    {
                ////////        frm_CountryName.BorderColor = Colors.Red;

                ////////        _bln_IsRegister_RunningNow = false;
                ////////        return;
                ////////    }

                ////////    if ( _register_Password != "0" && _bln_MobileNumber == true && _bln_IsCountryName && _bln_Register_Step1 )
                ////////    {

                ////////        //  ll_ProgressBar.IsVisible = true;
                ////////      ////////////////////  (( Page_Account_Dashboard ) Parent.BindingContext).Register_Show_Step2 ( true );

                ////////    }
                ////////    else
                ////////    {
                ////////        _bln_IsRegister_RunningNow = false;

                ////////        MainThread.BeginInvokeOnMainThread ( ( ) =>
                ////////        {
                ////////            // Code to run on the main thread
                ////////            (( Page_Account_Dashboard ) Parent.BindingContext).Snack_ShowMessage ( "Fill in your data!" );

                ////////        } );
                ////////    }
                ////////} );




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

        string strPassword = "0";

        bool bln_txt_Pswd1, bln_txt_Pswd2, bln_txt_Pswd3, bln_txt_Pswd4, bln_txt_Pswd5;
    bool _bln_IsPasswordVisible = false;
        int iTxtFocused = 0;


   
           
        async void btn_Submit_Clicked ( object sender , EventArgs e )
        {

            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_ContactUs_Message.Text ) )
                {
                    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                    {

                          Task.Run ( async ( ) =>
                        {
                            await SRoofing_UserSettingManager.UserSetting_Update_ContactUs_Message_ByOwnerUserTokenID (
                                App.Current ,
             App.iAccountType ,
             _iOwnerModel ,
              txt_ContactUs_Message.Text );

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



        bool Register_ValidateUserLoginMobileNumberOnBlur ( )
        {

            try
            {

                if ( !string.IsNullOrWhiteSpace ( txt_ContactUs_Message.Text ) )
                {

                    if ( txt_ContactUs_Message.Text.Length > 0 )
                    {

                        // get numE164 from edtNmuber , and check if valid
                        /*  UserLoginCountryCode = tvCountryCodeList.Text.ToString().toUpperCase();
                          UserLoginCountryMobileCode = TlknMobileNumberManager
                                  .MobileNumber_GetCountryMobileCodeFromCountryCode(

                                          getActivity(), UserLoginCountryCode);*/


                        if ( txt_ContactUs_Message.Text
                                             .ToString ( )
                                             .Substring ( 0 , 1 ) == ( "+" ) )
                        {

                            _register_MobileNumberE164_Clean = txt_ContactUs_Message.Text.ToString ( ).Substring (
                                    1 ,
                                    txt_ContactUs_Message.Text.ToString ( ).Length - 1 );
                        }
                        else
                        {
                            _register_MobileNumberE164_Clean = txt_ContactUs_Message.Text.ToString ( );
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
                            //txt_ContactUs_Message.selectAll();


                        }
                        else
                        {

                            //lbl_ErrorMessage.Text = (null);

                            /*   txt_ContactUs_Message.setText(TlknMobileNumberManager
                                       .MobileNumber_GetMobileNumberInternationalFromMobileNumberE164(
                                               getActivity(), "+" +
                                               txt_ContactUs_Message.Text.ToString()));*/

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
                 
                //////}
                //////else
                //////{
                //////    lbl_Title.HorizontalTextAlignment = TextAlignment.End;
                
                //////}
                                        //"S1Roofing " + 
                lbl_Title.Text = _iLanguageModel.lblText_ContactUs;
                txt_ContactUs_Message.Placeholder= _iLanguageModel.lblText_ContactUs_Message;


                ////lbl_CountryList.Text = _iLanguageModel.lblText_YourCountry;
                ////txt_ContactUs_Message.Placeholder = _iLanguageModel.lblText_MobileNumber;
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












    }
}