using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Azure;
using Azure.AI.TextAnalytics;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumHandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_HandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;


using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_ScreenCallShowMessageManager
    {





        async public static Task<string> ScreenCallShowMessage_Send_OfferMessageWS(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
        string MessageTokenIDWS,
        string CallTokenIDWS,
        string GroupTokenIDWS,
        string PrivateGroupTokenIDWS,
        string RemoteUserIDWS,
        string RemoteMobileNumberIDWS

        //////////string CallCodeWS,
        //////////string CallTypeWS,
        //////////string CallDirectionWS,
        //////////string CallStateWS,
        //////////string CallDurationWS,

        //////////string CallMessageTextWS,
        //////////string CallMessageTextWS,


        //////////string MessageCodeWS,
        //////////string MessageTypeWS,
        //////////string CallMessageTextWS
            )
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                              App.SiteDomainURL + "_iWebHandler"
                              + "/SRoofing_ScreenCallShowMessageHandler.ashx?"

                              + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                              + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                              + "&acctyp=" + App.iAccountType
                              + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                              + "&gcmid=" + Preferences.Get("GCMID", "0")

                              + "&uid=" + iOwnerModel.OwnerUserTokenID
                              + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID


                              + "&fuid=" + iOwnerModel.OwnerUserTokenID
                              + "&fmobid=" + iOwnerModel.OwnerMobileNumberTokenID


                              + "&tuid=" + RemoteUserIDWS
                              + "&tmobid=" + RemoteMobileNumberIDWS

                              + "&invtag=" + MessageTokenIDWS

                              + "&msgtknid=" + MessageTokenIDWS

                              + "&scncaltyp=" + "0"
                              + "&isdating=" + "0"

                              + "&msgtknid=" + MessageTokenIDWS

                              + "&caltknid=" + CallTokenIDWS

                              + "&grpid=" + GroupTokenIDWS
                              + "&pvtgrpid=" + PrivateGroupTokenIDWS
                              + "&grptyp=" + PrivateGroupTokenIDWS

                              + "&rmtid=" + RemoteUserIDWS
                              + "&rmtmobid=" + RemoteMobileNumberIDWS


                              + "&calcod=" + "call"
                              + "&caltyp=" + "voice"
                              + "&caldir=" + "out"
                              + "&calstat=" + "0"
                              + "&caltime=" + "0"

                              + "&invcod=" +  "call"
                              + "&invtyp=" + "voice"

                              + "&msgcod=" + "call"
                              + "&msgtyp=" +    SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_CallNewMessage
                              + "&msgtxt=" + "0"

                              + "&isnew=" + "1"


                              + "&isadmin=" + "0"

                              + "&req=" + SRoofingEnum_ScreenCallShowMessageHandler.ScreeCallShow_Call_Offer_Message_ByScreenCallShowID);


                return strResult;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }












        async public static Task<string> ScreenCallShowMessage_New_Event_Message_ByScreenCallShowID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
    SRoofingUserRemoteModelManager iRemoteModel,
     string MessageTokenID,
     string CallTokenID,
     string GroupID,
     string PrivateGroupID,
     string RemoteUserID,
     string RemoteMobileNumberID,
     string MessageCodeWS,
     string MessageTypeWS,
      string CallCodeWS,
     string CallTypeWS,
     string CallDirectionWS,
     string CallStateWS,
     string CallDurationWS,
     string CallMessageTextWS,
     string IsNewMessageWS)
        {

            try
            {


                var strResult = "0";



                String FromUserTokenIDWS = "0",
                        FromMobileNumberTokenIDWS = "0",
                        ToUserTokenIDWS = "0",
                        ToMobileNumberTokenIDWS = "0";

                if (CallStateWS == (SRoofingEnum_Call_State.CallState_DROP))
                {

                    FromUserTokenIDWS = iOwnerModel.OwnerUserTokenID;
                    FromMobileNumberTokenIDWS = iOwnerModel.OwnerMobileNumberTokenID;
                    ToUserTokenIDWS = iRemoteModel.OwnerUserTokenID;
                    ToMobileNumberTokenIDWS = iRemoteModel.OwnerMobileNumberTokenID;
                }

                else if (CallStateWS == (SRoofingEnum_Call_State.CallState_OFFLINE))
                {


                    FromUserTokenIDWS = iOwnerModel.OwnerUserTokenID;
                    FromMobileNumberTokenIDWS = iOwnerModel.OwnerMobileNumberTokenID;
                    ToUserTokenIDWS = iRemoteModel.OwnerUserTokenID;
                    ToMobileNumberTokenIDWS = iRemoteModel.OwnerMobileNumberTokenID;

                }


                else if (CallStateWS == (SRoofingEnum_Call_State.CallState_DECLINE))
                {


                    FromUserTokenIDWS = iRemoteModel.OwnerUserTokenID;
                    FromMobileNumberTokenIDWS = iRemoteModel.OwnerMobileNumberTokenID;
                    ToUserTokenIDWS = iOwnerModel.OwnerUserTokenID;
                    ToMobileNumberTokenIDWS = iOwnerModel.OwnerMobileNumberTokenID;

                }


                else if (CallStateWS == (SRoofingEnum_Call_State.CallState_ENDTIME))
                {

                    if (CallDirectionWS == (SRoofingEnum_Call_Direction.CallDirection_In))
                    {

                        FromUserTokenIDWS = iRemoteModel.OwnerUserTokenID;
                        FromMobileNumberTokenIDWS = iRemoteModel.OwnerMobileNumberTokenID;
                        ToUserTokenIDWS = iOwnerModel.OwnerUserTokenID;
                        ToMobileNumberTokenIDWS = iOwnerModel.OwnerMobileNumberTokenID;

                    }

                    else if (CallDirectionWS == (SRoofingEnum_Call_Direction.CallDirection_Out))
                    {

                        FromUserTokenIDWS = iOwnerModel.OwnerUserTokenID;
                        FromMobileNumberTokenIDWS = iOwnerModel.OwnerMobileNumberTokenID;
                        ToUserTokenIDWS = iRemoteModel.OwnerUserTokenID;
                        ToMobileNumberTokenIDWS = iRemoteModel.OwnerMobileNumberTokenID;

                    }
                }


                else if (CallStateWS == (SRoofingEnum_Call_State.CallState_TIMEOUT))
                {

                    FromUserTokenIDWS = iOwnerModel.OwnerUserTokenID;
                    FromMobileNumberTokenIDWS = iOwnerModel.OwnerMobileNumberTokenID;
                    ToUserTokenIDWS = iRemoteModel.OwnerUserTokenID;
                    ToMobileNumberTokenIDWS = iRemoteModel.OwnerMobileNumberTokenID;

                }


                else if (CallStateWS == (SRoofingEnum_Call_State.CallState_BUSY))
                {

                    FromUserTokenIDWS = iRemoteModel.OwnerUserTokenID;
                    FromMobileNumberTokenIDWS = iRemoteModel.OwnerMobileNumberTokenID;
                    ToUserTokenIDWS = iOwnerModel.OwnerUserTokenID;
                    ToMobileNumberTokenIDWS = iOwnerModel.OwnerMobileNumberTokenID;

                }



                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_ScreenCallShowMessageHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID


                        + "&fuid=" + FromUserTokenIDWS
                        + "&fmobid=" + FromMobileNumberTokenIDWS


                        + "&tuid=" + ToUserTokenIDWS
                        + "&tmobid=" + ToMobileNumberTokenIDWS

                        + "&msgtknid=" + MessageTokenID

                        + "&caltknid=" + CallTokenID

                        + "&grpid=" + GroupID
                        + "&pvtgrpid=" + PrivateGroupID
                        + "&grptyp=" + SRoofingEnum_GroupType.GroupType_PRIVATE 
                        
                        + "&rmtid=" + RemoteUserID
                        + "&rmtmobid=" + RemoteMobileNumberID

                        + "&msgcod=" + MessageCodeWS
                        + "&msgtyp=" + MessageTypeWS

                        + "&calcod=" + CallCodeWS
                        + "&caltyp=" + CallTypeWS
                        + "&caldir=" + CallDirectionWS
                        + "&calstat=" + CallStateWS
                        + "&caltime=" + CallDurationWS

                        + "&msgtxt=" + CallMessageTextWS
                        + "&isnew=" + IsNewMessageWS


                        + "&isadmin=" + "0"

                        + "&req=" + SRoofingEnum_ScreenCallShowMessageHandler.ScreeCallShow_New_Event_Message_ByScreenCallShowID);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }








    }
}
