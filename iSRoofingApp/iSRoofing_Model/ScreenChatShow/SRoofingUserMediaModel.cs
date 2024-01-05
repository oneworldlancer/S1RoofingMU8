using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.YouTube;

using System;
using System.Collections.Generic;
using System.Text;

 
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow
{
    public class SRoofingUserMediaModel
    {


        public SRoofingScreenChatShowScreenModel iChatModel { get; set; }

        public SRoofingYouTubeModel iYouTubeModel { get; set; } = null;
        public FileResult fileResult { get; set; } = null;
        public string MediaFile_MessageTokenID { get; set; } = "0";

        public string MediaFile_Code { get; set; } = "0";
        public string MediaFile_Type { get; set; } = "0";
        public string MediaFile_Thum { get; set; } = "0";
        public string MediaFile_Name { get; set; } = "0";
        public string MediaFile_Title { get; set; } = "0";
         public string MediaFile_Extension { get; set; } = "0";
        public string MediaFile_Size { get; set; } = "0";
        public string MediaFile_Duration { get; set; } = "0";
        public ImageSource MediaFile_Stream { get; set; } = null;


        public string MediaFile_TokenID { get; set; } = "0";
        public string MediaFile_ServerID { get; set; } = "0";
        public string MediaFile_LocalPathURL { get; set; } = "0";
        public string MediaFile_ServerURL { get; set; } = "0";
        public Uri MediaFile_URI { get; set; } = null;


        public string MediaFile_Thumbnail_TokenID { get; set; } = "0";
        public string MediaFile_Thumbnail_ServerID { get; set; } = "0";
        public string MediaFile_Thumbnail_LocalPathURL { get; set; } = "0";
        public string MediaFile_Thumbnail_ServerURL { get; set; } = "0";
        public Uri MediaFile_Thumbnail_URI { get; set; } = null;

        public bool MediaFile_IsMediaSlideShow { get; set; } = false;

        /*    public string UploadDay { get; set; }
            public string UploadDay { get; set; }
            public string UploadDay { get; set; }
            public string UploadDay { get; set; }
            public string UploadDay { get; set; }
            public string UploadDay { get; set; }
            public string UploadDay { get; set; }*/

        public string UploadDay { get; set; } = "0";
        public string UploadMonth { get; set; } = "0";
        public string UploadYear { get; set; } = "0";
        public string UploadTime { get; set; } = "0";
        public string UploadDateTime { get; set; } = "0";
        public string UploadDateTimeMilliSec { get; set; } = "0";

        public
         SRoofingUserMediaModel (

                 string MediaFile_MessageTokenID ,
                 SRoofingScreenChatShowScreenModel iChatModel ,

                 string MediaFile_Code ,
                 string MediaFile_Type ,
                 string MediaFile_Thum ,
                 string MediaFile_Name ,
                 string MediaFile_Extension ,
                 string MediaFile_Size ,
                 string MediaFile_Duration ,

                 string MediaFile_TokenID ,
                 string MediaFile_ServerID ,
                 string MediaFile_LocalPathURL ,
                 string MediaFile_ServerURL ,
                 Uri MediaFile_URI ,

                 string MediaFile_Thumbnail_TokenID ,
                 string MediaFile_Thumbnail_ServerID ,
                 string MediaFile_Thumbnail_LocalPathURL ,
                 string MediaFile_Thumbnail_ServerURL ,
                 Uri MediaFile_Thumbnail_URI ,

                 SRoofingYouTubeModel iYouTubeModel ,

                      FileResult fileResult ,

                        ImageSource MediaFile_Stream ,
                 bool MediaFile_IsMediaSlideShow )
        {

            this.MediaFile_Stream = MediaFile_Stream;
            this.iChatModel = iChatModel;
            this.MediaFile_MessageTokenID = MediaFile_MessageTokenID;
            this.MediaFile_Code = MediaFile_Code;
            this.MediaFile_Type = MediaFile_Type;
            this.MediaFile_Thum = MediaFile_Thum;
            this.MediaFile_Name = MediaFile_Name;
          this.MediaFile_Extension = MediaFile_Extension;

            this.MediaFile_Title = MediaFile_Name;// +  "." + MediaFile_Extension;      
           
            
            this.MediaFile_Duration = MediaFile_Duration;
            this.MediaFile_Size = MediaFile_Size;
            this.MediaFile_TokenID = MediaFile_TokenID;
            this.MediaFile_ServerID = MediaFile_ServerID;
            this.MediaFile_LocalPathURL = MediaFile_LocalPathURL;
            this.MediaFile_ServerURL = MediaFile_ServerURL;
            this.MediaFile_URI = MediaFile_URI;


            this.MediaFile_Thumbnail_TokenID = MediaFile_Thumbnail_TokenID;
            this.MediaFile_Thumbnail_ServerID = MediaFile_Thumbnail_ServerID;
            this.MediaFile_Thumbnail_LocalPathURL = MediaFile_Thumbnail_LocalPathURL;
            this.MediaFile_Thumbnail_ServerURL = MediaFile_Thumbnail_ServerURL;
            this.MediaFile_Thumbnail_URI = MediaFile_Thumbnail_URI;

            this.iYouTubeModel = iYouTubeModel;
            this.fileResult = fileResult;

            this.MediaFile_IsMediaSlideShow = MediaFile_IsMediaSlideShow;


        }

        public SRoofingUserMediaModel ( )
        {
        }

        public SRoofingUserMediaModel ( SRoofingYouTubeModel iYouTubeModel )
        {
            this.iYouTubeModel = iYouTubeModel;
        }

        public SRoofingUserMediaModel ( FileResult fileResult )
        {
            this.fileResult = fileResult;
        }


    }
}
