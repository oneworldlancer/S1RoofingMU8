using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

 

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Translation;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Media;

 
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Audio
{
    public static class SRoofing_ScreenChatShow_AudioMessageManager
    {


        #region Text



        #endregion


        #region Text_Translated


        public static async Task Owner_ScreenChatShowMessage_Audio_MessageWS (
                    Application _context,
                    string iAccountType,
                    SRoofingApplicationUtilityModelManager iApplicationUtilityModel ,
                    SRoofingUserSettingModelManager iSettingModel,

                    SRoofingLanguageTranslateModel iLanguageModel ,
                    
                    SRoofingUserOwnerModelManager iOwnerModel ,
                    SRoofingSpeechModel iSpeechModel,

                    string iOwner_LanguageCode_IN ,
                    string iOwner_LanguageCode_OUT ,

                      String GroupID ,


                     string MessageCode,
                    string MessageText,

            string MessageLineCode,
            string MessageLineType,

            FileResult fileResult,

            string ImageID,
            Uri ImageURI,
            string ImagePathURL,
            string ImageServerURL,
            string ImageIsViewOnly,
            bool IsUploadNew )
        {

             _= Task.Run(async () =>
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


                    string _MessageTokenID = SRoofing_TimeManager.Time_GenerateToken(); //DateTime.Now.Millisecond.ToString();


                    //  string _xMessageText = iOwner_LanguageCode + "|" + MessageText;


                    string DateTimeTextWS, DateTimeWS, DateTextWS, UserDateDayWS, UserDateMonthWS, UserDateYearWS;

                    DateTime objNow = DateTime.Now ;

                    DateTimeTextWS =SRoofing_TimeManager.Time_Get_DateTimeText(objNow);

                    DateTimeWS =SRoofing_TimeManager.Time_Get_DateTime(objNow);
                    
                    DateTextWS = SRoofing_TimeManager.Time_Get_DateText(objNow); ; 
                    
                    UserDateDayWS = SRoofing_TimeManager.Time_Get_UploadDay(objNow);

                    UserDateMonthWS = SRoofing_TimeManager.Time_Get_UploadMonth(objNow);
                    
                    UserDateYearWS= SRoofing_TimeManager.Time_Get_UploadYear(objNow);




                    #region TranslationModel

                    SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel { 
                        MessageCode_Original= iOwner_LanguageCode_OUT     ,
                        MessageText_Original= MessageText,

                        MessageCode_Translated= iOwner_LanguageCode_OUT,
                        MessageText_Translated= MessageText

                    };


                    #endregion



                    #region Nedia_Model


                    SRoofingUserMediaModel _iUserMediaModel = new SRoofingUserMediaModel (


                    ImageID ,
                    null ,

                   SRoofingEnum_File_Code.FileCode_Audio ,
                    SRoofingEnum_File_Type.ShareType_Audio ,
                     SRoofingEnum_File_Thum.FileThum_Audio ,
                     SRoofingEnum_File_Extension.FileExtension_Audio_MP3 ,
                    "0" ,  "0" , "0" ,

                    ImageID ,
                    ImageID ,
                    ImagePathURL ,
                    ImageServerURL ,
                    ImageURI ,

                    ImageID ,
                    ImageID ,
                    ImagePathURL ,
                    ImageServerURL ,
                    ImageURI ,

                    null ,

                    fileResult ,

                    null ,

                    true );


                    #endregion


                    #region Post


             //////       await Post_ScreenChatShow_Audio_Message
             //////            .Post_ScreenChatShowAudio_MessageWS (

             //////                    _context,


             //////                 iApplicationUtilityModel ,

             //////                    iOwnerModel ,

             //////                    iSettingModel,

             //////                    iAccountType,

             //////                    null,

             //////                    _MessageTokenID,
             //////                    _MessageTokenID,

             //////                    GroupID,

             //////                    iOwnerModel.OwnerUserTokenID,
             //////                    iOwnerModel.OwnerMobileNumberTokenID,

             //////                    "0",
             //////                    SRoofingEnum_UserType.UserType_Owner,
             //////                    MessageCode,
             //////                    MessageText,
             //////                    MessageText,



             //////                    iTranslationModel ,

             //////                    iOwner_LanguageCode_IN ,
             //////                    iOwner_LanguageCode_OUT ,


             //////                    MessageLineCode ,
             //////                    MessageLineType,

             //////                    fileResult ,
             //////                    _iUserMediaModel ,

             //////ImageID ,
             
             //////ImageURI,
             //////ImagePathURL,
             //////ImageServerURL,

             //////ImageIsViewOnly,

             //////                    SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save,

             //////                                      DateTimeTextWS,
             //////       DateTimeWS,
             //////       DateTextWS,
             //////        UserDateDayWS,
             //////         UserDateMonthWS,
             //////         UserDateYearWS,


             //////                    0);

                    //////////TlknBroadcastSender_ScreenChatShowMessage
                    //////////        .BroadcastSender_SendScreenChatShowMessage_ByGroupID(
                    //////////                _context,
                    //////////                GroupID,
                    //////////                TlknEnum_User_Type.UserType_Owner,
                    //////////                _MessageTokenID);


                    #endregion




                    #region Media_Model



                    FileInfo fi = new FileInfo ( fileResult.FullPath );


                    #endregion



                    #region Broadcast


                    await ScreenChatShow_Media_Broadcast_Audio_Message
                           .Broadcast_ScreenChatShowMessageShareAudioWS(

                                               _context,

                                       iAccountType,

                                       iSettingModel,
                                       iOwnerModel,



                                       _MessageTokenID,
             "chat",

                                       "0",
                                       "0",

                    GroupID,


                                 iOwnerModel.OwnerUserTokenID,
                                 iOwnerModel.OwnerMobileNumberTokenID,


                    MessageCode,
               MessageText,



                                 iTranslationModel ,

                                 iOwner_LanguageCode_IN ,
                                 iOwner_LanguageCode_OUT ,



           _iUserMediaModel ,
                   "0",

               "0",
                                       "0",

                                                        DateTimeTextWS,
                    DateTimeWS,
                    DateTextWS,
                     UserDateDayWS,
                      UserDateMonthWS,
                      UserDateYearWS,


                        IsUploadNew );















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
                catch (Exception ex)
                {
                    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    return;
                }



            });




        }




        #endregion


        #region Emotion


        #endregion


    }
}
