using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Translation;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Web;

 
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Emotion
{
    public class Broadcast_ScreenChatShow_Emotion_Message
    {

        public static async
Task<string> Broadcast_ScreenChatShow_Emotion_MessageWS(

        Application _context,

        string iAccountType,
        SRoofingUserOwnerModelManager iOwnerModel,
        string MessageTokenID,

        string UploadDateTimeMilliSec,

        string InviteTag,
        string GroupID,
        string ScreenChatShowID,
        string ScreenChatShowTicketID,
        string InviteOwnerUserID,
        string InviteOwnerMobileNumberID,
        string MessageType,
        string MessageText,


                         SRoofingTranslationModel iTranslationModel ,


        string iOwner_LanguageCode_IN ,
         string iOwner_LanguageCode_OUT ,


                                 string DateTimeTextWS ,
                  string DateTimeWS,
                  string DateTextWS,
                   string UserDateDayWS,
                    string UserDateMonthWS,
                    string UserDateYearWS)
        {

            try
            {

                  Task.Run ( async ( ) =>
                {

                await App.svcSRoofing_ScreenChatShowTextMessageWS
           .SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareEmotionMessageWSAsync(


                                                                    App.iPlatformOS,
                          App.iDatabaseServerTokenID,
                                       Preferences.Get("DeviceGlobalID", "0"),//DeviceGlobalIDWS
                        App.iAccountType,
                              MessageTokenID,
                              MessageTokenID,
                             GroupID, ScreenChatShowID,
                      ScreenChatShowTicketID,
                      

                              iOwnerModel.OwnerUserTokenID,
                                   iOwnerModel.OwnerMobileNumberTokenID,


                                 iOwnerModel.OwnerUserTokenID,
                                 iOwnerModel.OwnerMobileNumberTokenID,

                              InviteTag,
                                  SRoofingEnum_ScreenChatShowInviteCode.ScreenChatShowInviteCode_InviteText,
                           "emotion",
                             MessageType,

                         HttpUtility.UrlEncode(MessageText)    ,
                                                                                            
                     HttpUtility.UrlEncode ( iTranslationModel.MessageCode_Original ) ,
                  HttpUtility.UrlEncode ( iTranslationModel.MessageText_Original ) ,
                   HttpUtility.UrlEncode ( iTranslationModel.MessageCode_Translated ) ,
                  HttpUtility.UrlEncode ( iTranslationModel.MessageText_Translated ) ,



                                                      DateTimeTextWS ,
                         DateTimeWS,
                         DateTextWS,
                          UserDateDayWS,
                           UserDateMonthWS,
                           UserDateYearWS,
                           MessageTokenID).ConfigureAwait ( false );



                } );
                //////////////////////////
                return "true";

 

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "false";
            }
        }
    }
}
