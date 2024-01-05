using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Maui.Controls;
namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_FileSystemManager
    {

        // Load all suffixes in an array
        static readonly string[] suffixes =
        { "Bytes", "KB", "MB", "GB", "TB", "PB" };
        public static string FormatSize ( Int64 bytes )
        {
            int counter = 0;
            decimal number = ( decimal ) bytes;
            while ( Math.Round ( number / 1024 ) >= 1 )
            {
                number = number / 1024;
                counter++;
            }
            return string.Format ( "{0:n1}{1}" , number , suffixes[ counter ] );
        }
  


    public static string GetSaveDirectory ( )
        {
            string saveDirectory = "";
            switch ( DeviceInfo.Current.Platform.ToString() )
            {
                //case Device.Android:
                //    saveDirectory = Path.Combine ( Android.OS.Environment.ExternalStorageDirectory.AbsolutePath , ".iSRoofing" );
                //    break;
                //case Device.iOS:
                //    saveDirectory = Path.Combine ( Environment.GetFolderPath ( Environment.SpecialFolder.MyDocuments ) , ".iSRoofing" );
                //    break;
            }
            return saveDirectory;
        }

    }
}
