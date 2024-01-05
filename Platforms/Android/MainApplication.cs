using Android.App;
using Android.OS;
using Android.Runtime;

using Newtonsoft.Json;

using Plugin.FirebasePushNotification;

using S1RoofingMU.iSRoofingApp.iSRoofing_GCMManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

namespace S1RoofingMU
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();



        public override void OnCreate()
        {
            base.OnCreate();

            //Set the default notification channel for your app when running Android Oreo  
            if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
            {
                //Change for your default notification channel id here  
                FirebasePushNotificationManager.DefaultNotificationChannelId = "FirebasePushNotificationChannel";

                //Change for your default notification channel name here  
                FirebasePushNotificationManager.DefaultNotificationChannelName = "General";
            }

            //If debug you should reset the token each time.  
            ////////////#if DEBUG
            ////////////        FirebasePushNotificationManager.Initialize(this, true);
            ////////////#else
            ////////////              FirebasePushNotificationManager.Initialize(this,false);  
            ////////////#endif

            FirebasePushNotificationManager.Initialize(this, false);


            //Handle notification when app is closed here  
            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage("**************************************** OnNotificationReceived ****************************************");
                //foreach ( var data in p.Data )
                //{
                //    //   System.Diagnostics.Debug.WriteLine ( $"{data.Key} : {data.Value}" );

                //    SRoofing_DebugManager.Debug_ShowSystemMessage ( $"{data.Key} : {data.Value}" );
                //}


                foreach (var data in p.Data)
                {
                    //   System.Diagnostics.Debug.WriteLine ( $"{data.Key} : {data.Value}" );

                    SRoofing_DebugManager.Debug_ShowSystemMessage($"{data.Key} : {data.Value}");
                    if (data.Key == "body")
                    {

                        // var jsonData = JsonConvert.DeserializeObject<List<dynamic>> ( ( string ) data.Value );



                        dynamic iDynamicMessage = data.Value;

                        //  List<dynamic> jsonData = JsonConvert.DeserializeObject<List<dynamic>> ( iDynamicMessage );
                        dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(data.Value.ToString());

                        //SRoofing_DebugManager.Debug_ShowSystemMessage ( "################################ acctyp ################################" + jsonData.acctyp.ToString ( ) );

                        SRoofing_DebugManager.Debug_ShowSystemMessage("################################ START ################################" + jsonData.acctyp.ToString());

                        //
                        _=  Task.Run(async () =>
                        {

                            await Task.Run(async () =>
                            {

                                await SRoofing_GCMMessageManager.IntentService_ParseIntentExtras(jsonData);

                            });


                        }).ConfigureAwait(false);

                        SRoofing_DebugManager.Debug_ShowSystemMessage("################################ END ################################" + jsonData.acctyp.ToString());

                        break;
                    }
                }


            };





            CrossFirebasePushNotification.Current.OnNotificationOpened += (s, p) =>
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage("**************************************** OnNotificationOpened ****************************************");


                System.Diagnostics.Debug.WriteLine("Opened");
                //  dynamic iDynamicMessage = null;

                foreach (var data in p.Data)
                {
                    //   System.Diagnostics.Debug.WriteLine ( $"{data.Key} : {data.Value}" );

                    SRoofing_DebugManager.Debug_ShowSystemMessage($"{data.Key} : {data.Value}");
                    if (data.Key == "body")
                    {

                        var jsonData = JsonConvert.DeserializeObject<List<dynamic>>((string)data.Value);



                        //dynamic iDynamicMessage = data.Value;

                        // string acctypX = iDynamicMessage.acctyp;

                        SRoofing_DebugManager.Debug_ShowSystemMessage("################################ acctyp ################################" + jsonData.ToString());

                        break;
                    }
                }


                //SRoofing_DebugManager.Debug_ShowSystemMessage ( "################################ acctyp ################################" + acctyp );

            };


            CrossFirebasePushNotification.Current.OnNotificationAction += (s, p) =>
            {
                System.Diagnostics.Debug.WriteLine("Action");

                if (!string.IsNullOrEmpty(p.Identifier))
                {
                    SRoofing_DebugManager.Debug_ShowSystemMessage("**************************************** OnNotificationAction ****************************************");
                    System.Diagnostics.Debug.WriteLine($"ActionId: {p.Identifier}");
                    foreach (var data in p.Data)
                    {
                        //  System.Diagnostics.Debug.WriteLine ( $"{data.Key} : {data.Value}" );
                        SRoofing_DebugManager.Debug_ShowSystemMessage($"{data.Key} : {data.Value}");
                    }

                }

            };






        }


    }
}