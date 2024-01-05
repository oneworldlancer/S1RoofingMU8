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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Time;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Translation;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Media;

 
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Document
{
    public static class SRoofing_ScreenChatShow_DocumentMessageManager
    {


        #region Text



        #endregion


        #region Text_Translated


        public static async Task Owner_ScreenChatShowMessage_Document_MessageWS (
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

            FileResult fileResult ,

            string DocumentID ,
            Uri DocumentURI ,
            string DocumentPathURL ,
            string DocumentServerURL ,
            string ImageIsViewOnly ,
            bool IsUploadNew ,
                     SRoofingScreenChatShowMessageModelManager iMessageModel = null )
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

                        _ = Task.Run ( async ( ) =>
                      {

                          string _MessageTokenID = SRoofing_TimeManager.Time_GenerateToken ( ); //DateTime.Now.Millisecond.ToString();


                          #region iTimeModel

                          SRoofingTimeModel _iTimeModel = new SRoofingTimeModel ( );
                          _iTimeModel = SRoofing_TimeManager.Time_Get_TimeModel ( DateTime.Now );

                          #endregion


                          string DocumentName = "0", DocumentExtension = "0";

                          DocumentName = fileResult.FileName.Replace ( "-" , "_" );
                          DocumentExtension = System.IO.Path.GetExtension ( DocumentName ).Remove ( 0 , 1 );





                          #region Media_Model


                          string DocumentThum = "0";

                          if ( DocumentExtension == "pdf" )
                          {
                              DocumentThum = SRoofingEnum_File_Thum.FileThum_DocumentPDF;
                          }
                          else if ( DocumentExtension.Contains ( "doc" ) )
                          {
                              DocumentThum = SRoofingEnum_File_Thum.FileThum_Document_Word;
                          }
                          else if ( DocumentExtension.Contains ( "xls" ) )
                          {
                              DocumentThum = SRoofingEnum_File_Thum.FileThum_Document_Excel;
                          }
                          SRoofingUserMediaModel _iUserMediaModel = null;


                          if ( IsUploadNew )
                          {
                              FileInfo fi = new FileInfo ( fileResult.FullPath );


                              _iUserMediaModel = new SRoofingUserMediaModel (


                        DocumentID ,
                        null ,

                       SRoofingEnum_File_Code.FileCode_Document ,
                        SRoofingEnum_File_Type.ShareType_Document ,
                        DocumentThum ,
                        DocumentName ,
                       DocumentExtension ,
                        SRoofing_FileSystemManager.FormatSize ( fi.Length ) ,
                        "0" ,

                        DocumentID ,
                        DocumentID ,
                        DocumentPathURL ,
                        SRoofing_URLManager.URL_Document.Document_Get_DocumentDataByDocumentID ( App.Current , DocumentID , DocumentName , DocumentExtension ) ,
                        DocumentURI ,

                        DocumentID ,
                        DocumentID ,
                        DocumentPathURL ,
                        DocumentServerURL ,
                        DocumentURI ,

                        null ,

                        fileResult ,

                        null ,

                        false );

                          }

                          else
                          {

                              _iUserMediaModel = new SRoofingUserMediaModel (


                        DocumentID ,
                        null ,

                       iMessageModel.MediaFile_Code ,
                        iMessageModel.MediaFile_Type ,
                        iMessageModel.MediaFile_Thum ,
                            iMessageModel.MediaFile_Name ,
                       iMessageModel.MediaFile_Extension ,
                        iMessageModel.MediaFile_Size ,
                        "0" ,

                        DocumentID ,
                        DocumentID ,
                        iMessageModel.ImageDefaultPath,
                        SRoofing_URLManager.URL_Document.Document_Get_DocumentDataByDocumentID ( App.Current , DocumentID , DocumentName , DocumentExtension ) ,
                        null ,

                        DocumentID ,
                        DocumentID ,
                             iMessageModel.ImageDefaultPath ,
                             iMessageModel.ImageDefaultServerURL ,
                        null ,

                        null ,

                        null ,

                        null ,

                        false );

                          }




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






                          #region Post


                          _ = Task.Run ( async ( ) =>
                          {


                              //SRoofingUserGroupModelManager _iGroupModel = new SRoofingUserGroupModelManager ( );
                              //await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel ( App.Current , iOwnerModel , GroupID );




                              await Post_ScreenChatShow_Document_Message
                           .Post_ScreenChatShowDocument_MessageWS (

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

                                   //   fileResult ,

                                   _iUserMediaModel ,

               DocumentID ,

               DocumentName ,

               DocumentExtension ,


               DocumentURI ,
               DocumentPathURL ,
               DocumentServerURL ,

               ImageIsViewOnly ,

                                   SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save ,

                                                 _iTimeModel.DateTimeTextWS ,
                    _iTimeModel.DateTimeWS ,
                   _iTimeModel.DateTextWS ,
                    _iTimeModel.DateDayWS ,
                    _iTimeModel.DateMonthWS ,
                  _iTimeModel.DateYearWS ,


                                   0 );

                          } ).ConfigureAwait ( false );





                          #endregion


                          #region Broadcast


                          _ = Task.Run ( async ( ) =>
                          {
                              await ScreenChatShow_Media_Broadcast_Document_Message
                          .Broadcast_ScreenChatShowMessageShareDocumentWS (

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
              "0" ,

                   iTranslationModel ,

                                iOwner_LanguageCode_IN ,
                                iOwner_LanguageCode_OUT ,


          _iUserMediaModel ,
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



                      } );

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
