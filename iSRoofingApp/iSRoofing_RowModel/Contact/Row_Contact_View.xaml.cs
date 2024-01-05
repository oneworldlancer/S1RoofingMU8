using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Call;
//using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Call;
////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Contact;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;





namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.Contact
{
    ////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Row_Contact_View : ContentView
    {
        public Row_Contact_View()
        {
            InitializeComponent();
        }


        #region Bindings

        //iOwnerModel
        public SRoofingUserOwnerModelManager iOwnerModel
        {
            get
            {
                return (SRoofingUserOwnerModelManager)GetValue(iOwnerModelProperty);
            }
            set
            {
                SetValue(iOwnerModelProperty, value);
            }
        }

        public static BindableProperty iOwnerModelProperty =
            BindableProperty.Create(
                nameof(iOwnerModel),
                typeof(SRoofingUserOwnerModelManager),
                typeof(Row_Chat_Private_IsNewMessage_FALSE_View),
                new SRoofingUserOwnerModelManager(),
                BindingMode.TwoWay);






        public SRoofingUserRemoteModelManager iGroupModel
        {
            get
            {
                return (SRoofingUserRemoteModelManager)GetValue(iGroupModelProperty);
            }
            set
            {
                SetValue(iGroupModelProperty, value);
            }
        }

        public static BindableProperty iGroupModelProperty =
            BindableProperty.Create(nameof(iGroupModel), typeof(SRoofingUserRemoteModelManager), typeof(Row_Chat_Private_IsNewMessage_FALSE_View), new SRoofingUserRemoteModelManager(),
                BindingMode.TwoWay);

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == iGroupModelProperty.PropertyName)
            {
                if (iGroupModel != null)
                {
                    // Update ContentView properties and elements.
                    //Initialize_Command();
                }
            }
        }

        #endregion





        #region Commands_List

        public static readonly BindableProperty Command_Call_ByUserProperty = BindableProperty.Create(nameof(Command_Call_ByUser), typeof(ICommand), typeof(Row_Chat_Private_IsNewMessage_FALSE_View), null);
        public ICommand Command_Call_ByUser
        {
            get => (ICommand)GetValue(Command_Call_ByUserProperty);
            set => SetValue(Command_Call_ByUserProperty, value);
        }



        public static readonly BindableProperty Command_Chat_ByUserProperty = BindableProperty.Create(nameof(Command_Chat_ByUser), typeof(ICommand), typeof(Row_Chat_Private_IsNewMessage_FALSE_View), null);
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


                    try
                    {

                        var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

                        if (objService != null)
                        {
                            objService.KeyboardClick();
                        }


                        // await Task.Delay ( 500 );

                        await SRoofing_AnimationManager.Animation_FadeInOut(App.Current, frm_RowContent);



                        _ = Task.Run(async () =>
                        {



                            string _iPrivateGroupTokenID = "0";

                            SRoofingUserRemoteModelManager _iRemoteModel = null;
                            SRoofingUserGroupModelManager _iGroupModel = null;

                            SRoofingUserRemoteModelManager _iHistoryContactModel = (SRoofingUserRemoteModelManager)iObjectModel;



                            _iRemoteModel = new SRoofingUserRemoteModelManager();

                            if (_iHistoryContactModel.GroupTokenID == "0")
                            {

                                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                                {

                                    _iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                                        App.Current,
                                        App.iAccountType,
                                        iOwnerModel,
                                        _iHistoryContactModel.OwnerUserTokenID,
                                        _iHistoryContactModel.OwnerMobileNumberTokenID);

                                    _iHistoryContactModel.GroupTokenID = _iPrivateGroupTokenID;


                                    _iRemoteModel = _iHistoryContactModel;


                                    _iGroupModel = new SRoofingUserGroupModelManager();

                                    _iGroupModel =
                                    await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                                                App.Current,
                                                    iOwnerModel,
                                                     _iHistoryContactModel.GroupTokenID);


                                }


                            }


                            _iRemoteModel = _iHistoryContactModel;


                            _iGroupModel = new SRoofingUserGroupModelManager();

                            _iGroupModel = await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel(
                                  App.Current,
                                  iOwnerModel,
                                  _iHistoryContactModel.GroupTokenID);


                            if (_iGroupModel == null)
                            {
                                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                                {

                                    _iGroupModel = new SRoofingUserGroupModelManager();

                                    _iGroupModel =
                                    await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                                                App.Current,
                                                    iOwnerModel,
                                                     _iHistoryContactModel.GroupTokenID);
                                }

                            }



                            //////////SRoofing_ChatManager
                            //////////        .Chat_StartChatTicket_ToUserID(
                            //////////                App.Current,
                            //////////                App.iAccountType,
                            //////////                SRoofingEnum_Direction.Direction_Out,
                            //////////                SRoofingEnum_ScreenShow_InviteTag.InviteTag_Chat,
                            //////////                SRoofingEnum_ScreenChatShowMessage_Code
                            //////////                        .MessageCode_Text,
                            //////////                SRoofingEnum_ScreenChatShowMessage_Code
                            //////////                        .MessageCode_Text,
                            //////////                iOwnerModel,
                            //////////                _iRemoteModel,
                            //////////                _iGroupModel,
                            //////////                _iHistoryContactModel.GroupTokenID,
                            //////////                _iHistoryContactModel.GroupType,
                            //////////                _iHistoryContactModel.NameLine,
                            //////////                _iHistoryContactModel.NameLine,
                            //////////                "0",
                            //////////                false,
                            //////////                true);


                            //SRoofing_DebugManager.Debug_ShowSystemMessage("_blnSyncHistory_ScreenChatShow_List == " +
                            //     App._blnSyncHistory_ScreenChatShow_List);

                            //  App._blnSyncHistory_ScreenChatShow_List = true;
                            //  App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = true;


                            //SRoofing_DebugManager.Debug_ShowSystemMessage("_blnSyncHistory_ScreenChatShow_List == " +


                            //////////////////////////




                            SRoofingScreenChatShowScreenModel _iChatScreenModel = new SRoofingScreenChatShowScreenModel();
                            _iChatScreenModel=    await SRoofing_ScreenChatShowManager
                              .Chat_Initialize_Chat_Show(
                                   App.Current,
                                   iOwnerModel,
                                   _iRemoteModel,
                                   _iGroupModel);


                            ////////////////////await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener_WithChecker (
                            ////////////////////     Navigation ,
                            ////////////////////     typeof ( Page_ScreenChatShow_Dashboard ) ,
                            //////////////////// new Page_ScreenChatShow_Dashboard (  ) ,
                            //////////////////// false ,



                        })
                       .ConfigureAwait(false);


                    }
                    catch (Exception ex)
                    {
                        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                        return;
                    }

                });







                Command_Call_ByUser = new Command(async (object iObjectModel) =>
                {


                    try
                    {
                        var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

                        if (objService != null)
                        {
                            objService.KeyboardClick();
                        }


                        await Task.Delay(500);

                        //  await Task.Delay ( 500 );


                        _=   Task.Run(async () =>
                  {

                      string _iPrivateGroupTokenID = "0";

                      SRoofingUserRemoteModelManager _iRemoteModel = null;
                      String _InviteCode = "call";
                      String _InviteType = "voice";
                      bool _blnPopup_NoMoreCall = (false);
                      bool _blnStartCall = (false);
                      bool _blnSubscribe = (false);
                      String sResponse = "";
                      /*String _iPrivateGroupTokenID = "0";*/
                      String _iOwnerProjectRoleCode = "0";
                      SRoofingUserGroupModelManager _iGroupModel;


                      SRoofingUserRemoteModelManager _iHistoryContactModel = (SRoofingUserRemoteModelManager)iObjectModel;


                      _iRemoteModel = new SRoofingUserRemoteModelManager();

                      if (_iHistoryContactModel.GroupTokenID == "0")
                      {

                          if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                          {

                              _iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                                App.Current,
                                App.iAccountType,
                                iOwnerModel,
                                _iHistoryContactModel.RemoteUserTokenID,
                                _iHistoryContactModel.RemoteMobileNumberTokenID);

                              _iHistoryContactModel.GroupTokenID = _iPrivateGroupTokenID;


                              _iRemoteModel = _iHistoryContactModel;


                              _iGroupModel = new SRoofingUserGroupModelManager();

                              _iGroupModel =
                            await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                                        App.Current,
                                            iOwnerModel,
                                             _iHistoryContactModel.GroupTokenID);


                          }

                          _iHistoryContactModel.IsUNewJoinContact = false;

                      }


                      _iRemoteModel = _iHistoryContactModel;


                      _iGroupModel = new SRoofingUserGroupModelManager();

                      _iGroupModel = await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel(
                          App.Current,
                          iOwnerModel,
                          _iHistoryContactModel.GroupTokenID);



                      if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                      {

                          if (_iGroupModel == null)
                          {
                              _iGroupModel = new SRoofingUserGroupModelManager();

                              _iGroupModel =
                            await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                                        App.Current,
                                            iOwnerModel,
                                             _iHistoryContactModel.GroupTokenID);

                          }



                          bool _blnSystemCall_IsAvailable;
                          _blnSystemCall_IsAvailable = true;


                          //////////TlknCallManager.Call_ResetCallScreen_IfNotActive(
                          //////////       _iActivity,
                          //////////       _iActivity._iAccountType);


                          if (_blnSystemCall_IsAvailable == true)
                          {



                              bool blnAvatarIsBlur = false;


                              await SRoofing_ScreenCallShowManager
                       .Call_Initialize_Call_Show_Offer(
                            App.Current,
                            iOwnerModel,
                            _iRemoteModel,
                            _iGroupModel);













                              ///////////////////////////////////


                              //////////TlknCallManager.Call_StartCallTicket_ToUserID(
                              //////////        _iActivity,
                              //////////        _iActivity._iAccountType,
                              //////////        "out",
                              //////////        "chat",
                              //////////        "chat",
                              //////////        _InviteCode,
                              //////////        _InviteType,
                              //////////        _iRemoteModel,
                              //////////        _iActivity._iOwnerModel,

                              //////////        "chat",
                              //////////        blnAvatarIsBlur,

                              //////////         (false));

                              _blnStartCall = (true);
                              _blnPopup_NoMoreCall = (false);
                              _blnSubscribe = (false);

                          }


                          else
                          {

                              ////////////Call is Running
                              //////////if (TlknSyncManager.Sync_Call_GetCurrentScreenCallShowByUserID(_iActivity)
                              //////////                    .get_GroupID()
                              //////////                    .equalsIgnoreCase(iCallModel.get_GroupTokenID()))
                              //////////{

                              //////////    TlknCallManager
                              //////////            .Call_CurrentCallTicket_ToUserID(
                              //////////                    _iActivity,

                              //////////                    TlknEnum_User_Account.UserAccount_Personal,
                              //////////                    TlknEnum_Direction.Direction_Out,
                              //////////                    TlknEnum_ScreenShow_InviteTag.InviteTag_Chat,
                              //////////                    TlknEnum_Call_ScreenType.CallScreenType_Chat,

                              //////////                    _InviteCode,
                              //////////                    _InviteType,
                              //////////                    _iRemoteModel,
                              //////////                    _iActivity._iOwnerModel,

                              //////////                    TlknEnum_Dating_MatchType.DatingMatchType_Chat,
                              //////////                    false);

                              //////////    //same group, open call screen
                              //////////    _blnStartCall = true;
                              //////////    _blnPopup_NoMoreCall = false;
                              //////////    _blnSubscribe = false;

                              //////////}

                              //////////else
                              //////////{

                              //////////    ShowAlert_NoNewCall;
                              //////////    _blnStartCall = false;
                              //////////    _blnPopup_NoMoreCall = true;
                              //////////    _blnSubscribe = false;
                              //////////}
                          }









                          //////////}

                          //await Task.Delay ( 1000 );




                          await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener(
                                  Navigation,
                              new Page_Call_Dashboard(),
                              false,
                              true);


                      }
                      else
                      {
                          MainThread.BeginInvokeOnMainThread(async () =>
                        {
                            // Code to run on the main thread
                                  await ((Page_Contact_List_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Contact_List_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);

                              });
                      }
                  }).ConfigureAwait(false);


                    }


                    catch (Exception ex)
                    {
                        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                        return;
                    }

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


        async void frm_Avatar_Tapped(object sender, EventArgs e)
        {
            try
            {
                await SRoofing_UserProfileRemoteManager
                    .SRoofing_UserProfile_Open_Remote_Profile_ByRemoteUserTokenID(
                    App.Current,
                    Navigation,
                    iOwnerModel,
                    iGroupModel, iGroupModel.RemoteUserTokenID,
                    iGroupModel.RemoteMobileNumberTokenID);

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }


        #endregion

        private void imgBtn_UserCall_Clicked(object sender, EventArgs e)
        {

            try
            {
                var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

                if (objService != null)
                {
                    objService.KeyboardClick();
                }


                //await Task.Delay(500);

                //  await Task.Delay ( 500 );


                _=   Task.Run(async () =>
                {

                    string _iPrivateGroupTokenID = "0";

                    SRoofingUserRemoteModelManager _iRemoteModel = null;
                    String _InviteCode = "call";
                    String _InviteType = "voice";
                    bool _blnPopup_NoMoreCall = (false);
                    bool _blnStartCall = (false);
                    bool _blnSubscribe = (false);
                    String sResponse = "";
                    /*String _iPrivateGroupTokenID = "0";*/
                    String _iOwnerProjectRoleCode = "0";
                    SRoofingUserGroupModelManager _iGroupModel;


                    //SRoofingUserRemoteModelManager _iHistoryContactModel = (SRoofingUserRemoteModelManager)iObjectModel;


                    _iRemoteModel = new SRoofingUserRemoteModelManager();

                    if (iGroupModel.GroupTokenID == "0")
                    {

                        if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                        {

                            _iPrivateGroupTokenID = await SRoofing_UserGroupManager.Initialize_UserGroup_Private_ByGroupTokenID(

                                App.Current,
                                App.iAccountType,
                                iOwnerModel,
                                iGroupModel.RemoteUserTokenID,
                                iGroupModel.RemoteMobileNumberTokenID);

                            iGroupModel.GroupTokenID = _iPrivateGroupTokenID;


                            _iRemoteModel = iGroupModel;


                            _iGroupModel = new SRoofingUserGroupModelManager();

                            _iGroupModel =
                            await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                                        App.Current,
                                            iOwnerModel,
                                             iGroupModel.GroupTokenID);


                        }

                        iGroupModel.IsUNewJoinContact = false;

                    }


                    _iRemoteModel = iGroupModel;


                    _iGroupModel = new SRoofingUserGroupModelManager();

                    _iGroupModel = await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel(
                          App.Current,
                          iOwnerModel,
                          iGroupModel.GroupTokenID);



                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {

                        if (_iGroupModel == null)
                        {
                            _iGroupModel = new SRoofingUserGroupModelManager();

                            _iGroupModel =
                            await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                                        App.Current,
                                            iOwnerModel,
                                             iGroupModel.GroupTokenID);

                        }



                        bool _blnSystemCall_IsAvailable;
                        _blnSystemCall_IsAvailable = true;


                        //////////TlknCallManager.Call_ResetCallScreen_IfNotActive(
                        //////////       _iActivity,
                        //////////       _iActivity._iAccountType);


                        if (_blnSystemCall_IsAvailable == true)
                        {



                            bool blnAvatarIsBlur = false;


                            await SRoofing_ScreenCallShowManager
                       .Call_Initialize_Call_Show_Offer(
                            App.Current,
                            iOwnerModel,
                            _iRemoteModel,
                            _iGroupModel);













                            ///////////////////////////////////


                            //////////TlknCallManager.Call_StartCallTicket_ToUserID(
                            //////////        _iActivity,
                            //////////        _iActivity._iAccountType,
                            //////////        "out",
                            //////////        "chat",
                            //////////        "chat",
                            //////////        _InviteCode,
                            //////////        _InviteType,
                            //////////        _iRemoteModel,
                            //////////        _iActivity._iOwnerModel,

                            //////////        "chat",
                            //////////        blnAvatarIsBlur,

                            //////////         (false));

                            _blnStartCall = (true);
                            _blnPopup_NoMoreCall = (false);
                            _blnSubscribe = (false);

                        }


                        else
                        {

                            ////////////Call is Running
                            //////////if (TlknSyncManager.Sync_Call_GetCurrentScreenCallShowByUserID(_iActivity)
                            //////////                    .get_GroupID()
                            //////////                    .equalsIgnoreCase(iCallModel.get_GroupTokenID()))
                            //////////{

                            //////////    TlknCallManager
                            //////////            .Call_CurrentCallTicket_ToUserID(
                            //////////                    _iActivity,

                            //////////                    TlknEnum_User_Account.UserAccount_Personal,
                            //////////                    TlknEnum_Direction.Direction_Out,
                            //////////                    TlknEnum_ScreenShow_InviteTag.InviteTag_Chat,
                            //////////                    TlknEnum_Call_ScreenType.CallScreenType_Chat,

                            //////////                    _InviteCode,
                            //////////                    _InviteType,
                            //////////                    _iRemoteModel,
                            //////////                    _iActivity._iOwnerModel,

                            //////////                    TlknEnum_Dating_MatchType.DatingMatchType_Chat,
                            //////////                    false);

                            //////////    //same group, open call screen
                            //////////    _blnStartCall = true;
                            //////////    _blnPopup_NoMoreCall = false;
                            //////////    _blnSubscribe = false;

                            //////////}

                            //////////else
                            //////////{

                            //////////    ShowAlert_NoNewCall;
                            //////////    _blnStartCall = false;
                            //////////    _blnPopup_NoMoreCall = true;
                            //////////    _blnSubscribe = false;
                            //////////}
                        }









                        //////////}

                        //await Task.Delay ( 1000 );




                        await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener(
                                Navigation,
                            new Page_Call_Dashboard(),
                            false,
                            true);


                    }
                    else
                    {
                        MainThread.BeginInvokeOnMainThread(async () =>
                        {
                            // Code to run on the main thread
                            await ((Page_Contact_List_Dashboard)Parent.BindingContext).Snack_ShowMessage(((Page_Contact_List_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);

                        });
                    }
                }).ConfigureAwait(false);


            }


            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }
    }
}