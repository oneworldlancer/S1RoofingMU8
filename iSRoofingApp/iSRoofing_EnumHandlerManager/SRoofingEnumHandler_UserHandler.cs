using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_EnumHandlerManager
{
    class SRoofingEnumHandler_UserHandler
        {

        public static  int CheckUserExistByMobileNumber = 101;
        public static  int CheckUserExistByEmailAddress = 102;

        public static  int GetUserIDByUserMobileNumberE164 = 103;
        public static  int GetUserSessionIDByUserID = 104;
        public static  int GetUserMobileNumberIDByMobileNumberE164 = 105;
        public static  int Get_UserPassword_ByUserID = 106;

        public static  int GetUserLoginStatus = 201;
        public static  int GetUserVisibleStatus = 202;
        public static  int GetUser_VisibleStatus_GMTOnlineTime = 2022;

        public static  int UpdateUserVisibleStatus = 203;
        public static  int GetUserOnlineTime = 204;

        public static  int GetUserYouTubeChannelID = 205;
        public static  int GetUserTicket = 206;

        public static  int Dating_CheckUserMatchIsLikeMe = 207;
        public static  int Dating_CheckUserMatchIsMutual = 208;


        public static  int DatingGallery_GetImageList = 401;
        public static  int UserAvatar_GetDefaultImageID = 402;
        public static  int DatingGallery_GetDefaultDatingImageID = 403;

        public static  int GetUserRoleByAccountType = 500;

        public static  int Get_UserAvatar_ImageURL_ByAccountType = 600;


        public static  int Get_UserTokenID_ByEmailAddress = 700;

        public static  int Get_MobileNumberTokenID_ByEmailAddress = 710;

        public static  int Get_MobileNumberE164_ByEmailAddress = 715;


        //public static  int Verify_RegisterInvitation_IsNotRegister = 102;

        }
    }
