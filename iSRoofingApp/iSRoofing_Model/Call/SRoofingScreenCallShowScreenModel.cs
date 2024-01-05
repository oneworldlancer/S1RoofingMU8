using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.Call
{

    public class SRoofingScreenCallShowScreenModel
    {
        public
SRoofingScreenCallShowScreenModel ( )
        {
        }


        public string MatchType = "0";// TlknEnum Dating MatchType.DatingMatchType LikeYou;


        int RemoteAvatarIsBlur { get; set; } = 1;

        public string AccountType { get; set; } = "0";
        public string CallCode { get; set; } = "0";
        public string CallDirection { get; set; } = "0";
        public string CallDuration { get; set; } = "0";
        public string CallScreenType { get; set; } = "0";
        public string CallState { get; set; } = "0";
        public string CallStatus { get; set; } = "0";
        public string CallTag { get; set; } = "0";
        public string CallTokenID { get; set; } = "0";
        public string CallType { get; set; } = "0";
        public string CategoryID { get; set; } = "0";
        public string GroupTokenID { get; set; } = "0";
        public string GroupTitle { get; set; } = "0";
        public string GroupType { get; set; } = "0";
        public string InviteOwnerMobileNumberID { get; set; } = "0";
        public string InviteOwnerUserID { get; set; } = "0";
        public string InviteTag { get; set; } = "0";
        Boolean IsCalling { get; set; } = false;
        int IsDating { get; set; } = 0;
        Boolean IsSystem { get; set; } = false;
        public string NameLine { get; set; } = "0";
        public string AvatarName { get; set; } = "0";
        public string RemoteMobileNumberID { get; set; } = "0";
        public string RemoteUserID { get; set; } = "0";
        public string ScreenCallShowID { get; set; } = "0";
        public string ScreenCallShowTicketID { get; set; } = "0";
        public string ScreenChatShowID { get; set; } = "0";
        public string ScreenChatShowTicketID { get; set; } = "0";
        public string ScreenShowID { get; set; } = "0";
        public string ScreenShowNameLine { get; set; } = "0";
        public string ScreenShowTicketID { get; set; } = "0";
        public string ScreenShowTitle { get; set; } = "0";
        public string ScreenShowType { get; set; } = "0";
        public SRoofingUserRemoteModelManager iRemoteModel { get; set; } = null;
        SRoofingUserOwnerModelManager iOwnerModel { get; set; } = null;





        public
        SRoofingScreenCallShowScreenModel (
                String AccountType ,
                String CallTokenID ,
                String InviteTag ,
                String CallScreenType ,
                String GroupID ,
                String GroupType ,
                String GroupTitle ,
                String NameLine ,
                String ScreenChatShowID ,
                String ScreenChatShowTicketID ,
                String ScreenCallShowID ,
                String ScreenCallShowTicketID ,
                String InviteOwnerUserID ,
                String InviteOwnerMobileNumberID ,
                String RemoteUserID ,
                String RemoteMobileNumberID ,
                String CallCode ,
                String CallType ,
                String CallDirection ,
                String CallTag ,
                String CallStatus ,
                String CallState ,
                String CallDuration ,
                int IsDating ,
                Boolean blnIsCalling ,
                Boolean blnIsSystem ,
                SRoofingUserRemoteModelManager iRemoteModel ,

                String MatchType ,
                int RemoteAvatarIsBlur )
        {

            this.MatchType = MatchType;

            this.RemoteAvatarIsBlur = RemoteAvatarIsBlur;


            this.AccountType = AccountType;
            this.iRemoteModel = iRemoteModel;
            this.CallTokenID = CallTokenID;
            this.InviteTag = InviteTag;
            this.CallScreenType = CallScreenType;
            this.CallCode = CallCode;
            this.CallType = CallType;
            this.GroupTokenID = GroupID;
            this.GroupType = GroupType;
            this.GroupTitle = GroupTitle;
            this.NameLine = NameLine;

            this.AvatarName = iRemoteModel.AvatarName;
            this.RemoteUserID = RemoteUserID;
            this.RemoteMobileNumberID = RemoteMobileNumberID;
            this.ScreenChatShowID = ScreenChatShowID;
            this.ScreenChatShowTicketID = ScreenChatShowTicketID;
            this.ScreenCallShowID = ScreenCallShowID;
            this.ScreenCallShowTicketID = ScreenCallShowTicketID;
            this.InviteOwnerUserID = InviteOwnerUserID;
            this.InviteOwnerMobileNumberID = InviteOwnerMobileNumberID;
            this.CallDirection = CallDirection;
            this.CallTag = CallTag;
            this.CallStatus = CallStatus;
            this.CallState = CallState;
            this.CallDuration = CallDuration;
            this.IsDating = IsDating;
            this.IsCalling = blnIsCalling;
            this.IsSystem = blnIsSystem;
        }








        //public
        //SRoofingScreenCallShowScreenModel (
        //        string paramstring1 ,
        //        string paramstring2 ,
        //        string paramstring3 ,
        //        string paramstring4 ,
        //        string paramstring5 ,
        //        string paramstring6 ,
        //        string paramstring7 ,
        //        string paramstring8 ,
        //        string paramstring9 ,
        //        string paramstring10 ,
        //        string paramstring11 ,
        //        string paramstring12 ,
        //        string paramstring13 ,
        //        string paramstring14 ,
        //        string paramstring15 ,
        //        int paramInt ,
        //        Boolean paramBoolean1 ,
        //        Boolean paramBoolean2 ,
        //        SRoofingUserRemoteModelManager paramSRoofingUserRemoteModelManager )
        //    {
        //     AccountType = paramstring1;
        //     iRemoteModel = paramSRoofingUserRemoteModelManager;
        //     CallTokenID = paramstring2;
        //     ScreenShowID = paramstring4;
        //     ScreenShowTicketID = paramstring5;
        //     ScreenShowType = paramstring6;
        //     ScreenShowTitle = paramstring7;
        //     ScreenShowNameLine = paramstring8;
        //     InviteTag = paramstring3;
        //     CallCode = paramstring9;
        //     CallType = paramstring10;
        //     CallDirection = paramstring11;
        //     CallTag = paramstring12;
        //     CallStatus = paramstring13;
        //     CallState = paramstring14;
        //     CallDuration = paramstring15;
        //     IsDating = paramInt;
        //     IsCalling = paramBoolean1;
        //     IsSystem = paramBoolean2;
        //    }

        //public
        //SRoofingScreenCallShowScreenModel (
        //        string paramstring1 ,
        //        string paramstring2 ,
        //        string paramstring3 ,
        //        string paramstring4 ,
        //        string paramstring5 ,
        //        string paramstring6 ,
        //        string paramstring7 ,
        //        string paramstring8 ,
        //        string paramstring9 ,
        //        string paramstring10 ,
        //        string paramstring11 ,
        //        string paramstring12 ,
        //        string paramstring13 ,
        //        string paramstring14 ,
        //        string paramstring15 ,
        //        string paramstring16 ,
        //        string paramstring17 ,
        //        string paramstring18 ,
        //        string paramstring19 ,
        //        string paramstring20 ,
        //        string paramstring21 ,
        //        string paramstring22 ,
        //        string paramstring23 ,
        //        int paramInt ,
        //        Boolean paramBoolean1 ,
        //        Boolean paramBoolean2 ,
        //        SRoofingUserRemoteModelManager iRemoteModel )
        //    {
        //     AccountType = paramstring1;
        //     iRemoteModel = iRemoteModel;
        //     CallTokenID = paramstring2;
        //     InviteTag = paramstring3;
        //     CallScreenType = paramstring4;
        //     CallCode = paramstring17;
        //     CallType = paramstring18;
        //     GroupID = paramstring5;
        //     GroupType = paramstring6;
        //     GroupTitle = paramstring7;
        //     NameLine = paramstring8;
        //     RemoteUserID = paramstring15;
        //     RemoteMobileNumberID = paramstring16;
        //     ScreenChatShowID = paramstring9;
        //     ScreenChatShowTicketID = paramstring10;
        //     ScreenCallShowID = paramstring11;
        //     ScreenCallShowTicketID = paramstring12;
        //     InviteOwnerUserID = paramstring13;
        //     InviteOwnerMobileNumberID = paramstring14;
        //     CallDirection = paramstring19;
        //     CallTag = paramstring20;
        //     CallStatus = paramstring21;
        //     CallState = paramstring22;
        //     CallDuration = paramstring23;
        //     IsDating = paramInt;
        //     IsCalling = paramBoolean1;
        //     IsSystem = paramBoolean2;
        //    }


        //public
        //SRoofingScreenCallShowScreenModel (
        //        string AccountType ,
        //        string CallTokenID ,
        //        string paramstring3 ,
        //        string paramstring4 ,
        //        string paramstring5 ,
        //        string paramstring6 ,
        //        string paramstring7 ,
        //        string paramstring8 ,
        //        string paramstring9 ,
        //        string paramstring10 ,
        //        string paramstring11 ,
        //        string paramstring12 ,
        //        string paramstring13 ,
        //        string paramstring14 ,
        //        string paramstring15 ,
        //        string paramstring16 ,
        //        string paramstring17 ,
        //        string paramstring18 ,
        //        string paramstring19 ,
        //        string paramstring20 ,
        //        string paramstring21 ,
        //        string paramstring22 ,
        //        string paramstring23 ,
        //        int paramInt ,
        //        Boolean paramBoolean1 ,
        //        Boolean paramBoolean2 ,
        //        SRoofingUserOwnerModelManager iOwnerModel )
        //    {
        //     this.AccountType = AccountType;
        //   this.  iOwnerModel = iOwnerModel;
        //     this.CallTokenID = CallTokenID;
        //     InviteTag = paramstring3;
        //     CallScreenType = paramstring4;
        //     CallCode = paramstring17;
        //     CallType = paramstring18;
        //     GroupID = paramstring5;
        //     GroupType = paramstring6;
        //     GroupTitle = paramstring7;
        //     NameLine = paramstring8;
        //     RemoteUserID = paramstring15;
        //     RemoteMobileNumberID = paramstring16;
        //     ScreenChatShowID = paramstring9;
        //     ScreenChatShowTicketID = paramstring10;
        //     ScreenCallShowID = paramstring11;
        //     ScreenCallShowTicketID = paramstring12;
        //     InviteOwnerUserID = paramstring13;
        //     InviteOwnerMobileNumberID = paramstring14;
        //     CallDirection = paramstring19;
        //     CallTag = paramstring20;
        //     CallStatus = paramstring21;
        //     CallState = paramstring22;
        //     CallDuration = paramstring23;
        //     IsDating = paramInt;
        //     IsCalling = paramBoolean1;
        //     IsSystem = paramBoolean2;
        //    }


        //////////public
        //////////SRoofingScreenCallShowScreenModel (
        //////////        string AccountType ,
        //////////        string CallTokenID ,
        //////////        string InviteTag ,
        //////////        string CallScreenType ,
        //////////        string GroupID ,
        //////////        string GroupType ,
        //////////        string GroupTitle ,
        //////////        string NameLine ,
        //////////        string ScreenChatShowID ,
        //////////        string ScreenChatShowTicketID ,
        //////////        string ScreenCallShowID ,
        //////////        string ScreenCallShowTicketID ,
        //////////        string InviteOwnerUserID ,
        //////////        string InviteOwnerMobileNumberID ,
        //////////        string RemoteUserID ,
        //////////        string RemoteMobileNumberID ,
        //////////        string CallCode ,
        //////////        string CallType ,
        //////////        string CallDirection ,
        //////////        string CallTag ,
        //////////        string CallStatus ,
        //////////        string CallState ,
        //////////        string CallDuration ,
        //////////        int IsDating ,
        //////////        Boolean blnIsCalling ,
        //////////        Boolean blnIsSystem ,
        //////////        SRoofingUserRemoteModelManager iRemoteModel ,

        //////////        string MatchType ,
        //////////        int RemoteAvatarIsBlur )
        //////////    {

        //////////     MatchType = MatchType;

        //////////     RemoteAvatarIsBlur = RemoteAvatarIsBlur;


        //////////     AccountType = AccountType;
        //////////     iRemoteModel = iRemoteModel;
        //////////     CallTokenID = CallTokenID;
        //////////     InviteTag = InviteTag;
        //////////     CallScreenType = CallScreenType;
        //////////     CallCode = CallCode;
        //////////     CallType = CallType;
        //////////     GroupID = GroupID;
        //////////     GroupType = GroupType;
        //////////     GroupTitle = GroupTitle;
        //////////     NameLine = NameLine;
        //////////     RemoteUserID = RemoteUserID;
        //////////     RemoteMobileNumberID = RemoteMobileNumberID;
        //////////     ScreenChatShowID = ScreenChatShowID;
        //////////     ScreenChatShowTicketID = ScreenChatShowTicketID;
        //////////     ScreenCallShowID = ScreenCallShowID;
        //////////     ScreenCallShowTicketID = ScreenCallShowTicketID;
        //////////     InviteOwnerUserID = InviteOwnerUserID;
        //////////     InviteOwnerMobileNumberID = InviteOwnerMobileNumberID;
        //////////     CallDirection = CallDirection;
        //////////     CallTag = CallTag;
        //////////     CallStatus = CallStatus;
        //////////     CallState = CallState;
        //////////     CallDuration = CallDuration;
        //////////     IsDating = IsDating;
        //////////     IsCalling = blnIsCalling;
        //////////     IsSystem = blnIsSystem;
        //////////    }


    }

}
