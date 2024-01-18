
using Plugin.FirebasePushNotification;

using S1RoofingMU.iSRoofingApp.iSRoofing_Database;
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumGlobalManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumHandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_HandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Contact;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Launcher;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Splash;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager;


namespace S1RoofingMU
{
    public partial class App : Application
    {


        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
           // MainPage =new NavigationPage(new MainPage());
              MainPage =new NavigationPage(new Page_Launcher());

            ////////// ///


            CrossFirebasePushNotification.Current.OnTokenRefresh += async (s, p) =>
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage($"********** S1RoofingMU ********** TOKEN : {p.Token}");

                try
                {

                    //WeakReferenceMessenger.Default.Send(new OpenWindowMessage(p.Token.ToString()));

                    if (!_bln_IsFCM_IsSaved)
                    {

                        _bln_IsFCM_IsSaved = true;

                        //MainThread.BeginInvokeOnMainThread(async () =>
                        //{
                        // Code to run on the main thread

                        //////////var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_DeviceModel>();

                        //////////if (objService != null)
                        //////////{
                        //////////    //if (Preferences.Get("DeviceGlobalID", "0") == "0")
                        //////////    //{
                        //////////    Preferences.Set("DeviceGlobalID", objService.GetGlobalDeviceID());
                        //////////    Preferences.Set("PlatformOS", DeviceInfo.Current.Platform.ToString().ToLower());


                        //////////    //}
                        //////////}


                        Preferences.Set("GCMID", p.Token);

                        string dev_id = Preferences.Get("DeviceGlobalID", "0");
                        string dev_os = Preferences.Get("PlatformOS", "0");

                        //////////await SRoofing_HandlerManager.Handler_GetResponse(
                        //////////  App.SiteDomainURL + "_iWebHandler"
                        //////////        + "/SRoofing_UserDeviceHandler.ashx?"
                        //////////        + "devid=" +  dev_id//Preferences.Get ( "DeviceGlobalID" , "0" )
                        //////////        + "&syscod=" + dev_os//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        //////////        + "&acctyp=" + App.iAccountType
                        //////////        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        //////////        + "&gcmid=" + p.Token
                        //////////        + "&req=" + SRoofingEnumHandler_UserDeviceHandler.UserDevice_Register_GlobalDeviceID);

                        SRoofing_DebugManager.Debug_ShowSystemMessage($"GCMID_Token: {p.Token}");

                        //////////_bln_IsFCM_IsSaved = true;





                    }


                    //          SRoofing_DebugManager.Debug_ShowSystemMessage($"GCMID_Token: {e.Token}");   
                }
                catch (Exception ex)
                {
                    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    return;
                }

            };

