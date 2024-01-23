//using Camera.MAUI;


using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Category;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Image;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Video;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using CommunityToolkit.Maui.Views;


//using FFmpeg.AutoGen.Abstractions;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.CameraView;

// [XamlCompilation ( XamlCompilationOptions.Compile )]
public partial class Page_CameraView : ContentPage
{



    public SRoofingUserOwnerModelManager _iOwnerModel { get; set; }
    public SRoofingKeyValueModelManager _iCurrent_CategoryModel;


    bool _blnIsInitialized = false;
    bool _blnIsInitialized_BroadcastReceiver = false;
    bool _blnIsInitialized_Popup_IsOpen = false;


    bool _bln_IsInitialized_Page_Category_Dashboard = false;



    SRoofingApplicationUtilityModelManager _iApplicationUtilityModel;
    SRoofingUserSettingModelManager _iSettingModel;
    SRoofingSpeechModel _iSpeechModel;
    string _iOwner_Incoming_LanguageCode;
    string _iOwner_Outgoing_LanguageCode;
    SRoofingScreenChatShowScreenModel _iChatScreenModel;





    public Page_CameraView(SRoofingApplicationUtilityModelManager iApplicationUtilityModel,
         SRoofingUserSettingModelManager iSettingModel,
      SRoofingUserOwnerModelManager iOwnerModel,
        SRoofingSpeechModel iSpeechModel,
            string iOwner_Incoming_LanguageCode,
              string iOwner_Outgoing_LanguageCode,
            SRoofingScreenChatShowScreenModel iChatScreenModel)
    {
        InitializeComponent();



        try
        {

            _iApplicationUtilityModel = iApplicationUtilityModel;
            _iSettingModel = iSettingModel;
            _iOwnerModel = iOwnerModel;
            _iSpeechModel = iSpeechModel;

            _iOwner_Incoming_LanguageCode = iOwner_Incoming_LanguageCode;
            _iOwner_Outgoing_LanguageCode = iOwner_Outgoing_LanguageCode;

            _iChatScreenModel = iChatScreenModel;


            //OnPropertyChanged ( nameof ( CornerRadius ) );
            //////////////////////cameraView.CameraOptions = CameraOptions.Front;


            //  arr_Current_UseGrouplListByCategoryTokenID = new ObservableCollection<SRoofingUserGroupModelManager> ( );

            //RefreshCommand = new Command ( RefreshData );

            //////////zoomLabel.Text = string.Format("Zoom: {0}", zoomSlider.Value);


            if (!_blnIsInitialized_BroadcastReceiver)
            {

                _blnIsInitialized_BroadcastReceiver = true;



                MessagingCenter.Subscribe<App, Type>(App.Current, "Page_Load", async (snd, arg) =>
                {

                    try
                    {


                        if (arg == typeof(Page_CameraView))
                        {

                            //get the value by `arg`

                            SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == " + arg.ToString());

                            await Task.Delay(0);

                            if (!_bln_IsInitialized_Page_Category_Dashboard)
                            {
                                _bln_IsInitialized_Page_Category_Dashboard = true;

                                //if ( !_bln_IsInitialized )
                                //{
                                //      Task.Run ( async ( ) =>
                                //{
                                //    await Initialize ( );
                                //} ).ConfigureAwait ( false );

                                //}

                            }



                        }



                    }
                    catch (Exception ex)
                    {
                        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    }

                });


                MessagingCenter.Subscribe<App, SRoofingKeyValueModelManager>(App.Current, "OpenPage", async (snd, arg) =>
                {

                    //try
                    //{
                    //    //get the value by `arg`
                    //    _blnIsInitialized_Popup_IsOpen = false;

                    //    _iCurrent_CategoryModel = ( arg as SRoofingKeyValueModelManager );
                    //    lblCategoryList.Text = ( arg as SRoofingKeyValueModelManager ).ItemText.ToString ( );

                    //    //  Task.Run ( async ( ) =>
                    //    //   {
                    //    //       await Initialize_Get_List_Group_ByCategoryTokenID (
                    //    //           _iCurrent_CategoryModel.ItemValue ,
                    //    //           _iCurrent_CategoryModel.ItemText ,
                    //    //           false );
                    //    //   } );//.ConfigureAwait ( false );

                    //}
                    //catch ( Exception ex )
                    //{
                    //    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                    //}

                });





            }

            BindingContext = this;

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }




    #region CameraView


    bool playing;

    async void cameraView_CamerasLoaded(object sender, EventArgs e)
    {
        //////////try
        //////////{

        //////////    if (cameraView.NumCamerasDetected > 0)
        //////////    {
        //////////        if (cameraView.NumMicrophonesDetected > 0)
        //////////            cameraView.Microphone = cameraView.Microphones.First();

        //////////        cameraView.Camera = cameraView.Cameras[1];//.First();
        //////////                                                  //cameraView.Camera.Position= CameraPosition.Front;


        //////////        MainThread.BeginInvokeOnMainThread(async () =>
        //////////        {

        //////////            await Task.Delay(50);

        //////////            if (await cameraView.StartCameraAsync() == CameraResult.Success)
        //////////            {
        //////////                //////////btn_PickUp.Text = "Stop";
        //////////                playing = true;
        //////////            }
        //////////        });
        //////////    }
        //////////}
        //////////catch (Exception ex)
        //////////{
        //////////    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //////////    return;

        //////////}
    }






    #endregion









    async void imgBtn_BackPage_Clicked(object sender, EventArgs e)
    {

        try
        {

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                //////////if (await cameraView.StopCameraAsync() == CameraResult.Success)
                //////////{
                //////////    playing = false;
                //////////}

                await Navigation.PopAsync();
            });

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }






