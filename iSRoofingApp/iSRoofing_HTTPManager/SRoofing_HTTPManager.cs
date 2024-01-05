using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_HTTPManager
{
    public static class SRoofing_HTTPManager
    {





        // This method must be in a class in a platform project, even if
        // the HttpClient object is constructed in a shared project.
        public static HttpClient HTTP_Get_HttpClientInstance ( )
        {
            try
            {


                HttpClientHandler insecureHandler = GetInsecureHandler();
                HttpClient httpClient = new HttpClient(insecureHandler);

                //#if DEBUG
                //                HttpClientHandler insecureHandler = GetInsecureHandler ( );
                //                HttpClient httpClient = new HttpClient ( insecureHandler );
                //#else
                //    HttpClient httpClient = new HttpClient();
                //#endif

                //////            ServicePointManager.ServerCertificateValidationCallback = new

                return httpClient;
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return new HttpClient ( );
            }

        }








        // This method must be in a class in a platform project, even if
        // the HttpClient object is constructed in a shared project.
        public static HttpClientHandler GetInsecureHandler ( )
        {
            HttpClientHandler handler = new HttpClientHandler ( );
            handler.ServerCertificateCustomValidationCallback = ( message , cert , chain , errors ) =>
            {
                //if ( cert.Issuer.Equals ( "CN=localhost" ) )
                return true;
                //return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
        }




    }
}
