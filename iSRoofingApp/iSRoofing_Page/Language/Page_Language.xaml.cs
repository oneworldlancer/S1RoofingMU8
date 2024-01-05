
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
////////////////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Dashboard;
//////////////////////////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
////////////////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Register;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Splash;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.ApplicationModel;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Language
{
    //////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Language : ContentPage
    {
        bool _bln_IsInitialized_Page_Language_Dashboard = false;
        bool _blnIsInitialized_BroadcastReceiver = false;

        public Page_Language()
        {

            InitializeComponent();



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


                            if (arg == typeof(Page_Language))
                            {

                                //get the value by `arg`

                                SRoofing_DebugManager.Debug_ShowSystemMessage("Page_Load == " + arg.ToString());

                                //lbl_LanguageAR

                                //            MainThread.BeginInvokeOnMainThread ( ( ) =>
                                //{
                                //      lbl_LanguageAR .HorizontalTextAlignment = TextAlignment.End;
                                //} );  







                                //                       await   Task.Run ( async ( ) =>
                                //                          {
                                //                              await pb_ProgressBar.Initialize ( );

                                //} ).ConfigureAwait ( false );

                                //await SRoofing_LanguageManager.Initilalize_LanguageList_ByLanguageCode ("ar" );


                                //await Task.Delay ( 10000 );

                                ////////     if ( !_bln_IsInitialized_Page_Language_Dashboard )
                                ////////     {
                                ////////         _bln_IsInitialized_Page_Language_Dashboard = true;

                                ////////           Task.Run ( async ( ) =>
                                ////////{


                                ////////    bool bln_IsFirstRun = Preferences.Get ( "app_IsFirstRun" , true );

                                ////////    if ( bln_IsFirstRun == true )
                                ////////    {
                                ////////        await Initilalize ( );

                                ////////        await SimulateStartup ( );
                                ////////    }
                                ////////    else
                                ////////    {
                                ////////        await SimulateStartup ( );
                                ////////    }

                                ////////} );   

                                ////////     }


                            }
                        }
                        catch (Exception ex)
                        {
                            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                            return;

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





        public static SRoofingLanguageTranslateModel _iLanguageModel { get; set; } = new SRoofingLanguageTranslateModel();


        async void frm_Lanhuage_AR_Tapped(object sender, EventArgs e)
        {
            try
            {

                var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

                if (objService != null)
                {
                    objService.KeyboardClick();
                }


                _iLanguageModel = new SRoofingLanguageTranslateModel();
                _iLanguageModel = await SRoofing_LanguageManager.Initilalize_LanguageList_ByLanguageCode("ar");

                await Initialize_AppTranslation();

                MainThread.BeginInvokeOnMainThread(async () =>
                 {

                     // Code to run on the main thread
                     st_LanguageList.IsVisible= false;
                     st_PermissionList.IsVisible= true;

                 });


                //await Request_PermissionsList();



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }

        }

        async void frm_Lanhuage_EN_Tapped(object sender, EventArgs e)
        {
            try
            {

                var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

                if (objService != null)
                {
                    objService.KeyboardClick();
                }


                _iLanguageModel = new SRoofingLanguageTranslateModel();
                _iLanguageModel = await SRoofing_LanguageManager.Initilalize_LanguageList_ByLanguageCode("en");


                await Initialize_AppTranslation();

                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    // Code to run on the main thread
                    st_LanguageList.IsVisible= false;
                    st_PermissionList.IsVisible= true;

                });


                //await Request_PermissionsList();






                //await Task.Delay ( 100 );

                //MainThread.BeginInvokeOnMainThread(async () =>
                //{

                //    // Code to run on the main thread
                //    //    await SRoofing_Page_OpenerManager
                //    //                                 .Page_Reset_Stack(
                //    //                                 Navigation,
                //    //                                 new Page_Splash(_iLanguageModel));

                //    Navigation.InsertPageBefore(new Page_Splash(_iLanguageModel), this);

                //    await Navigation.PopToRootAsync();



                //});


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }

        }

        async void frm_Lanhuage_FR_Tapped(object sender, EventArgs e)
        {
            try
            {

                var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

                if (objService != null)
                {
                    objService.KeyboardClick();
                }

                _iLanguageModel = new SRoofingLanguageTranslateModel();
                _iLanguageModel = await SRoofing_LanguageManager.Initilalize_LanguageList_ByLanguageCode("fr");

                await Initialize_AppTranslation();

                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    // Code to run on the main thread
                    st_LanguageList.IsVisible= false;
                    st_PermissionList.IsVisible= true;

                });


                //await Request_PermissionsList();



                //await Task.Delay ( 100 );

                //MainThread.BeginInvokeOnMainThread(async () =>
                //{

                //    // Code to run on the main thread
                //    //await SRoofing_Page_OpenerManager
                //    //                             .Page_Reset_Stack(
                //    //                             Navigation,
                //    //                             new Page_Splash(_iLanguageModel));

                //    Navigation.InsertPageBefore(new Page_Splash(_iLanguageModel), this);

                //    await Navigation.PopToRootAsync();



                //});


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }

        }

        private void page_Language_Loaded(object sender, EventArgs e)
        {
            try
            {

#if __ANDROID_33__

                frm_Permission_Storage.IsVisible= false;
                _bln_IsPermission_StorageRead= true;
                _bln_IsPermission_StorageWrite= true;

#else

                   frm_Permission_Storage.IsVisible= true;

#endif


                //////////#if ANDROID32_0_OR_GREATER
                //////////                frm_Permission_Storage.IsVisible= false;
                //////////                _bln_IsPermission_StorageRead= true;
                //////////                _bln_IsPermission_StorageWrite= true;

                //////////#else
                //////////                frm_Permission_Storage.IsVisible= true;


                //////////#endif



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }
        }

        async void btn_SubmitPermission_Clicked(object sender, EventArgs e)
        {

            try
            {

                //PermissionStatus cameraStatus = await Permissions.CheckStatusAsync<Permissions.Camera>();
                //PermissionStatus microphoneStatus = await Permissions.CheckStatusAsync<Permissions.Microphone>();

                //if (cameraStatus != PermissionStatus.Granted || microphoneStatus != PermissionStatus.Granted)
                //{
                //    // Request permissions only if they are not granted
                //    //PermissionStatus[ ] statuses = await Permissions.RequestAsync(new Microsoft.Maui.ApplicationModel.Permission[ ] { 
                //    //    Permissions.Camera, Permissions.Microphone });
                //}
                //else {

                //    Navigation.InsertPageBefore(new Page_Splash(_iLanguageModel), this);

                //    await Navigation.PopToRootAsync();

                //}


                if (_bln_IsPermission_Camera  &&
           //_bln_IsPermission_Contacts  &&
           _bln_IsPermission_Location  &&
           _bln_IsPermission_Microphone  &&
           _bln_IsPermission_Photos  &&
                  //_bln_IsPermission_SMS  &&
                  _bln_IsPermission_StorageRead  &&
            _bln_IsPermission_StorageWrite)
                {

                    _bln_IsPermission_ALL= true;

                    //MainThread.BeginInvokeOnMainThread(async () =>
                    //{
                    //    img_Permission_Camera.Source="img_circle_check_orange.png";
                    //    //img_Permission_Contact.Source="img_circle_check_orange.png";
                    //    img_Permission_Location.Source="img_circle_check_orange.png";
                    //    img_Permission_Microphone.Source="img_circle_check_orange.png";
                    //    img_Permission_Photo.Source="img_circle_check_orange.png";
                    //    //img_Permission_SMS.Source="img_circle_check_orange.png";
                    //    img_Permission_Stroage.Source="img_circle_check_orange.png";

                    //});

                    Navigation.InsertPageBefore(new Page_Splash(_iLanguageModel), this);

                    await Navigation.PopToRootAsync();


                }
                else
                {
                    _bln_IsPermission_ALL=false;
                    return;
                }





                //if (_bln_IsPermission_ALL)
                //{

                //    Navigation.InsertPageBefore(new Page_Splash(_iLanguageModel), this);

                //    await Navigation.PopToRootAsync();

                //}
                //else
                //{

                //}


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }
        }

        async void frm_Permission_Storage_Tapped(object sender, TappedEventArgs e)
        {

            try
            {

                ///* permissions_StoragRead */
                var permissions_StoragRead = await Permissions.CheckStatusAsync<Permissions.StorageRead>();

                if (permissions_StoragRead == PermissionStatus.Granted)
                {
                    //img_Permission_Camera.Source="img_circle_check_orange.png";
                    //_bln_IsPermission_Camera=true;
                    //return;
                }


                if (Permissions.ShouldShowRationale<Permissions.StorageRead>())
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                }



                /* permissions_StorageWrite */
                var permissions_StorageWrite = await Permissions.CheckStatusAsync<Permissions.StorageWrite>();

                if (permissions_StorageWrite == PermissionStatus.Granted)
                {
                    //img_Permission_Camera.Source="img_circle_check_orange.png";
                    _bln_IsPermission_StorageRead=true;
                    _bln_IsPermission_StorageWrite=true;
                    //     return;
                }


                if (Permissions.ShouldShowRationale<Permissions.StorageWrite>())
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                }










                permissions_StoragRead = await Permissions.RequestAsync<Permissions.StorageRead>();

                if (permissions_StoragRead != PermissionStatus.Granted)
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                    //permissions_Camera= await Permissions.RequestAsync<Permissions.Camera>();
                }
                else
                {
                    //img_Permission_Camera.Source="img_circle_check_orange.png";
                    _bln_IsPermission_StorageRead=true;

                }

                permissions_StorageWrite = await Permissions.RequestAsync<Permissions.StorageWrite>();

                if (permissions_StorageWrite != PermissionStatus.Granted)
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                    //permissions_Camera= await Permissions.RequestAsync<Permissions.Camera>();
                }
                else
                {
                    //img_Permission_Camera.Source="img_circle_check_orange.png";
                    _bln_IsPermission_StorageRead=true;
                    _bln_IsPermission_StorageWrite=true;


                }

                if (_bln_IsPermission_StorageRead && _bln_IsPermission_StorageWrite)
                {
                    img_Permission_Stroage.Source="img_circle_check_orange.png";
                    _bln_IsPermission_StorageRead=true;
                    _bln_IsPermission_StorageWrite=true;
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }



        }

        async void frm_Permission_SMS_Tapped(object sender, TappedEventArgs e)
        {

            try
            {


                /* permissions_Camera */
                var permissions_Camera = await Permissions.CheckStatusAsync<Permissions.Sms>();

                if (permissions_Camera == PermissionStatus.Granted)
                {
                    //img_Permission_SMS.Source="img_circle_check_orange.png";
                    //_bln_IsPermission_SMS=true;
                    return;
                }


                if (Permissions.ShouldShowRationale<Permissions.Sms>())
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                }

                permissions_Camera = await Permissions.RequestAsync<Permissions.Sms>();

                if (permissions_Camera != PermissionStatus.Granted)
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                    //permissions_Camera= await Permissions.RequestAsync<Permissions.Camera>();
                }
                else
                {
                    //img_Permission_SMS.Source="img_circle_check_orange.png";
                    //_bln_IsPermission_SMS=true;

                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }


        }

        async void frm_Permission_Photo_Tapped(object sender, TappedEventArgs e)
        {

            try
            {


                /* permissions_Camera */
                var permissions_Camera = await Permissions.CheckStatusAsync<Permissions.Photos>();

                if (permissions_Camera == PermissionStatus.Granted)
                {
                    img_Permission_Photo.Source="img_circle_check_orange.png";
                    _bln_IsPermission_Photos=true;
                    return;
                }


                if (Permissions.ShouldShowRationale<Permissions.Photos>())
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                }

                permissions_Camera = await Permissions.RequestAsync<Permissions.Photos>();

                if (permissions_Camera != PermissionStatus.Granted)
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                    //permissions_Camera= await Permissions.RequestAsync<Permissions.Camera>();
                }
                else
                {
                    img_Permission_Photo.Source="img_circle_check_orange.png";
                    _bln_IsPermission_Photos=true;

                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }


        }

        async void frm_Permission_Microphone_Tapped(object sender, TappedEventArgs e)
        {

            try
            {


                /* permissions_Camera */
                var permissions_Camera = await Permissions.CheckStatusAsync<Permissions.Microphone>();

                if (permissions_Camera == PermissionStatus.Granted)
                {
                    img_Permission_Microphone.Source="img_circle_check_orange.png";
                    _bln_IsPermission_Microphone=true;
                    return;
                }


                if (Permissions.ShouldShowRationale<Permissions.Microphone>())
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                }

                permissions_Camera = await Permissions.RequestAsync<Permissions.Microphone>();

                if (permissions_Camera != PermissionStatus.Granted)
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                    //permissions_Camera= await Permissions.RequestAsync<Permissions.Camera>();
                }
                else
                {
                    img_Permission_Microphone.Source="img_circle_check_orange.png";
                    _bln_IsPermission_Microphone=true;

                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }


        }

        async void frm_Permission_Location_Tapped(object sender, TappedEventArgs e)
        {

            try
            {


                /* permissions_Camera */
                var permissions_Camera = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

                if (permissions_Camera == PermissionStatus.Granted)
                {
                    img_Permission_Location.Source="img_circle_check_orange.png";
                    _bln_IsPermission_Location=true;
                    return;
                }


                if (Permissions.ShouldShowRationale<Permissions.LocationWhenInUse>())
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                }

                permissions_Camera = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

                if (permissions_Camera != PermissionStatus.Granted)
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                    //permissions_Camera= await Permissions.RequestAsync<Permissions.Camera>();
                }
                else
                {
                    img_Permission_Location.Source="img_circle_check_orange.png";
                    _bln_IsPermission_Location=true;

                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }


        }

        async void frm_Permission_Contact_Tapped(object sender, TappedEventArgs e)
        {

            try
            {


                /* permissions_Camera */
                var permissions_Camera = await Permissions.CheckStatusAsync<Permissions.ContactsRead>();

                if (permissions_Camera == PermissionStatus.Granted)
                {
                    //img_Permission_Contact.Source="img_circle_check_orange.png";
                    //_bln_IsPermission_Contacts=true;
                    return;
                }


                if (Permissions.ShouldShowRationale<Permissions.ContactsRead>())
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                }

                permissions_Camera = await Permissions.RequestAsync<Permissions.ContactsRead>();

                if (permissions_Camera != PermissionStatus.Granted)
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                    //permissions_Camera= await Permissions.RequestAsync<Permissions.Camera>();
                }
                else
                {
                    //img_Permission_Contact.Source="img_circle_check_orange.png";
                    //_bln_IsPermission_Contacts=true;

                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }


        }

        async void frm_Permission_Camera_Tapped(object sender, TappedEventArgs e)
        {

            try
            {


                /* permissions_Camera */
                var permissions_Camera = await Permissions.CheckStatusAsync<Permissions.Camera>();

                if (permissions_Camera == PermissionStatus.Granted)
                {
                    img_Permission_Camera.Source="img_circle_check_orange.png";
                    _bln_IsPermission_Camera=true;
                    return;
                }


                if (Permissions.ShouldShowRationale<Permissions.Camera>())
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                }

                permissions_Camera = await Permissions.RequestAsync<Permissions.Camera>();

                if (permissions_Camera != PermissionStatus.Granted)
                {
                    await DisplayAlert("Permission needed", "App need to access device!!!", "OK");
                    //permissions_Camera= await Permissions.RequestAsync<Permissions.Camera>();
                }
                else
                {
                    img_Permission_Camera.Source="img_circle_check_orange.png";
                    _bln_IsPermission_Camera=true;

                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }


        }


        #region PermissionsList


        bool _bln_IsPermission_Camera,
           //_bln_IsPermission_Contacts,
           _bln_IsPermission_Location,
           _bln_IsPermission_Microphone,
           _bln_IsPermission_Photos,
                  //_bln_IsPermission_SMS,
                  _bln_IsPermission_StorageRead,
            _bln_IsPermission_StorageWrite,

          _bln_IsPermission_ALL;

        async Task Request_PermissionsList()
        {


            try
            {

                //Permissions[ ] prm = new Permissions[ ] { Permissions.Camera, Permissions.Microphone };

                //PermissionStatus[ ] statuses = await RequestMultiplePermissionsAsync(prm);






                ////////////////////////

                await Task.Delay(2000);

                /* permissions_Camera */
                var permissions_Camera = await Permissions.CheckStatusAsync<Permissions.Camera>();
                if (permissions_Camera != PermissionStatus.Granted)
                {
                    permissions_Camera= await Permissions.RequestAsync<Permissions.Camera>();
                }


                await Task.Delay(500);


                /* permissions_ContactsRead */
                var permissions_ContactsRead = await Permissions.CheckStatusAsync<Permissions.ContactsRead>();
                if (permissions_ContactsRead != PermissionStatus.Granted)
                {
                    permissions_ContactsRead = await Permissions.RequestAsync<Permissions.ContactsRead>();
                }


                await Task.Delay(500);


                /* permissions_Location */
                var permissions_Location = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
                if (permissions_Location != PermissionStatus.Granted)
                {
                    permissions_Location = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
                }


                await Task.Delay(500);


                /* permissions_Write */
                var permissions_Microphone = await Permissions.CheckStatusAsync<Permissions.Microphone>();
                if (permissions_Microphone != PermissionStatus.Granted)
                {
                    permissions_Microphone = await Permissions.RequestAsync<Permissions.Microphone>();
                }


                await Task.Delay(500);


                /* permissions_Photos */
                var permissions_Photos = await Permissions.CheckStatusAsync<Permissions.Photos>();
                if (permissions_Photos != PermissionStatus.Granted)
                {
                    permissions_Photos = await Permissions.RequestAsync<Permissions.Photos>();
                }


                await Task.Delay(500);


                /* permissions_Sms */
                var permissions_Sms = await Permissions.CheckStatusAsync<Permissions.Sms>();
                if (permissions_Sms != PermissionStatus.Granted)
                {
                    permissions_Sms = await Permissions.RequestAsync<Permissions.Sms>();
                }


                await Task.Delay(500);





                /* permissions_Read */
                var permissions_Read = await Permissions.CheckStatusAsync<Permissions.StorageRead>();
                if (permissions_Read != PermissionStatus.Granted)
                {
                    permissions_Read = await Permissions.RequestAsync<Permissions.StorageRead>();
                }

                //if (permissions_Read != PermissionStatus.Granted)
                //{
                //    return;
                //}

                await Task.Delay(500);


                /* permissions_Write */
                var permissions_Write = await Permissions.CheckStatusAsync<Permissions.StorageWrite>();
                if (permissions_Write != PermissionStatus.Granted)
                {
                    permissions_Write = await Permissions.RequestAsync<Permissions.StorageWrite>();
                }

                //if (permissions_Write != PermissionStatus.Granted)
                //{
                //    return;
                //}

                await Task.Delay(500);

                //////////////////////////////////////////////////

                PermissionStatus statusCamera = await Permissions.CheckStatusAsync<Permissions.Camera>();

                if (statusCamera == PermissionStatus.Granted)
                    _bln_IsPermission_Camera=true;



                //PermissionStatus statusContactsRead = await Permissions.CheckStatusAsync<Permissions.ContactsRead>();

                //if (statusContactsRead == PermissionStatus.Granted)
                //_bln_IsPermission_Contacts=true;




                PermissionStatus statusLocation = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

                if (statusLocation == PermissionStatus.Granted)
                    _bln_IsPermission_Location=true;



                PermissionStatus statusMicrophone = await Permissions.CheckStatusAsync<Permissions.Microphone>();

                if (statusMicrophone == PermissionStatus.Granted)
                    _bln_IsPermission_Microphone=true;






                PermissionStatus statusPhotos = await Permissions.CheckStatusAsync<Permissions.Photos>();

                if (statusPhotos == PermissionStatus.Granted)
                    _bln_IsPermission_Photos=true;






                //PermissionStatus statusSMS = await Permissions.CheckStatusAsync<Permissions.Sms>();

                //if (statusSMS == PermissionStatus.Granted)
                //    _bln_IsPermission_SMS=true;






                PermissionStatus statusStorageRead = await Permissions.CheckStatusAsync<Permissions.StorageRead>();

                if (statusStorageRead == PermissionStatus.Granted)
                    _bln_IsPermission_StorageRead=true;




                PermissionStatus statusStorageWrite = await Permissions.CheckStatusAsync<Permissions.StorageWrite>();

                if (statusStorageWrite  == PermissionStatus.Granted)
                    _bln_IsPermission_StorageWrite =true;





                if (_bln_IsPermission_Camera  &&
           //_bln_IsPermission_Contacts  &&
           _bln_IsPermission_Location  &&
           _bln_IsPermission_Microphone  &&
           _bln_IsPermission_Photos  &&
                  //_bln_IsPermission_SMS  &&
                  _bln_IsPermission_StorageRead  &&
            _bln_IsPermission_StorageWrite)
                {

                    _bln_IsPermission_ALL= true;

                    MainThread.BeginInvokeOnMainThread(async () =>
                    {
                        img_Permission_Camera.Source="img_circle_check_orange.png";
                        //img_Permission_Contact.Source="img_circle_check_orange.png";
                        img_Permission_Location.Source="img_circle_check_orange.png";
                        img_Permission_Microphone.Source="img_circle_check_orange.png";
                        img_Permission_Photo.Source="img_circle_check_orange.png";
                        //img_Permission_SMS.Source="img_circle_check_orange.png";
                        img_Permission_Stroage.Source="img_circle_check_orange.png";

                    });

                }
                else
                {
                    _bln_IsPermission_ALL=false;
                }





            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }

        }







        #endregion



        #region AppTranslation

        async Task Initialize_AppTranslation()
        {
            try
            {

                if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);

                MainThread.BeginInvokeOnMainThread(() =>
                {

                    lbl_Permission_Camera.Text= _iLanguageModel.lblText_Permission_Camera_Message;
                    //lbl_Permission_Contact.Text= _iLanguageModel.lblText_Permission_Contact_Message;
                    lbl_Permission_Location.Text= _iLanguageModel.lblText_Permission_Location_Message;
                    lbl_Permission_Microphone.Text= _iLanguageModel.lblText_Permission_Microphone_Message;
                    lbl_Permission_Photo.Text= _iLanguageModel.lblText_Permission_Photo_Message;
                    lbl_Permission_Storage.Text= _iLanguageModel.lblText_Permission_Storage_Message;
                    //lbl_Permission_SMS.Text= _iLanguageModel.lblText_Permission_SMS_Message;

                    btn_SubmitPermission.Text = _iLanguageModel.lblText_Command_Submit;
                    //lbl_TabCall.Text = _iLanguageModel.lblText_Tab_Calls;


                });


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