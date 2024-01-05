using System;
using System.Collections.Generic;
using System.Text;

 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech
{
    public class SRoofingSpeechModel
    {

        // detectlanguage.com/languages

        // https://learn.microsoft.com/en-us/azure/cognitive-services/speech-service/rest-text-to-speech?tabs=streaming

        public string idToken { get; set; } = "0";

        public string TokenID { get; set; } = "0";


        public string LocalCountry { get; set; } = "0";
        //String  LocalID { get; set; } ="0";
        public string LanguageCode { get; set; } = "en";
        public string LanguageName { get; set; } = "en";
        public string LanguageValue { get; set; } = "en";
        public string LocalShort { get; set; } = "0";

        public string LocaleName { get; set; } = "English (United States)";
        public string LocaleValue { get; set; } = "en-US";



        public string DisplayTitle { get; set; } = "0";
        public string DisplayName { get; set; } = "0";
        public string CountryISOCode { get; set; } = "0";
        public string CountryName { get; set; } = "0";


        public string UploadDay { get; set; } = "0";
        public string UploadMonth { get; set; } = "0";
        public string UploadYear { get; set; } = "0";
        public string UploadTime { get; set; } = "0";
        public string UploadDateTime { get; set; } = "0";

        //  public   Locale _iLocale = new lan Locale.ENGLISH;
        public
        SRoofingSpeechModel ( )
        {
        }


        public
        SRoofingSpeechModel (
                //Locale iLocale ,
                String DisplayName ,
                String DisplayTitle ,
                String CountryISOCode ,
                String CountryName ,
                String LanguageCode ,
                String LanguageValue )
        {

            //  iLocale = iLocale;

            // AccountType = AccountType;
            this.CountryISOCode = CountryISOCode;
            this.CountryName = CountryName;
            this.DisplayTitle = DisplayName + " (" + LanguageCode.ToUpperInvariant ( ) + ")";//DisplayTitle;
            this.DisplayName = DisplayName;
            // LocalID = LocalID;
            this.LanguageCode = LanguageCode;
            this.LanguageValue = LanguageValue;


            //_LocalShort=LocalShort;
        }


    }
}
