////// 
////// 

//using Mopups.Services;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
//////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Login;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 




namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Register
{
    ////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Register_Step1 : ContentView
    {



        #region Params

        //public Page_Login_Dashboard  iParent {get;set;}


        bool _bln_IsRegister_RunningNow = false;

        bool _blnIsInitialized_Step1 = false;

        public string _register_MobileNumberE164_Clean = "0", UserLoginMobileNumberE164 = "0";
        bool _blnMobileNumber = false;

        public string _register_CountryName = "0", _register_CountryCode = "0", _register_CountryMobileCode = "0",
            _register_FirstName = "0", _register_LastName = "0",
            _register_Password = "0", _register_MobileNumberE164 = "0";

        #endregion














        public Page_Register_Step1()
        {
            InitializeComponent();

            try
            {



                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    //IconTintColorEffect.SetTintColor ( img_Login , Colors.White );
                });



                //Task.Run ( async ( ) =>
                //{
                //    await Initialize_AppTranslation ( );
                //} ).Wait ( );












                MessagingCenter.Subscribe<App, SRoofingCountryModel>(App.Current, "OpenPage", (snd, arg) =>
                {

                    try
                    {
                        //get the value by `arg`
                        frm_CountryName.BorderColor = Colors.White;

                        lbl_CountryList.Text = (arg as SRoofingCountryModel).CountryName.ToString();
                        txt_MobileNumber.Text = "+" + (arg as SRoofingCountryModel).CountryMobileCode;// (arg as Employee).m
                        txt_MobileNumber.IsEnabled = true;


                        _register_CountryName = (arg as SRoofingCountryModel).CountryName;
                        _register_CountryCode = (arg as SRoofingCountryModel).CountryCode;
                        _register_CountryMobileCode = (arg as SRoofingCountryModel).CountryMobileCode;

                        //txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;
                        //txt_MobileNumber.Focus();

                        //////   lbl_SignUp.IsEnabled = true;
                        _bln_IsCountryName = true;
                    }
                    catch (Exception ex)
                    {
                        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    }

                });



                ////this.txt_MobileNumber.Completed += async (object sender, EventArgs e) =>
                ////{

                ////    //await iApp_Login ( );
                ////   //////// await onPostExecute_LoginAsync();
                ////};






            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }






        #region Property



        public static readonly BindableProperty iParentProperty = BindableProperty
            .Create("iParent", typeof(Page_Register_Dashboard),
            typeof(Page_Register_Step1), null);
        public Page_Register_Dashboard iParent
        {
            get { return (Page_Register_Dashboard)GetValue(iParentProperty); }
            set { SetValue(iParentProperty, value); }
        }



        #endregion





        #region Register-1



        string _login_MobileNumber = "0";
        bool _bln_MobileNumber = false;
        bool _bln_Register_Step1 = false;
        bool _bln_IsCountryName = false;
        async Task onPostExecute_LoginAsync()
        {

            try
            {

                _bln_IsRegister_RunningNow = true;

                _bln_MobileNumber =await Register_ValidateUserLoginMobileNumberOnBlur();
                _register_Password =await Get_Password();
                _bln_Register_Step1 =await Register_Step1();

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    // Code to run on the main thread

                    //    iParent.Lose_Focus();

                    if (!_bln_IsCountryName)
                    {
                        frm_CountryName.BorderColor = Colors.Red;

                        _bln_IsRegister_RunningNow = false;
                        return;
                    }

                    if (_register_Password != "0" && _bln_MobileNumber == true && _bln_IsCountryName && _bln_Register_Step1)
                    {

                        //  ll_ProgressBar.IsVisible = true;
                        iParent.Register_Show_Step2(true);

                    }
                    else
                    {
                        _bln_IsRegister_RunningNow = false;

                        MainThread.BeginInvokeOnMainThread(async () =>
                        {
                            // Code to run on the main thread
                            await iParent.Snack_ShowMessage(_iLanguageModel.lblText_Fill_Data_Message);

                        });
                    }
                });




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


                ////////////////        // iParent.Snack_ShowMessage("Loading your profile info!");

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

                ////////////////            //  iParent.Snack_ShowMessage("Loading your settings!");



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


                ////////////////                iParent.Snack_ShowMessage("Check your mobile number and pass code!");

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

                ////////////////            iParent.Snack_ShowMessage("Check your mobile number and pass code!");

                ////////////////            _bln_IsRegister_RunningNow = false;

                ////////////////        });
                ////////////////    }

                ////////////////}
                ////////////////else
                ////////////////{
                ////////////////    // Toast
                //////////////////    ll_ProgressBar.IsVisible = false;

                ////////////////    iParent.Snack_ShowMessage("Check your mobile number and pass code!");

                ////////////////    _bln_IsRegister_RunningNow = false;

                ////////////////}




            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }




        #endregion











        #region Password

        string strPassword = "0";

        bool bln_txt_Pswd1, bln_txt_Pswd2, bln_txt_Pswd3, bln_txt_Pswd4, bln_txt_Pswd5;

        async Task<string> Get_Password()
        {

            try
            {

                if (!string.IsNullOrWhiteSpace(txt_Pswd1.Text))
                {
                    bln_txt_Pswd1 = true;
                    frm_Pswd1.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_Pswd1.BorderColor = Colors.Red;
                }

                if (!string.IsNullOrWhiteSpace(txt_Pswd2.Text))
                {
                    bln_txt_Pswd2 = true;
                    frm_Pswd2.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_Pswd2.BorderColor = Colors.Red;
                }

                if (!string.IsNullOrWhiteSpace(txt_Pswd3.Text))
                {
                    bln_txt_Pswd3 = true;
                    frm_Pswd3.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_Pswd3.BorderColor = Colors.Red;
                }

                if (!string.IsNullOrWhiteSpace(txt_Pswd4.Text))
                {
                    bln_txt_Pswd4 = true;
                    frm_Pswd4.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_Pswd4.BorderColor = Colors.Red;
                }

                if (!string.IsNullOrWhiteSpace(txt_Pswd5.Text))
                {
                    bln_txt_Pswd5 = true;
                    frm_Pswd5.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                else
                {
                    frm_Pswd5.BorderColor = Colors.Red;
                }

                if (bln_txt_Pswd1 && bln_txt_Pswd2 && bln_txt_Pswd3 && bln_txt_Pswd4 && bln_txt_Pswd5)
                {
                    strPassword =
                        txt_Pswd1.Text
                        + txt_Pswd2.Text
                        + txt_Pswd3.Text
                        + txt_Pswd4.Text
                        + txt_Pswd5.Text;
                }
                else
                {
                    await iParent.Snack_ShowMessage(_iLanguageModel.lblText_Fill_Password_Message);

                    return "0";
                }

                return strPassword;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }









        bool _bln_IsPasswordVisible = false;
        int iTxtFocused = 0;
        private void img_Visible_Tapped(object sender, EventArgs e)
        {

            try
            {

                if (_bln_IsPasswordVisible)
                {

                    img_Visible.Source = "img_dating_eye_close.png";

                    txt_Pswd1.IsPassword = true;
                    txt_Pswd2.IsPassword = true;
                    txt_Pswd3.IsPassword = true;
                    txt_Pswd4.IsPassword = true;
                    txt_Pswd5.IsPassword = true;

                    //if (iTxtFocused == 1)
                    //{
                    //    txt_Pswd1.Focus();
                    //}
                    //else if (iTxtFocused == 2)
                    //{
                    //    txt_Pswd2.Focus();
                    //}
                    //else if (iTxtFocused == 3)
                    //{
                    //    txt_Pswd3.Focus();
                    //}
                    //else if (iTxtFocused == 4)
                    //{
                    //    txt_Pswd4.Focus();
                    //}
                    //else if (iTxtFocused == 5)
                    //{
                    //    txt_Pswd5.Focus();
                    //}

                    _bln_IsPasswordVisible = false;
                }
                else
                {

                    img_Visible.Source = "img_dating_eye_open.png";

                    txt_Pswd1.IsPassword = false;
                    txt_Pswd2.IsPassword = false;
                    txt_Pswd3.IsPassword = false;
                    txt_Pswd4.IsPassword = false;
                    txt_Pswd5.IsPassword = false;


                    //if (iTxtFocused == 1)
                    //{
                    //    txt_Pswd1.Focus();
                    //}
                    //else if (iTxtFocused == 2)
                    //{
                    //    txt_Pswd2.Focus();
                    //}
                    //else if (iTxtFocused == 3)
                    //{
                    //    txt_Pswd3.Focus();
                    //}
                    //else if (iTxtFocused == 4)
                    //{
                    //    txt_Pswd4.Focus();
                    //}
                    //else if (iTxtFocused == 5)
                    //{
                    //    txt_Pswd5.Focus();
                    //}

                    _bln_IsPasswordVisible = true;
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        protected void txt_Pswd1_Focussed(object sender, FocusEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_Pswd1.Text))
                {
                    txt_Pswd1.CursorPosition = 0;
                    txt_Pswd1.SelectionLength = txt_Pswd1.Text.Length;


                }


                iTxtFocused = 1;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        protected void txt_Pswd2_Focussed(object sender, FocusEventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(txt_Pswd2.Text))
                {
                    txt_Pswd2.CursorPosition = 0;
                    txt_Pswd2.SelectionLength = txt_Pswd2.Text.Length;

                }



                iTxtFocused = 2;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        protected void txt_Pswd3_Focussed(object sender, FocusEventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(txt_Pswd3.Text))
                {
                    txt_Pswd3.CursorPosition = 0;
                    txt_Pswd3.SelectionLength = txt_Pswd3.Text.Length;

                }



                iTxtFocused = 3;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        protected void txt_Pswd4_Focussed(object sender, FocusEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_Pswd4.Text))
                {
                    txt_Pswd4.CursorPosition = 0;
                    txt_Pswd4.SelectionLength = txt_Pswd4.Text.Length;


                }



                iTxtFocused = 4;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }

        async void lblCountryList_Clicked(object sender, EventArgs e)
        {
            try
            {

                _blnIsInitialized_Step1 = true;


                ////////////////////if ( PopupNavigation.Instance.PopupStack.Count > 0 )
                ////////////////////{
                ////////////////////    await Navigation.PopAllPopupAsync ( );
                ////////////////////}

                await MauiPopup.PopupAction.DisplayPopup(
                  new iSRoofing_Popup.Popup_List_PickUp(
                            iParent._iApplicationUtilityModel,
            SRoofingEnum_PopupByCodeManager.PopupByCode_COUNTRY_LIST));

                //await MopupService.Instance.PushAsync(
                //   new iSRoofing_Popup.Popup_List_PickUp(SRoofingEnum_PopupByCodeManager.PopupByCode_COUNTRY_LIST));

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private void txt_MobileNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                frm_MobileNumber.BorderColor = Colors.White;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private void txt_FirstName_Completed(object sender, EventArgs e)
        {
            try
            {

                txt_LastName.Focus();

                if (!string.IsNullOrWhiteSpace(txt_LastName.Text))
                {
                    txt_LastName.CursorPosition = 0;
                    txt_LastName.SelectionLength = txt_LastName.Text.Length;

                }



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private void txt_LastName_Completed(object sender, EventArgs e)
        {
            try
            {

                txt_Pswd1.Focus();

                if (!string.IsNullOrWhiteSpace(txt_Pswd1.Text))
                {
                    txt_Pswd1.CursorPosition = 0;
                    txt_Pswd1.SelectionLength = txt_Pswd1.Text.Length;

                }



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void btn_Register_Step1_Clicked(object sender, EventArgs e)
        {
            try
            {
                //  Task.Run(() => {
                //    // some long running task

                //});


                #region HideKeyboard

                await Task.Delay(100);

                S1RoofingMU.Platforms.KeyboardHelper.HideKeyboard();

                await Task.Delay(100);

                #endregion



                if (!_bln_IsRegister_RunningNow)
                {


                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {
                        await onPostExecute_LoginAsync();
                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread(async () =>
                        {
                            // Code to run on the main thread
                            await iParent.Snack_ShowMessage(_iLanguageModel.lblText_Connection_CheckOnline_Message);
                            //iParent.Snack_ShowMessage ( SRoofingEnum_Toast_MessageManager.Message_Internet_Connection.PopupMessage_MessageConnectionFalse ( ) );

                        });
                    }


                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        protected void txt_Pswd5_Focussed(object sender, FocusEventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(txt_Pswd5.Text))
                {
                    txt_Pswd5.CursorPosition = 0;
                    txt_Pswd5.SelectionLength = txt_Pswd5.Text.Length;

                }


                iTxtFocused = 5;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }



        private void txt_Pswd1_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {

                if (!string.IsNullOrWhiteSpace(txt_Pswd1.Text))
                {
                    frm_Pswd1.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }

                txt_Pswd2.Focus();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void btn_LogIn_Clicked(object sender, EventArgs e)
        {
            try
            {


                Navigation.InsertPageBefore(new Page_Login_Dashboard(_iLanguageModel), iParent);

                await Navigation.PopToRootAsync();



                //await SRoofing_Page_OpenerManager.Page_Opener (
                //        Navigation ,
                //    new Page_Login_Dashboard ( _iLanguageModel ) ,
                //    false ,
                //    true );

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void txt_Pswd5_Completed(object sender, EventArgs e)
        {
            try
            {


                //  cnt_Login_View.Focus();

                #region HideKeyboard

                await Task.Delay(100);

                S1RoofingMU.Platforms.KeyboardHelper.HideKeyboard();

                await Task.Delay(100);

                #endregion

                if (!_bln_IsRegister_RunningNow)
                {


                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {
                        await onPostExecute_LoginAsync();
                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread(async () =>
                        {
                            // Code to run on the main thread
                            await iParent.Snack_ShowMessage(_iLanguageModel.lblText_Connection_CheckOnline_Message);
                            //iParent.Snack_ShowMessage ( SRoofingEnum_Toast_MessageManager.Message_Internet_Connection.PopupMessage_MessageConnectionFalse ( ) );

                        });
                    }

                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private void txt_Pswd5_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(txt_Pswd5.Text))
                {
                    frm_Pswd5.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }

                //  btn_LogIn_Clicked(sender,e);

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private void txt_Pswd2_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {

                if (!string.IsNullOrWhiteSpace(txt_Pswd2.Text))
                {
                    frm_Pswd2.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                txt_Pswd3.Focus();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }
        private void txt_Pswd3_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {

                if (!string.IsNullOrWhiteSpace(txt_Pswd3.Text))
                {
                    frm_Pswd3.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                txt_Pswd4.Focus();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }
        private void txt_Pswd4_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {

                if (!string.IsNullOrWhiteSpace(txt_Pswd4.Text))
                {
                    frm_Pswd4.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                }
                txt_Pswd5.Focus();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        private void txt_MobileNumber_Focussed(object sender, FocusEventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(txt_MobileNumber.Text))
                {
                    txt_MobileNumber.CursorPosition = 0;
                    txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;


                }

                //txt_MobileNumber.IsEnabled = true;
                //txt_MobileNumber.Focus();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        private void txt_MobileNumber_Completed(object sender, EventArgs e)
        {
            try
            {

                txt_FirstName.Focus();
                if (!string.IsNullOrWhiteSpace(txt_FirstName.Text))
                {
                    txt_FirstName.CursorPosition = 0;
                    txt_FirstName.SelectionLength = txt_FirstName.Text.Length;

                }



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        #endregion


        #region MobileNumber



        async Task<bool> Register_ValidateUserLoginMobileNumberOnBlur()
        {

            try
            {

                if (!string.IsNullOrWhiteSpace(txt_MobileNumber.Text))
                {

                    if (txt_MobileNumber.Text.Length > 0)
                    {

                        // get numE164 from edtNmuber , and check if valid
                        /*  UserLoginCountryCode = tvCountryCodeList.Text.ToString().toUpperCase();
                          UserLoginCountryMobileCode = TlknMobileNumberManager
                                  .MobileNumber_GetCountryMobileCodeFromCountryCode(

                                          getActivity(), UserLoginCountryCode);*/


                        if (txt_MobileNumber.Text
                                             .ToString()
                                             .Substring(0, 1) == ("+"))
                        {

                            _register_MobileNumberE164_Clean = txt_MobileNumber.Text.ToString().Substring(
                                    1,
                                    txt_MobileNumber.Text.ToString().Length - 1);
                        }
                        else
                        {
                            _register_MobileNumberE164_Clean = txt_MobileNumber.Text.ToString();
                        }

                        frm_MobileNumber.BorderColor = Colors.White;


                        UserLoginMobileNumberE164 = SRoofing_MobileNumberManager
                                .MobileNumber_ValidateMobileNumberE164FromMobileNumberRaw(
                                        App.Current,
                                        "+" + _register_MobileNumberE164_Clean);

                        _register_MobileNumberE164 = UserLoginMobileNumberE164;

                        SRoofing_DebugManager.Debug_ShowSystemMessage("_MobileNumberE164_New: " + UserLoginMobileNumberE164);

                        if ((UserLoginMobileNumberE164 == ("0"))
                             || (UserLoginMobileNumberE164 == ("false")))
                        {
                            // this invalid number , we do error message
                            ////lbl_ErrorMessage.Text = ("This\'s NOT a valid number!");
                            MainThread.BeginInvokeOnMainThread(async () =>
                            {
                                frm_MobileNumber.BorderColor = Colors.Red;
                                await iParent.Snack_ShowMessage(_iLanguageModel.lblText_NotValid_MobileNumber_Message);
                                return;
                            });
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
                        await iParent.Snack_ShowMessage(_iLanguageModel.lblText_Fill_MobileNumber_Message);
                        return false;
                        //lbl_ErrorMessage.Text = ("Fill in your mobile number!");
                    }
                }
                else
                {
                    frm_MobileNumber.BorderColor = Colors.Red;

                    await iParent.Snack_ShowMessage(_iLanguageModel.lblText_Fill_MobileNumber_Message);
                    return false;

                }



                return _blnMobileNumber;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;
            }
        }




        #endregion



        #region Register_Step1

        bool bln_IsFirstName = false, bln_IsLastName = false, bln_IsCountry = false;

        async Task<bool> Register_Step1()
        {

            try
            {

                /* First-Name */
                if (!string.IsNullOrWhiteSpace(txt_FirstName.Text))
                {
                    sl_FirstName.BackgroundColor = Colors.White;
                    _register_FirstName = txt_FirstName.Text.ToString();
                    bln_IsFirstName = true;
                }
                else
                {
                    frm_FirstName.BorderColor = Colors.Red;
                    //txt_FirstName.Focus();
                    //txt_FirstName.CursorPosition = 0;
                    //txt_FirstName.SelectionLength = txt_FirstName.Text.Length;
                    await iParent.Snack_ShowMessage(_iLanguageModel.lblText_Fill_FirstName_Message);
                    // return false;
                }

                /* Last-Name */
                if (!string.IsNullOrWhiteSpace(txt_LastName.Text))
                {
                    sl_LastName.BackgroundColor = Colors.White;
                    _register_LastName = txt_LastName.Text.ToString();
                    bln_IsLastName = true;
                }
                else
                {
                    frm_LastName.BorderColor = Colors.Red;
                    //txt_LastName.Focus();
                    //txt_LastName.CursorPosition = 0;
                    //txt_LastName.SelectionLength = txt_LastName.Text.Length;
                    await iParent.Snack_ShowMessage(_iLanguageModel.lblText_Fill_LastName_Message);
                    // return false;
                }

                if (bln_IsFirstName && bln_IsLastName)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;
            }
        }





        #endregion






        #region Initialize_LanguageModel


        SRoofingLanguageTranslateModel _iLanguageModel;

        public async Task Initialize_AppTranslation(SRoofingLanguageTranslateModel iLanguageModel)
        {
            try
            {

                if (iLanguageModel == null) iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);

                _iLanguageModel = iLanguageModel;

                lbl_CountryList.Text = _iLanguageModel.lblText_YourCountry;
                txt_MobileNumber.Placeholder = _iLanguageModel.lblText_MobileNumber;
                txt_FirstName.Placeholder = _iLanguageModel.lblText_FirstName;
                txt_LastName.Placeholder = _iLanguageModel.lblText_LastName;

                btn_Register_Step1.Text = _iLanguageModel.lblText_Command_Continue;
                //btn_LogIn.Text = _iLanguageModel.lblText_Splash_SignIn;
                ////btn_Login.Text = _iLanguageModel.lblText_Splash_SignIn;


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        #endregion











    }
}