using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;

using System;
using System.Collections.Generic;
using System.Text;
 
using SQLite;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat
{
    public class SRoofingScreenChatShowHistoryMessageModelManager
    {

        //public SRoofingScreenChatShowHistoryMessageModelManager ( )
        //    {
        //    }



        //public SRoofingScreenChatShowHistoryMessageModelManager ( string OwnerUserTokenID , string OwnerMobileNumberTokenID )
        //    {
        //     OwnerUserTokenID = OwnerUserTokenID;
        //     OwnerMobileNumberTokenID = OwnerMobileNumberTokenID;
        //    }

        [PrimaryKey, AutoIncrement]
        public int _id { get; set; }


        public string GroupTag { get; set; } = SRoofingEnum_RowModelGroupTagManager.GroupTag_ITEM;



        public string iViewCodeType { get; set; } = SRoofingEnum_Generic_RowView_AdapterType.RowView_Header;


        public string AccountType { get; set; } = SRoofingEnum_UserAccountManager.UserAccount_PERSONAL;



        public string ProjectTokenID { get; set; } = "0";


        public string VisibleOnlineDateTimeMilliSec { get; set; } = "0";



        public string CategoryTitle { get; set; } = "0";



        public string CategoryName { get; set; } = "0";



        public string ChatterListCount { get; set; } = "0";




        public string AvatarImageID { get; set; } = "0";



        public string MessageType { get; set; } = "0";


        public string RemoteMobileNumberE164 { get; set; } = "0";


        // public  DeliveryBookingTokenID As String
        // Public Property DeliveryBookingTokenID() As String
        // Get
        // Return  DeliveryBookingTokenID
        // End Get
        // Set(ByVal value As String)
        //  DeliveryBookingTokenID = value
        // End Set
        // End Property


        //[JsonConverter(typeof(BooleanConverter))]
        //public bool  IsNewMessage { get;


        //    set; } =true ;

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

        public string CallTokenID { get; set; } = "0";



        public string DateTimeText { get; set; } = "0";


        //public string  CallTimeText { get; set; } ="0" ;


        //public string  CallDateText { get; set; } ="0" ;


        //public string  CallDirection { get; set; } ="0" ;


        //public string  CallStatus { get; set; } ="0" ;



        //public string  CallState { get; set; } ="0" ;



        public string MessageText { get; set; } = "0";

        public string CategoryTokenID { get; set; } = "0";


        public string PrivateGroupTokenID { get; set; } = "0";



        // public  SupplierCompanyTokenID As String
        // Public Property SupplierCompanyTokenID() As String
        // Get
        // Return  SupplierCompanyTokenID
        // End Get
        // Set(ByVal value As String)
        //  SupplierCompanyTokenID = value
        // End Set
        // End Property


        // public  SupplierCompanyName As String
        // Public Property SupplierCompanyName() As String
        // Get
        // Return  SupplierCompanyName
        // End Get
        // Set(ByVal value As String)
        //  SupplierCompanyName = value
        // End Set
        // End Property


        public string CategoryID { get; set; } = "0";


        // public  IsDating As String
        // Public Property IsDating() As String
        // Get
        // Return  IsDating
        // End Get
        // Set(ByVal value As String)
        //  IsDating = value
        // End Set
        // End Property


        public string GroupTokenID { get; set; } = "0";


        public string publicGroupTokenID { get; set; } = "0";


        public string GroupType { get; set; } = "0";




        // public  LocationLine As String
        // Public Property LocationLine() As String
        // Get
        // Return  LocationLine
        // End Get
        // Set(ByVal value As String)
        //  LocationLine = value
        // End Set
        // End Property


        public string NameLine { get; set; } = "0";



        public string AvatarName { get; set; } = "0";


        public string RemoteUserTokenID { get; set; } = "0";


        public string RemoteMobileNumberTokenID { get; set; } = "0";


        public string OwnerUserTokenID { get; set; } = "0";


        public string OwnerMobileNumberTokenID { get; set; } = "0";


        //public bool IsVisible { get; set; } = false;


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



        // public  RemoteFirstName As String
        // Public Property RemoteFirstName() As String
        // Get
        // Return  RemoteFirstName
        // End Get
        // Set(ByVal value As String)
        //  RemoteFirstName = value
        // End Set
        // End Property

        // public  RemoteLastName As String
        // Public Property RemoteLastName() As String
        // Get
        // Return  RemoteLastName
        // End Get
        // Set(ByVal value As String)
        //  RemoteLastName = value
        // End Set
        // End Property


        public string RemoteFullName { get; set; } = "0";


        public string RemoteVisibleStatus { get; set; } = "0";


        public string MessageTokenID { get; set; } = "0";



        public string DateTime { get; set; } = "0";


        public string DateText { get; set; } = "0";



        public string DateTimeMilliSec { get; set; } = "0";




        //public bool  IsOpen { get; set; } =false ;


        //public string  ScreenChatShowID { get; set; } ="0" ;


        //public string  ScreenChatShowTicketID { get; set; } ="0" ;


        public string GroupKey { get; set; } = "0";



        public string GroupCode { get; set; } = "0";




        //public string  GroupColor { get; set; } ="0" ;


        //public string  GroupName { get; set; } ="0" ;


        public string GroupTitle { get; set; } = "0";

        //public string  GroupDescription { get; set; } ="0" ;


        public string InviteOwnerUserID { get; set; } = "0";

        public string InviteOwnerMobileNumberID { get; set; } = "0";






















        //public string MemberCount { get; set; } ="0" ;




        //public string GroupOrder { get; set; } ="0" ;


        //public string IsActive { get; set; } = "0";

        private bool _IsActive = false;

        public bool IsActive
        {
            get { return _IsActive; }
            set
            {
                _IsActive = value;
            

            }
        }


        public long UploadDateTimeMilliSec { get; set; } = 0;


    }
}
