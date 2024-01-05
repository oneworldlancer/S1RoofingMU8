//using Plugin.SimpleAudioPlayer;

//// 
//// 

using Plugin.Maui.Audio;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
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
    ////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Account_Sound : ContentView
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






        readonly IAudioManager audioManager;

        public IAudioPlayer player;





        bool _blnIsInitializedd_Popup_IsOpen;



        public Page_Account_Sound()
        {
            InitializeComponent();

            try
            {

                //////////////////////if ( player == null )
                //////////////////////{
                //////////////////////    player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

                //////////////////////}




                MessagingCenter.Subscribe<App, SRoofingKeyValueModelManager>
                    (App.Current,
                    SRoofingEnum_MessageCenter.MessageCenter_SETTING_SOUND_CHAT_INCOMING,
                    async (snd, arg) =>
                {

                    try
                    {
                        //get the value by `arg`

                        if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                        {


                            _blnIsInitializedd_Popup_IsOpen = false;

                            SRoofingKeyValueModelManager _iKeyValueSpeechModel_Incoming = (arg as SRoofingKeyValueModelManager);
                            _iKeyValue_Chat_Incoming = _iKeyValueSpeechModel_Incoming;


                            lbl_Chat_Incoming.Text = "<" + (arg as SRoofingKeyValueModelManager).ItemText.ToString() + ">";


                            _iSettingModel.Sound_Chat_Incoming = (arg as SRoofingKeyValueModelManager).ItemValue;
                            //_iOwnerModel.CountryName = _register_CountryName;
                            //_iOwnerModel.MobileNumberE164 = _register_MobileNumberE164;

                            ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;


                            await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                                                          App.Current, _iOwnerModel, _iSettingModel);


                            await SRoofingSync_Sound_Manager.Sync_Sound_Set_Chat_Incoming_ByUserID(App.Current, _iOwnerModel, _iKeyValueSpeechModel_Incoming);




                            _ = Task.Run(async () =>
                            {
                                await SRoofing_UserSettingManager.UserSetting_Update_Sound_Chat_Incoming_ByOwnerUserTokenID(
                                    App.Current,
                 App.iAccountType,
                 _iOwnerModel,
                  (arg as SRoofingKeyValueModelManager).ItemText,
                  (arg as SRoofingKeyValueModelManager).ItemValue);
                            }).ConfigureAwait(false);

                        }
                        else
                        {
                            MainThread.BeginInvokeOnMainThread(() =>
                            {
                                // Code to run on the main thread
                                ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);

                            });
                        }


                    }
                    catch (Exception ex)
                    {
                        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    }

                });



                MessagingCenter.Subscribe<App, SRoofingKeyValueModelManager>(
                    App.Current, SRoofingEnum_MessageCenter.MessageCenter_SETTING_SOUND_CHAT_OUTGOING,
                    async (snd, arg) =>
                {

                    try
                    {
                        //get the value by `arg`

                        if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                        {


                            _blnIsInitializedd_Popup_IsOpen = false;

                            SRoofingKeyValueModelManager _iKeyValueSpeechModel_Incoming = (arg as SRoofingKeyValueModelManager);
                            _iKeyValue_Chat_Outgoing = _iKeyValueSpeechModel_Incoming;

                            lbl_Chat_Outgoing.Text = "<" + (arg as SRoofingKeyValueModelManager).ItemText.ToString() + ">";


                            _iSettingModel.Sound_Chat_Outgoing = (arg as SRoofingKeyValueModelManager).ItemValue;
                            //_iOwnerModel.CountryName = _register_CountryName;
                            //_iOwnerModel.MobileNumberE164 = _register_MobileNumberE164;

                            ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;


                            await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                                App.Current, _iOwnerModel, _iSettingModel);



                            await SRoofingSync_Sound_Manager.Sync_Sound_Set_Chat_Outgoing_ByUserID(App.Current, _iOwnerModel, _iKeyValueSpeechModel_Incoming);


                            _ = Task.Run(async () =>
                            {
                                await SRoofing_UserSettingManager.UserSetting_Update_Sound_Chat_Outgoing_ByOwnerUserTokenID(
                                    App.Current,
                 App.iAccountType,
                 _iOwnerModel,
                 (arg as SRoofingKeyValueModelManager).ItemText,
                    (arg as SRoofingKeyValueModelManager).ItemValue);
                            }).ConfigureAwait(false);

                        }
                        else
                        {
                            MainThread.BeginInvokeOnMainThread(() =>
                            {
                                // Code to run on the main thread
                                ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);

                            });
                        }


                    }
                    catch (Exception ex)
                    {
                        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    }

                });



                MessagingCenter.Subscribe<App, SRoofingKeyValueModelManager>(
                    App.Current, SRoofingEnum_MessageCenter.MessageCenter_SETTING_SOUND_CALL_INCOMING,
                    async (snd, arg) =>
                {

                    try
                    {
                        //get the value by `arg`

                        if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                        {


                            _blnIsInitializedd_Popup_IsOpen = false;

                            SRoofingKeyValueModelManager _iKeyValueSpeechModel_Incoming = (arg as SRoofingKeyValueModelManager);
                            _iKeyValue_Call_Incoming = _iKeyValueSpeechModel_Incoming;

                            lbl_Call_Incoming.Text = "<" + (arg as SRoofingKeyValueModelManager).ItemText.ToString() + ">";


                            _iSettingModel.Sound_Call_Incoming = (arg as SRoofingKeyValueModelManager).ItemValue;
                            //_iOwnerModel.CountryName = _register_CountryName;
                            //_iOwnerModel.MobileNumberE164 = _register_MobileNumberE164;

                            ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;


                            await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                                App.Current, _iOwnerModel, _iSettingModel);


                            await SRoofingSync_Sound_Manager.Sync_Sound_Set_Call_Incoming_ByUserID(App.Current, _iOwnerModel, _iKeyValueSpeechModel_Incoming);


                            _ = Task.Run(async () =>
                            {
                                await SRoofing_UserSettingManager.UserSetting_Update_Sound_Call_Incoming_ByOwnerUserTokenID(
                                    App.Current,
                 App.iAccountType,
                 _iOwnerModel,
                 (arg as SRoofingKeyValueModelManager).ItemText,
                    (arg as SRoofingKeyValueModelManager).ItemValue);
                            }).ConfigureAwait(false);

                        }
                        else
                        {
                            MainThread.BeginInvokeOnMainThread(() =>
                            {
                                // Code to run on the main thread
                                ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);

                            });
                        }


                    }
                    catch (Exception ex)
                    {
                        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    }

                });



                MessagingCenter.Subscribe<App, SRoofingKeyValueModelManager>(
                    App.Current, SRoofingEnum_MessageCenter.MessageCenter_SETTING_SOUND_CALL_OUTGOING,
                    async (snd, arg) =>
                {

                    try
                    {
                        //get the value by `arg`

                        if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                        {


                            _blnIsInitializedd_Popup_IsOpen = false;

                            SRoofingKeyValueModelManager _iKeyValueSpeechModel_Incoming = (arg as SRoofingKeyValueModelManager);
                            _iKeyValue_Call_Outgoing = _iKeyValueSpeechModel_Incoming;

                            lbl_Call_Outgoing.Text = "<" + (arg as SRoofingKeyValueModelManager).ItemText.ToString() + ">";


                            _iSettingModel.Sound_Call_Outgoing = (arg as SRoofingKeyValueModelManager).ItemValue;
                            //_iOwnerModel.CountryName = _register_CountryName;
                            //_iOwnerModel.MobileNumberE164 = _register_MobileNumberE164;

                            ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;


                            await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                                App.Current, _iOwnerModel, _iSettingModel);


                            await SRoofingSync_Sound_Manager.Sync_Sound_Set_Call_Outgoing_ByUserID(App.Current, _iOwnerModel, _iKeyValueSpeechModel_Incoming);


                            _ = Task.Run(async () =>
                            {
                                await SRoofing_UserSettingManager.UserSetting_Update_Sound_Call_Outgoing_ByOwnerUserTokenID(
                                    App.Current,
                 App.iAccountType,
                 _iOwnerModel,
                  (arg as SRoofingKeyValueModelManager).ItemText,
                   (arg as SRoofingKeyValueModelManager).ItemValue);
                            }).ConfigureAwait(false);

                        }
                        else
                        {
                            MainThread.BeginInvokeOnMainThread(() =>
                            {
                                // Code to run on the main thread
                                ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);

                            });
                        }


                    }
                    catch (Exception ex)
                    {
                        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    }

                });



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }



        SRoofingKeyValueModelManager _iKeyValue_Chat_Incoming;
        SRoofingKeyValueModelManager _iKeyValue_Chat_Outgoing;
        SRoofingKeyValueModelManager _iKeyValue_Call_Incoming;
        SRoofingKeyValueModelManager _iKeyValue_Call_Outgoing;


        bool _blnIsInitialized = false;


        SRoofingApplicationUtilityModelManager _iApplicationUtilityModel;

        SRoofingUserOwnerModelManager _iOwnerModel;
        SRoofingUserSettingModelManager _iSettingModel;
        #region Initialize

        public async Task Initialize(
                SRoofingApplicationUtilityModelManager iApplicationUtilityModel,
         SRoofingUserOwnerModelManager iOwnerModel,
            SRoofingUserSettingModelManager iSettingModel)
        {

            try
            {

                _iApplicationUtilityModel=iApplicationUtilityModel;
                _iOwnerModel = iOwnerModel;
                _iSettingModel = iSettingModel;

                swtch_SoundIsEnable.OnColor = Colors.Orange;
                swtch_SoundIsEnable.ThumbColor = Colors.Gray;



                _iKeyValue_Chat_Incoming = await SRoofingSync_Sound_Manager.Sync_Sound_Get_Chat_Incoming_ByUserID(App.Current, _iOwnerModel);


                _iKeyValue_Chat_Outgoing = await SRoofingSync_Sound_Manager.Sync_Sound_Get_Chat_Outgoing_ByUserID(App.Current, _iOwnerModel);

                _iKeyValue_Call_Incoming = await SRoofingSync_Sound_Manager.Sync_Sound_Get_Call_Incoming_ByUserID(App.Current, _iOwnerModel);

                _iKeyValue_Call_Outgoing = await SRoofingSync_Sound_Manager.Sync_Sound_Get_Call_Outgoing_ByUserID(App.Current, _iOwnerModel);




                lbl_Chat_Incoming.Text = "<" + _iKeyValue_Chat_Incoming.ItemText + ">";
                lbl_Chat_Outgoing.Text = "<" + _iKeyValue_Chat_Outgoing.ItemText + ">";

                lbl_Call_Incoming.Text = "<" + _iKeyValue_Call_Incoming.ItemText + ">";
                lbl_Call_Outgoing.Text = "<" + _iKeyValue_Call_Outgoing.ItemText + ">";












                if (_iSettingModel.VisibleStatus_IsEnable)
                {
                    swtch_SoundIsEnable.IsToggled = true;
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
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }

        #endregion


        #region Switch_Toggle


        async void swtch_SoundIsEnable_Toggled(object sender, ToggledEventArgs e)
        {
            try
            {
                if (_blnIsInitialized)
                {

                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {
                        _iSettingModel.Sound_IsEnable = e.Value;
                        //_iOwnerModel.CountryName = _register_CountryName;
                        //_iOwnerModel.MobileNumberE164 = _register_MobileNumberE164;

                        ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;


                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                            App.Current, _iOwnerModel, _iSettingModel);

                        Task.Run(async () =>
                      {
                          await SRoofing_UserSettingManager.UserSetting_Update_Sound_IsEnable_ByOwnerUserTokenID(
                              App.Current,
           App.iAccountType,
           _iOwnerModel,
           e.Value);
                      }).ConfigureAwait(false);

                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread(() =>
                        {
                            // Code to run on the main thread
                            ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);

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



        #endregion





        #region Sound_Speaker

        ////////////////////public ISimpleAudioPlayer player;


        async void img_Call_Outgoing_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Player_Stop();

                await _Play_Sound_Message(_iSettingModel.Sound_Call_Outgoing);


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void img_Call_Incoming_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Player_Stop();

                await _Play_Sound_Message(_iSettingModel.Sound_Call_Incoming);


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void img_Chat_Outgoing_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Player_Stop();

                await _Play_Sound_Message(_iSettingModel.Sound_Chat_Outgoing);


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void img_Chat_Incoming_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Player_Stop();


                await _Play_Sound_Message(_iSettingModel.Sound_Chat_Incoming);


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        async Task _Play_Sound_Message(string sndFile)
        {

            try
            {

                await Task.Delay(500);

                //if (player == null)
                // player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                //  player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("snd_connecting.mp3"));
                player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(sndFile));
                //else { }


                if (player.IsPlaying)
                    player.Stop();

                // player.Load("snd_connecting.mp3");
                await Task.Delay(500);

                player.Loop = false;
                player.Play();



                ////////////////////if ( player == null )
                ////////////////////    player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

                ////////////////////if ( player.IsPlaying )
                ////////////////////    player.Stop ( );

                //////////////////////   player.Load ( "snd_chat_out_1.mp3" );
                ////////////////////player.Load ( sndFile );
                ////////////////////await Task.Delay ( 500 );
                ////////////////////Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current.Loop = false;
                ////////////////////Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current.Play ( );



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        #endregion









        #region Register-1



        string _login_MobileNumber = "0";

        async void frm_Call_Out_Clicked(object sender, EventArgs e)
        {
            try
            {



                ////////////////////if ( PopupNavigation.Instance.PopupStack.Count > 0 )
                ////////////////////{
                ////////////////////    await Navigation.PopAllPopupAsync ( );
                ////////////////////}


                await MauiPopup.PopupAction.DisplayPopup(
                  new iSRoofing_Popup.Popup_List_PickUp_Generic(_iApplicationUtilityModel,
                     _iOwnerModel, SRoofingEnum_PopupByCodeManager.PopupByCode_SOUND_CALL_OUT));

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void frm_Call_In_Clicked(object sender, EventArgs e)
        {
            try
            {


                ////////////////////if ( PopupNavigation.Instance.PopupStack.Count > 0 )
                ////////////////////{
                ////////////////////    await Navigation.PopAllPopupAsync ( );
                ////////////////////}


                await MauiPopup.PopupAction.DisplayPopup(
                  new iSRoofing_Popup.Popup_List_PickUp_Generic(_iApplicationUtilityModel,
                     _iOwnerModel, SRoofingEnum_PopupByCodeManager.PopupByCode_SOUND_CALL_IN));

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void frm_Chat_Out_Clicked(object sender, EventArgs e)
        {
            try
            {


                ////////////////////if ( PopupNavigation.Instance.PopupStack.Count > 0 )
                ////////////////////{
                ////////////////////    await Navigation.PopAllPopupAsync ( );
                ////////////////////}


                await MauiPopup.PopupAction.DisplayPopup(
                  new iSRoofing_Popup.Popup_List_PickUp_Generic(_iApplicationUtilityModel,
                     _iOwnerModel, SRoofingEnum_PopupByCodeManager.PopupByCode_SOUND_CHAT_OUT));

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void frm_Chat_In_Clicked(object sender, EventArgs e)
        {
            try
            {


                ////////////////////if ( PopupNavigation.Instance.PopupStack.Count > 0 )
                ////////////////////{
                ////////////////////    await Navigation.PopAllPopupAsync ( );
                ////////////////////}


                await MauiPopup.PopupAction.DisplayPopup(
                  new iSRoofing_Popup.Popup_List_PickUp_Generic(_iApplicationUtilityModel,
                     _iOwnerModel, SRoofingEnum_PopupByCodeManager.PopupByCode_SOUND_CHAT_IN));

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }




        bool _bln_MobileNumber = false;
        bool _bln_Register_Step1 = false;
        bool _bln_IsCountryName = false;
 
        
        async Task onPostExecute_LoginAsync()
        {

            try
            {

                _bln_IsRegister_RunningNow = true;

                //////_bln_MobileNumber = Register_ValidateUserLoginMobileNumberOnBlur ( );
                //////_register_Password = Get_Password ( );
                //////_bln_Register_Step1 = Register_Step1 ( );

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    // Code to run on the main thread

                    //    (( Page_Account_Dashboard ) Parent.BindingContext).Lose_Focus();

                    if (!_bln_IsCountryName)
                    {
                        // frm_CountryName.BorderColor = Colors.Red;

                        _bln_IsRegister_RunningNow = false;
                        return;
                    }

                    if (_register_Password != "0" && _bln_MobileNumber == true && _bln_IsCountryName && _bln_Register_Step1)
                    {

                        //  ll_ProgressBar.IsVisible = true;
                        ////////////////////  (( Page_Account_Dashboard ) Parent.BindingContext).Register_Show_Step2 ( true );

                    }
                    else
                    {
                        _bln_IsRegister_RunningNow = false;

                        MainThread.BeginInvokeOnMainThread(async () =>
                        {
                            // Code to run on the main thread
                            await ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage("Fill in your data!");

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
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }




        #endregion











        #region Register_Step1

        bool bln_IsFirstName = false, bln_IsLastName = false, bln_IsCountry = false;

        bool Register_Step1()
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


        public async Task Initialize_AppTranslation(SRoofingLanguageTranslateModel _iLanguageModel)
        {
            try
            {

                if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);


                //////if ( _iLanguageModel.LanguageCode == "ar" )
                //////{
                //////    lbl_Title.HorizontalTextAlignment = TextAlignment.End;
                //////    lbl_Title_Sound_Chat.HorizontalTextAlignment = TextAlignment.End;
                //////    lbl_Title_Sound_Call.HorizontalTextAlignment = TextAlignment.End;

                //////}
                //////else
                //////{
                //////    lbl_Title.HorizontalTextAlignment = TextAlignment.Start;
                //////    lbl_Title_Sound_Chat.HorizontalTextAlignment = TextAlignment.Start;
                //////    lbl_Title_Sound_Call.HorizontalTextAlignment = TextAlignment.Start;

                //////}

                //lbl_Sound.HorizontalTextAlignment = TextAlignment.Start;



                lbl_Title.Text = "S1Roofing " + _iLanguageModel.lblText_Sounds;
                lbl_Title_Sound_Chat.Text = _iLanguageModel.lblText_Sound_Chat;
                lbl_Title_Sound_Call.Text = _iLanguageModel.lblText_Sound_Call;



                lbl_Sound.Text = _iLanguageModel.lblText_Setting_Sound_IsEnable_Message;

                lbl_Sound_Chat_Incoming.Text = _iLanguageModel.lblText_Setting_Sound_Chat_Incoming_Message;
                lbl_Sound_Chat_Outgoing.Text = _iLanguageModel.lblText_Setting_Sound_Chat_Outgoing_Message;

                lbl_Sound_Call_Incoming.Text = _iLanguageModel.lblText_Setting_Sound_Call_Incoming_Message;
                lbl_Sound_Call_Outgoing.Text = _iLanguageModel.lblText_Setting_Sound_Call_Outgoing_Message;

                //lbl_CountryList.Text = _iLanguageModel.lblText_YourCountry;
                //txt_MobileNumber.Placeholder = _iLanguageModel.lblText_MobileNumber;
                //txt_FirstName.Placeholder = _iLanguageModel.lblText_FirstName;
                //txt_LastName.Placeholder = _iLanguageModel.lblText_LastName;

                btn_Submit.Text = _iLanguageModel.lblText_Command_Submit;
                ////btn_Login.Text = _iLanguageModel.lblText_Splash_SignIn;


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        #endregion




        async void btn_Submit_Clicked(object sender, EventArgs e)
        {

            try
            {

                await Player_Stop();


                await ((Page_Account_Dashboard)Parent.BindingContext).CloseDrawer();


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        public Task Player_Stop()
        {

            try
            {

                ////////////////////if ( player != null )
                ////////////////////{
                ////////////////////    if ( player.IsPlaying )
                ////////////////////        player.Stop ( );
                ////////////////////    player = null;
                ////////////////////}



                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }





        #region frm_Toggle


        private void frm_Sound_Tapped(object sender, EventArgs e)
        {
            try
            {

                if (_blnIsInitialized)
                {

                    if (swtch_SoundIsEnable.IsToggled)
                    {
                        swtch_SoundIsEnable.IsToggled = false;
                    }
                    else
                    {
                        swtch_SoundIsEnable.IsToggled = true;
                    }

                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        #endregion



        private void page_SettingSound_Unloaded(object sender, EventArgs e)
        {
            try
            {

          player?.Dispose();
             player = null;

                //((MusicPlayerPageViewModel)BindingContext).TidyUp();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }
        }





    }
}