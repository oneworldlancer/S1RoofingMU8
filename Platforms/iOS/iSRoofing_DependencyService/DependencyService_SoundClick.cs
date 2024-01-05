using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;


using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;

using UIKit;

//[assembly: Xamarin.Forms.Dependency ( typeof ( S1RoofingMU.Platforms.DependencyService_SoundClick ) )]
namespace S1RoofingMU.Platforms
    {
    public class DependencyService_SoundClick : iSRoofing_DependencyService_SoundClick
    {
        public void KeyboardClick ( )
        {
            UIDevice.CurrentDevice.PlayInputClick ( );
        }
    }
}