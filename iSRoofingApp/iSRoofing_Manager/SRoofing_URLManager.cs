using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_URLManager
    {

        public static
  class URL_Emotion
        {


            public static
            void Emotion_Load_SystemEmotion (

                    Application context ,
                    Image imgView ,
                    String EmotionName )
            {

                try
                {

                    //Glide.with ( context )
                    //     .load ( Uri.parse ( "file:///android_asset/TlknEmotion/" + EmotionName ) )
                    //     .into ( imgView );

                }
                catch ( Exception ex )
                {
                    return;
                }

            }


        }


        public static
        class URL_Sticker
        {


            public static

            void Sticker_Load_SystemSticker (

                    Application context ,
                    Image imgView ,
                    String StickerName )
            {

                try
                {

                    //Glide.with ( context )
                    //     .load ( Uri.parse ( "file:///android_asset/TlknSticker/" + StickerName ) )
                    //     .into ( imgView );

                }
                catch ( Exception ex )
                {
                    return;
                }

            }


            public static
            String Sticker_Get_ServerStickerURL (

                    Application _context ,
                    String StickerName )
            {

                try
                {

                    return App.SiteDomainURL + "_itlknsticker/" + StickerName;

                    /*
                                    Glide.with (context)
                                            .load (Uri.parse ("file:///android_asset/TlknSticker/" + StickerName))
                                            .into (imgView);
                    */

                }
                catch ( Exception ex )
                {
                    return null;
                }

            }


        }


        public static
        class URL_Shop_Wallpaper
        {


            public static
            String ShopWallpaper_Get_Wallpaper_ImageURL (

                    Application context ,
                    String WallpaperImageID ,
                    bool IsSystem )
            {

                try
                {

                    String strURL = null;

                    if ( IsSystem == true )
                    {

                        strURL = "_iTlknShop/_iTlknWallpaper/" + WallpaperImageID + ".jpg";
                    }
                    else if ( IsSystem == false )
                    {

                        strURL =
                                App.SiteDomainURL + "_iUShop/_iUWallpaper/img_" + WallpaperImageID + ".jpg";
                    }
                    return strURL;

                }
                catch ( Exception ex )
                {
                    return null;
                }

            }


        }


        public static
        class URL_Avatar
        {


            public static
            String Avatar_Get_AvatarURLByImageID (

                    Application _context ,
                    String ImageID )
            {

                try
                {

                    return App.SiteDomainURL + "_iUAvatar/avt_" + ImageID + ".jpg";
                    //return ImageID;


                    //return "http://sourcey.com/images/stock/salvador-dali-the-great-masturbator.jpg";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".jpg";

                    /*                images.add("http://sourcey
                    .com/images/stock/salvador-dali-metamorphosis-of-narcissus.jpg");
                                    images.add("http://sourcey.com/images/stock/salvador-dali-the-dream.jpg");
                                    images.add("http://sourcey.com/images/stock/salvador-dali-persistence-of-memory
                                    .jpg");
                                    images.add("http://sourcey.com/images/stock/simpsons-persistence-of-memory.jpg");
                                    images.add("http://sourcey.com/images/stock/salvador-dali-the-great-masturbator
                                    .jpg");*/

                    /*
                                    Glide.with (context)
                                            .load (Uri.parse ("file:///android_asset/TlknEmotion/" + EmotionName))
                                            .into (imgView);
                    */


                }
                catch ( Exception ex )
                {
                    return null;
                }

            }


            public static
            String Avatar_Get_AvatarByImageID (

                    Application context ,
                    String ImageID )
            {

                try
                {

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";
                    return ImageID;


                    //return "http://sourcey.com/images/stock/salvador-dali-the-great-masturbator.jpg";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".jpg";

                    /*                images.add("http://sourcey
                    .com/images/stock/salvador-dali-metamorphosis-of-narcissus.jpg");
                                    images.add("http://sourcey.com/images/stock/salvador-dali-the-dream.jpg");
                                    images.add("http://sourcey.com/images/stock/salvador-dali-persistence-of-memory
                                    .jpg");
                                    images.add("http://sourcey.com/images/stock/simpsons-persistence-of-memory.jpg");
                                    images.add("http://sourcey.com/images/stock/salvador-dali-the-great-masturbator
                                    .jpg");*/

                    /*
                                    Glide.with (context)
                                            .load (Uri.parse ("file:///android_asset/TlknEmotion/" + EmotionName))
                                            .into (imgView);
                    */


                }
                catch ( Exception ex )
                {
                    return null;
                }

            }

            public static
            String Avatar_Get_AvatarByImageID (

                    String ImageID )
            {

                try
                {

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    // return   App.SiteDomainURL + "_iUAvatar/img_" + ImageID + ".jpg";
                    return ImageID;



                    /*
                                    Glide.with (context)
                                            .load (Uri.parse ("file:///android_asset/TlknEmotion/" + EmotionName))
                                            .into (imgView);
                    */


                }
                catch ( Exception ex )
                {
                    return null;
                }

            }

            public static
            String UserAvatar_ImageURL_ByAccountType (

                    Application _context ,
                    String iAccountType ,
                    String UserID ,
                    String MobileNumberID )
            {

                try
                {

                    //return TlknUserImageManager.UserImage_Get_UserAvatar_ImageURL_ByAccountType (
                    //        _context ,
                    //        iAccountType ,
                    //        UserID ,
                    //        MobileNumberID );

                    return "0";

                }
                catch ( Exception ex )
                {
                    return null;
                }

            }


        }


        public static
        class URL_Gallery
        {


            public static
            String Gallery_Get_GalleryByImageID (

                    Application _context ,
                    String ImageID )
            {

                try
                {

                    return App.SiteDomainURL + "_iUGallery/img_" + ImageID + ".jpg";

                }
                catch ( Exception ex )
                {
                    return null;
                }

            }


        }


        public static
        class URL_Background
        {


            public static
            String Background_Get_BackgroundByImageID (

                    Application _context ,
                    String ImageID )
            {

                try
                {

                    return App.SiteDomainURL + "_iUBackground/img_" + ImageID + ".jpg";

                }
                catch ( Exception ex )
                {
                    return null;
                }

            }


        }


        public static
        class URL_Image
        {


            public static
            string Image_Get_ImageByImageID (

                    Application _context ,
                    String ImageID )
            {

                try
                {

                    return App.SiteDomainURL + "_iUMedia/_iUImage/img_" + ImageID + ".jpg";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                }
                catch ( Exception ex )
                {
                    return null;
                }

            }

            public static   String Image_Get_CameraIcon =
                App.SiteDomainURL + "_iTlknImage/img_theme_splash_camera_trans.png";

    }


        public static
        class URL_Icon
        {


            public static   String Icon_Get_CameraIcon =
                App.SiteDomainURL + "_iTlknImage/img_theme_splash_camera_trans.png";

    }


        public static
        class URL_Audio
        {

            public static
            String Audio_Get_AudioDataByAudioID (

                    Application _context ,
                    String AudioID )
            {

                try
                {

                    return App.SiteDomainURL + "_iUMedia/_iUAudio/aud_" + AudioID + ".mp3";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                }
                catch ( Exception ex )
                {
                    return null;
                }

            }


            public static
            String Audio_Download_AudioDataByAudioID (

                    Application _context ,
                    String FileID ,
                    String FileExtension )
            {

                try
                {

                    return App.SiteDomainURL + "_iTlknDownloader/Audio/Data/default.aspx?audid=" + FileID + "&ext=" + FileExtension;//  App.SiteDomainURL + "_iUMedia/_iUAudio/aud_" + AudioID + ".mp3";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                }
                catch ( Exception ex )
                {
                    return null;
                }

            }




            /*
                    public static String Video_Get_VideoThumByVideoID(

                            Application _context,
                            String VideoID) {

                        try {

                            return   App.SiteDomainURL + "_iUMedia/_iUVideo/thm_" + VideoID + ".jpg";

                            //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                            //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                        } catch (Exception ex) {
                            return null;
                        }

                    }
            */


        }


        public static
        class URL_Document
        {

            public static
            String Document_Get_DocumentDataByDocumentID (

                    Application _context ,
                    String DocumentID ,
                    String DocumentName ,
                    String DocumentExtension )
            {

                try
                {

                    return App.SiteDomainURL + "_iUMedia/_iUDocument/doc_" + DocumentID + "." + DocumentExtension;

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                }
                catch ( Exception ex )
                {
                    return null;
                }

            }


            public static
            String Document_Get_Embed_Viewer_ByDocumentID (

                    Application _context ,
                    String FileID ,
                    String DocumentName ,
                    String FileExtension )
            {

                try
                {

                    //return   App.SiteDomainURL + "_iUMedia/_iUDocument/file_" + DocumentID + "
                    // ." + DocumentExtension;

                    /*
                                    return "http://docs.google.com/gview?url=http://tlknmobile.tlkn2
                                    .com/_iUMedia/_iUDocument/doc_" + FileID + "." + FileExtension + "&embedded=true";
                    */
                    return "http://docs.google.com/gview?url=" + App.SiteDomainURL + "_iUMedia"
                           + "/_iUDocument/doc_" + FileID + "." + FileExtension + "&embedded=true";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                }
                catch ( Exception ex )
                {
                    return null;
                }

            }


        }


        public static
        class URL_Video
        {

            public static
            String Video_Get_VideoDataByVideoID (

                    Application _context ,
                    String VideoID )
            {

                try
                {


                    return App.SiteDomainURL + "_iUMedia/_iUVideo/vid_" + VideoID +
                           ".mp4";

                    ////return "http://tlknstreamvideo.tlkn2.com/Video/Index.html?vidid=" +
                    ////       VideoID + "&cod=2&url=3";


                    /*
                                    return   App.SiteDomainURL + "_iUMedia/_iUVideo/vid_" + VideoID + ".mp4";
                    */

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                }
                catch ( Exception ex )
                {
                    return null;
                }

            }

            public static
            String Video_Get_VideoThumByVideoID (

                    Application _context ,
                    String VideoID )
            {

                try
                {

                    return App.SiteDomainURL + "_iUMedia/_iUVideo/thm_" + VideoID + ".jpg";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                }
                catch ( Exception ex )
                {
                    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    return null;
                }

            }


        }


   
        public static
        class URL_YouTube
        {

            public static
            String YouTube_Get_YouTubeDataByYouTubeID (

                    Application _context ,
                    String YouTubeID ,
                    String PlaylistID )
            {

                try
                {


                    return "https://www.youtube.com/embed/" + YouTubeID + "?showinfo=0&fs=0&rel=0"
                    + "&theme=light&playsinline=1&modestbranding=1";

                    ////return "http://tlknstreamYouTube.tlkn2.com/YouTube/Index.html?vidid=" +
                    ////       YouTubeID + "&cod=2&url=3";


                    /*
                                    return   App.SiteDomainURL + "_iUMedia/_iUYouTube/vid_" + YouTubeID + ".mp4";
                    */

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                }
                catch ( Exception ex )
                {
                    return null;
                }

            }

            public static
            String YouTube_Get_YouTubeThumByYouTubeID (

                    Application _context ,
                    String YouTubeID )
            {

                try
                {

                    return "http://img.youtube.com/vi/" + YouTubeID + "/0.jpg";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                }
                catch ( Exception ex )
                {
                    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    return null;
                }

            }


     
            public static
            String YouTube_Get_YouTubePlaylistByOwnerUserTokenID (

                    Application _context ,
                    String YouTubeID )
            {

                try
                {

                    return "http://img.youtube.com/vi/" + YouTubeID + "/0.jpg";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                }
                catch ( Exception ex )
                {
                    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    return null;
                }

            }


        }


        public static
        class URL_Broadcast_GroupShow_Video
        {

            public static
            String Broadcast_GroupShow_Video_Owner_Stop_LIVE_VideoDataByVideoID (

                    Application _context ,
                    String GroupShowTicketID )
            {

                try
                {

                    //return   App.SiteDomainURL + "_iUBroadcast/_iUGroupShow/vid_" + VideoID + "
                    // .mp4";
                    /*
                                    return  "rtmp://" + App.SiteDomainURL + ":1935/live_tlkn2_dating_broadcast_groupshow/" + "vid_" +
                                    VideoID ;
                    */


                    //return  "rtsp://" + App.SiteDomainURL + ":1935/live_tlkn2_dating_broadcast_groupshow/" + "vid_" +
                    // VideoID;

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";

                    /*
                                    return "http://" + App.SiteDomainURL + ":8087/v2/servers/_defaultServer_/vhosts" +
                                           "/_defaultVHost_/applications/live_tlkn2_dating_broadcast_groupshow"
                                           + "/instances" +
                                           "/_definst_/streamrecorders/vid_" + GroupShowTicketID + "/actions"
                                           + "/stopRecording";
                    */


                    return "http://41.205.116.6:8087/v2/servers/_defaultServer_/vhosts" +
                           "/_defaultVHost_/applications/live_tlkn2_dating_broadcast_groupshow"
                           + "/instances" +
                           "/_definst_/streamrecorders/vid_" + GroupShowTicketID + "/actions"
                           + "/stopRecording";

                }
                catch ( Exception ex )
                {
                    return null;
                }

            }


            public static
            String Broadcast_GroupShow_Video_Owner_Set_LIVE_VideoDataByVideoID (

                    Application _context ,
                    String VideoID )
            {

                try
                {

                    //return   App.SiteDomainURL + "_iUBroadcast/_iUGroupShow/vid_" + VideoID + "
                    // .mp4";
                    //return  "rtsp://" + App.SiteDomainURL + ":1935/live_tlkn2_dating_broadcast_groupshow/" + "vid_" +
                    // VideoID;

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";

                    /*
                                    return "rtmp://" + App.SiteDomainURL + ":1935/live_tlkn2_dating_broadcast_groupshow/" + "vid_" + VideoID;
                    */

                    return "rtmp://41.205.116.6:1935/live_tlkn2_dating_broadcast_groupshow/" + "vid_" + VideoID;

                }
                catch ( Exception ex )
                {
                    return null;
                }

            }

            public static
            String Broadcast_GroupShow_Video_Remote_Get_LIVE_VideoDataByVideoID (

                    Application _context ,
                    String VideoID )
            {

                try
                {

                    //return   App.SiteDomainURL + "_iUBroadcast/_iUGroupShow/vid_" + VideoID + "
                    // .mp4";

                    /*
                                   return  "rtmp://oneworldlancer.ddns.net:1935/live/helloworld";
                   */

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";

                    /*
                                    return "rtsp://" + App.SiteDomainURL + ":1935/live_tlkn2_dating_broadcast_groupshow/" + "vid_" + VideoID;
                    */

                    return "rtsp://41.205.116.6:1935/live_tlkn2_dating_broadcast_groupshow/" + "vid_" + VideoID;

                }
                catch ( Exception ex )
                {
                    return null;
                }

            }

            public static
            String Broadcast_GroupShow_Video_Get_VOD_VideoDataByVideoID (

                    Application _context ,
                    String VideoID )
            {

                try
                {

                    //return   App.SiteDomainURL + "_iUBroadcast/_iUGroupShow/vid_" + VideoID + "
                    // .mp4";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                    /*    return App.SiteDomainURL + "_iUBroadcast/_iUGroupShow/vid_" + VideoID + ".mp4";
                        return App.SiteDomainURL + "_iUBroadcast/_iUGroupShow/vid_" + VideoID + ".mp4";
        */


                    /*
                                    return "rtsp://146.255.35.182:1935/vod_tlkn2_dating_broadcast_groupshow/vid_" + VideoID
                                    + ".mp4";
                    */


                    return "rtsp://41.205.116.6:1935/vod_tlkn2_dating_broadcast_groupshow/vid_" + VideoID
                    + ".mp4";

                }
                catch ( Exception ex )
                {
                    return null;
                }

            }

            public static
            String Broadcast_GroupShow_Video_Get_VideoThumByVideoID (

                    Application _context ,
                    String VideoID )
            {

                try
                {

                    return App.SiteDomainURL + "_iUBroadcast/_iUGroupShow/thm_" + VideoID + ".jpg";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                }
                catch ( Exception ex )
                {
                    return null;
                }

            }


        }


        public static
        class URL_Broadcast_PrivateShow_Video
        {

            public static
            String Broadcast_PrivateShow_Video_Get_VideoDataByVideoID (

                    Application _context ,
                    String VideoID )
            {

                try
                {

                    return App.SiteDomainURL + "_iUBroadcast/_iUPrivateShow/vid_" + VideoID +
                           ".mp4";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                }
                catch ( Exception ex )
                {
                    return null;
                }

            }

            public static
            String Broadcast_PrivateShow_Video_Get_VideoThumByVideoID (

                    Application _context ,
                    String VideoID )
            {

                try
                {

                    return App.SiteDomainURL + "_iUBroadcast/_iUPrivateShow/thm_" + VideoID +
                           ".jpg";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_0.png";

                    //return   App.SiteDomainURL + "_iUAvatar/avt_" +  ImageID +".png";


                }
                catch ( Exception ex )
                {
                    return null;
                }

            }


        }


        public static
        class URL_Map
        {

            public static   String GlobalStaticMapURL =
                App.SiteDomainURL + "_iTlknImage/img_theme_map_bg.png";

        public static
        String Map_Get_GetStaticMapThumURL (

                String LocationLatitude ,
                String LocationLongitude ,
                String LocationTitle )
            {
                try
                {
                    // return "http://img.youtube.com/vi/" + YouTubeVideoID + "/1.jpg";

                    //http://maps.googleapis.com/maps/api/staticmap?center=30.6037843,%2032
                    // .2708311&autoscale=true&zoom=14&scale=false&size=500x500&maptype=roadmap
                    // &format=png&visual_refresh=true&key=AIzaSyDkGcHbSluF1CpDXlUrWOi2xtKd9HLeHV4
                    // &markers=size:mid%7Ccolor:0xff0000%7Clabel:T%7Cismailia


                    // http://maps.googleapis.com/maps/api/staticmap?center=30.6036621,32.270757&autoscale=true&zoom=14&scale=false&size=500x500&maptype=roadmap&format=png&visual_refresh=true&key=AIzaSyB6CeZQeM-FbHBXA5RUKvHj9mHVrz7Fdjw


                    return "http://maps.googleapis.com/maps/api/staticmap?center=" + LocationLatitude + "," + LocationLongitude + "&autoscale=true&zoom=14&scale=false&size=500x500&maptype=roadmap&format=png&visual_refresh=true&key=" + App.iGMapKey;

                    /*            + Uri
                                        .encode (LocationTitle);*/


                    /*
                    return "http://maps.googleapis.com/maps/api/staticmap?center=" + LocationLatitude +
                    "," + LocationLongitude + "&autoscale=true&zoom=14&scale=false&size=500x500&maptype
                    =roadmap&format=png&visual_refresh=true&key=AIzaSyDkGcHbSluF1CpDXlUrWOi2xtKd9HLeHV4
                    &markers=size:mid%7Ccolor:0xff0000%7Clabel:T%7C" + Uri
                            .encode (LocationTitle);
        */


                }
                catch ( Exception ex )
                {
                    return "0";
                }
            }


        }


        public static
        class URL_WebSocket
        {

            public static   String SiteTlknWebSocket_SRoofing_Call_URL =
                "ws://" + App.SiteDomainURL_Socket + ":1515/?";

        public static   String
                    SiteTlknWebSocket_SRoofing_ScreenChatShoww_Message_TypingStatusURL =
                "ws://" + App.SiteDomainURL_Socket + ":7070/?";



        //public static   String SiteTlknWebSocket_MessageTypingStatusURLX = "ws://41.205.113
        // .23/TlknWebSocket/TlknScreenChatShowMessage_TypingStatusWS
        // /TlknScreenChatShowMessage_TypingStatusHandler.ashx?";
        public static   String SiteTlknWebSocket_MessageTypingStatusURLX =
                "ws://" + App.SiteDomainURL_Socket + "/TlknWebSocket"
                + "/TlknScreenChatShowMessage_TypingStatusWS"
                + "/TlknScreenChatShowMessage_TypingStatusHandler.ashx?";


        public static   String SiteTlknWebSocket_CallOnLineURL =
                "ws://" + App.SiteDomainURL_Socket + "/TlknWebSocket"
                + "/TlknScreenCallShowMessage_OnlineStatusWS"
                + "/TlknScreenCallShowMessage_OnlineStatusHandler.ashx?";

        //public static   String SiteTlknWebSocket_PersonalCall_URL = "ws://41.205.113
        // .23/TlknWebSocket/TlknScreenCallShowMessage_PersonalCallWS
        // /TlknScreenCallShowMessage_PersonalCallHandler.ashx?";
        public static   String SiteTlknWebSocket_PersonalCall_URL =
                "ws://" + App.SiteDomainURL_Socket + ":4040/?";


        //public static   String SiteTlknWebSocket_DatingCall_Connect_URL = "ws://41.205.113
        // .23/TlknWebSocket/TlknScreenCallShowMessage_DatingCallWS
        // /TlknScreenCallShowMessage_DatingCallHandler.ashx?";
        public static   String SiteTlknWebSocket_DatingCall_Connect_URL =
                "ws://" + App.SiteDomainURL_Socket + ":5050/?";


        public static   String SiteTlknWebSocket_DatingCall_URL =
                "ws://" + App.SiteDomainURL_Socket + ":5151/?";


        //public static   String SiteTlknWebSocket_GroupShowCall_URL = "ws://41.205.113
        // .23/TlknWebSocket/TlknScreenCallShowMessage_GroupShowCallWS
        // /TlknScreenCallShowMessage_GroupShowCallHandler.ashx?";
        public static   String SiteTlknWebSocket_GroupShowCall_URL =
                "ws://" + App.SiteDomainURL_Socket + ":6060/?";


        //public static   String SiteTlknWebSocket_MessageTypingStatusURL = "ws://41.205.113
        // .23/TlknWebSocket/TlknScreenChatShowMessage_TypingStatusWS
        // /TlknScreenChatShowMessage_TypingStatusHandler.ashx?";

        //public static   String SiteTlknWebSocket_PostWidget_TypingStatusURL = "ws://41.205
        // .113.23/TlknWebSocket/TlknPostWidget_TypingStatusWS/TlknPostWidget_TypingStatusHandler
        // .ashx?";
        public static   String SiteTlknWebSocket_PostWidget_TypingStatusURL =
                "ws://" + App.SiteDomainURL_Socket + ":9090/?";

        public static   String SiteTlknWebSocket_ForumWidget_TypingStatusURL =
                "ws://" + App.SiteDomainURL_Socket + ":9191/?";

        public static   String SiteTlknWebSocket_Tracking_URL =
                "ws://" + App.SiteDomainURL_Socket + ":9595/?";


        //public static   String SiteTlknWebSocket_RootMasterURL = "ws://41.205.113
        // .23/TlknWebSocket/TlknWebSocket_RootMasterWS/TlknWebSocket_RootMasterHandler.ashx?";
        public static   String SiteTlknWebSocket_RootMasterURL =
                "ws://" + App.SiteDomainURL_Socket + ":3030/?";
   
        
        
        
    
        /*     public static   String GlobalStaticMapURL = App.SiteDomainURL_Socket +
        "_iTlknImage/img_theme_map_bg.png";
    
   public static String Map_Get_GetStaticMapThumURL(
            
            String LocationLatitude,
            String LocationLongitude,
            String LocationTitle) {
        try {
            // return "http://img.youtube.com/vi/" + YouTubeVideoID + "/1.jpg";
            
            //http://maps.googleapis.com/maps/api/staticmap?center=30.6037843,%2032
            .2708311&autoscale=true&zoom=14&scale=false&size=500x500&maptype=roadmap&format=png
            &visual_refresh=true&key=AIzaSyDkGcHbSluF1CpDXlUrWOi2xtKd9HLeHV4&markers=size:mid
            %7Ccolor:0xff0000%7Clabel:T%7Cismailia
            
            return "http://maps.googleapis.com/maps/api/staticmap?center=" + LocationLatitude +
            "," + LocationLongitude + "&autoscale=true&zoom=14&scale=false&size=500x500&maptype
            =roadmap&format=png&visual_refresh=true";
            

            
            
            
        } catch (Exception ex) {
            return "";
        }
    }
    */


    }




        public static
        class URL_WOWZAServer
        {


            public static   String WOWZAServer_Logistics_CONNECT_Live_Voice =
                "rtmp://" + App.SiteDomainURL_WOWZAServer + ":1935/live_s1roofing/";
        /*"ws://" + App.SiteDomainURL_Socket + "/safe2pass_live_voice";*/


        public static   String WOWZAServer_Logistics_PLAY_Live_Voice =
                "rtsp://" + App.SiteDomainURL_WOWZAServer + ":1935/live_s1roofing/";
        /*"ws://" + App.SiteDomainURL_Socket + "/safe2pass_live_voice";*/


/*
      public static   String WOWZAServer_Logistics_PLAY_Live_Voice =
              "rtsp://" + App.SiteDomainURL_WOWZAServer + " :1935/safe2pass_live_voice/";
*/
        /*"ws://" + App.SiteDomainURL_Socket + "/safe2pass_live_voice";*/

        public static
        String WOWZAServer_Logistics_DISCONNECT_Live_Voice (
                String StreamID )
            {

                try
                {

                    String _iURL = null;
                    /*   _iURL=  http://localhost:8087/v2/servers/_defaultServer_/vhosts
                    /_defaultVHost_/applications/testlive/instances/_definst_/incomingstreams
                    /creedence.stream/actions/disconnectStream
                     */

                    _iURL =
                            "http://" + App.SiteDomainURL_WOWZAServer + ":8087/v2/servers"
                            + "/_defaultServer_/vhosts"
                            + "/_defaultVHost_/applications/safe2pass_live_voice/instances/_definst_"
                            + "/incomingstreams/" + StreamID + "/actions/disconnectStream";


                    return _iURL;
                }
                catch ( Exception ex )
                {
                    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    return null;
                }

            }

        }





        public static
        class URL_TlknGenericPage
        {


            public static
            String Image_Get_GenericPage_ByPageCode (

                    Application _context ,
                    String PageCode )
            {

                try
                {

                    String _strResult = null;

                    //if ( PageCode.equalsIgnoreCase ( TlknEnum_TlknGenericPage.TlknGenericPage_Terms ) )
                    //{
                    //    _strResult = App.SiteDomainURL + "_iTlknPages/Generic/terms.aspx";
                    //}
                    //else if ( PageCode.equalsIgnoreCase ( TlknEnum_TlknGenericPage.TlknGenericPage_Privacy ) )
                    //{
                    //    _strResult = App.SiteDomainURL + "_iTlknPages/Generic/privacy.aspx";
                    //}

                    return _strResult;

                }
                catch ( Exception ex )
                {
                    return null;
                }

            }

            public static   String Image_Get_CameraIcon =
                App.SiteDomainURL + "_iTlknImage/img_theme_splash_camera_trans.png";

    }


        public
        class URL_Weather
        {

            public static   String Weather_Get_URL = "https://www.yahoo.com/news/weather";

    }




    }
}
