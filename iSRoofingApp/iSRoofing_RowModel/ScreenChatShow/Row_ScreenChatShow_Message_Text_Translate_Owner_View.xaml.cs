using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
 
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;

 
 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.ScreenChatShow
{
    ////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Row_ScreenChatShow_Message_Text_Translate_Owner_View : ContentView
    {
        public Row_ScreenChatShow_Message_Text_Translate_Owner_View()
        {
            InitializeComponent();
            // 

            //  Initialize_Command ( );

            ////Content.BindingContext = this;
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
                typeof(Row_ScreenChatShow_Message_Text_Only_Box_Owner_View),
                new SRoofingUserOwnerModelManager(),
                BindingMode.TwoWay);




        //iGroupModel
        public SRoofingScreenChatShowMessageModelManager iGroupModel
        {
            get
            {
                return (SRoofingScreenChatShowMessageModelManager)GetValue(iGroupModelProperty);
            }
            set
            {
                SetValue(iGroupModelProperty, value);
            }
        }

        public static BindableProperty iGroupModelProperty =
            BindableProperty.Create(nameof(iGroupModel), typeof(SRoofingScreenChatShowMessageModelManager), typeof(Row_ScreenChatShow_Message_Text_Only_Box_Owner_View), new SRoofingScreenChatShowMessageModelManager(),
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

                    //ctrl_AvatarName.iGroupModel = iGroupModel;
                    //ctrl_AvatarName.iOwnerModel = iOwnerModel;


                    //Initialize_Command();

                }
            }
        }

        #endregion




        #region Commands_List

        //public ICommand Command_Chat_ByUser { get; private set; }


        public static readonly BindableProperty Command_Chat_ByUserProperty = BindableProperty.Create(nameof(Command_Chat_ByUser), typeof(ICommand), typeof(Row_ScreenChatShow_Message_Text_Only_Box_Owner_View), null);
        public ICommand Command_Chat_ByUser
        {
            get => (ICommand)GetValue(Command_Chat_ByUserProperty);
            set => SetValue(Command_Chat_ByUserProperty, value);
        }

        void Initialize_Command()
        {

            //////try
            //////{

            //////    Command_Chat_ByUser = new Command(async (object iObjectModel) =>
            //////    {


            //////        try
            //////        {

            //////            // await Task.Delay ( 1000 );
            //////            SRoofingUserRemoteModelManager _iRemoteModel = null;
            //////            SRoofingUserGroupModelManager _iGroupModel = null;

            //////            SRoofingScreenChatShowMessageModelManager _iHistoryChatModel = (SRoofingScreenChatShowMessageModelManager)iObjectModel;

            //////            if (_iHistoryChatModel.GroupType == (SRoofingEnum_GroupType.GroupType_PRIVATE))
            //////            {

            //////                _iRemoteModel = new SRoofingUserRemoteModelManager();

            //////                _iRemoteModel =
            //////                      await SRoofing_UserProfileRemoteManager.SRoofing_User_Get_Remote_Model_ByRemoteUserTokenID(
            //////                                App.Current,
            //////                                iOwnerModel,
            //////                                _iHistoryChatModel.RemoteUserTokenID,
            //////                                _iHistoryChatModel.RemoteMobileNumberTokenID);


            //////            }
            //////            else if (_iHistoryChatModel.GroupType == (SRoofingEnum_GroupType.GroupType_GROUP))
            //////            {

            //////                _iRemoteModel = null;
            //////            }

            //////            _iGroupModel = new SRoofingUserGroupModelManager();
            //////            _iGroupModel =
            //////                await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

            //////                            App.Current,
            //////                                iOwnerModel,
            //////                                 _iHistoryChatModel.GroupTokenID);


            //////            await SRoofing_ScreenChatShowManager
            //////           .Chat_Initialize_Chat_Show(
            //////                App.Current,
            //////                iOwnerModel,
            //////                _iRemoteModel,
            //////                _iGroupModel);


            //////            await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener(
            //////                    Navigation,
            //////                new Page_Chat_Dashboard(),
            //////                false,
            //////                true);




            //////            //if ( iPage.Navigation.NavigationStack.Count == 0 ||

            //////            //iPage.Navigation.NavigationStack.Last ( ).GetType ( ) != typeof ( Page_Chat_View ) )
            //////            //    {
            //////            //    await iPage.Navigation.PushModalAsync ( new Page_Chat_View ( _iHistoryChatModel ) , true );

            //////            //    }
            //////        }
            //////        catch (Exception ex)
            //////        {
            //////            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            //////            return;
            //////        }

            //////    });


            //////}
            //////catch (Exception ex)
            //////{
            //////    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            //////    return;
            //////}

        }



        #endregion




    }
}