using Android.App;
using Android.Content;
using Android.Gms.Common.Apis;

using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using S1RoofingMU.iSRoofingApp.Droid.iSafePass_DependencyService;
 
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 


//using LocationRequest = Android.Gms.Location.LocationRequest;
using Uri = Android.Net.Uri;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

[assembly: Dependency(typeof( DependencyService_GMap_IDetectGPS ) )]
namespace S1RoofingMU.iSRoofingApp.Droid.iSafePass_DependencyService
    {
    class DependencyService_GMap_IDetectGPS : iSRoofing_DependencyService_GMap_IDetectGPS
    {
        public bool isGPSEnabled()
            {

            return false ;

            //////////try
            //////////    {

            //////////    LocationManager locationManager = null;
            //////////    bool gps_enabled = false;

            //////////    if (locationManager == null)
            //////////        {

            //////////        locationManager = (LocationManager)Forms.Context.GetSystemService(Context.LocationService);
            //////////        }
            //////////    try
            //////////        {
            //////////        gps_enabled = locationManager.IsProviderEnabled(LocationManager.GpsProvider);
            //////////        }
            //////////    catch (Exception ex)
            //////////        {
            //////////        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            //////////        return false;
            //////////        }


            //////////    return gps_enabled;
            //////////    }
            //////////catch (Exception ex)
            //////////    {
            //////////    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            //////////    return false;
            //////////    }
          
        }

        [Obsolete]
        public async Task OpenGPS()
            {

            //////////try
            //////////    {
                
            //////////    //MainActivity activity = Forms.Context as MainActivity;
            //////////    GoogleApiClient googleApiClient = new GoogleApiClient.Builder(Forms.Context)
            //////////        .AddApi(LocationServices.API).Build();
            //////////    googleApiClient.Connect();
            //////////    LocationRequest locationRequest = LocationRequest.Create();
            //////////    locationRequest.SetPriority(LocationRequest.PriorityHighAccuracy);
            //////////    locationRequest.SetInterval(10000);
            //////////    locationRequest.SetFastestInterval(10000 / 2);
            //////////    LocationSettingsRequest.Builder
            //////////            locationSettingsRequestBuilder = new LocationSettingsRequest.Builder()
            //////////            .AddLocationRequest(locationRequest);
            //////////    locationSettingsRequestBuilder.SetAlwaysShow(false);
            //////////    LocationSettingsResult locationSettingsResult = await LocationServices.SettingsApi.CheckLocationSettingsAsync
            //////////        (googleApiClient, locationSettingsRequestBuilder.Build());
            //////////    if (locationSettingsResult.Status.StatusCode == LocationSettingsStatusCodes.ResolutionRequired)
            //////////        {
            //////////        locationSettingsResult.Status.StartResolutionForResult((Activity)Forms.Context, 0);
            //////////        }

            //////////    }
            //////////catch (Exception ex)
            //////////    {
            //////////    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            //////////    return  ;
            //////////    }

            }
      
    }
    }