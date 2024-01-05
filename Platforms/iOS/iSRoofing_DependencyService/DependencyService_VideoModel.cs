using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using AVFoundation;

using CoreGraphics;

using CoreMedia;

using Foundation;


using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

using UIKit;



//[assembly: Xamarin.Forms.Dependency ( typeof ( S1RoofingMU.Platforms.DependencyServiceVideoModel ) )]
namespace S1RoofingMU.Platforms
{
    internal class DependencyService_VideoModel : iSRoofing_DependencyService_VideoModel
    {
        public ImageSource GenerateThumbImage (  string FilePath )
        {
            try
            {

                AVAssetImageGenerator imageGenerator = new AVAssetImageGenerator ( AVAsset.FromUrl ( ( NSUrl.FromFilename ( FilePath ) ) ) );
                imageGenerator.AppliesPreferredTrackTransform = true;
                CMTime actualTime;
                NSError error;
                CGImage cgImage = imageGenerator.CopyCGImageAtTime ( new CMTime ( 1 , 1000000 ) , out actualTime , out error );
                return ImageSource.FromStream ( ( ) => new UIImage ( cgImage ).AsPNG ( ).AsStream ( ) ); 

                
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }

        }



        public   string VideoDuration ( string FilePath )
        {
          
           try
            {

             //  AVAsset avasset = AVAsset.FromUrl ( ( new Foundation.NSUrl ( url ) ) );
               AVAsset avasset = AVAsset.FromUrl ( ( NSUrl.FromFilename ( FilePath ) ) );
            var length = avasset.Duration.Seconds.ToString ( );
            var lengthseconds = Convert.ToInt32 ( length ) / 1000;
            TimeSpan t = TimeSpan.FromSeconds ( lengthseconds );
            var timeformat = t.ToString ( );
            return timeformat.ToString ( );
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            } 
         

        }
    }
}