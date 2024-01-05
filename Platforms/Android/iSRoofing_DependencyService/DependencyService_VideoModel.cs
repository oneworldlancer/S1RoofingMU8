using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

 
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;

 
using Urix = Android.Net.Uri;
using Application = Android.App.Application;
using pvd = Android.Provider;
using Android.Media;
using Android.Graphics;
using System.IO;

using Java.Lang;

using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

//[assembly: Xamarin.Forms.Dependency(typeof(S1RoofingMU.Platforms.DependencyService_VideoModel))]

namespace S1RoofingMU.Platforms
    {
    internal class DependencyService_VideoModel : iSRoofing_DependencyService_VideoModel
    {
        public ImageSource GenerateThumbImage (   string FilePath )
        {
            try
            {
                Java.IO.File file = new Java.IO.File ( FilePath );
                global::Android.Net.Uri uri = global::Android.Net.Uri.FromFile ( file );
             
                MediaMetadataRetriever retriever = new MediaMetadataRetriever ( );
                //   retriever.SetDataSource ( FilePath , new Dictionary<string , string> ( ) );
                retriever.SetDataSource ( Application.Context , uri );
                Bitmap bitmap = retriever.GetFrameAtTime ( 1 );
                if ( bitmap != null )
                {
                    MemoryStream stream = new MemoryStream ( );
                    bitmap.Compress ( Bitmap.CompressFormat.Png , 0 , stream );
                    byte[] bitmapData = stream.ToArray ( );


                    SRoofing_DebugManager.Debug_ShowSystemMessage ( "GenerateThumbImage == DONE" );


                    return ImageSource.FromStream ( ( ) => new MemoryStream ( bitmapData ) );
              
                }
                return null;

            }
            catch (System.Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( "GenerateThumbImage == ERROR" );
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }

        }



        public   string VideoDuration_X1 ( string FilePath )
        {
          try
            {
                Java.IO.File file = new Java.IO.File ( FilePath );
                global::Android.Net.Uri uri = global::Android.Net.Uri.FromFile ( file );
                //return uri;

                MediaMetadataRetriever retriever = new MediaMetadataRetriever ( );
               //   retriever.SetDataSource ( uri , new Dictionary<string , string> ( ) );
                retriever.SetDataSource (Application.Context, uri );
            var length = retriever.ExtractMetadata ( MetadataKey.Duration );
            var lengthseconds = Convert.ToInt32 ( length ) / 1000;
            TimeSpan t = TimeSpan.FromSeconds ( lengthseconds );
            var timeformat = t.ToString ( );
            return timeformat.ToString ( );
            }
            catch ( System.Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            } 
          
        }    




        public   string VideoDuration ( string FilePath )
        {
          try
            {
                Java.IO.File file = new Java.IO.File ( FilePath );
                global::Android.Net.Uri uri = global::Android.Net.Uri.FromFile ( file );
                //return uri;

                MediaMetadataRetriever retriever = new MediaMetadataRetriever ( );
                //use one of overloaded setDataSource() functions to set your data source
                retriever.SetDataSource ( Application.Context ,  ( uri ) );
                string length = retriever.ExtractMetadata ( MetadataKey.Duration );
              
                retriever.Release ( );

                var lengthseconds = Convert.ToInt32 ( length ) / 1000;
                TimeSpan t = TimeSpan.FromSeconds ( lengthseconds );
                var timeformat = t.ToString ( );
                return timeformat.ToString ( );
            }
            catch (System.Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            } 
          
        }
    }
}