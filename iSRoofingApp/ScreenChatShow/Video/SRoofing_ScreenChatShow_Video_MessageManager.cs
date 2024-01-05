using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
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

namespace S1RoofingMU.iSRoofingApp.ScreenChatShow.Video
{
    public static class SRoofing_ScreenChatShow_Video_MessageManager
    {


        #region Text



        #endregion


        #region Text_Translated


        public static async Task Owner_ScreenChatShowMessage_Video_MessageWS(
                    Application _context,
                    string iAccountType,
                    SRoofingApplicationUtilityModelManager iApplicationUtilityModel,
                    SRoofingUserSettingModelManager iSettingModel,

                    SRoofingLanguageTranslateModel iLanguageModel,

                    SRoofingUserOwnerModelManager iOwnerModel,
                         SRoofingUserGroupModelManager iGroupModel,

       SRoofingSpeechModel iSpeechModel,


                    string iOwner_LanguageCode_IN,
                    string iOwner_LanguageCode_OUT,


                      String GroupID,


                     string MessageCode,
                    string MessageText,

            string MessageLineCode,
            string MessageLineType,


            FileResult fileResult,


            string FullPath,


            string VideoID,

            string FileFullPath,
             Uri VideoURI,
            string VideoPathURL,
            string VideoServerURL,
            string VideoIsViewOnly,
            bool IsUploadNew,
                     SRoofingScreenChatShowMessageModelManager iMessageModel = null)
        {

            _ = Task.Run(async () =>
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

                    #region iTimeModel

                    SRoofingTimeModel _iTimeModel = new SRoofingTimeModel();
                    _iTimeModel = SRoofing_TimeManager.Time_Get_TimeModel(DateTime.Now);

                    #endregion




                    #region TranslationModel

                    SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel
                    {
                        MessageCode_Original = iOwner_LanguageCode_OUT,
                        MessageText_Original = MessageText,

                        MessageCode_Translated = iOwner_LanguageCode_OUT,
                        MessageText_Translated = MessageText

                    };


                    #endregion



                    #region Media_Model

                    SRoofingUserMediaModel _iUserMediaModel = null;

                    if (IsUploadNew)
                    {

                        var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_VideoModel>();

                        string _VideoThumPath = "0";
                        ImageSource imageSource = null;
                        _VideoThumPath = Path.Combine(FileSystem.Current.CacheDirectory, "thm_" + VideoID + ".jpg");

                        if (objService != null)
                        {
                            //imageSource = objService.GenerateThumbImage(fileResult.FullPath);
                            imageSource = objService.GenerateThumbImage(FileFullPath);

                            await SRoofing_ImageManager.SaveImageAsync(imageSource, _VideoThumPath);

                        }

                        //FileInfo fi = new FileInfo(fileResult.FullPath);
                        FileInfo fi = new FileInfo(FileFullPath);


                        _iUserMediaModel = new SRoofingUserMediaModel(


                       VideoID,
                       null,

                      SRoofingEnum_File_Code.FileCode_Video,
                       SRoofingEnum_File_Type.ShareType_Video,
                       SRoofingEnum_File_Thum.FileThum_Video,
                       "0",
                       SRoofingEnum_File_Extension.FileExtension_Video_MP4,
                           SRoofing_FileSystemManager.FormatSize(fi.Length),
                         objService.VideoDuration(FileFullPath),

                       VideoID,
                       VideoID,
                        FileFullPath,
                      VideoServerURL,
                       VideoURI,

                       VideoID,
                       VideoID,
                       _VideoThumPath,
                       VideoServerURL,
                       VideoURI,

                       null,

                       fileResult,

                       imageSource,

                       true);

                    }
                    else
                    {


                        _iUserMediaModel = new SRoofingUserMediaModel(


                       VideoID,
                       null,

                      SRoofingEnum_File_Code.FileCode_Video,
                       SRoofingEnum_File_Type.ShareType_Video,
                       SRoofingEnum_File_Thum.FileThum_Video,
                      "0",
                      SRoofingEnum_File_Extension.FileExtension_Video_MP4,
                       iMessageModel.MediaFile_Size,
                       iMessageModel.MediaFile_Duration,

                       VideoID,
                       VideoID,
                 iMessageModel.VideoDefaultPath,
                       iMessageModel.VideoDefaultServerURL,
                       null,

                       VideoID,
                       VideoID,
                       iMessageModel.VideoThumPath,
                       iMessageModel.VideoDefaultServerThumURL,
                       null,

                       null,

                       null,

                       null,

                       true);

                    }






                    #endregion






                    #region Post

                    _ = Task.Run(async () =>
              {


                  //SRoofingUserGroupModelManager _iGroupModel = new SRoofingUserGroupModelManager ( );
                  //await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel ( App.Current , iOwnerModel , GroupID );








                  await Post_ScreenChatShow_Video_Message
                       .Post_ScreenChatShowVideo_MessageWS(

                               _context,

                               iApplicationUtilityModel,

                               iOwnerModel,

                               iSettingModel,


                            iLanguageModel,

                             iAccountType,

                               null,

                            iGroupModel,
   _MessageTokenID,
                               _MessageTokenID,

                               GroupID,

                               iOwnerModel.OwnerUserTokenID,
                               iOwnerModel.OwnerMobileNumberTokenID,

                               "0",
                               SRoofingEnum_UserType.UserType_Owner,
                               MessageCode,
                               "0",
                               "0",


                               iTranslationModel,

                               iOwner_LanguageCode_IN,
                               iOwner_LanguageCode_OUT,

                               MessageLineCode,
                               MessageLineType,

                               fileResult,
                               _iUserMediaModel,

                                             VideoID,
            VideoURI,
            VideoPathURL,
            VideoServerURL,
            VideoIsViewOnly,

                               SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save,

                                            _iTimeModel.DateTimeTextWS,
               _iTimeModel.DateTimeWS,
               _iTimeModel.DateTextWS,
               _iTimeModel.DateDayWS,
               _iTimeModel.DateMonthWS,
                 _iTimeModel.DateYearWS,


                               0);

              }).ConfigureAwait(false);


                    //////////TlknBroadcastSender_ScreenChatShowMessage
                    //////////        .BroadcastSender_SendScreenChatShowMessage_ByGroupID(
                    //////////                _context,
                    //////////                GroupID,
                    //////////                TlknEnum_User_Type.UserType_Owner,
                    //////////                _MessageTokenID);


                    #endregion












                    #region Broadcast


                    _ = Task.Run(async () =>
                    {
                        await ScreenChatShow_Media_Broadcast_Video_Message
                         .Broadcast_ScreenChatShowMessageShareVideoWS(

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
             "0",

                  iTranslationModel,

                               iOwner_LanguageCode_IN,
                               iOwner_LanguageCode_OUT,

         _iUserMediaModel,
                 "0",

             "0",
                                     "0",

                                                  _iTimeModel.DateTimeTextWS,
               _iTimeModel.DateTimeWS,
               _iTimeModel.DateTextWS,
              _iTimeModel.DateDayWS,
                 _iTimeModel.DateMonthWS,
                _iTimeModel.DateYearWS,


                     IsUploadNew);


                    }).ConfigureAwait(false);


















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



            })
                .ConfigureAwait(false);


        }



