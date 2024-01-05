using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager
{
    class SRoofingEnum_Toast_MessageManager
        {

        public static
 String PopupMessage_LoginValidateDetailsNotExist ( )
            {

            return "The details entered don't match our records";
            }


        public static
        String PopupMessage_LoginValidateAddDeviceToList ( )
            {

            // return "You need to use option(4) to register this device";

            return "You need to use [Add New Devices] link";

            }


        public static
        String PopupMessage_RegisterValidateMobileNumberExist ( )
            {

            return "Can't register with this Mobile Number";
            }


        public static
        String PopupMessage_RegisterValidateEmailAddressExist ( )
            {

            return "Can't register with this Email Address";
            }

        public static
        String PopupMessage_ChatSelectContact ( )
            {

            return "Select contact first";
            }

        public static
        String PopupMessage_ChatMaxContact ( )
            {

            return "Can't select more than 4 contacts";
            }


        public static
        String PopupMessage_ChatAllowContactCount ( String CountContact )
            {

            if ( CountContact.ToLower() ==  ( "0" ) )
                {

                return "This group is full, try again later";

                }
            else
                {
                return "Can't select more than " + CountContact + " contacts";
                }

            }


        public static
        String PopupMessage_ChatGroupFullContact ( )
            {

            return "This group is full, you need to remove contacts to add more";
            }

        public static
        String PopupMessage_ChatGroupNotAllowed ( )
            {

            return "This group is full, try again later";
            }


        public static
        String PopupMessage_CallNoNewCallRunning ( )
            {

            return "Can\'t initiate new call";
            }

        public static
        String PopupMessage_NeedSubscribe ( )
            {

            return "You need to upgrade your account to use this service";
            }


        public static
        String PopupMessage_LocationTrack_Limit_NeedSubscribe ( )
            {

            return "Upgrade to be able to track more than 3 users at one time";
            }


        public static
        String PopupMessage_Post_AttachCount_RoleFree ( )
            {

            return "You can\'t upload more than 5 files, upgrade to Premium to upload more";
            }


        public static
        String PopupMessage_Post_AttachCount_RolePremium ( )
            {

            return "You can\'t upload more than 10 files";
            }


        public static
        String PopupMessage_Post_Notification_ClearAll ( )
            {

            return "Are you sure want to remove all notifications";
            }


        public static
        String PopupMessage_Post_Remove ( )
            {

            return "Are you sure want to remove post";
            }

        public static
        String PopupMessage_Post_ClearAll ( )
            {

            return "Are you sure want to clear all";
            }


        public static
        String PopupMessage_Post_Share ( )
            {

            return "Are you sure want to clear all posts";
            }


        public static
        String PopupMessage_Attach_Remove ( )
            {

            return "Are you sure want to remove attach";
            }


        public static
        String PopupMessage_SettingRestoreDefault ( )
            {

            return "Are you sure want to reset all settings";
            }


        public static
        String PopupMessage_UserNotAdmin ( )
            {

            return "You don\'t have permission for this action";
            }


        public static
        String PopupMessage_ClearHistory ( )
            {

            return "Are you sure want to clear all chat messages";
            }

        public static
        String PopupMessage_ResetAvatar ( )
            {

            return "Are you sure want to remove your avatar";
            }

        public static
        String PopupMessage_AccountDeactivate ( )
            {

            return "Are you sure want to close this account";
            }


        public static
        String PopupMessage_MessageSent ( )
            {

            return "Your message has been sent successfully";
            }


        public static
        String PopupMessage_RequestSent ( )
            {

            return "Your request has been sent successfully";
            }


        public static
        String PopupMessage_Accept_Contact_Add ( )
            {

            return "User is now in contacts";
            }


        public static
        String PopupMessage_Accept_Contact_Info ( )
            {

            return "You shared info with friend";
            }


        public static
        String PopupMessage_Accept_Location_Track ( )
            {

            return "You shared location with friend";
            }

        public static
        String PopupMessage_Post_Shared ( )
            {

            return "You\'ve shared a post";
            }

        public static
        String PopupMessage_Post_Sent ( )
            {

            return "You post has been sent successfully";
            }

        public static
        String PopupMessage_Post_Temp ( )
            {

            return "Your post is being uploading";
            }


        public static
        String PopupMessage_Post_Comment_Sent ( )
            {

            return "You\'ve sent a comment";
            }


        public static
        String PopupMessage_Record_Voice_No ( )
            {

            return "You can\'t record voice now, try again later";
            }


        public static
        String PopupMessage_MessageUpdateUserName ( )
            {

            return "Your name has been updates successfully";
            }

        public static
        String PopupMessage_MessageUpdatePassword ( )
            {

            return "Your pass code has been updates successfully";
            }

        public static
        String PopupMessage_MessagePickContactMessage ( )
            {

            return "Your need to pick contact and fill in message first";
            }

        public static
        String PopupMessage_MessagePickContact ( )
            {

            return "Your need to pick contact";
            }

        public static
        String PopupMessage_MessageNoYourselfMessage ( )
            {

            return "You can\'t send message to yourself";
            }


        public static
        String PopupMessage_MessageNoYourselfSearch ( )
            {

            return "You can\'t search for yourself";
            }


        public class Message_Internet_Connection
            {

 public static
        String PopupMessage_MessageConnectionFalse ( )
            {

        return "Network error\nCheck your network data connections";
            // return "الإتصال بالشبكة غير متوفر!";
            }


            }

       
        public static
        String PopupMessage_MessageValidateEntry ( )
            {

            return "Wait while validate your entries";
            }

        public static
        String PopupMessage_MessageValidateLogin ( )
            {

            return "Wait while validate your credentials";
            }

        public static
        String PopupMessage_MessageDoLogin ( )
            {

            return "Wait while loading your login info";
            }


        public static
        String PopupMessage_MessageSyncAvatar ( )
            {

            return "Wait while loading your Avatar";
            }


        public static
        String PopupMessage_MessageSyncContact ( )
            {

            return "Wait while loading your Contacts list";
            }


        public static
        String PopupMessage_MessageSyncCategory ( )
            {

            return "Wait while loading your Cateogries";
            }


        public static
        String PopupMessage_MessageSyncGroup ( )
            {

            return "Wait while loading your Groups";
            }


        public static
        String PopupMessage_MessageShareImageSent ( )
            {

            return "Shared photo has been sent successfully";
            }


        public static
        String PopupMessage_MessageShareVideoSent ( )
            {

            return "Shared video has been sent successfully";
            }


        public static
        String PopupMessage_MessageGetEmailDefault ( )
            {

            return "You need to set your primary E-mail address first";
            }


        public static
        String PopupMessage_MessageCheckEmailDefault ( )
            {

            return "Make sure of your primary E-mail address";
            }

        public static
        String PopupMessage_MessageCheckPassword ( )
            {

            return "Make sure of your Password";
            }

        public static
        String PopupMessage_MessageUserOtherMobileNumber ( )
            {

            return "You can\'t add this mobile number, try another one";
            }

        public static
        String PopupMessage_MessageUserOtherEmailAddress ( )
            {

            return "You can\'t add this email address, try another one";
            }

        public static
        String PopupMessage_StartCallScreen ( )
            {

            return "Call screen";
            }

        public static
        String PopupMessage_DataSaved ( )
            {

            return "Data saved";
            }

        public static
        String PopupMessage_AutoChatMessage ( )
            {

            return "Invite chat message sent";
            }

        public static
        String PopupMessage_Dating_UserAccountSubscribeMessage ( )
            {

            return "Account Subscribe Message";
            }


        public static
        String PopupMessage_Dating_UserAccountUnsubscribeMessage ( )
            {

            return "Account Unsubscribe Message";
            }


        public static
        String PopupMessage_Dating_UserAccountDeleteMessage ( )
            {

            return "Account Delete Message";
            }


        public static
        String PopupMessage_Dating_AutoUserInviteMessage ( )
            {

            return "Sent invite to chat";
            }


        public static
        String PopupMessage_Dating_AutoUserMatchLikeMessage ( )
            {

            //return "You did Like :smile";
            //return ":like";
            return "You did like";
            }


        public static
        String PopupMessage_Dating_AutoUserMatchNotLikeMessage ( )
            {

            //return "You did unlike :sad";
            //return ":unlike";
            return "You did unlike";
            }


        public static
        String PopupMessage_Dating_AutoUserMatchMutualMessage ( )
            {

            //return ":heart";
            /*
                    return "You both likes each other";
            */
            return "You get matched";
            }


        public static
        class PopupMessage_Post
            {


            public static
            String PopupMessage_Post_Shared ( )
                {

                return "You\'ve shared a post";
                }

            public static
            String PopupMessage_Post_Sent ( )
                {

                return "You\'ve sent a post";
                }


            public static
            String PopupMessage_Post_Comment_Sent ( )
                {

                return "You\'ve sent a comment";
                }


            public static
            String PopupMessage_Post_New ( )
                {

                return "Shared a post";
                }

            public static
            String PopupMessage_Post_Avatar ( )
                {

                return "Changed avatar ";
                }

            public static
            String PopupMessage_Post_Birthday ( )
                {

                return "Happy birthday";
                }

            public static
            String PopupMessage_Post_Horoscope ( )
                {

                return "Daily horoscope";
                }


            public static
            String PopupMessage_Post_Like ( )
                {

                return "Liked post";
                }


            public static
            String PopupMessage_Post_Comment ( )
                {

                return "Commented on post";
                }

            public static
            String PopupMessage_Comment_Like ( )
                {

                return "Liked comment";
                }

            public static
            String PopupMessage_Comment_Reply ( )
                {

                return "Replied on comment";
                }

            public static
            String PopupMessage_Reply_Like ( )
                {

                return "Liked reply";
                }


            public static
            String PopupMessage_Attach_Comment ( )
                {

                return "Commented on attach";
                }

            public static
            String PopupMessage_Attach_Like ( )
                {

                return "Liked attach";
                }

            public static
            String PopupMessage_Post_Share ( )
                {

                return "Shared your post";
                }


            }


        public static
        class PopupMessage_InvitePopup
            {


            public static
            String PopupMessage_FriendAddRequest ( )
                {

                return "Contact request";
                }

            public static
            String PopupMessage_TrackRequest ( )
                {

                return "Asked to share your location";
                }

            public static
            String PopupMessage_TrackResponse ( String RequestDirection )
                {

                String strMessage = null;

                if ( RequestDirection.ToLower() == ( "in" ) )
                    {
                    strMessage = "Can now watch your location";
                    }
                else if ( RequestDirection.ToLower() ==  ( "out" ) )
                    {
                    strMessage = "Now, you can watch location";
                    }

                return strMessage;

                }

            public static
            String PopupMessage_FriendAddResponse ( )
                {

                return "Is now on your contacts";
                }


            public static
            String PopupMessage_FriendBirthday ( )
                {

                return "Birthday today";
                }


            public static
            String PopupMessage_FriendNewJoin ( )
                {

                return "Has joined Tlkn2";
                }

            public static
            String PopupMessage_FriendProfileUpdate ( )
                {

                return "Updated profile";
                }


            }


        public static
        class PopupMessage_ChatX
            {

            public static
            String PopupMessage_Chat_SuggestUserMax ( )
                {

                return "Can\'t sent more than 4 contact on one time";
                }

            public static
            String PopupMessage_Chat_OfflineMessage ( )
                {

                return "New messages waiting for you";
                }


            }


        public static
        class PopupMessage_Setting
            {

            public static
            String PopupMessage_Setting_Update ( )
                {

                return "Your setting has been updated successfully";
                }

            }


        public static
        class PopupMessage_Request
            {


            public static
            String PopupMessage_Request_Decline ( )
                {

                return "Are you sure want to decline request";
                }


            public static
            String PopupMessage_Request_ClearAll ( )
                {

                return "Are you sure want to clear all requests";
                }


            public static
            String PopupMessage_Request_Accept ( )
                {

                return "Are you sure want to accept request";
                }


            public static
            String PopupMessage_Request_Cancel ( )
                {

                //return "Are you sure want to cancel request";
                return "Are you sure want to cancel request";
                }

            public static
            String PopupMessage_Request_Sent ( )
                {

                return "Your request sent successfully";
                }

            }


        public static
        class PopupMessage_Random
            {


            public static
            String PopupMessage_Random_Start ( )
                {

                return "Click any square to play";
                }


            public static
            String PopupMessage_Random_Pick ( )
                {

                return "Click any square to pick a random user";
                }

            }

        public static
        class PopupMessage_Payment
            {


            public static
            String PopupMessage_Payment_Pending ( )
                {

                return "Payment pending";
                }


            public static
            String PopupMessage_Payment_Succeed ( )
                {

                return "Payment succeeded";
                }

            public static
            String PopupMessage_Payment_Fail ( )
                {

                return "Payment failed";
                }

            public static
            String PopupMessage_Payment_Cancel ( )
                {

                return "Payment cancelled";
                }

            }


        public static
        class PopupMessage_Paypal
            {


            public static
            String PopupMessage_Paypal_Connect_True ( )
                {

                return "Paypal account connected successfully";
                }


            public static
            String PopupMessage_Paypal_Connect_False ( )
                {

                return "Paypal account couldn\'t connected";
                }

            /*
              public static
              String PopupMessage_Payment_Fail() {

                  return "Payment failed";
              }

              public static
              String PopupMessage_Payment_Cancel() {

                  return "Payment cancelled";
              }
              */
            }

        public static
        class PopupMessage_ChatMessage
            {


            public static
            String PopupMessage_ChatMessage_Delete ( )
                {

                return "Are you sure want to delete this message";
                }

            public static
            String PopupMessage_ChatMessage_Delete ( String MessageCount )
                {

                if ( MessageCount.ToLower() ==  ( "1" ) )
                    {
                    return "Are you sure want to delete this message";
                    }
                return "Are you sure want to delete (" + MessageCount + ") messages";

                }


            /*
                    public static String PopupMessage_Random_Pick() {

                        return "Click any square to pick a random user";
                    }
            */

            }


        public static
        class PopupMessage_ChatterList
            {


            public static
            String PopupMessage_ChatterList_Remove ( )
                {

                return "Are you sure want to remove users from chat";
                }


            /*
                    public static String PopupMessage_Random_Pick() {

                        return "Click any square to pick a random user";
                    }
            */

            }


        public static
        class PopupMessage_Broadcast
            {


            public static
            String PopupMessage_Broadcast_Favorite_ClearAll ( )
                {

                return "Are you sure want to clear all connections";
                }

            public static
            String PopupMessage_Broadcast_History_ClearAll ( )
                {

                return "Are you sure want to clear all history";
                }


            public static
            String PopupMessage_Request_ClearAll ( )
                {

                return "Are you sure want to clear all requests";
                }


            public static
            String PopupMessage_Request_Accept ( )
                {

                return "Are you sure want to accept request";
                }


            public static
            String PopupMessage_Request_Cancel ( )
                {

                //return "Are you sure want to cancel request";
                return "Are you sure want to cancel request";
                }

            public static
            String PopupMessage_Request_Sent ( )
                {

                return "Your request sent successfully";
                }

            }


        public static
        class PopupMessage_PrivateShow
            {

            public static
            String PopupMessage_PrivateShow_Call_Request ( )
                {

                return "Will be notified 30 seconds before the live call takes place";
                }

            public static
            String PopupMessage_PrivateShow_Record_Owner_Request_Sent ( )
                {

                return "Requested recording has been sent";
                }

            public static
            String PopupMessage_PrivateShow_Record_Remote_Accept ( )
                {

                return "Requested recording has been accepted";
                }

            public static
            String PopupMessage_PrivateShow_Record_Remote_Decline ( )
                {

                return "Requested recording has been declined";
                }

            public static
            String PopupMessage_PrivateShow_ExtendTime_Remote_Accept ( )
                {

                return "Session time has been extended";
                }

            public static
            String PopupMessage_PrivateShow_Invite_Cancel ( )
                {

                return "Are you sure want to cancel request";
                }


            }


        public static
        class PopupMessage_Token
            {

            public static
            String MessageText_Token_Needed ( )
                {

                return "You need to purchase more credits to continue";
                }


            public static
            String MessageText_Token_Transfer_Minimum ( )
                {

                return "Can't sent less then 2 tokens";
                }


            public static
            String MessageText_Token_Transfer_Maximum ( )
                {

                return "Can't sent more than 1000 tokens";
                }


            public static
            String MessageText_Token_Transfer_Sent ( )
                {

                return "You\'ve successfully sent tokens";
                }


            public static
            String MessageText_Token_Earn ( )
                {

                return "Click to collect a reward";
                }


            public static
            String MessageText_Token_Transfer_Received ( )
                {

                return "Gifted you tokens";

                }


            public static
            String MessageText_Token_Transfer_You_Accept ( )
                {

                return "You accepted a gift of tokens";

                }


            public static
            String MessageText_Token_Transfer_You_Decline ( )
                {

                return "You declined a gift of tokens";

                }

            public static
            String MessageText_Token_Transfer_Received (
                    String TokenAmount ,
                    Boolean blnShowAmount )
                {

                if ( blnShowAmount == true )
                    {
                    return "You\'ve just earned " + TokenAmount + " extra tokens click to accept";
                    }
                else
                    {
                    return "You\'ve just earned extra tokens click to accept";
                    }

                }


            public static
            String MessageText_Token_Transfer_Accept ( )
                {

                return "Has accepted your gift, thank you";
                }


            public static
            String MessageText_Token_NoCredit_WaitRemoteTextFirst ( )
                {
                /*
                            String FirstName*/
                //  return "You are out of tokens, please wait for " + FirstName + " to reply before
                //  you can text again";
                return "You are out of tokens, please wait for a reply before you can text again";
                }


            public static
            String MessageText_Token_Transfer_Decline ( )
                {

                return "Has declined your gift";
                }


            }


        public static
        class PopupMessage_History
            {

            public static
            String PopupMessage_History_ClearAll ( )
                {

                return "Are you sure want to clear all history";
                }

            public static
            String PopupMessage_History_DeleteOne ( int intCount )
                {

                // return "Are you sure want to clear all history";
                if ( intCount <= 1 )
                    {
                    return "Are you sure you want to delete all history with this group!";
                    }
                else
                    {
                    return "Are you sure you want to delete all history with [" +  
                            intCount.ToString() + "] groups!";
                    }
                }


            public static
            String PopupMessage_Token_Needed ( )
                {

                return "You need to purchase more credits to continue";
                }


            public static
            String PopupMessage_Token_Transfer_Minimum ( )
                {

                return "Can't sent less then 2 tokens";
                }


            public static
            String PopupMessage_Token_Transfer_Maximum ( )
                {

                return "Can't sent more than 1000 tokens";
                }


            public static
            String PopupMessage_Token_Transfer_Sent ( )
                {

                return "You\'ve successfully sent tokens";
                }

            }


        public static
        class PopupMessage_Chat
            {

            public static
            String PopupMessage_Chat_SuggestUserMax ( )
                {

                return "Can\'t sent more than 4 contact on one time";
                }

            public static
            String PopupMessage_Chat_OfflineMessage ( )
                {

                return "New messages waiting for you";
                }


            public static
            String PopupMessage_Chat_ClearAll ( )
                {

                return "Are you sure want to clear all chat";
                }


            public static
            String PopupMessage_Chat_DeleteOne ( int intCount )
                {

                // return "Are you sure want to clear all Chat";
                if ( intCount <= 1 )
                    {
                    return "Are you sure you want to delete all Chat with this group!";
                    }
                else
                    {
                    return "Are you sure you want to delete all Chat with [" +  
                            intCount.ToString ( ) + "] groups!";
                    }
                }


            public static
            String PopupMessage_Token_Needed ( )
                {

                return "You need to purchase more credits to continue";
                }


            public static
            String PopupMessage_Token_Transfer_Minimum ( )
                {

                return "Can't sent less then 2 tokens";
                }


            public static
            String PopupMessage_Token_Transfer_Maximum ( )
                {

                return "Can't sent more than 1000 tokens";
                }


            public static
            String PopupMessage_Token_Transfer_Sent ( )
                {

                return "You\'ve successfully sent tokens";
                }

            }


        public static
        class PopupMessage_BlackList
            {

            public static
            String PopupMessage_BlackList_ClearAll ( )
                {

                return "Are you sure to clear all!";
                }


            public static
            String PopupMessage_BlackList_UnBlockAll ( )
                {

                return "Are you sure to unblock all!";
                }

            public static
            String PopupMessage_BlackList_DeleteOne ( int intCount )
                {

                // return "Are you sure want to clear all BlackList";
                if ( intCount <= 1 )
                    {
                    return "Are you sure you want to delete all BlackList with this group!";
                    }
                else
                    {
                    return "Are you sure you want to delete all BlackList with [" + 
                            intCount.ToString ( ) + "] groups!";
                    }
                }

            /*
                public static
                String PopupMessage_Token_Needed() {

                    return "You need to purchase more credits to continue";
                }
                */


            }


        public static
        class PopupMessage_Contact
            {

            /* public static
             String PopupMessage_Category_MaxCount() {

                 return "Can\'t have more than 15 Categories";
             }
           */

            public static
            String PopupMessage_Contact_Delete ( )
                {

                return "Permanently delete contact";
                }


            public static
            String PopupMessage_Contact_LoginStatus_Online ( )
                {

                return "Is online";
                }


            public static
            String PopupMessage_Contact_LoginStatus_Offline ( )
                {

                return "Is offline";
                }


            }


        public static
        class PopupMessage_Category
            {

            public static
            String PopupMessage_Category_MaxCount ( )
                {

                return "Can\'t have more than 15 Categories";
                }

            public static
            String PopupMessage_Category_Delete ( )
                {

                return "Permanently delete category";
                }


            }


        public static
        class PopupMessage_Group
            {


            public static
            String PopupMessage_Group_DeleteOne ( int intCount )
                {

                // return "Are you sure want to clear all history";
                if ( intCount <= 1 )
                    {
                    return "Are you sure you want to delete this group!";
                    }
                else
                    {
                    return "Are you sure you want to delete all [" +  intCount.ToString ( ) + "]"
                           + " groups!";
                    }
                }

            public static
            String PopupMessage_Group_MaxCount ( )
                {

                return "Can\'t have more than 30 groups in a category";
                }

            public static
            String PopupMessage_Group_Delete ( )
                {

                return "Permanently delete category";
                }


            }


        public static
        class PopupMessage_Avatar
            {


            public static
            String PopupMessage_Avatar_MustSetAvatar ( )
                {

                return "You must set your avatar first";
                }

            public static
            String PopupMessage_Avatar_Delete ( )
                {

                return "Are you sure want to remove your avatar";
                }


            }



        public static
        class PopupMessage_Sound
            {


            public static
            String PopupMessage_Sound_ResetAll ( )
                {

                return "Are you sure want to reset all sounds";
                }


            }


        public static
        class PopupMessage_Profile
            {

            /*   public static
               String PopupMessage_EmailAddress_CheckDefault() {

                   return "Make sure of your primary E-mail address";
               }
       */
            public static
            String PopupMessage_Profile_Update ( )
                {

                return "Your account has been updated successfully";
                }


            }


        public static
        class PopupMessage_EmailAddress
            {

            public static
            String PopupMessage_EmailAddress_CheckDefault ( )
                {

                return "Make sure of your primary E-mail address";
                }

            public static
            String PopupMessage_EmailAddress_Update ( )
                {

                return "Your E-mail address has been updated successfully";
                }


            public static
            String PopupMessage_EmailAddress_SendVerify ( )
                {

                return "Send email to verify this E-mail address";
                }


            }


        public static
        class PopupMessage_Email
            {

            public static
            String PopupMessage_Email_Sent ( )
                {

                return "Email has been sent to you";
                }
            /*
              public static
              String PopupMessage_EmailAddress_Update() {

                  return "Your E-mail address has been updated successfully";
              }


              public static
              String PopupMessage_EmailAddress_SendVerify() {

                  return "Send email to verify this E-mail address";
              }*/


            }

        public static
        class PopupMessage_Forum
            {

            public static
            String PopupMessage_Forum_Post_Create_New ( )
                {

                return "Your post created successfully";
                }

            public static
          String PopupMessage_Forum_Post_Update ( )
                {

                return "Your post updated successfully";
                }

            public static
            String PopupMessage_Forum_Post_Delete ( )
                {

                return "Are you sure want to delete?";
                }
            /*
              public static
              String PopupMessage_EmailAddress_Update() {

                  return "Your E-mail address has been updated successfully";
              }


              public static
              String PopupMessage_EmailAddress_SendVerify() {

                  return "Send email to verify this E-mail address";
              }*/


            }

        public static
        class PopupMessage_DatePicker
            {

            public static
            String PopupMessage_DatePicker_BirthDate ( )
                {

                return "Pick up a Birth Date!";
                }


            public static
                 String PopupMessage_DatePicker_TestDate ( )
                {

                return "Pick up a Test Date!";
                }


            public static
                 String PopupMessage_DatePicker_ExpireDate ( )
                {

                return "Pick up an Expire Date!";
                }



            }


        public static
        class PopupMessage_SelectPicker
            {

            public static
            String PopupMessage_SelectPicker_Qualification ( )
                {

                return "Select a Qualification!";
                }


            /* public static
                  String PopupMessage_DatePicker_TestDate ( ) {

                      return "Pick up your test date!";
                  }


             public static
                  String PopupMessage_DatePicker_ExpireDate ( ) {

                      return "Pick up your expire date!";
                  }
          */


            }


        public static
        class PopupMessage_MobileNumber
            {

            public static
            String PopupMessage_MobileNumber_IsExist ( )
                {

                return "Can't register with this Mobile Number";
                }

            public static
            String PopupMessage_MobileNumber_Update ( )
                {

                return "Your mobile number has been updated successfully";
                }


            public static
            String PopupMessage_MobileNumber_NotAvailable ( )
                {

                return "Can\'t register with this number!";
                }

            public static
            String PopupMessage_MobileNumber_NotLogin ( )
                {

                return "Can\'t login with this account!";
                }

            public static
            String PopupMessage_MobileNumber_NotValid ( )
                {

                return "NOT_A_NUMBER. The string supplied did not seem to be a phone number!";
                }

            public static
            String PopupMessage_MobileNumber_RegisterVerify ( )
                {

                return "Waiting for SMS verification\nThis could take a moment, please be patient, "
                       + "we'll notify you when verification is complete.";
                }


            }


        public static
        class PopupMessage_Password
            {

            public static
            String PopupMessage_Password_NotMatch ( )
                {

                return "Your pass code NOT match";
                }

            public static
            String PopupMessage_Password_Update ( )
                {

                return "Your pass code has been updates successfully";
                }

            public static
            String PopupMessage_Password_Wrong ( )
                {

                return "Your passcode mismatch";
                }


            }


        public static
        class PopupMessage_Gallery
            {

            public static
            String PopupMessage_Gallery_ClearOne ( )
                {

                return "Are you sure want to remove item";
                }

            public static
            String PopupMessage_Gallery_ClearSome ( )
                {

                return "Are you sure want to clear all selected";
                }

            public static
            String PopupMessage_Gallery_ClearAll ( )
                {

                return "Are you sure want to clear all gallery";
                }

            public static
            String PopupMessage_Gallery_Deleted ( )
                {

                return "Deleted successfully";
                }

            public static
            String PopupMessage_Gallery_SavedToDevice ( )
                {

                return "Image has been saved successfully";
                }

            public static
            String PopupMessage_Gallery_Being_SavedToDevice ( )
                {

                return "Saving into gallery";
                }


            public static
            String PopupMessage_Gallery_SetAvatar ( )
                {

                return "Image is now your avatar";
                }

            public static
            String PopupMessage_Gallery_StartSave ( )
                {

                return "Start downloading this";
                }

            public static
            String PopupMessage_Gallery_NoSave ( )
                {

                return "Sorry, Can\'t save this";
                }

            public static
            String PopupMessage_Gallery_WaitUpload ( )
                {

                return "Wait till another upload finishing";
                }


            public static
            String PopupMessage_Gallery_ReachMax ( )
                {

                return "Your gallery is full !";
                }


            public static
            String PopupMessage_Gallery_Shared ( )
                {

                return "Gallery has been shared successfully";
                }

            public static
            String PopupMessage_Gallery_SaveChanges ( )
                {

                return "Do you want save changes ? ";
                }

            }


        public static
        class PopupMessage_Shortcut
            {

            public static
            String PopupMessage_Shortcut_NoPinAction ( )
                {

                return "You can\'t remove this pin shortcut";
                }

            public static
            String PopupMessage_Shortcut_AddNewAction ( )
                {

                return "Pin shortcut has been added successfully";
                }

            public static
            String PopupMessage_Shortcut_DeleteAction ( )
                {

                return "Pin shortcut has been removed successfully";
                }


            }

        public static
        class PopupMessage_Theme
            {

            public static
            String PopupMessage_Theme_NotAllowColor ( )
                {

                return "You can\'t apply this theme color";
                }


            }


        public static
        class PopupMessage_Event
            {

            public static
            String PopupMessage_Event_DeleteOne ( )
                {

                return "Are you sure want to delete event";
                }


            public static
            String PopupMessage_Event_Time_EndLessThanStart ( )
                {

                return "Event\'s end time less than start time";
                }

            public static
            String PopupMessage_Event_Time_StartLessThanCurrent ( )
                {

                return "Event\'s start time less than current time";
                }


            public static
            String PopupMessage_Event_TimeStartSetup ( )
                {

                return "Fill in Event\'s start date & time";
                }

            public static
            String PopupMessage_Event_TimeEndSetup ( )
                {

                return "Fill in Event\'s end date & time";
                }

            public static
            String PopupMessage_Event_LocationSetup ( )
                {

                return "Fill in Event\'s location";
                }


            }

        public static
        class PopupMessage_Shop
            {

            public static
            String PopupMessage_Wallpaper_UploadNeeded ( )
                {

                return "Please upload your wallpaper image";
                }

            public static
            String PopupMessage_PickCategory ( )
                {

                return "Please pick a category";
                }


            public static
            String PopupMessage_Shop_Confirm_ItemDelete ( )
                {

                return "Are you sure want to delete";
                }

            public static
            String PopupMessage_Shop_Confirm_ItemUnistall ( )
                {

                return "Are you sure want to unistall";
                }

            public static
            String PopupMessage_Shop_Wait_Approval ( )
                {

                return "Your wallpaper set is waiting for approval from Tlkn2 admin";
                }

            public static
            String PopupMessage_Shop_Start_New ( )
                {

                return "Start uploading your new wallpaper to Tlkn2 shop";
                }

            public static
            String PopupMessage_Sticker_UploadNeeded ( )
                {

                return "Please upload your sticker image";
                }


            public static
            String PopupMessage_Event_TimeSetPass ( )
                {

                return "Event\'s end time less than start time";
                }


            public static
            String PopupMessage_Event_TimeStartSetup ( )
                {

                return "Fill in Event\'s start date & time";
                }

            public static
            String PopupMessage_Event_TimeEndSetup ( )
                {

                return "Fill in Event\'s end date & time";
                }

            public static
            String PopupMessage_Event_LocationSetup ( )
                {

                return "Fill in Event\'s location";
                }


            }


        public static
        class PopupMessage_Register
            {


            public static
            String PopupMessage_Register_Create_New ( )
                {

                return "Wait while creating your new account";
                }


            /* public static
             String PopupMessage_Event_Time_EndLessThanStart() {

                 return "Event\'s end time less than start time";
             }


             public static
             String PopupMessage_Event_TimeStartSetup() {

                 return "Fill in Event\'s start date & time";
             }

             public static
             String PopupMessage_Event_TimeEndSetup() {

                 return "Fill in Event\'s end date & time";
             }
               public static
             String PopupMessage_Event_LocationSetup() {

                 return "Fill in Event\'s location";
             }*/


            }


        public static
        class PopupMessage_Account
            {

            public static
            String PopupMessage_Account_Delete ( )
                {

                return "Are you sure want to delete account";
                }


            /* public static
             String PopupMessage_Event_Time_EndLessThanStart() {

                 return "Event\'s end time less than start time";
             }


             public static
             String PopupMessage_Event_TimeStartSetup() {

                 return "Fill in Event\'s start date & time";
             }

             public static
             String PopupMessage_Event_TimeEndSetup() {

                 return "Fill in Event\'s end date & time";
             }
               public static
             String PopupMessage_Event_LocationSetup() {

                 return "Fill in Event\'s location";
             }*/


            }


        public static
        class PopupMessage_Application
            {

            /*
                    public static
                    String PopupMessage_Application_BackToExit() {

                        return "Please click BACK again to exit";
                    }
            */


            /* public static
             String PopupMessage_Event_Time_EndLessThanStart() {

                 return "Event\'s end time less than start time";
             }


             public static
             String PopupMessage_Event_TimeStartSetup() {

                 return "Fill in Event\'s start date & time";
             }

             public static
             String PopupMessage_Event_TimeEndSetup() {

                 return "Fill in Event\'s end date & time";
             }
               public static
             String PopupMessage_Event_LocationSetup() {

                 return "Fill in Event\'s location";
             }*/


            }


        public static
        class PopupMessage_ScreenChatShow
            {

            public static
            String PopupMessage_ScreenChatShow_UserNotAdmin ( )
                {

                return "You don\'t have permission for this action";
                }

            /*
                    public static
                    String PopupMessage_Password_Update() {

                        return "Your pass code has been updates successfully";
                    }
            */


            }


        public static
        class PopupMessage_Admin
            {

            public static
            String PopupMessage_UserNotAdmin ( )
                {

                return "You don\'t have permission for this action";
                }

            /*
                    public static
                    String PopupMessage_Password_Update() {

                        return "Your pass code has been updates successfully";
                    }
            */


            }

        public static
        class PopupMessage_GenericNotification
            {

            public static
            String PopupMessage_LoadMore ( )
                {

                return " Load more ";
                }

            public static
            String PopupMessage_BackToExit ( )
                {

                return "Please click BACK again to exit";
                }

            /*
                    public static
                    String PopupMessage_Password_Update() {

                        return "Your pass code has been updates successfully";
                    }
            */


            }


        public static
        class PopupMessage_Invoice
            {

            public static
            String PopupMessage_Invoice_Request_MiniAmount ( )
                {

                return "Minimum amount $ 5.00 to request money";
                }

            public static
            String PopupMessage_Invoice_Request_Submit ( )
                {

                return "Your money request sent successfully";
                }

            /*
                    public static
                    String PopupMessage_Password_Update() {

                        return "Your pass code has been updates successfully";
                    }
            */


            }


        public static
        class PopupMessage_File
            {

            public static
            String PopupMessage_File_NotOpened ( )
                {

                return "Can\'t open this file";
                }
            public static
                   String PopupMessage_File_Pickup ( )
                {

                return "Pickup a file";
                }

            public static
            String PopupMessage_File_Uploading ( )
                {

                return "Uploading ...";
                }

            public static
            String PopupMessage_File_Uploaded ( )
                {

                return "Uploaded";
                }

            public static
            String PopupMessage_File_Downloading ( )
                {

                return "Downloading ...";
                }

            public static
            String PopupMessage_File_Downloaded ( )
                {

                return "Downloaded";
                }

            /*
                    public static
                    String PopupMessage_Password_Update() {

                        return "Your pass code has been updates successfully";
                    }
            */


            }


        public static
        class PopupMessage_DocumentForm
            {

            public static
            String PopupMessage_DocumentForm_Check_SignAllFormFirst ( )
                {

                return "Fill in all forms first!";
                }


            public static
            String PopupMessage_DocumentForm_Open_TryLater ( )
                {

                return "Something wrong, try another time!";
                }

            /*  public static
              String PopupMessage_File_Uploading ( ) {

                  return "Uploading ...";
              }

              public static
              String PopupMessage_File_Uploaded ( ) {

                  return "Uploaded";
              }

              public static
              String PopupMessage_File_Downloading ( ) {

                  return "Downloading ...";
              }

              public static
              String PopupMessage_File_Downloaded ( ) {

                  return "Downloaded";
              }
      */
            /*
                    public static
                    String PopupMessage_Password_Update() {

                        return "Your pass code has been updates successfully";
                    }
            */


            }


        public static
        class PopupMessage_Location
            {

            public static
            String PopupMessage_Location_MyPlaces_ClearAll ( )
                {

                return "Are you sure want to clear all places";
                }


            public static
            String PopupMessage_Location_Save ( )
                {

                return "Location saved successfully";
                }

            public static
            String PopupMessage_Location_Employee_Remote_InTrack ( )
                {

                return "Pay attention please, keep a minimum of 2 metres apart";
                }

            /*
                    public static
                    String PopupMessage_Password_Update() {

                        return "Your pass code has been updates successfully";
                    }
            */


            }


        public static
        class PopupMessage_Subscribe
            {

            public static
            String PopupMessage_Subscribe_Confirm_YES ( )
                {

                return "Are you sure want to Subscribe";
                }

            public static
            String PopupMessage_Subscribe_Confirm_NO ( )
                {

                return "Are you sure want to Un-Subscribe";
                }


            public static
            String PopupMessage_Location_Save ( )
                {

                return "Location saved successfully";
                }

            /*
                    public static
                    String PopupMessage_Password_Update() {

                        return "Your pass code has been updates successfully";
                    }
            */


            }


        public static
        class PopupMessageLogistics_ProjectDelivery
            {

            public static
            String PopupMessage_Logistics_ProjectDelivery_Zone_LiveList ( )
                {

                return "Active vehicles in selected zone - ";
                }


            /*   public static
               String PopupMessage_Location_Save ( ) {

                   return "Location saved successfully";
               }

               public static
               String PopupMessage_Location_Employee_Remote_InTrack ( ) {

                   return "Pay attention please, keep a minimum of 2 metres apart" ;
               }*/

            /*
                    public static
                    String PopupMessage_Password_Update() {

                        return "Your pass code has been updates successfully";
                    }
            */


            }


        public static
        class PopupMessage_SearchFilter
            {

            public static
            String PopupMessage_SearchFilter_ID ( )
                {

                return "Fill in Booking ID!";
                }


            public static
            String PopupMessage_SearchFilter_FillIn ( )
                {

                return "Fill in Search criteria!";
                }



            public static
                 String PopupMessage_SearchFilter_FillDate ( )
                {

                return "Fill in Search Start & End Dates!";
                }

            /* public static
               String PopupMessage_Subscribe_Confirm_NO() {

                   return "Are you sure want to Un-Subscribe";
               }




               public static
               String PopupMessage_Location_Save() {

                   return "Location saved successfully";
               }*/

            /*
                    public static
                    String PopupMessage_Password_Update() {

                        return "Your pass code has been updates successfully";
                    }
            */


            }


        public static
        class PopupMessage_Clipboard
            {

            public static
            String PopupMessage_Clipboard_Copy ( )
                {

                return "Copied to clipboard";
                }

            /* public static
               String PopupMessage_Subscribe_Confirm_NO() {

                   return "Are you sure want to Un-Subscribe";
               }




               public static
               String PopupMessage_Location_Save() {

                   return "Location saved successfully";
               }*/

            /*
                    public static
                    String PopupMessage_Password_Update() {

                        return "Your pass code has been updates successfully";
                    }
            */


            }





        public static
        class PopupMessage_Generic
            {

            public static
            String PopupMessage_Generic_Create_New ( )
                {

                return "Your post created successfully";
                }

            public static
            String PopupMessage_Generic_Update ( )
                {

                return "Your post updated successfully";
                }

            public static
            String PopupMessage_Generic_Delete ( )
                {

                return "Are you sure want to delete?";
                }
            /*
              public static
              String PopupMessage_EmailAddress_Update() {

                  return "Your E-mail address has been updated successfully";
              }


              public static
              String PopupMessage_EmailAddress_SendVerify() {

                  return "Send email to verify this E-mail address";
              }*/


            }



        }
    }
