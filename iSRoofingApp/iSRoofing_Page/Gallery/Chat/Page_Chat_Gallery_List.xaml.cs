using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Category;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;

//using Xamarin.CommunityToolkit.UI.Views;





using S1RoofingMU.iSRoofingApp.iSRoofing_Model.YouTube;

using System.Net.Http;

using System.Net;

using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Chat;
//using S1RoofingMU.iSRoofingApp.ScreenChatShow.YouTube;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Image;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Video;

using S1RoofingMU.iSRoofingApp.iSRoofing_DownloaderManager;
using System.Runtime.InteropServices.ComTypes;
using System.IO;
using Microsoft.Maui.ApplicationModel;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Chatter;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumGlobalManager;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Gallery.Chat
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Chat_Gallery_List : ContentPage
    {



        public SRoofingUserOwnerModelManager _iOwnerModel { get; set; }
        public SRoofingKeyValueModelManager _iCurrent_CategoryModel;


        bool _blnIsInitialized = false;
        bool _blnIsInitialized_BroadcastReceiver = false;
        bool _bln_IsInitialized_Page_Gallery_Dashboard = false;

        bool _blnIsInitialized_Popup_IsOpen = false;


        ObservableCollection<SRoofingScreenChatShowMessageModelManager> arr_ChatGalleryList = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();
        ObservableCollection<SRoofingScreenChatShowMessageModelManager> arr_ChatGalleryList_Temp = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();
        SRoofingScreenChatShowMessageModelManager _iChatMessageModel;



        SRoofingApplicationUtilityModelManager _iApplicationUtilityModel;
        SRoofingUserSettingModelManager _iSettingModel;
        SRoofingSpeechModel _iSpeechModel;
        public SRoofingLanguageTranslateModel _iLanguageModel;
        string _iOwner_Incoming_LanguageCode;
        string _iOwner_Outgoing_LanguageCode;
        SRoofingScreenChatShowScreenModel _iChatScreenModel;
        SRoofingScreenChatShowMessageModelManager iChatMessageModel;
        string _iMediaCode;
        string _iTargetCode;


        public Page_Chat_Gallery_List(
 SRoofingApplicationUtilityModelManager iApplicationUtilityModel,
         SRoofingUserSettingModelManager iSettingModel,
        SRoofingSpeechModel iSpeechModel,
            SRoofingLanguageTranslateModel iLanguageModel,
        SRoofingUserOwnerModelManager iOwnerModel,
        string iOwner_Incoming_LanguageCode,
              string iOwner_Outgoing_LanguageCode,
            SRoofingScreenChatShowScreenModel iChatScreenModel,
            SRoofingScreenChatShowMessageModelManager iChatMessageModel,
             string iMediaCode,
            string iTargetCode)
        {

            InitializeComponent();

            try
            {

                //ideo_Preview.Source = "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4";

                _iMediaCode = iMediaCode;
                _iTargetCode = iTargetCode;

                _iChatMessageModel = iChatMessageModel;

                _iApplicationUtilityModel = iApplicationUtilityModel;
                _iSettingModel = iSettingModel;

                _iLanguageModel = iLanguageModel;

                _iOwnerModel = iOwnerModel;
                _iSpeechModel = iSpeechModel;

                _iOwner_Incoming_LanguageCode = iOwner_Incoming_LanguageCode;
                _iOwner_Outgoing_LanguageCode = iOwner_Outgoing_LanguageCode;

                _iChatScreenModel = iChatScreenModel;

                grd_Content.WidthRequest = _iApplicationUtilityModel.Screen_WidthPixel;
                grd_Content.HeightRequest = _iApplicationUtilityModel.Screen_HeightPixel;


                //  arr_Current_UseGrouplListByCategoryTokenID = new ObservableCollection<SRoofingUserGroupModelManager> ( );

                RefreshCommand = new Command(RefreshData);


                ////////////        if ( !_blnIsInitialized_BroadcastReceiver )
                ////////////        {

                ////////////            _blnIsInitialized_BroadcastReceiver = true;
                ////////////            MessagingCenter.Subscribe<App , SRoofingKeyValueModelManager> ( App.Current , "OpenPage" , ( snd , arg ) =>
                ////////////{

                ////////////    try
                ////////////    {
                ////////////        //get the value by `arg`

                ////////////        _iCurrent_CategoryModel = ( arg as SRoofingKeyValueModelManager );
                ////////////        lblCategoryList.Text = ( arg as SRoofingKeyValueModelManager ).ItemText.ToString ( );

                ////////////        Task.Run ( async ( ) =>
                ////////////        {
                ////////////            await Initialize_Get_List_Group_ByCategoryTokenID (
                ////////////                _iCurrent_CategoryModel.ItemValue ,
                ////////////                _iCurrent_CategoryModel.ItemText ,
                ////////////                false );
                ////////////        } ).Wait ( );
                ////////////        //_blnIsInitialized_Popup_IsOpen = false;

                ////////////        //txt_MobileNumber.Text = "+" + ( arg as SRoofingKeyValueModelManager ).CountryMobileCode;// (arg as Employee).m
                ////////////        // txt_MobileNumber.IsEnabled = true;
                ////////////        //txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;
                ////////////        //txt_MobileNumber.Focus();

                ////////////        //lbl_SignUp.IsEnabled = true;

                ////////////    }
                ////////////    catch ( Exception ex )
                ////////////    {
                ////////////        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                ////////////    }

                ////////////} );


                ////////////        }
                ///










                if (!_blnIsInitialized_BroadcastReceiver)
                {

                    _blnIsInitialized_BroadcastReceiver = true;

                    //MessagingCenter.Subscribe<App , Type> ( App.Current , "Page_Load" , async ( snd , arg ) =>
                    //{

                    //    try
                    //    {

                    //        if ( arg == typeof ( Page_Chat_Gallery_List ) )
                    //        {

                    //            //get the value by `arg`

                    //            SRoofing_DebugManager.Debug_ShowSystemMessage ( "Page_Load == " + arg.ToString ( ) );

                    //            //await Task.Delay ( 0 );

                    //            if ( !_bln_IsInitialized_Page_Gallery_Dashboard )
                    //            {
                    //                _bln_IsInitialized_Page_Gallery_Dashboard = true;

                    //                //  Task.Run ( async ( ) =>
                    //                //{
                    //                await Initialize ( );
                    //                //} );

                    //            }







                    //            //////_iCurrent_CategoryModel = ( arg as SRoofingKeyValueModelManager );
                    //            //////lblCategoryList.Text = ( arg as SRoofingKeyValueModelManager ).ItemText.ToString ( );

                    //            //////Task.Run ( async ( ) =>
                    //            //////{
                    //            //////    await Initialize_Get_List_Group_ByCategoryTokenID (
                    //            //////        _iCurrent_CategoryModel.ItemValue ,
                    //            //////        _iCurrent_CategoryModel.ItemText ,
                    //            //////        false );
                    //            //////} ).Wait ( );
                    //            //_blnIsInitialized_Popup_IsOpen = false;

                    //            //txt_MobileNumber.Text = "+" + ( arg as SRoofingKeyValueModelManager ).CountryMobileCode;// (arg as Employee).m
                    //            // txt_MobileNumber.IsEnabled = true;
                    //            //txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;
                    //            //txt_MobileNumber.Focus();

                    //            //lbl_SignUp.IsEnabled = true;

                    //        }
                    //    }
                    //    catch ( Exception ex )
                    //    {
                    //        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                    //    }

                    //} );



                    //MessagingCenter.Subscribe<App , string> ( App.Current , "bind_list_chat_gallery" , async ( snd , arg ) =>
                    //{

                    //    try
                    //    {
                    //        //get the value by `arg`

                    //        SRoofing_DebugManager.Debug_ShowSystemMessage ( "bind_list_chat_gallery == " + arg.ToString ( ) );

                    //        //await Task.Delay ( 0 );

                    //        MainThread.BeginInvokeOnMainThread ( async ( ) =>
                    //        {

                    //            // Code to run on the main thread
                    //            if ( cv_UserGroupList.ItemsSource == null )
                    //            {
                    //                cv_UserGroupList.ItemsSource = arr_ChatGalleryList;
                    //            }

                    //            if ( arr_ChatGalleryList_Temp != null )
                    //            {
                    //                arr_ChatGalleryList.Clear ( );

                    //                for ( int i = 0 ; i < arr_ChatGalleryList_Temp.Count ; i++ )
                    //                {
                    //                    arr_ChatGalleryList.Add ( arr_ChatGalleryList_Temp[ i ] );

                    //                    await Task.Delay ( 100 );
                    //                }

                    //            }

                    //            //////_iParent.llProgress_ToggleVisible_ChatList ( true , false );

                    //        } );

                    //    }
                    //    catch ( Exception ex )
                    //    {
                    //        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                    //    }

                    //} );



                }



                BindingContext = this;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }





        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            //if ( App.bln_IsBack_FromShareScreen_PickerPopup )
            //{

            //    App.bln_IsBack_FromShareScreen_PickerPopup = false;
            //    Navigation.PopModalAsync ( );

            //}

            //try
            //{
            //    if ( !_bln_IsInitialized )
            //    {
            //        //Task.Run ( async ( ) => { await Initialize ( ); } ).Wait ( );
            //    }
            //}
            //catch ( Exception ex )
            //{
            //    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            //    return;
            //}

        }





        async void imgBtn_BackPage_Clicked(object sender, EventArgs e)
        {

            try
            {

                await Navigation.PopModalAsync();
                //Dismiss ( null );
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }




        #region Initialize

        //Page_Landing_Dashboard _iParent;
        bool _bln_IsInitialized = false;

        //SRoofingCategoryModelManager _iHistoryCategoryModel = new SRoofingCategoryModelManager ( );

        public async Task Initialize()
        {

            try
            {


                MainThread.BeginInvokeOnMainThread(() =>
                   {
                       btn_Close_Window.Text = _iLanguageModel.lblText_Command_CLOSE_Message;
                   });

                //        _iOwnerModel = await
                //   SRoofingSync_User_OwnerManager.Sync_User_Owner_Get_UserModel (
                //App.Current );
                //
                //


                _ = Task.Run(async () =>
                  {

                      arr_ChatGalleryList_Temp = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();

                      arr_ChatGalleryList_Temp = await App.Database.Get_List_Chat_Gallery_ByGroupTokenID(
                        _iChatScreenModel.GroupTokenID,
                        _iChatMessageModel);


                      if (arr_ChatGalleryList_Temp == null)
                      {
                          arr_ChatGalleryList_Temp = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();
                      }


                      await ShowList();

                  }).ConfigureAwait(false);


                //    MessagingCenter.Send<App , string> ( App.Current as App , "bind_list_chat_gallery" , "bind_list_chat_gallery" );




                _bln_IsInitialized = true;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }


        public static ObservableCollection<SRoofingUserGroupModelManager> arr_Current_UseGrouplListByCategoryTokenID
        { get; set; } = new ObservableCollection<SRoofingUserGroupModelManager>();

        public static ObservableCollection<SRoofingUserGroupModelManager> arr_Temp_UseGrouplListByCategoryTokenID
        { get; set; } = new ObservableCollection<SRoofingUserGroupModelManager>();


        public async Task Initialize_Get_List_Group_ByCategoryTokenID(
            string strCategoryTokenID,
            string CategoryTitle,
            bool IsRefreshNew)
        {

            //////try
            //////{

            //////    if ( !IsRefreshNew )
            //////    {
            //////        arr_Temp_UseGrouplListByCategoryTokenID = new ObservableCollection<SRoofingUserGroupModelManager> ( );

            //////        arr_Temp_UseGrouplListByCategoryTokenID = await SRoofingSync_UserGroupManager
            //////                          .Sync_User_Group_Get_List_ByCategoryTokenID (
            //////           App.Current ,
            //////           _iOwnerModel , strCategoryTokenID );

            //////        if ( arr_Temp_UseGrouplListByCategoryTokenID == null )
            //////        {

            //////            if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
            //////            {

            //////                arr_Temp_UseGrouplListByCategoryTokenID = new ObservableCollection<SRoofingUserGroupModelManager> ( );

            //////                arr_Temp_UseGrouplListByCategoryTokenID = await SRoofing_UserGroupManager
            //////                    .SRoofing_XFMobile_UserCategory_Get_GroupList_ByCategoryTokenIDWS (
            //////                    App.Current ,
            //////                    _iOwnerModel , strCategoryTokenID , CategoryTitle );
            //////            }

            //////        }

            //////    }

            //////    else
            //////    {
            //////        if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
            //////        {
            //////            arr_Temp_UseGrouplListByCategoryTokenID = new ObservableCollection<SRoofingUserGroupModelManager> ( );

            //////            arr_Temp_UseGrouplListByCategoryTokenID = await SRoofing_UserGroupManager
            //////                .SRoofing_XFMobile_UserCategory_Get_GroupList_ByCategoryTokenIDWS (
            //////                App.Current ,
            //////                _iOwnerModel , strCategoryTokenID , CategoryTitle );
            //////        }
            //////        else
            //////        {
            //////            arr_Temp_UseGrouplListByCategoryTokenID = new ObservableCollection<SRoofingUserGroupModelManager> ( );

            //////            arr_Temp_UseGrouplListByCategoryTokenID = await SRoofingSync_UserGroupManager
            //////                               .Sync_User_Group_Get_List_ByCategoryTokenID (
            //////                App.Current ,
            //////                _iOwnerModel , strCategoryTokenID );
            //////        }

            //////    }


            //////    await SRoofingSync_UserCategoryManager.Sync_User_Category_Set_History_CategoryModel (
            //////   App.Current ,
            //////     _iOwnerModel , new iSRoofing_Model.Category.SRoofingCategoryModelManager ( )
            //////     {
            //////         CategoryTokenID = _iCurrent_CategoryModel.ItemValue ,
            //////         CategoryTitle = _iCurrent_CategoryModel.ItemText
            //////     } );

            //////    await SRoofingSync_UserCategoryManager.Sync_User_Category_Set_History_Group_List_ByCategoryTokenID (
            //////   App.Current ,
            //////     _iOwnerModel , _iCurrent_CategoryModel.ItemValue ,
            //////     arr_Temp_UseGrouplListByCategoryTokenID );





            //////    MainThread.BeginInvokeOnMainThread ( ( ) =>
            //////    {
            //////        if ( cv_UserGroupList.ItemsSource == null )
            //////        {
            //////            // Code to run on the main thread
            //////            cv_UserGroupList.ItemsSource = arr_Current_UseGrouplListByCategoryTokenID;
            //////        }

            //////        arr_Current_UseGrouplListByCategoryTokenID.Clear ( );
            //////        for ( int i = 0 ; i < arr_Temp_UseGrouplListByCategoryTokenID.Count ; i++ )
            //////        {
            //////            arr_Current_UseGrouplListByCategoryTokenID.Add ( arr_Temp_UseGrouplListByCategoryTokenID[ i ] );
            //////        }




            //////        //////if ( cv_UserGroupList.ItemsSource == null )
            //////        //////{
            //////        //////    // Code to run on the main thread
            //////        //////    arr_Current_UseGrouplListByCategoryTokenID = arr_Temp_UseGrouplListByCategoryTokenID;
            //////        //////    cv_UserGroupList.ItemsSource = arr_Current_UseGrouplListByCategoryTokenID;
            //////        //////}
            //////        //////else
            //////        //////{
            //////        //////    arr_Current_UseGrouplListByCategoryTokenID.Clear ( );
            //////        //////    for ( int i = 0 ; i < arr_Temp_UseGrouplListByCategoryTokenID.Count ; i++ )
            //////        //////    {
            //////        //////        arr_Current_UseGrouplListByCategoryTokenID.Add ( arr_Temp_UseGrouplListByCategoryTokenID[ i ] );
            //////        //////    }
            //////        //////}




            //////    } );

            //////}
            //////catch ( Exception ex )
            //////{
            //////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            //////    return;
            //////}


        }




        #endregion


        #region Category_List_Picker
        ObservableCollection<SRoofingKeyValueModelManager> arr_UserCategoryList;
        // ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList;


        #endregion





        #region RefreshView

        public System.Windows.Input.ICommand RefreshCommand { get; }


        async void RefreshData()
        {
            try
            {
                // refresh your data here

                _ = Task.Run(async () =>
                {

                    arr_ChatGalleryList_Temp = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();

                    arr_ChatGalleryList_Temp = await App.Database.Get_List_Chat_Gallery_ByGroupTokenID(
                      _iChatScreenModel.GroupTokenID,
                      _iChatMessageModel);


                    if (arr_ChatGalleryList_Temp == null)
                    {
                        arr_ChatGalleryList_Temp = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>();
                    }


                    await ShowList();

                }).ConfigureAwait(false);



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

                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    // Code to run on the main thread
                    // iSnackBar.BackgroundColor = Colors.Red;

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

        async void Btn_SearchYouTubeVideo_SearchButtonPressed(object sender, EventArgs e)
        {

        }


        public async Task Video_Play(string YouTubeVideoID)
        {
            try
            {


                /////////////////////  await Xamarin.Essentials.Launcher.OpenAsync ( new Uri ( "https://www.youtube.com/embed/" + YouTubeVideoID + "&fs=0&autoplay=1" ) );








                //Device.OpenUri
                //Task.Run ( async ( ) =>
                //{


                // Code to run on the main thread
                //////                    //"https://www.youtube.com/embed/rAGh8iy9YnU"

                //////                    //wv_YouTupePlayer.Source = "https://www.youtube.com/embed/" + YouTubeVideoID + "&fs=0&autoplay=1";

                //////                    //var videoId = ( string ) parameters[ "videoId" ];
                //////                    var videoURL = $"https://www.youtube.com/watch?v={YouTubeVideoID}";
                //////                    var youtube = new YoutubeClient ( );

                //////                    var streamManifest = await youtube.Videos.Streams.GetManifestAsync ( YouTubeVideoID );

                //////                    var streamInfo = streamManifest
                //////.GetVideoOnlyStreams ( )
                //////.Where ( s => s.Container == Container.Mp4 )
                //////.GetWithHighestVideoQuality ( );


                //////                    //      var streamInfo = streamManifest.GetMuxedStreams ( ).GetWithHighestVideoQuality ( );


                //////                    // Code to run on the main thread

                //////                    if ( streamInfo != null )
                //////                    {
                //////                        // Get the actual stream
                //////                        var stream = await youtube.Videos.Streams.GetAsync ( streamInfo );
                //////                        var source = streamInfo.Url;
                //////                        // Then use it with MediaElement
                //////                                wv_YouTupePlayer.Source = source;


                //////                        MainThread.BeginInvokeOnMainThread ( async ( ) =>
                //////                           {
                //////                               grd_VideoPlayer.IsVisible = true;
                //////                           } );

                //////                    }



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }









        #region Document_View


        public async Task Document_Preview(SRoofingScreenChatShowMessageModelManager iMessageModel)
        {
            try
            {


                //Device.BeginInvokeOnMainThread ( async ( ) =>
                //{

                //    {

                //        if ( File.Exists ( iMessageModel.ImageDefaultPath ) )
                //        {
                //            await Xamarin.Essentials.Launcher.OpenAsync ( new OpenFileRequest
                //            {
                //                File = new ReadOnlyFile ( iMessageModel.ImageDefaultPath )
                //            } );

                //        }
                //        else
                //        {
                //            await Snack_ShowMessage ( _iLanguageModel.lblText_File_NotFound_Message );
                //        }

                //    }
                //} );



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }




        #endregion





        #region Image_View


        public async Task Image_Preview(SRoofingScreenChatShowMessageModelManager iMessageModel)
        {
            try
            {


                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    {

                        if (File.Exists(iMessageModel.ImageDefaultPath))
                        {

                            //bool supportsUri = await Launcher.Default.CanOpenAsync("lyft://");
                            //if (supportsUri)
                            //    await Launcher.Default.OpenAsync("lyft://ridetype?id=lyft_line");

                            //await Launcher.OpenAsync(new OpenFileRequest
                            //{
                            //    File = new ReadOnlyFile(file),
                            //    PresentationSourceBounds = DeviceInfo.Platform == DevicePlatform.iOS && DeviceInfo.Idiom == DeviceIdiom.Tablet
                            //    ? new Rect(0, 20, 0, 0)
                            //    : Rect.Zero
                            //});




                            await Microsoft.Maui.ApplicationModel.Launcher.OpenAsync(new OpenFileRequest
                            {
                                File = new ReadOnlyFile(iMessageModel.ImageDefaultPath)
                            });

                        }
                        else
                        {
                            await Snack_ShowMessage(_iLanguageModel.lblText_File_NotFound_Message);

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



        #region Video_Play




        public async Task Video_Preview(SRoofingScreenChatShowMessageModelManager iMessageModel)
        {

            try
            {

                MainThread.BeginInvokeOnMainThread(async () =>
{

    if (File.Exists(iMessageModel.VideoDefaultPath))
    {

        await Microsoft.Maui.ApplicationModel.Launcher.OpenAsync(new OpenFileRequest
        {
            File = new ReadOnlyFile(iMessageModel.VideoDefaultPath)
        });
    }
    else
    {
        await Snack_ShowMessage(_iLanguageModel.lblText_File_NotFound_Message);

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



        #region Share_Media


        async public Task Media_Share(
                 string iMediaType,
                 SRoofingScreenChatShowMessageModelManager iMessageModel)
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
                                                                         _iOwner_Incoming_LanguageCode,
                                                                     _iOwner_Outgoing_LanguageCode,
                                                                  _iChatScreenModel,
                                                                  "chat_share",
                                               iMessageModel), false, true);

                //Picker_Group_Dashboard 

                //////////MainThread.BeginInvokeOnMainThread(async () =>
                //////////{
                //////////    var currentPage = Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

                //////////    if (currentPage != null)
                //////////    {

                //////////        if (currentPage.GetType() != typeof(Picker_Chatter_Dashboard))
                //////////        {

                //////////            await Navigation.PushModalAsync(new Picker_Chatter_Dashboard(
                //////////           _iApplicationUtilityModel,
                //////////           _iSettingModel,
                //////////          _iSpeechModel,
                //////////          _iLanguageModel,
                //////////                _iOwnerModel,
                //////////           _iOwner_Incoming_LanguageCode,
                //////////            _iOwner_Outgoing_LanguageCode,
                //////////           _iChatScreenModel,
                //////////           iMessageModel));



                //////////        }
                //////////    }
                //////////    else
                //////////    {

                //////////        await Navigation.PushModalAsync(new Picker_Group_Dashboard(
                //////////           _iApplicationUtilityModel,
                //////////           _iSettingModel,
                //////////          _iSpeechModel,
                //////////          _iLanguageModel,
                //////////                _iOwnerModel,
                //////////         _iOwner_Incoming_LanguageCode,
                //////////             _iOwner_Outgoing_LanguageCode,
                //////////            _iChatScreenModel,
                //////////            iMessageModel));


                //////////    }


                //////////    await Navigation.PopModalAsync();

                //////////});  //Dismiss ( null );



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }



        }





        #endregion





        #region Download_Media


        async public Task Media_Download(
                 string iMediaType,
                 SRoofingScreenChatShowMessageModelManager iMessageModel)
        {


            try
            {

                _ = Task.Run(async () =>
                {
                    await Snack_ShowMessage(_iLanguageModel.lblText_Command_DOWNLOAD_Message + " ... ");


                    await SRoofing_DownloaderManager.Downloader_File_ByFileTokenID(
                           App.Current, App.iAccountType, null,
                           "0",
                     iMessageModel.MediaFile_Code,
                          iMessageModel.MediaFile_Type,
                          iMessageModel);


                }).ConfigureAwait(false);


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }



        }





        #endregion





        private void ImgBtn_Close_Clicked(object sender, EventArgs e)
        {
            try
            {

                MainThread.BeginInvokeOnMainThread(() =>
                 {

                     grd_MediaContent.IsVisible = false;
                     frm_ImagePreview.IsVisible = false;
                     frm_VideoPlayer.IsVisible = false;
                 });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        private void frm_VideoPlayer_Tapped(object sender, EventArgs e)
        {
            try
            {
                //grd_VideoPlayer.IsVisible = false;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }



        public string GetYouTubeUrl(string videoId)
        {
            //var videoInfoUrl = $"https://www.youtube.com/get_video_info?video_id={videoId}";
            //using ( var client = new HttpClient ( ) )
            //{
            //    var videoPageContent = client.GetStringAsync ( videoInfoUrl ).Result;
            //    var videoParameters = System.Web.HttpUtility.ParseQueryString ( videoPageContent );
            //    var encodedStreamsDelimited1 = WebUtility.HtmlDecode ( videoParameters[ "player_response" ] );
            //    JObject jObject = JObject.Parse ( encodedStreamsDelimited1 );
            //    string url = ( string ) jObject[ "streamingData" ][ "formats" ][ 0 ][ "url" ];
            //    return url;
            //}

            return null;
        }

        private void ImgBtn_VideoList_SRoofing_Clicked(object sender, EventArgs e)
        {

        }

        private void ImgBtn_VideoList_Playlist_Clicked(object sender, EventArgs e)
        {

        }

        private void frm_ImagePreview_Tapped(object sender, EventArgs e)
        {

        }









        #region Show-List

        async Task ShowList()
        {



            MainThread.BeginInvokeOnMainThread(async () =>
            {
                ll_ProgressBar.IsVisible = false;

                //////////refresh_GroupList.IsRefreshing = false;


                // Code to run on the main thread
                if (cv_UserGroupList.ItemsSource == null)
                {
                    cv_UserGroupList.ItemsSource = arr_ChatGalleryList;
                }

                if (arr_ChatGalleryList_Temp != null)
                {
                    arr_ChatGalleryList.Clear();

                    for (int i = 0; i < arr_ChatGalleryList_Temp.Count; i++)
                    {
                        arr_ChatGalleryList.Add(arr_ChatGalleryList_Temp[i]);

                        await Task.Delay(SRoofing_EnumGlobalPreference.Global_ROW_LIST_DELAY);
                    }

                }

                //////_iParent.llProgress_ToggleVisible_ChatList ( true , false );

            });



        }



        #endregion

        async void ct_GalleryList_Loaded(object sender, EventArgs e)
        {
            try
            {

                //get the value by `arg`

                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == ");

                //await Task.Delay ( 0 );

                if (!_bln_IsInitialized_Page_Gallery_Dashboard)
                {
                    _bln_IsInitialized_Page_Gallery_Dashboard = true;

                    //  Task.Run ( async ( ) =>
                    //{
                    await Initialize();
                    //} );

                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }
    }
}