        public static async Task Owner_ScreenChatShowMessage_Video_MessageWS_X1(
                    Application _context,
                    string iAccountType,
                    SRoofingApplicationUtilityModelManager iApplicationUtilityModel,
                    SRoofingUserSettingModelManager iSettingModel,

                    SRoofingLanguageTranslateModel iLanguageModel,

                    SRoofingUserOwnerModelManager iOwnerModel,
                         SRoofingUserGroupModelManager iGroupModel,

       SRoofingSpeechModel iSpeechModel,


                    string iOwner_LanguageCode_IN,
                    string iOwner_LanguageCode_OUT,


                      String GroupID,


                     string MessageCode,
                    string MessageText,

            string MessageLineCode,
            string MessageLineType,


            FileResult fileResult,


            string FullPath,


            string VideoID,

            string FileFullPath,
             Uri VideoURI,
            string VideoPathURL,
            string VideoServerURL,
            string VideoIsViewOnly,
            bool IsUploadNew,
                     SRoofingScreenChatShowMessageModelManager iMessageModel = null)
        {

            _ = Task.Run(async () =>
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

                    #region iTimeModel

                    SRoofingTimeModel _iTimeModel = new SRoofingTimeModel();
                    _iTimeModel = SRoofing_TimeManager.Time_Get_TimeModel(DateTime.Now);

                    #endregion




                    #region TranslationModel

                    SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel
                    {
                        MessageCode_Original = iOwner_LanguageCode_OUT,
                        MessageText_Original = MessageText,

                        MessageCode_Translated = iOwner_LanguageCode_OUT,
                        MessageText_Translated = MessageText

                    };


                    #endregion



                    #region Media_Model

                    SRoofingUserMediaModel _iUserMediaModel = null;

                    if (IsUploadNew)
                    {

                        var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_VideoModel>();

                        string _VideoThumPath = "0";
                        ImageSource imageSource = null;
                        _VideoThumPath = Path.Combine(FileSystem.Current.CacheDirectory, "thm_" + VideoID + ".jpg");

                        if (objService != null)
                        {
                            imageSource = objService.GenerateThumbImage(fileResult.FullPath);

                            await SRoofing_ImageManager.SaveImageAsync(imageSource, _VideoThumPath);

                        }

                        FileInfo fi = new FileInfo(fileResult.FullPath);


                        _iUserMediaModel = new SRoofingUserMediaModel(


                       VideoID,
                       null,

                      SRoofingEnum_File_Code.FileCode_Video,
                       SRoofingEnum_File_Type.ShareType_Video,
                       SRoofingEnum_File_Thum.FileThum_Video,
                       "0",
                       SRoofingEnum_File_Extension.FileExtension_Video_MP4,
                           SRoofing_FileSystemManager.FormatSize(fi.Length),
                         objService.VideoDuration(fileResult.FullPath),

                       VideoID,
                       VideoID,
                       MediaFile_LocalPathURL: FileFullPath,
                      VideoServerURL,
                       VideoURI,

                       VideoID,
                       VideoID,
                       _VideoThumPath,
                       VideoServerURL,
                       VideoURI,

                       null,

                       fileResult,

                       imageSource,

                       true);

                    }
                    else
                    {


                        _iUserMediaModel = new SRoofingUserMediaModel(


                       VideoID,
                       null,

                      SRoofingEnum_File_Code.FileCode_Video,
                       SRoofingEnum_File_Type.ShareType_Video,
                       SRoofingEnum_File_Thum.FileThum_Video,
                      "0",
                      SRoofingEnum_File_Extension.FileExtension_Video_MP4,
                       iMessageModel.MediaFile_Size,
                       iMessageModel.MediaFile_Duration,

                       VideoID,
                       VideoID,
                 iMessageModel.VideoDefaultServerURL,
                       iMessageModel.VideoDefaultServerURL,
                       null,

                       VideoID,
                       VideoID,
                       iMessageModel.VideoDefaultServerThumURL,
                       iMessageModel.VideoDefaultServerURL,
                       null,

                       null,

                       null,

                       null,

                       true);

                    }






                    #endregion






                    #region Post

                    _ = Task.Run(async () =>
              {


                  //SRoofingUserGroupModelManager _iGroupModel = new SRoofingUserGroupModelManager ( );
                  //await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel ( App.Current , iOwnerModel , GroupID );








                  await Post_ScreenChatShow_Video_Message
                       .Post_ScreenChatShowVideo_MessageWS(

                               _context,

                               iApplicationUtilityModel,

                               iOwnerModel,

                               iSettingModel,


                            iLanguageModel,

                             iAccountType,

                               null,

                            iGroupModel,
   _MessageTokenID,
                               _MessageTokenID,

                               GroupID,

                               iOwnerModel.OwnerUserTokenID,
                               iOwnerModel.OwnerMobileNumberTokenID,

                               "0",
                               SRoofingEnum_UserType.UserType_Owner,
                               MessageCode,
                               "0",
                               "0",


                               iTranslationModel,

                               iOwner_LanguageCode_IN,
                               iOwner_LanguageCode_OUT,

                               MessageLineCode,
                               MessageLineType,

                               fileResult,
                               _iUserMediaModel,

                                             VideoID,
            VideoURI,
            VideoPathURL,
            VideoServerURL,
            VideoIsViewOnly,

                               SRoofingEnum_ScreenChatShow_Message_Status.ScreenChatShow_Message_Save,

                                            _iTimeModel.DateTimeTextWS,
               _iTimeModel.DateTimeWS,
               _iTimeModel.DateTextWS,
               _iTimeModel.DateDayWS,
               _iTimeModel.DateMonthWS,
                 _iTimeModel.DateYearWS,


                               0);

              }).ConfigureAwait(false);


                    //////////TlknBroadcastSender_ScreenChatShowMessage
                    //////////        .BroadcastSender_SendScreenChatShowMessage_ByGroupID(
                    //////////                _context,
                    //////////                GroupID,
                    //////////                TlknEnum_User_Type.UserType_Owner,
                    //////////                _MessageTokenID);


                    #endregion












                    #region Broadcast


                    _ = Task.Run(async () =>
                    {
                        await ScreenChatShow_Media_Broadcast_Video_Message
                         .Broadcast_ScreenChatShowMessageShareVideoWS(

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
             "0",

                  iTranslationModel,

                               iOwner_LanguageCode_IN,
                               iOwner_LanguageCode_OUT,

         _iUserMediaModel,
                 "0",

             "0",
                                     "0",

                                                  _iTimeModel.DateTimeTextWS,
               _iTimeModel.DateTimeWS,
               _iTimeModel.DateTextWS,
              _iTimeModel.DateDayWS,
                 _iTimeModel.DateMonthWS,
                _iTimeModel.DateYearWS,


                     IsUploadNew);


                    }).ConfigureAwait(false);


















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



            })
                .ConfigureAwait(false);


        }




        #endregion


        #region Emotion


        #endregion


    }
}
