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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

//using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;





namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.History.Chat
{
    ////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Row_Chat_Private_IsNewMessage_TRUE_View : ContentView
    {
        public Row_Chat_Private_IsNewMessage_TRUE_View()
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


        //iParentCode
        public string iParentCode
        {
            get
            {
                return (string)GetValue(iParentCodeProperty);
            }
            set
            {
                SetValue(iParentCodeProperty, value);
            }
        }

        public static BindableProperty iParentCodeProperty =
            BindableProperty.Create(
                nameof(iParentCode),
                typeof(string),
                typeof(Row_Chat_Private_IsNewMessage_TRUE_View),
                string.Empty,
                BindingMode.TwoWay);






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
                typeof(Row_Chat_Private_IsNewMessage_TRUE_View),
                new SRoofingUserOwnerModelManager(),
                BindingMode.TwoWay);




        //iGroupModel
        public SRoofingScreenChatShowHistoryMessageModelManager iGroupModel
        {
            get
            {
                return (SRoofingScreenChatShowHistoryMessageModelManager)GetValue(iGroupModelProperty);
            }
            set
            {
                SetValue(iGroupModelProperty, value);
            }
        }

        public static BindableProperty iGroupModelProperty =
            BindableProperty.Create(nameof(iGroupModel), typeof(SRoofingScreenChatShowHistoryMessageModelManager), typeof(Row_Chat_Private_IsNewMessage_TRUE_View), new SRoofingScreenChatShowHistoryMessageModelManager(),
                BindingMode.TwoWay);


        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            // if (propertyName == iOwnerModelProperty.PropertyName)
            if (propertyName == iGroupModelProperty.PropertyName)
            {
                if (iGroupModel != null)
                {
                    // Update ContentView properties and elements.
                    Initialize_Command();

                }
            }
        }

        #endregion




        #region Commands_List

        //public ICommand Command_Chat_ByUser { get; private set; }


        public static readonly BindableProperty Command_Chat_ByUserProperty = BindableProperty.Create(nameof(Command_Chat_ByUser), typeof(ICommand), typeof(Row_Chat_Private_IsNewMessage_TRUE_View), null);
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


                        await SRoofing_AnimationManager.Animation_FadeInOut(App.Current, frm_RowContent);


                        //  await Task.Delay ( 100 );

                        _ = Task.Run(async () =>
                 {

                     SRoofingUserRemoteModelManager _iRemoteModel = null;
                     SRoofingUserGroupModelManager _iGroupModel = null;

                     SRoofingScreenChatShowHistoryMessageModelManager _iHistoryChatModel = (SRoofingScreenChatShowHistoryMessageModelManager)iObjectModel;

                     if (_iHistoryChatModel.GroupType == (SRoofingEnum_GroupType.GroupType_PRIVATE))
                     {

                         _iRemoteModel = new SRoofingUserRemoteModelManager();

                         _iRemoteModel = await SRoofingSync_User_RemoteManager
                        .Sync_User_Remote_Get_UserModel(
              App.Current,
              iOwnerModel,
_iHistoryChatModel.RemoteUserTokenID,
_iHistoryChatModel.RemoteMobileNumberTokenID);

                         if (_iRemoteModel == null)
                         {
                             if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                             {
                                 _iRemoteModel =
                            await SRoofing_UserProfileRemoteManager.SRoofing_User_Get_Remote_Model_ByRemoteUserTokenID(
                                      App.Current,
                                      iOwnerModel,
                                      _iHistoryChatModel.RemoteUserTokenID,
                                      _iHistoryChatModel.RemoteMobileNumberTokenID);
                             }

                         }
                     }

                     else if (_iHistoryChatModel.GroupType == (SRoofingEnum_GroupType.GroupType_GROUP))
                     {

                         _iRemoteModel = null;
                     }

                     _iGroupModel = new SRoofingUserGroupModelManager();


                     _iGroupModel = await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel(
                          App.Current,
                          iOwnerModel,
                          _iHistoryChatModel.GroupTokenID);


                     if (_iGroupModel == null)
                     {
                         if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                         {

                             _iGroupModel = new SRoofingUserGroupModelManager();

                             _iGroupModel =
                            await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                                        App.Current,
                                            iOwnerModel,
                                             _iHistoryChatModel.GroupTokenID);
                         }

                     }






                     SRoofingScreenChatShowScreenModel _iChatScreenModel = new SRoofingScreenChatShowScreenModel();
                     _iChatScreenModel = await SRoofing_ScreenChatShowManager
                   .Chat_Initialize_Chat_Show(
                        App.Current,
                        iOwnerModel,
                        _iRemoteModel,
                        _iGroupModel);



                     if (iParentCode == "landing_dashboard")
                     {

                         await ((Page_Landing_Chat_List)Parent.BindingContext).open_ChatDashboard(_iChatScreenModel);

                     }

                     ////////////////////else if ( iParentCode == "chat_dashboard" )
                     ////////////////////{
                     ////////////////////    await ( ( Page_Chat_Group_List ) Parent.BindingContext ).open_ChatDashboard ( _iChatScreenModel );

                     ////////////////////}


                 })
                         .ConfigureAwait(false);





                        ////await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener_WithChecker (
                        ////        Navigation ,
                        ////        typeof ( Page_Chat_Dashboard ) ,
                        ////    new Page_Chat_Dashboard ( ) ,
                        ////    false ,
                        ////    true );




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
                    null, iGroupModel.RemoteUserTokenID,
                    iGroupModel.RemoteMobileNumberTokenID);

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }

        #endregion

    }
}