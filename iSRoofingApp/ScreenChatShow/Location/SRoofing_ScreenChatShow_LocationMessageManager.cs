using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;



using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Location;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Time;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Translation;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Image;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Media;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Location
{
    public static class SRoofing_ScreenChatShow_LocationMessageManager
    {



        #region Text



        #endregion


        #region Text_Translated


        public static async Task Owner_ScreenChatShowMessage_Location_MessageWS (
                    Application _context ,
                    string iAccountType ,
                    SRoofingApplicationUtilityModelManager iApplicationUtilityModel ,
                    SRoofingUserSettingModelManager iSettingModel ,

                    SRoofingLanguageTranslateModel iLanguageModel ,

                    SRoofingUserOwnerModelManager iOwnerModel ,
                      SRoofingUserGroupModelManager iGroupModel ,

        SRoofingSpeechModel iSpeechModel ,


                    string iOwner_LanguageCode_IN ,
                    string iOwner_LanguageCode_OUT ,


                      String GroupID ,


                     string MessageCode ,
                    string MessageText ,

            string MessageLineCode ,
            string MessageLineType ,

  SRoofingLocationModel iLocationModel ,

  string FullPath ,

            string ImageID ,
            List<string> ListImageID ,
            List<string> ListImageLocalFullPath ,
            Uri ImageURI ,
            string ImagePathURL ,
            string ImageServerURL ,
            string ImageIsViewOnly ,
            bool IsUploadNew )
        {

            _ = Task.Run ( async ( ) =>
                 {
                     // some long running task

                     // Task.Delay(5000);

                     ////TODO UNCOMMENT AFTER CREATE NEW CODE
                     string _iLanguageCode;
                     string _iOriginal_MessageText = MessageText;

                     string _iTranslated_MessageText;
                     string _iResult_MessageText;



                     try
                     {


                         string _MessageTokenID = SRoofing_TimeManager.Time_GenerateToken ( ); //DateTime.Now.Millisecond.ToString();


                         #region iTimeModel

                         SRoofingTimeModel _iTimeModel = new SRoofingTimeModel ( );
                         _iTimeModel = SRoofing_TimeManager.Time_Get_TimeModel ( DateTime.Now );

                         #endregion


                         //  string _xMessageText = iOwner_LanguageCode + "|" + MessageText;


                         ////////string DateTimeTextWS, DateTimeWS, DateTextWS, UserDateDayWS, UserDateMonthWS, UserDateYearWS;

                         ////////DateTime objNow = DateTime.Now ;

                         ////////DateTimeTextWS =SRoofing_TimeManager.Time_Get_DateTimeText(objNow);

                         ////////DateTimeWS =SRoofing_TimeManager.Time_Get_DateTime(objNow);

                         ////////DateTextWS = SRoofing_TimeManager.Time_Get_DateText(objNow); ; 

                         ////////UserDateDayWS = SRoofing_TimeManager.Time_Get_UploadDay(objNow);

                         ////////UserDateMonthWS = SRoofing_TimeManager.Time_Get_UploadMonth(objNow);

                         ////////UserDateYearWS= SRoofing_TimeManager.Time_Get_UploadYear(objNow);



                         #region TranslationModel

                         SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel
                         {
                             MessageCode_Original = iOwner_LanguageCode_OUT ,
                             MessageText_Original = MessageText ,

                             MessageCode_Translated = iOwner_LanguageCode_OUT ,
                             MessageText_Translated = MessageText

                         };


                         #endregion


                         #region Media_Model


                         SRoofingUserMediaModel _iUserMediaModel = new SRoofingUserMediaModel ( );

                         ////////  FileInfo fi = new FileInfo ( FullPath );


                         ////////  SRoofingUserMediaModel _iUserMediaModel = new SRoofingUserMediaModel (


                         ////////  ImageID ,
                         ////////  null ,

                         //////// SRoofingEnum_File_Code.FileCode_Image ,
                         ////////  SRoofingEnum_File_Type.ShareType_Image ,
                         //////// SRoofingEnum_File_Thum.FileThum_Image ,
                         ////////SRoofingEnum_File_Extension.FileExtension_Image_JPG ,
                         ////////  SRoofing_FileSystemManager.FormatSize ( fi.Length ) ,
                         ////////  "0" ,

                         ////////  ImageID ,
                         ////////  ImageID ,
                         ////////  ImagePathURL ,
                         ////////  SRoofing_URLManager.URL_Image.Image_Get_ImageByImageID ( App.Current , ImageID ) ,
                         ////////  ImageURI ,

                         ////////  ImageID ,
                         ////////  ImageID ,
                         ////////  ImagePathURL ,
                         ////////            SRoofing_URLManager.URL_Image.Image_Get_ImageByImageID ( App.Current , ImageID ) ,
                         ////////  ImageURI ,

                         ////////  null ,

                         ////////  null ,

                         ////////  null ,

                         ////////  true );


                         #endregion


                         #region Post

                  _ =      Task.Run ( async ( ) =>
                {


                    //SRoofingUserGroupModelManager _iGroupModel = new SRoofingUserGroupModelManager ( );
                    //await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel ( App.Current , iOwnerModel , GroupID );











                    await Post_ScreenChatShow_Location_Message
                              .Post_ScreenChatShowLocation_MessageWS (

                                      _context ,


                                   iApplicationUtilityModel ,

                                      iOwnerModel ,

                                      iSettingModel ,


                                   iLanguageModel ,

                                     iAccountType ,

                                      null ,

                                   iGroupModel ,
         _MessageTokenID ,
                                      _MessageTokenID ,

                                      GroupID ,

                                      iOwnerModel.OwnerUserTokenID ,
                                      iOwnerModel.OwnerMobileNumberTokenID ,

                                      "0" ,
                                      SRoofingEnum_UserType.UserType_Owner ,
                                      MessageCode ,
                                      MessageText ,
                                      MessageText ,


                               iTranslationModel ,


              iOwner_LanguageCode_IN ,
               iOwner_LanguageCode_OUT ,



                                      MessageLineCode ,
                                      MessageLineType ,

                                      // fileResult ,

                                      _iUserMediaModel ,

                                      iLocationModel ,

                  ImageID ,

                  ImageURI ,
                  ImagePathURL ,
                  ImageServerURL ,

                  ImageIsViewOnly ,

                                      SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save ,

                                                     _iTimeModel.DateTimeTextWS ,
                      _iTimeModel.DateTimeWS ,
                       _iTimeModel.DateTextWS ,
                       _iTimeModel.DateDayWS ,
                       _iTimeModel.DateMonthWS ,
                        _iTimeModel.DateYearWS ,


                                      0 );

                } ).ConfigureAwait (false );


                         //////////TlknBroadcastSender_ScreenChatShowMessage
                         //////////        .BroadcastSender_SendScreenChatShowMessage_ByGroupID(
                         //////////                _context,
                         //////////                GroupID,
                         //////////                TlknEnum_User_Type.UserType_Owner,
                         //////////                _MessageTokenID);


                         #endregion


                         #region Media_Model


                         #endregion



                         #region Broadcast



                         _ = Task.Run ( async ( ) =>
                         {

                          await ScreenChatShow_Media_Broadcast_Location_Message
                                .Broadcast_ScreenChatShowMessageShareLocationWS (

                                                    _context ,

                                            iAccountType ,

                                            iSettingModel ,
                                            iOwnerModel ,



                                            _MessageTokenID ,
                  "chat" ,

                                            "0" ,
                                            "0" ,

                         GroupID ,


                                      iOwnerModel.OwnerUserTokenID ,
                                      iOwnerModel.OwnerMobileNumberTokenID ,


                         MessageCode ,
                    MessageText ,


                                      iTranslationModel ,

                                      iOwner_LanguageCode_IN ,
                                      iOwner_LanguageCode_OUT ,


                _iUserMediaModel ,

                iLocationModel ,
                        "0" ,

                    "0" ,
                                            "0" ,

                                                        _iTimeModel.DateTimeTextWS ,
                     _iTimeModel.DateTimeWS ,
                      _iTimeModel.DateTextWS ,
                        _iTimeModel.DateDayWS ,
                     _iTimeModel.DateMonthWS ,
                        _iTimeModel.DateYearWS ,


                             IsUploadNew );


                         } ).ConfigureAwait ( false );
                         
                       













                         //////////TlknIntentService_ScreenChatShow_Media_Manager
                         //////////        .IntentServiceMedia_ScreenChatShow_Media_Broadcast_Text_Message_ByAccountType(

                         //////////                _context,

                         //////////                iAccountType,

                         //////////                iSettingModel,
                         //////////                iOwnerModel,

                         //////////                _MessageTokenID,

                         //////////                InviteTag,

                         //////////                "0",
                         //////////                "0",

                         //////////                GroupID,

                         //////////                InviteOwnerUserID,
                         //////////                InviteOwnerMobileNumberID,

                         //////////                MessageCode,
                         //////////                _xMessageText,

                         //////////                _iUserMediaModel,
                         //////////                "1",

                         //////////                "ToContactListUserID",
                         //////////                "ToContactListMobileNumberID",

                         //////////                false);

                         #endregion


                     }
                     catch ( Exception ex )
                     {
                         SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                         return;
                     }



                 } )
                     .ConfigureAwait ( false );




        }




        #endregion


        #region Emotion


        #endregion


    }
}
