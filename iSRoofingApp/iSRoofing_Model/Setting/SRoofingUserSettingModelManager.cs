using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;

using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting
{
    public class SRoofingUserSettingModelManager
    {

        public SRoofingUserSettingModelManager ( )
        {
        }

        //////public SRoofingUserSettingModelManager ( string UserID )
        //////{
        //////    this.UserID = UserID;
        //////}
        //////public SRoofingUserSettingModelManager ( string UserID , string MobileNumberID )
        //////{
        //////    this.UserID = UserID;
        //////    this.MobileNumberID = MobileNumberID;
        //////}



        public string AccountType { get; set; } = App.iAccountType;



        public string History_Chat_SortBy { get; set; } = SRoofing_Enum_SortBy.SortBy_RECENT;
        public string History_Call_SortBy { get; set; } = SRoofing_Enum_SortBy.SortBy_RECENT;


                             
        public bool Chat_SaveHistory_IsEnable { get; set; } =true;

                                  
        public bool Media_DownloadImage_IsEnable { get; set; } =false;

                                  
        public bool Media_DownloadVideo_IsEnable { get; set; } =false;

                                  
        public bool Media_DownloadDocument_IsEnable { get; set; } =false;

    
        public string Sound_Chat_Incoming { get; set; } = "snd_chat_in_1.mp3";

     
        public string Sound_Chat_Outgoing { get; set; } = "snd_chat_out_1.mp3";

     
        public string Sound_Call_Incoming { get; set; } = "snd_call_in_1.mp3";

     
        public string Sound_Call_Outgoing { get; set; } = "snd_call_out_1.mp3";

     
     
        public string Sound_Chat_Incoming_Title { get; set; } = "Sound-1";

     
        public string Sound_Chat_Outgoing_Title { get; set; } = "Sound-1";

     
        public string Sound_Call_Incoming_Title { get; set; } = "Sound-1";

     
        public string Sound_Call_Outgoing_Title { get; set; } = "Sound-1";

     
        public bool Call_VoiceCommand_IsEnable { get; set; } = false;

     
        public bool Call_Auto_Answer { get; set; } = false;

     
        public bool Call_Auto_Redial { get; set; } = false;

     
        public string Call_Auto_Message { get; set; } = "0";

     
        public string Speech_Incoming { get; set; } = "0";

     
        public string Speech_Outgoing { get; set; } = "0";

     
        public bool Speech_IsEnable { get; set; } =true;

   
        public bool Sound_IsEnable { get; set; } =true;

     
        public bool VisibleStatus_IsEnable { get; set; } =true;

     
        
        
        public string OwnerUserTokenID { get; set; } = "0";


        public string OwnerMobileNumberTokenID { get; set; } = "0";


        public string RateUs { get; set; } = "0";


        public string Chat_Background_ImageURL { get; set; } = "bg0.png";


        public string Profile_VisibleTo { get; set; } = "0";

        public bool Account_IsVisible { get; set; } = true;


        public bool Account_IsEnable { get; set; } = true;






        public bool Show_VisibleStatus_OnlineTime { get; set; } = true;

        public bool Notification_Contact_NewJoin { get; set; } = true;


        public bool Notification_Update_New { get; set; } = true;


        public bool Notification_Update_Auto { get; set; } = true;

   
        public bool Notification_Update_WIFI { get; set; } = true;


        // public  SoundMuteAll As String
        // Public Property SoundMuteAll() As String
        // Get
        // Return  SoundMuteAll
        // End Get
        // Set(ByVal value As String)
        //  SoundMuteAll = value
        // End Set
        // End Property


        // public  DatingReceiveCall As String
        // Public Property DatingReceiveCall() As String
        // Get
        // Return  DatingReceiveCall
        // End Get
        // Set(ByVal value As String)
        //  DatingReceiveCall = value
        // End Set
        // End Property


        // public  DatingReceiveText As String
        // Public Property DatingReceiveText() As String
        // Get
        // Return  DatingReceiveText
        // End Get
        // Set(ByVal value As String)
        //  DatingReceiveText = value
        // End Set
        // End Property


        // public  DatinAlertMatch As String
        // Public Property DatingAlertMatch() As String
        // Get
        // Return  DatinAlertMatch
        // End Get
        // Set(ByVal value As String)
        //  DatinAlertMatch = value
        // End Set
        // End Property


        public bool Dating_Alert_Email { get; set; } = true;

        public bool Dating_Play_Random { get; set; } = true;



        // public  DatingHideMe As String
        // Public Property Dating HideMe() As String
        // Get
        // Return  DatingHideMe
        // End Get
        // Set(ByVal value As String)
        //  DatingHideMe = value
        // End Set
        // End Property



        public string Dating_Search_Gender { get; set; } = "0";


        public string Dating_Search_Age_Min { get; set; } = "0";

        public string Dating_Search_Age_Max { get; set; } = "0";


        // public  DatingSearchLocationIsEnable As String
        // Public Property DatingSearchLocationIsEnable() As String
        // Get
        // Return  DatingSearchLocationIsEnable
        // End Get
        // Set(ByVal value As String)
        //  DatingSearchLocationIsEnable = value
        // End Set
        // End Property


        public string Dating_Search_Location_CountryCode { get; set; } = "0";


        public string Dating_Search_Location_CountryName { get; set; } = "0";



        public string Dating_Search_Location_CityCode { get; set; } = "0";


        public string Dating_Search_Location_CityName { get; set; } = "0";



        public string Dating_Search_Distance_Code { get; set; } = "0";


        public string Dating_Search_Distance_Value { get; set; } = "0";



        public string Dating_Show_Location_CityName { get; set; } = "0";



        public string Dating_Show_Location_Distance { get; set; } = "0";




        public string Post_ViewFrom { get; set; } = "0";



        public string Post_ShareTo { get; set; } = "0";


        public string Post_Comment_ViewFrom { get; set; } = "0";



        //public string UserID { get; set; } = "0";


        //public string MobileNumberID { get; set; } = "0";


    }
}
