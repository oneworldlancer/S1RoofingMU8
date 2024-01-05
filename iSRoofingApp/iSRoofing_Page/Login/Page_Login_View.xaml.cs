using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
//////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
////////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Register;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Splash;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

using System.Windows.Input;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Login;

////////[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Page_Login_View : ContentView
{


    #region Params

    //public Page_Login_Dashboard  iParent {get;set;}




    bool _blnIsInitialized = false;

    SRoofingUserOwnerModelManager iOwnerModel = null;

    string _iOwnerUserTokenID = "0", _iOwnerMobileNumberTokenID = "0";



    string _iRegisterInvitationTokenID = "0";


    string _iCleanMobileNumber = "0", UserLoginMobileNumberE164 = "0";
    bool _blnMobileNumber = false;



    #endregion



    public ICommand TogglePasswordCommand { get; set; }




    public Page_Login_View()
    {
        try
        {

            InitializeComponent();


            MainThread.BeginInvokeOnMainThread(async () =>
            {

                // IconTintColorEffect.SetTintColor ( img_Register , Colors.White );
                // IconTintColorEffect.SetTintColor ( img_Login , Colors.White );
            });

            //    Task.Run ( async ( ) =>
            //{
            //    await Initialize_AppTranslation ( );
            //} ).Wait ( );


            //IconTintColorEffect.SetTintColor ( img_Visible , Colors.Orange );


            //TogglePasswordCommand = new Command(() =>
            //          {
            //              MainThread.BeginInvokeOnMainThread(async () =>
            //              {
            //                  txt_Pswd1.IsPassword = false;// !txt_Pswd1.IsPassword;
            //              });
            //          });




            txt_MobileNumber.Unfocus();

            // BindingContext = this;
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }






    #region Property



    public static readonly BindableProperty iParentProperty = BindableProperty
        .Create("iParent", typeof(Page_Login_Dashboard),
        typeof(Page_Login_View), null);
    public Page_Login_Dashboard iParent
    {
        get { return (Page_Login_Dashboard)GetValue(iParentProperty); }
        set { SetValue(iParentProperty, value); }
    }



    #endregion











    async void btn_LogIn_Clicked(object sender, EventArgs e)
    {
        try
        {
            //  Task.Run(() => {
            //    // some long running task

            //});

            if (!_bln_IsLogin_RunningNow)
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
                                        await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Connection_CheckOnline_Message);

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

    async void btn_Register_New_Clicked(object sender, EventArgs e)
    {
        try
        {


            Navigation.InsertPageBefore(new Page_Register_Dashboard(_iLanguageModel), iParent);

            await Navigation.PopToRootAsync();



            //await SRoofing_Page_OpenerManager.Page_Reset_Stack (
            //                       Navigation ,
            //                   new Page_Register_Dashboard ( _iLanguageModel) );

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }




    #region LogIn

    bool _bln_IsLogin_RunningNow = false;

    string _login_MobileNumber = "0";
    string _login_Password = "0";
    bool _bln_MobileNumber = false;
    async Task onPostExecute_LoginAsync()
    {

        try
        {

            _bln_IsLogin_RunningNow = true;


            #region HideKeyboard

            await Task.Delay(100);

            S1RoofingMU.Platforms.KeyboardHelper.HideKeyboard();

            await Task.Delay(100);

            #endregion


            _bln_MobileNumber =await Login_ValidateUserLoginMobileNumberOnBlur();
            _login_Password =await Get_Password();


            if (_login_Password != "0" && _bln_MobileNumber == true)
            {

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    // Code to run on the main thread

                    ll_ProgressBar.IsVisible = true;

                });

                _iOwnerUserTokenID =
                    await SRoofing_UserMobileNumberManager
                                                     .UserMobileNumber_Get_OwnerUserTokenID_ByMobileNumberE164(
                                                             App.Current,
                                                             _iCleanMobileNumber);

                _iOwnerMobileNumberTokenID =
                  await SRoofing_UserMobileNumberManager
                                .UserMobileNumber_Get_OwnerMobileNumberTokenID_ByMobileNumberE164(
                                        App.Current,
                                        _iCleanMobileNumber);

                if (_iOwnerUserTokenID != "0" && _iOwnerMobileNumberTokenID != "0")
                {

                    // await Task.Delay(3000);



                    await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Wait_LoadProfile_Message);

                    // Get_Owner_Model
                    iOwnerModel = new SRoofingUserOwnerModelManager();
                    iOwnerModel = await SRoofing_UserProfileOwnerManager
                        .UserProfile_Get_Owner_Profile_ByAccountTypeWS(
                        App.Current,
                        _iOwnerUserTokenID,
                        _iOwnerMobileNumberTokenID);


                    // await Task.Delay(3000);



                    if (iOwnerModel != null)
                    {

                        // Get_Owner_Setting_Model

                        //  iParent.Snack_ShowMessage("Loading your settings!");

                        Task.Run(async () =>
                        {
                            await SRoofing_UserAccountManager.UserAccount_UserAccountLoginSystem(
                                    App.Current,

                                    _iOwnerUserTokenID,
                                    _iOwnerMobileNumberTokenID,
                                    _iCleanMobileNumber,
                                    SRoofingEnum_LoginStatus.LoginStatus_ONLINE,
                                    SRoofingEnum_VisibleStatus.VisibleStatus_ONLINE,
                                    "member");
                        }).Wait();

                        Preferences.Set("user_IsLogin", true);


                        MainThread.BeginInvokeOnMainThread(async () =>
                                                 {
                                                     // Code to run on the main thread
 


                                                     await iParent.Go_Page_LandingDashboard();


                                                 });


                        _bln_IsLogin_RunningNow = false;

                    }
                    else
                    {
                        // Toast
                        MainThread.BeginInvokeOnMainThread(async () =>
                        {

                            ll_ProgressBar.IsVisible = false;


                            await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Check_Data_Message);

                            _bln_IsLogin_RunningNow = false;

                        });
                    }

                }

                else
                {
                    // Toast
                    MainThread.BeginInvokeOnMainThread(async () =>
                    {

                        ll_ProgressBar.IsVisible = false;

                        await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Check_Data_Message);
                        // iParent.Snack_ShowMessage ( "Check your mobile number and pass code!" );

                        _bln_IsLogin_RunningNow = false;

                    });
                }

            }
            else
            {
                // Toast
                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    ll_ProgressBar.IsVisible = false;

                    await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Check_Data_Message);

                    _bln_IsLogin_RunningNow = false;

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


    #region Password

    string strPassword = "0";

    bool bln_txt_Pswd1, bln_txt_Pswd2, bln_txt_Pswd3, bln_txt_Pswd4, bln_txt_Pswd5;

    async Task<string> Get_Password()
    {

        try
        {

            // Retrieve the Primary color which is in the .NET MAUI default template
            // var hasValue = Resources.TryGetValue("iAppColor_SemiOrange", out object iAppColor_SemiOrange);

            //if (hasValue)
            //{
            //    myLabel.TextColor = (Color)primaryColor;
            //}


            if (!string.IsNullOrWhiteSpace(txt_Pswd1.Text))
            {
                bln_txt_Pswd1 = true;
                frm_Pswd1.BorderColor = Color.FromHex("#fc5d51");//Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
            }
            else
            {
                frm_Pswd1.BorderColor = Colors.Red;
            }

            if (!string.IsNullOrWhiteSpace(txt_Pswd2.Text))
            {
                bln_txt_Pswd2 = true;
                frm_Pswd2.BorderColor =  Color.FromHex("#fc5d51");
            }
            else
            {
                frm_Pswd2.BorderColor = Colors.Red;
            }

            if (!string.IsNullOrWhiteSpace(txt_Pswd3.Text))
            {
                bln_txt_Pswd3 = true;
                frm_Pswd3.BorderColor =  Color.FromHex("#fc5d51");
            }
            else
            {
                frm_Pswd3.BorderColor = Colors.Red;
            }

            if (!string.IsNullOrWhiteSpace(txt_Pswd4.Text))
            {
                bln_txt_Pswd4 = true;
                frm_Pswd4.BorderColor =  Color.FromHex("#fc5d51");
            }
            else
            {
                frm_Pswd4.BorderColor = Colors.Red;
            }

            if (!string.IsNullOrWhiteSpace(txt_Pswd5.Text))
            {
                bln_txt_Pswd5 = true;
                frm_Pswd5.BorderColor =  Color.FromHex("#fc5d51");
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
                await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Check_Data_Message);
                //  iParent.Snack_ShowMessage ( "Check your pass code!" );

                return "0";
            }

            return await Task.FromResult(strPassword);

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
                txt_Pswd1.BackgroundColor = Colors.Transparent;
            }
            txt_Pswd2.Focus();

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


            //   cnt_Login_View.Focus();


            await Task.Delay(100);

            if (!_bln_IsLogin_RunningNow)
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
                        await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Connection_CheckOnline_Message);
                        // iParent.Snack_ShowMessage ( SRoofingEnum_Toast_MessageManager.Message_Internet_Connection.PopupMessage_MessageConnectionFalse ( ) );

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
                txt_Pswd5.BackgroundColor = Colors.Transparent;
            }

            //  btn_LogIn_Clicked(sender,e);

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    private void Image_Focused(object sender, FocusEventArgs e)
    {

    }

    private void Image_Focused_1(object sender, FocusEventArgs e)
    {

    }

    private void txt_MobileNumber_TextChanged(object sender, TextChangedEventArgs e)
    {

        try
        {
            frm_MobileNumber.BackgroundColor = Colors.White;
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
                txt_Pswd2.BackgroundColor = Colors.Transparent;
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
                txt_Pswd3.BackgroundColor = Colors.Transparent;
            }
            txt_Pswd4.Focus();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    private void img_Toggle_Clicked(object sender, EventArgs e)
    {
        txt_Pswd1.IsPassword=false;// !txt_Pswd1.IsPassword;
    }

    private void txt_Pswd4_TextChanged(object sender, TextChangedEventArgs e)
    {

        try
        {

            if (!string.IsNullOrWhiteSpace(txt_Pswd4.Text))
            {
                txt_Pswd4.BackgroundColor = Colors.Transparent;
            }
            txt_Pswd5.Focus();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    private async void lbl_ForgotPassword_Tapped(object sender, TappedEventArgs e)
    {
        try
        {

              await iParent.Show_PasswordView();
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
            //if (!string.IsNullOrEmpty(txt_MobileNumber.Text))
            //{
            //    //txt_MobileNumber.CursorPosition = 0;
            //    txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;

            //}


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

    #endregion


    #region MobileNumber



    async Task<bool> Login_ValidateUserLoginMobileNumberOnBlur()
    {

        try
        {

            if (!string.IsNullOrWhiteSpace(txt_MobileNumber.Text))
            {

                if (txt_MobileNumber.Text.Length > 0)
                {

                    // get numE164 from edtNmuber , and check if valid

                    if (txt_MobileNumber.Text
                                         .ToString()
                                         .Substring(0, 1) == ("+"))
                    {
                        frm_MobileNumber.BorderColor =  Color.FromHex("#fc5d51");
                        _iCleanMobileNumber = txt_MobileNumber.Text.ToString().Substring(
                                1,
                                txt_MobileNumber.Text.ToString().Length - 1);
                    }
                    else
                    {
                        _iCleanMobileNumber = txt_MobileNumber.Text.ToString();
                    }


                    UserLoginMobileNumberE164 = SRoofing_MobileNumberManager
                            .MobileNumber_ValidateMobileNumberE164FromMobileNumberRaw(
                                    App.Current,
                                    "+" + _iCleanMobileNumber);


                    SRoofing_DebugManager.Debug_ShowSystemMessage("_MobileNumberE164_New: " + UserLoginMobileNumberE164);

                    if ((UserLoginMobileNumberE164 == ("0"))
                         || (UserLoginMobileNumberE164 == ("false")))
                    {
                        // this invalid number , we do error message
                        ////lbl_ErrorMessage.Text = ("This\'s NOT a valid number!");
                        MainThread.BeginInvokeOnMainThread(async () =>
                        {
                            frm_MobileNumber.BorderColor = Colors.Red;
                            await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_NotValid_MobileNumber_Message);
                            //iParent.Snack_ShowMessage ( "This\'s NOT a valid number!" );
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
                    await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Fill_MobileNumber_Message);
                    //  iParent.Snack_ShowMessage ( "Fill in your mobile number!" );
                    return false;
                    //lbl_ErrorMessage.Text = ("Fill in your mobile number!");
                }
            }
            else
            {

                frm_MobileNumber.BorderColor = Colors.Red;
                await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Fill_MobileNumber_Message);

                return false;

            }

            return await Task.FromResult(_blnMobileNumber);
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

            MainThread.BeginInvokeOnMainThread(() =>
               {
                   txt_MobileNumber.Placeholder =  _iLanguageModel.lblText_MobileNumber;
                   lbl_ForgotPassword.Text =  _iLanguageModel.lblText_ForgotPassword;

                   //btn_Register_New.Text =   _iLanguageModel.lblText_Splash_CreateAccount;
                   btn_LogIn.Text =   _iLanguageModel.lblText_Splash_SignIn;


               });
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }


    #endregion




    private void OnCounterClicked(object sender, EventArgs e)
    {
        //count++;

        //if (count == 1)
        //    CounterBtn.Text = $"Clicked {count} time";
        //else
        //    CounterBtn.Text = $"Clicked {count} times";

        //SemanticScreenReader.Announce(CounterBtn.Text);

        //txt_Password.IsPassword= !txt_Password.IsPassword;
    }






}
