using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Views;


//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;

 
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;


 
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

//[assembly: Xamarin.Forms.Dependency ( typeof ( S1RoofingMU.Platforms.DependencyService_SaveMediaDataFile ) )]

namespace S1RoofingMU.Platforms
{
    public class DependencyService_SaveMediaDataFile : iSRoofing_DependencyService_SaveMediaDataFile
    {
        public void SaveFile ( string filePath , byte[] data )
        {

            try
            {

                byte[] iNewData_Rotate = RotateImage (data,filePath );
                //string picPath = Path.Combine (global::Android.OS.Environment.ExternalStorageDirectory.AbsolutePath , global::Android.OS.Environment.DirectoryPictures );
                //string filePath = Path.Combine ( picPath , fileName );
                //File.WriteAllBytes ( filePath , data );
                File.WriteAllBytes ( filePath , iNewData_Rotate );


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }


       // public byte[] RotateImage ( System.IO.Stream imageStream , string filePath )
          public byte[] RotateImage ( byte[] byteArray , string filePath )
        {
            //int rotationDegrees = GetImageRotation ( filePath )
            //byte[] byteArray = new byte[ imageStream.Length ];
            try
            {
                //imageStream.Read ( byteArray , 0 , ( int ) imageStream.Length );

                Bitmap originalImage = BitmapFactory.DecodeByteArray ( byteArray , 0 , byteArray.Length );
                Matrix matrix = new Matrix ( );
                matrix.PostRotate ( ( float ) -90 );

                Bitmap rotatedBitmap = Bitmap.CreateBitmap ( originalImage , 0 , 0 , originalImage.Width ,
                    originalImage.Height , matrix , true );

                using ( MemoryStream ms = new MemoryStream ( ) )
                {
                    rotatedBitmap.Compress ( Bitmap.CompressFormat.Jpeg , 100 , ms );
                    return ms.ToArray ( );
                }
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return byteArray;
            }
        }



        //https://stackoverflow.com/questions/60618209/xamarin-forms-save-image-from-an-url-into-devices-gallery
    
        public void SaveImageFromByte ( byte[] imageByte , string filename )
        {
            try
            {
             
            
                Java.IO.File storagePath =global::Android.OS.Environment.GetExternalStoragePublicDirectory (global:: Android.OS.Environment.DirectoryDownloads );
             //   Java.IO.File storagePath =global::Android.OS.Environment.GetExternalStoragePublicDirectory (global:: Android.OS.Environment.DirectoryPictures );
              
                
                string path = System.IO.Path.Combine ( storagePath.ToString ( ) , filename );
                System.IO.File.WriteAllBytes ( path , imageByte );
                var mediaScanIntent = new Intent ( Intent.ActionMediaScannerScanFile );
                mediaScanIntent.SetData (global:: Android.Net.Uri.FromFile ( new Java.IO.File ( path ) ) );
               /////////// ( ( Activity ) Forms.Context ).SendBroadcast ( mediaScanIntent );
         
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }




         
        public string Get_DownloadPath ( )
        {
            try
            {
             
            
                Java.IO.File storagePath =global::Android.OS.Environment.GetExternalStoragePublicDirectory (global:: Android.OS.Environment.DirectoryDownloads );
             //   Java.IO.File storagePath =global::Android.OS.Environment.GetExternalStoragePublicDirectory (global:: Android.OS.Environment.DirectoryPictures );
              
                
                //string path = System.IO.Path.Combine ( storagePath.ToString ( ) , filename );
                //System.IO.File.WriteAllBytes ( path , imageByte );
                //var mediaScanIntent = new Intent ( Intent.ActionMediaScannerScanFile );
                //mediaScanIntent.SetData (global:: Android.Net.Uri.FromFile ( new Java.IO.File ( path ) ) );
                //( ( Activity ) Forms.Context ).SendBroadcast ( mediaScanIntent );
         
                return storagePath.ToString ( ) ;
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }




    }
}