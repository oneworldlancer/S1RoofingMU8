using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Translation;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Text;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Media
{
    public class ScreenChatShow_Media_Broadcast_Text_Message
    {


        public static async Task Broadcast_ScreenChatShowMessageShareTextTranslateWS(

            Application _context,

            string iAccountType,

            SRoofingUserSettingModelManager iSettingModel,
            SRoofingUserOwnerModelManager iOwnerModel,

            string MessageTokenID,

            string InviteTag,

            string ScreenChatShowID,
            string ScreenChatShowTicketID,

            string GroupID,

            string InviteOwnerUserID,
            string InviteOwnerMobileNumberID,

            string MessageCode,
             string MessageType,
            string MessageText,

                         SRoofingTranslationModel iTranslationModel,


        string iOwner_LanguageCode_IN,
         string iOwner_LanguageCode_OUT,

       SRoofingUserMediaModel iUserMediaModel,
            string IsAllowToSave,

            string ToContactListUserID,
            string ToContactListMobileNumberID,


                            string DateTimeTextWS,
                  string DateTimeWS,
                  string DateTextWS,
                   string UserDateDayWS,
                    string UserDateMonthWS,
                    string UserDateYearWS,

                    bool IsUploadNew
)
        {


            try
            {


                await Broadcast_ScreenChatShow_Text_Translate_Message
                           .Broadcast_ScreenChatShow_Text_Translate_MessageWS(
                       App.Current,
            iAccountType,
             iOwnerModel,
             MessageTokenID,

                          MessageTokenID,


             InviteTag,
             GroupID,
             ScreenChatShowID,
             ScreenChatShowTicketID,
            InviteOwnerUserID,
            InviteOwnerMobileNumberID,
            MessageType,
            MessageText,

            iTranslationModel,

             iOwner_LanguageCode_IN,
             iOwner_LanguageCode_OUT,


                                      DateTimeTextWS,
                       DateTimeWS,
                       DateTextWS,
                        UserDateDayWS,
                         UserDateMonthWS,
                        UserDateYearWS);








                ///////////////////////





                //_context,

                //            _iAccountType,
                //            _iOwnerModel,
                //            _MessageTokenID,

                //            _MessageTokenID,

                //            _InviteTag,
                //            _GroupID,
                //            "0",
                //            "0",
                //            _InviteOwnerUserID,
                //            _InviteOwnerMobileNumberID,
                //            TlknEnumScreenChatShowMessageTypeManager.
                //                    ScreenChatShowTextTypeMessage_TextMessage_ParsePendingMessage,
                //            _MessageText);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }



    }
}
