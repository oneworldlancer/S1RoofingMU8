using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;


using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

using UIKit;


//[assembly: Xamarin.Forms.Dependency ( typeof ( S1RoofingMU.Platforms.DependencyService_DeviceModel ) )]
namespace S1RoofingMU.Platforms
    {
    public class DependencyService_DeviceModel : iSRoofing_DependencyService_DeviceModel
        {
        public string GetDeviceModel ( )
            {

            try
                {
                return UIKit.UIDevice.CurrentDevice.Model;

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

                return UIDevice.CurrentDevice.IdentifierForVendor.ToString ( );

                }
            catch ( Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
                }


            }
        }
    }