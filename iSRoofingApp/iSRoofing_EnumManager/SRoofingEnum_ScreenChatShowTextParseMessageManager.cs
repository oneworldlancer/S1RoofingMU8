using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager
{
    class SRoofingEnum_ScreenChatShowTextParseMessageManager
    {

        public static
           string ScreenCallShowTextParseMessage_CallEndDurationMessage(
                   string CallDirection,
                   string CallDuration)
        {

            string str = "";

            if (CallDirection == ("in"))
            {
                if (CallDuration!= "0")
                {
  str = "Incoming call ended (" + CallDuration + ")";
                }
                else
                {
                    str = "Incoming call ended";
                }
                
              
            }

            else if (CallDirection == ("out"))
            {
                if (CallDuration!= "0")
                {
    str = "Outgoing call ended  (" + CallDuration + ")";
                }
                else
                {
                    str = "Outgoing call ended";
                }
            
            }

            return str;

        }

        public static
        string ScreenCallShowTextParseMessage_CallEndInRingMessage(string paramstring)
        {

            try
            {

                string str = "";

                if (paramstring == ("in"))
                {
                    str = "Incoming missed call";
                }
                else if (paramstring == ("out"))
                {
                    str = "Outgoing call dropped";
                }
                return str;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }


        }

        public static
        string ScreenCallShowTextParseMessage_CallEndMessage(string paramstring)
        {

            try
            {

                string str = "";
                if (paramstring == ("in"))
                {
                    str = "Call ended";
                }
                else if (paramstring == ("out"))
                {
                    str = "Call ended";
                }

                return str;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }

        public static
        string ScreenCallShowTextParseMessage_CallNewMessage(string paramstring)
        {

            try
            {

                string str = "";
                if (paramstring == ("in"))
                {
                    str = "Incoming call";
                }
                else if (paramstring == ("out"))
                {
                    str = "Outgoing call";
                }
                return str;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }


        }

        public static
        string ScreenCallShowTextParseMessage_CallOfflineMessage(string paramstring)
        {
            try
            {

                string str = "";
                if (paramstring == ("in"))
                {
                    str = "Incoming missed call";
                }
                else if (paramstring == ("out"))
                {
                    str = "Outgoing call offline";
                }

                return str;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }

        public static
        string ScreenCallShowTextParseMessage_CallReplyByBusyMessage(string paramstring)
        {

            try
            {

                string str = "";

                if (paramstring == ("in"))
                {
                    str = "Incoming missed call";
                }
                else
                {
                    str = "Busy on a call";
                }

                return str;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }

        public static
        string ScreenCallShowTextParseMessage_CallReplyByDeclineMessage(string paramstring)
        {

            try
            {

                string str = "";
                if (paramstring == ("in"))
                {
                    str = "Incoming call declined";
                }
                else if (paramstring == ("out"))
                {
                    str = "Outgoing call declined";
                }

                return str;


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }

        public static
        string ScreenCallShowTextParseMessage_CallReplyBySwipeMessage(string paramstring)
        {
            //string str = "";
            //if ( paramstring == ( "in" ) )
            //    {
            //    str = "Incoming call unavailable";
            //    }
            //while ( !paramstring == ( "out" ) )
            //    {
            //    return str;
            //    }
            return "Outgoing call unavailable";
        }

        public static
        string ScreenCallShowTextParseMessage_CallReplyByTextMessage(string paramstring)
        {
            //string str = "";
            //if ( paramstring == ( "in" ) )
            //    {
            //    str = "Incoming call answered with text";
            //    }
            //while ( !paramstring == ( "out" ) )
            //    {
            //    return str;
            //    }
            return "Outgoing call replied by text";
        }

        public static
        string ScreenCallShowTextParseMessage_CallReplyByVoiceCallMessage(string paramstring)
        {
            //string str = "";
            //if ( paramstring == ( "in" ) )
            //    {
            //    str = "Incoming call answered";
            //    }
            //while ( !paramstring == ( "out" ) )
            //    {
            //    return str;
            //    }
            return "Outgoing call replied";
        }

        public static
        string ScreenCallShowTextParseMessage_CallTimeOutMessage(string paramstring)
        {

            try
            {
                string str = "";
                if (paramstring == ("in"))
                {
                    str = "Incoming missed call";
                }
                else if (paramstring == ("out"))
                {
                    str = "Outgoing call unanswered";
                }

                return str;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }


        }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerAcceptUserInviteTextReplyByTextMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( Globals.SiteDomainURL
        //                                              + "_iWebHandler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Joined text chat with " + str + "";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerAcceptUserInviteTextReplyByVoiceMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( Globals.SiteDomainURL
        //                                              + "_iWebHandler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Joined text chat with " + str + "";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerAcceptUserInviteVideoReplyByVideoMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Joined video call with " + str + "";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerAcceptUserInviteVideoReplyByVoiceMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Joined video call with " + str + "";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerAcceptUserInviteVoiceReplyByVideoMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Joined voice call with " + str + "";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerAcceptUserInviteVoiceReplyByVoiceMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Joined voice call with " + str + "";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerDeclineUserInviteTextMessage ( string paramstring )
        //    {
        //    return "Sorry, am busy";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerDeclineUserInviteVideoMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Declined video call from " + str + "";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerDeclineUserInviteVoiceMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Declined voice call from " + str + "";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerGroupInviteAcceptMessage ( )
        //    {
        //    return "Unable to get location at this time , try later";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerGroupInviteDeclineMessage ( )
        //    {
        //    return "Unable to get location at this time , try later";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerGroupInviteRequestReceivedMessage ( )
        //    {
        //    return "Unable to get location at this time , try later";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerGroupInviteRequestSendMessage ( )
        //    {
        //    return "You invited friends to join the group";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerLeaveUserInviteLeaveTextMessage ( )
        //    {
        //    return "Left the chat";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerLeaveUserInviteLeaveVideoMessage ( )
        //    {
        //    return "Left the call";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerLeaveUserInviteLeaveVoiceMessage ( )
        //    {
        //    return "Left the call";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerMissedUserInviteTextMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Missed text chat call from " + str + "";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerMissedUserInviteVideoMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Missed video call from " + str + "";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerMissedUserInviteVoiceMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Missed voice call from " + str + "";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerShareLocationAskRemoteDeclineMessage ( )
        //    {
        //    return "You declined to share your location";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerShareLocationAskRemoteMessage ( )
        //    {
        //    return "Request location";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerShareLocationCityMessage ( )
        //    {
        //    return "Shared your city location";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerShareLocationMessage ( )
        //    {
        //    return "Shared location";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerShareLocationPinPointMessage ( )
        //    {
        //    return "Shared pinpoint";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerShareLocationUnableMessage ( )
        //    {
        //    return "Unable to get location at this time , try later";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerSharePhotoCancelMessage ( )
        //    {
        //    return "Transfer cancelled";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerSharePhotoDeclineMessage ( )
        //    {
        //    return "Transfer declined";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerSharePhotoMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Shared photo with " + str + "";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerShareVideoCancelMessage ( )
        //    {
        //    return "Transfer cancelled";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerShareVideoDeclineMessage ( )
        //    {
        //    return "Transfer declined";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerShareVideoMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Shared video with " + str + "";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerStartNewUserInviteToGroupMessage ( )
        //    {
        //    return "Invited you to join their chat";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerStartUserInviteTextMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Invited " + str + " to text chat";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerStartUserInviteVideoMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Invited " + str + " to video call";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerStartUserInviteVoiceMessage ( string paramstring )
        //    {
        //    string str =
        //            TlknHandler.Handler_GetResponse ( "http://tlknmobile.tlkn2"
        //                                              + ".com/Handler/SRoofing_UserHandler.ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Invited " + str + " to voice call";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerSuggestUserMessage ( )
        //    {
        //    return "Suggested friends";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_OwnerToRemoteLeaveUserInviteTextMessage ( )
        //    {
        //    return "Removed from chat";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteAcceptUserInviteTextReplyByTextMessage ( )
        //    {
        //    return "Joined the chat";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteAcceptUserInviteTextReplyByVoiceMessage ( )
        //    {
        //    return "Started voice call";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteAcceptUserInviteVideoReplyByVideoMessage ( string paramstring )
        //    {
        //    TlknHandler.Handler_GetResponse ( Globals.SiteDomainURL + "_iWebHandler/SRoofing_UserHandler"
        //                                      + ".ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Joined you in video call";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteAcceptUserInviteVideoReplyByVoiceMessage ( string paramstring )
        //    {
        //    TlknHandler.Handler_GetResponse ( Globals.SiteDomainURL + "_iWebHandler/SRoofing_UserHandler"
        //                                      + ".ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Joined you in video call";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteAcceptUserInviteVoiceReplyByVideoMessage ( )
        //    {
        //    return "Started video call";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteAcceptUserInviteVoiceReplyByVoiceMessage ( )
        //    {
        //    return "Started voice call";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteDeclineUserInviteTextMessage ( )
        //    {
        //    return "Sorry, am busy";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteDeclineUserInviteVideoMessage ( string paramstring )
        //    {
        //    TlknHandler.Handler_GetResponse ( Globals.SiteDomainURL + "_iWebHandler/SRoofing_UserHandler"
        //                                      + ".ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Sorry, am busy";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteDeclineUserInviteVoiceMessage ( string paramstring )
        //    {
        //    TlknHandler.Handler_GetResponse ( Globals.SiteDomainURL + "_iWebHandler/SRoofing_UserHandler"
        //                                      + ".ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Sorry, am busy";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteGroupInviteAcceptAllMessage ( )
        //    {
        //    return "Unable to get location at this time , try later";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteGroupInviteAcceptMessage ( )
        //    {
        //    return "Unable to get location at this time , try later";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteGroupInviteDeclineMessage ( )
        //    {
        //    return "Unable to get location at this time , try later";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteLeaveUserInviteOwnerTextMessage ( )
        //    {
        //    return "Closed the chat";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteLeaveUserInviteTextMessage ( )
        //    {
        //    return "Left the chat";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteLeaveUserInviteVideoMessage ( )
        //    {
        //    return "Left the call";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteLeaveUserInviteVoiceMessage ( )
        //    {
        //    return "Left call";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteMissedUserInviteTextMessage ( )
        //    {
        //    return "No reply";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteMissedUserInviteVideoMessage ( string paramstring )
        //    {
        //    return "No answer";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteMissedUserInviteVoiceMessage ( string paramstring )
        //    {
        //    TlknHandler.Handler_GetResponse ( Globals.SiteDomainURL + "_iWebHandler/SRoofing_UserHandler"
        //                                      + ".ashx?uid=" + paramstring + "&req=firstname" );
        //    return "No answer";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteShareLocationAskRemoteDeclineMessage ( string paramstring )
        //    {
        //    TlknHandler.Handler_GetResponse ( Globals.SiteDomainURL + "_iWebHandler/SRoofing_UserHandler"
        //                                      + ".ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Sorry I don't want to share my location";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteShareLocationAskRemoteMessage ( string paramstring )
        //    {

        //    /*
        //            TlknHandler.Handler_GetResponse (   Globals.SiteDomainURL + "_iWebHandler/SRoofing_UserHandler"
        //                                              + ".ashx?uid=" + paramstring + "&req=firstname" );


        //            return "Asked to share your location?";*/

        //    return "Request location?";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteShareLocationCityMessage (
        //        Context paramContext ,
        //        string paramstring1 ,
        //        string paramstring2 ,
        //        string paramstring3 )
        //    {
        //    string str1 = "";
        //    string str2 = TlknGPSLocationManager.GPSLocation_GetAddressLineByCoordinates (
        //            paramContext ,
        //            paramstring1 ,
        //            paramstring2 ,
        //            "countryname" );
        //    string str3 = TlknGPSLocationManager.GPSLocation_GetAddressLineByCoordinates (
        //            paramContext ,
        //            paramstring1 ,
        //            paramstring2 ,
        //            "statename" );
        //    string str4 = TlknGPSLocationManager.GPSLocation_GetAddressLineByCoordinates (
        //            paramContext ,
        //            paramstring1 ,
        //            paramstring2 ,
        //            "cityname" );
        //    if ( ( !str3.equals ( "" ) ) && ( !str2.equals ( "" ) ) && ( !str4.equals ( "" ) ) )
        //        {
        //        if ( paramstring3 == ( "text" ) )
        //            {
        //            str1 = "Shared location:\n" + str4 + " - " + str3 + " ,\n" + str2;
        //            }
        //        while ( !paramstring3 == ( "keyword" ) )
        //            {
        //            return str1;
        //            }
        //        string str5 = str4 + " - " + str2;
        //        return Uri.encode ( str4 + "+" + str2 + "(" + str5 + ")" );
        //        }
        //    return "Can't recognize location!";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteShareLocationCityMessage ( string paramstring )
        //    {
        //    if ( ( !paramstring.toLowerCase ( ) == ( "null" ) ) && ( !paramstring == ( "" ) ) )
        //        {
        //        string str = paramstring.substring (
        //                0 ,
        //                1 ).toUpperCase ( ) + paramstring.substring ( 1 );
        //        return "Shared location:\n" + str + "";
        //        }
        //    return "Shared location";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteShareLocationMessage ( )
        //    {
        //    return "Shared location";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteShareLocationPinPointMessage ( )
        //    {
        //    return "Shared pinpoint";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteShareLocationPinPointMessage (
        //        Context paramContext ,
        //        string paramstring1 ,
        //        string paramstring2 ,
        //        string paramstring3 )
        //    {
        //    string str1 = "";
        //    string str2 = TlknGPSLocationManager.GPSLocation_GetAddressLineByCoordinates (
        //            paramContext ,
        //            paramstring1 ,
        //            paramstring2 ,
        //            "countryname" );
        //    string str3 = TlknGPSLocationManager.GPSLocation_GetAddressLineByCoordinates (
        //            paramContext ,
        //            paramstring1 ,
        //            paramstring2 ,
        //            "statename" );
        //    string str4 = TlknGPSLocationManager.GPSLocation_GetAddressLineByCoordinates (
        //            paramContext ,
        //            paramstring1 ,
        //            paramstring2 ,
        //            "cityname" );
        //    string str5 = TlknGPSLocationManager.GPSLocation_GetAddressLineByCoordinates (
        //            paramContext ,
        //            paramstring1 ,
        //            paramstring2 ,
        //            "addressline" );
        //    if ( ( !str5.equals ( "" ) ) && ( !str2.equals ( "" ) ) && ( !str4.equals ( "" ) ) )
        //        {
        //        if ( paramstring3 == ( "text" ) )
        //            {
        //            str1 = "Shared location:\n" + str5 + " - " + str4 + " ,\n" + str3 + " ,\n" + str2;
        //            }
        //        while ( !paramstring3 == ( "keyword" ) )
        //            {
        //            return str1;
        //            }
        //        return str5 + "\n" + str4 + " - " + str2;
        //        }
        //    return "Can't recognize location!";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteSharePhotoCancelMessage ( )
        //    {
        //    return "Transfer cancelled";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteSharePhotoDeclineMessage ( )
        //    {
        //    return "Transfer declined";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteSharePhotoMessage ( string paramstring )
        //    {
        //    TlknHandler.Handler_GetResponse ( Globals.SiteDomainURL + "_iWebHandler/SRoofing_UserHandler"
        //                                      + ".ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Shared photo with you";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteShareVideoMessage ( string paramstring )
        //    {
        //    TlknHandler.Handler_GetResponse ( Globals.SiteDomainURL + "_iWebHandler/SRoofing_UserHandler"
        //                                      + ".ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Shared video with you";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteStartNewUserInviteToGroupMessage ( )
        //    {
        //    return "Invited you to join their chat";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteStartUserInviteTextMessage ( string paramstring )
        //    {
        //    TlknHandler.Handler_GetResponse ( Globals.SiteDomainURL + "_iWebHandler/SRoofing_UserHandler"
        //                                      + ".ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Invited you to text chat";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteStartUserInviteVideoMessage ( string paramstring )
        //    {
        //    TlknHandler.Handler_GetResponse ( Globals.SiteDomainURL + "_iWebHandler/SRoofing_UserHandler"
        //                                      + ".ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Invited you to video call";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteStartUserInviteVoiceMessage ( string paramstring )
        //    {
        //    TlknHandler.Handler_GetResponse ( Globals.SiteDomainURL + "_iWebHandler/SRoofing_UserHandler"
        //                                      + ".ashx?uid=" + paramstring + "&req=firstname" );
        //    return "Invited you to voice call";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_RemoteSuggestUserMessage ( )
        //    {
        //    return "Suggested friends";
        //    }

        //public static
        //string ScreenChatShowTextParseMessage_StartNewUserInviteToGroupMessage ( )
        //    {
        //    return "Invited to join the chat";
        //    }

        //public static string WidgetByCode_EmotionList = "WidgetByCode_EmotionList";
        //public static string WidgetByCode_ImageList = "WidgetByCode_ImageList";

        //public static string WidgetByCode_VideoList = "WidgetByCode_VideoList";

        //public static string WidgetByCode_LocationList = "WidgetByCode_LocationList";
        //public static string WidgetByCode_ThumList = "WidgetByCode_ThumList";



    }
}
