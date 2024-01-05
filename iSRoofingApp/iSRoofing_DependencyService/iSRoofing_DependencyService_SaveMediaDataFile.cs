using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService
{
    public interface iSRoofing_DependencyService_SaveMediaDataFile
    {
        void SaveFile ( string fileName , byte[] data );




        //https://stackoverflow.com/questions/60618209/xamarin-forms-save-image-from-an-url-into-devices-gallery

        void SaveImageFromByte ( byte[] imageByte , string filename );
        string Get_DownloadPath (  );
    }
}
