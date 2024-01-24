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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.YouTube;

using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Gallery.Chat;


using S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;





namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.Gallery.Chat
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Row_Gallery_Image_View : ContentView
    {
        public Row_Gallery_Image_View()
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
            BindableProperty.Create(nameof(iGroupModel), typeof(SRoofingScreenChatShowMessageModelManager), typeof(Row_Chat_Private_IsNewMessage_FALSE_View), new SRoofingScreenChatShowMessageModelManager(),
                BindingMode.TwoWay);

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == iGroupModelProperty.PropertyName)
            {
                if (iGroupModel != null)
                {
                    // Update ContentView properties and elements.
                    Initialize_Command();

                    if (File.Exists(iGroupModel.ImageDefaultPath))
                    {
                        imgBtn_Thum.Source = iGroupModel.ImageDefaultPath;

                    }
                    else
                    {
                        imgBtn_Thum.Source = iGroupModel.ImageDefaultServerURL;

                    }






                    grd_Avatar.WidthRequest = iGroupModel.iGallery_iMedia_Width;
                    grd_Avatar.HeightRequest = iGroupModel.iGallery_iMedia_Height;


                    lbl_Download.Text = iGroupModel.CommandText_Download;
                    lbl_Share.Text = iGroupModel.CommandText_Share;




                }
            }
        }

        #endregion




        #region Commands_List

        //public ICommand Command_Chat_ByUser { get; private set; }


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

                    //////await Task.Delay ( 500 );


                    //////await ( ( Page_Chat_Gallery_List ) Parent.BindingContext ).Video_Share (
                    //////    iGroupModel );


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


        async void imgBtn_Thum_Tapped(object sender, EventArgs e)
        {
            try
            {


                await ((Page_Chat_Gallery_List)Parent.BindingContext)
                        .Image_Preview(iGroupModel);

                ////await ( ( Page_Chat_Gallery_List ) Parent.BindingContext ).Video_Play (
                ////                 iGroupModel.VideoID );

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }

        #endregion



        async void sl_Play_Tapped(object sender, EventArgs e)
        {
            try
            {

                await ((Page_Chat_Gallery_List)Parent.BindingContext)
                        .Image_Preview(iGroupModel);



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }

        //async void sl_Share_Tapped(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        await ((Page_Chat_Gallery_List)Parent.BindingContext)
        //           .Media_Share(
        //                      SRoofingEnum_File_Type.ShareType_Image,
        //             iGroupModel);


        //    }
        //    catch (Exception ex)
        //    {
        //        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //        return;
        //    }

        //}

        async void sl_Download_Tapped(object sender, TappedEventArgs e)
        {
            try
            {
                await ((Page_Chat_Gallery_List)Parent.BindingContext)
                   .Media_Download(
                              SRoofingEnum_File_Type.ShareType_Image,
                     iGroupModel);


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }

        async void sl_Share_Tapped(object sender, TappedEventArgs e)
        {
            try
            {
                await((Page_Chat_Gallery_List)Parent.BindingContext)
                   .Media_Share(
                              SRoofingEnum_File_Type.ShareType_Image,
                     iGroupModel);


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }
    }
}