            // Push message received event  
            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage("Received");

            };

            //Push message received event  
            CrossFirebasePushNotification.Current.OnNotificationOpened += (s, p) =>
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage("Opened");
                foreach (var data in p.Data)
                {
                    SRoofing_DebugManager.Debug_ShowSystemMessage($"{data.Key} : {data.Value}");
                }

            };



        }




        #region Firebase

        bool _bln_IsFCM_IsSaved = false;
        async private void Current_OnTokenRefresh(object source, FirebasePushNotificationTokenEventArgs e)
        {

            //////////try
            //////////{


            //////////    Preferences.Set ( "GCMID" , e.Token );

            //////////    if ( !_bln_IsFCM_IsSaved )
            //////////    {

            //////////        _bln_IsFCM_IsSaved = true;

            //////////        MainThread.BeginInvokeOnMainThread ( ( ) =>
            //////////        {
            //////////            // Code to run on the main thread

            //////////            var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_DeviceModel> ( );

            //////////            if ( objService != null )
            //////////            {
            //////////                if ( Preferences.Get ( "DeviceGlobalID" , "0" ) == "0" )
            //////////                {
            //////////                    Preferences.Set ( "DeviceGlobalID" , objService.GetGlobalDeviceID ( ) );
            //////////                    Preferences.Set ( "PlatformOS" , DeviceInfo.Current.Platform.ToString().ToString ( ).ToLower ( ) );


            //////////                }
            //////////            }

            //////////        } );

            //////////        await SRoofing_HandlerManager.Handler_GetResponse (
            //////////          App.SiteDomainURL + "_iWebHandler"
            //////////                + "/SRoofing_UserDeviceHandler.ashx?"
            //////////                + "devid=" + Preferences.Get ( "DeviceGlobalID" , "0" ) //Preferences.Get ( "DeviceGlobalID" , "0" )
            //////////                + "&syscod=" + Preferences.Get ( "PlatformOS" , "0" )//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
            //////////                + "&acctyp=" + App.iAccountType
            //////////                + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
            //////////                + "&gcmid=" + e.Token
            //////////                + "&req=" + SRoofingEnumHandler_UserDeviceHandler.UserDevice_Register_GlobalDeviceID );

            //////////        SRoofing_DebugManager.Debug_ShowSystemMessage ( $"GCMID_Token: {e.Token}" );

            //////////        _bln_IsFCM_IsSaved = true;

            //////////    }


            //////////    //  SRoofing_DebugManager.Debug_ShowSystemMessage($"GCMID_Token: {e.Token}");   
            //////////}
            //////////catch ( Exception ex )
            //////////{
            //////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            //////////    return;
            //////////}

        }


        #endregion



        #region Database

        public static string iDatabasePath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "SRoofingDatabase.db3");
        //public static string iDatabasePath = Path.Combine ( System.Environment.GetFolderPath ( System.Environment.SpecialFolder.LocalApplicationData ) , "SRoofingDatabase.db3" );

        private static SRoofingDatabase _database;

        public static SRoofingDatabase Database
        {


            get
            {

                if (_database == null)
                {

                    _database = new SRoofingDatabase(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "SRoofingDatabase.db3"));
                    //      _database = new SRoofingDatabase ( Path.Combine ( System.Environment.GetFolderPath ( System.Environment.SpecialFolder.LocalApplicationData ) , "SRoofingDatabase.db3" ) );
                }
                return _database;
            }

        }

        #endregion




        #region Globals-URLs



        ////////////Server
        //////////public static string SiteDomainURL = "https://www.s1r.chat/";
        //////////public static string SiteDomainAPIWSURL = "https://s1r.chat/api/";
        //////////public static string SiteDomainURL_Socket = "160.153.251.219";
        //////////public static string SiteDomainURL_WOWZAServer = "160.153.251.219";



        //Localhost
        public static string SiteDomainURL = "https://oneworldlancer.ddns.net/S1Roofing/";
        public static string SiteDomainAPIWSURL = "http://oneworldlancer.ddns.net:8090/";
        public static string SiteDomainURL_Socket = "oneworldlancer.ddns.net";
        public static string SiteDomainURL_WOWZAServer = "41.205.116.6";



        public static string iAppKey_YOUTUBE = "AIzaSyBa0EmYp2YEAGGb1NqyvS0yKvUf-yDY81c";



        public static string SiteChatShareDocumentDataURLUpload =
            SiteDomainURL + "_iSRoofingUploader/Document/Default.aspx";

        public static string SiteChatShareImageDataURLUpload =
                SiteDomainURL + "_iSRoofingUploader/Image/Default.aspx";


        public static string URL_TlknUploader_AudioDataURL =
                SiteDomainURL + "_iSRoofingUploader/Audio/Data/Default.aspx";


        public static string URL_TlknUploader_VideoDataURL =
                SiteDomainURL + "_iSRoofingUploader/Video/Data/Default.aspx";
        public static string URL_TlknUploader_VideoThumDataURL =
                SiteDomainURL + "_iSRoofingUploader/Video/Thum/Default.aspx";

        public static string SiteUserUploadAvatarImageProfileDataURLUpload =
             SiteDomainURL + "_iSRoofingUploader/Avatar/Image/Default.aspx";


        public static string URL_TlknDownloader_DocumentFileDataURL =
    SiteDomainURL + "_iTlknDownloader/document/default.aspx?vidid=";
        public static string URL_TlknDownloader_VideoFileDataURL =
                SiteDomainURL + "_iTlknDownloader/video/data/default.aspx?vidid=";






        public static string iAccountType = SRoofingEnum_UserAccountManager.UserAccount_PERSONAL;

        public static string iDatabaseServerTokenID = SRoofingEnum_DatabaseServer.DatabaseServer_UK;
        public static string iPlatformOS = DeviceInfo.Current.Platform.ToString().ToLower();

        public static string iGMapKey = "AIzaSyB6CeZQeM-FbHBXA5RUKvHj9mHVrz7Fdjw";


        public static SRoofingApplicationUtilityModelManager _iApplicationUtilityModel;
        public static int iScreenChatShow_iMedia_Width = 0;
        public static int iScreenChatShow_iMedia_Height = 0;







        public static bool bln_IsBack_FromShareScreen_PickerPopup = false;


        public static bool bln_Chat_IsOnProgress_PickerPopup = false;
        public static bool bln_ScreenChatShow_OnAppearing_New_MessageList = false;





        public static bool _blnSyncHistory_ScreenChatShow_List = false;
        public static bool _blnSyncHistory_ScreenCallShow_List = false;




        public static bool _blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;
        public static bool _blnSyncHistory_ScreenChatShow_CHAT_Thum_List = false;
        public static bool _blnSyncHistory_ScreenCallShow_CALL_Landing_List = false;


 

        public static bool _blnSyncHistory_Dating_ChatContactList = false;
        public static bool _blnSync_Chat_IsRefreshNewMessage = false;


        public static bool _blnSyncOwnerAvatar = false;
        public static bool _blnSyncOwnerGalleryPersonal = false;
        public static bool _blnSyncOwnerLandingAvatar = false;
        public static bool _blnSyncOwnerAccountAvatar = false;



        #endregion



        #region Globals-Initialize

        //public static List<string> myList { get; set; }
        public static void Initilalize()
        {

            try
            {

                //Initilalize_ByDevice();

                Initilalize_ByVersion();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());

                return;
            }

        }


        public static void Initilalize_ByDevice()
        {

            ////////////try
            ////////////{
            ////////////    if ( DeviceInfo.Current.Platform.ToString() == Device.Android )
            ////////////    {
            ////////////        // Android specific code
            ////////////    }
            ////////////    else if ( DeviceInfo.Current.Platform.ToString() == Device.iOS )
            ////////////    {
            ////////////        // iOS specific code
            ////////////    }
            ////////////    else if ( DeviceInfo.Current.Platform.ToString() == Device.UWP )
            ////////////    {
            ////////////        // UWP specific code
            ////////////    }
            ////////////}
            ////////////catch ( Exception ex )
            ////////////{
            ////////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            ////////////    return;
            ////////////}

        }


        public static void Initilalize_ByVersion()
        {
            // https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/appmodel/version-tracking
            try
            {
                //if (VersionTracking.IsFirstLaunchEver)

                if (VersionTracking.Default.IsFirstLaunchEver)

                {

                    // Display pop-up alert for first launch
                    SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_ByVersion == IsFirstLaunchEver");
                    //	SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_ByVersion == IsFirstLaunchEver");
                    Initilalize_FirstRun();

                }
                else if (VersionTracking.Default.IsFirstLaunchForCurrentVersion)
                {
                    // Display update notification for current version (1.0.0)
                    SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_ByVersion == IsFirstLaunchForCurrentVersion");
                    //	SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_ByVersion == IsFirstLaunchForCurrentVersion");
                }
                else if (VersionTracking.Default.IsFirstLaunchForCurrentBuild)
                {
                    // Display update notification for current build number (2)
                    SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_ByVersion == IsFirstLaunchForCurrentBuild");
                    //	SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_ByVersion == IsFirstLaunchForCurrentBuild");
                }
                else
                {
                    SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_ByVersion == CurrentBuild:" + VersionTracking.CurrentBuild + "  CurrentVersion: " + VersionTracking.CurrentVersion);
                    //	SRoofing_DebugManager.Debug_ShowSystemMessage();
                }
            }

            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        public static void Initilalize_FirstRun()
        {

            try
            {

                //SRoofing_DebugManager.Debug_ShowSystemMessage ( "Initilalize_FirstRun()" );


                if (!Preferences.ContainsKey("app_IsFirstRun"))
                {

                    Preferences.Set("app_IsFirstRun", true);


                    Preferences.Set("user_IsLogin", false);

                    Task.Run(async () =>
                    {

                        await Initialize_Globals();

                        //    await Initilalize_CountryList ( );

                        //    await Initialize_ApplicationUtility ( );

                        //    await Initialize_AlphabetList ( );

                        //    await Initialize_EmotionList ( );

                    }).Wait();



                }
                //Task.Run ( async ( ) =>
                //{
                //    SRoofingScreenChatShowMessageModelManager x = new SRoofingScreenChatShowMessageModelManager ( )
                //    {

                //        InviteOwnerUserID = "0" ,
                //        InviteOwnerMobileNumberID = "0"
                //    };

                //    await App.Database.saveDataAsync_HistoryChat_MessageModel ( x );

                //} ).Wait ( );


                //Preferences.Set ( "app_IsFirstRun" , false );

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                // 	SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }



        public static async Task Initialize_ApplicationUtility()
        {

            //////////try
            //////////{

            //////////    var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            //////////    // Orientation (Landscape, Portrait, Square, Unknown)
            //////////    //var orientation = mainDisplayInfo.Orientation;

            //////////    //// Rotation (0, 90, 180, 270)
            //////////    //var rotation = mainDisplayInfo.Rotation;

            //////////    // Width (in pixels)
            //////////    var width = mainDisplayInfo.Width;

            //////////    //// Height (in pixels)
            //////////    var height = mainDisplayInfo.Height;

            //////////    // Screen density
            //////////    var density = mainDisplayInfo.Density;
            //////////    int ScreenWidth = ( int ) ( width / density ); // device independent pixels
            //////////                                                   //  int   ScreenHeight = (int)(height / density); // device independent pixels

            //////////    int ScreenHeight = ( int ) ( height / density ); // device independent pixels

            //////////    SRoofingApplicationUtilityModelManager iApplicationUtilityModel = new SRoofingApplicationUtilityModelManager ( )
            //////////    {


            //////////        Screen_WidthPixel = ( int ) ScreenWidth ,
            //////////        Screen_HeightPixel = ( int ) ScreenHeight ,


            //////////        Portrait_ScreenWidthPixel = ( int ) ScreenWidth ,
            //////////        Portrait_ScreenHeightPixel = ( int ) ScreenHeight ,



            //////////        Landscape_ScreenWidthPixel = ( int ) ScreenHeight ,
            //////////        Landscape_ScreenHeightPixel = ( int ) ScreenWidth ,

            //////////        //Convert.ToInt32 
            //////////        iScreenChatShow_iMedia_Width = ( int ) ( ( ScreenWidth / 10 ) * 7 ) ,
            //////////        iScreenChatShow_iMedia_Height = ( int ) ( ( ScreenWidth / 10 ) * 7 ) ,

            //////////        //iScreenChatShow_iMedia_Width =  ( ( ScreenWidth / 2 ) ) ,
            //////////        //iScreenChatShow_iMedia_Height =  ( ( ScreenWidth / 2 ) ) ,



            //////////        iProfile_Avatar_Width = ( int ) ( ScreenWidth / 3 ) ,
            //////////        iProfile_Avatar_Height = ( int ) ( ScreenWidth / 3 ) ,


            //////////    };

            //////////    //  _iApplicationUtilityModel = iApplicationUtilityModel;

            //////////    await SRoofingSync_ApplicationUtility_Manager.Sync_Speech_Set_ApplicationUtility_ByAccountType (
            //////////            App.Current ,
            //////////            iApplicationUtilityModel );
            //////////}
            //////////catch ( Exception ex )
            //////////{
            //////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            //////////    return;
            //////////}


        }


        public static async Task Initialize_AlphabetList()
        {

            //////////try
            //////////{
            //////////    ObservableCollection<SRoofingKeyValueModelManager> arr_AlphabetList_Initialize = new ObservableCollection<SRoofingKeyValueModelManager> ( );
            //////////    SRoofingKeyValueModelManager iItem_Initialize;

            //////////    //arr_AlphabetList = new ObservableCollection<SRoofingKeyValueModelManager> ( );

            //////////    char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray ( );

            //////////    for ( int i = 0 ; i < alpha.Length ; i++ )
            //////////    {


            //////////        iItem_Initialize = new SRoofingKeyValueModelManager ( );
            //////////        iItem_Initialize.ItemIndex = i;
            //////////        iItem_Initialize.ItemText = alpha[ i ].ToString ( ).ToUpper ( );
            //////////        iItem_Initialize.ItemValue = alpha[ i ].ToString ( ).ToUpper ( );
            //////////        iItem_Initialize.ItemCode = "disable";

            //////////        arr_AlphabetList_Initialize.Add ( iItem_Initialize );

            //////////    }

            //////////    await SRoofingSync_UserContactManager
            //////////           .Sync_User_Category_Set_Alphabet_Initialize_List_ByOwnerUserTokenID (
            //////////               App.Current ,
            //////////                             arr_AlphabetList_Initialize );

            //////////}
            //////////catch ( Exception ex )
            //////////{
            //////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            //////////    return;
            //////////}


        }


        public static async Task Initialize_EmotionList()
        {

            //////////try
            //////////{

            //////////    ObservableCollection<string> arr_UserEmotionList = new ObservableCollection<string> ( );



            //////////    for ( int i = 1 ; i <= 37 ; i++ )
            //////////    {
            //////////        //  arr_UserEmotionList.Add ( "emo" + i.ToString ( ) + ".png" );
            //////////        arr_UserEmotionList.Add ( "emo" + i.ToString ( ) );
            //////////    }


            //////////    await SRoofingSync_Emotion_Manager
            //////////           .Sync_Emotion_Set_List_All (
            //////////               App.Current ,
            //////////                             arr_UserEmotionList );

            //////////}
            //////////catch ( Exception ex )
            //////////{
            //////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            //////////    return;
            //////////}


        }



        public static async Task Initilalize_CountryList()
        {

            //////////try
            //////////{

            //////////    await SRoofing_CountryManager.Initilalize_CountryList ( );

            //////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( "Initilalize_CountryList()" );

            //////////}
            //////////catch ( Exception ex )
            //////////{
            //////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            //////////    return;
            //////////}

        }



        public static async Task Initialize_Globals()
        {

            try
            {

                var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_DeviceModel>();

                if (objService != null)
                {

                    Preferences.Set("DeviceGlobalID", objService.GetGlobalDeviceID());

                    SRoofing_DebugManager.Debug_ShowSystemMessage("DeviceGlobalID  == "
                        + Preferences.Get("DeviceGlobalID", "0"));

                }

                Preferences.Set("PlatformOS", DeviceInfo.Current.Platform.ToString().ToLower());
                SRoofing_DebugManager.Debug_ShowSystemMessage("PlatformOS  == "
                + Preferences.Get("PlatformOS", "0"));


                //  App.Current. UIDevice.CurrentDevice.IdentifierForVendor.AsString(), "0");  


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                //	SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }




        #endregion







        #region WebService


        public static SRoofing_ScreenCallShowMessageWS svcSRoofing_ScreenCallShowMessageWS
        {
            get; set;
        }

        public static SRoofing_ScreenChatShowMessageWS svcSRoofing_ScreenChatShowMessageWS
        {
            get; set;
        }

        public static SRoofing_ScreenChatShowTextMessageWS svcSRoofing_ScreenChatShowTextMessageWS
        {
            get; set;
        }

        public static SRoofing_UserCategoryWS svcSRoofing_UserCategoryWS
        {
            get; set;
        }

        public static SRoofing_UserGroupWS svcSRoofing_UserGroupWS
        {
            get; set;
        }

        public static SRoofing_UserContactFriendWS svcSRoofing_UserContactFriendWS
        {
            get; set;
        }


        public static SRoofing_UserProfileWS svcSRoofing_UserProfileWS
        {
            get; set;
        }


        public static SRoofing_UserRegisterWS svcSRoofing_UserRegisterWS
        {
            get; set;
        }



        public static SRoofing_ScreenChatShowChatterListWS svcSRoofing_ScreenChatShowChatterListWS
        {
            get; set;
        }



        #endregion




    }
}