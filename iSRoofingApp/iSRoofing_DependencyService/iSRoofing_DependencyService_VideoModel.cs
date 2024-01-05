using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService
	{
  public  interface iSRoofing_DependencyService_VideoModel
    {

        ImageSource GenerateThumbImage (  string FilePath);

        string VideoDuration ( string FilePath );

        //void StartGMap_Track();
    }
}
