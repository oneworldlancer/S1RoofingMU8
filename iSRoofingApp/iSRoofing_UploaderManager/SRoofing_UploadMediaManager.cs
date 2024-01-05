using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

 
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_UploaderManager
{
    public class SRoofing_UploadMediaManager
    {

        public static async Task Uploader_MediaFile_AvatarWS (

      Application _context ,

      string iAccountType ,
      string OwnerUserTokenID ,
      string OwnerMobileNumberTokenID ,

      //SRoofingUserSettingModelManager iSettingModel ,
      //SRoofingUserOwnerModelManager iOwnerModel ,

      string EndpointURL ,


 SRoofingUserMediaModel iUserMediaModel )


        {
            try
            {

                var content = new MultipartFormDataContent ( );

                content.Add ( new StreamContent ( await iUserMediaModel.fileResult.OpenReadAsync ( ) ) , "file" , iUserMediaModel.fileResult.FileName );


                StringContent FileID = new StringContent ( iUserMediaModel.MediaFile_ServerID );
                content.Add ( FileID , "\"FileID\"" );



                StringContent FileDuration = new StringContent ( "0" );
                content.Add ( FileDuration , "\"FileDuration\"" );



                StringContent FileSize = new StringContent ( "0" );
                content.Add ( FileSize , "\"FileSize\"" );



                StringContent imgcod = new StringContent ( "avatar" );
                content.Add ( imgcod , "\"imgcod\"" );


                StringContent imgtyp = new StringContent ( "mid" );
                content.Add ( imgtyp , "\"imgtyp\"" );



                StringContent title = new StringContent ( "title" );
                content.Add ( title , "\"title\"" );

                StringContent description = new StringContent ( "description" );
                content.Add ( description , "\"description\"" );

                StringContent devid = new StringContent ( Preferences.Get ( "DeviceGlobalID" , "0" ) );
                content.Add ( devid , "\"devid\"" );


                StringContent syscod = new StringContent ( Preferences.Get ( "PlatformOS" , "0" ) );
                content.Add ( syscod , "\"syscod\"" );

                StringContent acctyp = new StringContent ( App.iAccountType );
                content.Add ( acctyp , "\"acctyp\"" );

                StringContent uid = new StringContent ( OwnerUserTokenID );
                content.Add ( uid , "\"uid\"" );


                StringContent mobid = new StringContent ( OwnerMobileNumberTokenID );
                content.Add ( mobid , "\"mobid\"" );



                //var httpClient =  new HttpClient ( );

                HttpClientHandler insecureHandler = GetInsecureHandler();
                HttpClient httpClient = new HttpClient(insecureHandler);

                //#if DEBUG
                //                HttpClientHandler insecureHandler = GetInsecureHandler ( );
                //                HttpClient httpClient = new HttpClient ( insecureHandler );
                //#else
                //                HttpClient httpClient = new HttpClient();
                //#endif



                var response = await httpClient.PostAsync ( App.SiteUserUploadAvatarImageProfileDataURLUpload , content );

                App._blnSyncOwnerAvatar = true;
                App._blnSyncOwnerGalleryPersonal = true;
                App._blnSyncOwnerLandingAvatar = true;
                App._blnSyncOwnerAccountAvatar = true;


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }




        public static async Task Uploader_MediaFile_ImageWS (

      Application _context ,

      string iAccountType ,

      SRoofingUserSettingModelManager iSettingModel ,
      SRoofingUserOwnerModelManager iOwnerModel ,

      string EndpointURL ,


 SRoofingUserMediaModel iUserMediaModel )


        {


            try
            {

                var content = new MultipartFormDataContent ( );

                //////using ( var stream = new System.IO.FileStream ( iUserMediaModel.MediaFile_LocalPathURL , FileMode.Open , FileAccess.Read ) )
                //////{
                //////    content.Add ( new StreamContent ( stream ) , "file" , "img_" + iUserMediaModel.MediaFile_ServerID + ".jpg" );

                //////}

                var iStream = new System.IO.FileStream ( iUserMediaModel.MediaFile_LocalPathURL , FileMode.Open , FileAccess.Read );
                        content.Add ( new StreamContent ( iStream ) , "file" , "img_" + iUserMediaModel.MediaFile_ServerID + ".jpg" );



                //content.Add ( new StreamContent ( await iUserMediaModel.fileResult.OpenReadAsync ( ) ) , "file" , iUserMediaModel.fileResult.FileName );


                StringContent FileID = new StringContent ( iUserMediaModel.MediaFile_ServerID );
                content.Add ( FileID , "\"FileID\"" );



                StringContent FileDuration = new StringContent ( iUserMediaModel.MediaFile_Duration );
                content.Add ( FileDuration , "\"FileDuration\"" );



                StringContent FileSize = new StringContent ( iUserMediaModel.MediaFile_Size );
                content.Add ( FileSize , "\"FileSize\"" );



                StringContent title = new StringContent ( "title" );
                content.Add ( title , "\"title\"" );

                StringContent description = new StringContent ( "description" );
                content.Add ( description , "\"description\"" );

                StringContent devid = new StringContent ( Preferences.Get ( "DeviceGlobalID" , "0" ) );
                content.Add ( devid , "\"devid\"" );


                StringContent syscod = new StringContent ( Preferences.Get ( "PlatformOS" , "0" ) );
                content.Add ( syscod , "\"syscod\"" );

                StringContent acctyp = new StringContent ( App.iAccountType );
                content.Add ( acctyp , "\"acctyp\"" );

                StringContent uid = new StringContent ( iOwnerModel.OwnerUserTokenID );
                content.Add ( uid , "\"uid\"" );


                StringContent mobid = new StringContent ( iOwnerModel.OwnerMobileNumberTokenID );
                content.Add ( mobid , "\"mobid\"" );



                //var httpClient =  new HttpClient ( );

                HttpClientHandler insecureHandler = GetInsecureHandler();
                HttpClient httpClient = new HttpClient(insecureHandler);

//#if DEBUG
//                HttpClientHandler insecureHandler = GetInsecureHandler ( );
//                HttpClient httpClient = new HttpClient ( insecureHandler );
//#else
//                HttpClient httpClient = new HttpClient();
//#endif

                //////            ServicePointManager.ServerCertificateValidationCallback = new
                //////RemoteCertificateValidationCallback
                //////(
                //////   delegate { return true; }
                //////);

                var response = await httpClient.PostAsync ( App.SiteChatShareImageDataURLUpload , content );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }





    


        public static async Task Uploader_MediaFile_ImageWS_X1 (

      Application _context ,

      string iAccountType ,

      SRoofingUserSettingModelManager iSettingModel ,
      SRoofingUserOwnerModelManager iOwnerModel ,

      string EndpointURL ,


 SRoofingUserMediaModel iUserMediaModel )


        {


            try
            {

                var content = new MultipartFormDataContent ( );

                content.Add ( new StreamContent ( await iUserMediaModel.fileResult.OpenReadAsync ( ) ) , "file" , iUserMediaModel.fileResult.FileName );


                StringContent FileID = new StringContent ( iUserMediaModel.MediaFile_ServerID );
                content.Add ( FileID , "\"FileID\"" );



                StringContent FileDuration = new StringContent ( iUserMediaModel.MediaFile_Duration );
                content.Add ( FileDuration , "\"FileDuration\"" );



                StringContent FileSize = new StringContent ( iUserMediaModel.MediaFile_Size );
                content.Add ( FileSize , "\"FileSize\"" );



                StringContent title = new StringContent ( "title" );
                content.Add ( title , "\"title\"" );

                StringContent description = new StringContent ( "description" );
                content.Add ( description , "\"description\"" );

                StringContent devid = new StringContent ( Preferences.Get ( "DeviceGlobalID" , "0" ) );
                content.Add ( devid , "\"devid\"" );


                StringContent syscod = new StringContent ( Preferences.Get ( "PlatformOS" , "0" ) );
                content.Add ( syscod , "\"syscod\"" );

                StringContent acctyp = new StringContent ( App.iAccountType );
                content.Add ( acctyp , "\"acctyp\"" );

                StringContent uid = new StringContent ( iOwnerModel.OwnerUserTokenID );
                content.Add ( uid , "\"uid\"" );


                StringContent mobid = new StringContent ( iOwnerModel.OwnerMobileNumberTokenID );
                content.Add ( mobid , "\"mobid\"" );



                //var httpClient =  new HttpClient ( );

                HttpClientHandler insecureHandler = GetInsecureHandler();
                HttpClient httpClient = new HttpClient(insecureHandler);

                //#if DEBUG
                //                HttpClientHandler insecureHandler = GetInsecureHandler ( );
                //                HttpClient httpClient = new HttpClient ( insecureHandler );
                //#else
                //                HttpClient httpClient = new HttpClient();
                //#endif



                //////            ServicePointManager.ServerCertificateValidationCallback = new
                //////RemoteCertificateValidationCallback
                //////(
                //////   delegate { return true; }
                //////);

                var response = await httpClient.PostAsync ( App.SiteChatShareImageDataURLUpload , content );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }










        public static async Task Uploader_MediaFile_VideoWS (

      Application _context ,

      string iAccountType ,

      SRoofingUserSettingModelManager iSettingModel ,
      SRoofingUserOwnerModelManager iOwnerModel ,

      string EndpointURL ,


 SRoofingUserMediaModel iUserMediaModel )


        {


            try
            {

                var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_VideoModel> ( );

                #region Video-Data

                var content_VideoData = new MultipartFormDataContent ( );

                //////using ( var stream = new System.IO.FileStream ( iUserMediaModel.MediaFile_LocalPathURL , FileMode.Open , FileAccess.Read ) )
                //////{
                //////    content_VideoData.Add ( new StreamContent ( stream ) , "file" , "xxx.mp4" );

                //////}



                var iStream = new System.IO.FileStream ( iUserMediaModel.MediaFile_LocalPathURL , FileMode.Open , FileAccess.Read );
                content_VideoData.Add ( new StreamContent ( iStream ) , "file" , "vid_" + iUserMediaModel.MediaFile_ServerID + ".mp4" );




                //content_VideoData.Add ( new StreamContent ( await iUserMediaModel.fileResult.OpenReadAsync ( ) ) , "file" , iUserMediaModel.fileResult.FileName );


                StringContent FileID = new StringContent ( iUserMediaModel.MediaFile_ServerID );
                content_VideoData.Add ( FileID , "\"FileID\"" );


                //if ( objService != null )
                //{

                //    StringContent FileDuration = new StringContent ( objService.VideoDuration ( iUserMediaModel.fileResult.FullPath ) );
                //    content_VideoData.Add ( FileDuration , "\"FileDuration\"" );

                //}
                //else
                //{
                //    StringContent FileDuration = new StringContent ( "0" );
                //    content_VideoData.Add ( FileDuration , "\"FileDuration\"" );

                //}


                StringContent FileDuration = new StringContent ( iUserMediaModel.MediaFile_Duration );
                content_VideoData.Add ( FileDuration , "\"FileDuration\"" );


                StringContent FileSize = new StringContent ( iUserMediaModel.MediaFile_Size );
                content_VideoData.Add ( FileSize , "\"FileSize\"" );




                StringContent title = new StringContent ( "title" );
                content_VideoData.Add ( title , "\"title\"" );

                StringContent description = new StringContent ( "description" );
                content_VideoData.Add ( description , "\"description\"" );

                StringContent devid = new StringContent ( Preferences.Get ( "DeviceGlobalID" , "0" ) );
                content_VideoData.Add ( devid , "\"devid\"" );


                StringContent syscod = new StringContent ( Preferences.Get ( "PlatformOS" , "0" ) );
                content_VideoData.Add ( syscod , "\"syscod\"" );

                StringContent acctyp = new StringContent ( App.iAccountType );
                content_VideoData.Add ( acctyp , "\"acctyp\"" );

                StringContent uid = new StringContent ( iOwnerModel.OwnerUserTokenID );
                content_VideoData.Add ( uid , "\"uid\"" );


                StringContent mobid = new StringContent ( iOwnerModel.OwnerMobileNumberTokenID );
                content_VideoData.Add ( mobid , "\"mobid\"" );



                #endregion


                #region Video-Thum

                //ImageSource imageSource = null;
                //string ThumPath = Path.Combine ( FileSystem.Current.CacheDirectory , "thm_" + iUserMediaModel.MediaFile_ServerID + ".jpg" );

                //if ( objService != null )
                //{
                //    imageSource = objService.GenerateThumbImage ( iUserMediaModel.fileResult.FullPath );

                //    await SRoofing_ImageManager.SaveImageAsync ( imageSource , ThumPath );

                //}

                var content_VideoThum = new MultipartFormDataContent ( );


                if ( iUserMediaModel.MediaFile_Stream is StreamImageSource streamImageSource )

                {                                                           /**/
                    var stream = await streamImageSource.Stream ( CancellationToken.None );
                    content_VideoThum.Add ( new StreamContent ( stream ) , "file" , "thm_" + iUserMediaModel.MediaFile_ServerID + ".jpg" );

                    StringContent FileIDThum = new StringContent ( iUserMediaModel.MediaFile_ServerID );
                    content_VideoThum.Add ( FileIDThum , "\"FileID\"" );

                    StringContent titleThum = new StringContent ( "title" );
                    content_VideoThum.Add ( titleThum , "\"title\"" );

                    StringContent descriptionThum = new StringContent ( "description" );
                    content_VideoThum.Add ( descriptionThum , "\"description\"" );

                    //StringContent devid = new StringContent ( Preferences.Get ( "DeviceGlobalID" , "0" ) );
                    //content_VideoThum.Add ( devid , "\"devid\"" );


                    //StringContent syscod = new StringContent ( Preferences.Get ( "PlatformOS" , "0" ) );
                    //content_VideoThum.Add ( syscod , "\"syscod\"" );

                    //StringContent acctyp = new StringContent ( App.iAccountType );
                    //content_VideoThum.Add ( acctyp , "\"acctyp\"" );

                    //StringContent uid = new StringContent ( iOwnerModel.OwnerUserTokenID );
                    //content_VideoThum.Add ( uid , "\"uid\"" );


                    //StringContent mobid = new StringContent ( iOwnerModel.OwnerMobileNumberTokenID );
                    //content_VideoThum.Add ( mobid , "\"mobid\"" );




                    #endregion








                    //////var httpClient = new HttpClient ( );

                    HttpClientHandler insecureHandler = GetInsecureHandler();
                    HttpClient httpClient = new HttpClient(insecureHandler);

                    //#if DEBUG
                    //                HttpClientHandler insecureHandler = GetInsecureHandler ( );
                    //                HttpClient httpClient = new HttpClient ( insecureHandler );
                    //#else
                    //                HttpClient httpClient = new HttpClient();
                    //#endif





                    var response_Data = await httpClient.PostAsync ( App.URL_TlknUploader_VideoDataURL , content_VideoData );
                    await response_Data.Content.ReadAsStringAsync ( );

                    HttpClientHandler insecureHandler_Thum = GetInsecureHandler();
                    HttpClient httpClient_Thum = new HttpClient(insecureHandler_Thum);

                    //#if DEBUG
                    //                HttpClientHandler insecureHandler = GetInsecureHandler ( );
                    //                HttpClient httpClient = new HttpClient ( insecureHandler );
                    //#else
                    //                HttpClient httpClient = new HttpClient();
                    //#endif




                    var response_Thum = await httpClient_Thum.PostAsync ( App.URL_TlknUploader_VideoThumDataURL , content_VideoThum );
                    await response_Thum.Content.ReadAsStringAsync ( );
                }
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }

   
 
        public static async Task Uploader_MediaFile_DocumentWS (

      Application _context ,

      string iAccountType ,

      SRoofingUserSettingModelManager iSettingModel ,
      SRoofingUserOwnerModelManager iOwnerModel ,

      string EndpointURL ,


 SRoofingUserMediaModel iUserMediaModel )


        {


            try
            {


                //var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_VideoModel> ( );


                var content = new MultipartFormDataContent ( );

                content.Add ( new StreamContent ( await iUserMediaModel.fileResult.OpenReadAsync ( ) ) , "file" , iUserMediaModel.fileResult.FileName );


                StringContent FileID = new StringContent ( iUserMediaModel.MediaFile_ServerID );
                content.Add ( FileID , "\"FileID\"" );




                //if ( objService != null )
                //{

                //    StringContent FileDuration = new StringContent ( objService.VideoDuration ( iUserMediaModel.fileResult.FullPath ) );
                //    content.Add ( FileDuration , "\"FileDuration\"" );

                //}
                //else
                //{
                //    StringContent FileDuration = new StringContent ( "0" );
                //    content.Add ( FileDuration , "\"FileDuration\"" );

                //}


                StringContent FileDuration = new StringContent ( iUserMediaModel.MediaFile_Duration );
                content.Add ( FileDuration , "\"FileDuration\"" );


                StringContent FileSize = new StringContent ( iUserMediaModel.MediaFile_Size );
                content.Add ( FileSize , "\"FileSize\"" );



                StringContent FileExtension = new StringContent ( iUserMediaModel.MediaFile_Extension );
                content.Add ( FileExtension , "\"ext\"" );

                StringContent title = new StringContent ( "title" );
                content.Add ( title , "\"title\"" );

                StringContent description = new StringContent ( "description" );
                content.Add ( description , "\"description\"" );

                StringContent devid = new StringContent ( Preferences.Get ( "DeviceGlobalID" , "0" ) );
                content.Add ( devid , "\"devid\"" );


                StringContent syscod = new StringContent ( Preferences.Get ( "PlatformOS" , "0" ) );
                content.Add ( syscod , "\"syscod\"" );

                StringContent acctyp = new StringContent ( App.iAccountType );
                content.Add ( acctyp , "\"acctyp\"" );

                StringContent uid = new StringContent ( iOwnerModel.OwnerUserTokenID );
                content.Add ( uid , "\"uid\"" );


                StringContent mobid = new StringContent ( iOwnerModel.OwnerMobileNumberTokenID );
                content.Add ( mobid , "\"mobid\"" );



                //var httpClient =  new HttpClient ( );

                HttpClientHandler insecureHandler = GetInsecureHandler();
                HttpClient httpClient = new HttpClient(insecureHandler);

                //#if DEBUG
                //                HttpClientHandler insecureHandler = GetInsecureHandler ( );
                //                HttpClient httpClient = new HttpClient ( insecureHandler );
                //#else
                //                HttpClient httpClient = new HttpClient();
                //#endif



                //////            ServicePointManager.ServerCertificateValidationCallback = new
                //////RemoteCertificateValidationCallback
                //////(
                //////   delegate { return true; }
                //////);


                _ = Task.Run ( async ( ) =>
                {
                      var response = await httpClient.PostAsync ( App.SiteChatShareDocumentDataURLUpload , content );


                } ).ConfigureAwait ( false );
            

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }



        public static async Task Uploader_MediaFile_AudioWS (

      Application _context ,

      string iAccountType ,

      SRoofingUserSettingModelManager iSettingModel ,
      SRoofingUserOwnerModelManager iOwnerModel ,

      string EndpointURL ,


 SRoofingUserMediaModel iUserMediaModel )


        {


            try
            {

                //var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_VideoModel> ( );

                var content = new MultipartFormDataContent ( );

                content.Add ( new StreamContent ( await iUserMediaModel.fileResult.OpenReadAsync ( ) ) , "file" , iUserMediaModel.fileResult.FileName );


                StringContent FileID = new StringContent ( iUserMediaModel.MediaFile_ServerID );
                content.Add ( FileID , "\"FileID\"" );


                //if ( objService != null )
                //{

                //    StringContent FileDuration = new StringContent ( objService.VideoDuration ( iUserMediaModel.fileResult.FullPath ) );
                //    content.Add ( FileDuration , "\"FileDuration\"" );

                //}
                //else
                //{
                //    StringContent FileDuration = new StringContent ( "0" );
                //    content.Add ( FileDuration , "\"FileDuration\"" );

                //}

                StringContent FileDuration = new StringContent ( iUserMediaModel.MediaFile_Duration );
                content.Add ( FileDuration , "\"FileDuration\"" );



                StringContent FileSize = new StringContent ( iUserMediaModel.MediaFile_Size );
                content.Add ( FileSize , "\"FileSize\"" );



                StringContent title = new StringContent ( "title" );
                content.Add ( title , "\"title\"" );

                StringContent description = new StringContent ( "description" );
                content.Add ( description , "\"description\"" );

                StringContent devid = new StringContent ( Preferences.Get ( "DeviceGlobalID" , "0" ) );
                content.Add ( devid , "\"devid\"" );


                StringContent syscod = new StringContent ( Preferences.Get ( "PlatformOS" , "0" ) );
                content.Add ( syscod , "\"syscod\"" );

                StringContent acctyp = new StringContent ( App.iAccountType );
                content.Add ( acctyp , "\"acctyp\"" );

                StringContent uid = new StringContent ( iOwnerModel.OwnerUserTokenID );
                content.Add ( uid , "\"uid\"" );


                StringContent mobid = new StringContent ( iOwnerModel.OwnerMobileNumberTokenID );
                content.Add ( mobid , "\"mobid\"" );



                //var httpClient =  new HttpClient ( );

                HttpClientHandler insecureHandler = GetInsecureHandler();
                HttpClient httpClient = new HttpClient(insecureHandler);

                //#if DEBUG
                //                HttpClientHandler insecureHandler = GetInsecureHandler ( );
                //                HttpClient httpClient = new HttpClient ( insecureHandler );
                //#else
                //                HttpClient httpClient = new HttpClient();
                //#endif



                //////            ServicePointManager.ServerCertificateValidationCallback = new
                //////RemoteCertificateValidationCallback
                //////(
                //////   delegate { return true; }
                //////);

                var response = await httpClient.PostAsync ( App.URL_TlknUploader_AudioDataURL , content );



            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }











        // This method must be in a class in a platform project, even if
        // the HttpClient object is constructed in a shared project.
        public static HttpClientHandler GetInsecureHandler ( )
        {
            HttpClientHandler handler = new HttpClientHandler ( );
            handler.ServerCertificateCustomValidationCallback = ( message , cert , chain , errors ) =>
            {
                //if ( cert.Issuer.Equals ( "CN=localhost" ) )
                return true;
                //return errors == System.Net.Security.SslPolicyErrors.None;
            };
            return handler;
        }


    }
}
