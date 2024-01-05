﻿using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;
using S1RoofingMU.iSRoofingApp.iSRoofing_UploaderManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Translation;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Video;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Audio;

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Media
{
    public class ScreenChatShow_Media_Broadcast_Audio_Message
    {

        public static async Task Broadcast_ScreenChatShowMessageShareAudioWS (

            Application _context ,

            string iAccountType ,

            SRoofingUserSettingModelManager iSettingModel ,
            SRoofingUserOwnerModelManager iOwnerModel ,

            string MessageTokenID ,

            string InviteTag ,

            string ScreenChatShowID ,
            string ScreenChatShowTicketID ,

            string GroupID ,

            string InviteOwnerUserID ,
            string InviteOwnerMobileNumberID ,

            string MessageType ,
            string MessageText ,


                         SRoofingTranslationModel iTranslationModel ,


        string iOwner_LanguageCode_IN ,
         string iOwner_LanguageCode_OUT ,


     SRoofingUserMediaModel iUserMediaModel ,
            string IsAllowToSave ,

            string ToContactListUserID ,
            string ToContactListMobileNumberID ,


                            string DateTimeTextWS ,
                  string DateTimeWS ,
                  string DateTextWS ,
                   string UserDateDayWS ,
                    string UserDateMonthWS ,
                    string UserDateYearWS ,

                    bool IsUploadNew
)
        {


            try
            {

                if ( IsUploadNew )
                {

                    if ( iUserMediaModel.MediaFile_Code == ( SRoofingEnum_File_Code.FileCode_Audio ) )
                    {

                        await SRoofing_UploadMediaManager.Uploader_MediaFile_AudioWS (

                                _context ,

        iAccountType ,

        iSettingModel ,
        iOwnerModel ,

      App.URL_TlknUploader_AudioDataURL ,
      iUserMediaModel );
                    }
                }




                await Broadcast_ScreenChatShow_Audio_Message
                           .Broadcast_ScreenChatShow_Audio_MessageWS (

                               App.Current ,

         iAccountType ,
          iOwnerModel ,
          MessageTokenID ,

          MessageTokenID ,

          InviteTag ,
          GroupID ,
          ScreenChatShowID ,
          ScreenChatShowTicketID ,
          InviteOwnerUserID ,
          InviteOwnerMobileNumberID ,
          MessageType ,
          MessageText ,



                         iTranslationModel ,


          iOwner_LanguageCode_IN ,
           iOwner_LanguageCode_OUT ,


         iUserMediaModel ,

        iUserMediaModel.MediaFile_ServerID ,
        iUserMediaModel.MediaFile_URI ,
          iUserMediaModel.MediaFile_LocalPathURL ,
           iUserMediaModel.MediaFile_ServerURL ,
              "0" ,

                                   DateTimeTextWS ,
                    DateTimeWS ,
                    DateTextWS ,
                     UserDateDayWS ,
                      UserDateMonthWS ,
                      UserDateYearWS );



                //////    await Broadcast_ScreenChatShow_Text_Translate_Message
                //////               .Broadcast_ScreenChatShow_Text_Translate_MessageWS(
                //////           App.Current,
                //////iAccountType,
                ////// iOwnerModel,
                ////// MessageTokenID,

                //////              MessageTokenID,


                ////// InviteTag,
                ////// GroupID,
                ////// ScreenChatShowID,
                ////// ScreenChatShowTicketID,
                //////InviteOwnerUserID,
                //////InviteOwnerMobileNumberID,
                //////MessageType,
                //////MessageText,

                ////// iOwner_LanguageCode_IN,
                ////// iOwner_LanguageCode_OUT,


                //////                          DateTimeTextWS,
                //////           DateTimeWS,
                //////           DateTextWS,
                //////            UserDateDayWS,
                //////             UserDateMonthWS,
                //////            UserDateYearWS);




            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }

    }
}
