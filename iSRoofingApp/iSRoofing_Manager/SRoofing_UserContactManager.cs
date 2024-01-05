using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Category;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;

 
using Microsoft.Maui.Controls;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_Manager;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_UserContactManager
    {



        // UserProfile_Get_Owner_Profile_ByAccountTypeWS
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
                    string xx = arr_AlphabetList[ x ].ItemValue.ToLower();

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

                SRoofing_DebugManager.Debug_ShowSystemMessage ( "arr_AlphabetList_Active == " + "\n\n" + arr_AlphabetList_Active.ToList ( ) );


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



        // UserProfile_Get_Owner_Profile_ByAccountTypeWS
        public static async Task<ObservableCollection<SRoofingCategoryModelManager>> SRoofing_XFMobile_UserCategory_Get_List_ByOwnerUserTokenIDWS (
           Application context ,
                SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {

                ObservableCollection<SRoofingCategoryModelManager> arr_ItemList = new ObservableCollection<SRoofingCategoryModelManager> ( );


                arr_ItemList = await App.svcSRoofing_UserCategoryWS
        .SRoofing_XFMobile_UserCategory_Get_List_ByOwnerUserTokenIDWSAsync (

                                                App.iPlatformOS ,
                       App.iDatabaseServerTokenID ,
       Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
       App.iAccountType ,

                  iOwnerModel.OwnerUserTokenID ,
                       iOwnerModel.OwnerMobileNumberTokenID );




                if ( arr_ItemList != null )
                {
                    await SRoofingSync_UserCategoryManager
                                             .Sync_User_Category_Set_Category_List_ByOwnerUserTokenID (
                                          App.Current ,
                                                                                     iOwnerModel ,
                                          arr_ItemList );
                }

                return arr_ItemList;


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


                arr_ItemList = await  SRoofing_UserContactFriendWS
        .SRoofing_XFMobile_UserContactFriend_Get_List_Alphabet_Index_AccountTypeWSAsync (

                                            iOwnerModel,
                                            App.iPlatformOS ,
                       App.iDatabaseServerTokenID ,
       Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
       App.iAccountType ,

                  iOwnerModel.OwnerUserTokenID ,
                       iOwnerModel.OwnerMobileNumberTokenID ,
                       "0" );

  
       //////         arr_ItemList = await App.svcSRoofing_UserContactFriendWS
       ////// .SRoofing_XFMobile_UserContactFriend_Get_List_Alphabet_Index_AccountTypeWSAsync (

       //////                                         App.iPlatformOS ,
       //////                App.iDatabaseServerTokenID ,
       //////Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
       //////App.iAccountType ,

       //////           iOwnerModel.OwnerUserTokenID ,
       //////                iOwnerModel.OwnerMobileNumberTokenID ,
       //////                "0" );

    
                
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








        public static async Task<ObservableCollection<SRoofingUserRemoteModelManager>> SRoofing_XFMobile_UserContactFriend_Get_List_Contact_ByAlphabetIndexWS (
       Application context ,
            SRoofingUserOwnerModelManager iOwnerModel ,
           string strCharacter )
        {

            try
            {

                ObservableCollection<SRoofingUserRemoteModelManager> arr_ItemList = new ObservableCollection<SRoofingUserRemoteModelManager> ( );


                arr_ItemList = await  SRoofing_UserContactFriendWS
      .SRoofing_XFMobile_UserContactFriend_Get_List_Contact_ByAlphabetIndexWSAsync (

                                            iOwnerModel,
                                             App.iPlatformOS ,
                     App.iDatabaseServerTokenID ,
     Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
     App.iAccountType ,
                  iOwnerModel.OwnerUserTokenID ,
                    iOwnerModel.OwnerMobileNumberTokenID ,
         strCharacter ,
           "0" );

            
     ////////           arr_ItemList = await App.svcSRoofing_UserContactFriendWS
     //////// .SRoofing_XFMobile_UserContactFriend_Get_List_Contact_ByAlphabetIndexWSAsync (
     ////////                      App.iPlatformOS ,
     ////////                App.iDatabaseServerTokenID ,
     ////////Preferences.Get ( "DeviceGlobalID" , "0" ) ,//DeviceGlobalIDWS
     ////////App.iAccountType ,
     ////////             iOwnerModel.OwnerUserTokenID ,
     ////////               iOwnerModel.OwnerMobileNumberTokenID ,
     ////////    strCharacter ,
     ////////      "0" );

         SRoofingUserRemoteModelManager iHeader = new SRoofingUserRemoteModelManager ( )
                {

                    NameLine = strCharacter.ToUpper ( ) ,
                    iViewCodeType = SRoofingEnum_Generic_RowView_AdapterType.RowView_Header

                };

                arr_ItemList.Insert ( 0 , iHeader );

                //////////SRoofingUserRemoteModelManager iInfoTutorial = new SRoofingUserRemoteModelManager ( )
                //////////{

                //////////    NameLine = strCharacter.ToUpper ( ) ,
                //////////    iViewCodeType = SRoofingEnum_Generic_RowView_AdapterType.RowView_InfoTutorial

                //////////};

                //////////arr_ItemList.Insert ( 0 , iInfoTutorial );




                if ( arr_ItemList != null )
                {
                  

                     await SRoofingSync_UserContactManager.Sync_User_Contact_Set_List_Contact_ByCharcterID (
                                context ,
                                iOwnerModel ,
                                strCharacter ,
                                arr_ItemList );


                    await SRoofingSync_UserContactManager.Sync_User_Contact_Set_History_Selected_CharacterModel (
                      context ,
                        iOwnerModel , new SRoofingKeyValueModelManager ( )
                        {
                            ItemText = strCharacter.ToUpper ( ) ,
                            ItemValue = strCharacter.ToUpper ( )
                        } );

                    await SRoofingSync_UserContactManager.Sync_User_Contact_Set_History_Selected_Contact_List_ByCharacterID (
                                   context ,
                                     iOwnerModel , strCharacter ,
                                     arr_ItemList );


                }

                return arr_ItemList;


            }
            catch ( Exception ex )
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }














    }
}
