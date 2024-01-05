using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Views;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;

 
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;

//using AndroidApp = Android.App.Application;




//[assembly: Xamarin.Forms.Dependency(typeof(S1RoofingMU.Platforms.DependencyService_SoundClick ) )]

namespace S1RoofingMU.Platforms
    {
    public class DependencyService_SoundClick : iSRoofing_DependencyService_SoundClick
    {
        public global::Android.Views.View root;
        public void KeyboardClick ( )
        {
            if ( root == null )
            {
               root = (Platform.CurrentActivity ).FindViewById<global::Android.Views.View> (global::Android.Resource.Id.Content );
            }
            root.PlaySoundEffect ( SoundEffects.Click );
        }
    }
}