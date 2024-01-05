
//////////using FFImageLoading.Maui;

using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_DownloaderManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
//////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Dashboard;
////////////////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Language;
//////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Register;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Splash;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

//using NS_SRoofing_UserRegisterWS;
//using NS_SRoofing_UserProfileWS;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Launcher
{
    //[XamlCompilation ( XamlCompilationOptions.Compile )]
    public partial class Page_Launcher : ContentPage
    {
        bool _bln_IsInitialized_Page_Launcher_Dashboard = false;
        bool _blnIsInitialized_BroadcastReceiver = false;
        public Page_Launcher()
        {

            InitializeComponent();


            //MyASMXWebService proxy = new MyASMXWebService();
            //proxy.Url = "web service url";
            //proxy.HelloWorld();


            ///

            //////MySoapClient.EndpointConfiguration endpoint = new MySoapClient.EndpointConfiguration();
            //////MySoapClient myService = new MySoapClient(endpoint, myURL);
            //////AuthorizationSoapHeader MyAuthHeader = new AuthorizationSoapHeader();

            //////MyAuthHeader.AppName = FDSServiceAppName;
            //////MyAuthHeader.AppID = Guid.Parse(MyAppID);

            //////Entry[ ] entries = MyService.GetUsers().Result;




            /////////////////////////////

            ////////var client = new SRoofing_UserRegisterWSSoapClient(SRoofing_UserRegisterWSSoapClient.EndpointConfiguration.WSHttpBinding_IEchoService, "https://oneworldlancer.ddns.net/S1Roofing/SRoofing_UserRegisterWS.asmx");

            ////////var simpleResult = await client.EchoAsync("Hello");
            ////////Console.WriteLine(simpleResult);

            ////////var msg = new EchoMessage() { Text = "Hello2" };
            ////////var msgResult = await client.ComplexEchoAsync(msg);
            ////////Console.WriteLine(msgResult);






            ///////////////////////////////









            //SRoofing_LanguageManager.Initilalize_LanguageList_ByLanguageCode_AR ( );

            // SRoofing_DebugManager.Debug_ShowSystemMessage ( "Get_DownloadPath == " +
            //   App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SaveMediaDataFile> ( )
            //.Get_DownloadPath ( ) );



            //try
            //{
            //    //https://oneworldlancer.ddns.net/S1Roofing/_iUMedia/_iUImage/img_1688326759304.jpg

            //    _ = Task.Run ( async ( ) =>
            //         {
            //             //https://thumbs.dreamstime.com/b/white-shark-blue-water-swimming-guadalupe-34864624.jpg?w=768

            //             ////////_ = await SRoofing_DownloaderManager.Downloader_File_ByFileTokenID (
            //             ////////    App.Current , App.iAccountType , null ,
            //             ////////    "1688326759304" ,
            //             ////////     SRoofingEnum_File_Code.FileCode_Image ,
            //             ////////      SRoofingEnum_File_Code.FileCode_Image );

            //             ////////_ = await SRoofing_DownloaderManager.Downloader_File_ByFileTokenID (
            //             ////////      App.Current , App.iAccountType , null ,
            //             ////////      "1690662983634" ,
            //             ////////       SRoofingEnum_File_Code.FileCode_Video ,
            //             ////////        SRoofingEnum_File_Code.FileCode_Video );


            //             ////////////////////string documentsPath = Environment.GetFolderPath ( Environment.SpecialFolder.MyPictures );
            //             ////////////////////string localFilename = "queen.jpg";
            //             ////////////////////string localPath = Path.Combine ( documentsPath , localFilename );
            //             ////////////////////File.WriteAllBytes ( localPath , downloadedImage );


            //             ////////String folderName ="Shaymaa" ;
            //             ////////IFolder folder = PCLStorage.FileSystem.Current.LocalStorage;
            //             ////////folder = await folder.CreateFolderAsync ( folderName , CreationCollisionOption.OpenIfExists );
            //             //               IFolder folder = await rootFolder.CreateFolderAsync ( "Shaymaa" ,
            //             //CreationCollisionOption.OpenIfExists );
            //             //IFile file = await folder.CreateFileAsync ( "answer.txt" ,
            //             //    CreationCollisionOption.ReplaceExisting );
            //             //await file.WriteAllTextAsync ( "42" );

            //             /////////   await  SRoofing_DirectoryManager.SaveImage ( downloadedImage,"shark.jpg", folder );


            //             //////App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SaveMediaDataFile> ( )
            //             //////.SaveImageFromByte (downloadedImage,  "vidshark123123.mp4"   );


            //             //byte[] img = await SRoofing_DirectoryManager.LoadImage ( );
            //             //App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SaveMediaDataFile> ( )
            //             //    .SaveFile ( Path.Combine ( FileSystem.AppDataDirectory , "shark.jpg" ) , downloadedImage );



            //             //  SRoofing_DownloaderManager.SaveToDisk ( "shark.jpg" , downloadedImage );

            //             //Initilalize_Speech_CountryList ( );
            //             //await SRoofing_LanguageManager.Initilalize_LanguageList_ByLanguageCode_AR ( );
            //             //await Initilalize_Sound_List ( );

            //         } ).ConfigureAwait ( false );
            //}
            //catch ( Exception ex )
            //{
            //    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            //    return;
            //}









            try
            {

                //Initialize_ApplicationUtility ( );











                if (!_blnIsInitialized_BroadcastReceiver)
                {

                    _blnIsInitialized_BroadcastReceiver = true;

                    MessagingCenter.Subscribe<App, Type>(App.Current, "Page_Load", async (snd, arg) =>
                    {

                        try
                        {

                            if (arg == typeof(Page_Launcher))
                            {

                                //////////             List<SRoofingScreenChatShowHistoryMessageModelManager> arr = await App.Database.getAllAsync_HistoryChat ( );

                                //////////SRoofing_DebugManager.Debug_ShowSystemMessage ( "arr-Count== " + arr.Count.ToString ( ) );
                                //get the value by `arg`

                                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == " + arg.ToString());

                                //await Task.Delay ( 10000 );

                                if (!_bln_IsInitialized_Page_Launcher_Dashboard)
                                {
                                    _bln_IsInitialized_Page_Launcher_Dashboard = true;

                                    _ = Task.Run(async () =>
                             {


                                 bool bln_IsFirstRun = Preferences.Get("app_IsFirstRun", true);

                                 if (bln_IsFirstRun == true)
                                 {
                                     await Initilalize();

                                     await SimulateStartup();
                                 }
                                 else
                                 {
                                     await SimulateStartup();
                                 }

                             });

                                    //////Task.Run ( async ( ) =>
                                    ////// {
                                    //////     await SimulateStartup ( );
                                    ////// } ).Wait ( );

                                }


                            }


                        }
                        catch (Exception ex)
                        {
                            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                            return;

                        }

                    });


                }

                Task.Run(async () =>
               {


                   //////////SRoofing_UserRegisterWSSoapClient.EndpointConfiguration endpoint = new SRoofing_UserRegisterWSSoapClient.EndpointConfiguration();


                   //////////// SRoofing_UserRegisterWSSoapClient objService = new SRoofing_UserRegisterWSSoapClient(endpoint, "https://oneworldlancer.ddns.net/S1Roofing/SRoofing_UserRegisterWS.asmx");
                   //////////SRoofing_UserRegisterWSSoapClient objService = new SRoofing_UserRegisterWSSoapClient(endpoint);
                   //////////UserRegister_RegisterUserContactWSRequest req = new UserRegister_RegisterUserContactWSRequest();
                   //////////req.UserIDWS = "0";
                   //////////req.MobileNumberIDWS = "0";
                   //////////req.MobileNumberE164WS =  "0";
                   //////////req.CountryCodeWS = "0";
                   //////////req.CountryMobileCodeWS =  "0";
                   //////////req.ListUserIDWS = "0";

                   ////////////var xxx = await objService.UserRegister_RegisterUserContactWSAsync(req);


                   ////////////SRoofing_DebugManager.Debug_ShowSystemMessage("***************SRoofing_UserRegisterWSSoapClient***************"+ xxx.UserRegister_RegisterUserContactWSResult.ToString());

                   /////////////////////////////////////////////////////////////////////////////////////

                   ////////////////////SRoofing_UserProfileWSSoapClient.EndpointConfiguration endpoint2 = new SRoofing_UserProfileWSSoapClient.EndpointConfiguration();


                   ////////////////////// SRoofing_UserRegisterWSSoapClient objService = new SRoofing_UserRegisterWSSoapClient(endpoint, "https://oneworldlancer.ddns.net/S1Roofing/SRoofing_UserRegisterWS.asmx");
                   ////////////////////SRoofing_UserProfileWSSoapClient objService2 = new SRoofing_UserProfileWSSoapClient(endpoint2);

                   //var xxx2 = await objService2.SRoofing_XFMobile_UserProfile_Get_Owner_Profile_ByAccountTypeWSAsync("0", "0", "0", App.iAccountType, "2148", "38");

                   //SRoofing_DebugManager.Debug_ShowSystemMessage("***************SRoofing_UserRegisterWSSoapClient*************** == " + xxx2[0].FullName.ToString());

                   /////////////////////////////////////////////////////


                   ////////ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_History_ChatList_Temp = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                   ////////arr_History_ChatList_Temp = await SRoofing_History_ScreenChatShowManager
                   ////////     .SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWS(
                   ////////     App.Current, new iSRoofing_Model.User.SRoofingUserOwnerModelManager()
                   ////////     {
                   ////////         OwnerUserTokenID="2148",
                   ////////         OwnerMobileNumberTokenID = "38"
                   ////////     },
                   ////////      await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current)
                   ////////         );


                   //////SRoofing_DebugManager.Debug_ShowSystemMessage("***************SRoofing_UserRegisterWSSoapClient*************** == "+ arr_History_ChatList_Temp.Count().ToString());




                   //  await Xamarin.Essentials.Launcher.OpenAsync ( new OpenFileRequest { File = new ReadOnlyFile ( "/storage/emulated/0/Download/MyPic.jpeg" ) } );
                   ////////////////////await Xamarin.Essentials.Launcher.OpenAsync(new OpenFileRequest { File = new ReadOnlyFile("/storage/emulated/0/Download/vid.mp4") });

               }).Wait();


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }


        //page_Launcher.Loaded += (s, e) => {        };


        //private void Current_OnNotificationReceived ( object source , FirebasePushNotificationDataEventArgs e )
        //    {
        //    DisplayAlert ( "Notification" , $"Data: {e.Data [ "myData" ]}" , "OK" );
        //    }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            try
            {

                //Task.Run ( async ( ) =>
                //{
                //    await SimulateStartup ( );
                //} ).Wait ( );
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }

        }


        #region Initialize


        //public static List<string> myList { get; set; }
        public static async Task Initilalize()
        {

            try
            {

                await Initilalize_ByDevice();

                await Initilalize_ByVersion();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());

                return;
            }

        }


        public static async Task Initilalize_ByDevice()
        {

            try
            {

                await Task.Delay(0);
                //if ( DeviceInfo.Current.Platform.ToString() == Device.Android )
                //{
                //    // Android specific code
                //}
                //else if ( DeviceInfo.Current.Platform.ToString() == Device.iOS )
                //{
                //    // iOS specific code
                //}
                //else if ( DeviceInfo.Current.Platform.ToString() == Device.UWP )
                //{
                //    // UWP specific code
                //}
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        public static async Task Initilalize_ByVersion()
        {

            try
            {

                await Task.Delay(0);

                if (VersionTracking.IsFirstLaunchEver)
                {

                    // Display pop-up alert for first launch
                    SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_ByVersion == IsFirstLaunchEver");
                    //	SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_ByVersion == IsFirstLaunchEver");
                    Initilalize_FirstRun();

                }
                else if (VersionTracking.IsFirstLaunchForCurrentVersion)
                {
                    // Display update notification for current version (1.0.0)
                    SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_ByVersion == IsFirstLaunchForCurrentVersion");
                    //	SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_ByVersion == IsFirstLaunchForCurrentVersion");
                }
                else if (VersionTracking.IsFirstLaunchForCurrentBuild)
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

                SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_FirstRun()");

                //////Preferences.Set (  "app_IsFirstRun" , true );


                ////////////Preferences.Set("user_IsLogin", false);

                Task.Run(async () =>
                {

                    await Initialize_Globals();

                    await Initilalize_CountryList();

                    await Initilalize_Speech_CountryList();


                    await Initilalize_Sound_List();

                    await Initialize_AlphabetList();

                    await Initialize_BackgroundImageList();

                    //////////await Initialize_EmotionList ( );

                }).Wait();


                Task.Run(async () =>
                {
                    SRoofingScreenChatShowMessageModelManager x = new SRoofingScreenChatShowMessageModelManager()
                    {

                        InviteOwnerUserID = "0",
                        InviteOwnerMobileNumberID = "0"
                    };

                    await App.Database.saveDataAsync(x);

                    SRoofingScreenChatShowHistoryMessageModelManager x1 = new SRoofingScreenChatShowHistoryMessageModelManager()
                    {

                        InviteOwnerUserID = "0",
                        InviteOwnerMobileNumberID = "0"
                    };

                    await App.Database.saveDataAsync_HistoryChat_MessageModel(x1);

                    SRoofingScreenCallShowHistoryMessageModelManager x2 = new SRoofingScreenCallShowHistoryMessageModelManager()
                    {

                        InviteOwnerUserID = "0",
                        InviteOwnerMobileNumberID = "0"
                    };

                    await App.Database.saveDataAsync_HistoryCall_MessageModel(x2);

                }).Wait();



                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    // Code to run on the main thread

                    await Initialize_ApplicationUtility();

                });


                Preferences.Set("app_IsFirstRun", false);

                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Launcher-Initilalize_FirstRun");

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

            try
            {

                var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

                // Orientation (Landscape, Portrait, Square, Unknown)
                //var orientation = mainDisplayInfo.Orientation;

                //// Rotation (0, 90, 180, 270)
                //var rotation = mainDisplayInfo.Rotation;

                // Width (in pixels)
                var width = mainDisplayInfo.Width;

                //// Height (in pixels)
                var height = mainDisplayInfo.Height;

                // Screen density
                var density = mainDisplayInfo.Density;
                int ScreenWidth = (int)(width / density); // device independent pixels
                                                          //  int   ScreenHeight = (int)(height / density); // device independent pixels

                int ScreenHeight = (int)(height / density); // device independent pixels

                SRoofingApplicationUtilityModelManager iApplicationUtilityModel = new SRoofingApplicationUtilityModelManager()
                {


                    Screen_WidthPixel = (int)ScreenWidth,
                    Screen_HeightPixel = (int)ScreenHeight,


                    Portrait_ScreenWidthPixel = (int)ScreenWidth,
                    Portrait_ScreenHeightPixel = (int)ScreenHeight,



                    Landscape_ScreenWidthPixel = (int)ScreenHeight,
                    Landscape_ScreenHeightPixel = (int)ScreenWidth,

                    //Convert.ToInt32 
                    iScreenChatShow_iMedia_Width = (int)((ScreenWidth / 10) * 7),
                    iScreenChatShow_iMedia_Height = (int)((ScreenWidth / 10) * 7),


                    Window_Popup_Width = (int)((ScreenWidth - 100)),
                    Window_Popup_Height =(int)(((ScreenWidth - 100) * 3) / 4),

                    iYouTube_iMedia_Width = (int)((ScreenWidth - 100)),
                    iYouTube_iMedia_Height = (int)(((ScreenWidth - 100) * 3) / 4),


                    iGallery_iMedia_Width = (int)((ScreenWidth - 100)),
                    iGallery_iMedia_Height = (int)(((ScreenWidth - 100) * 3) / 4),

                    //iScreenChatShow_iMedia_Width =  ( ( ScreenWidth / 2 ) ) ,
                    //iScreenChatShow_iMedia_Height =  ( ( ScreenWidth / 2 ) ) ,



                    iProfile_Avatar_Width = (int)(ScreenWidth / 3),
                    iProfile_Avatar_Height = (int)(ScreenWidth / 3),


                };

                //  _iApplicationUtilityModel = iApplicationUtilityModel;

                await SRoofingSync_ApplicationUtility_Manager.Sync_Speech_Set_ApplicationUtility_ByAccountType(
                        App.Current,
                        iApplicationUtilityModel);
                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Launcher-Initialize_ApplicationUtility");
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }


        public static async Task Initialize_AlphabetList()
        {

            try
            {
                ObservableCollection<SRoofingKeyValueModelManager> arr_AlphabetList_Initialize = new ObservableCollection<SRoofingKeyValueModelManager>();
                SRoofingKeyValueModelManager iItem_Initialize;

                //arr_AlphabetList = new ObservableCollection<SRoofingKeyValueModelManager> ( );

                char[ ] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

                for (int i = 0; i < alpha.Length; i++)
                {


                    iItem_Initialize = new SRoofingKeyValueModelManager();
                    iItem_Initialize.ItemIndex = i;
                    iItem_Initialize.ItemText = alpha[i].ToString().ToUpper();
                    iItem_Initialize.ItemValue = alpha[i].ToString().ToUpper();
                    iItem_Initialize.ItemCode = "disable";

                    arr_AlphabetList_Initialize.Add(iItem_Initialize);

                }

                await SRoofingSync_UserContactManager
                       .Sync_User_Category_Set_Alphabet_Initialize_List_ByOwnerUserTokenID(
                           App.Current,
                                         arr_AlphabetList_Initialize);

                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Launcher-Initialize_AlphabetList");
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }




        public static async Task Initialize_BackgroundImageList()
        {

            try
            {

                var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

                // Orientation (Landscape, Portrait, Square, Unknown)
                //var orientation = mainDisplayInfo.Orientation;

                //// Rotation (0, 90, 180, 270)
                //var rotation = mainDisplayInfo.Rotation;

                // Width (in pixels)
                var width = mainDisplayInfo.Width;

                //// Height (in pixels)
                //var height = mainDisplayInfo.Height;

                // Screen density
                var density = mainDisplayInfo.Density;
                int ScreenWidth = (int)(width / density); // device independent pixels


                int iGallery_iMedia_Width = (int)((ScreenWidth - 100));
                int iGallery_iMedia_Height = (int)(((ScreenWidth - 100) * 3) / 4);



                ObservableCollection<SRoofingKeyValueModelManager> arr_BackgroundImage_System_Chat_LightList = new ObservableCollection<SRoofingKeyValueModelManager>();

                SRoofingKeyValueModelManager iItem_Initialize;


                // LIGHT
                for (int i = 0; i < 11; i++)
                {

                    arr_BackgroundImage_System_Chat_LightList.Add(
                                      new SRoofingKeyValueModelManager
                                      {

                                          ItemValue="bglight"+ i.ToString() +".png",
                                          //ItemValue="bgdark5.png",
                                          ItemWidth=  iGallery_iMedia_Width,
                                          ItemHeight=  iGallery_iMedia_Height
                                      }

                                      );

                }

                await SRoofingSync_ImageBackground_Manager
               .Sync_ImageBackground_Set_System_Chat_LightList(
                   App.Current,
                                 arr_BackgroundImage_System_Chat_LightList);



                // DARK


                ObservableCollection<SRoofingKeyValueModelManager> arr_BackgroundImage_System_Chat_DarkList = new ObservableCollection<SRoofingKeyValueModelManager>();

                for (int i = 0; i < 11; i++)
                {

                    arr_BackgroundImage_System_Chat_DarkList.Add(
                                      new SRoofingKeyValueModelManager
                                      {

                                          ItemValue="bgdark"+ i.ToString() +".png",
                                          //ItemValue="bgdark5.png",
                                          ItemWidth=  iGallery_iMedia_Width,
                                          ItemHeight=  iGallery_iMedia_Height
                                      }

                                      );

                }



                await SRoofingSync_ImageBackground_Manager
               .Sync_ImageBackground_Set_System_Chat_DarkList(
                   App.Current,
                                 arr_BackgroundImage_System_Chat_DarkList);


                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Launcher-Initialize_AlphabetList");
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }














        public static async Task Initialize_EmotionList()
        {

            try
            {

                ObservableCollection<string> arr_UserEmotionList = new ObservableCollection<string>();



                for (int i = 1; i <= 37; i++)
                {
                    //  arr_UserEmotionList.Add ( "emo" + i.ToString ( ) + ".png" );
                    arr_UserEmotionList.Add("emo" + i.ToString());
                }


                await SRoofingSync_Emotion_Manager
                       .Sync_Emotion_Set_List_All(
                           App.Current,
                                         arr_UserEmotionList);

                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Launcher-Initialize_EmotionList");
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }



        public static async Task Initilalize_CountryList()
        {

            try
            {

                await iSRoofing_Manager.SRoofing_CountryManager.Initilalize_CountryList();

                SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_CountryList()");

                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Launcher-Initilalize_CountryList");
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }





        public static async Task Initilalize_Speech_CountryList()
        {

            try
            {

                await iSRoofing_Manager.SRoofing_SpeechManager.Initilalize_Speech_CountryList();

                SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_Speech_CountryList()");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }




        public static async Task Initilalize_Sound_List()
        {

            try
            {

                await iSRoofing_Manager.SRoofing_SoundManager.Initilalize_Sound_List();

                SRoofing_DebugManager.Debug_ShowSystemMessage("Initilalize_Sound_List()");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

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

                Preferences.Set("PlatformOS", DeviceInfo.Current.Platform.ToString().ToString().ToLower());
                SRoofing_DebugManager.Debug_ShowSystemMessage("PlatformOS  == "
                + Preferences.Get("PlatformOS", "0"));


                //  App.Current. UIDevice.CurrentDevice.IdentifierForVendor.AsString(), "0");  
                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Launcher-Initialize_Globals");


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                //	SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
            // throw new NotImplementedException();
        }



        #endregion


        //////async Task Initialize_FirstLoad ( )
        //////{

        //////    try
        //////    {

        //////    }
        //////    catch ( Exception ex )
        //////    {
        //////        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //////        return;

        //////    }

        //////}


        // SRoofingLogisticsOwnerModelManager _iOwnerModel;


        public static SRoofingLanguageTranslateModel _iLanguageModel { get; set; } = new SRoofingLanguageTranslateModel();





        async Task SimulateStartup()
        {

            //TODO SRoofing
            try
            {

                //await Task.Delay(3000);

                if (Preferences.Get("user_IsLogin", false))

                {

                    _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);


                    MainThread.BeginInvokeOnMainThread(async () =>
                    {

                        // Code to run on the main thread


                        Navigation.InsertPageBefore(new Page_Landing_Dashboard(_iLanguageModel), this);

                        await Navigation.PopToRootAsync();




                        ////////////////////Application.Current.MainPage = new NavigationPage(new Page_Landing_Dashboard(_iLanguageModel));

                        ////////////////////await Navigation.PopToRootAsync();

                    });

                }
                else
                {

                    MainThread.BeginInvokeOnMainThread(async () =>
                    {

                        // Code to run on the main thread

                        Navigation.InsertPageBefore(new Page_Language(), this);

                        await Navigation.PopToRootAsync();


                        //await SRoofing_Page_OpenerManager
                        //                             .Page_Reset_Stack(
                        //                             Navigation,
                        //                             new Page_Language());


                    });






                    ////////////    ///

                    ////////////    //////////////////////////App.Current.MainPage.Handler.MauiContext.Services.GetService<IStartService> ( ).Service_Driver_DeliveryBookingReminderManager (
                    ////////////    //////////////////////////    App.Current ,
                    ////////////    //////////////////////////    SRoofingSync_Logistics_User_Owner_Manager.Sync_User_Owner_Get_UserModel ( Application.Current ) );



                    ////////////    if (Preferences.Get("app_IsFirstRun", true) == true)
                    ////////////    {

                    ////////////        MainThread.BeginInvokeOnMainThread(async () =>
                    ////////////        {
                    ////////////              // Code to run on the main thread
                    ////////////              await SRoofing_Page_OpenerManager
                    ////////////                                       .Page_Reset_Stack(
                    ////////////                                       Navigation,
                    ////////////                                       new Page_Splash_Dashboard());
                    ////////////        });
                    ////////////    }

                    ////////////    else
                    ////////////    {

                    ////////////        if (Preferences.Get("user_IsLogin", false) == true)
                    ////////////        {

                    ////////////            //SRoofing_Logistics_User_OwnerManager.Logistics_User_Owner_Initialize_UserModel ( );

                    ////////////            if (_iOwnerModel == null)
                    ////////////            {
                    ////////////                _iOwnerModel = SRoofingSync_Logistics_User_Owner_Manager.Sync_User_Owner_Get_UserModel(Application.Current);

                    ////////////            }

                    ////////////            //Sync_User_Owner_Get_UserModel

                    ////////////            if (_iOwnerModel.ApplicationRoleCode == iSRoofing_EnumManager.SRoofingEnum_RoleCode_ByApplication.RoleCode_APPLICATION_LOGISTICS_MARSHAL)
                    ////////////            {
                    ////////////                MainThread.BeginInvokeOnMainThread(async () =>
                    ////////////            {
                    ////////////                  // Code to run on the main thread
                    ////////////                  await SRoofing_Page_OpenerManager
                    ////////////                   .Page_Reset_Stack(
                    ////////////                   Navigation,
                    ////////////                   new S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing.Page_Map_Dashboard(_iOwnerModel));

                    ////////////            });
                    ////////////            }

                    ////////////            else if (_iOwnerModel.ApplicationRoleCode == iSRoofing_EnumManager.SRoofingEnum_RoleCode_ByApplication.RoleCode_APPLICATION_LOGISTICS_DRIVER)
                    ////////////            {
                    ////////////                MainThread.BeginInvokeOnMainThread(async () =>
                    ////////////                {
                    ////////////                      // Code to run on the main thread
                    ////////////                      await SRoofing_Page_OpenerManager
                    ////////////                       .Page_Reset_Stack(
                    ////////////                       Navigation,
                    ////////////                       new S1RoofingMU.iSRoofingApp.iSRoofing_Page.Access.Page_Driver_Access_Dashboard());

                    ////////////                });
                    ////////////            }

                    ////////////        }

                    ////////////        else
                    ////////////        {
                    ////////////            MainThread.BeginInvokeOnMainThread(async () =>
                    ////////////            {
                    ////////////                  // Code to run on the main thread
                    ////////////                  await SRoofing_Page_OpenerManager
                    ////////////                                          .Page_Reset_Stack(
                    ////////////                                          Navigation,
                    ////////////                                          new Page_Splash_Dashboard());
                    ////////////            });
                    ////////////        }


                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;


            }


        }

        private async void page_Launcher_Loaded(object sender, EventArgs e)
        {

            try
            {

                //await Initialize_BackgroundImageList();

                // Custom logic
                SRoofing_DebugManager.Debug_ShowSystemMessage("*** CreateWindow *** == " + "page_Launcher_Loaded");

                if (!_bln_IsInitialized_Page_Launcher_Dashboard)
                {
                    _bln_IsInitialized_Page_Launcher_Dashboard = true;

                    _ = Task.Run(async () =>
                    {

                                              bool bln_IsFirstRun = Preferences.Get("app_IsFirstRun", true);

                        if (bln_IsFirstRun == true)
                        {
                            await Initilalize();

                            await SimulateStartup();
                        }
                        else
                        {
                            await SimulateStartup();
                        }

                    });

                    //////Task.Run ( async ( ) =>
                    ////// {
                    //////     await SimulateStartup ( );
                    ////// } ).Wait ( );

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