    #region SnackBar


    public void Snack_ShowMessage(string strMessage)
    {

        try
        {

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                // Code to run on the main thread
                // iSnackBar.BackgroundColor = Colors.Red;

                //ll_ProgressBar.IsVisible = false;

                await SRoofing_ToastMessageManager.ToastMessage_Show_Message(strMessage);



            });
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }


    #endregion


    string str_FilePath = "0";
    string _FileID = "0";
    string _iCameraViewFacing = "front";
    string _iCameraViewMode = "image";
    bool _bln_IsCameraViewBusy = false;


    async void imgBtn_Image_Clicked(object sender, EventArgs e)
    {
        try
        {

            if (!_bln_IsCameraViewBusy)
            {
                _iCameraViewMode="image";


                imgBtn_Video.BackgroundColor = Colors.Black;
                imgBtn_Image.BackgroundColor = Colors.Red;


            }

            await Capture_Image();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }





    private void imgBtn_Image_Clicked_X1(object sender, EventArgs e)
    {
        try
        {

            if (!_bln_IsCameraViewBusy)
            {
                _iCameraViewMode="image";
                //bx_Image.IsVisible = true;
                //bx_Video.IsVisible = false;

                //////////cameraView.CaptureMode = CameraCaptureMode.Photo;

                imgBtn_Video.BackgroundColor = Colors.Black;     //  MainThread.BeginInvokeOnMainThread ( ( ) =>
                imgBtn_Image.BackgroundColor = Colors.Red;     //  MainThread.BeginInvokeOnMainThread ( ( ) =>

                //MainThread.BeginInvokeOnMainThread ( ( ) =>
                //{


                //} );

            }

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }













    async void imgBtn_Video_Clicked(object sender, EventArgs e)
    {
        try
        {

            if (!_bln_IsCameraViewBusy)
            {
                _iCameraViewMode="video";

                imgBtn_Video.BackgroundColor = Colors.Red;
                imgBtn_Image.BackgroundColor = Colors.Black;

            }


            await Capture_Video();





        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }



    private void imgBtn_Video_Clicked_X1(object sender, EventArgs e)
    {
        try
        {

            if (!_bln_IsCameraViewBusy)
            {
                _iCameraViewMode="video";
                //bx_Image.IsVisible = false;
                //bx_Video.IsVisible = true;

                //////////cameraView.CaptureMode = CameraCaptureMode.Video;

                imgBtn_Video.BackgroundColor = Colors.Red;     //  MainThread.BeginInvokeOnMainThread ( ( ) =>
                imgBtn_Image.BackgroundColor = Colors.Black;     //  MainThread.BeginInvokeOnMainThread ( ( ) =>
                                                                 //{

                //} );
            }
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }












    bool _bln_IsCameraVideoStart = false;
    private async void imgBtn_Pick_Clicked(object sender, EventArgs e)
    {
        //////////try
        //////////{


        //////////    if (_iCameraViewMode== "image")
        //////////    {
        //////////        _FileID = SRoofing_TimeManager.Time_GenerateToken();
        //////////        str_FilePath = Path.Combine(FileSystem.Current.CacheDirectory, "img_" + _FileID + ".jpg");// result.FullPath;

        //////////        //ImageSource imageSource = cameraView.GetSnapShot(Camera.MAUI.ImageFormat.JPEG);
        //////////        img_Preview.Source = cameraView.GetSnapShot(Camera.MAUI.ImageFormat.JPEG);
        //////////        bool resultImage = await cameraView.SaveSnapShot(Camera.MAUI.ImageFormat.JPEG, str_FilePath);

        //////////        vid_Preview.IsVisible= false;
        //////////        img_Preview.IsVisible= true;
        //////////        frm_Preview.IsVisible= true;
        //////////    }


        //////////    else if (_iCameraViewMode== "video")
        //////////    {


        //////////        //////////if (_bln_IsCameraVideoStart == false)
        //////////        //////////{

        //////////        //////////    _bln_IsCameraViewBusy= true;


        //////////        //////////    _FileID = SRoofing_TimeManager.Time_GenerateToken();

        //////////        //////////    str_FilePath = Path.Combine(FileSystem.Current.CacheDirectory, "vid_" + _FileID + ".mp4");// result.FullPath;

        //////////        //////////    SRoofing_DebugManager.Debug_ShowSystemMessage("@@@@@@@@@@@@@@@@@@@@@@@@ str_FilePath *********" + str_FilePath);


        //////////        //////////    ////////////////////////////////////////////


        //////////        //////////    //int ornt = DeviceDisplay.Current.MainDisplayInfo.Orientation;






        //////////        //////////    ///////////////////////////////////////////

        //////////        //////////    ////////////////////var result = await cameraView.StartRecordingAsync(str_FilePath);


        //////////        //////////    //, new Size(Double.Parse(_iApplicationUtilityModel.Screen_WidthPixel.ToString()), Double.Parse(_iApplicationUtilityModel.Screen_HeightPixel.ToString())));

        //////////        //////////    //, new Size(Double.Parse( _iApplicationUtilityModel.Screen_WidthPixel.ToString())  ,Double.Parse( _iApplicationUtilityModel.Screen_HeightPixel.ToString()) 
        //////////        //////////    //var result = await cameraView.StartRecordingAsync(Path.Combine(FileSystem.Current.CacheDirectory, 
        //////////        //////////    //                        "vid_"+ _FileID + ".mp4", new Size(1920, 1080)));


        //////////        //////////    _bln_IsCameraVideoStart = true;
        //////////        //////////    imgBtn_Pick.Source = "icon_chat_share_stop.png";

        //////////        //////////    //////////cameraView.Shutter();
        //////////        //////////}
        //////////        //////////else
        //////////        //////////{




        //////////        //////////    ////////////////////var resultVideo = await cameraView.StopRecordingAsync();
        //////////        //////////    _bln_IsCameraVideoStart = false;
        //////////        //////////    imgBtn_Pick.Source = "icon_chat_share_video_take.png";

        //////////        //////////    vid_Preview.Source= MediaSource.FromFile(str_FilePath);

        //////////        //////////    img_Preview.IsVisible= false;
        //////////        //////////    vid_Preview.IsVisible= true;
        //////////        //////////    frm_Preview.IsVisible= true;
        //////////        //////////    //////////cameraView.Shutter();

        //////////        //////////}


        //////////    }

        //////////    _bln_IsCameraViewBusy= false;




        //////////}
        //////////catch (Exception ex)
        //////////{
        //////////    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //////////    return;
        //////////}
    }




    async private void imgBtn_Gallery_Clicked(object sender, EventArgs e)
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



            var fResults = await FilePicker.PickMultipleAsync(new PickOptions
            {
                FileTypes=FilePickerFileType.Images,
                PickerTitle = "Pick a photo(s)"
            });

            List<string> _arrImageListFullPath = new List<string>();


            foreach (var item in fResults)
            {
                _arrImageListFullPath.Add(item.FullPath);
            }



            if (fResults != null)
            {
                // str_FilePath = result.FullPath;

                // var stream = await result.OpenReadAsync ( );

                //  resultImage.Source = ImageSource.FromStream ( ( ) => stream );

                _=   Task.Run(async () =>
                   {
                       await SRoofing_ScreenChatShow_Image_MessageManager
                       .Owner_ScreenChatShowMessage_Image_List_MessageWS(
                                   App.Current,
              App.iAccountType,
         _iApplicationUtilityModel,
            _iSettingModel,
            _iLanguageModel,
               _iOwnerModel,
  _iChatScreenModel.iGroupModel,

 _iSpeechModel,


                _iOwner_Incoming_LanguageCode,
                _iOwner_Outgoing_LanguageCode,


                      _iChatScreenModel.GroupTokenID,


                                   SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_SharePhotoMessage,
                      _iLanguageModel.lblText_ScreenChatShow_ShareImage_Message,

             "media",
                            "image",

    //str_FilePath,

    //_FileID,
    //null,
    _arrImageListFullPath,
             //  new System.Uri(str_FilePath),
             "0",
  true);

                   }).ConfigureAwait(false);//.Wait ( );;//.Wait ( );



                await Task.Delay(500);

                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    //////////if (await cameraView.StopCameraAsync() == CameraResult.Success)
                    //////////{
                    //////////    playing = false;
                    //////////}

                    await Navigation.PopAsync();
                });




            }
            else
            {
                return;
            }
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    async void imgBtn_CameraSwitch_Clicked(object sender, EventArgs e)
    {
        //////////try
        //////////{


        //////////    // if (await cameraView.StartCameraAsync(new Size(1280, 720)) == CameraResult.Success)
        //////////    MainThread.BeginInvokeOnMainThread(async () =>
        //////////    {

        //////////        if (await cameraView.StopCameraAsync() == CameraResult.Success)
        //////////        {
        //////////            playing = false;
        //////////        }


        //////////        if (_iCameraViewFacing == "front")
        //////////        {

        //////////            cameraView.Camera = cameraView.Cameras.First();

        //////////            _iCameraViewFacing = "back";

        //////////        }
        //////////        else if (_iCameraViewFacing == "back")
        //////////        {

        //////////            cameraView.Camera = cameraView.Cameras[1];//.First();

        //////////            _iCameraViewFacing = "front";
        //////////        }


        //////////        await Task.Delay(50);

        //////////        if (await cameraView.StartCameraAsync() == CameraResult.Success)
        //////////        {
        //////////            //////////btn_PickUp.Text = "Stop";
        //////////            playing = true;
        //////////        }
        //////////    });


        //////////    //cameraView.Camera.Position= CameraPosition.Front;


        //////////    //MainThread.BeginInvokeOnMainThread(async () =>
        //////////    //{
        //////////    //    if (await cameraView.StartCameraAsync() == CameraResult.Success)
        //////////    //    {
        //////////    //        //////////btn_PickUp.Text = "Stop";
        //////////    //        playing = true;
        //////////    //    }
        //////////    //});

        //////////    //if (cameraView.CameraOptions == CameraOptions.Front)
        //////////    //{
        //////////    //    cameraView.CameraOptions = CameraOptions.Back;
        //////////    //}
        //////////    //else if (cameraView.CameraOptions == CameraOptions.Back)
        //////////    //{
        //////////    //    cameraView.CameraOptions = CameraOptions.Front;
        //////////    //}


        //////////    //////Device.BeginInvokeOnMainThread ( ( ) =>
        //////////    //////{

        //////////    //////} );

        //////////}
        //////////catch (Exception ex)
        //////////{
        //////////    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //////////    return;
        //////////}
    }




    async void Btn_Send_Clicked(object sender, EventArgs e)
    {
        try
        {


            await Task.Delay(500);


            _FileID = SRoofing_TimeManager.Time_GenerateToken();

            if (_iCameraViewMode == "image")
            {


                _= Task.Run(async () =>
                         {
                             await SRoofing_ScreenChatShow_Image_MessageManager
                             .Owner_ScreenChatShowMessage_Image_MessageWS(
                                                    App.Current,
                       App.iAccountType,
                  _iApplicationUtilityModel,
                     _iSettingModel,
                     _iLanguageModel,
                        _iOwnerModel,
           _iChatScreenModel.iGroupModel,

          _iSpeechModel,


                         _iOwner_Incoming_LanguageCode,
                         _iOwner_Outgoing_LanguageCode,


                               _iChatScreenModel.GroupTokenID,


                                            SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_SharePhotoMessage,
                               _iLanguageModel.lblText_ScreenChatShow_ShareImage_Message,

                      "media",
                                     "image",

         str_FilePath,

                    _FileID,
                      //null,
                      //    null,
                      new System.Uri(str_FilePath),
                      str_FilePath, "0", "0",
           true);

                         })
                                 .ConfigureAwait(false);



            }

            else if (_iCameraViewMode == "video")
            {
                _=  Task.Run(async () =>
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


               _iOwner_Incoming_LanguageCode,
               _iOwner_Outgoing_LanguageCode,


                     _iChatScreenModel.GroupTokenID,


                                  SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareVideoMessage,
                     _iLanguageModel.lblText_ScreenChatShow_ShareVideo_Message,

            "media",
                           "video",

                           null,

str_FilePath,

         _FileID,
             str_FilePath,
            new System.Uri(str_FilePath),
            str_FilePath,
             "0", "0",
 true);

                })
                     .ConfigureAwait(false);



            }




            MainThread.BeginInvokeOnMainThread(async () =>
            {
                //if (await cameraView.StopCameraAsync() == CameraResult.Success)
                //{
                //    playing = false;
                //}

                await Navigation.PopAsync();
            });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }




    #region Video-Rotation

    async Task RotateMyVideo()
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


    //using FFmpegInterop;
    //using Windows.Storage;

    //public async Task RotateVideoAsync(File inputFile, File outputFile)
    //{

    //    try
    //    {

    //        var ffmpeg = await  FFmpeg.AutoGen.Abstractions.sw. .CreateFromUriAsync(inputFile.Path);
    //        var transcoder = new MediaTranscoder();
    //        transcoder.AddVideoEffect(ffmpeg.VideoEffects.Rotate(90));
    //        var preparedTranscodeResult = await transcoder.PrepareFileTranscodeAsync(inputFile, outputFile);
    //        if (preparedTranscodeResult.CanTranscode)
    //        {
    //            await preparedTranscodeResult.TranscodeAsync();

    //        }

    //    }
    //    catch (Exception ex)
    //    {
    //        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
    //        return;

    //    }

    //}



    #endregion



    #region AppTranslation

    public SRoofingLanguageTranslateModel _iLanguageModel;//{ get; set; } = new SRoofingLanguageTranslateModel ( );



    async Task Initialize_AppTranslation()
    {
        try
        {
            //_iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All ( App.Current );


            if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);

            MainThread.BeginInvokeOnMainThread(async () =>
            {

                Btn_Send.Text = _iLanguageModel.lblText_Command_SUBMIT_Message;
                Btn_Cancel.Text = _iLanguageModel.lblText_Command_CANCEL_Message;



            });   //////lbl_Error.Text = _iLanguageModel.lblText_Connection_CheckOnline_Message;

            //////btn_Popup_OK.Text = _iLanguageModel.lblText_Command_SUBMIT_Message;
            //////btn_Popup_CANCEL.Text = _iLanguageModel.lblText_Command_CANCEL_Message;


            //lbl_TabChat.Text = _iLanguageModel.lblText_Tab_Chats;
            //lbl_TabCall.Text = _iLanguageModel.lblText_Tab_Calls;


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    async void page_CameraView_Loaded(object sender, EventArgs e)
    {


        try
        {

            await Initialize_AppTranslation();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    private void page_CameraView_Unloaded(object sender, EventArgs e)
    {
        try
        {

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                //////////if (await cameraView.StopCameraAsync() == CameraResult.Success)
                //////////{
                //////////    playing = false;
                //////////}

            });

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

        //try
        //{



        //    var currentPage = Microsoft.Maui.Controls.Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

        //    if (currentPage != null)
        //    {

        //        if (currentPage.GetType() != typeof(Picker_Group_Dashboard))
        //        {

        //            await Navigation.PushModalAsync(new Picker_Group_Dashboard(
        //          _iApplicationUtilityModel,
        //          _iSettingModel,
        //          _iSpeechModel,
        //              _iLanguageModel,
        //             _iOwnerModel,
        //         _iOwner_Incoming_LanguageCode,
        //            _iOwner_Outgoing_LanguageCode,
        //           _iChatScreenModel,
        //           iScreenChatShowMessageModel));



        //        }
        //    }
        //    else
        //    {

        //        await Navigation.PushModalAsync(new Picker_Group_Dashboard(
        //              _iApplicationUtilityModel,
        //          _iSettingModel,
        //          _iSpeechModel,
        //              _iLanguageModel,
        //             _iOwnerModel,
        //             _iOwner_Incoming_LanguageCode,
        //               _iOwner_Outgoing_LanguageCode,
        //              _iChatScreenModel,
        //              iScreenChatShowMessageModel));



        //    }





        //}
        //catch (Exception ex)
        //{
        //    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //    return;
        //}

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


        //////////                 _iOwner_Incoming_LanguageCode,
        //////////                 _iOwner_Outgoing_LanguageCode,


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


               _iOwner_Incoming_LanguageCode,
               _iOwner_Outgoing_LanguageCode,


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

            //            MainThread.BeginInvokeOnMainThread(async () =>
            //            {

            //                var currentPage = Microsoft.Maui.Controls.Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

            //                if (currentPage != null)
            //                {

            //                    if (currentPage.GetType() != typeof(Page_Chat_Gallery_List))
            //                    {

            //                        await Navigation.PushModalAsync(new Page_Chat_Gallery_List(
            //            _iApplicationUtilityModel,
            //            _iSettingModel,
            //            _iSpeechModel,
            //            _iLanguageModel,
            //               _iOwnerModel,

            //            _iOwner_Incoming_LanguageCode,
            //              _iOwner_Outgoing_LanguageCode,
            //             _iChatScreenModel,
            //            iGroupModel,
            //              iMediaCode,
            //iTargetCode));




            //                    }
            //                }
            //                else
            //                {

            //                    await Navigation.PushModalAsync(new Page_Chat_Gallery_List(
            //           _iApplicationUtilityModel,
            //           _iSettingModel,
            //           _iSpeechModel,
            //           _iLanguageModel,
            //              _iOwnerModel,

            //           _iOwner_Incoming_LanguageCode,
            //             _iOwner_Outgoing_LanguageCode,
            //            _iChatScreenModel,
            //           iGroupModel,
            //              iMediaCode,
            //iTargetCode));




            //                }


            //            });




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

            //await iSnackBar_GalleryOption.Close();

            //await Task.Delay(500);


        });

    }

    #endregion




















    //async void cameraView_MediaCaptured ( object sender , MediaCapturedEventArgs e )
    //{
    //    try
    //    {

    //        switch ( cameraView.CaptureMode )
    //        {

    //            // default:

    //            case CameraCaptureMode.Default:

    //            case CameraCaptureMode.Photo:

    //                lbl_Result.Text ="TRUE-Photo";

    //                ////////try
    //                ////////{


    //                ////////    previewVideo.IsVisible = false;
    //                ////////    previewPicture.IsVisible = true;
    //                ////////    previewPicture.Rotation = e.Rotation;
    //                ////////    previewPicture.Source = e.Image;


    //                ////////    frm_Preview.IsVisible = true;

    //                ////////    byte[] image = e.ImageData;
    //                ////////    _FileID = SRoofing_TimeManager.Time_GenerateToken ( );
    //                ////////    DependencyService.Get<iSRoofing_DependencyService_SaveMediaDataFile> ( ).SaveFile ( Path.Combine ( FileSystem.Current.CacheDirectory , "img_" + _FileID + ".jpg" ) , image );


    //                ////////    if ( previewPicture.Source != null )
    //                ////////    {
    //                ////////        str_FilePath = Path.Combine ( FileSystem.Current.CacheDirectory , "img_" + _FileID + ".jpg" );// result.FullPath;





    //                ////////    }

    //                ////////}
    //                ////////catch ( Exception ex )
    //                ////////{
    //                ////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
    //                ////////    return;
    //                ////////}

    //                break;

    //            case CameraCaptureMode.Video:

    //                try
    //                {


    //                    lbl_Result.Text = "TRUE-Video";



    //                    //////previewPicture.IsVisible = false;
    //                    //////previewVideo.IsVisible = true;
    //                    //////previewVideo.Source = e.Video;

    //                    //////SRoofing_DebugManager.Debug_ShowSystemMessage ( "previewVideo == " + previewVideo.Source.ToString ( ) );


    //                    //////frm_Preview.IsVisible = true;

    //                    //////if ( previewVideo.Source != null )
    //                    //////{

    //                    //////    str_FilePath = previewVideo.Source.ToString ( );



    //                    //////}

    //                }
    //                catch ( Exception ex )
    //                {
    //                    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
    //                    return;
    //                }
    //                break;
    //        }

    //        //////////await Task.Delay ( 500);

    //        //////////MainThread.BeginInvokeOnMainThread ( async ( ) =>
    //        //////////{
    //        //////////    await Navigation.PopModalAsync ( );
    //        //////////} );



    //    }
    //    catch ( Exception ex )
    //    {
    //        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
    //        return;
    //    }

    //}



    //void cameraView_OnAvailable ( object sender , bool e )
    //{



    //   if ( e )
    //   {

    //        cameraView.CaptureMode = CameraCaptureMode.Video;



    //        //    zoomSlider.Value = cameraView.Zoom;
    //        //    var max = cameraView.MaxZoom;
    //        //    if ( max > zoomSlider.Minimum && max > zoomSlider.Value )
    //        //        zoomSlider.Maximum = max;
    //        //    else
    //        //        zoomSlider.Maximum = zoomSlider.Minimum + 1; // if max == min throws exception
    //    }

    //    //doCameraThings.IsEnabled = e;
    //    //zoomSlider.IsEnabled = e;
    //}

    //private void btn_PickUp_Clicked ( object sender , EventArgs e )
    //{
    //               try
    //    {

    //        cameraView.Shutter ( );

    //    }
    //    catch ( Exception ex )
    //    {
    //        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
    //        return;
    //    }
    //}

    #region Capture_Image

    async Task Capture_Image()
    {

        try
        {

            /* permissions_Read */
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


            ///////////* permissions_Camera */
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

    #endregion



    #region Capture_Video


    async Task Capture_Video()
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



            ///////////* permissions_Camera */
            //////////var permissions_Camera = await Permissions.CheckStatusAsync<Permissions.Camera>();
            //////////if (permissions_Camera != PermissionStatus.Granted)
            //////////{
            //////////    permissions_Camera = await Permissions.RequestAsync<Permissions.Camera>();
            //////////}
            //////////if (permissions_Camera != PermissionStatus.Granted)
            //////////{
            //////////    return;
            //////////}

            ///////////* permissions_Microphone */
            //////////var permissions_Microphone = await Permissions.CheckStatusAsync<Permissions.Microphone>();
            //////////if (permissions_Microphone != PermissionStatus.Granted)
            //////////{
            //////////    permissions_Microphone = await Permissions.RequestAsync<Permissions.Microphone>();
            //////////}
            //////////if (permissions_Microphone != PermissionStatus.Granted)
            //////////{
            //////////    return;
            //////////}

            await TakeVideoAsync();

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }




    }
    #endregion



    #region Media


    async Task TakeVideoAsync()
    {
        try
        {
            var fileResult = await MediaPicker.CaptureVideoAsync();



            ////////  Task.Run ( async ( ) =>
            ////////{
            ////////       await SRoofing_ScreenChatShow_Video_MessageManager
            ////////       .Owner_ScreenChatShowMessage_Video_MessageWS (
            ////////                    App.Current ,
            ////////       App.iAccountType ,
            ////////( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iApplicationUtilityModel ,
            ////////       ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iSettingModel ,
            ////////      ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iOwnerModel ,
            ////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iSpeechModel ,
            ////////   ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iOwner_Incoming_LanguageCode ,
            ////////    ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iOwner_Outgoing_LanguageCode ,
            ////////     ( ( Page_ScreenChatShow_Dashboard ) Parent.BindingContext )._iChatScreenModel.GroupTokenID ,
            ////////        SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareVideoMessage ,
            ////////       "Shared video" ,

            //////// "media" ,
            ////////               "video" ,
            ////////                     fileResult , fileResult.FullPath ,

            ////////                   SRoofing_TimeManager.Time_GenerateToken ( ) ,
            ////////                  null , "0" , "0" , "0" , true );

            ////////   } );//.ConfigureAwait ( false );//.Wait ( );;//.Wait ( );

            await LoadVideoAsync(fileResult);

            Console.WriteLine($"CapturePhotoAsync COMPLETED: {PhotoPath}");
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
            Console.WriteLine($"CapturePhotoAsync THREW: {ex.Message}");
        }
    }


    string PhotoPath;

    async Task LoadVideoAsync(FileResult fileResult)
    {


        try
        {
            // canceled
            if (fileResult == null)
            {
                str_FilePath  = null;
                return;
            }
            // save the file into local storage
            //////////    ////////////////////var resultVideo = await cameraView.StopRecordingAsync();
            //////////    _bln_IsCameraVideoStart = false;
            //////////    imgBtn_Pick.Source = "icon_chat_share_video_take.png";

            str_FilePath  = fileResult.FullPath;

            vid_Preview.Source= MediaSource.FromFile(fileResult.FullPath);

            img_Preview.IsVisible= false;
            vid_Preview.IsVisible= true;
            frm_Preview.IsVisible= true;


            //////////var newFile = Path.Combine ( FileSystem.Current.CacheDirectory , fileResult.FileName );
            //////////using ( var stream = await fileResult.OpenReadAsync ( ) )
            //////////using ( var newStream = File.OpenWrite ( newFile ) )
            //////////    await stream.CopyToAsync ( newStream );

            //////////PhotoPath = newFile;


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }


    #endregion







    #region Media


    async Task TakePhotoAsync()
    {
        try
        {
            var photo = await MediaPicker.CapturePhotoAsync();
            await LoadPhotoAsync(photo);
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

    //string str_FilePath;

    async Task LoadPhotoAsync(FileResult photo)
    {


        try
        {
            // canceled
            if (photo == null)
            {
                str_FilePath = null;
                return;
            }


            ///////////////////////////////////////////
            ///

            var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SaveMediaDataFile>();
            string _downloadFolder;

            if (objService != null)
            {

                _downloadFolder= objService.Get_DownloadPath();


            // save the file into local storage
            //var newFile = Path.Combine(FileSystem.Current.CacheDirectory, photo.FileName);
           //  var newFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), photo.FileName);
             var newFile = Path.Combine(_downloadFolder, photo.FileName);

            using (var stream = await photo.OpenReadAsync())

            using (var newStream = File.OpenWrite(newFile))
                await stream.CopyToAsync(newStream);

            str_FilePath = newFile;

            img_Preview.Source =ImageSource.FromFile(str_FilePath);//cameraView.GetSnapShot(Camera.MAUI.ImageFormat.JPEG);


            vid_Preview.IsVisible= false;
            img_Preview.IsVisible= true;
            frm_Preview.IsVisible= true;

            }
            ////////////////////////////////////////


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    #endregion














}