
#if ANDROID


using Android.Webkit;
using Android.Widget;

using Java.Interop;

#endif

using S1RoofingMU.Platforms;

using System.Diagnostics;

namespace S1RoofingMU
{

    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

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


                var xxx = await webViewCall.EvaluateJavaScriptAsync("callFromCSharp('" + "SHAYMAA CS 2024" + "')");
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
                Console.WriteLine("WebSocket-WS ::: "  + ex.Message);
            }

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

                                Toast.MakeText(Android.App.Application.Context, "InvokeAction :: " + data, ToastLength.Long).Show();

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

  public class JsBridge {
  
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