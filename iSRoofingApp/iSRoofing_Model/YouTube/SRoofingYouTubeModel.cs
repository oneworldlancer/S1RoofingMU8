using System;
using System.Collections.Generic;
using System.Text;

 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.YouTube
{
    public class SRoofingYouTubeModel
    {

        // detectlanguage.com/languages

        public string idToken { get; set; } = "0";

        //public   string  TokenID { get; set; }


        public string VideoID { get; set; } = "0";
        public string VideoTitle { get; set; } = "0";
        //public string PublisherName { get; set; } = "0";

        public string ChannelID { get; set; } = "0";
        public string ChannelTitle { get; set; } = "0";

        public string VideoDescription { get; set; } = "0";
        public string VideoTime { get; set; }
        public string ImageThumServerURL { get; set; } = "0";



        public string OwnerUserTokenID { get; set; } = "0";
        //String  LocalID { get; set; }
        public string OwnerMobileNumberTokenID { get; set; } = "0";

        public string OwnerYouTubeChannelID { get; set; } = "0";



        public int iYouTube_iMedia_Width { get; set; } = 0;
        public int iYouTube_iMedia_Height { get; set; } = 0;


        
        //public   string  LocalShort { get; set; }

        //public   string  CountryISOCode { get; set; }
        //public   string  CountryName { get; set; }


        //  public   string  UploadDay { get; set; }
        //  public   string  UploadMonth { get; set; }
        //  public   string  UploadYear { get; set; }
        //  public   string  UploadTime { get; set; }
        //  public   string  UploadDateTime { get; set; }

        //  public   Locale _iLocale = new lan Locale.ENGLISH;
        public
        SRoofingYouTubeModel ( )
        {
        }


        ////public
        ////SRoofingYouTubeModel (
        ////        //Locale iLocale ,
        ////        String DisplayName ,
        ////        String DisplayTitle ,
        ////        String CountryISOCode ,
        ////        String CountryName ,
        ////        String LanguageCode ,
        ////        String LanguageValue )
        ////    {

        ////   //  iLocale = iLocale;

        ////    // AccountType = AccountType;
        ////   this.  CountryISOCode = CountryISOCode;
        ////    this.CountryName = CountryName;
        ////    this.DisplayTitle = DisplayName + " (" + LanguageCode.ToUpperInvariant ( ) + ")";//DisplayTitle;
        ////    this.DisplayName = DisplayName;
        ////    // LocalID = LocalID;
        ////    this.LanguageCode = LanguageCode;
        ////    this.LanguageValue = LanguageValue;


        ////    //_LocalShort=LocalShort;
        ////    }


    }
}
