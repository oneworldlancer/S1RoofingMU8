using System;
using System.Collections.Generic;
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
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Media;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Text
{
    public static class SRoofing_ScreenChatShow_TextMessageManager
    {


        #region Text



        #endregion


        #region Text_Translated


        public static async Task Owner_ScreenChatShowMessage_TextTranslate_Pending_MessageWS (
                    Application _context ,
                    string iAccountType ,
                    SRoofingUserSettingModelManager iSettingModel ,

        SRoofingLanguageTranslateModel iLanguageModel ,

   SRoofingUserOwnerModelManager iOwnerModel ,
                    SRoofingUserGroupModelManager iGroupModel ,

        SRoofingSpeechModel iSpeechModel ,

                    string iOwner_LanguageCode_IN ,
                    string iOwner_LanguageCode_OUT ,

                    string GroupID ,


                     string MessageCode ,
                    string MessageText ,

            string MessageLineCode ,
            string MessageLineType )
        {

        _=      Task.Run ( async ( ) =>
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

                    string _xMessageText = iOwner_LanguageCode_IN + "|" + MessageText;


                    string DateTimeTextWS, DateTimeWS, DateTextWS, UserDateDayWS, UserDateMonthWS, UserDateYearWS;

                    #region iTimeModel

                    SRoofingTimeModel _iTimeModel = new SRoofingTimeModel ( );
                    _iTimeModel = SRoofing_TimeManager.Time_Get_TimeModel ( DateTime.Now );

                    #endregion

                    //DateTime objNow = DateTime.Now;

                    //DateTimeTextWS = SRoofing_TimeManager.Time_Get_DateTimeText ( objNow );

                    //DateTimeWS = SRoofing_TimeManager.Time_Get_DateTime ( objNow );

                    //DateTextWS = SRoofing_TimeManager.Time_Get_DateText ( objNow ); ;

                    //UserDateDayWS = SRoofing_TimeManager.Time_Get_UploadDay ( objNow );

                    //UserDateMonthWS = SRoofing_TimeManager.Time_Get_UploadMonth ( objNow );

                    //UserDateYearWS = SRoofing_TimeManager.Time_Get_UploadYear ( objNow );



                    #region TranslationModel

                    SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel ( );

                    // if message is url
                    if ( Uri.IsWellFormedUriString ( MessageText , UriKind.Absolute ) )     // url-valid 
                    {
                        // YES, retrn URL message
                        iTranslationModel.MessageType = "textweblink";
                        iTranslationModel.MessageCode_Translated = "en"; // iOwner_LanguageCode_OUT;
                        iTranslationModel.MessageText_Translated = MessageText.ToLower ( );

                        iTranslationModel.MessageCode_Original = "en"; // iOwner_LanguageCode_OUT;
                        iTranslationModel.MessageText_Original = MessageText.ToLower ( );

                        MessageCode = SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_TextWebLinkMessage;
                    }
                    else
                    {
                        //NO, return traslation-Model

                        iTranslationModel = SRoofing_TranslationManager.Get_TranslationModel (
                    SRoofingEnum_Direction.Direction_Out ,
                     iOwner_LanguageCode_IN ,
                       iOwner_LanguageCode_OUT ,
                     MessageText ).Result;


                        if ( iTranslationModel.MessageText_Translated == "0" )
                        {
                            iTranslationModel.MessageType = "textmessage";
                            iTranslationModel.MessageCode_Translated = iTranslationModel.MessageCode_Original;
                            iTranslationModel.MessageText_Translated = iTranslationModel.MessageText_Original;
                        }

                        MessageCode = SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_TextMessage_ParsePendingMessage;

                    }




                    #endregion


                    #region Post

                   _=   Task.Run ( async ( ) =>
                 {




                     //SRoofingUserGroupModelManager _iGroupModel = new SRoofingUserGroupModelManager ( );
                     //await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel ( App.Current , iOwnerModel , GroupID );








                     await Post_ScreenChatShow_Text_Translate_Pending_Message
                          .Post_ScreenChatShowTextTranslate_PendingMessageWS (

                                  _context ,

                                  iOwnerModel ,

                                  iSettingModel ,
                                iLanguageModel,

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
                                  _xMessageText ,
                                  MessageText ,

                                  iTranslationModel ,

                                  iOwner_LanguageCode_IN ,
                                  iOwner_LanguageCode_OUT ,

                                  MessageLineCode ,
                                  MessageLineType ,
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


                    _=  Task.Run ( async ( ) =>
                    {

                        SRoofingUserMediaModel _iUserMediaModel = new SRoofingUserMediaModel ( );

                        await ScreenChatShow_Media_Broadcast_Text_Message
                               .Broadcast_ScreenChatShowMessageShareTextTranslateWS (

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

                        MessageCode ,
                   _xMessageText ,


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


                            false );


                    } ).ConfigureAwait ( false );


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
