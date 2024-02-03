using Android.Telephony;

using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1RoofingMU.Platforms.Android
{
    public class PhoneCallListener : PhoneStateListener
    {
        public override void OnCallStateChanged ( CallState state , string incomingNumber )
        {
            base.OnCallStateChanged ( state , incomingNumber );

            try
            {

                if ( state == CallState.Ringing )
                { // Retrieve the caller ID information string callerId = TelephonyManager.FromContext(Application.Context).GetLine1Number(); // Do something with the caller ID information Console.WriteLine($"Incoming call from {callerId}"); } } } 
                }
                else if ( state == CallState.Idle )
                { // Retrieve the caller ID information string callerId = TelephonyManager.FromContext(Application.Context).GetLine1Number(); // Do something with the caller ID information Console.WriteLine($"Incoming call from {callerId}"); } } } 
                }
                else if ( state == CallState.Offhook )
                { // Retrieve the caller ID information string callerId = TelephonyManager.FromContext(Application.Context).GetLine1Number(); // Do something with the caller ID information Console.WriteLine($"Incoming call from {callerId}"); } } } 
                }

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;

            }

        }
    }
}