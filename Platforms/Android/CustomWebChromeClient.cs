using Android.Webkit;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.Platforms
{
    internal class CustomWebChromeClient : WebChromeClient
    {

        //private MainActivity activity = null;

        //public CustomWebChromeClient(MainActivity context)
        //{
        //    this.activity = context;
        //}


        //public override void OnPermissionRequest(PermissionRequest request)
        //{

        //    foreach (var resource in request.GetResources())
        //    {
        //        if (resource.Equals(PermissionRequest.ResourceVideoCapture, StringComparison.OrdinalIgnoreCase))
        //        {
        //            request.Grant(request.GetResources());
        //            return;
        //        }
        //    }

        //    base.OnPermissionRequest(request);
        //}


        public override void OnPermissionRequest(PermissionRequest request)
        {
            foreach (var resource in request.GetResources())
            {
                if (resource.Equals(PermissionRequest.ResourceVideoCapture, StringComparison.OrdinalIgnoreCase))
                {
                    // Get the status of the .NET MAUI app's access to the camera                     
                    PermissionStatus status = Permissions.CheckStatusAsync<Permissions.Camera>().Result;

                    // Deny the web page's request if the app's access to the camera is not "Granted"                     
                    if (status != PermissionStatus.Granted)
                        request.Deny();
                    else
                        request.Grant(request.GetResources());

                    return;
                }
            }

            base.OnPermissionRequest(request);
        }

        //public override bool OnShowFileChooser(WebView webView, IValueCallback filePathCallback, FileChooserParams fileChooserParams)
        //{
        //    MainActivity.mUploadCallbackAboveL = filePathCallback;

        //    //PickPhoto;              
        //    var imageStorageDir = FileSystem.Current.CacheDirectory;

        //    // Create picked image file path and name, add ticks to make it unique               
        //    var file = new Java.IO.File(imageStorageDir + Java.IO.File.Separator + "IMG_" + DateTime.Now.Ticks + ".jpg");

        //    //MainActivity.imageUri = Uri.FromFile(file);             
        //    MainActivity.imageUri = FileProvider.GetUriForFile(activity, activity.PackageName + ".fileprovider", file);

        //    //Create camera capture image intent and add it to the chooser               
        //    var captureIntent = new Intent(MediaStore.ActionImageCapture);
        //    captureIntent.PutExtra(MediaStore.ExtraOutput, MainActivity.imageUri);

        //    var i = new Intent(Intent.ActionGetContent);
        //    i.AddCategory(Intent.CategoryOpenable);
        //    i.SetType("image/*");

        //    var chooserIntent = Intent.CreateChooser(i, "Choose Image");
        //    chooserIntent.PutExtra(Intent.ExtraInitialIntents, new Intent[ ] { captureIntent });

        //    MainActivity.Instance.StartActivityForResult(chooserIntent, MainActivity.PHOTO_REQUEST);

        //    return true;
        //}



    }
}
