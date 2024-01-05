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
public partial class Page_Password_View : ContentView
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




    public Page_Password_View()
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
        typeof(Page_Password_View), null);
    public Page_Login_Dashboard iParent
    {
        get { return (Page_Login_Dashboard)GetValue(iParentProperty); }
        set { SetValue(iParentProperty, value); }
    }



    #endregion











    async void btn_GetPassword_Clicked(object sender, EventArgs e)
    {
        try
        {
           
            
            //  Task.Run(() => {
            //    // some long running task

            //});

            ////////////////////if (!_bln_IsLogin_RunningNow)
            ////////////////////{
            ////////////////////    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            ////////////////////    {
            ////////////////////        await onPostExecute_LoginAsync();
            ////////////////////    }
            ////////////////////    else
            ////////////////////    {
            ////////////////////        MainThread.BeginInvokeOnMainThread(async () =>
            ////////////////////                        {
            ////////////////////                            // Code to run on the main thread
            ////////////////////                            await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Connection_CheckOnline_Message);

            ////////////////////                        });
            ////////////////////    }


            ////////////////////}

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

            await Task.Delay(100);

            S1RoofingMU.Platforms.KeyboardHelper.HideKeyboard();

            await Task.Delay(100);

            _bln_MobileNumber =await Login_ValidateUserLoginMobileNumberOnBlur();
          //  _login_Password =await Get_Password();


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

                                                     //ll_ProgressBar.IsVisible = false;


                                                     //      Navigation.InsertPageBefore(new Page_Landing_Dashboard(_iLanguageModel), iParent);
                                                     //await   Navigation.PushAsync(new Page_Landing_Dashboard(_iLanguageModel));

                                                     //   await Navigation.PopToRootAsync();

                                                     //await   SRoofing_Page_OpenerManager.Page_Reset_Stack(
                                                     //       Navigation,
                                                     //       new Page_Landing_Dashboard(_iLanguageModel));


                                                     //Microsoft.Maui.Controls.Application.Current.MainPage = new NavigationPage ( new Page_Landing_Dashboard ( _iLanguageModel ) );

                                                     //await Navigation.PopToRootAsync ( );


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
                   txt_EmailAddress.Placeholder =  _iLanguageModel.lblText_EmailAddress;
                   //lbl.Text =  _iLanguageModel.lblText_ForgotPassword;

                   //btn_Register_New.Text =   _iLanguageModel.lblText_Splash_CreateAccount;
                   btn_GetPassword.Text =   _iLanguageModel.lblText_Command_Submit;
                   //btn_GetPassword.Text =   _iLanguageModel.lblText_Command_Submit;


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
