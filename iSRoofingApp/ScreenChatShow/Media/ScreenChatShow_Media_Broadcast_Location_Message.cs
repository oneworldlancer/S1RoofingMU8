using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Location;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Translation;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_UploaderManager;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Document;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Image;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Location;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Text;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Media
{
    public class ScreenChatShow_Media_Broadcast_Location_Message
    {




        public static async Task Broadcast_ScreenChatShowMessageShareLocationWS (

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

         SRoofingLocationModel iLocationModel,


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

      //          if ( IsUploadNew )
      //          {

      //              if ( iUserMediaModel.MediaFile_Code == ( SRoofingEnum_File_Code.FileCode_Image ) )
      //              {



      //                  await SRoofing_UploadMediaManager.Uploader_MediaFile_ImageWS (

      //                          _context ,

      //  iAccountType ,

      //  iSettingModel ,
      //  iOwnerModel ,

      //App.SiteChatShareImageDataURLUpload ,
      //iUserMediaModel );

      //              }
      //          }



                await Broadcast_ScreenChatShow_Location_Message
                           .Broadcast_ScreenChatShow_Location_MessageWS (

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

         iLocationModel,

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





   
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }

    }
}
