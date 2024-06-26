﻿
#if ANDROID


using Android.Webkit;
using Android.Widget;

using Java.Interop;

#endif

using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Storage;

using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.Platforms;

using System.Diagnostics;
using System.Text;

namespace S1RoofingMU
{
    // cam=&caltknid=&ownid=&ownmpoid=&rmtid=&rmtmobid=&caltag=&caldir=&caltyp=


    public partial class MainPage : ContentPage
    {
        int count = 0;
        //        private readonly IFileSaver fileSaver;
        //IFileSaver fileSaver
        public MainPage()
        {
            InitializeComponent();

            //imgURL.Source="/storage/emulated/0/Download/7521121026864ca4b372f60b144508ec.jpg";

            //this.fileSaver = fileSaver;
            // cam=&caltknid=&ownid=&ownmobid=&rmtid=&rmtmobid=&caltag=&caldir=&caltyp=

            //# Owner
            //
            //cam=front&caltknid=11011101&ownid=2202&ownmobid=2202x&rmtid=1101&rmtmobid=1101x&caltag=answer&caldir=in&caltyp=video

            //#Remote
            //
            //cam=front&caltknid=11011101&ownid=1101&ownmobid=1101x&rmtid=2202&rmtmobid=2202x&caltag=answer&caldir=in&caltyp=video

            webViewCall.Source="WebRTC/Landing_Chat/Index.html";

            //webViewCall.Source="WebRTC/Source/Index.html?" +

            //    "cam=" + "front" +
            //    "&caltknid=" + "11011101" +
            //    "&ownid=" +"1101" +
            //    "&ownmobid=" + "1101x"+
            //    "&rmtid=" + "2202" +
            //    "&rmtmobid=" + "2202x" +
            //    "&caltag=" + "offer" +
            //    "&caldir=" + "out" +
            //    "&caltyp=" + "video";




            CustomizeWebViewHandler();

#if ANDROID

            // Add the JavaScript interface in the WebView
            //webViewCall.AddJavascriptInterface(new JsBridge(webViewCall), "jsBridge");


#endif
            //theWebViewControl.EnableWebDevTools= true;
            //theWebViewControl.chr(new MyWebChromeClient());
        }

        async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            try
            {

                string folderPath = System.IO.Path.Combine(FileSystem.Current.AppDataDirectory, "SRoofingUser1XXX");
                System.IO.Directory.CreateDirectory(folderPath);


                /////////////////////////////////

                using var stream = new MemoryStream(Encoding.Default.GetBytes("Hello from the Community Toolkit!"));

                var newFile = Path.Combine(folderPath, "testXXX.txt");

                //using (var stream = await photo.OpenReadAsync())

                using (var newStream = File.OpenWrite(newFile))
                    await stream.CopyToAsync(newStream);

                await CommunityToolkit.Maui.Alerts.Toast.Make($"The file was saved successfully to location: {newFile}").Show(CancellationToken.None);
             
                SRoofing_DebugManager.Debug_ShowSystemMessage(newFile);

                //var fileSaverResult = await FileSaver.Default.SaveAsync("test.txt", stream, CancellationToken.None);

                await CommunityToolkit.Maui.Alerts.Toast.Make($"File is saved: ").Show(CancellationToken.None);

                //////////System.IO.Directory.CreateDirectory(folderPath);
                //////////var filePath = System.IO.Path.Combine(folderPath, "test.txt");
                //////////var fileSaverResult = await FileSaver.Default.SaveAsync(filePath, stream, CancellationToken.None);

                //////////fileSaverResult.EnsureSuccess();

                //////////if (fileSaverResult.IsSuccessful)
                //////////{
                //////////    await CommunityToolkit.Maui.Alerts.Toast.Make($"The file was saved successfully to location: {fileSaverResult.FilePath}").Show(CancellationToken.None);
                //////////}
                //////////else
                //////////{
                //////////    await CommunityToolkit.Maui.Alerts.Toast.Make($"The file was not saved successfully with error: {fileSaverResult.Exception.Message}").Show(CancellationToken.None);
                //////////}

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }


            //////////try
            //////////{


            //////////    //var xxx = await webViewCall.EvaluateJavaScriptAsync("callFromCSharp('" + "SHAYMAA CS 2024" + "')");

            //////////    // Create a stopwatch instance
            //////////    var stopwatch = new Stopwatch();

            //////////    // Create a timer instance
            //////////    IDispatcherTimer? timer = Application.Current.Dispatcher.CreateTimer();

            //////////    // Set the timer interval to one second
            //////////    timer.Interval = TimeSpan.FromSeconds(1);

            //////////    // Subscribe to the Tick event
            //////////    timer.Tick += (s, e) =>
            //////////    {
            //////////        // Update the label text with the elapsed time
            //////////        // Use MainThread.BeginInvokeOnMainThread to ensure UI updates are done on the UI thread
            //////////        MainThread.BeginInvokeOnMainThread(() =>
            //////////        {
            //////////            lbl_Result.Text = stopwatch.Elapsed.ToString("hh\\:mm\\:ss");
            //////////        });
            //////////    };

            //////////    // Start the stopwatch and the timer
            //////////    stopwatch.Start();
            //////////    timer.Start();


            //////////}
            //////////catch (Exception ex)
            //////////{
            //////////    Console.WriteLine("WebSocket-WS ::: "  + ex.Message);
            //////////}

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }



        // Define a C# method that you want to invoke from JavaScript
        public static void MyCSharpMethod()
        {
            // Your C# code here
            Console.WriteLine("MyCSharpMethod-WS ::: ");
            ///   DisplayAlert("titleX", "msg-MyCSharpMethod", "OK");
        }

        private void webViewCall_Navigating(object sender, WebNavigatingEventArgs e)
        {
            if (e.Url.Contains("/api/"))
            {

                e.Cancel = true;

                //e.Cancel();

                var dataId = e.Url.Substring(e.Url.IndexOf("/api/") + 5);

                DisplayAlert("titleX", dataId, "OK");

                e.Cancel = true;


                //Dispatcher.DispatchDelayed(5,);

                //////////Task.Run(() => {

                //////////    Dispatcher.Dispatch(async () => {

                //////////        var data = await webViewCall.EvaluateJavaScriptAsync($"getData({dataId})");
                //////////        var cdData = JsonSerializer.Deserialize<CsData>(data.Replace("\\", ""));

                //////////        //Now Call the corresponding C# Funktion with data
                //////////        // - this is only a simple example
                //////////        // - you could also use a ICommand Interface, create an instance of a class implementing ICommand dynamically from csData.command and call it's execute Method, or ...
                //////////        if (cdData != null)
                //////////        {
                //////////            switch (cdData.command)
                //////////            {
                //////////                case "Debug.WriteLine":
                //////////                    Debug.WriteLine(cdData.data);

                //////////                    //Just for the Show...
                //////////                    await webViewCall.EvaluateJavaScriptAsync($"log('{cdData.command} with dataId {cdData.dataId} was executed...')");
                //////////                    break;
                //////////            }
                //////////        }
                //////////    });
                //////////});

                return;

            }
        }


        //private async Task RequestCameraPermission()
        //{
        //    PermissionStatus status = await Permissions.CheckStatusAsync<Permissions.Camera>();

        //    if (status != PermissionStatus.Granted)
        //        await Permissions.RequestAsync<Permissions.Camera>();
        //}


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

                                Console.WriteLine("JavascriptInterface :: " + data);

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









    }










    // ReSharper disable InconsistentNaming
    internal class CsData
    {
        public int dataId { get; set; }
        public string command { get; set; }
        public string data { get; set; }
    }
}