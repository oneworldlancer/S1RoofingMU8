using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Microsoft.Maui.Controls;
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_VideoManager
    {

        public static async Task<string> Video_Get_Thumbnail (string FileID, string OriginalFilePath,ImageSource imgStream )
        {
            try
            {         /*,*/

                //ImageSource imageSource=null;

                //var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_VideoModel> ( );

                //if ( objService != null )
                //{
                //    imageSource = objService.GenerateThumbImage ( OriginalFilePath );

                //}


                if ( imgStream != null )
                {
                 await   SRoofing_ImageManager.SaveImageAsync ( imgStream , Path.Combine(FileSystem.Current.CacheDirectory, "img_"+ FileID +".jpg"));
                }

              

                return Path.Combine ( FileSystem.Current.CacheDirectory , "img_" + FileID + ".jpg" );
          
            
            
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return "0";
            }
        }

    }
}
