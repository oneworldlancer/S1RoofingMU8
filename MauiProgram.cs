using epj.ProgressBar.Maui;

using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;

using S1RoofingMU.iSRoofingApp.iMaui_Handler;
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.Entry;

using Plugin.Maui.Audio;
using S1RoofingMU.Platforms;
using CommunityToolkit.Maui;

namespace S1RoofingMU
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                 .UseMauiCommunityToolkit()
               .UseMauiCommunityToolkitMediaElement()

           .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                  .ConfigureEssentials(essentials =>
                  {
                      essentials.UseVersionTracking();
                  })
       //.UseMauiCameraView() // Add the use of the plugging        
       //.UseFFImageLoading()
       .UseProgressBar()

      .UseMauiCompatibility()
      .ConfigureMauiHandlers((handlers) =>
      {

#if ANDROID
          handlers.AddCompatibilityRenderer(
              typeof(UCView_EntryChatView),
              typeof(S1RoofingMU.iSRoofingApp.Droid.iSRoofing_Render.Entry.Render_EntryChatView));
#elif IOS
          handlers.AddCompatibilityRenderer(
          typeof(UCView_EntryChatView),
          typeof(S1RoofingMU.iSRoofingApp.iOS.iSRoofing_Render.Entry.Render_EntryChatView));
#endif
      });

#if DEBUG
            builder.Logging.AddDebug();
#endif


            builder.Services.AddSingleton<iSRoofing_DependencyService_DeviceModel, DependencyService_DeviceModel>();
            builder.Services.AddSingleton<iSRoofing_DependencyService_SoundClick, DependencyService_SoundClick>();
            builder.Services.AddSingleton<iSRoofing_DependencyService_SaveMediaDataFile, DependencyService_SaveMediaDataFile>();
            builder.Services.AddSingleton<iSRoofing_DependencyService_VideoModel, DependencyService_VideoModel>();
            builder.Services.AddSingleton(AudioManager.Current);
      
            
            CustomizeWebViewHandler();



            FormHandler.RemoveBorders();


    


            return builder.Build();
        }





        static void CustomizeWebViewHandler()
        {
#if ANDROID
            Microsoft.Maui.Handlers.WebViewHandler.Mapper.Add("WebChromeClient", (handler, view) =>
            {
                Android.Webkit.WebView.SetWebContentsDebuggingEnabled(true);

                handler.PlatformView.Settings.UseWideViewPort= true;
                handler.PlatformView.Settings.JavaScriptEnabled= true;
                handler.PlatformView.Settings.JavaScriptCanOpenWindowsAutomatically= true;
                handler.PlatformView.Settings.MediaPlaybackRequiresUserGesture= false;


                handler.PlatformView.Settings.AllowContentAccess=true;
                handler.PlatformView.Settings.AllowFileAccess=true;
                handler.PlatformView.Settings.SetAppCacheEnabled(true);
                handler.PlatformView.Settings.DomStorageEnabled=true;


                handler.PlatformView.SetWebViewClient(new CustomWebViewClient());
                handler.PlatformView.SetWebChromeClient(new CustomWebChromeClient());


                ////////////////////////////////////

                //////////handler.PlatformView.SetWebViewClient(new JavascriptWebViewClient($"javascript: {JavascriptFunction}"));
                //////////handler.PlatformView.AddJavascriptInterface(new JsBridge(this), "jsBridge");

            });
#elif WINDOWS
#elif IOS
#endif
        }





    }
}