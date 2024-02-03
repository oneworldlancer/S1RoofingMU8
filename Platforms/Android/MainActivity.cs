using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Telephony;
using Android.Views;

using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

using Plugin.FirebasePushNotification;

using S1RoofingMU.Platforms.Android;

using System.Net;

namespace S1RoofingMU
{
    [Activity ( Theme = "@style/Maui.SplashTheme" ,
     MainLauncher = true ,
     ScreenOrientation = ScreenOrientation.Portrait ,
     ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density )]
    public class MainActivity : MauiAppCompatActivity
    {
        //add this property  
        public static MainActivity InstanceActivity { get; set; }

        protected override void OnCreate ( Bundle savedInstanceState )
        {
            base.OnCreate ( savedInstanceState );

            //set it  
            InstanceActivity = this;

            if ( Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat )
            {
                Android.Webkit.WebView.SetWebContentsDebuggingEnabled ( true );

            }

            // Request camera and microphone permissions
            //////////ActivityCompat.RequestPermissions(this, new[ ] { Manifest.Permission.Camera, Manifest.Permission.RecordAudio, Manifest.Permission.ModifyAudioSettings }, 0);




            var handler = new HttpClientHandler ( );
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                ( httpRequestMessage , cert , cetChain , policyErrors ) => true;

            var client = new HttpClient ( handler );




            //#if DEBUG
            ServicePointManager.ServerCertificateValidationCallback += ( o , certificate , chain , errors ) => true;
            //#endif


            App.Current
                .On<Microsoft.Maui.Controls.PlatformConfiguration.Android> ( )
                .UseWindowSoftInputModeAdjust ( WindowSoftInputModeAdjust.Resize );


            var window = ( Platform.CurrentActivity ).Window;
            window.SetSoftInputMode ( SoftInput.StateHidden );



            ////////var handlerX = new HttpClientHandler();
            ////////handlerX.ClientCertificateOptions = ClientCertificateOption.Manual;
            ////////handlerX.ServerCertificateCustomValidationCallback =
            ////////    (httpRequestMessage, cert, cetChain, policyErrors) => true;

            ////////var clientX = new HttpClient(handlerX);

            ////////var config = new FFImageLoading.Config.Configuration()
            ////////{
            ////////    VerboseLogging = false,
            ////////    VerbosePerformanceLogging = false,
            ////////    VerboseMemoryCacheLogging = false,
            ////////    VerboseLoadingCancelledLogging = false,
            ////////    //Logger = new CustomLogger(),
            ////////    HttpClient = clientX
            ////////};

            //////////FFImageLoading.Config=.ImageService.Config=config;

            ////////ImageService.Instance.Initialize(new FFImageLoading.Config.Configuration
            ////////{
            ////////    HttpClient = clientX
            ////////});

            //var telephonyManager = ( TelephonyManager ) GetSystemService ( TelephonyService ); 
            //var phoneCallListener = new PhoneCallListener ( ); 
            //telephonyManager.Listen ( phoneCallListener , PhoneStateListenerFlags.CallState );

            FirebasePushNotificationManager.ProcessIntent ( this , Intent );

        }



        protected override void OnNewIntent ( Intent intent )
        {
            base.OnNewIntent ( intent );
            FirebasePushNotificationManager.ProcessIntent ( this , intent );
        }

    }
}