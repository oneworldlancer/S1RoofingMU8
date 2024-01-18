using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;

using SQLite;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Call
    {
    public class SRoofingScreenCallShowHistoryMessageModelManager
        {
        public SRoofingScreenCallShowHistoryMessageModelManager ( )
            {
            }

     
        [PrimaryKey, AutoIncrement]
        public int _id { get; set; }


   //public SRoofingScreenCallShowHistoryMessageModelManager ( string OwnerUserTokenID , string OwnerMobileNumberTokenID )
        //    {
        //     OwnerUserTokenID = OwnerUserTokenID;
        //     OwnerMobileNumberTokenID = OwnerMobileNumberTokenID;
        //    }



        public string InviteOwnerUserID { get; set; } = "0";
        public string InviteOwnerMobileNumberID { get; set; } = "0";



        public  string GroupTag { get; set; } = SRoofingEnum_RowModelGroupTagManager.GroupTag_ITEM;


        public  string iViewCodeType { get; set; } = SRoofingEnum_Generic_RowView_AdapterType.RowView_Header;



        public  string  AccountType= SRoofingEnum_UserAccountManager.UserAccount_PERSONAL;

      
        //public  string  ProjectTokenID { get; set; } ="0" ;
 


        public  string  VisibleOnlineDateTimeMilliSec { get; set; } ="0" ;


        public  string  CategoryTitle { get; set; } ="0" ;



        public  string  AvatarImageID { get; set; } ="0" ;


        public  string  DateTime { get; set; } ="0" ;


        public  string  DateText { get; set; } ="0" ;


        public  string  DateTimeMilliSec { get; set; } ="0" ;
 

        public  string  RemoteMobileNumberE164 { get; set; } ="0" ;


        private bool _IsNewMessage = false;

        public bool IsNewMessage
        {
            get { return _IsNewMessage; }
            set
            {
                _IsNewMessage = value;
                //////if (value.ToString().ToLower() == "false")
                //////{
                //////    _IsNewMessage = false;
                //////}
                //////else
                //////{
                //////    _IsNewMessage = true;
                //////}


                //if ((value > 0) && (value < 13))
                //{
                //    _month = value;
                //}

                //_IsNewMessage = value.ToString();

            }
        }

        public string  CallTokenID { get; set; } ="0" ;



        public  string  DateTimeText { get; set; } ="0" ;



        //public  string  CallTimeText { get; set; } ="0" ;

        //public  string  CallDateText { get; set; } ="0" ;


        public  string  CallDirection { get; set; } ="0" ;


        public  string  CallStatus { get; set; } ="0" ;
 


        public  string  CallState { get; set; } ="0" ;



        public  string  MessageText { get; set; } ="0" ;


        public  string PrivateGroupTokenID { get; set; } ="0" ;

       
        public  string  CategoryTokenID { get; set; } ="0" ;




        private bool _IsVisible = false;

        public bool IsVisible
        {
            get { return _IsVisible; }
            set
            {
                _IsVisible = value;
                //if (value.ToString() == "false")
                //{
                //    _IsVisible = false;
                //}
                //else
                //{
                //    _IsVisible = true;
                //}

            }
        }





        // public  _SupplierCompanyTokenID As String
        // Public Property SupplierCompanyTokenID() As String
        // Get
        // Return _SupplierCompanyTokenID
        // End Get
        // Set(ByVal value As String)
        // _SupplierCompanyTokenID = value
        // End Set
        // End Property


        // public  _SupplierCompanyName As String
        // Public Property SupplierCompanyName() As String
        // Get
        // Return _SupplierCompanyName
        // End Get
        // Set(ByVal value As String)
        // _SupplierCompanyName = value
        // End Set
        // End Property


        //public string  CategoryID { get; set; } ="0" ;



        //public  string  CategoryName { get; set; } ="0" ;



        // public  _IsDating As String
        // Public Property IsDating() As String
        // Get
        // Return _IsDating
        // End Get
        // Set(ByVal value As String)
        // _IsDating = value
        // End Set
        // End Property


        public string  GroupTokenID { get; set; } ="0" ;

    
        public  string  GroupType { get; set; } ="0" ;



        // public  _LocationLine As String
        // Public Property LocationLine() As String
        // Get
        // Return _LocationLine
        // End Get
        // Set(ByVal value As String)
        // _LocationLine = value
        // End Set
        // End Property


        public  string  NameLine { get; set; } ="0" ;


        public  string  AvatarName { get; set; } ="0" ;

        public  string  RemoteUserTokenID { get; set; } ="0" ;

        public  string  RemoteMobileNumberTokenID { get; set; } ="0" ;


        public  string  OwnerUserTokenID { get; set; } ="0" ;
       
        public  string  OwnerMobileNumberTokenID { get; set; } ="0" ;
 
            
        public  long  UploadDateTimeMilliSec { get; set; } =0 ;
 

        // public  _RemoteFirstName As String
        // Public Property RemoteFirstName() As String
        // Get
        // Return _RemoteFirstName
        // End Get
        // Set(ByVal value As String)
        // _RemoteFirstName = value
        // End Set
        // End Property

        // public  _RemoteLastName As String
        // Public Property RemoteLastName() As String
        // Get
        // Return _RemoteLastName
        // End Get
        // Set(ByVal value As String)
        // _RemoteLastName = value
        // End Set
        // End Property


        public  string  RemoteFullName { get; set; } ="0" ;


        public  string  RemoteVisibleStatus { get; set; } ="0" ;



        //public  bool _IsOpen { get; set; } =false ;

        //public  string  ScreenChatShowID { get; set; } ="0" ;


        //public  string  ScreenChatShowTicketID { get; set; } ="0" ;


        public string GroupKey { get; set; } = "0";

        public  string  GroupCode { get; set; } ="0" ;

           //public bool IsOpen { get; set; } =false ;




        //public  string  GroupColor { get; set; } ="0" ;


        //public  string  GroupName { get; set; } ="0" ;


        public  string  GroupTitle { get; set; } ="0" ;



        public  string  ImagePath { get; set; } = "img/img_call_out_white.png";


        //public  string  GroupDescription { get; set; } ="0" ;





















        //public  string  MemberCount { get; set; } ="0" ;







        //public  string  GroupOrder { get; set; } ="0" ;

        private bool _IsActive = false;

        public bool IsActive
        {
            get { return _IsActive; }
            set
            {
                _IsActive = value;


            }
        }


    }

}
