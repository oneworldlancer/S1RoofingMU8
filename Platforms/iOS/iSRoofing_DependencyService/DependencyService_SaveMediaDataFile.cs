using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;


using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

using UIKit;

//[assembly: Xamarin.Forms.Dependency ( typeof ( S1RoofingMU.Platforms.DependencyService_SaveMediaDataFile ) )]
namespace S1RoofingMU.Platforms
    {
    public class DependencyService_SaveMediaDataFile : iSRoofing_DependencyService_SaveMediaDataFile
    {
        public void  SaveFile ( string filePath , byte[] data )
        {
            try
            {
                //     var documents = Environment.GetFolderPath ( Environment.SpecialFolder.MyDocuments );
                //var filename = Path.Combine ( documents , fileName );
                File.WriteAllBytes ( filePath , data );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        
        }

        //public void  SaveFile ( string fileName , byte[] data )
        //{
        //    try
        //    {
        //         var documents = Environment.GetFolderPath ( Environment.SpecialFolder.MyDocuments );
        //    var filename = Path.Combine ( documents , fileName );
        //    File.WriteAllBytes ( filename , data );

        //    }
        //    catch ( Exception ex )
        //    {
        //        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //        return;
        //    }

        //}









        //https://stackoverflow.com/questions/60618209/xamarin-forms-save-image-from-an-url-into-devices-gallery
    
        public void SaveImageFromByte ( byte[] imageByte , string fileName )
        {
            var imageData = new UIImage ( NSData.FromArray ( imageByte ) );
            imageData.SaveToPhotosAlbum ( ( image , error ) =>
            {
                //you can retrieve the saved UI Image as well if needed using  
                //var i = image as UIImage;  
                if ( error != null )
                {
                    SRoofing_DebugManager.Debug_ShowSystemMessage ( error.ToString ( ) );
                }
            } );
        }
  
    
    
    
           public string Get_DownloadPath ( )
        {
             try
            {
                return Environment.GetFolderPath ( Environment.SpecialFolder.MyPictures );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }

          //  throw new NotImplementedException ( );
        }

      
    
    
    
    
    }
}