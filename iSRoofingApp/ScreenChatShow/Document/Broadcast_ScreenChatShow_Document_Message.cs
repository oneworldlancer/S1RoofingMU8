using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
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

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Document
{
    public class Broadcast_ScreenChatShow_Document_Message
    {

        public static async
Task<string> Broadcast_ScreenChatShow_Document_MessageWS (

        Application _context ,

        string iAccountType ,
        SRoofingUserOwnerModelManager iOwnerModel ,
        string MessageTokenID ,

        string UploadDateTimeMilliSec ,

        string InviteTag ,
        string GroupID ,
        string ScreenChatShowID ,
        string ScreenChatShowTicketID ,
        string InviteOwnerUserID ,
        string InviteOwnerMobileNumberID ,
        string MessageType ,
        string MessageText ,



                         SRoofingTranslationModel iTranslationModel ,


        string iOwner_LanguageCode_IN ,
         string iOwner_LanguageCode_OUT ,


       SRoofingUserMediaModel iUserMediaModel ,

            string ImageID ,
            Uri ImageURI ,
            string ImagePathURL ,
            string ImageServerURL ,
            string ImageIsViewOnly ,

                                 string DateTimeTextWS ,
                  string DateTimeWS ,
                  string DateTextWS ,
                   string UserDateDayWS ,
                    string UserDateMonthWS ,
                    string UserDateYearWS )
        {

            try
            {
              _=    Task.Run ( async ( ) =>
                {

                    await  SRoofing_ScreenChatShowTextMessageWS
                 .SRoofing_XFMobile_ScreenChatShowMessage_SendScreenChatShowShareUploadDocumentMessageWSAsync (

                         App.iPlatformOS ,
                         App.iDatabaseServerTokenID ,
                         Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
                         App.iAccountType ,
                         MessageTokenID ,
                         MessageTokenID ,
                         GroupID ,
                         ScreenChatShowID ,
                         ScreenChatShowTicketID ,


                         iOwnerModel.OwnerUserTokenID ,
                         iOwnerModel.OwnerMobileNumberTokenID ,


                         iOwnerModel.OwnerUserTokenID ,
                         iOwnerModel.OwnerMobileNumberTokenID ,

                         InviteTag ,
                         SRoofingEnum_ScreenChatShowInviteCode.ScreenChatShowInviteCode_InviteText ,
                         "document" ,
                         MessageType ,


                              HttpUtility.UrlEncode ( "Shared file" ) ,
                     HttpUtility.UrlEncode ( "en" ) ,
                  HttpUtility.UrlEncode ( "Shared file" ) ,
                   HttpUtility.UrlEncode ( "en" ) ,
                  HttpUtility.UrlEncode ( "Shared file" ) ,



                                                iUserMediaModel.MediaFile_ServerID ,
                                              HttpUtility.UrlEncode ( iUserMediaModel.MediaFile_Title ) ,
                                              iUserMediaModel.MediaFile_Extension ,
                                          iUserMediaModel.MediaFile_Thum ,
                                          iUserMediaModel.MediaFile_Size ,
                                                                                  iUserMediaModel.MediaFile_Duration ,
               DateTimeTextWS ,
                         DateTimeWS ,
                         DateTextWS ,
                         UserDateDayWS ,
                         UserDateMonthWS ,
                         UserDateYearWS ,
                         MessageTokenID );



                } ).ConfigureAwait(false);
                //////////////////////////
                return "true";



            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return "false";
            }
        }
    }
}
