using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

 

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Translation;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Media;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Emotion
{
    public static class SRoofing_ScreenChatShow_EmotionMessageManager
    {


        #region Text



        #endregion


        #region Text_Translated


        public static async Task Owner_ScreenChatShowMessage_Emotion_MessageWS(
                    Application _context,
                    string iAccountType,
                    SRoofingUserSettingModelManager iSettingModel,
                    SRoofingUserOwnerModelManager iOwnerModel,
                    SRoofingSpeechModel iSpeechModel,


                    string iOwner_LanguageCode_IN ,
                    string iOwner_LanguageCode_OUT ,


                      String GroupID ,


                     string MessageCode,
                    string MessageText,

            string MessageLineCode,
            string MessageLineType)
        {

              Task.Run(async () =>
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

                    SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel
                    {
                        MessageCode_Original = iOwner_LanguageCode_OUT ,
                        MessageText_Original = "Emotion" ,

                        MessageCode_Translated = iOwner_LanguageCode_OUT ,
                        MessageText_Translated = "Emotion"

                    };


                    #endregion






                    #region Post


                    await Post_ScreenChatShow_Emotion_Message
                         .Post_ScreenChatShowEmotion_MessageWS(

                                 _context,

                                 iOwnerModel,

                                 iSettingModel,

                                 iAccountType,

                                 null,

                                 _MessageTokenID,
                                 _MessageTokenID,

                                 GroupID,

                                 iOwnerModel.OwnerUserTokenID,
                                 iOwnerModel.OwnerMobileNumberTokenID,

                                 "0",
                                 SRoofingEnum_UserType.UserType_Owner,
                                 MessageCode,
                                 MessageText,
                                 MessageText,


                                 iTranslationModel ,

                                 iOwner_LanguageCode_IN ,
                                 iOwner_LanguageCode_OUT ,

                                 MessageLineCode ,
                                 MessageLineType,
                                 SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save,

                                                   DateTimeTextWS,
                    DateTimeWS,
                    DateTextWS,
                     UserDateDayWS,
                      UserDateMonthWS,
                      UserDateYearWS,


                                 0);

                    //////////TlknBroadcastSender_ScreenChatShowMessage
                    //////////        .BroadcastSender_SendScreenChatShowMessage_ByGroupID(
                    //////////                _context,
                    //////////                GroupID,
                    //////////                TlknEnum_User_Type.UserType_Owner,
                    //////////                _MessageTokenID);


                    #endregion


                    #region Broadcast


                    SRoofingUserMediaModel _iUserMediaModel = new SRoofingUserMediaModel();

                    await ScreenChatShow_Media_Broadcast_Emotion_Message
                           .Broadcast_ScreenChatShowMessageShareEmotionWS(

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


                        false);















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
