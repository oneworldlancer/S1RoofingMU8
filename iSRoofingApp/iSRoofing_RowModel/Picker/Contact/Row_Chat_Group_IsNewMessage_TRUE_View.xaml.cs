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
 
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Share;



namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.Picker.Contact
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Row_Chat_Group_IsNewMessage_TRUE_View : ContentView
    {
        public Row_Chat_Group_IsNewMessage_TRUE_View()
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
                typeof(Row_Chat_Group_IsNewMessage_TRUE_View),
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
            BindableProperty.Create(nameof(iGroupModel), typeof(SRoofingScreenChatShowHistoryMessageModelManager), typeof(Row_Chat_Group_IsNewMessage_TRUE_View), new SRoofingScreenChatShowHistoryMessageModelManager(),
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
                    //Initialize_Command ( );

                }
            }
        }

        #endregion




        #region Commands_List

        //public ICommand Command_Chat_ByUser { get; private set; }


        //public static readonly BindableProperty Command_Chat_ByUserProperty = BindableProperty.Create(nameof(Command_Chat_ByUser), typeof(ICommand), typeof(Row_Chat_Group_IsNewMessage_TRUE_View), null);
        //public ICommand Command_Chat_ByUser
        //{
        //    get => (ICommand)GetValue(Command_Chat_ByUserProperty);
        //    set => SetValue(Command_Chat_ByUserProperty, value);
        //}

        //public static readonly BindableProperty CloseButtonClickProperty = BindableProperty.Create ( nameof ( CloseButtonClick ) , typeof ( ICommand ) , typeof ( HeaderView ) , null );
        //public ICommand CloseButtonClick
        //    {
        //    get => ( ICommand ) GetValue ( CloseButtonClickProperty );
        //    set => SetValue ( CloseButtonClickProperty , value );
        //    }

        //void Initialize_Command()
        //{

        //    try
        //    {

        //        Command_Chat_ByUser = new Command ( async ( object iObjectModel ) =>
        //        {
        //            try
        //            {
        //                var objService = DependencyService.Get<iSRoofing_DependencyService_SoundClick> ( );

        //                if ( objService != null )
        //                {
        //                    objService.KeyboardClick ( );
        //                }

        //                    ( (View_Chat_Share_List) Parent.BindingContext )
        //                            .Gallery_Share ( iGroupModel );




        //            }
        //            catch ( Exception ex )
        //            {
        //                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //                return;
        //            }

        //        } );


        //    }
        //    catch ( Exception ex )
        //    {
        //        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //        return;
        //    }

        //}



        #endregion



        //#region Avatar


        //async void frm_Avatar_Tapped ( object sender , EventArgs e )
        //{
        //    try
        //    {
        //        await SRoofing_UserProfileRemoteManager
        //            .SRoofing_UserProfile_Open_Remote_Profile_ByRemoteUserTokenID (
        //            App.Current ,
        //            Navigation ,
        //            iOwnerModel ,
        //            null , iGroupModel.RemoteUserTokenID ,
        //            iGroupModel.RemoteMobileNumberTokenID );

        //    }
        //    catch ( Exception ex )
        //    {
        //        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //        return;
        //    }


        //}

        //#endregion

        async void btn_Command_Clicked ( object sender , EventArgs e )
        {


            try
            {



                await((View_Chat_Share_List)Parent.BindingContext)
                   .pendingRemove_ShareMedia((SRoofingScreenChatShowHistoryMessageModelManager)iGroupModel);





                //((View_Chat_Share_List)Parent.BindingContext)
                //        .Gallery_Share(iGroupModel);



            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }
    }
}