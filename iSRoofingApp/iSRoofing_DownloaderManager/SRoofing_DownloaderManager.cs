using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumHandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_HandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_HTTPManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;

 
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_DownloaderManager
{
    public class SRoofing_DownloaderManager
    {




        //  async public static Task<byte[]> Downloader_File_ByFileTokenID(

        async public static Task<bool> Downloader_File_ByFileTokenID (

    Application _context ,
    string iAccountType ,
    SRoofingUserOwnerModelManager iOwnerModel ,
     string FileTokenID ,
    string FileCode ,
    string FileType ,
          SRoofingScreenChatShowMessageModelManager iMessageModel = null )
        {

            try
            {

                HttpClient _client = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance ( );

                string _iFileUrl = string.Empty;
                string _iFileName = string.Empty;
                string _iFileTitle = string.Empty;
                string _iFileExtension = string.Empty;
                string _iDpwnloadPath = string.Empty;
                string _iFileNewPath = string.Empty;

                _iDpwnloadPath = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SaveMediaDataFile> ( )
                  .Get_DownloadPath ( );


                if ( iMessageModel != null )
                {

                    if ( FileCode == SRoofingEnum_File_Code.FileCode_Image )
                    {
                        _iFileName = "img_" + iMessageModel.ImageDefaultServerID + ".jpg";

                        _iFileUrl = SRoofing_URLManager.URL_Image.Image_Get_ImageByImageID ( Application.Current , iMessageModel.ImageDefaultServerID );
                    }
                    else if ( FileCode == SRoofingEnum_File_Code.FileCode_Video )
                    {
                        _iFileName = "vid_" + iMessageModel.VideoDefaultServerID + ".mp4";

                        _iFileUrl = SRoofing_URLManager.URL_Video.Video_Get_VideoDataByVideoID ( Application.Current , iMessageModel.VideoDefaultServerID );

                    }
                    else if ( FileCode == SRoofingEnum_File_Code.FileCode_Document )
                    {
                        _iFileName = "doc_" + iMessageModel.ImageDefaultServerID + "." + iMessageModel.MediaFile_Extension;

                        _iFileUrl = SRoofing_URLManager.URL_Document.Document_Get_DocumentDataByDocumentID ( Application.Current , iMessageModel.ImageDefaultServerID , "0" , iMessageModel.MediaFile_Extension );

                    }

                    _iFileNewPath = _iDpwnloadPath + "/" + _iFileName;

                }
                else
                {

                    //if ( FileCode == SRoofingEnum_File_Code.FileCode_Image )
                    //{
                    //    _iFileName = "img_" + FileTokenID + ".jpg";

                    //    _iFileUrl = SRoofing_URLManager.URL_Image.Image_Get_ImageByImageID ( Application.Current , FileTokenID );
                    //}
                    //else if ( FileCode == SRoofingEnum_File_Code.FileCode_Video )
                    //{
                    //    _iFileName = "vid_" + FileTokenID + ".mp4";

                    //    _iFileUrl = SRoofing_URLManager.URL_Video.Video_Get_VideoDataByVideoID ( Application.Current , FileTokenID );

                    //}
                    //else if ( FileCode == SRoofingEnum_File_Code.FileCode_Document )
                    //{
                    //    _iFileName = "doc_" + FileTokenID + "." + iMessageModel.MediaFile_Extension;

                    //    _iFileUrl = SRoofing_URLManager.URL_Document.Document_Get_DocumentDataByDocumentID ( Application.Current , FileTokenID , "0" , iMessageModel.MediaFile_Extension );

                    //}
                }



                if ( !_iFileUrl.Trim ( ).StartsWith ( "https" , StringComparison.OrdinalIgnoreCase ) )
                    throw new Exception ( "iOS and Android Require Https" );

                //  return await await Task.FromResult ( _client.GetByteArrayAsync ( _iFileUrl ) );
                //   return await await Task.FromResult ( _client.GetByteArrayAsync ( "https://thumbs.dreamstime.com/b/white-shark-blue-water-swimming-guadalupe-34864624.jpg?w=768" ) );



                // return await await Task.FromResult(_client.GetByteArrayAsync("https://oneworldlancer.ddns.net/S1Roofing/_iUMedia/_iUImage/img_1688326759304.jpg"));
                //return await await Task.FromResult(_client.GetByteArrayAsync( "https://oneworldlancer.ddns.net/S1Roofing/_iUMedia/_iUVideo/vid_1690662983634.mp4" ) );
                //return strResult;

                var downloadedImage = await await Task.FromResult ( _client.GetByteArrayAsync ( _iFileUrl ) );

            
                if ( downloadedImage != null )
                {
                    App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SaveMediaDataFile> ( )
                .SaveImageFromByte ( downloadedImage , _iFileName );

                    if ( iMessageModel != null )
                    {
                        await App.Database.ScreenChatShow_Update_MediaPath_MessageModel (
        iMessageModel.MessageTokenID , iMessageModel.FileCode , _iFileNewPath );

                    }
                }


                return true;

            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return false;
            }
        }



        public async static void SaveToDisk ( string imageFileName , byte[] imageAsBase64String )
        {

            try
            {
                Preferences.Set (  imageFileName ,
                    Convert.ToBase64String ( imageAsBase64String ) );



                //byte[] image = e.ImageData;
                // _FileID = SRoofing_TimeManager.Time_GenerateToken ( );


                //////var filename = System.IO.Path.Combine ( Environment.GetExternalStoragePublicDirectory ( Environment.DirectoryPictures ).ToString ( ) , "NewFolder" );
                //////Directory.CreateDirectory ( filename );
                //////filename = System.IO.Path.Combine ( filename , "filename.jpg" );
                //////using ( var fileOutputStream = new FileOutputStream ( filename ) )
                //////{
                //////    await fileOutputStream.WriteAsync ( reducedImage );
                //////}






                ////////App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SaveMediaDataFile> ( )
                ////////    .SaveFile ( Path.Combine ( FileSystem.AppDataDirectory , "shark789.jpg" ) , imageAsBase64String );

                ////App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SaveMediaDataFile> ( )
                //    .SaveFile ( Path.Combine ( FileSystem.Current.CacheDirectory , "img_" + _FileID + ".jpg" ) , image );



            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }


        public static ImageSource GetFromDisk ( string imageFileName )
        {
            try
            {

                var imageAsBase64String = Preferences.Get ( imageFileName , string.Empty );

                return ImageSource.FromStream ( ( ) => new MemoryStream ( Convert.FromBase64String ( imageAsBase64String ) ) );


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }





    }
}
