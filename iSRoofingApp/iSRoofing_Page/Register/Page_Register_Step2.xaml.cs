using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Login;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Document;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;





namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Register
{
    //////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Register_Step2 : ContentView
    {




        #region Params

        //public Page_Login_Dashboard  iParent {get;set;}


        public bool _bln_IsRegister_RunningNow = false;

        bool _blnIsInitialized_Step2 = false;


        public string _register_BirthDay = "0", _register_BirthMonth = "0", _register_BirthYear = "0",
               _register_EmailAddress = "0", _register_Gender = "male";

        #endregion








        private void dt_BirthDate_DateSelected(object sender, DateChangedEventArgs e)
        {
            try
            {

                //string strDay, strMonth, strYear;
                _register_BirthDay = e.NewDate.Day.ToString();
                _register_BirthMonth = e.NewDate.Month.ToString();
                _register_BirthYear = e.NewDate.Year.ToString();

                lbl_BirthDate.Text = _register_BirthDay + "-" + _register_BirthMonth + "-" + _register_BirthYear;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        public Page_Register_Step2()
        {

            InitializeComponent();


            try
            {

                //Task.Run ( async ( ) =>
                //{
                //    await Initialize_AppTranslation ( );
                //} ).Wait ( );


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
            typeof(Page_Register_Step2), null);

        private void img_Male_Clicked(object sender, EventArgs e)
        {
            try
            {
                img_Male.WidthRequest = 60;
                img_Male.Source = "img_gender_male_select.png";

                img_Female.WidthRequest = 50;
                img_Female.Source = "img_gender_female_normal_small.png";

                _register_Gender = "male";

                _bln_IsGender = true;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private void img_Female_Clicked(object sender, EventArgs e)
        {
            try
            {
                img_Female.WidthRequest = 60;
                img_Female.Source = "img_gender_female_select.png";

                img_Male.WidthRequest = 50;
                img_Male.Source = "img_gender_male_normal_small.png";

                _register_Gender = "female";

                _bln_IsGender = true;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        public Page_Register_Dashboard iParent
        {
            get { return (Page_Register_Dashboard)GetValue(iParentProperty); }
            set { SetValue(iParentProperty, value); }
        }




        #endregion

        async void btn_Register_Step2_Clicked(object sender, EventArgs e)
        {
            try
            {

                if (chk_Agreement.IsChecked)
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
                else
                {
                    await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_AcceptAgreement_Message);
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        #region Register_Step2

        bool _bln_IsBirthDate = false, _bln_IsEmailAddress = false, _bln_IsGender = true;

        async void chk_Agreement_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

            await Task.Delay(500);

            if (chk_Agreement.IsChecked)
            {
                if (!_bln_IsRegister_RunningNow)
                {


                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {
                        await onPostExecute_LoginAsync();
                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread(action: async () =>
                        {
                            // Code to run on the main thread
                            await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Connection_CheckOnline_Message);

                        });
                    }


                }
            }
            else
            {
                await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_AcceptAgreement_Message);
            }

        }

        async Task<bool> Register_Step1()
        {

            try
            {

                /* BirthDate-Name */
                if (!string.IsNullOrWhiteSpace(lbl_BirthDate.Text))
                {
                    frm_BirthDate.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                    // _register_FirstName = txt_FirstName.Text.ToString();
                    _bln_IsBirthDate = true;
                }
                else
                {
                    frm_BirthDate.BorderColor = Colors.Red;
                    //txt_FirstName.Focus();
                    //txt_FirstName.CursorPosition = 0;
                    //txt_FirstName.SelectionLength = txt_FirstName.Text.Length;
                    await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Fill_BirthDate_Message);
                    // return false;
                }

                /* EmailAddress */
                if (!string.IsNullOrWhiteSpace(txt_EmailAddress.Text))
                {
                    frm_EmailAddress.BorderColor = Color.FromHex("#fc5d51"); //( Color ) Application.Current.Resources[ "iAppColor_SemiOrange" ];
                    _register_EmailAddress = txt_EmailAddress.Text.ToString();
                    _bln_IsEmailAddress = true;
                }
                else
                {
                    frm_EmailAddress.BorderColor = Colors.Red;
                    //txt_LastName.Focus();
                    //txt_LastName.CursorPosition = 0;
                    //txt_LastName.SelectionLength = txt_LastName.Text.Length;
                    await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Fill_EmailAddress_Message);
                    // return false;
                }

                if (_bln_IsBirthDate && _bln_IsEmailAddress)
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


        #region Avatar_Picker


        async void lbl_Avatar_Clicked(object sender, EventArgs e)
        {
            try
            {

                /* permissions_Read */
                ////////////////////var permissions_Read = await Permissions.CheckStatusAsync<Permissions.StorageRead>();
                ////////////////////if (permissions_Read != PermissionStatus.Granted)
                ////////////////////{
                ////////////////////    permissions_Read = await Permissions.RequestAsync<Permissions.StorageRead>();
                ////////////////////}
                ////////////////////if (permissions_Read != PermissionStatus.Granted)
                ////////////////////{
                ////////////////////    return;
                ////////////////////}

                /////////////////////* permissions_Write */
                ////////////////////var permissions_Write = await Permissions.CheckStatusAsync<Permissions.StorageWrite>();
                ////////////////////if (permissions_Write != PermissionStatus.Granted)
                ////////////////////{
                ////////////////////    permissions_Write = await Permissions.RequestAsync<Permissions.StorageWrite>();
                ////////////////////}
                ////////////////////if (permissions_Write != PermissionStatus.Granted)
                ////////////////////{
                ////////////////////    return;
                ////////////////////}


            
                /////////////////////* permissions_Write */
                ////////////////////var permissions_Camera = await Permissions.CheckStatusAsync<Permissions.Camera>();
                ////////////////////if (permissions_Camera != PermissionStatus.Granted)
                ////////////////////{
                ////////////////////    permissions_Camera = await Permissions.RequestAsync<Permissions.Camera>();
                ////////////////////}
                ////////////////////if (permissions_Camera != PermissionStatus.Granted)
                ////////////////////{
                ////////////////////    return;
                ////////////////////}


                await TakePhotoAsync();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        public FileResult register_fileResult = null;

        async Task TakePhotoAsync()
        {
            try
            {
              
                register_fileResult = await MediaPicker.Default.CapturePhotoAsync();
             
                await LoadPhotoAsync(register_fileResult);

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    // Code to run on the main thread
                    img_Avatar.Source = register_fileResult.FullPath;// ImageSource.FromStream ( ( ) => stream );
                    img_Camera.IsVisible = false;
                    frm_CameraImage.IsVisible = true;
                });

                SRoofing_DebugManager.Debug_ShowSystemMessage($"CapturePhotoAsync COMPLETED: {str_FilePath}");


            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature is not supported on the device
            }
            catch (PermissionException pEx)
            {
                // Permissions not granted
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage($"CapturePhotoAsync THREW: {ex.Message}");
            }
        }

        string str_FilePath;

        async Task LoadPhotoAsync(FileResult register_fileResult)
        {


            try
            {
                // canceled
                if (register_fileResult == null)
                {
                    str_FilePath = null;
                    return;
                }

                // save the file into local storage
                var newFile = Path.Combine(FileSystem.Current.CacheDirectory, register_fileResult.FileName);
                using (var stream = await register_fileResult.OpenReadAsync())
                {

                    //var stream = await fileResult.OpenReadAsync ( );



                    using (var newStream = File.OpenWrite(newFile))
                        await stream.CopyToAsync(newStream);


                }
             
                str_FilePath = newFile;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }



        #endregion



        #region Register-2



        string _login_MobileNumber = "0";
        bool _bln_MobileNumber = false;
        bool _bln_Register_Step1 = false;
        bool _bln_CountryName = false;
        async Task onPostExecute_LoginAsync()
        {

            try
            {

                _bln_IsRegister_RunningNow = true;

                _bln_Register_Step1 =await Register_Step1();


                // Code to run on the main thread

                if (_bln_Register_Step1 && _bln_IsGender)
                {
                    MainThread.BeginInvokeOnMainThread(() =>
                                 {
                                     ll_ProgressBar.IsVisible = true;
                                 });



                    await iParent.UserRegister_New_UserAccount();



                    //  await Task.Delay(500);




                    //////MainThread.BeginInvokeOnMainThread(async () =>
                    //////                  {
                    //////                      // Code to run on the main thread
                    //////                      _bln_IsRegister_RunningNow = false;
                    //////                      ll_ProgressBar.IsVisible = false;

                    //////                      await SRoofing_Page_OpenerManager.Page_Reset_Stack(
                    //////                                              Navigation,
                    //////                                          new Page_Login_Dashboard());


                    //////                  });
                }
                else
                {
                    _bln_IsRegister_RunningNow = false;

                    MainThread.BeginInvokeOnMainThread(action: async () =>
                {
                    // Code to run on the main thread
                    await iParent.Snack_ShowMessage(iParent._iLanguageModel.lblText_Fill_Data_Message);

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





        #region Initialize_LanguageModel


        public async Task Initialize_AppTranslation(SRoofingLanguageTranslateModel _iLanguageModel)
        {
            try
            {

                // if ( _iLanguageModel == null ) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All ( App.Current );

                lbl_Avatar.Text =  _iLanguageModel.lblText_TakePhoto
                    + " (" +  _iLanguageModel.lblText_Optional + ")";
                txt_EmailAddress.Placeholder =  _iLanguageModel.lblText_EmailAddress;

                //txt_FirstName.Placeholder =  _iLanguageModel.lblText_FirstName;
                //  txt_LastName.Placeholder =  _iLanguageModel.lblText_LastName;


                lbl_Agreement.Text =  _iLanguageModel.lblText_Agreement;
                lbl_Terms.Text =  _iLanguageModel.lblText_TermsCondition;
                lbl_AND.Text =  _iLanguageModel.lblText_AND;
                lbl_Privacy.Text =  _iLanguageModel.lblText_Privacy;

                btn_Register_Step2.Text =  _iLanguageModel.lblText_Command_Submit;

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