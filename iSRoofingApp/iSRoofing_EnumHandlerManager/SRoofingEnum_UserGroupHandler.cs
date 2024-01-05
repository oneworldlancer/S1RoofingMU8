using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_EnumHandlerManager
{
    class SRoofingEnum_UserGroupHandler
    {


        public static int GetGroupIDByChatToUserID = 301;
        public static int GetGroupIDByChatToListUserID = 302;
        public static int CreateGroupCode = 303;
        public static int GetGroupIDByGroupCode = 304;
        public static int GetGroupIsDatingTypeByGroupID = 305;

        public static int GetGroupIDByChatToListUserID_WithAutoLogin_OriginalUser = 306;

        public static int GetRemoteUserIDByGroupID = 401;
        public static int GetRemoteMobileNumberIDByGroupID = 402;

        public static int InitializeGroupIDToUserID = 501;
        public static int InitializeGroupIDToListUserID = 502;


        public static string Initialize_UserGroup_Project_ByGroupTokenID = "503";

        public static string Initialize_UserGroup_Delivery_ByGroupTokenID = "504";


        public static string Initialize_UserGroup_Private_ByGroupTokenID = "505";



        public static string Initialize_UserGroup_Group_ByGroupTokenID = "506";


        public static string Initialize_UserGroup_New_CREATE_Group_ByOwnerUserTokenID = "507";




        public static string UserGroup_Add_Group_To_Category_ByCategoryTokenID = "508";



        public static string UserGroup_User_ADD_To_Group_ByGroupTokenID = "510";
        public static string UserGroup_User_REMOVE_From_Group_ByGroupTokenID = "511";


        //public static  int Verify_RegisterInvitation_IsNotRegister = 102;

    }
}
