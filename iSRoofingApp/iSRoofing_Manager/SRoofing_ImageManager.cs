using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_ImageManager
    {

        public static async Task<string> SaveImageAsync ( ImageSource imageSource , string filePath )
        {
            try
            {

                if ( imageSource is StreamImageSource streamImageSource )
                {
                    var stream = await streamImageSource.Stream ( CancellationToken.None );
                    using ( var fileStream = new FileStream ( filePath , FileMode.Create ) )
                    {
                        await stream.CopyToAsync ( fileStream );
                    }

                    return filePath;
                }
                return "0";
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return "0";
            }
        }
    }
}
