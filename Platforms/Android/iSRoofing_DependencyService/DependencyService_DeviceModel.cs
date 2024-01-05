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

 
using Uri = Android.Net.Uri;
using Application = Android.App.Application;
using pvd = Android.Provider;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;



//[assembly: Xamarin.Forms.Dependency(typeof(S1RoofingMU.Platforms.DependencyService_DeviceModel))]

namespace S1RoofingMU.Platforms
    {
    public class DependencyService_DeviceModel : iSRoofing_DependencyService_DeviceModel
        {
     
        public string GetDeviceModel ( )
            {

            try
                {
                return DeviceInfo.Model;// Android.OS.Build.Moedl;
                }
            catch ( Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
                }

            //throw new NotImplementedException();
            }

        public string GetGlobalDeviceID ( )
            {

            try
                {


                return pvd.Settings.Secure.GetString (
                    Application.Context.ContentResolver ,
                    pvd.Settings.Secure.AndroidId );

                }
            catch ( Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
                }


            }
        }
    }