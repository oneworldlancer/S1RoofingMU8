using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
    {
    public class SRoofing_EncoderManager
        {

        public static string Encoder_To_Base64Encode ( string text )
            {
            var textBytes = System.Text.Encoding.UTF8.GetBytes ( text );
            return System.Convert.ToBase64String ( textBytes );
            }
      
        
        
        public static string Encoder_From_Base64Decode ( string base64 )
            {
            var base64Bytes = System.Convert.FromBase64String ( base64 );
            return System.Text.Encoding.UTF8.GetString ( base64Bytes );
            }
        }
    }
