using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

using Plugin.Maui.Audio;

using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Account;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.CameraView;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Document;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Image;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Text;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Video;

using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Gallery.Chat;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
 
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Contact;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Chatter;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;

// //[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Page_ScreenChatShow_Dashboard : ContentPage
{


    public SRoofingSpeechModel _iSpeechModel { get; set; } = new SRoofingSpeechModel();

    public SRoofingSpeechModel _iSpeechModel_Incoming;
    public SRoofingSpeechModel _iSpeechModel_Outgoing;


    public SRoofingLanguageTranslateModel _iLanguageModel { get; set; } //= new SRoofingLanguageTranslateModel();


    bool _blnIsInitialized_BroadcastReceiver = false;
    bool _bln_IsInitialized_Page_ScreenChatShow_Dashboard = false;
    public SRoofingApplicationUtilityModelManager _iApplicationUtilityModel;


    public SRoofingUserOwnerModelManager _iOwnerModel { get; set; }

    public SRoofingScreenChatShowScreenModel _iChatScreenModel { get; set; }


    public SRoofingUserSettingModelManager _iSettingModel { get; set; } //= new SRoofingUserSettingModelManager();

    public string _iOwner_LanguageCode_OUT { get; set; } = "en";
    public string _iOwner_LanguageCode_IN { get; set; } = "en";










    public Page_ScreenChatShow_Dashboard()
    {
        InitializeComponent();

        //Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific
        //    .Application.SetWindowSoftInputModeAdjust(
        //    this.Window, WindowSoftInputModeAdjust.Resize);


        try
        {


            //txt_MessageText.ReturnType = ReturnType.Send;

        }
        catch (Exception ex)
        {

            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;

        }








        BindingContext = this;






        //            Task.Run ( async ( ) =>
        //{
        //    await Initialize ( );
        //} ).Wait ( );

    }




    #region MyRegion






    public async Task Initialize()
    {

        try
        {

            _iApplicationUtilityModel = await SRoofingSync_ApplicationUtility_Manager
                          .Sync_Speech_Get_ApplicationUtility_ByAccountType(App.Current);

            _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);


            _iOwnerModel = new SRoofingUserOwnerModelManager();
            _iOwnerModel = await SRoofingSync_User_OwnerManager.Sync_User_Owner_Get_UserModel(App.Current);


            _iSettingModel = await SRoofingSync_UserSetting_Manager.Sync_Setting_Get_Setting_ByUserID(
            App.Current, _iOwnerModel);

            _iSpeechModel_Incoming = await SRoofingSync_Speech_Manager.Sync_Speech_Get_Incoming_ByUserID(App.Current, _iOwnerModel);
            _iSpeechModel_Outgoing = await SRoofingSync_Speech_Manager.Sync_Speech_Get_Outgoing_ByUserID(App.Current, _iOwnerModel);


            // _iOwner_Outgoing_LanguageCode = "en";


            _iOwner_LanguageCode_IN = _iSpeechModel_Incoming.LanguageCode.ToLower();
            _iOwner_LanguageCode_OUT = _iSpeechModel_Outgoing.LanguageCode.ToLower();





            _iChatScreenModel = new SRoofingScreenChatShowScreenModel();
            _iChatScreenModel = await SRoofingSync_ScreenChatShowManager.Sync_ScreenChatShow_Get_ChatModel(
                 App.Current,
                 App.iAccountType,
                 _iOwnerModel);

            MainThread.BeginInvokeOnMainThread(async () =>
   {



       //lbl_GroupTokenID.Text = _iChatScreenModel.GroupTokenID;


       img_Thum.Source = _iSettingModel.Chat_Background_ImageURL;


       txt_MessageText.Placeholder = _iLanguageModel.lblText_StartTypingHere;

       if (_iLanguageModel.LanguageCode== "ar")
       {
           txt_MessageText.HorizontalTextAlignment= TextAlignment.End;
       }
       else
       {
           txt_MessageText.HorizontalTextAlignment= TextAlignment.Start;

       }

       //await swipeMeLeft.TranslateTo(-_iApplicationUtilityModel.Screen_WidthPixel, 0, 250, Easing.CubicOut);
       //await swipeMeRight.TranslateTo(_iApplicationUtilityModel.Screen_WidthPixel, 0, 250, Easing.CubicOut);

       //txt_MessageText.ReturnType = ReturnType.Send;


       // grd_LeftContent.WidthRequest = _iApplicationUtilityModel.Screen_WidthPixel;//.iGallery_iMedia_Width;
       //grd_RightContent.WidthRequest = _iApplicationUtilityModel.Screen_WidthPixel;//.iGallery_iMedia_Width;


       await iSnackBar_GalleryOption.OpenLoader(this, "", _iLanguageModel);

   });

            await Initialize_Chat_Window();


            //await vw_GroupList.Preload(this, _iApplicationUtilityModel);
            //await vw_ChattersList.Preload(this);
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }





    async Task Initialize_Chat_Window_FirstLoad()
    {

        try
        {

            //_iApplicationUtilityModel = await SRoofingSync_ApplicationUtility_Manager
            //                  .Sync_Speech_Get_ApplicationUtility_ByAccountType ( App.Current );

            //_iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All ( App.Current );
            ////   await Task.Delay ( 500 );

            ////_iOwnerModel = new SRoofingUserOwnerModelManager ( );
            ////_iOwnerModel = await SRoofingSync_User_OwnerManager.Sync_User_Owner_Get_UserModel ( App.Current );

            //_iSettingModel = await SRoofingSync_UserSetting_Manager.Sync_Setting_Get_Setting_ByUserID (
            //    App.Current , _iOwnerModel );

            //_iSpeechModel_Incoming = await SRoofingSync_Speech_Manager.Sync_Speech_Get_Incoming_ByUserID ( App.Current , _iOwnerModel );
            //_iSpeechModel_Outgoing = await SRoofingSync_Speech_Manager.Sync_Speech_Get_Outgoing_ByUserID ( App.Current , _iOwnerModel );


            //// _iOwner_Outgoing_LanguageCode = "en";


            //_iOwner_LanguageCode_IN = _iSpeechModel_Incoming.LanguageCode.ToLower ( );
            //_iOwner_LanguageCode_OUT = _iSpeechModel_Outgoing.LanguageCode.ToLower ( );

            //_iChatScreenModel = iChatScreenModel;
            //_iGroupTokenID = _iChatScreenModel.GroupTokenID;

            //// int xxx = ( _iApplicationUtilityModel.Screen_WidthPixel / 60 ) - 10;
            ////  int xxx = ( int ) ( ( ScreenWidth / 60 ) - 10 );

            ////MainThread.BeginInvokeOnMainThread ( async ( ) =>
            ////{
            //// Code to run on the main thread
            //// widget_Emotion.SpanGridEmotion = ( _iApplicationUtilityModel.Screen_WidthPixel / 50 ) - 2;

            //////grd_LeftContent.WidthRequest = _iApplicationUtilityModel.iGallery_iMedia_Width;
            //////grd_RightContent.WidthRequest = _iApplicationUtilityModel.iGallery_iMedia_Width;


            //              MainThread.BeginInvokeOnMainThread ( async ( ) =>
            //              {


            //              txt_MessageText.Placeholder = _iLanguageModel.lblText_StartTypingHere;

            //img_Thum.Source = _iSettingModel.Chat_Background_ImageURL;

            //                  await iSnackBar_GalleryOption.OpenLoader ( this , "" , _iLanguageModel );

            //              } );

            await Initialize_Chat_Window();



            // IsNewMessage
            _ = Task.Run(async () =>
            {
                // some long running task
                await IsNewMessage();
            }).ConfigureAwait(false);


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }




    public async Task Initialize_Chat_Window()
    {

        try
        {

            //_iChatScreenModel = new SRoofingScreenChatShowScreenModel ( );
            //_iChatScreenModel = await SRoofingSync_ScreenChatShowManager.Sync_ScreenChatShow_Get_ChatModel (
            //     App.Current ,
            //     App.iAccountType ,
            //     _iOwnerModel );


            MainThread.BeginInvokeOnMainThread(() =>
            {
                // Code to run on the main thread
                if (_iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE)
                {

                    lbl_Chat_AvatarName.Text = _iChatScreenModel.AvatarName;
                    lbl_Chat_UserName.Text = _iChatScreenModel.FullName;
                    lbl_Chat_MobileNumber.Text = _iChatScreenModel.MobileNumberE164;
                    //   img_Toggle_CallChatter.IsVisible = true;
                    img_Toggle_CallChatter.Source = "img_theme_chat_call_voice.png";
                    //grd_RightContent.WidthRequest = 0;
                    //img_SwipeLeft.IsVisible = false;

                    //////////vw_ChattersList.IsVisible = false;
                    ////vw_Page_Account_Chat.IsVisible = true;


                }
                else if (_iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_GROUP)
                {

                    lbl_Chat_AvatarName.Text = _iChatScreenModel.AvatarName;
                    lbl_Chat_UserName.Text = _iChatScreenModel.GroupTitle;
                    lbl_Chat_MobileNumber.Text = null;


                    img_Toggle_CallChatter.Source = "img_command_top_group.png";



                }


            });


            await Task.Delay(500);

            _ = Task.Run(async () =>
                {

                    arr_ChatMessageList_Temp = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();

                    arr_ChatMessageList_Temp = await App.Database.Get_List_Chat_Message_ByGroupTokenID(
                        _iChatScreenModel.GroupTokenID);


                    if (arr_ChatMessageList_Temp == null)
                    {
                        arr_ChatMessageList_Temp = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();
                    }

                    await Task.Delay(100);

                    await ShowList();

                })
              .ConfigureAwait(false);




            // IsNewMessage
            _ = Task.Run(async () =>
            {
                // some long running task
                await Task.Delay(500);

                await IsNewMessage();

            }).ConfigureAwait(false);


            MainThread.BeginInvokeOnMainThread(async () =>
            {

                //await swipeMeLeft.TranslateTo(-_iApplicationUtilityModel.Screen_WidthPixel, 0, 250, Easing.CubicOut);
                //await swipeMeRight.TranslateTo(_iApplicationUtilityModel.Screen_WidthPixel, 0, 250, Easing.CubicOut);



                //await MenuCloser();
            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }







    #endregion




    #region Check_IsNewMessage

    async Task IsNewMessage()
    {


        try
        {

            bool bln_IsNewMessage = await SRoofing_ScreenChatShowTextMessageManager
                .ScreenChatShowMessage_Check_IsNew_Message_True_ByOwnerUserTokenID(
               App.Current, App.iAccountType, _iOwnerModel);

            MainThread.BeginInvokeOnMainThread(() =>
            {
                if (bln_IsNewMessage)
                {
                    img_NewNessage.IsVisible = true;
                }
                else
                {
                    img_NewNessage.IsVisible = false;

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








    #region Back-Button


    protected override bool OnBackButtonPressed()
    {

        try
        {

  //          if (_bln_IsDrawerOpen)
  //          {
  //              MainThread.BeginInvokeOnMainThread(async () =>
  //{
  //    // Code to run on the main thread
  //    swipe_ChatDashboard.Close();
  //    _bln_IsDrawerOpen= false;
  //});
  //              return true;
  //          }


            //if (_iSwipe_ViewCode == "left_open")
            //{
            //    MainThread.BeginInvokeOnMainThread(async () =>
            //    {
            //        // Code to run on the main thread
            //        await swipeMeLeft.TranslateTo(-DeviceDisplay.Current.MainDisplayInfo.Width, 0, 250, Easing.CubicOut);
            //        _iSwipe_ViewCode = "0";
            //    });

            //    return true;
            //}

            //else  if (_iSwipe_ViewCode == "right_open")
            //{
            //    MainThread.BeginInvokeOnMainThread(async () =>
            //    {
            //        // Code to run on the main thread
            //        await swipeMeRight.TranslateTo(DeviceDisplay.Current.MainDisplayInfo.Width, 0, 250, Easing.CubicOut);
            //        _iSwipe_ViewCode = "0";
            //    });

            //    return true;
            //}





            //if (sideMenuView.State == SideMenuState.LeftMenuShown)
            //{
            //    sideMenuView.State = SideMenuState.MainViewShown;
            //    return true;
            //}

            //else if (sideMenuView.State == SideMenuState.RightMenuShown)
            //{

            //    sideMenuView.State = SideMenuState.MainViewShown;

            //    return true;
            //}






            return false;
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return false;
        }

        //return base.OnBackButtonPressed ( );
    }


    #endregion








    #region SoundPlayer

    //ISimpleAudioPlayer player;

    readonly IAudioManager audioManager;

    IAudioPlayer player;



    async Task Call_Play_Owner_Out_ChatMessage()
    {

        try
        {

            await Task.Delay(500);

            if (player == null)
                //player = player;

                player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(_iSettingModel.Sound_Chat_Outgoing));

            if (player.IsPlaying)
                player.Stop();

            //player.Load ( _iSettingModel.Sound_Chat_Outgoing );
            //player.Load ( "snd_chat_out_1.mp3" );
            await Task.Delay(500);
            player.Loop = false;
            player.Play();



            // player.Loop = true;


            //if ( objSRoofingSound_PlayerManager == null )
            //    {
            //    objSRoofingSound_PlayerManager = new SRoofingSound_PlayerManager ( _iActivity );
            //    }

            //if ( SRoofingSound_PlayerManager.mp != null )
            //    {
            //    objSRoofingSound_PlayerManager.SoundPlayer_Stop_AllSound ( _iActivity );
            //    }
            //objSRoofingSound_PlayerManager.SoundPlayer_Play_CallEnd ( _iActivity ,
            //                                                      _iActivity._iSettingModel ,
            //                                                      _iActivity._iOwnerModel );

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        }
    }


    async Task Call_Play_Owner_In_ChatMessage()
    {

        try
        {

            await Task.Delay(500);

            if (player == null)
                //player = player;

                player = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(_iSettingModel.Sound_Chat_Incoming));


            if (player.IsPlaying)
                player.Stop();

            //player.Load ( _iSettingModel.Sound_Chat_Incoming );
            //player.Load ( "snd_chat_in_1.mp3" );
            await Task.Delay(500);
            player.Loop = false;
            player.Play();



            // player.Loop = true;


            //if ( objSRoofingSound_PlayerManager == null )
            //    {
            //    objSRoofingSound_PlayerManager = new SRoofingSound_PlayerManager ( _iActivity );
            //    }

            //if ( SRoofingSound_PlayerManager.mp != null )
            //    {
            //    objSRoofingSound_PlayerManager.SoundPlayer_Stop_AllSound ( _iActivity );
            //    }
            //objSRoofingSound_PlayerManager.SoundPlayer_Play_CallEnd ( _iActivity ,
            //                                                      _iActivity._iSettingModel ,
            //                                                      _iActivity._iOwnerModel );

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        }
    }

    #endregion



    #region Sidebar


    private async void sideMenuView_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        ////////////////////try
        ////////////////////{
        ////////////////////    if (sender is SideMenuView sideMenuView && e.PropertyName == nameof(sideMenuView.State))
        ////////////////////    {
        ////////////////////        if (sideMenuView.State == SideMenuState.LeftMenuShown)
        ////////////////////        {
        ////////////////////            // The menu is opened.
        ////////////////////            SRoofing_DebugManager.Debug_ShowSystemMessage("************************** LeftMenuShown");
        ////////////////////            await MenuLeft_Initialize();

        ////////////////////        }
        ////////////////////        else if (sideMenuView.State == SideMenuState.RightMenuShown)
        ////////////////////        {
        ////////////////////            // The menu is opened.
        ////////////////////            SRoofing_DebugManager.Debug_ShowSystemMessage("************************** RightMenuShown");
        ////////////////////            await MenuRight_Initialize();
        ////////////////////        }
        ////////////////////        else if (sideMenuView.State == SideMenuState.MainViewShown)
        ////////////////////        {
        ////////////////////            // The menu is closed.
        ////////////////////            SRoofing_DebugManager.Debug_ShowSystemMessage("************************** MainViewShown");
        ////////////////////            await MenuMain_Initialize();
        ////////////////////        }

        ////////////////////    }

        ////////////////////}
        ////////////////////catch (Exception ex)
        ////////////////////{
        ////////////////////    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        ////////////////////    return;
        ////////////////////}
    }









    public async Task MenuCloser()
    {

        //try
        //{
        //    MainThread.BeginInvokeOnMainThread(() =>
        //    {

        //        swipe_ChatDashboard.Close();
        //        _bln_IsDrawerOpen= false;
        //        //swipe_ChatDashboard.IsEnabled=true;


        //        //if (sideMenuView.State == SideMenuState.LeftMenuShown)
        //        //{
        //        //    sideMenuView.State = SideMenuState.MainViewShown;
        //        //    //return true;
        //        //}

        //        //else if (sideMenuView.State == SideMenuState.RightMenuShown)
        //        //{

        //        //    sideMenuView.State = SideMenuState.MainViewShown;

        //        //    //return true;
        //        //}



        //    });



        //}
        //catch (Exception ex)
        //{
        //    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //    return;
        //}
    }



    async Task MenuLeft_Initialize()
    {

        //try
        //{

        //    await Task.Delay(500);

        //    _ = Task.Run(async () =>
        //    {


        //        await vw_GroupList.MenuOpener_MenuLeft();


        //    }).ConfigureAwait(false);//.Wait ( );



        //}
        //catch (Exception ex)
        //{
        //    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //    return;
        //}
    }


    async Task MenuRight_Initialize()
    {

        try
        {

            await Task.Delay(500);


            _ = Task.Run(async () =>
            {


                //////////////////////await vw_ChattersList.Initialize();

            }).ConfigureAwait(false);//.Wait ( );


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }


    async Task MenuMain_Initialize()
    {

        try
        {

            await Task.Delay(500);

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }



    #endregion








    #region Gallery

    bool _bln_IsOnProgress_PickerImage;


    public async Task Picker_ShareMedia(
        string iMediaCode,
        string iTargetCode,
        SRoofingScreenChatShowMessageModelManager iScreenChatShowMessageModel)
    {

        try
        {


            await SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
                                             Navigation,
                                         typeof(Picker_Chatter_Dashboard),
                                         new Picker_Chatter_Dashboard(
                                                                   _iApplicationUtilityModel,
                                                                   _iSettingModel,
                                                                   _iLanguageModel,
                                                                      _iOwnerModel,
                                                                  _iSpeechModel,
                                                                     _iOwner_LanguageCode_IN,
                                                                 _iOwner_LanguageCode_OUT,
                                                              _iChatScreenModel,
                                                              "chat_share",
                                           iScreenChatShowMessageModel), false, true);

            //var currentPage = Microsoft.Maui.Controls.Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

            //if (currentPage != null)
            //{

            //    if (currentPage.GetType() != typeof(Picker_Group_Dashboard))
            //    {

            //        await Navigation.PushModalAsync(new Picker_Group_Dashboard(
            //      _iApplicationUtilityModel,
            //      _iSettingModel,
            //      _iSpeechModel,
            //          _iLanguageModel,
            //         _iOwnerModel,
            //     _iOwner_LanguageCode_IN,
            //        _iOwner_LanguageCode_OUT,
            //       _iChatScreenModel,
            //       iScreenChatShowMessageModel));



            //    }
            //}
            //else
            //{

            //    await Navigation.PushModalAsync(new Picker_Group_Dashboard(
            //          _iApplicationUtilityModel,
            //      _iSettingModel,
            //      _iSpeechModel,
            //          _iLanguageModel,
            //         _iOwnerModel,
            //         _iOwner_LanguageCode_IN,
            //           _iOwner_LanguageCode_OUT,
            //          _iChatScreenModel,
            //          iScreenChatShowMessageModel));



            //}





        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }


    async Task GalleryPicker_Pick_Image()
    {

        //////////         try
        //////////         {


        //////////             _bln_IsOnProgress_PickerImage = true;

        //////////             string str_FilePath = null;


        //////////             FileResult result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
        //////////             {
        //////////                 Title = _iLanguageModel.lblText_Picker_Image_Message
        //////////             });

        //////////             if (result != null)
        //////////             {
        //////////                 str_FilePath = result.FullPath;

        //////////                 // var stream = await result.OpenReadAsync ( );

        //////////                 //  resultImage.Source = ImageSource.FromStream ( ( ) => stream );

        //////////                 await Task.Run(async () =>
        //////////                 {
        //////////                     await SRoofing_ScreenChatShow_Image_MessageManager
        //////////                     .Owner_ScreenChatShowMessage_Image_MessageWS(
        //////////                                            App.Current,
        //////////               App.iAccountType,
        //////////          _iApplicationUtilityModel,
        //////////             _iSettingModel,
        //////////             _iLanguageModel,
        //////////                _iOwnerModel,
        //////////   _iChatScreenModel.iGroupModel,

        //////////  _iSpeechModel,


        //////////                 _iOwner_LanguageCode_IN,
        //////////                 _iOwner_LanguageCode_OUT,


        //////////                       _iChatScreenModel.GroupTokenID,


        //////////                                    SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_SharePhotoMessage,
        //////////                       _iLanguageModel.lblText_ScreenChatShow_ShareImage_Message,

        //////////              "media",
        //////////                             "image",

        //////////str_FilePath,

        //////////            SRoofing_TimeManager.Time_GenerateToken(),
        //////////null,
        //////////     null,
        //////////              new System.Uri(str_FilePath),
        //////////              str_FilePath, "0", "0",
        //////////   true);

        //////////                 })
        //////////                         .ConfigureAwait(false);


        //////////             }

        //////////             _bln_IsOnProgress_PickerImage = false;
        //////////         }
        //////////         catch (Exception ex)
        //////////         {
        //////////             SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //////////             return;
        //////////         }
    }










    async Task GalleryPicker_Pick_Video()
    {

        try
        {


            string str_FilePath = null;


            FileResult result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = _iLanguageModel.lblText_Picker_Video_Message
            });

            if (result != null)
            {
                str_FilePath = result.FullPath;

                // var stream = await result.OpenReadAsync ( );

                //  resultImage.Source = ImageSource.FromStream ( ( ) => stream );

                await Task.Run(async () =>
                {
                    await SRoofing_ScreenChatShow_Video_MessageManager
                   .Owner_ScreenChatShowMessage_Video_MessageWS(
                                          App.Current,
             App.iAccountType,
        _iApplicationUtilityModel,
           _iSettingModel,

           _iLanguageModel,
              _iOwnerModel,
_iChatScreenModel.iGroupModel,

_iSpeechModel,


               _iOwner_LanguageCode_IN,
               _iOwner_LanguageCode_OUT,


                     _iChatScreenModel.GroupTokenID,


                                  SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareVideoMessage,
                     _iLanguageModel.lblText_ScreenChatShow_ShareVideo_Message,

            "media",
                           "video",

                           result,

str_FilePath,

          SRoofing_TimeManager.Time_GenerateToken(),
             str_FilePath,
            new System.Uri(str_FilePath),
            str_FilePath,
             "0", "0",
 true);

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



    public async Task GalleryOpener_ShowMedia(
        string iMediaCode,
        string iTargetCode,
        SRoofingScreenChatShowMessageModelManager iGroupModel)
    {

        try
        {

            MainThread.BeginInvokeOnMainThread(async () =>
            {

                var currentPage = Microsoft.Maui.Controls.Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

                if (currentPage != null)
                {

                    if (currentPage.GetType() != typeof(Page_Chat_Gallery_List))
                    {

                        await Navigation.PushModalAsync(new Page_Chat_Gallery_List(
            _iApplicationUtilityModel,
            _iSettingModel,
            _iSpeechModel,
            _iLanguageModel,
               _iOwnerModel,

            _iOwner_LanguageCode_IN,
              _iOwner_LanguageCode_OUT,
             _iChatScreenModel,
            iGroupModel,
              iMediaCode,
iTargetCode));




                    }
                }
                else
                {

                    await Navigation.PushModalAsync(new Page_Chat_Gallery_List(
           _iApplicationUtilityModel,
           _iSettingModel,
           _iSpeechModel,
           _iLanguageModel,
              _iOwnerModel,

           _iOwner_LanguageCode_IN,
             _iOwner_LanguageCode_OUT,
            _iChatScreenModel,
           iGroupModel,
              iMediaCode,
iTargetCode));




                }


            });




        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }



    public async Task GalleryOption_Close()
    {


        MainThread.BeginInvokeOnMainThread(async () =>
        {

            await iSnackBar_GalleryOption.Close();

            await Task.Delay(500);


        });

    }

    #endregion




    #region onAppearing




    protected async override void OnAppearing()
    {
        base.OnAppearing();

        try
        {

            _blnIsScreenBackground = false;

            if (App.bln_ScreenChatShow_OnAppearing_New_MessageList== true)
            {
                App.bln_ScreenChatShow_OnAppearing_New_MessageList= false;


                try
                {
                    //get the value by `arg`

                    arr_ChatMessageList_New = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();

                    arr_ChatMessageList_New = await App.Database
                    .Get_New_Chat_MessageList_ByGroupTokenID(_iOwnerModel, _iChatScreenModel.GroupTokenID);

                    MainThread.BeginInvokeOnMainThread(async () =>
                    {
                        // Code to run on the main thread
                        for (int i = 0; i < arr_ChatMessageList_New.Count; i++)
                        {
                            arr_ChatMessageList.Add(arr_ChatMessageList_New[i]);


                            await Task.Delay(100);

                            if (arr_ChatMessageList.Count > 0)
                            {
                                MainThread.BeginInvokeOnMainThread(() =>
                                {
                                    cv_MessgeList.ScrollTo(arr_ChatMessageList.Last(), null, ScrollToPosition.End, true);

                                });
                            }



                        }

                        if (arr_ChatMessageList_New[arr_ChatMessageList_New.Count-1].UserType == SRoofingEnum_UserType.UserType_Owner)
                        {
                            await Call_Play_Owner_Out_ChatMessage();

                        }
                        else if (arr_ChatMessageList_New[arr_ChatMessageList_New.Count-1].UserType == SRoofingEnum_UserType.UserType_Remote)
                        {
                            await Call_Play_Owner_In_ChatMessage();

                        }

                    });

                 
                    _ = Task.Run(async () =>
                    {
                      
                           await SRoofing_ScreenChatShowTextMessageManager.ScreenChatShowMessage_Reset_History_Chat_Message_IsNew_False_ByGroupTokenID(
  App.Current, App.iAccountType,
  _iOwnerModel,
            arr_ChatMessageList.Last().UserType,
  _iChatScreenModel.GroupTokenID,
  arr_ChatMessageList.Last().MessageTokenID);


                        
                        ////////////////////await vw_GroupList.Bind_ChatRow ( iBroadcastModel );

                    }).ConfigureAwait(false);


                    // IsNewMessage
                    _ = Task.Run(async () =>
                    {
                        // some long running task
                        await IsNewMessage();
                    }).ConfigureAwait(false);


                }
                catch (Exception ex)
                {
                    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                }


            }

            ///////////////////   txt_MessageText.Focused += InputFocused;



            //widget_Emotion.iParent = this;
            //widget_GroupList.iParent = this;
            //widget_ImageList.iParent = this;
            //widget_LocationList.iParent = this;
            //widget_ThumList.iParent = this;
            //widget_VideoList.iParent = this;

            //////Task.Run ( async ( ) =>
            //////{
            //////    // some long running task
            //////    await Initialize_Chat_Window ( );

            //////} );




        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }


    bool _blnIsScreenBackground = false;
    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        try
        {
            _blnIsScreenBackground = true;


            player?.Dispose();
            player = null;
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }





    #endregion




    #region Show-List



    ObservableCollection<SRoofingScreenChatShowMessageModelManager> arr_ChatMessageList = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();
    ObservableCollection<SRoofingScreenChatShowMessageModelManager> arr_ChatMessageList_Temp = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();
    ObservableCollection<SRoofingScreenChatShowMessageModelManager> arr_ChatMessageList_New = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();



    public async Task ShowList()
    {


        try
        {


            MainThread.BeginInvokeOnMainThread(async () =>
            {

                // Code to run on the main thread
                if (cv_MessgeList.ItemsSource == null)
                {
                    cv_MessgeList.ItemsSource = arr_ChatMessageList;
                }

                if (arr_ChatMessageList_Temp != null)
                {
                    arr_ChatMessageList.Clear();

                    for (int i = 0; i < arr_ChatMessageList_Temp.Count; i++)
                    {
                        arr_ChatMessageList.Add(arr_ChatMessageList_Temp[i]);
                        await Task.Delay(50);

                    }


                    await Task.Delay(100);

                    if (arr_ChatMessageList.Count > 0)
                    {
                        MainThread.BeginInvokeOnMainThread(() =>
                        {
                            cv_MessgeList.ScrollTo(arr_ChatMessageList.Last(), null, ScrollToPosition.End, true);

                        });
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





    #endregion



    #region MyRegion


    private async void imgBtn_Chat_Close_Clicked(object sender, EventArgs e)
    {
        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                await Navigation.PopAsync();

            });

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }





    #endregion




    #region MyRegion



    private async void imgBtn_SendMessage_Clicked(object sender, EventArgs e)
    {
        try
        {

            var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

            if (objService != null)
            {
                objService.KeyboardClick();
            }

            string txtMessage = string.Empty;

            txtMessage = txt_MessageText.Text;

            //txt_MessageText.Focus ( );

            MainThread.BeginInvokeOnMainThread(() =>
            {
                txt_MessageText.Text = null;

                //   txt_MessageText.Text = "xxx";

                //txt_MessageText.Focus ( );

            });

            if (!string.IsNullOrEmpty(txtMessage))
            {

                _ = Task.Run(async () =>
                {
                    await SRoofing_ScreenChatShow_TextMessageManager
                   .Owner_ScreenChatShowMessage_TextTranslate_Pending_MessageWS(
                       App.Current,
                       App.iAccountType,
                       _iSettingModel,
                       _iLanguageModel,
                       _iOwnerModel,
                      _iChatScreenModel.iGroupModel,
                       _iSpeechModel,
                        _iOwner_LanguageCode_IN,
                     _iOwner_LanguageCode_OUT,
                       _iChatScreenModel.GroupTokenID,
                       SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_TextMessage_ParsePendingMessage,
                       txtMessage,

                       "text",
                       "text");

                }).ConfigureAwait(false);//.Wait ( );;



            }


            MainThread.BeginInvokeOnMainThread(() =>
            {
                txt_MessageText.Focus();
            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }





    #endregion






    #region Widgets


    async void img_Widget_Location_Clicked(object sender, EventArgs e)
    {



        #region HideKeyboard

        await Task.Delay(100);

        S1RoofingMU.Platforms.KeyboardHelper.HideKeyboard();

        await Task.Delay(100);

        #endregion



        ////////////////////try
        ////////////////////{


        ////////////////////    /* permissions_Read */
        ////////////////////    var permissions_Read = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
        ////////////////////    if (permissions_Read != PermissionStatus.Granted)
        ////////////////////    {
        ////////////////////        permissions_Read = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
        ////////////////////    }
        ////////////////////    if (permissions_Read != PermissionStatus.Granted)
        ////////////////////    {
        ////////////////////        return;
        ////////////////////    }



        ////////////////////    if (DeviceInfo.Current.Platform.ToString() == "Android")
        ////////////////////    {
        ////////////////////        var objServiceX = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_GMap_IDetectGPS>();
        ////////////////////        if (objServiceX != null)
        ////////////////////        {
        ////////////////////            if (!objServiceX.isGPSEnabled())
        ////////////////////            {
        ////////////////////                await objServiceX.OpenGPS();

        ////////////////////                await Task.Delay(500);

        ////////////////////            }
        ////////////////////        }

        ////////////////////    }




        ////////////////////    var currentPage = Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

        ////////////////////    if (currentPage != null)
        ////////////////////    {

        ////////////////////        if (currentPage.GetType() != typeof(Page_Map_Dashboard))
        ////////////////////        {

        ////////////////////            await Navigation.PushModalAsync(new Page_Map_Dashboard(
        ////////////////////          _iApplicationUtilityModel,
        ////////////////////          _iSettingModel,
        ////////////////////             _iOwnerModel,
        ////////////////////         _iSpeechModel,
        ////////////////////          _iOwner_LanguageCode_IN,
        ////////////////////            _iOwner_LanguageCode_OUT,
        ////////////////////           _iChatScreenModel));



        ////////////////////        }
        ////////////////////    }
        ////////////////////    else
        ////////////////////    {

        ////////////////////        await Navigation.PushModalAsync(new Page_Map_Dashboard(
        ////////////////////             _iApplicationUtilityModel,
        ////////////////////             _iSettingModel,
        ////////////////////                _iOwnerModel,
        ////////////////////            _iSpeechModel,
        ////////////////////             _iOwner_LanguageCode_IN,
        ////////////////////               _iOwner_LanguageCode_OUT,
        ////////////////////              _iChatScreenModel));



        ////////////////////    }



        ////////////////////}
        ////////////////////catch (Exception ex)
        ////////////////////{
        ////////////////////    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        ////////////////////    return;
        ////////////////////}

    }

    async void img_Widget_Video_Clicked(object sender, EventArgs e)
    {

        try
        {



            #region HideKeyboard

            await Task.Delay(100);

            S1RoofingMU.Platforms.KeyboardHelper.HideKeyboard();

            await Task.Delay(100);

            #endregion



            await SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
                                 Navigation,
                             typeof(Picker_Chatter_Dashboard),
                             new Page_CameraView(
                                              _iApplicationUtilityModel,
                                              _iSettingModel,
                                                 _iOwnerModel,
                                             _iSpeechModel,
                                                _iOwner_LanguageCode_IN,
                                            _iOwner_LanguageCode_OUT,
                                         _iChatScreenModel),
                             false, true);


        

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

   
    
    
    
        //////////////////////try
        //////////////////////{


        //////////////////////    /* permissions_Read */
        //////////////////////    var permissions_Read = await Permissions.CheckStatusAsync<Permissions.StorageRead>();
        //////////////////////    if (permissions_Read != PermissionStatus.Granted)
        //////////////////////    {
        //////////////////////        permissions_Read = await Permissions.RequestAsync<Permissions.StorageRead>();
        //////////////////////    }

        //////////////////////    if (permissions_Read != PermissionStatus.Granted)
        //////////////////////    {
        //////////////////////        //return;
        //////////////////////    }

        //////////////////////    /* permissions_Write */
        //////////////////////    var permissions_Write = await Permissions.CheckStatusAsync<Permissions.StorageWrite>();
        //////////////////////    if (permissions_Write != PermissionStatus.Granted)
        //////////////////////    {
        //////////////////////        permissions_Write = await Permissions.RequestAsync<Permissions.StorageWrite>();
        //////////////////////    }

        //////////////////////    if (permissions_Write != PermissionStatus.Granted)
        //////////////////////    {
        //////////////////////        //return;
        //////////////////////    }

        //////////////////////    /* permissions_Camera */
        //////////////////////    var permissions_Camera = await Permissions.CheckStatusAsync<Permissions.Camera>();

        //////////////////////    if (permissions_Camera != PermissionStatus.Granted)
        //////////////////////    {
        //////////////////////        permissions_Camera = await Permissions.RequestAsync<Permissions.Camera>();
        //////////////////////    }

        //////////////////////    if (permissions_Camera != PermissionStatus.Granted)
        //////////////////////    {
        //////////////////////        //return;
        //////////////////////    }


        //////////////////////    //img_Widget_Video_Clicked(sender,e);


        //////////////////////    //////////////if (iSnackBar_GalleryOption.IsOpen)
        //////////////////////    //////////////{
        //////////////////////    //////////////    MainThread.BeginInvokeOnMainThread(async () =>
        //////////////////////    //////////////    {

        //////////////////////    //////////////        await iSnackBar_GalleryOption.Close();

        //////////////////////    //////////////    });
        //////////////////////    //////////////}
        //////////////////////    //////////////else
        //////////////////////    //////////////{
        //////////////////////    //////////////    MainThread.BeginInvokeOnMainThread(async () =>
        //////////////////////    //////////////    {

        //////////////////////    //////////////        await iSnackBar_GalleryOption.Open(this, "", _iLanguageModel);

        //////////////////////    //////////////    });
        //////////////////////    //////////////}



        //////////////////////    //if ( PopupNavigation.Instance.PopupStack.Count > 0 )
        //////////////////////    //{
        //////////////////////    //    await Navigation.PopAllPopupAsync ( );
        //////////////////////    //}


        //////////////////////    //await PopupNavigation.Instance.PushAsync (
        //////////////////////    //  new iSRoofing_Popup.Popup_List_PickUp_Generic (
        //////////////////////    //      _iOwnerModel , SRoofingEnum_PopupByCodeManager.PopupByCode_GALERY_PICKERLIST ) );



        //////////////////////    //var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick> ( );

        //////////////////////    //if ( objService != null )
        //////////////////////    //{
        //////////////////////    //    objService.KeyboardClick ( );
        //////////////////////    //}

        //////////////////////    //await Task.Delay ( 100 );



        //////////////////////    //if ( txt_MessageText.IsFocused )
        //////////////////////    //{
        //////////////////////    //    txt_MessageText.Unfocus ( );
        //////////////////////    //    await Task.Delay ( 100 );

        //////////////////////    //}

        //////////////////////    //await Task.Delay ( 100 );


        //////////////////////    var currentPage = Microsoft.Maui.Controls.Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

        //////////////////////    if (currentPage != null)
        //////////////////////    {

        //////////////////////        if (currentPage.GetType() != typeof(Page_CameraView))
        //////////////////////        {

        //////////////////////            await Navigation.PushModalAsync(new Page_CameraView(
        //////////////////////                                      _iApplicationUtilityModel,
        //////////////////////                                      _iSettingModel,
        //////////////////////                                         _iOwnerModel,
        //////////////////////                                     _iSpeechModel,
        //////////////////////                                        _iOwner_LanguageCode_IN,
        //////////////////////                                    _iOwner_LanguageCode_OUT,
        //////////////////////                                 _iChatScreenModel));

        //////////////////////            //await Navigation.PushModalAsync(new Page_CameraView(
        //////////////////////            //                   _iApplicationUtilityModel,
        //////////////////////            //                   _iSettingModel,
        //////////////////////            //                      _iOwnerModel,
        //////////////////////            //                  _iSpeechModel,
        //////////////////////            //                   _iOwner_Incoming_LanguageCode,
        //////////////////////            //                     _iOwner_Outgoing_LanguageCode,
        //////////////////////            //                    _iChatScreenModel));




        //////////////////////        }
        //////////////////////    }
        //////////////////////    else
        //////////////////////    {

        //////////////////////        await Navigation.PushModalAsync(new Page_CameraView(
        //////////////////////                                  _iApplicationUtilityModel,
        //////////////////////                                  _iSettingModel,
        //////////////////////                                     _iOwnerModel,
        //////////////////////                                 _iSpeechModel,
        //////////////////////                                  _iOwner_LanguageCode_IN,
        //////////////////////                                    _iOwner_LanguageCode_OUT,
        //////////////////////                                   _iChatScreenModel));




        //////////////////////        //   await Navigation.PushModalAsync(new Page_Camera_View_Dashboard(
        //////////////////////        // _iApplicationUtilityModel,
        //////////////////////        // _iSettingModel,
        //////////////////////        //    _iOwnerModel,
        //////////////////////        //_iSpeechModel,
        //////////////////////        // _iOwner_Incoming_LanguageCode,
        //////////////////////        //   _iOwner_Outgoing_LanguageCode,
        //////////////////////        //  _iChatScreenModel));




        //////////////////////    }


        //////////////////////}
        //////////////////////catch (Exception ex)
        //////////////////////{
        //////////////////////    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //////////////////////    return;
        //////////////////////}

   
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }

    async void img_Widget_Image_Clicked(object sender, EventArgs e)
    {

        try
        {




            #region HideKeyboard

            await Task.Delay(100);

            S1RoofingMU.Platforms.KeyboardHelper.HideKeyboard();

            await Task.Delay(100);

            #endregion



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



            //var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick> ( );

            //if ( objService != null )
            //{
            //    objService.KeyboardClick ( );
            //}

            //if ( txt_MessageText.IsFocused )
            //{
            //    txt_MessageText.Unfocus ( );

            //    await Task.Delay ( 500 );


            //}

            Picker_Document();


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    async private void Picker_Document()
    {


        try
        {
            /* permissions_Read */
            var permissions_Read = await Permissions.CheckStatusAsync<Permissions.StorageRead>();
            if (permissions_Read != PermissionStatus.Granted)
            {
                permissions_Read = await Permissions.RequestAsync<Permissions.StorageRead>();
            }
            if (permissions_Read != PermissionStatus.Granted)
            {
                return;
            }

            /* permissions_Write */
            var permissions_Write = await Permissions.CheckStatusAsync<Permissions.StorageWrite>();
            if (permissions_Write != PermissionStatus.Granted)
            {
                permissions_Write = await Permissions.RequestAsync<Permissions.StorageWrite>();
            }
            if (permissions_Write != PermissionStatus.Granted)
            {
                return;
            }

            // For custom file types            
            // var customFileType =
            //     new FilePickerFileType(new Dictionary<DevicePlatform, IEnumerable<string>>
            //     {
            //         { DevicePlatform.iOS, new[] { "com.adobe.pdf" } }, // or general UTType values
            //         { DevicePlatform.Android, new[] { "application/pdf" } },
            //         { DevicePlatform.UWP, new[] { ".pdf" } },
            //         { DevicePlatform.Tizen, new[] { "*/*" } },
            //         { DevicePlatform.macOS, new[] { "pdf"} }, // or general UTType values
            //     }); 



            //For custom file types
            var customFileType =
                 new FilePickerFileType(new Dictionary<DevicePlatform, IEnumerable<string>>
                 {
                     { DevicePlatform.iOS, new[] { "com.adobe.pdf", "com.microsoft.word.doc" , "org.openxmlformats.wordprocessingml.document" , "com.microsoft.excel.xls" , "org.openxmlformats.spreadsheetml.sheet" } }, // or general UTType values
                     { DevicePlatform.Android, new[] { "application/pdf" ,"application/msword", "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" } },
                     //////{ DevicePlatform.UWP, new[] { ".pdf" } },
                     //////{ DevicePlatform.Tizen, new[] { "*/*" } },
                     //////{ DevicePlatform.macOS, new[] { "pdf"} }, // or general UTType values
                 });

            var fileResult = await FilePicker.PickAsync(new PickOptions
            {
                //FileTypes = FilePickerFileType.Images ,
                FileTypes = customFileType,
                PickerTitle = _iLanguageModel.lblText_Picker_Document_Message //"Pick a file"
            });

            //var fileResult = await FilePicker.PickAsync ( new PickOptions
            //{
            //    FileTypes = FilePickerFileType.Images ,
            //    //FileTypes = customFileType,
            //    PickerTitle = "Pick an image"
            //} );

            if (fileResult != null)
            {

                string str_FilePath = fileResult.FullPath;

                //var stream = await fileResult.OpenReadAsync ( );

                /// resultImage.Source = ImageSource.FromStream ( ( ) => stream );

                _ = Task.Run(async () =>
                {
                    await SRoofing_ScreenChatShow_DocumentMessageManager
                    .Owner_ScreenChatShowMessage_Document_MessageWS(
                                 App.Current,
                    App.iAccountType,
                _iApplicationUtilityModel,
                     _iSettingModel,
                     _iLanguageModel,

                   _iOwnerModel,
                      _iChatScreenModel.iGroupModel,
                   _iSpeechModel,
                  _iOwner_LanguageCode_IN,
                   _iOwner_LanguageCode_OUT,
                    _iChatScreenModel.GroupTokenID,
                     SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareDocument,
                         _iLanguageModel.lblText_ScreenChatShow_ShareDocument_Message,

              "media",
                            "file",

                            fileResult,

                                SRoofing_TimeManager.Time_GenerateToken(),
                               new System.Uri(str_FilePath),
                               str_FilePath, "0", "0", true);

                })
                      .ConfigureAwait(false);//.Wait ( );;//.Wait ( );

            }



        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }



    }

    async void img_Widget_Group_Clicked(object sender, EventArgs e)
    {
        try
        {

            txt_MessageText.Unfocus();

            // await Task.Delay ( 500 );

            //////     var keyboardService = Xamarin.Forms.App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_KeyboardService>();

            //////  //   keyboardService.Hide_Keyboard();

            //////bool xx=     keyboardService.isKeyboardOpened();

            //await Widget_Icon_Select_ByCode ( SRoofingEnum_Chat_WidgetByCodeManager.WidgetByCode_GroupList );
            //await Widget_View_Select_ByCode ( SRoofingEnum_Chat_WidgetByCodeManager.WidgetByCode_GroupList );

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }




    #endregion






    #region Call



    async void img_Toggle_CallChatter_Clicked(object sender, EventArgs e)
    {
        try
        {



            ////if ( _iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE )
            ////{
            ////    //await Start_Call ( );
            ////}

            //////vw_ChattersList.IsVisible = true;
            ////vw_Page_Account_Chat.IsVisible = false;

            // // MainSwipeView.Open ( OpenSwipeItem.RightItems,true );



            if (_iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE)
            {
                //await Start_Call ( );
            }
            else if (_iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_GROUP)
            {
                //Chatter List

                await SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
                                     Navigation,
                                 typeof(Picker_Chatter_Dashboard),
                                 new Picker_Chatter_Dashboard(
                                                           _iApplicationUtilityModel,
                                                           _iSettingModel,
                                                           _iLanguageModel,
                                                              _iOwnerModel,
                                                          _iSpeechModel,
                                                             _iOwner_LanguageCode_IN,
                                                         _iOwner_LanguageCode_OUT,
                                                      _iChatScreenModel,
                                                      "chatter_list"
                                     ), false, true);
                //await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
                //     Navigation,
                //     typeof(Page_Account_Dashboard),
                // new Page_Account_Dashboard(_iLanguageModel),
                // false,
                // true);
                //   await Navigation.PushAsync(new Picker_Chatter_Dashboard(), true);



                //await Navigation.PushAsync(new Picker_Contact_Dashboard(
                //                      _iApplicationUtilityModel,
                //                      _iSettingModel,
                //                      _iLanguageModel,
                //                         _iOwnerModel,
                //                     _iSpeechModel,
                //                        _iOwner_LanguageCode_IN,
                //                    _iOwner_LanguageCode_OUT,
                //                 _iChatScreenModel,
                //                 "chatter_list"
                //                 ), true);



                //await SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
                //         Navigation,
                //         typeof(Picker_Contact_Dashboard),
                //     new Picker_Contact_Dashboard(
                //                      _iApplicationUtilityModel,
                //                      _iSettingModel,
                //                      _iLanguageModel,
                //                         _iOwnerModel,
                //                     _iSpeechModel,
                //                        _iOwner_LanguageCode_IN,
                //                    _iOwner_LanguageCode_OUT,
                //                 _iChatScreenModel,
                //                 "chatter_list"),
                //    false, true);

                ////////var currentPage = Microsoft.Maui.Controls.Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

                ////////if (currentPage != null)
                ////////{

                ////////    if (currentPage.GetType() != typeof(Picker_Contact_Dashboard))
                ////////    {

                ////////        await Navigation.PushModalAsync(new Picker_Contact_Dashboard(
                ////////                                  _iApplicationUtilityModel,
                ////////                                  _iSettingModel,
                ////////                                  _iLanguageModel,
                ////////                                     _iOwnerModel,
                ////////                                 _iSpeechModel,
                ////////                                    _iOwner_LanguageCode_IN,
                ////////                                _iOwner_LanguageCode_OUT,
                ////////                             _iChatScreenModel,
                ////////                             "chatter_list"));



                ////////    }
                ////////}
                ////////else
                ////////{

                ////////    await Navigation.PushModalAsync(new Picker_Contact_Dashboard(
                ////////                              _iApplicationUtilityModel,
                ////////                              _iSettingModel,
                ////////                              _iLanguageModel,
                ////////                                 _iOwnerModel,
                ////////                             _iSpeechModel,
                ////////                              _iOwner_LanguageCode_IN,
                ////////                                _iOwner_LanguageCode_OUT,
                ////////                               _iChatScreenModel,
                ////////                             "chatter_list"));




                ////////    //   await Navigation.PushModalAsync(new Page_Camera_View_Dashboard(
                ////////    // _iApplicationUtilityModel,
                ////////    // _iSettingModel,
                ////////    //    _iOwnerModel,
                ////////    //_iSpeechModel,
                ////////    // _iOwner_Incoming_LanguageCode,
                ////////    //   _iOwner_Outgoing_LanguageCode,
                ////////    //  _iChatScreenModel));




                ////////}


            }



        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }



    async Task Start_Call()
    {


        try
        {

            SRoofingUserRemoteModelManager _iRemoteModel = null;
            String _InviteCode = "call";
            String _InviteType = "voice";
            bool _blnPopup_NoMoreCall = (false);
            bool _blnStartCall = (false);
            bool _blnSubscribe = (false);
            String sResponse = "";
            /*String _iPrivateGroupTokenID = "0";*/
            String _iOwnerProjectRoleCode = "0";
            SRoofingUserGroupModelManager _iGroupModel;


            //   SRoofingScreenCallShowHistoryMessageModelManager _iHistoryCallModel = ( SRoofingScreenCallShowHistoryMessageModelManager ) iObjectModel;




            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {


                //                    _iRemoteModel = new SRoofingUserRemoteModelManager ( );

                //                    _iRemoteModel = await SRoofingSync_User_RemoteManager
                //                    .Sync_User_Remote_Get_UserModel (
                //          App.Current ,
                //          _iOwnerModel ,
                //_iHistoryCallModel.RemoteUserTokenID ,
                //_iHistoryCallModel.RemoteMobileNumberTokenID );

                //                    if ( _iRemoteModel == null )
                //                    {
                //                        if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                //                        {
                //                            _iRemoteModel =
                //                        await SRoofing_UserProfileRemoteManager.SRoofing_User_Get_Remote_Model_ByRemoteUserTokenID (
                //                                  App.Current ,
                //                                  _iOwnerModel ,
                //                                  _iHistoryCallModel.RemoteUserTokenID ,
                //                                  _iHistoryCallModel.RemoteMobileNumberTokenID );
                //                        }

                //                    }
                //_iGroupModel = new SRoofingUserGroupModelManager ( );


                //_iGroupModel = await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel (
                //      App.Current ,
                //      iOwnerModel ,
                //      _iHistoryCallModel.GroupTokenID );


                //if ( _iGroupModel == null )
                //{
                //    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                //    {

                //        _iGroupModel = new SRoofingUserGroupModelManager ( );

                //        _iGroupModel =
                //        await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID (

                //                    App.Current ,
                //                        iOwnerModel ,
                //                         _iHistoryCallModel.GroupTokenID );
                //    }

                //}

                //_iGroupModel = new SRoofingUserGroupModelManager();
                //_iGroupModel =
                //              await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                //                          App.Current,
                //                              iOwnerModel,
                //                               _iHistoryCallModel.GroupTokenID);



                bool _blnSystemCall_IsAvailable;
                _blnSystemCall_IsAvailable = true;


                //////////TlknCallManager.Call_ResetCallScreen_IfNotActive(
                //////////       _iActivity,
                //////////       _iActivity._iAccountType);


                if (_blnSystemCall_IsAvailable == true)
                {



                    bool blnAvatarIsBlur = false;





                    //     await SRoofing_ScreenCallShowManager
                    //.Call_Initialize_Call_Show (
                    //     App.Current ,
                    //     _iOwnerModel ,
                    //     _iChatScreenModel. ,
                    //     _iGroupModel );



                    _blnStartCall = (true);
                    _blnPopup_NoMoreCall = (false);
                    _blnSubscribe = (false);

                }


                else
                {

                    ////////////Call is Running
                    //////////if (TlknSyncManager.Sync_Call_GetCurrentScreenCallShowByUserID(_iActivity)
                    //////////                    .get_GroupID()
                    //////////                    .equalsIgnoreCase(iCallModel.get_GroupTokenID()))
                    //////////{

                    //////////    TlknCallManager
                    //////////            .Call_CurrentCallTicket_ToUserID(
                    //////////                    _iActivity,

                    //////////                    TlknEnum_User_Account.UserAccount_Personal,
                    //////////                    TlknEnum_Direction.Direction_Out,
                    //////////                    TlknEnum_ScreenShow_InviteTag.InviteTag_Chat,
                    //////////                    TlknEnum_Call_ScreenType.CallScreenType_Chat,

                    //////////                    _InviteCode,
                    //////////                    _InviteType,
                    //////////                    _iRemoteModel,
                    //////////                    _iActivity._iOwnerModel,

                    //////////                    TlknEnum_Dating_MatchType.DatingMatchType_Chat,
                    //////////                    false);

                    //////////    //same group, open call screen
                    //////////    _blnStartCall = true;
                    //////////    _blnPopup_NoMoreCall = false;
                    //////////    _blnSubscribe = false;

                    //////////}

                    //////////else
                    //////////{

                    //////////    ShowAlert_NoNewCall;
                    //////////    _blnStartCall = false;
                    //////////    _blnPopup_NoMoreCall = true;
                    //////////    _blnSubscribe = false;
                    //////////}
                }


                await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener(
                        Navigation,
                    new Page_Call_Dashboard(),
                    false,
                    true);


            }
            else
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    // Code to run on the main thread
                    Snack_ShowMessage(SRoofingEnum_Toast_MessageManager.Message_Internet_Connection.PopupMessage_MessageConnectionFalse());

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









    #region SnackBar


    public async Task Snack_ShowMessage(string strMessage)
    {

        try
        {

            // iSnackBar.BackgroundColor = Colors.Red;

            await SRoofing_ToastMessageManager.ToastMessage_Show_Message(strMessage);


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }





    #endregion


    #region Menu-Items


    async void img_Widget_Thums_Clicked(object sender, EventArgs e)
    {
        try
        {

            MainThread.BeginInvokeOnMainThread(() =>
            {
                // MainSwipeView.Open ( OpenSwipeItem.LeftItems , true );
            });

            //  txt_MessageText.Unfocus ( );

            // await Task.Delay ( 500 );


            // await Widget_Icon_Select_ByCode ( SRoofingEnum_Chat_WidgetByCodeManager.WidgetByCode_ThumList );
            //  await Widget_View_Select_ByCode ( SRoofingEnum_Chat_WidgetByCodeManager.WidgetByCode_ThumList );

            //    await TextToSpeech.SpeakAsync("Hello World  Hello World  Hello World  Hello World");

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }


    async void Img_Options_SettingsChat_Clicked(object sender, EventArgs e)
    {
        try
        {
            //////        MainThread.BeginInvokeOnMainThread (   ( ) =>
            //////{
            //////    // Code to run on the main thread

            //////    //////vw_ChattersList.IsVisible = false;
            //////    vw_Page_Account_Chat.IsVisible = true;

            //////   // MainSwipeView.Open ( OpenSwipeItem.RightItems , true );

            //////    //await iSRoofing_Manager.SRoofing_Screen_OpenerManager
            //////    //.Screen_Opener_Page_Account_Dashboard (
            //////    //        Navigation ,
            //////    //        _iLanguageModel ,
            //////    //    "chat" ,
            //////    //    "chat" ,
            //////    //    "chat" ,
            //////    //    false ,
            //////    //    true );

            //////} );

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }





    #endregion



    private void iPage_ChatDashboard_Loaded(object sender, EventArgs e)
    {

        try
        {


            //////////if ( player == null )
            //////////{
            //////////    //player = player;

            //////////}
            //get the value by `arg`

            SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == Page_ChatDashboard");

            // await Task.Delay ( 0 );

            if (!_bln_IsInitialized_Page_ScreenChatShow_Dashboard)
            {
                _bln_IsInitialized_Page_ScreenChatShow_Dashboard = true;

                _ = Task.Run(async () =>
                {
                    // some long running task

                    await Initialize();

                }).ConfigureAwait(false);//.Wait ( );


            }



            if (!_blnIsInitialized_BroadcastReceiver)
            {

                _blnIsInitialized_BroadcastReceiver = true;

                //MessagingCenter.Subscribe<App , Type> ( App.Current , "Page_Load" , async ( snd , arg ) =>
                //{

                //    try
                //    {

                //        if ( arg == typeof ( Page_ScreenChatShow_Dashboard ) )
                //        {


                //            //////////if ( player == null )
                //            //////////{
                //            //////////    //player = player;

                //            //////////}
                //            //get the value by `arg`

                //            SRoofing_DebugManager.Debug_ShowSystemMessage ( "Page_Load == " + arg.ToString ( ) );

                //            // await Task.Delay ( 0 );

                //            if ( !_bln_IsInitialized_Page_ScreenChatShow_Dashboard )
                //            {
                //                _bln_IsInitialized_Page_ScreenChatShow_Dashboard = true;

                //                _ = Task.Run ( async ( ) =>
                //                {
                //                    // some long running task

                //                    await Initialize ( );

                //                } ).ConfigureAwait ( false );//.Wait ( );


                //            }


                //        }

                //    }
                //    catch ( Exception ex )
                //    {
                //        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                //    }

                //} );






                MessagingCenter.Subscribe<App, object>(App.Current,
                    SRoofingEnum_MessageCenter.MessageCenter_CHAT_NEW_SCREENCHATSHOW_MESSAGE, async (snd, arg) =>
                    {

                        try
                        {
                            //get the value by `arg`
                            SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Chat_Dashboard == " + arg.ToString());

                            SRoofingKeyValueModelManager iBroadcastModel = new SRoofingKeyValueModelManager();
                            iBroadcastModel = arg as SRoofingKeyValueModelManager;

                            //await Task.Delay(100);

                            if (iBroadcastModel.ItemText == "new_message" && iBroadcastModel.ItemCode == _iChatScreenModel.GroupTokenID
                            && !_blnIsScreenBackground)
                            {
                                App.bln_ScreenChatShow_OnAppearing_New_MessageList= false;

                                arr_ChatMessageList_New = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();

                                arr_ChatMessageList_New = await App.Database
                                .Get_New_Chat_MessageList_ByGroupTokenID(_iOwnerModel, _iChatScreenModel.GroupTokenID);

                                MainThread.BeginInvokeOnMainThread(async () =>
                                {
                                    // Code to run on the main thread
                                    for (int i = 0; i < arr_ChatMessageList_New.Count; i++)
                                    {
                                        arr_ChatMessageList.Add(arr_ChatMessageList_New[i]);

                                        if (iBroadcastModel.ItemValue == SRoofingEnum_UserType.UserType_Owner)
                                        {
                                            await Call_Play_Owner_Out_ChatMessage();

                                        }
                                        else if (iBroadcastModel.ItemValue == SRoofingEnum_UserType.UserType_Remote)
                                        {
                                            await Call_Play_Owner_In_ChatMessage();

                                        }


                                        await Task.Delay(100);

                                        if (arr_ChatMessageList.Count > 0)
                                        {
                                            MainThread.BeginInvokeOnMainThread(() =>
                                            {
                                                cv_MessgeList.ScrollTo(arr_ChatMessageList.Last(), null, ScrollToPosition.End, true);

                                            });
                                        }



                                    }

                                });

                                _ = Task.Run(async () =>
                                {
                                  
                                    
                                await SRoofing_ScreenChatShowTextMessageManager.ScreenChatShowMessage_Reset_History_Chat_Message_IsNew_False_ByGroupTokenID(
              App.Current, App.iAccountType,
              _iOwnerModel,
                        arr_ChatMessageList.Last().UserType,
              _iChatScreenModel.GroupTokenID,
              arr_ChatMessageList.Last().MessageTokenID);


                                    
                                    ////////////////////await vw_GroupList.Bind_ChatRow ( iBroadcastModel );

                                }).ConfigureAwait(false);


                            }
                            else if (iBroadcastModel.ItemText == "new_message" && !_blnIsScreenBackground)
                            {

                                _ = Task.Run(async () =>
                                {
                                    ////////////////////await vw_GroupList.Bind_ChatRow ( iBroadcastModel );

                                }).ConfigureAwait(false);

                            }

                            else if (iBroadcastModel.ItemText == "copy_message")
                            {
                                // Clipboard
                                await Snack_ShowMessage("Message copied");
                            }


                            // IsNewMessage
                            _ = Task.Run(async () =>
                            {
                                // some long running task
                                await IsNewMessage();
                            }).ConfigureAwait(false);


                        }
                        catch (Exception ex)
                        {
                            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                        }

                    });
















            }



        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    private void iPage_ChatDashboard_Unloaded(object sender, EventArgs e)
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

    bool _bln_IsDrawerOpen = false;
    async void swipe_ChatDashboard_SwipeEnded(object sender, SwipeEndedEventArgs e)
    {
        try
        {

            if (e.IsOpen)
            {
                // SwipeView is open
                if (e.SwipeDirection == SwipeDirection.Left)
                {

                    await MenuRight_Initialize();
                    _bln_IsDrawerOpen= true;

                }

                else if (e.SwipeDirection == SwipeDirection.Right)
                {
                    await MenuLeft_Initialize();
                    _bln_IsDrawerOpen= true;
                    //swipe_ChatDashboard.IsEnabled=false;
                }

            }
            else
            {
                // SwipeView is closed
                //swipe_ChatDashboard.IsEnabled=true;

            }
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;

        }
    }



    #region SwipeView




    string _iSwipe_ViewCode = "0";

    async void SwipeGestureRecognizer_SwipedLeft(object sender, SwipedEventArgs e)
    {
        try
        {

            //Console.WriteLine("********** SWIPE-EX **********"+ e.Direction.ToString());
            //Console.WriteLine("********** SWIPE-EX **********"+ DeviceDisplay.Current.MainDisplayInfo.Width.ToString());

            //////////if (_iSwipe_ViewCode == "0")
            //////////{
            //////////    MainThread.BeginInvokeOnMainThread(async () =>
            //////////    {
            //////////        // Code to run on the main thread
            //////////        await swipeMeRight.TranslateTo(0, 0, 250, Easing.CubicIn);
            //////////        _iSwipe_ViewCode = "right_open";
            //////////    });

            //////////}
            //////////else if (_iSwipe_ViewCode == "left_open")
            //////////{
            //////////    MainThread.BeginInvokeOnMainThread(async () =>
            //////////    {
            //////////        // Code to run on the main thread
            //////////        await swipeMeLeft.TranslateTo(-DeviceDisplay.Current.MainDisplayInfo.Width, 0, 250, Easing.CubicOut);
            //////////        _iSwipe_ViewCode = "0";
            //////////    });

            //////////}


            //if (e.Direction == SwipeDirection.Left)
            //{
            //    MainThread.BeginInvokeOnMainThread(async () =>
            //    {
            //        // Code to run on the main thread
            //        await swipeMe.TranslateTo(-400, 0, 250, Easing.Linear);

            //    });
            //}
            //else if (e.Direction == SwipeDirection.Right)
            //{
            //    MainThread.BeginInvokeOnMainThread(async () =>
            //    {
            //        // Code to run on the main thread
            //        await swipeMe.TranslateTo(400, 0, 250, Easing.Linear);

            //    });
            //}
        }
        catch (Exception ex)
        {
            Console.WriteLine("********** SWIPE-EX **********"+ ex.Message);
            return;
        }
    }

    async void SwipeGestureRecognizer_SwipedRight(object sender, SwipedEventArgs e)
    {
        try
        {

            //Console.WriteLine("********** SWIPE-EX **********"+ e.Direction.ToString());
            //Console.WriteLine("********** SWIPE-EX **********"+ DeviceDisplay.Current.MainDisplayInfo.Width.ToString());

            //////////if (_iSwipe_ViewCode == "0")
            //////////{

            //////////    MainThread.BeginInvokeOnMainThread(async () =>
            //////////    {
            //////////        // Code to run on the main thread
            //////////        //  await swipeMeLeft.TranslateTo(DeviceDisplay.Current.MainDisplayInfo.Width, 0, 250, Easing.Linear);
            //////////        await swipeMeLeft.TranslateTo(0, 0, 250, Easing.CubicIn);
            //////////        _iSwipe_ViewCode = "left_open";
            //////////    });
            //////////}

            //////////else if (_iSwipe_ViewCode == "right_open")
            //////////{

            //////////    MainThread.BeginInvokeOnMainThread(async () =>
            //////////    {
            //////////        // Code to run on the main thread
            //////////        //  await swipeMeLeft.TranslateTo(DeviceDisplay.Current.MainDisplayInfo.Width, 0, 250, Easing.Linear);
            //////////        await swipeMeRight.TranslateTo(DeviceDisplay.Current.MainDisplayInfo.Width, 0, 250, Easing.CubicOut);
            //////////        _iSwipe_ViewCode = "0";
            //////////    });
            //////////}


            //if (e.Direction == SwipeDirection.Left)
            //{
            //    MainThread.BeginInvokeOnMainThread(async () =>
            //    {
            //        // Code to run on the main thread
            //        await swipeMe.TranslateTo(-400, 0, 250, Easing.Linear);

            //    });
            //}
            //else if (e.Direction == SwipeDirection.Right)
            //{
            //    MainThread.BeginInvokeOnMainThread(async () =>
            //    {
            //        // Code to run on the main thread
            //        await swipeMe.TranslateTo(400, 0, 250, Easing.Linear);

            //    });
            //}
        }
        catch (Exception ex)
        {
            Console.WriteLine("********** SWIPE-EX **********"+ ex.Message);
            return;
        }
    }

    async void img_Toggle_CallChatter_Tapped(object sender, TappedEventArgs e)
    {
        try
        {

            await toggle_ChatterCall();
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;

        }
    }




    public async Task toggle_ChatterCall()
    {

        try
        {



            ////if ( _iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE )
            ////{
            ////    //await Start_Call ( );
            ////}

            //////vw_ChattersList.IsVisible = true;
            ////vw_Page_Account_Chat.IsVisible = false;

            // // MainSwipeView.Open ( OpenSwipeItem.RightItems,true );



            if (_iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE)
            {
                //await Start_Call ( );
            }
            else if (_iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_GROUP)
            {
                //Chatter List
                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    //await Navigation.PopAsync();
                    await SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
                                                       Navigation,
                                                   typeof(Picker_Chatter_Dashboard),
                                                   new Picker_Chatter_Dashboard(
                                                                             _iApplicationUtilityModel,
                                                                             _iSettingModel,
                                                                             _iLanguageModel,
                                                                                _iOwnerModel,
                                                                            _iSpeechModel,
                                                                               _iOwner_LanguageCode_IN,
                                                                           _iOwner_LanguageCode_OUT,
                                                                        _iChatScreenModel,
                                                                        "chatter_list"
                                                       ), false, true);
                });



                //await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
                //     Navigation,
                //     typeof(Page_Account_Dashboard),
                // new Page_Account_Dashboard(_iLanguageModel),
                // false,
                // true);
                //   await Navigation.PushAsync(new Picker_Chatter_Dashboard(), true);



                //await Navigation.PushAsync(new Picker_Contact_Dashboard(
                //                      _iApplicationUtilityModel,
                //                      _iSettingModel,
                //                      _iLanguageModel,
                //                         _iOwnerModel,
                //                     _iSpeechModel,
                //                        _iOwner_LanguageCode_IN,
                //                    _iOwner_LanguageCode_OUT,
                //                 _iChatScreenModel,
                //                 "chatter_list"
                //                 ), true);



                //await SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
                //         Navigation,
                //         typeof(Picker_Contact_Dashboard),
                //     new Picker_Contact_Dashboard(
                //                      _iApplicationUtilityModel,
                //                      _iSettingModel,
                //                      _iLanguageModel,
                //                         _iOwnerModel,
                //                     _iSpeechModel,
                //                        _iOwner_LanguageCode_IN,
                //                    _iOwner_LanguageCode_OUT,
                //                 _iChatScreenModel,
                //                 "chatter_list"),
                //    false, true);

                ////////var currentPage = Microsoft.Maui.Controls.Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

                ////////if (currentPage != null)
                ////////{

                ////////    if (currentPage.GetType() != typeof(Picker_Contact_Dashboard))
                ////////    {

                ////////        await Navigation.PushModalAsync(new Picker_Contact_Dashboard(
                ////////                                  _iApplicationUtilityModel,
                ////////                                  _iSettingModel,
                ////////                                  _iLanguageModel,
                ////////                                     _iOwnerModel,
                ////////                                 _iSpeechModel,
                ////////                                    _iOwner_LanguageCode_IN,
                ////////                                _iOwner_LanguageCode_OUT,
                ////////                             _iChatScreenModel,
                ////////                             "chatter_list"));



                ////////    }
                ////////}
                ////////else
                ////////{

                ////////    await Navigation.PushModalAsync(new Picker_Contact_Dashboard(
                ////////                              _iApplicationUtilityModel,
                ////////                              _iSettingModel,
                ////////                              _iLanguageModel,
                ////////                                 _iOwnerModel,
                ////////                             _iSpeechModel,
                ////////                              _iOwner_LanguageCode_IN,
                ////////                                _iOwner_LanguageCode_OUT,
                ////////                               _iChatScreenModel,
                ////////                             "chatter_list"));




                ////////    //   await Navigation.PushModalAsync(new Page_Camera_View_Dashboard(
                ////////    // _iApplicationUtilityModel,
                ////////    // _iSettingModel,
                ////////    //    _iOwnerModel,
                ////////    //_iSpeechModel,
                ////////    // _iOwner_Incoming_LanguageCode,
                ////////    //   _iOwner_Outgoing_LanguageCode,
                ////////    //  _iChatScreenModel));




                ////////}


            }



        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

        //try
        //{

        //    var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

        //    if (objService != null)
        //    {
        //        objService.KeyboardClick();
        //    }


        //    //  await Task.Delay ( 100 );

        //    await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
        //         Navigation,
        //         typeof(Page_Account_Dashboard),
        //     new Page_Account_Dashboard(_iLanguageModel),
        //     false,
        //     true);



        //    //var currentPage = Application.Current.MainPage.Navigation.ModalStack.LastOrDefault ( );

        //    //if ( currentPage != null )
        //    //{

        //    //    if ( currentPage.GetType ( ) != typeof ( Page_Account_Dashboard ) )
        //    //    {

        //    //        await Navigation.PushModalAsync ( new Page_Account_Dashboard ( _iLanguageModel ) , true );

        //    //    }
        //    //}
        //    //else
        //    //{

        //    //    await Navigation.PushModalAsync ( new Page_Account_Dashboard ( _iLanguageModel ) , true );
        //    //}


        //}
        //catch (Exception ex)
        //{
        //    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //    return;
        //}


    }















    #endregion

    //private void txt_MessageText_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    Editor editor = (Editor)sender;

    //    if (editor.Text.EndsWith(Environment.NewLine))
    //    {

    //        //string text = txt_MessageText.Text;
    //        //txt_MessageText.Text = "";
    //        //imgBtn_SendMessage.doc
    //        //DoSomeCoolStuff(text)



    //        string txtMessage = string.Empty;

    //        txtMessage = editor.Text;

    //        //txt_MessageText.Focus ( );

    //        MainThread.BeginInvokeOnMainThread(() =>
    //        {
    //            editor.Text = null;

    //            //   txt_MessageText.Text = "xxx";

    //            editor.Focus ( );

    //        });

    //        if (!string.IsNullOrEmpty(txtMessage))
    //        {

    //            _ = Task.Run(async () =>
    //            {
    //                await SRoofing_ScreenChatShow_TextMessageManager
    //               .Owner_ScreenChatShowMessage_TextTranslate_Pending_MessageWS(
    //                   App.Current,
    //                   App.iAccountType,
    //                   _iSettingModel,
    //                   _iLanguageModel,
    //                   _iOwnerModel,
    //                  _iChatScreenModel.iGroupModel,
    //                   _iSpeechModel,
    //                    _iOwner_LanguageCode_IN,
    //                 _iOwner_LanguageCode_OUT,
    //                   _iChatScreenModel.GroupTokenID,
    //                   SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_TextMessage_ParsePendingMessage,
    //                   txtMessage,

    //                   "text",
    //                   "text");

    //            })
    //                .ConfigureAwait(false);//.Wait ( );;



    //        }


    //        //MainThread.BeginInvokeOnMainThread(() =>
    //        //{
    //        //    editor.Focus();
    //        //});












    //    }
    //}

}