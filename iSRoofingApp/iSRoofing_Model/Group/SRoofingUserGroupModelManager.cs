using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group
{
    public class SRoofingUserGroupModelManager
    {
        public SRoofingUserGroupModelManager ( )
        {
        }




        public string AccountType { get; set; } = SRoofingEnum_UserAccountManager.UserAccount_PERSONAL;


        public string iViewCodeType = SRoofingEnum_Generic_RowView_AdapterType.RowView_Header;



        //public SRoofingUserGroupModelManager (   public string  AvatarName ,   public string  RemoteFullName )
        //    {
        //    _AvatarName = AvatarName;
        //    _RemoteFullName = RemoteFullName;
        //    }


        //public SRoofingUserGroupModelManager (   public string  CategoryID )
        //    {
        //    _CategoryID = CategoryID;
        //    }


        public string RemoteMobileNumberE164 { get; set; } = "0";


        // Private _AvatarImageID As String
        // Public Property AvatarImageID() As String
        // Get
        // Return _AvatarImageID
        // End Get
        // Set(ByVal value As String)
        // _AvatarImageID = value
        // End Set
        // End Property



        public string GroupTag { get; set; } = "0";



        public string PrivateGroupTokenID { get; set; } = "0";


        public string CategoryTokenID { get; set; } = "0";



        public string CategoryTitle { get; set; } = "0";


        public string GroupTokenID { get; set; } = "0";

        public string GroupType { get; set; } = "0";


        public string LocationLine { get; set; } = "0";


        public string NameLine { get; set; } = "0";


        public string RemoteUserTokenID { get; set; } = "0";


        public string RemoteMobileNumberTokenID { get; set; } = "0";


        //string  RemoteFirstName { get; set; } = "0";

        //string  RemoteLastName { get; set; } = "0";


        public string RemoteFullName { get; set; } = "0";


        public string RemoteVisibleStatus { get; set; } = "0";



        public string GroupCode { get; set; } = "0";


        public string GroupColor { get; set; } = "0";


        public string GroupTitle { get; set; } = "0";


        public string GroupDescription { get; set; } = "0";














        public string RemoteDistanceLine { get; set; } = "0";




        public string ChatterListCount { get; set; } = "0";




        public string AvatarImageID { get; set; } = "0";



        public string AvatarName { get; set; } = "0";



        public string MobileNumberE164 { get; set; } = "0";



        public string iRowViewIsEnable { get; set; } = "0";



    }
}