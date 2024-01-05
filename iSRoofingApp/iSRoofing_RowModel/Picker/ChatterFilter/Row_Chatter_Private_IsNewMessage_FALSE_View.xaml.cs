using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
 
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Chatter;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Contact;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

 
 
 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.Picker.ChatterFilter
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Row_Chatter_Private_IsNewMessage_FALSE_View  : ContentView
    {
        public Row_Chatter_Private_IsNewMessage_FALSE_View ()
        {
            InitializeComponent();
            // 

            //  Initialize_Command ( );

            ////Content.BindingContext = this;
        }

        //private void SwipeItem_Invoked ( object sender , EventArgs e )
        //    {

        //          try
        //        {

        //        SRoofing_DebugManager.Debug_ShowSystemMessage ( "Inoked");

        //        }
        //    catch ( Exception ex )
        //        {
        //        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //        return;
        //        }

        //    }





        #region Bindings

        //iOwnerModel
        public SRoofingUserOwnerModelManager iOwnerModel
        {
            get
            {
                return ( SRoofingUserOwnerModelManager ) GetValue ( iOwnerModelProperty );
            }
            set
            {
                SetValue ( iOwnerModelProperty , value );
            }
        }

        public static BindableProperty iOwnerModelProperty =
            BindableProperty.Create (
                nameof ( iOwnerModel ) ,
                typeof ( SRoofingUserOwnerModelManager ) ,
                typeof ( Row_Chatter_Private_IsNewMessage_FALSE_View ) ,
                new SRoofingUserOwnerModelManager ( ) ,
                BindingMode.TwoWay );






        public SRoofingUserGroupModelManager iGroupModel
        {
            get
            {
                return ( SRoofingUserGroupModelManager ) GetValue ( iGroupModelProperty );
            }
            set
            {
                SetValue ( iGroupModelProperty , value );
            }
        }

        public static BindableProperty iGroupModelProperty =
            BindableProperty.Create ( nameof ( iGroupModel ) , typeof ( SRoofingUserGroupModelManager ) , typeof ( Row_Chatter_Private_IsNewMessage_FALSE_View ) , new SRoofingUserGroupModelManager ( ) ,
                BindingMode.TwoWay );

        protected override void OnPropertyChanged ( string propertyName = null )
        {
            base.OnPropertyChanged ( propertyName );

            if ( propertyName == iGroupModelProperty.PropertyName )
            {
                if ( iGroupModel != null )
                {
                    // Update ContentView properties and elements.
                    Initialize_Command ( );
                }
            }
        }

        #endregion





        #region Commands_List

        //public ICommand Command_Chat_ByUser { get; private set; }


        public static readonly BindableProperty Command_Chat_ByUserProperty = BindableProperty.Create(nameof(Command_Chat_ByUser), typeof(ICommand), typeof(Row_Chatter_Private_IsNewMessage_FALSE_View), null);
        public ICommand Command_Chat_ByUser
        {
            get => (ICommand)GetValue(Command_Chat_ByUserProperty);
            set => SetValue(Command_Chat_ByUserProperty, value);
        }

        //public static readonly BindableProperty CloseButtonClickProperty = BindableProperty.Create ( nameof ( CloseButtonClick ) , typeof ( ICommand ) , typeof ( HeaderView ) , null );
        //public ICommand CloseButtonClick
        //    {
        //    get => ( ICommand ) GetValue ( CloseButtonClickProperty );
        //    set => SetValue ( CloseButtonClickProperty , value );
        //    }

        void Initialize_Command()
        {

            try
            {

                Command_Chat_ByUser = new Command(async (object iObjectModel) =>
                {
  ////////                  try
  ////////                  {
  ////////                      var objService = DependencyService.Get<iSRoofing_DependencyService_SoundClick> ( );

  ////////                      if ( objService != null )
  ////////                      {
  ////////                          objService.KeyboardClick ( );
  ////////                      }


  ////////                      await Task.Delay ( 500 );

  ////////                      SRoofingUserGroupModelManager _iRemoteModel = null;
  ////////                      SRoofingUserGroupModelManager _iGroupModel = null;

  ////////                      SRoofingUserGroupModelManager _iHistoryChatModel = (SRoofingUserGroupModelManager)iObjectModel;

  ////////                      if (_iHistoryChatModel.GroupType == (SRoofingEnum_GroupType.GroupType_PRIVATE))
  ////////                      {

  ////////                          _iRemoteModel = new SRoofingUserGroupModelManager ( );

  ////////                          _iRemoteModel = await SRoofingSync_User_RemoteManager
  ////////                          .Sync_User_Remote_Get_UserModel (
  ////////                App.Current ,
  ////////                iOwnerModel ,
  ////////  _iHistoryChatModel.RemoteUserTokenID ,
  ////////_iHistoryChatModel.RemoteMobileNumberTokenID );

  ////////                          if ( _iRemoteModel == null )
  ////////                          {
  ////////                              if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
  ////////                              {
  ////////                                  _iRemoteModel =
  ////////                              await SRoofing_UserProfileRemoteManager.SRoofing_User_Get_Remote_Model_ByRemoteUserTokenID (
  ////////                                        App.Current ,
  ////////                                        iOwnerModel ,
  ////////                                        _iHistoryChatModel.RemoteUserTokenID ,
  ////////                                        _iHistoryChatModel.RemoteMobileNumberTokenID );
  ////////                              }

  ////////                          }
  ////////                      }
  ////////                      else if (_iHistoryChatModel.GroupType == (SRoofingEnum_GroupType.GroupType_GROUP))
  ////////                      {

  ////////                          _iRemoteModel = null;
  ////////                      }

  ////////                      _iGroupModel = new SRoofingUserGroupModelManager ( );


  ////////                      _iGroupModel = await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel (
  ////////                            App.Current ,
  ////////                            iOwnerModel ,
  ////////                            _iHistoryChatModel.GroupTokenID );


  ////////                      if ( _iGroupModel == null )
  ////////                      {
  ////////                          if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
  ////////                          {

  ////////                              _iGroupModel = new SRoofingUserGroupModelManager ( );

  ////////                              _iGroupModel =
  ////////                              await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID (

  ////////                                          App.Current ,
  ////////                                              iOwnerModel ,
  ////////                                               _iHistoryChatModel.GroupTokenID );
  ////////                          }

  ////////                      }        //_iGroupModel = new SRoofingUserGroupModelManager();
  ////////                               //_iGroupModel =
  ////////                               //    await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

  ////////                      //                App.Current,
  ////////                      //                    iOwnerModel,
  ////////                      //                     _iHistoryChatModel.GroupTokenID);


  ////////                      //////////SRoofing_ChatManager
  ////////                      //////////        .Chat_StartChatTicket_ToUserID(
  ////////                      //////////                App.Current,
  ////////                      //////////                App.iAccountType,
  ////////                      //////////                SRoofingEnum_Direction.Direction_Out,
  ////////                      //////////                SRoofingEnum_ScreenShow_InviteTag.InviteTag_Chat,
  ////////                      //////////                SRoofingEnum_ScreenChatShowMessage_Code
  ////////                      //////////                        .MessageCode_Text,
  ////////                      //////////                SRoofingEnum_ScreenChatShowMessage_Code
  ////////                      //////////                        .MessageCode_Text,
  ////////                      //////////                iOwnerModel,
  ////////                      //////////                _iRemoteModel,
  ////////                      //////////                _iGroupModel,
  ////////                      //////////                _iHistoryChatModel.GroupTokenID,
  ////////                      //////////                _iHistoryChatModel.GroupType,
  ////////                      //////////                _iHistoryChatModel.NameLine,
  ////////                      //////////                _iHistoryChatModel.NameLine,
  ////////                      //////////                "0",
  ////////                      //////////                false,
  ////////                      //////////                true);


  ////////                      //SRoofing_DebugManager.Debug_ShowSystemMessage("_blnSyncHistory_ScreenChatShow_List == " +
  ////////                      //     App._blnSyncHistory_ScreenChatShow_List);

  ////////                      //  App._blnSyncHistory_ScreenChatShow_List = true;
  ////////                      //  App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = true;


  ////////                      //SRoofing_DebugManager.Debug_ShowSystemMessage("_blnSyncHistory_ScreenChatShow_List == " +


  ////////                      //////////////////////////




  ////////                      await SRoofing_ScreenChatShowManager
  ////////                     .Chat_Initialize_Chat_Show(
  ////////                          App.Current,
  ////////                          iOwnerModel,
  ////////                          _iRemoteModel,
  ////////                          _iGroupModel);


  ////////                      await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener(
  ////////                              Navigation,
  ////////                          new Page_Chat_Dashboard(),
  ////////                          false,
  ////////                          true);




  ////////                      //if ( iPage.Navigation.NavigationStack.Count == 0 ||

  ////////                      //iPage.Navigation.NavigationStack.Last ( ).GetType ( ) != typeof ( Page_Chat_View ) )
  ////////                      //    {
  ////////                      //    await iPage.Navigation.PushModalAsync ( new Page_Chat_View ( _iHistoryChatModel ) , true );

  ////////                      //    }
  ////////                  }
  ////////                  catch (Exception ex)
  ////////                  {
  ////////                      SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
  ////////                      return;
  ////////                  }

                });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }



        #endregion




        #region Avatar


        async void frm_Avatar_Tapped ( object sender , EventArgs e )
        {
            try
            {
                await SRoofing_UserProfileRemoteManager
                    .SRoofing_UserProfile_Open_Remote_Profile_ByRemoteUserTokenID (
                    App.Current ,
                    Navigation ,
                    iOwnerModel ,
                    null , iGroupModel.RemoteUserTokenID ,
                    iGroupModel.RemoteMobileNumberTokenID );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }


        }

        #endregion




        private async void btn_Command_Clicked ( object sender , EventArgs e )
        {
            try
            {

                await ( ( View_Chat_Chatters_Picker_List ) Parent.BindingContext )
                   .pendingRemove_Chatter ( ( SRoofingUserGroupModelManager ) iGroupModel );






                //////( ( View_Chat_Chatters_Picker_List ) Parent.BindingContext ).arr_UserMarshalList.Remove ( ( SRoofingUserGroupModelManager ) iGroupModel );



                //           MessagingCenter.Send<App , string> ( App.Current as App ,
                //SRoofingEnum_MessageCenter.MessageCenter_CHATTER_REMOVE_USER ,
                //SRoofingEnum_MessageCenter.MessageCenter_CHATTER_REMOVE_USER );


                // btn_Command.Text = iParent._bln_IsUNDO.ToString();

                //  await    iParent.remove_Chatter ( iGroupModel);

                //////   var btn = sender as Button;
                //////   var item = btn.BindingContext as SRoofingUserRemoteModelManager;

                //////iParent.arr_UserChattersList     .Remove ( item );


                //////if ( !( ( Page_Chat_Chatters_List ) Parent.BindingContext )._bln_IsUNDO_Global )
                //////{


                //////    if ( !( ( Page_Chat_Chatters_List ) Parent.BindingContext )._bln_IsUNDO )
                //////    {
                //////        //( ( Page_Chat_Dashboard ) Parent.BindingContext )._bln_IsUNDO_Global = true;
                //////        ( ( Page_Chat_Chatters_List ) Parent.BindingContext )._bln_IsUNDO = true;

                //////        btn_Command.Text = "Undo";

                //////        ////////await Task.Delay ( 1500 );

                //////        ////////if ( ( ( Page_Chat_Dashboard ) Parent.BindingContext )._bln_IsUNDO )
                //////        ////////{

                //////        ////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( "########## _bln_IsUNDO ##########" );
                //////        ////////    ( ( Page_Chat_Dashboard ) Parent.BindingContext )._bln_IsUNDO = false;
                //////        ////////}

                //////    }
                //////    else
                //////    {
                //////        ( ( Page_Chat_Chatters_List ) Parent.BindingContext )._bln_IsUNDO = false;
                //////        btn_Command.Text = "Remove";
                //////        ( ( Page_Chat_Chatters_List ) Parent.BindingContext )._bln_IsUNDO_Global = false;

                //////    }


                //////}


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }



    }
}