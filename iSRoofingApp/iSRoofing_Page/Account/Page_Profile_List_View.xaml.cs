using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
//using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Splash;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UploaderManager;

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Account;


//[XamlCompilation ( XamlCompilationOptions.Compile )]
public partial class Page_Profile_List_View : ContentView
{
    public Page_Profile_List_View()
    {
        InitializeComponent();

        BindingContext = this;


    }
    SRoofingUserOwnerModelManager _iOwnerModel;
    SRoofingSpeechModel _iSpeechModel_Incoming;
    SRoofingSpeechModel _iSpeechModel_Outgoing;
    public async Task Initialize(
        SRoofingUserOwnerModelManager iOwnerModel,
        iSRoofing_Model.Setting.SRoofingUserSettingModelManager _iSettingModel,
        iSRoofing_Model.Speech.SRoofingSpeechModel iSpeechModel_Incoming,
        iSRoofing_Model.Speech.SRoofingSpeechModel iSpeechModel_Outgoing)
    {


        //////////try
        //////////{
        //////////    _iOwnerModel = iOwnerModel;

        //////////    _iSpeechModel_Incoming =iSpeechModel_Incoming;
        //////////    _iSpeechModel_Outgoing = iSpeechModel_Outgoing;

        //////////    MainThread.BeginInvokeOnMainThread(async () =>
        //////////    {

        //////////        lbl_AvatarName.Text = iOwnerModel.AvatarName;

        //////////        if (_iOwnerModel.AvatarImageID!= "0")
        //////////        {

        //////////            img_Avatar.Source = ImageSource.FromUri(new Uri(_iOwnerModel.AvatarImageID));// ImageSource.FromStream ( ( ) => stream );
        //////////            frm_UserAvatarName.IsVisible = false;
        //////////            frm_CameraImage.IsVisible = true;
        //////////        }
        //////////        else
        //////////        {

        //////////            img_Avatar.Source = null;// ImageSource.FromStream ( ( ) => stream );
        //////////            frm_UserAvatarName.IsVisible =true;
        //////////            frm_CameraImage.IsVisible =  false;
        //////////        }


        //////////    });


        //////////    await((Page_Account_Dashboard)Parent.BindingContext).Hide_Loading();

        //////////}
        //////////catch (Exception ex)
        //////////{
        //////////    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //////////    return;
        //////////}

    }

