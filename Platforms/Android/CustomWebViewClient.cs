using Android.Webkit;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using WebViewX = Android.Webkit.WebView;


namespace S1RoofingMU.Platforms
{
   
    internal class CustomWebViewClient : WebViewClient
    {
        public CustomWebViewClient()
        {
        }



        ////////////////////////////////////////
        /////
        //private readonly string javascript;

        //public CustomWebViewClient(string javascript) : base()
        //{
        //    this.javascript = javascript;
        //}

        public override void OnPageFinished(WebViewX view, string url)
        {
            base.OnPageFinished(view, url);
            //view.EvaluateJavascript(javascript, null);
        }



        public override bool ShouldOverrideUrlLoading( WebViewX view, IWebResourceRequest request)
        {
            var url = request.Url.ToString();
            if (url.StartsWith("https://mywebsite.com"))
            {
                // Allow the WebView to load the URL
                return false;
            }
            else
            {
                // Cancel the navigation in the WebView
                // Open the URL in the default browser
                //Launcher.TryOpenAsync(url);
                return true;
            }
        }







        /// <summary>
        /// //////////////////////////////////
        /// </summary>
        /// <param name="view"></param>
        /// <param name="url"></param>
        //public override void OnPageFinished(WebView view, string url)
        //{
        //    base.OnPageFinished(view, url);

        //    // Your Logic comes here
        //}

        public override void OnReceivedHttpError(WebViewX view, IWebResourceRequest request, WebResourceResponse errorResponse)
        {
            //get error from errorResponse  
            base.OnReceivedHttpError(view, request, errorResponse);
        }

    }
}
