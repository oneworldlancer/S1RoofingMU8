
#if ANDROID


using Android.Webkit;
using Android.Widget;

using Java.Interop;

#endif


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

using Plugin.Maui.Audio;

//using Plugin.SimpleAudioPlayer;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Register;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;


namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Call
{
    ////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Call_Dashboard : ContentPage
    {

        readonly IAudioManager audioManager;

        IAudioPlayer player;

        public SRoofingUserOwnerModelManager _iOwnerModel;
        public SRoofingUserRemoteModelManager _iRemoteModel;

        public SRoofingScreenCallShowScreenModel _iCallModel;
        public string _CallServerStatus = null;
        public string _CallState = null;
        public string _TimeState = null;
        public bool IsCallEndByRemote = false;
        public string _CallStatus = "pending";
        public string _CallType_Owner = SRoofingEnum_Call_Type.CallType_Voice;
        public string _CallType_Remote = SRoofingEnum_Call_Type.CallType_Voice;


        bool _blnIsInitialized_BroadcastReceiver = false;

        public Page_Call_Dashboard()
        {
            InitializeComponent();

            try
            {

                //////////if (player == null)
                //////////{

                //////////    Task.Run(async () =>
                //////////    {

                //////////        player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(""));


                //////////    }).Wait();

                //////////    //player = AudioManager.Current;//.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("ukelele.mp3"));

                //////////    ////////var audioPlayer = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("ukelele.mp3"));

                //////////    //  player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

                //////////}

                //  IconTintColorEffect.SetTintColor ( imgBG_Drop , Colors.Blue );

                //   SRoofing_DebugManager.Debug_ShowSystemMessage("SRoofing_TranslationManager == " + SRoofing_TranslationManager.TranslateText("fr", "صباح الخير"));


                //if (!_blnIsInitialized_BroadcastReceiver)
                //{

                //    _blnIsInitialized_BroadcastReceiver = true;

                //    MessagingCenter.Subscribe<App, Type>(App.Current, "Page_Load", async (snd, arg) =>
                //    {

                //        try
                //        {



                //            if (arg == typeof(Page_Call_Dashboard))
                //            {

                //                //get the value by `arg`

                //                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == " + arg.ToString());

                //                //await Task.Delay ( 0 );

                //                //////if ( !_bln_IsInitialized_Page_Landing_Dashboard )
                //                //////{
                //                //////    _bln_IsInitialized_Page_Landing_Dashboard = true;

                //                ////////Task.Run ( async ( ) => { await Preload ( ); } ) ;
                //                ////////Task.Run ( async ( ) => { await Initialize ( ); } ) ;



                //                //////}

                //                await Preload();
                //                await Initialize();





                //                //////_iCurrent_CategoryModel = ( arg as SRoofingKeyValueModelManager );
                //                //////lblCategoryList.Text = ( arg as SRoofingKeyValueModelManager ).ItemText.ToString ( );

                //                //////Task.Run ( async ( ) =>
                //                //////{
                //                //////    await Initialize_Get_List_Group_ByCategoryTokenID (
                //                //////        _iCurrent_CategoryModel.ItemValue ,
                //                //////        _iCurrent_CategoryModel.ItemText ,
                //                //////        false );
                //                //////} ).Wait ( );
                //                //_blnIsInitialized_Popup_IsOpen = false;

                //                //txt_MobileNumber.Text = "+" + ( arg as SRoofingKeyValueModelManager ).CountryMobileCode;// (arg as Employee).m
                //                // txt_MobileNumber.IsEnabled = true;
                //                //txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;
                //                //txt_MobileNumber.Focus();

                //                //lbl_SignUp.IsEnabled = true;
                //            }
                //        }
                //        catch (Exception ex)
                //        {
                //            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                //        }

                //    });


                //}



                //SRoofing_DebugManager.Debug_ShowSystemMessage ( "page_CallDashboard Width== " + page_CallDashboard.Width.ToString ( ) );
                //SRoofing_DebugManager.Debug_ShowSystemMessage ( "page_CallDashboard WidthRequest== " + page_CallDashboard.WidthRequest.ToString ( ) );
                //SRoofing_DebugManager.Debug_ShowSystemMessage ( "page_CallDashboard MainDisplayInfo== " + DeviceDisplay.MainDisplayInfo.Width.ToString ( ) );





            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }





        protected override async void OnAppearing()
        {
            base.OnAppearing();

            try
            {

                ////////////Task.Run(async () => { await Preload(); }).Wait();
                ////////////Task.Run(async () => { await Initialize(); }).Wait();

                //await Task.Delay ( 2000 );
                //player.Load ( "snd_call_out_1.mp3" );


                //await Task.Delay ( 2000 );


                //Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current.Play ( );

                //Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current.Loop = true;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        #region Preload

        async Task Preload()
        {
            try
            {

                //////SRoofingScreenCallShowScreenModel _iCallModelX;

                //////_iCallModelX = new SRoofingScreenCallShowScreenModel {

                //////    CallTag="offer",
                //////    CallType = "voice",
                //////    CallDirection="out",
                //////    iRemoteModel=new SRoofingUserRemoteModelManager
                //////        {
                //////        OwnerUserTokenID="39",
                //////        OwnerMobileNumberTokenID="1102" ,
                //////        AvatarName="SH"
                //////        }
                //////    } ;
                //////SRoofingSync_ScreenCallShowManager.Sync_ScreenCallShow_Set_CallModel ( App.Current ,
                //////    new System.Collections.ObjectModel.ObservableCollection<SRoofingScreenCallShowScreenModel> {
                //////    _iCallModelX} );

                _iOwnerModel = await
        SRoofingSync_User_OwnerManager.Sync_User_Owner_Get_UserModel(
     App.Current);

                _iCallModel = SRoofingSync_ScreenCallShowManager.Sync_ScreenCallShow_Get_CallModel(App.Current);

                _iRemoteModel = _iCallModel.iRemoteModel;


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }
        #endregion




        #region Initialize

        async Task Initialize()
        {
            try
            {


                _CallType_Owner = SRoofingEnum_Call_Type.CallType_Voice;
                _CallType_Remote = SRoofingEnum_Call_Type.CallType_Voice;




                await Initialize_Socket();

                await Initialize_Avatar();

                await Initialize_Popup();



                //     _iCallModel = SRoofingSyncManager.Sync_Call_GetCurrentScreenCallShowByUserID (
                //this );

                //     _iRemoteModel = _iCallModel. iRemoteModel ( );


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        async Task Initialize_Avatar()
        {
            try
            {

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    // Code to run on the main thread
                    lbl_AvatarName_Splash.Text = _iRemoteModel.AvatarName;
                    lbl_UserName.Text = _iRemoteModel.FullName;


                });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        async Task Initialize_Popup()
        {

            try
            {
                _CallType_Owner = _iCallModel.CallType;
                _CallType_Remote = _iCallModel.CallType;


                if (_iCallModel.CallTag == SRoofingEnum_Call_Tag.CallTag_Offer)
                {
                    await Call_Owner_Tag_OnOffer();
                }

                else if (_iCallModel.CallTag == SRoofingEnum_Call_Tag.CallTag_Answer)
                {

                    await Call_Owner_Tag_OnAnswer();
                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        string _ScreenCallShowTicketID;
        string _iRemoteLoginStatus = SRoofingEnum_LoginStatus.LoginStatus_ONLINE;


        async Task Call_Owner_Tag_OnOffer()
        {

            try
            {
                CallWindow = "open";

                _CallStatus=SRoofingEnum_Call_Status.CallStatus_Pending;

                //   ll_Drop.IsVisible = true;
                // ll_Redial.IsVisible = true;

                await ShowView(ll_Redial, ll_Drop);

                await Call_PlayCallOutSound();

                //_iRemoteLoginStatus = SRoofingEnum_LoginStatus.LoginStatus_OFFLINE;



                if (_iRemoteLoginStatus == SRoofingEnum_LoginStatus.LoginStatus_OFFLINE)
                {

                    await Call_StopCallOutSound();

                    //if ( _hndlr_iGlobalHandler != null )
                    //    {
                    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_SoundPlayer_CallOut );
                    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_Owner_Offer_TimeOut_Ring );
                    //    }

                    await SoundPlayer_Play_CallFail();

                    await Call_Remote_OnReplyByMessageType(
                            SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_CallReplyByOfflineMessage,
                            "",
                            "");

                    //CallWindow = "close";

                }
                else
                {

                    CallWindow = "open";

                    await Owner_Call_OfferWS();


                    _ = Task.Run(async () =>
                    {

                        await Task.Delay(30000);

                        if (_CallStatus == SRoofingEnum_Call_Status.CallStatus_Pending
                                    && ll_Redial.IsVisible == false)
                        {
                            _CallStatus = SRoofingEnum_Call_Status.CallStatus_NotApproved;

                            await Owner_Call_TimeoutWS();

                            await Call_StopCallOutSound();

                            //if ( _hndlr_iGlobalHandler != null )
                            //    {
                            //    _hndlr_iGlobalHandler.removeCallbacks ( _run_SoundPlayer_CallOut );
                            //    _hndlr_iGlobalHandler.removeCallbacks ( _run_Owner_Offer_TimeOut_Ring );
                            //    }

                            await SoundPlayer_Play_CallFail();

                            await Call_Remote_OnReplyByMessageType(
                                    SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_CallReplyByTimeOutMessage,
                                    "",
                                    "");


                        }


                    })
                        .ConfigureAwait(false);

                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        async Task Call_Owner_Tag_OnAnswer()
        {

            try
            {
                CallWindow = "open";

                _CallStatus=SRoofingEnum_Call_Status.CallStatus_Ring;

                //   ll_Drop.IsVisible = true;
                // ll_Redial.IsVisible = true;

                await ShowView(ll_Redial, ll_Ring);

                await Call_PlayCallInSound();


                _ = Task.Run(async () =>
                {

                    await Task.Delay(25000);

                    if (_CallStatus == SRoofingEnum_Call_Status.CallStatus_Ring)
                    {


                        _CallStatus = SRoofingEnum_Call_Status.CallStatus_NotApproved;

                        //////Call_Handler_Reset_OnStart ( );

                        //////Call_OnCameraRelease ( );

                        //////if ( _iActivity.svcSRoofingFloatCallCommandRTMP != null )
                        //////    {
                        //////    _iActivity.svcSRoofingFloatCallCommandRTMP.Timer_Stop ( );
                        //////    }


                        _CallState = "notapproved";
                        _TimeState = "stop";

                        IsCallEndByRemote = true;

                        await Call_StopCallInSound();
                        await Call_StopCallOutSound();


                        MainThread.BeginInvokeOnMainThread(async () =>
                        {
                            // Code to run on the main thread
                            CallWindow = "close";

                            await Navigation.PopAsync();

                        });

                    }


                })
                    .ConfigureAwait(false);


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        #endregion

        #region Call_Message


        async Task Call_Remote_OnReplyByMessageType(
                  string MessageType,
                string MessageText,
                string CallDuration)
        {

            try
            {

                _CallStatus = SRoofingEnum_Call_Status.CallStatus_NotApproved;

                //////Call_Handler_Reset_OnStart ( );

                //////Call_OnCameraRelease ( );

                //////if ( _iActivity.svcSRoofingFloatCallCommandRTMP != null )
                //////    {
                //////    _iActivity.svcSRoofingFloatCallCommandRTMP.Timer_Stop ( );
                //////    }


                _CallState = "notapproved";
                _TimeState = "stop";

                IsCallEndByRemote = true;

                await Call_StopCallInSound();
                await Call_StopCallOutSound();

                //xWalkWebView1.load("javascript:" + "ShowReplyMessage()", null);

                // call_CommandButton_OnReplyMessage ();

                if (MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager
                                                            .ScreenChatShowTextTypeMessage_CallReplyByBusyMessage)
                {

                    //Call_MessageText(intent.getstringExtra("msgtxt"));

                    await Call_MessageText(SRoofingEnum_ScreenChatShowTextParseMessageManager
                                                   .ScreenCallShowTextParseMessage_CallReplyByBusyMessage(
                                                           "out"));

                }
                else if (MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager
                                                                 .ScreenChatShowTextTypeMessage_VoiceCommandMessage)
                {


                    //Call_MessageText (
                    //        SRoofingChatEmotionParse.ChatEmotion_GetSmiledText (
                    //                _iActivity ,
                    //                MessageText ).ToString ( ) ;

                }
                else if (MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager
                                                                 .ScreenChatShowTextTypeMessage_CallReplyByTextMessage)
                {

                    //Call_MessageText (
                    //        SRoofingChatEmotionParse.ChatEmotion_GetSmiledText (
                    //                _iActivity ,
                    //                MessageText ).ToString ( ) ;


                    /*
                    Call_MessageText(SRoofingEnum_ScreenChatShowTextParseMessageManager
                            .ScreenCallShowTextParseMessage_CallReplyByTextMessage("out"));
    */
                }
                else if (MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager
                                                                 .ScreenChatShowTextTypeMessage_CallReplyByVoiceCallMessage)
                {

                    //Call_MessageText (
                    //        SRoofingChatEmotionParse.ChatEmotion_GetSmiledText (
                    //                _iActivity ,
                    //                MessageText ).ToString ( ) ;

                    /*
                    Call_MessageText(SRoofingEnum_ScreenChatShowTextParseMessageManager
                            .ScreenCallShowTextParseMessage_CallReplyByVoiceCallMessage("out"));
    */
                }
                else if (MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager
                                                                 .ScreenChatShowTextTypeMessage_CallReplyByDeclineMessage)
                {

                    //Call_MessageText (
                    //        SRoofingChatEmotionParse.ChatEmotion_GetSmiledText (
                    //                _iActivity ,
                    //                MessageText ).ToString ( ) ;


                    await Call_MessageText(SRoofingEnum_ScreenChatShowTextParseMessageManager
                            .ScreenCallShowTextParseMessage_CallReplyByDeclineMessage("out"));

                }
                else if (MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager
                                                                 .ScreenChatShowTextTypeMessage_CallReplyBySwipeMessage)
                {

                    //Call_MessageText (
                    //        SRoofingChatEmotionParse.ChatEmotion_GetSmiledText (
                    //                _iActivity ,
                    //                MessageText ).ToString ( ) ;

                    /*
                    Call_MessageText(SRoofingEnum_ScreenChatShowTextParseMessageManager
                            .ScreenCallShowTextParseMessage_CallReplyBySwipeMessage("out"));
    */
                }
                else if (MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager
                                                                 .ScreenChatShowTextTypeMessage_CallReplyByOfflineMessage)
                {

                    await Call_MessageText(SRoofingEnum_ScreenChatShowTextParseMessageManager
                                                 .ScreenCallShowTextParseMessage_CallOfflineMessage(
                                                         "out"));
                }
                else if (MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager
                                                                 .ScreenChatShowTextTypeMessage_CallEndDurationMessage)
                {

                    await Call_MessageText(SRoofingEnum_ScreenChatShowTextParseMessageManager
                                               .ScreenCallShowTextParseMessage_CallEndDurationMessage(
                                                       _iCallModel.CallDirection,
                                                       CallDuration));
                }
                else if (MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager
                                                                 .ScreenChatShowTextTypeMessage_CallEndMessage)
                {

                    await Call_MessageText(SRoofingEnum_ScreenChatShowTextParseMessageManager
                                               .ScreenCallShowTextParseMessage_CallEndMessage(
                                                       "out"));
                }
                else if (MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager
                                                                 .ScreenChatShowTextTypeMessage_CallReplyByTimeOutMessage)
                {

                    await Call_MessageText(SRoofingEnum_ScreenChatShowTextParseMessageManager
                                               .ScreenCallShowTextParseMessage_CallTimeOutMessage(
                                                       "out"));
                }

                ///////CommandBar_Owner_Redial ( );
                ///
                //////////ShowView ( ll_Drop ,  ll_Redial);


                //////////////////////MainThread.BeginInvokeOnMainThread(async () =>
                //////////////////////{
                //////////////////////    //ll_Drop.IsVisible = false;
                //////////////////////    //ll_Redial.IsVisible = true;

                //////////////////////    await ShowView(ll_Drop, ll_Redial);

                //////////////////////    // Code to run on the main thread
                //////////////////////    //////await SRoofing_Page_OpenerManager
                //////////////////////    //////                             .Page_Reset_Stack (
                //////////////////////    //////                             Navigation ,
                //////////////////////    //////                             new Page_Login_View ( ) );
                //////////////////////});



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }



        async Task Call_MessageText(string strMessageText)
        {
            try
            {

                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    // Code to run on the main thread


                    lbl_CallMessageText.Text = strMessageText;

                    webViewCall.Source=null;


                    //////await SRoofing_Page_OpenerManager
                    //////                             .Page_Reset_Stack (
                    //////                             Navigation ,
                    //////                             new Page_Login_View ( ) );
                });

                //Call_TimerText ( "" ,
                //                 Boolean.valueOf ( false ) );
                //_iActivity.fraCall_Dashboard._mViewPager.setPagingEnabled ( true );
                //_globalMessageText = paramstring;
                //handler_Start_CloseScreen ( );

                await ShowView(ll_Drop, ll_Redial);

                CallWindow = "close";

                await Task.Delay(7000);


                MainThread.BeginInvokeOnMainThread(async () =>
                            {


                                // Code to run on the main thread
                                if (CallWindow == "close")
                                {

                                    await Navigation.PopAsync();

                                }


                            });

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        #endregion




        #region SoundPlayer



        async Task Call_StopCallOutSound()
        {
            try
            {

                await Task.Delay(500);

                if (player != null)
                {

                    if (player.IsPlaying)
                    {
                        player.Stop();
                    }
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        async Task Call_StopCallInSound()
        {
            try
            {

                await Task.Delay(500);

                if (player != null)
                {

                    if (player.IsPlaying)
                    {
                        player.Stop();
                    }
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        async Task Call_PlayCallConnectingSound()
        {

            try
            {

                await Task.Delay(500);

                ////if (player == null)
                // player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("snd_connecting.mp3"));

                if (player.IsPlaying)
                    player.Stop();

                // player.Load("snd_connecting.mp3");
                await Task.Delay(500);

                player.Loop = false;
                player.Play();


                //if ( objSRoofingSound_PlayerManager == null )
                //    {
                //    objSRoofingSound_PlayerManager = new SRoofingSound_PlayerManager ( _iActivity );
                //    }

                //if ( SRoofingSound_PlayerManager.mp != null )
                //    {
                //    objSRoofingSound_PlayerManager.SoundPlayer_Stop_AllSound ( _iActivity );
                //    }

                //objSRoofingSound_PlayerManager.SoundPlayer_Play_CallConnecting (
                //        _iActivity ,
                //        _iActivity._iSettingModel ,
                //        _iActivity._iOwnerModel );

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            }
        }

        async Task Call_PlayCallEndSound()
        {

            try
            {

                await Task.Delay(500);

                ////if (player == null)
                player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("snd_call_end.mp3"));

                //player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

                if (player.IsPlaying)
                    player.Stop();

                // player.Load("snd_call_end.mp3");
                await Task.Delay(500);
                player.Loop = false;
                player.Play();


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            }
        }

        async Task Call_PlayCallFailSoundx()
        {

            try
            {

                await Task.Delay(500);

                ////if (player == null)
                player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("snd_call_fail.mp3"));

                //player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

                if (player.IsPlaying)
                    player.Stop();

                if (CallWindow != "close")
                {

                    //player.Load("snd_call_fail.mp3");
                    await Task.Delay(500);
                    player.Loop = false;
                    player.Play();
                }



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async Task Call_PlayCallInSound()
        {

            try
            {

                await Task.Delay(500);

                ////if (player == null)

                player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("snd_call_in_1.mp3"));

                //player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

                if (player.IsPlaying)
                    player.Stop();


                //player.Load("snd_call_in_1.mp3");
                await Task.Delay(500);
                player.Loop = true;
                player.Play();



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            }
        }

        async Task Call_PlayCallOutSound()
        {

            try
            {

                await Task.Delay(500);

                ////if (player == null)
                player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("snd_call_out_1.mp3"));

                //player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

                if (player.IsPlaying)
                    player.Stop();


                //player.Load("snd_call_out_1.mp3");
                await Task.Delay(500);
                player.Loop = true;
                player.Play();



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        async Task SoundPlayer_Play_CallFail()
        {

            try
            {


                await Task.Delay(500);

                //if (player == null)

                player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("snd_call_fail.mp3"));

                //player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

                if (player.IsPlaying)
                    player.Stop();


                if (CallWindow != "close")
                {

                    //player.Load("snd_call_fail.mp3");
                    await Task.Delay(500);
                    player.Loop = false;
                    player.Play();

                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }




        #endregion





        private async void imgBtn_CallDrop_Clicked(object sender, EventArgs e)
        {
            try
            {

                CallWindow = "close";

                if (player != null)
                {
                    if (player.IsPlaying)
                    {
                        player.Stop();
                        player = null;
                    }
                }

                await Owner_Call_DropWS();

                // Remove page before Edit Page
                //////this.Navigation.RemovePage ( this.Navigation.NavigationStack[ this.Navigation.NavigationStack.Count - 1  ] );

                //App.Current.MainPage.Navigation.RemovePage ( Navigation.NavigationStack.Last ( ) );

                MainThread.BeginInvokeOnMainThread(async () =>
                            {


                                // Code to run on the main thread
                                await Navigation.PopAsync();

                            });

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        string CallWindow = "open";
        private async void imgBtn_CallDecline_Voice_Clicked(object sender, EventArgs e)
        {
            try
            {

                await Owner_Call_DeclineWS();

                MainThread.BeginInvokeOnMainThread(async () =>
                            {
                                CallWindow = "close";


                                await Navigation.PopAsync();

                                // Code to run on the main thread

                            });



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private async void imgBtn_CallAnswer_Clicked(object sender, EventArgs e)
        {

            try
            {
                CallWindow = "open";

                _CallStatus=SRoofingEnum_Call_Status.CallStatus_Approved;



                await Call_StopCallInSound();

                await ShowView(ll_Ring, ll_ActionVoice);

                await Owner_Call_AnswerWS();


                _=  Task.Run(async () =>
                 {
                     string skt_Message = _iCallModel.CallTokenID + "-" +  _iCallModel.GroupTokenID + "-" + _iOwnerModel.OwnerUserTokenID + "-" + _iOwnerModel.OwnerMobileNumberTokenID + "-"+ SRoofingEnum_Socket_Call.SRoofingSocket_Call_Answer_RemoteToOwner + ",0";

                     await Send(client, skt_Message, CancellationToken.None);



                     //////////                 await SRoofing_ScreenCallShowMessageManager
                     //////////                   .ScreenCallShowMessage_New_Event_Message_ByScreenCallShowID(

                     //////////             App.Current,
                     //////////             App.iAccountType,
                     //////////             _iOwnerModel,
                     //////////   _iCallModel.iRemoteModel,
                     //////////       SRoofing_TimeManager.Time_GenerateToken(),
                     //////////    _iCallModel.CallTokenID,
                     //////////     _iCallModel.GroupTokenID,
                     //////////      _iCallModel.GroupTokenID,
                     //////////_iCallModel.iRemoteModel.OwnerUserTokenID,
                     //////////     _iCallModel.iRemoteModel.OwnerMobileNumberTokenID,
                     //////////       "0",
                     //////////       "0",
                     //////////        SRoofingEnum_Call_Code.CallCode_Voice,
                     //////////       SRoofingEnum_Call_Type.CallType_Voice,
                     //////////       SRoofingEnum_Call_Direction.CallDirection_In,
                     //////////       SRoofingEnum_Call_State.CallState_DECLINE,
                     //////////       "0",
                     //////////       "0",
                     //////////       "1");

                 })
                     .ConfigureAwait(false);






                //////////////_iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                //////////////          App.Current,
                //////////////          App.iAccountType,
                //////////////          _iOwnerModel,
                //////////////          _iHistoryContactModel.RemoteUserTokenID,
                //////////////          _iHistoryContactModel.RemoteMobileNumberTokenID);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }
        }

        private async void imgBtn_CallCancel_Clicked(object sender, EventArgs e)
        {
            try
            {

                _ = Task.Run(async () =>
                {
                    await webViewCall.EvaluateJavaScriptAsync("stop()");

                }).ConfigureAwait(false);



                MainThread.BeginInvokeOnMainThread(async () =>
            {


                // Code to run on the main thread
                CallWindow = "close";

                await Navigation.PopAsync();

            });




            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private async void imgBtn_CallRedial_Clicked(object sender, EventArgs e)
        {
            try
            {

                CallWindow = "open";

                _CallStatus= SRoofingEnum_Call_Status.CallStatus_Pending;


                await SRoofing_ScreenCallShowManager
           .Call_Initialize_Call_Show_Offer(
                App.Current,
                _iOwnerModel,
                _iRemoteModel);


                _iCallModel = SRoofingSync_ScreenCallShowManager.Sync_ScreenCallShow_Get_CallModel(App.Current);

                await Call_Owner_Tag_OnOffer();


                //await ShowView(ll_Redial, ll_Drop);
                //await Task.Delay(500);
                //await Call_PlayCallOutSound();



                await Initialize_Socket();



                //await Task.Delay(10000);

                //if (_iRemoteLoginStatus == SRoofingEnum_LoginStatus.LoginStatus_OFFLINE)
                //{

                //    await Call_StopCallOutSound();

                //    //if ( _hndlr_iGlobalHandler != null )
                //    //    {
                //    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_SoundPlayer_CallOut );
                //    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_Owner_Offer_TimeOut_Ring );
                //    //    }

                //    await SoundPlayer_Play_CallFail();

                //    await Call_Remote_OnReplyByMessageType(
                //            SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_CallReplyByOfflineMessage,
                //            "",
                //            "");

                //    //CallWindow = "close";


                //}








            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private async void imgBtn_CallMute_Voice_Clicked(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async void imgBtn_CallEndClose_Voice_Clicked(object sender, EventArgs e)
        {
            try
            {


                _ = Task.Run(async () =>
                {
                    await webViewCall.EvaluateJavaScriptAsync("stop()");

                }).ConfigureAwait(false);



                _=  Task.Run(async () =>
                {

                    string skt_Message = _iCallModel.CallTokenID + "-" +  _iCallModel.GroupTokenID + "-" + _iOwnerModel.OwnerUserTokenID + "-" + _iOwnerModel.OwnerMobileNumberTokenID + "-"+ SRoofingEnum_Socket_Call.SRoofingSocket_Call_EndTime + ",0x0x0x";

                    await Send(client, skt_Message, CancellationToken.None);





                    await SRoofing_ScreenCallShowMessageManager
                      .ScreenCallShowMessage_New_Event_Message_ByScreenCallShowID(

                App.Current,
                App.iAccountType,
                _iOwnerModel,
      _iCallModel.iRemoteModel,
          SRoofing_TimeManager.Time_GenerateToken(),
       _iCallModel.CallTokenID,
        _iCallModel.GroupTokenID,
         _iCallModel.GroupTokenID,
   _iCallModel.iRemoteModel.OwnerUserTokenID,
        _iCallModel.iRemoteModel.OwnerMobileNumberTokenID,
          "0",
          "0",
           SRoofingEnum_Call_Code.CallCode_Voice,
          SRoofingEnum_Call_Type.CallType_Voice,
          _iCallModel.CallDirection,
          SRoofingEnum_Call_State.CallState_ENDTIME,
          "0",
          "0",
          "1");

                })
                    .ConfigureAwait(false);





                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    CallWindow = "close";


                    await Navigation.PopAsync();

                    // Code to run on the main thread

                });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private async void imgBtn_CallCamera_Voice_Clicked(object sender, EventArgs e)
        {
            try
            {

                await ShowView(ll_SplashBG, ll_ActionVideo);
                await ShowView(ll_ActionVoice, ll_ActionVideo);
                await ShowView(grd_CallActionVideo, grd_ToggleCallActionVideo);

                _CallType_Owner=SRoofingEnum_Call_Type.CallType_Video;
                _CallType_Remote=SRoofingEnum_Call_Type.CallType_Video;



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private async void imgBtn_CallHold_Voice_Clicked(object sender)
        {
            try
            {


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }


        private async void imgBtn_CalSpeaker_Voice_Clicked(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        async Task ShowView(Grid objHide, Grid objShow)
        {
            try
            {

                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    // Code to run on the main thread
                    if (objHide!= null)
                    {
                        if (objHide.IsVisible== true)
                        {
                            await objHide.FadeTo(0, 500);
                            objHide.IsVisible = false;
                            objHide.Opacity = 0;

                        }
                    }

                    if (objShow!= null)
                    {
                        if (objShow.IsVisible== false)
                        {
                            objShow.Opacity = 0;
                            objShow.IsVisible = true;
                            await objShow.FadeTo(1, 500);
                        }
                    }




                });
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        async void imgBtn_CallCamera_Video_Clicked(object sender, EventArgs e)
        {
            try
            {

                await ShowView(ll_ActionVideo, ll_SplashBG);
                await ShowView(ll_ActionVideo, ll_ActionVoice);

                _CallType_Owner=SRoofingEnum_Call_Type.CallType_Voice;
                _CallType_Remote=SRoofingEnum_Call_Type.CallType_Voice;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async private void imgBtn_CallEndClose_Video_Clicked(object sender, EventArgs e)
        {
            // Remove page before Edit Page
            ////this.Navigation.RemovePage ( this.Navigation.NavigationStack[ this.Navigation.NavigationStack.Count - 1  ] );
            //await Navigation.PopAsync();
            try
            {


                _ = Task.Run(async () =>
                {
                    await webViewCall.EvaluateJavaScriptAsync("stop()");

                }).ConfigureAwait(false);



                _=  Task.Run(async () =>
                {

                    string skt_Message = _iCallModel.CallTokenID + "-" +  _iCallModel.GroupTokenID + "-" + _iOwnerModel.OwnerUserTokenID + "-" + _iOwnerModel.OwnerMobileNumberTokenID + "-"+ SRoofingEnum_Socket_Call.SRoofingSocket_Call_EndTime + ",0x0x0x";

                    await Send(client, skt_Message, CancellationToken.None);


                    await SRoofing_ScreenCallShowMessageManager
                      .ScreenCallShowMessage_New_Event_Message_ByScreenCallShowID(

                App.Current,
                App.iAccountType,
                _iOwnerModel,
      _iCallModel.iRemoteModel,
          SRoofing_TimeManager.Time_GenerateToken(),
       _iCallModel.CallTokenID,
        _iCallModel.GroupTokenID,
         _iCallModel.GroupTokenID,
   _iCallModel.iRemoteModel.OwnerUserTokenID,
        _iCallModel.iRemoteModel.OwnerMobileNumberTokenID,
          "0",
          "0",
           SRoofingEnum_Call_Code.CallCode_Video,
          SRoofingEnum_Call_Type.CallType_Video,
          _iCallModel.CallDirection,
          SRoofingEnum_Call_State.CallState_ENDTIME,
          "0",
          "0",
          "1");

                })
                    .ConfigureAwait(false);





                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    CallWindow = "close";


                    await Navigation.PopAsync();

                    // Code to run on the main thread

                });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private void imgBtn_CallMute_Video_Clicked(object sender, EventArgs e)
        {

        }

        private void imgBtn_CallHold_Video_Clicked(object sender, EventArgs e)
        {

        }

        private void imgBtn_CalSpeaker_Video_Clicked(object sender, EventArgs e)
        {

        }

        private void imgBtn_CallHold_Voice_Clicked(object sender, EventArgs e)
        {

        }

        async void imgBtn_CallDecline_Clicked(object sender, EventArgs e)
        {
            try
            {

                await Call_StopCallInSound();


                await Owner_Call_DeclineWS();

                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    CallWindow = "close";


                    await Navigation.PopAsync();

                    // Code to run on the main thread

                });



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private void imgBtn_CallSwitch_Video_Clicked(object sender, EventArgs e)
        {

        }

        bool _bln_IsInitialized = false;
        private void page_CallDashboard_SizeChanged(object sender, EventArgs e)
        {
            try
            {

                if (!_bln_IsInitialized)
                {

                    var intWidth = (int)page_CallDashboard.Width;
                    SRoofing_DebugManager.Debug_ShowSystemMessage("page_CallDashboard Width== " + page_CallDashboard.Width.ToString());
                    SRoofing_DebugManager.Debug_ShowSystemMessage("page_CallDashboard WidthRequest== " + page_CallDashboard.WidthRequest.ToString());

                    grd_AvatarName_Splash.WidthRequest = intWidth / 3;
                    grd_AvatarName_Splash.HeightRequest = intWidth / 3;

                    grd_AvatarName_Drop.WidthRequest = intWidth / 3;
                    grd_AvatarName_Drop.HeightRequest = intWidth / 3;


                    grd_AvatarName_Redial.WidthRequest = intWidth / 3;
                    grd_AvatarName_Redial.HeightRequest = intWidth / 3;


                    grd_AvatarName_Ring.WidthRequest = intWidth / 3;
                    grd_AvatarName_Ring.HeightRequest = intWidth / 3;


                    grd_AvatarName_ActionVoice.WidthRequest = intWidth / 3;
                    grd_AvatarName_ActionVoice.HeightRequest = intWidth / 3;


                    //grd_AvatarName_Drop.WidthRequest =intWidth / 2;
                    //grd_AvatarName_Drop.HeightRequest = intWidth / 2;


                    frm_AvatarName_Splash.CornerRadius = intWidth / 6;

                    _bln_IsInitialized = true;

                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }





        protected override void OnDisappearing()
        {
            base.OnDisappearing();

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

        async void page_CallDashboard_Loaded(object sender, EventArgs e)
        {

            try
            {


                //get the value by `arg`

                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == page_CallDashboard");

                //await Task.Delay ( 0 );

                //////if ( !_bln_IsInitialized_Page_Landing_Dashboard )
                //////{
                //////    _bln_IsInitialized_Page_Landing_Dashboard = true;

                ////////Task.Run ( async ( ) => { await Preload ( ); } ) ;
                ////////Task.Run ( async ( ) => { await Initialize ( ); } ) ;



                //////}

                await Preload();

                await Initialize();





                CustomizeWebViewHandler();


                //////_iCurrent_CategoryModel = ( arg as SRoofingKeyValueModelManager );
                //////lblCategoryList.Text = ( arg as SRoofingKeyValueModelManager ).ItemText.ToString ( );

                //////Task.Run ( async ( ) =>
                //////{
                //////    await Initialize_Get_List_Group_ByCategoryTokenID (
                //////        _iCurrent_CategoryModel.ItemValue ,
                //////        _iCurrent_CategoryModel.ItemText ,
                //////        false );
                //////} ).Wait ( );
                //_blnIsInitialized_Popup_IsOpen = false;

                //txt_MobileNumber.Text = "+" + ( arg as SRoofingKeyValueModelManager ).CountryMobileCode;// (arg as Employee).m
                // txt_MobileNumber.IsEnabled = true;
                //txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;
                //txt_MobileNumber.Focus();

                //lbl_SignUp.IsEnabled = true;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }
        }


        private void page_CallDashboard_Unloaded(object sender, EventArgs e)
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


        #region Owner_Call

        string _iMessageTokenID_Offer = "0";
        public async Task Owner_Call_OfferWS()
        {

            try
            {

                _= Task.Run(async () =>
                 {

                     _iMessageTokenID_Offer = SRoofing_TimeManager.Time_GenerateToken();

                     await SRoofing_ScreenCallShowMessageManager.ScreenCallShowMessage_Send_OfferMessageWS(

                                             App.Current,
                                             App.iAccountType,
                                             _iOwnerModel,

                         _iMessageTokenID_Offer,
                   _iCallModel.CallTokenID,
                          _iCallModel.GroupTokenID,
                            _iCallModel.GroupTokenID,
                           _iCallModel.RemoteUserID,
                       _iCallModel.RemoteMobileNumberID);


                 }).ConfigureAwait(false);

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }

        }



        public async Task Owner_Call_DropWS()
        {

            try
            {

                _=  Task.Run(async () =>
                {

                    await SRoofing_ScreenCallShowMessageManager
                      .ScreenCallShowMessage_New_Event_Message_ByScreenCallShowID(

                App.Current,
                App.iAccountType,
                _iOwnerModel,
      _iCallModel.iRemoteModel,
          SRoofing_TimeManager.Time_GenerateToken(),
       _iCallModel.CallTokenID,
        _iCallModel.GroupTokenID,
         _iCallModel.GroupTokenID,
   _iCallModel.iRemoteModel.OwnerUserTokenID,
        _iCallModel.iRemoteModel.OwnerMobileNumberTokenID,
          "0",
          "0",
           SRoofingEnum_Call_Code.CallCode_Voice,
          SRoofingEnum_Call_Type.CallType_Voice,
          SRoofingEnum_Call_Direction.CallDirection_Out,
          SRoofingEnum_Call_State.CallState_DROP,
          "0",
          "0",
          "1");

                })
                    .ConfigureAwait(false);





                //////////////_iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                //////////////          App.Current,
                //////////////          App.iAccountType,
                //////////////          _iOwnerModel,
                //////////////          _iHistoryContactModel.RemoteUserTokenID,
                //////////////          _iHistoryContactModel.RemoteMobileNumberTokenID);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }

        }



        public async Task Owner_Call_TimeoutWS()
        {

            try
            {

                _=  Task.Run(async () =>
                {

                    await SRoofing_ScreenCallShowMessageManager
                      .ScreenCallShowMessage_New_Event_Message_ByScreenCallShowID(

                App.Current,
                App.iAccountType,
                _iOwnerModel,
      _iCallModel.iRemoteModel,
          SRoofing_TimeManager.Time_GenerateToken(),
       _iCallModel.CallTokenID,
        _iCallModel.GroupTokenID,
         _iCallModel.GroupTokenID,
   _iCallModel.iRemoteModel.OwnerUserTokenID,
        _iCallModel.iRemoteModel.OwnerMobileNumberTokenID,
          "0",
          "0",
           SRoofingEnum_Call_Code.CallCode_Voice,
          SRoofingEnum_Call_Type.CallType_Voice,
          SRoofingEnum_Call_Direction.CallDirection_Out,
          SRoofingEnum_Call_State.CallState_TIMEOUT,
          "0",
          "0",
          "1");

                })
                    .ConfigureAwait(false);





                //////////////_iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                //////////////          App.Current,
                //////////////          App.iAccountType,
                //////////////          _iOwnerModel,
                //////////////          _iHistoryContactModel.RemoteUserTokenID,
                //////////////          _iHistoryContactModel.RemoteMobileNumberTokenID);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }

        }




        public async Task Owner_Call_DeclineWS()
        {

            try
            {

                _=  Task.Run(async () =>
                {
                    string skt_Message = _iCallModel.CallTokenID + "-" +  _iCallModel.GroupTokenID + "-" + _iOwnerModel.OwnerUserTokenID + "-" + _iOwnerModel.OwnerMobileNumberTokenID + "-"+ SRoofingEnum_Socket_Call.SRoofingSocket_Call_Decline + ",0";

                    await Send(client, skt_Message, CancellationToken.None);



                    await SRoofing_ScreenCallShowMessageManager
                      .ScreenCallShowMessage_New_Event_Message_ByScreenCallShowID(

                App.Current,
                App.iAccountType,
                _iOwnerModel,
      _iCallModel.iRemoteModel,
          SRoofing_TimeManager.Time_GenerateToken(),
       _iCallModel.CallTokenID,
        _iCallModel.GroupTokenID,
         _iCallModel.GroupTokenID,
   _iCallModel.iRemoteModel.OwnerUserTokenID,
        _iCallModel.iRemoteModel.OwnerMobileNumberTokenID,
          "0",
          "0",
           SRoofingEnum_Call_Code.CallCode_Voice,
          SRoofingEnum_Call_Type.CallType_Voice,
          SRoofingEnum_Call_Direction.CallDirection_In,
          SRoofingEnum_Call_State.CallState_DECLINE,
          "0",
          "0",
          "1");

                })
                    .ConfigureAwait(false);





                //////////////_iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                //////////////          App.Current,
                //////////////          App.iAccountType,
                //////////////          _iOwnerModel,
                //////////////          _iHistoryContactModel.RemoteUserTokenID,
                //////////////          _iHistoryContactModel.RemoteMobileNumberTokenID);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }

        }



        public async Task Owner_Call_RedialWS()
        {


            try
            {



                _=  Task.Run(async () =>
                {



                })
                          .ConfigureAwait(false);





                //////////////_iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                //////////////          App.Current,
                //////////////          App.iAccountType,
                //////////////          _iOwnerModel,
                //////////////          _iHistoryContactModel.RemoteUserTokenID,
                //////////////          _iHistoryContactModel.RemoteMobileNumberTokenID);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }



        }


        public async Task Owner_Call_MuteWS()
        {


            try
            {



                _=  Task.Run(async () =>
                {



                })
                          .ConfigureAwait(false);





                //////////////_iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                //////////////          App.Current,
                //////////////          App.iAccountType,
                //////////////          _iOwnerModel,
                //////////////          _iHistoryContactModel.RemoteUserTokenID,
                //////////////          _iHistoryContactModel.RemoteMobileNumberTokenID);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }



        }


        public async Task Owner_Call_UnMuteWS()
        {


            try
            {



                _=  Task.Run(async () =>
                {



                })
                          .ConfigureAwait(false);





                //////////////_iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                //////////////          App.Current,
                //////////////          App.iAccountType,
                //////////////          _iOwnerModel,
                //////////////          _iHistoryContactModel.RemoteUserTokenID,
                //////////////          _iHistoryContactModel.RemoteMobileNumberTokenID);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }



        }



        public async Task Owner_Call_PauseVideoWS()
        {


            try
            {



                _=  Task.Run(async () =>
                {



                })
                          .ConfigureAwait(false);





                //////////////_iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                //////////////          App.Current,
                //////////////          App.iAccountType,
                //////////////          _iOwnerModel,
                //////////////          _iHistoryContactModel.RemoteUserTokenID,
                //////////////          _iHistoryContactModel.RemoteMobileNumberTokenID);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }



        }




        public async Task Owner_Call_ResumeVideoWS()
        {


            try
            {



                _=  Task.Run(async () =>
                {



                })
                          .ConfigureAwait(false);





                //////////////_iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                //////////////          App.Current,
                //////////////          App.iAccountType,
                //////////////          _iOwnerModel,
                //////////////          _iHistoryContactModel.RemoteUserTokenID,
                //////////////          _iHistoryContactModel.RemoteMobileNumberTokenID);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }



        }


        public async Task Owner_Call_EndCloseWS()
        {


            try
            {



                _=  Task.Run(async () =>
                {



                })
                          .ConfigureAwait(false);





                //////////////_iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                //////////////          App.Current,
                //////////////          App.iAccountType,
                //////////////          _iOwnerModel,
                //////////////          _iHistoryContactModel.RemoteUserTokenID,
                //////////////          _iHistoryContactModel.RemoteMobileNumberTokenID);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }



        }




        public async Task Owner_Call_ConnectWS()
        {


            try
            {

                /*

                 1- Show Run screen
                 1- Connect Webrtc

                 */



                _=  Task.Run(async () =>
                {



                })
                          .ConfigureAwait(false);





                //////////////_iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                //////////////          App.Current,
                //////////////          App.iAccountType,
                //////////////          _iOwnerModel,
                //////////////          _iHistoryContactModel.RemoteUserTokenID,
                //////////////          _iHistoryContactModel.RemoteMobileNumberTokenID);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }



        }




        public async Task Owner_Call_AnswerWS()
        {


            try
            {


                // Connect WebRTC 

                //

                //var xxx = await webViewCall.EvaluateJavaScriptAsync("callFromCSharp('" + "SHAYMAA CS 2024" + "')");

                MainThread.BeginInvokeOnMainThread(async () =>
                {


                    // Code to run on the main thread
                    webViewCall.Source="WebRTC/Source/Index.html?" +

                        "cam=" + "front" +
                        "&caltknid=" + _iCallModel.CallTokenID +
                        "&ownid=" + _iOwnerModel.OwnerUserTokenID +
                        "&ownmobid=" + _iOwnerModel.OwnerMobileNumberTokenID +
                        "&rmtid=" + _iRemoteModel.OwnerUserTokenID +
                        "&rmtmobid=" + _iRemoteModel.OwnerMobileNumberTokenID +
                        "&caltag=" + "answer" +
                        "&caldir=" + "in" +
                        "&caltyp=" + "video";




                });



                _=  Task.Run(async () =>
                {



                })
                          .ConfigureAwait(false);





                //////////////_iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                //////////////          App.Current,
                //////////////          App.iAccountType,
                //////////////          _iOwnerModel,
                //////////////          _iHistoryContactModel.RemoteUserTokenID,
                //////////////          _iHistoryContactModel.RemoteMobileNumberTokenID);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }



        }













        #endregion



        #region Remote_Call



        public async Task Remote_Call_AnswerWS()
        {


            try
            {

                CallWindow = "open";

                _CallStatus=SRoofingEnum_Call_Status.CallStatus_Approved;



                await Call_StopCallOutSound();


                await ShowView(ll_Drop, ll_ActionVoice);

                // Connect WebRTC + Dial

                //////////webViewCall.Source="WebRTC/Source/Index.html?" +

                //////////    "cam=" + "front" +
                //////////    "&caltknid=" + _iCallModel.CallTokenID +
                //////////    "&ownid=" + _iOwnerModel.OwnerUserTokenID +
                //////////    "&ownmobid=" + _iOwnerModel.OwnerMobileNumberTokenID +
                //////////    "&rmtid=" + _iRemoteModel.OwnerUserTokenID +
                //////////    "&rmtmobid=" + _iRemoteModel.OwnerMobileNumberTokenID +
                //////////    "&caltag=" + "offer" +
                //////////    "&caldir=" + "out" +
                //////////    "&caltyp=" + "video";

                MainThread.BeginInvokeOnMainThread(async () =>
                            {


                                // Code to run on the main thread

                                // Connect WebRTC + Dial

                                webViewCall.Source="WebRTC/Source/Index.html?" +

                                    "cam=" + "front" +
                                    "&caltknid=" + _iCallModel.CallTokenID +
                                    "&ownid=" + _iOwnerModel.OwnerUserTokenID +
                                    "&ownmobid=" + _iOwnerModel.OwnerMobileNumberTokenID +
                                    "&rmtid=" + _iRemoteModel.OwnerUserTokenID +
                                    "&rmtmobid=" + _iRemoteModel.OwnerMobileNumberTokenID +
                                    "&caltag=" + "offer" +
                                    "&caldir=" + "out" +
                                    "&caltyp=" + "video";



                                //webViewCall.Source="WebRTC/Source/Index.html?" +

                                //"cam=" + "front" +
                                //"&caltknid=" + "11011101" +
                                //"&ownid=" +"1101" +
                                //"&ownmobid=" + "1101x"+
                                //"&rmtid=" + "2202" +
                                //"&rmtmobid=" + "2202x" +
                                //"&caltag=" + "offer" +
                                //"&caldir=" + "out" +
                                //"&caltyp=" + "video";



                            });




                //_=  Task.Run(async () =>
                //{
                //    string skt_Message = _iCallModel.CallTokenID + "-" +  _iCallModel.GroupTokenID + "-" + _iOwnerModel.OwnerUserTokenID + "-" + _iOwnerModel.OwnerMobileNumberTokenID + "-"+ SRoofingEnum_Socket_Call.SRoofingSocket_Call_Answer_OwnerToRemote;

                //    await Send(client, skt_Message, CancellationToken.None);


                //})
                //    .ConfigureAwait(false);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }



        }



        public async Task Remote_Call_ConnectWS()
        {


            try
            {

                /*

                 1- Show Run screen
                 1- Connect Webrtc

                 */

                _=  Task.Run(async () =>
                {



                })
                          .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }



        }



        #endregion






        #region WebSocket


        //using var client = new ClientWebSocket();
        ClientWebSocket client;//= new ClientWebSocket();


        async Task Initialize_Socket()
        {
            try
            {

                _=  Task.Run(async () =>
                {


                    //_=  Task.Run(async () =>
                    //{
                    // Create a WebSocket client
                    Uri uri = new("ws://" + App.SiteDomainURL_Socket + ":5050?"
                        + "caltknid=" + _iCallModel.CallTokenID
                        + "&grpid=" + _iCallModel.GroupTokenID
                        + "&uid=" + _iOwnerModel.OwnerUserTokenID
                        + "&mobid="  + _iOwnerModel.OwnerMobileNumberTokenID
                        );

                    //Uri uri = new("ws://10.0.2.2:5050?"
                    //   + "caltknid=" + _iCallModel.CallTokenID
                    //   + "&grpid=" + _iCallModel.GroupTokenID
                    //   + "&uid=" + _iOwnerModel.OwnerUserTokenID
                    //   + "&mobid="  + _iOwnerModel.OwnerMobileNumberTokenID
                    //   );



                    client = new ClientWebSocket();


                    // Connect to the server
                    //await client.ConnectAsync(new CancellationToken());
                    await client.ConnectAsync(uri, CancellationToken.None);



                    //await Send(client, "data", stoppingToken);
                    await Receive(client, CancellationToken.None);


                    ////////////////////var receiveTask = Task.Run(async () =>
                    ////////////////////{

                    ////////////////////    var buffer = new byte[1024 * 4];
                    ////////////////////    while (true)
                    ////////////////////    {

                    ////////////////////        var result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

                    ////////////////////        if (result.MessageType == WebSocketMessageType.Close)
                    ////////////////////        {
                    ////////////////////            break;
                    ////////////////////        }

                    ////////////////////        var msg = Encoding.UTF8.GetString(buffer, 0, result.Count);

                    ////////////////////        string[ ] _arrSocketMsg = msg.Split("-");

                    ////////////////////        if (_arrSocketMsg.Length > 0)
                    ////////////////////        {

                    ////////////////////            if (_arrSocketMsg[4] ==    SRoofingEnum_Socket_Call.SRoofingSocket_Call_Busy)
                    ////////////////////            {

                    ////////////////////                await Call_StopCallOutSound();

                    ////////////////////                //if ( _hndlr_iGlobalHandler != null )
                    ////////////////////                //    {
                    ////////////////////                //    _hndlr_iGlobalHandler.removeCallbacks ( _run_SoundPlayer_CallOut );
                    ////////////////////                //    _hndlr_iGlobalHandler.removeCallbacks ( _run_Owner_Offer_TimeOut_Ring );
                    ////////////////////                //    }

                    ////////////////////                await SoundPlayer_Play_CallFail();

                    ////////////////////                await Call_Remote_OnReplyByMessageType(
                    ////////////////////                        SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_CallReplyByOfflineMessage,
                    ////////////////////                        "",
                    ////////////////////                        "");



                    ////////////////////            }

                    ////////////////////        }


                    ////////////////////        SRoofing_DebugManager.Debug_ShowSystemMessage("WebSocket-WS ::: " +  msg);
                    ////////////////////    }

                    ////////////////////}
                    ////////////////////);

                    //////////////////////.ConfigureAwait(false)

                    ////////////////////await receiveTask;



                    // Send messages to the server
                    //////////var message = "Hello from .NET MAUI";
                    //////////var bytesX = Encoding.UTF8.GetBytes(message);
                    //////////await client.SendAsync(new ArraySegment<byte>(bytesX), WebSocketMessageType.Text, true, CancellationToken.None);

                    // Close the connection
                    //////////await client.CloseAsync(WebSocketCloseStatus.NormalClosure, "Bye", CancellationToken.None);



                    //});
                    //.ConfigureAwait(false);


                })
                          .ConfigureAwait(false);





            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        private async Task Send(ClientWebSocket socket, string data, CancellationToken stoppingToken)
        {

            try
            {

                _=  Task.Run(async () =>
                {

                    await socket.SendAsync(Encoding.UTF8.GetBytes(data), WebSocketMessageType.Text, true, stoppingToken);

                })
                      .ConfigureAwait(false);

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }

        }


        private async Task Receive(ClientWebSocket socket, CancellationToken stoppingToken)
        {


            //_=  Task.Run(async () =>
            //{



            var buffer = new ArraySegment<byte>(new byte[2048]);
            while (!stoppingToken.IsCancellationRequested)
            {
                WebSocketReceiveResult result;
                using (var ms = new MemoryStream())
                {
                    do
                    {
                        result = await socket.ReceiveAsync(buffer, stoppingToken);
                        ms.Write(buffer.Array, buffer.Offset, result.Count);
                    } while (!result.EndOfMessage);

                    if (result.MessageType == WebSocketMessageType.Close)
                        break;

                    ms.Seek(0, SeekOrigin.Begin);
                    using (var reader = new StreamReader(ms, Encoding.UTF8))
                    {

                        // SRoofing_DebugManager.Debug_ShowSystemMessage("WebSocket-WS ::: " + await reader.ReadToEndAsync());


                        //string[ ] _arrSocketMsg = msg.Split("-");
                        string msg = await reader.ReadToEndAsync();


                        string[ ] _arrSocketMsg = msg.Split("-");

                        if (_arrSocketMsg.Length > 1)
                        {


                            string _socket_Code, _socket_Message;
                            string[ ] _arrSocket = _arrSocketMsg[4].Split(",");

                            _socket_Code = _arrSocket[0];
                            _socket_Message = _arrSocket[1];



                            if (_socket_Code == SRoofingEnum_Socket_Call.SRoofingSocket_Call_Busy)
                            {

                                if (_CallStatus != SRoofingEnum_Call_Status.CallStatus_NotApproved
                                    && ll_Redial.IsVisible == false)
                                {

                                    await Call_StopCallOutSound();

                                    //if ( _hndlr_iGlobalHandler != null )
                                    //    {
                                    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_SoundPlayer_CallOut );
                                    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_Owner_Offer_TimeOut_Ring );
                                    //    }

                                    await SoundPlayer_Play_CallFail();

                                    await Call_Remote_OnReplyByMessageType(
                                            SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_CallReplyByBusyMessage,
                                            "",
                                            "");


                                }

                            }


                            else if (_socket_Code == SRoofingEnum_Socket_Call.SRoofingSocket_Call_Decline)
                            {

                                if (_CallStatus != SRoofingEnum_Call_Status.CallStatus_NotApproved
                                    && ll_Redial.IsVisible == false)
                                {

                                    await Call_StopCallOutSound();

                                    //if ( _hndlr_iGlobalHandler != null )
                                    //    {
                                    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_SoundPlayer_CallOut );
                                    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_Owner_Offer_TimeOut_Ring );
                                    //    }

                                    await SoundPlayer_Play_CallFail();

                                    await Call_Remote_OnReplyByMessageType(
                                            SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_CallReplyByDeclineMessage,
                                            "",
                                            "");


                                }

                            }



                            else if (_socket_Code == SRoofingEnum_Socket_Call.SRoofingSocket_Call_Answer_RemoteToOwner)
                            {

                                await Remote_Call_AnswerWS();



                                //////////if (_CallStatus != SRoofingEnum_Call_Status.CallStatus_NotApproved
                                //////////    && ll_Redial.IsVisible == false)
                                //////////{

                                //////////    await Call_StopCallOutSound();

                                //////////    //if ( _hndlr_iGlobalHandler != null )
                                //////////    //    {
                                //////////    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_SoundPlayer_CallOut );
                                //////////    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_Owner_Offer_TimeOut_Ring );
                                //////////    //    }

                                //////////    await SoundPlayer_Play_CallFail();

                                //////////    await Call_Remote_OnReplyByMessageType(
                                //////////            SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_CallReplyByDeclineMessage,
                                //////////            "",
                                //////////            "");


                                //////////}

                            }



                            else if (_socket_Code == SRoofingEnum_Socket_Call.SRoofingSocket_Call_Answer_OwnerToRemote)
                            {

                                // Connect WebRTC + Dial


                                //////////if (_CallStatus != SRoofingEnum_Call_Status.CallStatus_NotApproved
                                //////////    && ll_Redial.IsVisible == false)
                                //////////{

                                //////////    await Call_StopCallOutSound();

                                //////////    //if ( _hndlr_iGlobalHandler != null )
                                //////////    //    {
                                //////////    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_SoundPlayer_CallOut );
                                //////////    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_Owner_Offer_TimeOut_Ring );
                                //////////    //    }

                                //////////    await SoundPlayer_Play_CallFail();

                                //////////    await Call_Remote_OnReplyByMessageType(
                                //////////            SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_CallReplyByDeclineMessage,
                                //////////            "",
                                //////////            "");


                                //////////}

                            }



                            else if (_socket_Code == SRoofingEnum_Socket_Call.SRoofingSocket_Call_EndTime)
                            {


                                try
                                {

                                    _ = Task.Run(async () =>
                                                        {
                                                            await webViewCall.EvaluateJavaScriptAsync("stop()");

                                                        }).ConfigureAwait(false);


                                    MainThread.BeginInvokeOnMainThread(async () =>
                                  {

                                      await ShowView(ll_ActionVoice, ll_SplashBG);
                                      await ShowView(ll_ActionVideo, ll_Splash);
                                      await ShowView(null, ll_Redial);
                                      //await ShowView(ll_Drop, ll_Redial);

                                      await Call_PlayCallEndSound();

                                      await Call_Remote_OnReplyByMessageType(
                                                SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_CallEndDurationMessage,
                                                "",
                                                _socket_Message);


                                  });





                                }
                                catch (Exception ex)
                                {
                                    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                                    return;
                                }




                                // Connect WebRTC + Dial


                                //////////if (_CallStatus != SRoofingEnum_Call_Status.CallStatus_NotApproved
                                //////////    && ll_Redial.IsVisible == false)
                                //////////{

                                //////////    await Call_StopCallOutSound();

                                //////////    //if ( _hndlr_iGlobalHandler != null )
                                //////////    //    {
                                //////////    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_SoundPlayer_CallOut );
                                //////////    //    _hndlr_iGlobalHandler.removeCallbacks ( _run_Owner_Offer_TimeOut_Ring );
                                //////////    //    }

                                //////////    await SoundPlayer_Play_CallFail();

                                //////////    await Call_Remote_OnReplyByMessageType(
                                //////////            SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_CallReplyByDeclineMessage,
                                //////////            "",
                                //////////            "");


                                //////////}

                            }





                        }


                        SRoofing_DebugManager.Debug_ShowSystemMessage("WebSocket-WS ::: " +  msg);
                    }







                }
            };

            //})
            //          .ConfigureAwait(false);





        }







        #endregion





        #region Call_Timer

        async Task CallTimer_Start()
        {


            try
            {


                //var xxx = await webViewCall.EvaluateJavaScriptAsync("callFromCSharp('" + "SHAYMAA CS 2024" + "')");

                // Create a stopwatch instance
                var stopwatch = new Stopwatch();

                // Create a timer instance
                var timer = Application.Current.Dispatcher.CreateTimer();

                // Set the timer interval to one second
                timer.Interval = TimeSpan.FromSeconds(1);

                // Subscribe to the Tick event
                timer.Tick += (s, e) =>
                {
                    // Update the label text with the elapsed time
                    // Use MainThread.BeginInvokeOnMainThread to ensure UI updates are done on the UI thread
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        // lbl_Result.Text = stopwatch.Elapsed.ToString("hh\\:mm\\:ss");
                    });
                };

                // Start the stopwatch and the timer
                stopwatch.Start();
                timer.Start();


                ////////////// Create a timer instance
                ////////////var timer = Application.Current!.Dispatcher.CreateTimer();

                ////////////// Set the timer interval to one second
                ////////////timer.Interval = TimeSpan.FromSeconds(1);

                ////////////// Subscribe to the Tick event
                ////////////timer.Tick += (s, e) =>
                ////////////{
                ////////////    // Update the label text with the current time
                ////////////    // Use MainThread.BeginInvokeOnMainThread to ensure UI updates are done on the UI thread
                ////////////    MainThread.BeginInvokeOnMainThread(() =>
                ////////////    {
                ////////////        lbl_Result.Text = DateTime.Now.ToString("h:mm:ss tt");
                ////////////    });
                ////////////};

                ////////////// Start the timer
                ////////////timer.Start();



                //await webViewCall.EvaluateJavaScriptAsync();


                //////////if (App.client.State == WebSocketState.Open)
                //////////{
                //////////    //Debug.Log("Input message ('exit' to exit): ");

                //////////    ArraySegment<byte> bytesToSend = new ArraySegment<byte>(
                //////////        Encoding.UTF8.GetBytes("hello fury from unity")
                //////////    );
                //////////    await App.client.SendAsync(
                //////////        bytesToSend,
                //////////        WebSocketMessageType.Text,
                //////////        true,
                //////////        CancellationToken.None
                //////////    );
                //////////}

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage("WebSocket-WS ::: "  + ex.Message);
            }



        }



        async Task CallTimer_Stop()
        {


            try
            {


                //var xxx = await webViewCall.EvaluateJavaScriptAsync("callFromCSharp('" + "SHAYMAA CS 2024" + "')");

                // Create a stopwatch instance
                var stopwatch = new Stopwatch();

                // Create a timer instance
                var timer = Application.Current.Dispatcher.CreateTimer();

                // Set the timer interval to one second
                timer.Interval = TimeSpan.FromSeconds(1);

                // Subscribe to the Tick event
                timer.Tick += (s, e) =>
                {
                    // Update the label text with the elapsed time
                    // Use MainThread.BeginInvokeOnMainThread to ensure UI updates are done on the UI thread
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        // lbl_Result.Text = stopwatch.Elapsed.ToString("hh\\:mm\\:ss");
                    });
                };

                // Start the stopwatch and the timer
                stopwatch.Start();
                timer.Start();


                ////////////// Create a timer instance
                ////////////var timer = Application.Current!.Dispatcher.CreateTimer();

                ////////////// Set the timer interval to one second
                ////////////timer.Interval = TimeSpan.FromSeconds(1);

                ////////////// Subscribe to the Tick event
                ////////////timer.Tick += (s, e) =>
                ////////////{
                ////////////    // Update the label text with the current time
                ////////////    // Use MainThread.BeginInvokeOnMainThread to ensure UI updates are done on the UI thread
                ////////////    MainThread.BeginInvokeOnMainThread(() =>
                ////////////    {
                ////////////        lbl_Result.Text = DateTime.Now.ToString("h:mm:ss tt");
                ////////////    });
                ////////////};

                ////////////// Start the timer
                ////////////timer.Start();



                //await webViewCall.EvaluateJavaScriptAsync();


                //////////if (App.client.State == WebSocketState.Open)
                //////////{
                //////////    //Debug.Log("Input message ('exit' to exit): ");

                //////////    ArraySegment<byte> bytesToSend = new ArraySegment<byte>(
                //////////        Encoding.UTF8.GetBytes("hello fury from unity")
                //////////    );
                //////////    await App.client.SendAsync(
                //////////        bytesToSend,
                //////////        WebSocketMessageType.Text,
                //////////        true,
                //////////        CancellationToken.None
                //////////    );
                //////////}

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage("WebSocket-WS ::: "  + ex.Message);
            }



        }




        #endregion



        #region WebView



        void CustomizeWebViewHandler()
        {
#if ANDROID

            Microsoft.Maui.Handlers.WebViewHandler.Mapper.Add("WebChromeClientXXX", (handler, view) =>
            {

                //Android.Webkit.WebView.SetWebContentsDebuggingEnabled(true);

                //handler.PlatformView.Settings.UseWideViewPort= true;
                //handler.PlatformView.Settings.JavaScriptEnabled= true;
                //handler.PlatformView.Settings.JavaScriptCanOpenWindowsAutomatically= true;
                //handler.PlatformView.Settings.MediaPlaybackRequiresUserGesture= false;


                //handler.PlatformView.Settings.AllowContentAccess=true;
                //handler.PlatformView.Settings.AllowFileAccess=true;
                //handler.PlatformView.Settings.SetAppCacheEnabled(true);
                //handler.PlatformView.Settings.DomStorageEnabled=true;


                //handler.PlatformView.SetWebViewClient(new CustomWebViewClient());
                //handler.PlatformView.SetWebChromeClient(new CustomWebChromeClient());


                ////////////////////////////////////

                //////////handler.PlatformView.SetWebViewClient(new JavascriptWebViewClient($"javascript: {JavascriptFunction}"));
                handler.PlatformView.AddJavascriptInterface(new JsBridge(), "jsBridge");

            });
#elif WINDOWS
#elif IOS
#endif
        }





        // Define a C# method that you want to invoke from JavaScript
        public static void MyCSharpMethod()
        {
            // Your C# code here
            SRoofing_DebugManager.Debug_ShowSystemMessage("MyCSharpMethod-WS ::: ");
              DisplayAlert("titleX", "msg-MyCSharpMethod=invokeTimer", "OK");
        }






#if ANDROID


        public class JsBridge : Java.Lang.Object
        {
            //readonly WeakReference<HybridWebViewRenderer> HybridWebViewMainRenderer;

            //public JsBridge(HybridWebViewRenderer hybridRenderer)
            //{
            //    HybridWebViewMainRenderer = new WeakReference<HybridWebViewRenderer>(hybridRenderer);
            //}

            [JavascriptInterface]
            [Export("invokeAction")]
            //[Export()]
            public void InvokeAction(string data)
            {

                MainThread.BeginInvokeOnMainThread(() =>
                {

                    //Toast.MakeText(Android.App.Application.Context, "InvokeAction :: " + data, ToastLength.Long).Show();

                    MyCSharpMethod();

                    //DisplayAlert("titleX", "msg-JsBridge", "OK");

                    // Code to run on the main thread

                    SRoofing_DebugManager.Debug_ShowSystemMessage("JavascriptInterface :: " + data);

                });
                //if (HybridWebViewMainRenderer != null && HybridWebViewMainRenderer.TryGetTarget(out var hybridRenderer))
                //{
                //    ((UCView_HybridWebView)hybridRenderer.Element).InvokeAction(data);
                //}
            }
     
        
        
        
        
        
            [JavascriptInterface]
            [Export("invokeTimer")]
            //[Export()]
            public void InvokeTimer(string data)
            {

                MainThread.BeginInvokeOnMainThread(() =>
                {

                    //Toast.MakeText(Android.App.Application.Context, "InvokeAction :: " + data, ToastLength.Long).Show();

                    MyCSharpMethod();

                    //DisplayAlert("titleX", "msg-JsBridge", "OK");

                    // Code to run on the main thread

                    SRoofing_DebugManager.Debug_ShowSystemMessage("JavascriptInterface :: invokeTimer " + data);

                });
                //if (HybridWebViewMainRenderer != null && HybridWebViewMainRenderer.TryGetTarget(out var hybridRenderer))
                //{
                //    ((UCView_HybridWebView)hybridRenderer.Element).InvokeAction(data);
                //}
            }
     
        
        
        
        
        
        
        
        
        
        
        }



#elif IOS

        public class JsBridge
        {

        }

#endif







        #endregion

        async void imgBtn_ToggleCallActionVideo_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (grd_CallActionVideo.IsVisible== true)
                {
                    await ShowView(grd_CallActionVideo, null);


                }
                else
                {
                    await ShowView(null, grd_CallActionVideo);


                }

                _CallType_Owner=SRoofingEnum_Call_Type.CallType_Video;
                _CallType_Remote=SRoofingEnum_Call_Type.CallType_Video;



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }
    }
}