    async void btn_LogOut_Clicked(object sender, EventArgs e)
    {

        try
        {

            //var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

            //if (objService != null)
            //{
            //    objService.KeyboardClick();
            //}


            await Task.Delay(50);



            Preferences.Set("user_IsLogin", false);

            //MainThread.BeginInvokeOnMainThread ( async ( ) =>
            //{
            //    // Code to run on the main thread
            //    ll_ProgressBar.IsVisible = true;


            //} );



            _=   Task.Run(async () =>
                 {
                     await SRoofing_UserAccountManager.UserAccount_UserAccountLogoutSystem(
                             App.Current,

                             _iOwnerModel.OwnerUserTokenID,
                             _iOwnerModel.OwnerMobileNumberTokenID,
                             _iOwnerModel.MobileNumberE164,
                             SRoofingEnum_LoginStatus.LoginStatus_OFFLINE,
                             SRoofingEnum_VisibleStatus.VisibleStatus_OFFLINE,
                             "member");
                 }).ConfigureAwait(false);


            //System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();

            Application.Current.Quit();

            //////MainThread.BeginInvokeOnMainThread ( async ( ) =>
            //////{
            //////    // Code to run on the main thread


            //////    ll_ProgressBar.IsVisible = false;

            //////    await SRoofing_Page_OpenerManager
            //////                              .Page_Reset_Stack (
            //////                              Navigation ,
            //////                              new Page_Splash_Dashboard ( ) );


            //////} );


            // lbl_Avatar.Text = iOwnerModel.AvatarName;
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    #region Navigation


    async void sl_PersonalInfo_Tapped(object sender, EventArgs e)
    {

        try
        {
            await ((Page_Account_Dashboard)Parent.BindingContext).PersonalInfo_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }


    async void sl_MobileNumber_Tapped(object sender, EventArgs e)
    {
        try
        {

            await ((Page_Account_Dashboard)Parent.BindingContext).MobileNumber_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async void sl_Password_Tapped(object sender, EventArgs e)
    {
        try
        {

            await ((Page_Account_Dashboard)Parent.BindingContext).Password_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async void sl_EmailAddress_Tapped(object sender, EventArgs e)
    {
        try
        {

            await ((Page_Account_Dashboard)Parent.BindingContext).EmailAddress_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async void sl_Privacy_Tapped(object sender, EventArgs e)
    {
        try
        {
            await ((Page_Account_Dashboard)Parent.BindingContext).Privacy_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async void sl_Speech_Tapped(object sender, EventArgs e)
    {
        try
        {
            await ((Page_Account_Dashboard)Parent.BindingContext).Speech_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async void sl_Sounds_Tapped(object sender, EventArgs e)
    {
        try
        {
            await ((Page_Account_Dashboard)Parent.BindingContext).Sounds_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async void sl_Chats_Tapped(object sender, EventArgs e)
    {
        try
        {
            await ((Page_Account_Dashboard)Parent.BindingContext).Chats_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async void sl_Calls_Tapped(object sender, EventArgs e)
    {
        try
        {
            await ((Page_Account_Dashboard)Parent.BindingContext).Calls_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async void sl_Notifications_Tapped(object sender, EventArgs e)
    {
        try
        {

            await ((Page_Account_Dashboard)Parent.BindingContext).Notifications_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async void sl_RateUs_Tapped(object sender, EventArgs e)
    {
        try
        {
            await ((Page_Account_Dashboard)Parent.BindingContext).RateUs_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }

    async void sl_ContactUs_Tapped(object sender, EventArgs e)
    {
        try
        {

            await ((Page_Account_Dashboard)Parent.BindingContext).ContactUs_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async void sl_About_Tapped(object sender, EventArgs e)
    {
        try
        {
            await ((Page_Account_Dashboard)Parent.BindingContext).About_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async void sl_FAQ_Tapped(object sender, EventArgs e)
    {
        try
        {
            await ((Page_Account_Dashboard)Parent.BindingContext).FAQ_Tapped();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }














    #endregion





    #region Avatar_Picker



    async void sl_Avatar_Tapped(object sender, EventArgs e)
    {

        try
        {

            ///////////* permissions_Read */
            //////////var permissions_Read = await Permissions.CheckStatusAsync<Permissions.StorageRead>();
            //////////if (permissions_Read != PermissionStatus.Granted)
            //////////{
            //////////    permissions_Read = await Permissions.RequestAsync<Permissions.StorageRead>();
            //////////}
            //////////if (permissions_Read != PermissionStatus.Granted)
            //////////{
            //////////    return;
            //////////}

            ///////////* permissions_Write */
            //////////var permissions_Write = await Permissions.CheckStatusAsync<Permissions.StorageWrite>();
            //////////if (permissions_Write != PermissionStatus.Granted)
            //////////{
            //////////    permissions_Write = await Permissions.RequestAsync<Permissions.StorageWrite>();
            //////////}
            //////////if (permissions_Write != PermissionStatus.Granted)
            //////////{
            //////////    return;
            //////////}



            ///////////* permissions_Write */
            //////////var permissions_Camera = await Permissions.CheckStatusAsync<Permissions.Camera>();
            //////////if (permissions_Camera != PermissionStatus.Granted)
            //////////{
            //////////    permissions_Camera = await Permissions.RequestAsync<Permissions.Camera>();
            //////////}
            //////////if (permissions_Camera != PermissionStatus.Granted)
            //////////{
            //////////    return;
            //////////}


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
        //////////try
        //////////{

        //////////    register_fileResult = await MediaPicker.Default.CapturePhotoAsync();

        //////////    await LoadPhotoAsync(register_fileResult);

        //////////    MainThread.BeginInvokeOnMainThread(() =>
        //////////    {
        //////////        // Code to run on the main thread
        //////////        img_Avatar.Source = register_fileResult.FullPath;// ImageSource.FromStream ( ( ) => stream );
        //////////        frm_UserAvatarName.IsVisible = false;
        //////////        frm_CameraImage.IsVisible = true;
        //////////    });


        //////////    /* Avatar */

        //////////    _ = Task.Run(async () =>
        //////////    {

        //////////        try
        //////////        {


        //////////            if (register_fileResult != null)
        //////////            {
        //////////                SRoofingUserMediaModel iUserMediaModel = new SRoofingUserMediaModel
        //////////                {
        //////////                    MediaFile_ServerID = SRoofing_TimeManager.Time_GenerateToken(),
        //////////                    fileResult = register_fileResult
        //////////                };

        //////////                await SRoofing_UploadMediaManager
        //////////                                   .Uploader_MediaFile_AvatarWS(
        //////////                App.Current,
        //////////                App.iAccountType,
        //////////                 ((Page_Account_Dashboard)Parent.BindingContext)._iOwnerModel.OwnerUserTokenID,
        //////////                ((Page_Account_Dashboard)Parent.BindingContext)._iOwnerModel.OwnerMobileNumberTokenID,
        //////////                null,
        //////////                iUserMediaModel);

        //////////                // Update iOwnerModel
        //////////                _iOwnerModel.AvatarImageID = SRoofing_URLManager.URL_Avatar.Avatar_Get_AvatarURLByImageID(
        //////////                  App.Current, iUserMediaModel.MediaFile_ServerID);

        //////////                await SRoofingSync_User_Owner_Manager.Sync_User_Owner_Update_UserModel(
        //////////                    App.Current, _iOwnerModel);
        //////////            }




        //////////        }
        //////////        catch (Exception ex)
        //////////        {
        //////////            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //////////            return;

        //////////        }

        //////////    }).ConfigureAwait(false);




        //////////    SRoofing_DebugManager.Debug_ShowSystemMessage($"CapturePhotoAsync COMPLETED: {str_FilePath}");


        //////////}
        //////////catch (FeatureNotSupportedException fnsEx)
        //////////{
        //////////    // Feature is not supported on the device
        //////////}
        //////////catch (PermissionException pEx)
        //////////{
        //////////    // Permissions not granted
        //////////}
        //////////catch (Exception ex)
        //////////{
        //////////    SRoofing_DebugManager.Debug_ShowSystemMessage($"CapturePhotoAsync THREW: {ex.Message}");
        //////////}
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




    #region Initialize_LanguageModel


    public async Task Initialize_AppTranslation(SRoofingLanguageTranslateModel _iLanguageModel)
    {
        try
        {

            if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);

            //if (_iLanguageModel.LanguageCode == "ar")
            //{
            //   // lbl_TitleAccount.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_TitleSetting.HorizontalTextAlignment = TextAlignment.Start;

            //    //lbl_About.HorizontalTextAlignment = TextAlignment.Start;
            //    lbl_Avatar.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_Calls.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_Chats.HorizontalTextAlignment = TextAlignment.Start;
            //    lbl_EmailAddress.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_FAQ.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_Notifictions.HorizontalTextAlignment = TextAlignment.Start;
            //    lbl_PersonalInfo.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_Privacy.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_RateUs.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_Sounds.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_TheWorld.HorizontalTextAlignment = TextAlignment.Start;

            //    lbl_MobileNumber.HorizontalTextAlignment = TextAlignment.Start;
            //    lbl_Password.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_ContactUs.HorizontalTextAlignment = TextAlignment.Start;

            //}
            //else
            //{

            //  //  lbl_TitleAccount.HorizontalTextAlignment = TextAlignment.Start;

            //    //lbl_TitleSetting.HorizontalTextAlignment = TextAlignment.Start;

            //    ////lbl_About.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_Avatar.HorizontalTextAlignment = TextAlignment.Start;
            //    ////lbl_Calls.HorizontalTextAlignment = TextAlignment.Start;
            //    ////lbl_Chats.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_EmailAddress.HorizontalTextAlignment = TextAlignment.Start;
            //    ////lbl_FAQ.HorizontalTextAlignment = TextAlignment.Start;
            //    ////lbl_Notifictions.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_PersonalInfo.HorizontalTextAlignment = TextAlignment.Start;
            //    ////lbl_Privacy.HorizontalTextAlignment = TextAlignment.Start;
            //    ////lbl_RateUs.HorizontalTextAlignment = TextAlignment.Start;
            //    ////lbl_Sounds.HorizontalTextAlignment = TextAlignment.Start;
            //    ////lbl_TheWorld.HorizontalTextAlignment = TextAlignment.Start;



            //    //lbl_MobileNumber.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_Password.HorizontalTextAlignment = TextAlignment.Start;
            //    //lbl_ContactUs.HorizontalTextAlignment = TextAlignment.Start;






            //}





            // lbl_TitleAccount.Text = _iLanguageModel.lblText_Title_Account;
            //lbl_TitleSetting.Text = _iLanguageModel.lblText_Title_Settings;

            //lbl_About.Text = "S1Roofing " + _iLanguageModel.lblText_About;
            //lbl_Avatar.Text = _iLanguageModel.lblText_Avatar;
            ////lbl_Calls.Text = "S1Roofing " + _iLanguageModel.lblText_Tab_Calls;
            ////lbl_Chats.Text = "S1Roofing " + _iLanguageModel.lblText_Tab_Chats;
            //lbl_EmailAddress.Text = _iLanguageModel.lblText_EmailAddress;
            ////lbl_FAQ.Text = "S1Roofing " + _iLanguageModel.lblText_FAQ;
            ////lbl_Notifictions.Text = _iLanguageModel.lblText_Notifications;
            //lbl_PersonalInfo.Text = _iLanguageModel.lblText_PersonalInfo;
            ////lbl_Privacy.Text = _iLanguageModel.lblText_Privacy;
            ////lbl_RateUs.Text = _iLanguageModel.lblText_RateUs;
            ////lbl_Sounds.Text = "S1Roofing " + _iLanguageModel.lblText_Sounds;
            ////lbl_TheWorld.Text = "S1Roofing " + _iLanguageModel.lblText_TheWorld;

            //lbl_MobileNumber.Text = _iLanguageModel.lblText_MobileNumber;
            //lbl_Password.Text = _iLanguageModel.lblText_Password;
            //lbl_ContactUs.Text = _iLanguageModel.lblText_ContactUs;

            btn_LogOut.Text = _iLanguageModel.lblText_LogOut_Message;


            //lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;
            //lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;
            //lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;
            //lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;
            //lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;
            //lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;
            //lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;
            //lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;
            //lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;
            //lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;
            //lbl_Title.Text = _iLanguageModel.lblText_Title_SignIn;
            //////btn_Register.Text = _iLanguageModel.lblText_Splash_CreateAccount;
            //////btn_Login.Text = _iLanguageModel.lblText_Splash_SignIn;

            //await vw_LogIn_View.Initialize_AppTranslation ( _iLanguageModel );

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }







    #endregion

    private async void page_ProfileView_Loaded(object sender, EventArgs e)
    {
        try
        {

            await Initialize_AppTranslation(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel);

            MainThread.BeginInvokeOnMainThread(async () =>
             {
                 // Code to run on the main thread



                 lbl_AvatarName_Splash.Text=((Page_Account_Dashboard)Parent.BindingContext)._iOwnerModel.AvatarName;
                 lbl_UserName.Text=((Page_Account_Dashboard)Parent.BindingContext)._iOwnerModel.FullName;
                 lbl_MobileNumber.Text=((Page_Account_Dashboard)Parent.BindingContext)._iOwnerModel.MobileNumberE164;
                 lbl_EmailAddress.Text=((Page_Account_Dashboard)Parent.BindingContext)._iOwnerModel.EmailAddress;
             });



        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    bool _bln_IsInitialized;

    private void page_ProfileView_SizeChanged(object sender, EventArgs e)
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
                        {


                            // Code to run on the main thread
                            if (!_bln_IsInitialized)
                            {

                                var intWidth = (int)page_ProfileView.Width;
                                //SRoofing_DebugManager.Debug_ShowSystemMessage("page_CallDashboard Width== " + page_CallDashboard.Width.ToString());
                                //SRoofing_DebugManager.Debug_ShowSystemMessage("page_CallDashboard WidthRequest== " + page_CallDashboard.WidthRequest.ToString());

                                grd_AvatarName_Splash.WidthRequest = intWidth / 3;
                                grd_AvatarName_Splash.HeightRequest = intWidth / 3;

                                //grd_AvatarName_Drop.WidthRequest = intWidth / 3;
                                //grd_AvatarName_Drop.HeightRequest = intWidth / 3;


                                //grd_AvatarName_Redial.WidthRequest = intWidth / 3;
                                //grd_AvatarName_Redial.HeightRequest = intWidth / 3;


                                //grd_AvatarName_Ring.WidthRequest = intWidth / 3;
                                //grd_AvatarName_Ring.HeightRequest = intWidth / 3;


                                //grd_AvatarName_ActionVoice.WidthRequest = intWidth / 3;
                                //grd_AvatarName_ActionVoice.HeightRequest = intWidth / 3;


                                ////grd_AvatarName_Drop.WidthRequest =intWidth / 2;
                                ////grd_AvatarName_Drop.HeightRequest = intWidth / 2;


                                //frm_AvatarName_Splash.CornerRadius = intWidth / 6;

                                _bln_IsInitialized = true;

                            }


                        });

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }


}
