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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.YouTube;

using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Gallery.Chat;


using S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;





namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.Gallery.ChatBackground
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






        public SRoofingKeyValueModelManager iGroupModel
        {
            get
            {
                return (SRoofingKeyValueModelManager)GetValue(iGroupModelProperty);
            }
            set
            {
                SetValue(iGroupModelProperty, value);
            }
        }

        public static BindableProperty iGroupModelProperty =
            BindableProperty.Create(nameof(iGroupModel), typeof(SRoofingKeyValueModelManager), typeof(Row_Chat_Private_IsNewMessage_FALSE_View), new SRoofingKeyValueModelManager(),
                BindingMode.TwoWay);

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == iGroupModelProperty.PropertyName)
            {
                if (iGroupModel != null)
                {
                    // Update ContentView properties and elements.
                    //  Initialize_Command ( );

                    //imgBtn_Thum.Source = iGroupModel.ImageDefaultServerURL;
                    //imgBtn_Thum.Source =  ImageSource.FromFile(iGroupModel.ItemValue);




                    //frm_Avatar.WidthRequest =  iGroupModel.ItemWidth;
                    //frm_Avatar.HeightRequest =  iGroupModel.ItemHeight;


                    ////lbl_Play.Text = iGroupModel.CommandText_View;
                    //lbl_Download.Text = iGroupModel.CommandText_Download;
                    //lbl_Share.Text = iGroupModel.CommandText_Share;




                }
            }
        }

        #endregion



    }
}