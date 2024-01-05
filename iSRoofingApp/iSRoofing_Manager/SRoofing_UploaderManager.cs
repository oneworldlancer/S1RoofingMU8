using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumHandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_HandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;

 
using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_UploaderManager
    {




        async public static Task<string> Initialize_UserGroup_Private_ByGroupTokenID (

    Application _context ,
    string iAccountType ,
    SRoofingUserOwnerModelManager iOwnerModel ,
     string ToUserTokenID ,
    string ToMobileNumberTokenID )
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse (

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserGroupHandler.ashx?"

                        + "acctyp=" + iAccountType

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&tuid=" + ToUserTokenID
                        + "&tmobid=" + ToMobileNumberTokenID

                        + "&grpid=" + "0"
                        + "&grptyp=" + SRoofingEnum_GroupType.GroupType_PRIVATE

                        + "&projid=" + "0"
                        + "&bktknid=" + "0"

                        + "&fprojrolcod=" + "0"
                        + "&tprojrolcod=" + "0"

                        + "&isadmin=" + "0"

                        + "&req=" + SRoofingEnum_UserGroupHandler.Initialize_UserGroup_Private_ByGroupTokenID );


                return strResult;


          
            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return "0";
            }
        }



        


        async public static Task<string> Initialize_UserGroup_New_CREATE_Group_ByOwnerUserTokenID (

    Application _context ,
    string iAccountType ,
    SRoofingUserOwnerModelManager iOwnerModel ,
     string GroupTokenID , 
     string GroupTitle  )
        {

            try
            {


                var strResult = "0";

                //////strResult = await SRoofing_HandlerManager.Handler_GetResponse (

                //////        App.SiteDomainURL + "_iWebHandler"
                //////        + "/SRoofing_UserGroupHandler.ashx?"

                //////        + "acctyp=" + iAccountType

                //////        + "&uid=" + iOwnerModel.OwnerUserTokenID
                //////        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                //////        + "&tuid=" + "0"
                //////        + "&tmobid=" +   "0"

                //////        + "&grpid=" + GroupTokenID
                //////        + "&grptit=" +   HttpUtility.HtmlDecode(GroupTitle) 
                //////        + "&grptyp=" + SRoofingEnum_GroupType.GroupType_GROUP

                //////        + "&projid=" + "0"
                //////        + "&bktknid=" + "0"

                //////        + "&fprojrolcod=" + "0"
                //////        + "&tprojrolcod=" + "0"

                //////        + "&isadmin=" + "0"

                //////        + "&req=" + SRoofingEnum_UserGroupHandler.Initialize_UserGroup_New_CREATE_Group_ByOwnerUserTokenID );


                return strResult;


          
            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return "0";
            }
        }



        


        async public static Task<string> SRoofing_UserGroup_ADD_User_To_Group_ByGroupTokenID (

    Application _context ,
    string iAccountType ,
    SRoofingUserOwnerModelManager iOwnerModel ,
     string GroupTokenID ,
     string GroupTitle ,
     string ToUserTokenID ,
    string ToMobileNumberTokenID )
        {

            try
            {


                var strResult = "0";

                //////strResult = await SRoofing_HandlerManager.Handler_GetResponse (

                //////        App.SiteDomainURL + "_iWebHandler"
                //////        + "/SRoofing_UserGroupHandler.ashx?"

                //////        + "acctyp=" + iAccountType

                //////        + "&uid=" + iOwnerModel.OwnerUserTokenID
                //////        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                //////        + "&tuid=" + ToUserTokenID
                //////        + "&tmobid=" + ToMobileNumberTokenID


                //////        + "&grpid=" + GroupTokenID
                //////        + "&grptit=" + HttpUtility.HtmlDecode ( GroupTitle )
                //////        + "&grptyp=" + SRoofingEnum_GroupType.GroupType_GROUP

                //////        + "&projid=" + "0"
                //////        + "&bktknid=" + "0"

                //////        + "&fprojrolcod=" + "0"
                //////        + "&tprojrolcod=" + "0"

                //////        + "&isadmin=" + "0"

                //////        + "&req=" + SRoofingEnum_UserGroupHandler.UserGroup_User_ADD_To_Group_ByGroupTokenID );


                return strResult;



          
            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return "0";
            }
        }



        


        async public static Task<string> UserGroup_User_REMOVE_From_Group_ByGroupTokenID (

    Application _context ,
    string iAccountType ,
    SRoofingUserOwnerModelManager iOwnerModel ,
     string GroupTokenID ,
     string ToUserTokenID ,
    string ToMobileNumberTokenID )
        {

            try
            {


                var strResult = "0";

                //////strResult = await SRoofing_HandlerManager.Handler_GetResponse (

                //////        App.SiteDomainURL + "_iWebHandler"
                //////        + "/SRoofing_UserGroupHandler.ashx?"

                //////        + "acctyp=" + iAccountType

                //////        + "&uid=" + iOwnerModel.OwnerUserTokenID
                //////        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                //////        + "&tuid=" + ToUserTokenID
                //////        + "&tmobid=" + ToMobileNumberTokenID

                //////        + "&grpid=" + GroupTokenID
                //////        + "&grptyp=" + SRoofingEnum_GroupType.GroupType_GROUP

                //////        + "&projid=" + "0"
                //////        + "&bktknid=" + "0"

                //////        + "&fprojrolcod=" + "0"
                //////        + "&tprojrolcod=" + "0"

                //////        + "&isadmin=" + "0"

                //////        + "&req=" + SRoofingEnum_UserGroupHandler.UserGroup_User_REMOVE_From_Group_ByGroupTokenID );


                return strResult;


          
            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return "0";
            }
        }







        // UserProfile_Get_Owner_Profile_ByAccountType
        public static async Task<SRoofingUserGroupModelManager> SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID (
           Application context ,
                SRoofingUserOwnerModelManager iOwnerModel ,
               string GroupTokenID )
        {

            try
            {

                ObservableCollection<SRoofingUserGroupModelManager> arr_ItemList = new ObservableCollection<SRoofingUserGroupModelManager> ( );


                arr_ItemList = await App.svcSRoofing_UserGroupWS
     .SRoofing_XFMobile_UserGroup_Get_Group_ByGroupTokenIDWSAsync (

                                             App.iPlatformOS ,
                    App.iDatabaseServerTokenID ,
    Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
    App.iAccountType ,
    iOwnerModel.OwnerUserTokenID ,
    iOwnerModel.OwnerMobileNumberTokenID ,
     GroupTokenID );


                if ( arr_ItemList != null )
                {
                     await SRoofingSync_UserGroupManager.Sync_User_Group_Set_UserModel (
                                      context ,
                                      iOwnerModel ,
                                      arr_ItemList[ 0 ] );

                }


                return arr_ItemList[ 0 ];


            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }



        public static async Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserCategory_Get_GroupList_ByCategoryTokenIDWS (
       Application context ,
            SRoofingUserOwnerModelManager iOwnerModel ,
           string CategoryTokenID ,
           string CategoryTitle )
        {

            try
            {

                ObservableCollection<SRoofingUserGroupModelManager> arr_ItemList = new ObservableCollection<SRoofingUserGroupModelManager> ( );


                arr_ItemList = await App.svcSRoofing_UserGroupWS
      .SRoofing_XFMobile_UserCategory_Get_GroupList_ByCategoryTokenIDWSAsync (

                                              App.iPlatformOS ,
                     App.iDatabaseServerTokenID ,
     Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
     App.iAccountType ,

                 iOwnerModel.OwnerUserTokenID ,
                      iOwnerModel.OwnerMobileNumberTokenID ,
                                          CategoryTokenID );



                if ( arr_ItemList != null )
                {
                    await SRoofingSync_UserGroupManager.Sync_User_Group_Set_List_ByCategoryTokenID (
                                context ,
                                iOwnerModel ,
                                CategoryTokenID ,
                                arr_ItemList );


                    await SRoofingSync_UserCategoryManager.Sync_User_Category_Set_History_CategoryModel (
                      context ,
                        iOwnerModel , new iSRoofing_Model.Category.SRoofingCategoryModelManager ( )
                        {
                            CategoryTokenID = CategoryTokenID ,
                            CategoryTitle = CategoryTitle
                        } );

                    await SRoofingSync_UserCategoryManager.Sync_User_Category_Set_History_Group_List_ByCategoryTokenID (
                                   context ,
                                     iOwnerModel , CategoryTokenID , arr_ItemList );


                }



                return arr_ItemList;


            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }






        public static async Task<ObservableCollection<SRoofingUserGroupModelManager>> SRoofing_XFMobile_UserGroup_Get_List_Private_Filter_Chatter_ByAlphabetIndexWS (
Application context ,
     SRoofingUserOwnerModelManager iOwnerModel,
       string GroupTokenIDWS)
        {

            try
            {

                ObservableCollection<SRoofingUserGroupModelManager> arr_ItemList = new ObservableCollection<SRoofingUserGroupModelManager> ( );


           //     arr_ItemList = await App.svcSRoofing_UserGroupWS
           // .SRoofing_XFMobile_UserGroup_Get_List_Private_Filter_Chatter_ByAlphabetIndexWSAsync (

           //                                  iOwnerModel,
           //                                  App.iPlatformOS ,
           //                App.iDatabaseServerTokenID ,
           //Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
           //App.iAccountType ,

           //           iOwnerModel.OwnerUserTokenID ,
           //                iOwnerModel.OwnerMobileNumberTokenID ,
           //                                         GroupTokenIDWS ,
           //                                         "0" ,
           //                                         "0" );

                //SRoofingUserGroupModelManager iInfoTutorial = new SRoofingUserGroupModelManager ( )
                //{

                //    //NameLine = strCharacter.ToUpper ( ) ,
                //    iViewCodeType = SRoofingEnum_Generic_RowView_AdapterType.RowView_InfoTutorial

                //};

                //arr_ItemList.Insert ( 0 , iInfoTutorial );




                if ( arr_ItemList != null )
                {
                    //await SRoofingSync_History_ScreenChatShowManager
                    //                         .Sync_History_ScreenChatShow_Set_ChatList (
                    //                      App.Current ,
                    //                      App.iAccountType ,
                    //                       iOwnerModel ,
                    //                      arr_ItemList );




                      Task.Run ( async ( ) =>
                    {

                       // await App.Database.Initialize_DataAsync_HistoryChat_MessageModel ( arr_ItemList );

                    } ).ConfigureAwait ( false );








                }

                return arr_ItemList;


            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }



        #region Picker


        public static async Task<ObservableCollection<SRoofingKeyValueModelManager>> SRoofing_XFMobile_Get_Alphabet_Index_List (
   Application context ,
        SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arr_AlphabetList = new ObservableCollection<SRoofingKeyValueModelManager> ( );
                ObservableCollection<SRoofingKeyValueModelManager> arr_NameItemList = new ObservableCollection<SRoofingKeyValueModelManager> ( );
                ObservableCollection<string> arr_AlphabetList_Active = new ObservableCollection<string> ( );


                arr_NameItemList = await SRoofing_XFMobile_UserContactFriend_Get_List_Alphabet_Index_AccountTypeWS (
                    context , iOwnerModel );


                arr_AlphabetList = await SRoofingSync_UserContactManager.Sync_User_Category_Get_Alphabet_Initialize_List_ByOwnerUserTokenID (
                    context );



                //List<string> arrAlphabet = new List<string>() {
                //"A","B","C","D","E"};

                //List<string> arrNames = new List<string>() {
                //"Ahmed","Burham","Shaymaa"};

                string selections = string.Empty;

                for ( int x = 0 ; x < arr_AlphabetList.Count ; x++ )
                {
                    string xx = arr_AlphabetList[ x ].ItemValue.ToLower ( );

                    for ( int y = 0 ; y < arr_NameItemList.Count ; y++ )
                    {
                        string yy = arr_NameItemList[ y ].ItemText.ToLower ( );

                        if ( xx.ToLower ( ) == yy[ 0 ].ToString ( ).ToLower ( ) )
                        {
                            if ( !arr_AlphabetList_Active.Contains ( arr_AlphabetList[ x ].ItemValue.ToUpper ( ) ) )
                            {

                                arr_AlphabetList[ x ].ItemCode = "active";
                                arr_AlphabetList_Active.Add ( arr_AlphabetList[ x ].ItemValue.ToUpper ( ) );


                                selections += "  " + arr_AlphabetList[ x ].ItemValue.ToUpper ( );

                                SRoofing_DebugManager.Debug_ShowSystemMessage ( "arrAlphabet == " + xx + "\n\n" + selections );
                                break;
                            }
                            //break;
                        }
                    }
                }

              //  SRoofing_DebugManager.Debug_ShowSystemMessage ( "arr_AlphabetList_Active == " + "\n\n" + arr_AlphabetList_Active.ToList ( ) );


                await SRoofingSync_UserContactManager
                    .Sync_User_Category_Set_Alphabet_List_Active_Index_ByOwnerUserTokenID (
                   context , iOwnerModel , arr_AlphabetList );


                await SRoofingSync_UserContactManager
                    .Sync_User_Category_Set_Alphabet_List_Active_Chars_ByOwnerUserTokenID (
                   context , iOwnerModel , arr_AlphabetList_Active );

                return arr_AlphabetList;

            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }






        // SRoofing_XFMobile_UserContactFriend_Get_List_Alphabet_Index_AccountTypeWS
        public static async Task<ObservableCollection<SRoofingKeyValueModelManager>> SRoofing_XFMobile_UserContactFriend_Get_List_Alphabet_Index_AccountTypeWS (
           Application context ,
                SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {

                ObservableCollection<SRoofingUserRemoteModelManager> arr_ItemList = new ObservableCollection<SRoofingUserRemoteModelManager> ( );


       //         arr_ItemList = await App.svcSRoofing_UserContactFriendWS
       // .SRoofing_XFMobile_UserContactFriend_Get_List_Alphabet_Index_AccountTypeWSAsync (

       //                                         App.iPlatformOS ,
       //                App.iDatabaseServerTokenID ,
       //Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
       //App.iAccountType ,

       //           iOwnerModel.OwnerUserTokenID ,
       //                iOwnerModel.OwnerMobileNumberTokenID ,
       //                "0" );

                ObservableCollection<SRoofingKeyValueModelManager> arrItemLisAlphabet
                    = new ObservableCollection<SRoofingKeyValueModelManager> ( );

                for ( int i = 0 ; i < arr_ItemList.Count ; i++ )
                {
                    arrItemLisAlphabet.Add ( new SRoofingKeyValueModelManager ( )
                    {
                        ItemText = arr_ItemList[ i ].FullName ,
                        ItemValue = arr_ItemList[ i ].FullName
                    } );
                }


                if ( arr_ItemList != null )
                {
                    await SRoofingSync_UserContactManager
                                             .Sync_User_Category_Set_Alphabet_List_ByOwnerUserTokenID (
                                          App.Current ,
                                               iOwnerModel ,
                                          arrItemLisAlphabet );
                }

                return arrItemLisAlphabet;


            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }





        #endregion








    }
}
