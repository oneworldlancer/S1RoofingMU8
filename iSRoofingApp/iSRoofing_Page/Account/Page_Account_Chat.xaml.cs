//// 

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumGlobalManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
//////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Login;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Account
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Account_Chat : ContentView
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














        public Page_Account_Chat()
        {
            InitializeComponent();

            try
            {




                //Task.Run ( async ( ) =>
                //{
                //    await Initialize_AppTranslation ( );
                //} ).Wait ( );












                MessagingCenter.Subscribe<App, SRoofingCountryModel>(App.Current, "OpenPage", (snd, arg) =>
                {

                    //try
                    //{
                    //    //get the value by `arg`
                    //    frm_CountryName.BorderColor = Colors.White;

                    //    lbl_CountryList.Text = ( arg as SRoofingCountryModel ).CountryName.ToString ( );
                    //    txt_MobileNumber.Text = "+" + ( arg as SRoofingCountryModel ).CountryMobileCode;// (arg as Employee).m
                    //    txt_MobileNumber.IsEnabled = true;


                    //    _register_CountryName = ( arg as SRoofingCountryModel ).CountryName;
                    //    _register_CountryCode = ( arg as SRoofingCountryModel ).CountryCode;
                    //    _register_CountryMobileCode = ( arg as SRoofingCountryModel ).CountryMobileCode;

                    //    //txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;
                    //    //txt_MobileNumber.Focus();

                    //    //////   lbl_SignUp.IsEnabled = true;
                    //    _bln_IsCountryName = true;
                    //}
                    //catch ( Exception ex )
                    //{
                    //    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                    //}

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



        Type _iParent = null;


        bool _blnIsInitialized = false;



        SRoofingApplicationUtilityModelManager _iApplicationUtilityModel;



        SRoofingUserOwnerModelManager _iOwnerModel;
        SRoofingUserSettingModelManager _iSettingModel;
        #region Initialize

        public async Task Initialize(
         Type iParent,
             SRoofingApplicationUtilityModelManager iApplicationUtilityModel,
         SRoofingUserOwnerModelManager iOwnerModel,
            SRoofingUserSettingModelManager iSettingModel)
        {

            try
            {

                _iApplicationUtilityModel=iApplicationUtilityModel;


                _iParent = iParent;

                _iOwnerModel = iOwnerModel;
                _iSettingModel = iSettingModel;

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    swtch_SaveHistoryIsEnable.OnColor = Colors.Orange;
                    swtch_SaveHistoryIsEnable.ThumbColor = Colors.Gray;



                    swtch_DownloadImage.OnColor = Colors.Orange;
                    swtch_DownloadImage.ThumbColor = Colors.Gray;



                    swtch_DownloadVideo.OnColor = Colors.Orange;
                    swtch_DownloadVideo.ThumbColor = Colors.Gray;



                    swtch_DownloadDocument.OnColor = Colors.Orange;
                    swtch_DownloadDocument.ThumbColor = Colors.Gray;


                    if (_iSettingModel.History_Chat_SortBy == SRoofing_Enum_SortBy.SortBy_RECENT)
                    {
                        rdio_ByRecent.IsChecked = true;
                    }
                    else
                    {
                        rdio_ByName.IsChecked = true;

                    }

                    if (_iSettingModel.Chat_SaveHistory_IsEnable)
                    {
                        swtch_SaveHistoryIsEnable.IsToggled = true;
                    }



                    if (_iSettingModel.Media_DownloadImage_IsEnable)
                    {
                        swtch_DownloadImage.IsToggled = true;
                    }



                    if (_iSettingModel.Media_DownloadVideo_IsEnable)
                    {
                        swtch_DownloadVideo.IsToggled = true;
                    }



                    if (_iSettingModel.Media_DownloadDocument_IsEnable)
                    {
                        swtch_DownloadDocument.IsToggled = true;
                    }

                    img_Thum.Source = _iSettingModel.Chat_Background_ImageURL; //"bgbg_light_8.jpg";



                    Initialize_Gallery();














                    _blnIsInitialized = true;
                });



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


        #region Initialize_Gallery



        void Initialize_Gallery()
        {


            try
            {

                //imgBtn_BG_Light_1.Source = "bg_light_1.jpg";
                //imgBtn_BG_Light_2.Source = "bg_light_2.jpg";
                //imgBtn_BG_Light_3.Source = "bg_light_3.jpg";
                //imgBtn_BG_Light_4.Source = "bg_light_4.jpg";
                //imgBtn_BG_Light_5.Source = "bg_light_5.jpg";
                //imgBtn_BG_Light_6.Source = "bg_light_6.jpg";
                //imgBtn_BG_Light_7.Source = "bg_light_7.jpg";
                //imgBtn_BG_Light_8.Source = "bg_light_8.jpg";
                //imgBtn_BG_Light_9.Source = "bg_light_9.jpg";
                //imgBtn_BG_Light_10.Source = "bg_light_10.jpg";


                //imgBtn_BG_Dark_1.Source = "bg_dark_1.jpg";
                //imgBtn_BG_Dark_2.Source = "bg_dark_2.jpg";
                //imgBtn_BG_Dark_3.Source = "bg_dark_3.jpg";
                //imgBtn_BG_Dark_4.Source = "bg_dark_4.jpg";
                //imgBtn_BG_Dark_5.Source = "bg_dark_5.jpg";
                //imgBtn_BG_Dark_6.Source = "bg_dark_6.jpg";
                //imgBtn_BG_Dark_7.Source = "bg_dark_7.jpg";
                //imgBtn_BG_Dark_8.Source = "bg_dark_8.jpg";
                //imgBtn_BG_Dark_9.Source = "bg_dark_9.jpg";
                //imgBtn_BG_Dark_10.Source = "bg_dark_10.jpg";




                //imgBtn_BG_Light_1.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Light_1.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Light_2.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Light_2.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Light_3.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Light_3.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Light_4.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Light_4.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Light_5.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Light_5.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Light_6.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Light_6.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Light_7.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Light_7.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Light_8.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Light_8.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Light_9.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Light_9.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Light_10.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Light_10.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;



                //////////////////////////////




                //imgBtn_BG_Dark_1.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Dark_1.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Dark_2.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Dark_2.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Dark_3.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Dark_3.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Dark_4.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Dark_4.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Dark_5.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Dark_5.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Dark_6.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Dark_6.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Dark_7.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Dark_7.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Dark_8.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Dark_8.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Dark_9.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Dark_9.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;


                //imgBtn_BG_Dark_10.WidthRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Width;
                //imgBtn_BG_Dark_10.HeightRequest=_iApplicationUtilityModel.iScreenChatShow_iMedia_Height;














            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }

        }


        #endregion



















        #region Switch_Toggle


        async void swtch_SaveHistoryIsEnable_Toggled(object sender, ToggledEventArgs e)
        {
            try
            {
                if (_blnIsInitialized)
                {

                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {
                        _iSettingModel.Chat_SaveHistory_IsEnable = e.Value;
                        //_iOwnerModel.CountryName = _register_CountryName;
                        //_iOwnerModel.MobileNumberE164 = _register_MobileNumberE164;

                        if (_iParent == typeof(Page_Account_Dashboard))
                        {

                            ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;

                        }

                        ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                        ////////////////////{
                        ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        ////////////////////}



                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                            App.Current, _iOwnerModel, _iSettingModel);

                        Task.Run(async () =>
                      {
                          await SRoofing_UserSettingManager.UserSetting_Update_Chat_SaveHistory_IsEnable_ByOwnerUserTokenID(
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

                            if (_iParent == typeof(Page_Account_Dashboard))
                            {
                                ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);


                            }

                            ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                            ////////////////////{
                            ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                            ////////////////////}

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




        async void swtch_DownloadImage_Toggled(object sender, ToggledEventArgs e)
        {
            try
            {
                if (_blnIsInitialized)
                {

                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {
                        _iSettingModel.Media_DownloadImage_IsEnable = e.Value;
                        //_iOwnerModel.CountryName = _register_CountryName;
                        //_iOwnerModel.MobileNumberE164 = _register_MobileNumberE164;


                        if (_iParent == typeof(Page_Account_Dashboard))
                        {

                            ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;

                        }

                        ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                        ////////////////////{
                        ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        ////////////////////}



                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                            App.Current, _iOwnerModel, _iSettingModel);

                        _ = Task.Run(async () =>
                        {
                            await SRoofing_UserSettingManager.UserSetting_Update_Chat_Media_Image_IsDownload_ByOwnerUserTokenID(
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

                            if (_iParent == typeof(Page_Account_Dashboard))
                            {
                                ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);


                            }

                            ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                            ////////////////////{
                            ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                            ////////////////////}

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




        async void swtch_DownloadVideo_Toggled(object sender, ToggledEventArgs e)
        {
            try
            {
                if (_blnIsInitialized)
                {

                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {
                        _iSettingModel.Media_DownloadVideo_IsEnable = e.Value;
                        //_iOwnerModel.CountryName = _register_CountryName;
                        //_iOwnerModel.MobileNumberE164 = _register_MobileNumberE164;

                        if (_iParent == typeof(Page_Account_Dashboard))
                        {

                            ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;

                        }

                        ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                        ////////////////////{
                        ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        ////////////////////}



                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                            App.Current, _iOwnerModel, _iSettingModel);

                        Task.Run(async () =>
                      {
                          await SRoofing_UserSettingManager.UserSetting_Update_Chat_Media_Video_IsDownload_ByOwnerUserTokenID(
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

                            if (_iParent == typeof(Page_Account_Dashboard))
                            {
                                ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);


                            }

                            ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                            ////////////////////{
                            ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                            ////////////////////}

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




        async void swtch_DownloadDocument_Toggled(object sender, ToggledEventArgs e)
        {
            try
            {
                if (_blnIsInitialized)
                {

                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {
                        _iSettingModel.Media_DownloadDocument_IsEnable = e.Value;
                        //_iOwnerModel.CountryName = _register_CountryName;
                        //_iOwnerModel.MobileNumberE164 = _register_MobileNumberE164;


                        if (_iParent == typeof(Page_Account_Dashboard))
                        {

                            ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;

                        }

                        ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                        ////////////////////{
                        ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        ////////////////////}



                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                            App.Current, _iOwnerModel, _iSettingModel);

                        Task.Run(async () =>
                      {
                          await SRoofing_UserSettingManager.UserSetting_Update_Chat_Media_Document_IsDownload_ByOwnerUserTokenID(
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

                            if (_iParent == typeof(Page_Account_Dashboard))
                            {
                                ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);


                            }

                            ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                            ////////////////////{
                            ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                            ////////////////////}

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








        #region SortBy





        async void rdio_ByName_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try
            {
                if (_blnIsInitialized)
                {

                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {

                        _iSettingModel.History_Chat_SortBy = SRoofing_Enum_SortBy.SortBy_NAME;



                        if (_iParent == typeof(Page_Account_Dashboard))
                        {

                            ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;

                        }

                        ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                        ////////////////////{
                        ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        ////////////////////}



                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                            App.Current, _iOwnerModel, _iSettingModel);

                        _ = Task.Run(async () =>
                          {
                              App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = true;

                              App.bln_ScreenChatShow_OnAppearing_New_MessageList=true;

                              await SRoofing_UserSettingManager.UserSetting_Update_Chat_SortBy_ByOwnerUserTokenID(
                                   App.Current,
                App.iAccountType,
                _iOwnerModel,
                 SRoofing_Enum_SortBy.SortBy_NAME);

                          }).ConfigureAwait(false);

                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread(() =>
                        {
                            // Code to run on the main thread

                            if (_iParent == typeof(Page_Account_Dashboard))
                            {
                                ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);


                            }

                            ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                            ////////////////////{
                            ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                            ////////////////////}

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

        async void rdio_ByRecent_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try
            {
                if (_blnIsInitialized)
                {

                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {

                        _iSettingModel.History_Chat_SortBy = SRoofing_Enum_SortBy.SortBy_RECENT;


                        if (_iParent == typeof(Page_Account_Dashboard))
                        {

                            ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;

                        }

                        ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                        ////////////////////{
                        ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        ////////////////////}




                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                            App.Current, _iOwnerModel, _iSettingModel);

                        _ = Task.Run(async () =>
                           {

                               App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = true;

                               App.bln_ScreenChatShow_OnAppearing_New_MessageList=true;


                               await SRoofing_UserSettingManager.UserSetting_Update_Chat_SortBy_ByOwnerUserTokenID(
                                   App.Current,
                App.iAccountType,
                _iOwnerModel,
                  SRoofing_Enum_SortBy.SortBy_RECENT);

                           }).ConfigureAwait(false);

                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread(() =>
                        {
                            // Code to run on the main thread

                            if (_iParent == typeof(Page_Account_Dashboard))
                            {
                                ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);


                            }

                            ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                            ////////////////////{
                            ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                            ////////////////////}

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






        #region Register-1



        string _login_MobileNumber = "0";



        bool _bln_MobileNumber = false;
        bool _bln_Register_Step1 = false;
        bool _bln_IsCountryName = false;
        async Task onPostExecute_LoginAsync()
        {

            try
            {

                ////_bln_IsRegister_RunningNow = true;

                ////_bln_MobileNumber = Register_ValidateUserLoginMobileNumberOnBlur ( );
                ////_register_Password = Get_Password ( );
                ////_bln_Register_Step1 = Register_Step1 ( );

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

                        MainThread.BeginInvokeOnMainThread(() =>
                        {
                            // Code to run on the main thread

                            //////if ( _iParent == typeof ( Page_Account_Dashboard ) )
                            //////{


                            //////}

                            //////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                            //////{

                            //////}

                            //  ( ( Page_Account_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( "Fill in your data!" );

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

        async void btn_Popup_OK_Tapped(object sender, EventArgs e)
        {

        }

        async void btn_Popup_CANCEL_Tapped(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(txt_Chat_BackgroungImageURL.Text))
            {

                if (Uri.IsWellFormedUriString(txt_Chat_BackgroungImageURL.Text, UriKind.Absolute))     // url-valid 
                {

                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {

                        _iSettingModel.Chat_Background_ImageURL = txt_Chat_BackgroungImageURL.Text;



                        if (_iParent == typeof(Page_Account_Dashboard))
                        {

                            ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;

                        }

                        ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                        ////////////////////{
                        ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                        ////////////////////}


                        await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                            App.Current, _iOwnerModel, _iSettingModel);

                        Task.Run(async () =>
                      {
                          await SRoofing_UserSettingManager.UserSetting_Update_Chat_BackgroundImageURL_ByOwnerUserTokenID(
                              App.Current,
           App.iAccountType,
           _iOwnerModel, txt_Chat_BackgroungImageURL.Text);

                      }).ConfigureAwait(false);


                    }

                    else
                    {
                        MainThread.BeginInvokeOnMainThread(() =>
                        {
                            // Code to run on the main thread

                            if (_iParent == typeof(Page_Account_Dashboard))
                            {
                                ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);


                            }

                            ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                            ////////////////////{
                            ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                            ////////////////////}

                        });
                    }

                }
            }


        }

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

        async void imgBtn_BG_Light_1_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_light_1.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_light_1.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }

        async void imgBtn_BG_Light_2_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_light_2.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_light_2.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Light_3_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_light_3.jpg";
                grd_PickerGallery.IsVisible = false;

                await Set_Chat_BackgroundImageURL("bg_light_3.jpg");


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Light_4_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_light_4.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_light_4.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Light_5_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_light_5.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_light_5.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Light_6_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_light_6.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_light_6.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Light_7_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_light_7.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_light_7.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Light_8_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_light_8.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_light_8.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Light_9_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_light_9.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_light_9.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Light_10_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_light_10.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_light_10.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Dark_1_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_dark_1.jpg";
                grd_PickerGallery.IsVisible = false;

                await Set_Chat_BackgroundImageURL("bg_dark_1.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Dark_2_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_dark_2.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_dark_2.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Dark_3_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_dark_3.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_dark_3.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Dark_4_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_dark_4.jpg";
                grd_PickerGallery.IsVisible = false;

                await Set_Chat_BackgroundImageURL("bg_dark_4.jpg");


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Dark_5_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_dark_5.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_dark_5.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Dark_6_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_dark_6.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_dark_6.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Dark_7_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_dark_7.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_dark_7.jpg");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }

        async void imgBtn_BG_Dark_8_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_dark_8.jpg";
                grd_PickerGallery.IsVisible = false;

                await Set_Chat_BackgroundImageURL("bg_dark_8.jpg");


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Dark_9_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_dark_9.jpg";
                grd_PickerGallery.IsVisible = false;

                await Set_Chat_BackgroundImageURL("bg_dark_9.jpg");


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_BG_Dark_10_Clicked(object sender, EventArgs e)
        {
            try
            {
                // img_Thum.Source = "bg_dark_10.jpg";
                grd_PickerGallery.IsVisible = false;


                await Set_Chat_BackgroundImageURL("bg_dark_10.jpg");

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

                MainThread.BeginInvokeOnMainThread(() =>
                {

                    //////if ( _iLanguageModel.LanguageCode == "ar" )
                    //////{
                    //////    lbl_Title.HorizontalTextAlignment = TextAlignment.Start;

                    //////    lbl_Title_Chat_SortBy.HorizontalTextAlignment = TextAlignment.Start;
                    //////    lbl_Title_Chat_History.HorizontalTextAlignment = TextAlignment.Start;
                    //////    lbl_Title_Chat_BackgroundImage.HorizontalTextAlignment = TextAlignment.Start;
                    //////    lbl_Title_Chat_Media.HorizontalTextAlignment = TextAlignment.Start;

                    //////    //lbl_Title_Chat_Media.HorizontalTextAlignment = TextAlignment.Start;
                    //////    //lbl_Title_Chat_Media.HorizontalTextAlignment = TextAlignment.Start;
                    //////    //lbl_Title_Chat_Media.HorizontalTextAlignment = TextAlignment.Start;

                    //////}
                    //////else
                    //////{
                    //////    lbl_Title.HorizontalTextAlignment = TextAlignment.End;

                    //////    lbl_Title_Chat_SortBy.HorizontalTextAlignment = TextAlignment.End;
                    //////    lbl_Title_Chat_History.HorizontalTextAlignment = TextAlignment.End;
                    //////    lbl_Title_Chat_BackgroundImage.HorizontalTextAlignment = TextAlignment.End;
                    //////    lbl_Title_Chat_Media.HorizontalTextAlignment = TextAlignment.End;

                    //////    //lbl_Title_Chat_Media.HorizontalTextAlignment = TextAlignment.End;
                    //////    //lbl_Title_Chat_Media.HorizontalTextAlignment = TextAlignment.End;
                    //////    //lbl_Title_Chat_Media.HorizontalTextAlignment = TextAlignment.End;

                    //////}

                    //lbl_SortByRecent.HorizontalTextAlignment = TextAlignment.End;
                    //lbl_SortByName.HorizontalTextAlignment = TextAlignment.End;
                    //lbl_Chat_SaveHistory.HorizontalTextAlignment = TextAlignment.End;
                    //lbl_Chat_BackgroungImageURL.HorizontalTextAlignment = TextAlignment.End;
                    //lbl_Download_Image.HorizontalTextAlignment = TextAlignment.End;
                    //lbl_Download_Video.HorizontalTextAlignment = TextAlignment.End;
                    //lbl_Download_Document.HorizontalTextAlignment = TextAlignment.End;


                    lbl_Title.Text = "S1Roofing " + _iLanguageModel.lblText_Tab_Chats;
                    lbl_Title_Chat_History.Text = _iLanguageModel.lblText_Chat_History;
                    lbl_Title_Chat_BackgroundImage.Text = _iLanguageModel.lblText_Chat_BackgruondImageURL;
                    lbl_Title_Chat_Media.Text = _iLanguageModel.lblText_Chat_Media;


                    lbl_Title_Chat_SortBy.Text = _iLanguageModel.lblText_Setting_SortBy_Message;
                    lbl_SortByRecent.Text = _iLanguageModel.lblText_Setting_ByRecent_Message;
                    lbl_SortByName.Text = _iLanguageModel.lblText_Setting_ByName_Message;

                    lbl_Chat_SaveHistory.Text = _iLanguageModel.lblText_Setting_SaveHistory_Message;
                    //txt_Chat_BackgroungImageURL.Placeholder = _iLanguageModel.lblText_Setting_Chat_BackgroundImageURL_Message;

                    lbl_Download_Image.Text = _iLanguageModel.lblText_Setting_Chat_MediaDownload_Image_Message;
                    lbl_Download_Video.Text = _iLanguageModel.lblText_Setting_Chat_MediaDownload_Video_Message;
                    lbl_Download_Document.Text = _iLanguageModel.lblText_Setting_Chat_MediaDownload_Document_Message;



                    ////lbl_CountryList.Text = _iLanguageModel.lblText_YourCountry;
                    ////txt_MobileNumber.Placeholder = _iLanguageModel.lblText_MobileNumber;
                    ////txt_FirstName.Placeholder = _iLanguageModel.lblText_FirstName;
                    ////txt_LastName.Placeholder = _iLanguageModel.lblText_LastName;

                    ////btn_Popup_CANCEL.Text = _iLanguageModel.lblText_Command_Reset;
                    ////btn_Popup_OK.Text = _iLanguageModel.lblText_Command_Save;
                    btn_Submit.Text = _iLanguageModel.lblText_Command_Submit;
                    ////btn_Login.Text = _iLanguageModel.lblText_Splash_SignIn;
                });



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

                if (!string.IsNullOrWhiteSpace(txt_Chat_BackgroungImageURL.Text))
                {

                    if (Uri.IsWellFormedUriString(txt_Chat_BackgroungImageURL.Text, UriKind.Absolute))     // url-valid 
                    {

                        if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                        {

                            _iSettingModel.Chat_Background_ImageURL = txt_Chat_BackgroungImageURL.Text;


                            if (_iParent == typeof(Page_Account_Dashboard))
                            {

                                ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;

                            }

                            ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                            ////////////////////{
                            ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                            ////////////////////}



                            await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                                App.Current, _iOwnerModel, _iSettingModel);

                            _=      Task.Run(async () =>
                                {
                                    await SRoofing_UserSettingManager.UserSetting_Update_Chat_BackgroundImageURL_ByOwnerUserTokenID(
                                        App.Current,
                     App.iAccountType,
                     _iOwnerModel, txt_Chat_BackgroungImageURL.Text);

                                }).ConfigureAwait(false);


                        }

                        else
                        {
                            MainThread.BeginInvokeOnMainThread(async () =>
                            {
                                // Code to run on the main thread

                                if (_iParent == typeof(Page_Account_Dashboard))
                                {
                                    await ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);


                                }

                                //////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                                //////////////////{
                                //////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                                //////////////////}


                            });
                        }

                    }
                }

                if (_iParent == typeof(Page_Account_Dashboard))
                {

                    await ((Page_Account_Dashboard)Parent.BindingContext).CloseDrawer();


                }

                ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                ////////////////////{

                ////////////////////    //await ( ( Page_Account_Dashboard ) Parent.BindingContext ).CloseDrawer ( );


                ////////////////////}

                ////////if ( !_bln_IsRegister_RunningNow )
                ////////{




            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }







        #region frm_Toggle


        private void frm_ChatHsitory_Tapped(object sender, EventArgs e)
        {
            try
            {

                if (_blnIsInitialized)
                {

                    if (swtch_SaveHistoryIsEnable.IsToggled)
                    {
                        swtch_SaveHistoryIsEnable.IsToggled = false;
                    }
                    else
                    {
                        swtch_SaveHistoryIsEnable.IsToggled = true;
                    }

                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }




        private void frm_MediaImage_Tapped(object sender, EventArgs e)
        {
            try
            {

                if (_blnIsInitialized)
                {

                    if (swtch_DownloadImage.IsToggled)
                    {
                        swtch_DownloadImage.IsToggled = false;
                    }
                    else
                    {
                        swtch_DownloadImage.IsToggled = true;
                    }

                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void btn_ImageDarkList_Clicked(object sender, EventArgs e)
        {
            try
            {

                _arrImageList_Temp= new ObservableCollection<SRoofingKeyValueModelManager>();

                _arrImageList_Temp=  await SRoofingSync_ImageBackground_Manager
                          .Sync_ImageBackground_Get_System_Chat_DarkList(App.Current);


                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    _arrImageList.Clear();


                    for (int i = 0; i < _arrImageList_Temp.Count; i++)
                    {

                        _arrImageList.Add(_arrImageList_Temp[i]);
                        await Task.Delay(SRoofing_EnumGlobalPreference.Global_ROW_LIST_DELAY);

                    }


                });

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }
        }

        private async void btn_ImageLightList_Clicked(object sender, EventArgs e)
        {
            try
            {

                _arrImageList_Temp= new ObservableCollection<SRoofingKeyValueModelManager>();

                _arrImageList_Temp=  await SRoofingSync_ImageBackground_Manager
                          .Sync_ImageBackground_Get_System_Chat_LightList(App.Current);


                MainThread.BeginInvokeOnMainThread(async () =>
                 {

                     _arrImageList.Clear();
                     for (int i = 0; i < _arrImageList_Temp.Count; i++)
                     {

                         _arrImageList.Add(_arrImageList_Temp[i]);
                         await Task.Delay(SRoofing_EnumGlobalPreference.Global_ROW_LIST_DELAY);

                     }


                 });



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }
        }

        private void cv_ChatBackgroundImageList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                //var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

                //if (objService != null)
                //{
                //    objService.KeyboardClick();
                //}


                SRoofingKeyValueModelManager _iBackgroundImageModel = (SRoofingKeyValueModelManager)e.CurrentSelection.FirstOrDefault();//(SRoofingScreenChatShowHistoryMessageModelManager)iObjectModel;


                _ = Task.Run(async () =>
                {

                    await Set_Chat_BackgroundImageURL(_iBackgroundImageModel.ItemValue);

                })
                 .ConfigureAwait(false);

                MainThread.BeginInvokeOnMainThread(action: () =>
                {

                    grd_PickerGallery.IsVisible = false;

                });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private void frm_MediaVideo_Tapped(object sender, EventArgs e)
        {
            try
            {

                if (_blnIsInitialized)
                {

                    if (swtch_DownloadVideo.IsToggled)
                    {
                        swtch_DownloadVideo.IsToggled = false;
                    }
                    else
                    {
                        swtch_DownloadVideo.IsToggled = true;
                    }

                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }




        private void frm_MediaDocument_Tapped(object sender, EventArgs e)
        {
            try
            {

                if (_blnIsInitialized)
                {

                    if (swtch_DownloadDocument.IsToggled)
                    {
                        swtch_DownloadDocument.IsToggled = false;
                    }
                    else
                    {
                        swtch_DownloadDocument.IsToggled = true;
                    }

                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }





        async void sl_Chat_SortByRecent_Tapped(object sender, EventArgs e)
        {
            try
            {

                if (_blnIsInitialized)
                {

                    if (rdio_ByRecent.IsChecked)
                    {
                        rdio_ByRecent.IsChecked = false;
                    }
                    else
                    {
                        rdio_ByRecent.IsChecked = true;
                    }

                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }





        async void sl_Chat_SortByName_Tapped(object sender, EventArgs e)
        {
            try
            {

                if (_blnIsInitialized)
                {

                    if (rdio_ByName.IsChecked)
                    {
                        rdio_ByName.IsChecked = false;
                    }
                    else
                    {
                        rdio_ByName.IsChecked = true;
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



        #region Chat_BackgroundImageURL

        ObservableCollection<SRoofingKeyValueModelManager> _arrImageList = new ObservableCollection<SRoofingKeyValueModelManager>();
        ObservableCollection<SRoofingKeyValueModelManager> _arrImageList_Temp;
        async void imgBtn_Chat_BackgroundImageURL_Clicked(object sender, EventArgs e)
        {
            try
            {

                if (cv_ChatBackgroundImageList.ItemsSource == null)
                {
                    cv_ChatBackgroundImageList.ItemsSource=_arrImageList;
                }

                _arrImageList_Temp= new ObservableCollection<SRoofingKeyValueModelManager>();

                _arrImageList_Temp=  await SRoofingSync_ImageBackground_Manager
                          .Sync_ImageBackground_Get_System_Chat_LightList(App.Current);


                MainThread.BeginInvokeOnMainThread(async () =>
              {

                  _arrImageList.Clear();


                  for (int i = 0; i < _arrImageList_Temp.Count; i++)
                  {

                      _arrImageList.Add(_arrImageList_Temp[i]);

                      await Task.Delay(SRoofing_EnumGlobalPreference.Global_ROW_LIST_DELAY);

                  }


              });


                grd_PickerGallery.IsVisible = true;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        async Task Set_Chat_BackgroundImageURL(string imgURL)
        {

            try
            {
                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {

                    MainThread.BeginInvokeOnMainThread(() =>
                 {
                     img_Thum.Source = imgURL;
                 });

                    _iSettingModel.Chat_Background_ImageURL = imgURL;


                    if (_iParent == typeof(Page_Account_Dashboard))
                    {

                        ((Page_Account_Dashboard)Parent.BindingContext)._iSettingModel = _iSettingModel;

                    }

                    ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                    ////////////////////{
                    ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iSettingModel = _iSettingModel;

                    ////////////////////}



                    await SRoofingSync_UserSetting_Manager.Sync_Speech_Update_Setting_ByUserID(
                        App.Current, _iOwnerModel, _iSettingModel);

                    _=   Task.Run(async () =>
                     {
                         await SRoofing_UserSettingManager.UserSetting_Update_Chat_BackgroundImageURL_ByOwnerUserTokenID(
                             App.Current,
          App.iAccountType,
          _iOwnerModel, txt_Chat_BackgroungImageURL.Text);

                     }).ConfigureAwait(false);


                }

                else
                {
                    MainThread.BeginInvokeOnMainThread(async () =>
                    {
                        // Code to run on the main thread

                        if (_iParent == typeof(Page_Account_Dashboard))
                        {
                            await ((Page_Account_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Account_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);


                        }

                        ////////////////////else if ( _iParent == typeof ( Page_ScreenChatShow_Dashboard ) )
                        ////////////////////{
                        ////////////////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext ).Snack_ShowMessage ( ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iLanguageModel.lblText_Connection_CheckOnline_Message );

                        ////////////////////}

                    });
                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }

        public bool close_List()
        {
            if (grd_PickerGallery.IsVisible == true)
            {
                grd_PickerGallery.IsVisible = false;
                return false;
            }
            return true;
        }

        #endregion



    }
}