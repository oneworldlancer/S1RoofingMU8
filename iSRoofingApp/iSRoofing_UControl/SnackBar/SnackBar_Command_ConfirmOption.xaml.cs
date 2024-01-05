using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
//////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
//using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Contact;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;



using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Chatter;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar
{
    //[XamlCompilation ( XamlCompilationOptions.Compile )]
    public partial class SnackBar_Command_ConfirmOption : TemplatedView
    {



        public static readonly BindableProperty MessageTextConfirmProperty = BindableProperty.Create("MessageTextConfirm", typeof(string), typeof(SnackBar_Command_ConfirmOption), default(string));
        public string MessageTextConfirm
        {
            get
            {
                return (string)GetValue(MessageTextConfirmProperty);
            }
            set
            {
                SetValue(MessageTextConfirmProperty, value);

            }
        }



        public static readonly BindableProperty YESProperty = BindableProperty.Create("YES", typeof(string), typeof(SnackBar_Command_ConfirmOption), default(string));
        public string YES
        {
            get
            {
                return (string)GetValue(YESProperty);
            }
            set
            {
                SetValue(YESProperty, value);

            }
        }



        public static readonly BindableProperty NOProperty = BindableProperty.Create("NO", typeof(string), typeof(SnackBar_Command_ConfirmOption), default(string));
        public string NO
        {
            get
            {
                return (string)GetValue(NOProperty);
            }
            set
            {
                SetValue(NOProperty, value);

            }
        }





        public static readonly BindableProperty GalleryIsEnableProperty = BindableProperty.Create("GalleryIsEnable", typeof(bool), typeof(SnackBar_Command_ConfirmOption), default(bool));
        public bool GalleryIsEnable
        {
            get
            {
                return (bool)GetValue(GalleryIsEnableProperty);
            }
            set
            {
                SetValue(GalleryIsEnableProperty, value);

            }
        }





        public static readonly BindableProperty GalleryIconProperty = BindableProperty.Create("GalleryIcon", typeof(string), typeof(SnackBar_Command_ConfirmOption), default(string));
        public string GalleryIcon
        {
            get
            {
                return (string)GetValue(GalleryIconProperty);
            }
            set
            {
                SetValue(GalleryIconProperty, value);

            }
        }





        public static readonly BindableProperty GalleryColorProperty = BindableProperty.Create("GalleryColor", typeof(Color), typeof(SnackBar_Command_ConfirmOption), default(Color));
        public Color GalleryColor
        {
            get { return (Color)GetValue(GalleryColorProperty); }
            set { SetValue(GalleryColorProperty, value); }
        }








        //public static readonly BindableProperty ButtonTextColorProperty = BindableProperty.Create ( "ButtonTextColor" , typeof ( Color ) , typeof ( SnackBar_Command_ConfirmOption ) , default ( Color ) );

        //private string MessageTextConfirmProperty;
        //public string MessageTextConfirmProperty
        //	{
        //	get { return MessageTextConfirmProperty; }
        //	set
        //		{
        //		MessageTextConfirmProperty = value;
        //		OnPropertyChanged ( nameof ( MessageTextConfirmProperty ) ); // Notify that there was a change on this property
        //		}
        //	}








        public static readonly BindableProperty ButtonTextColorProperty = BindableProperty.Create("ButtonTextColor", typeof(Color), typeof(SnackBar_Command_ConfirmOption), default(Color));
        public Color ButtonTextColor
        {
            get { return (Color)GetValue(ButtonTextColorProperty); }
            set { SetValue(ButtonTextColorProperty, value); }
        }

        public static readonly BindableProperty MessageProperty = BindableProperty.Create("Message", typeof(string), typeof(SnackBar_Command_ConfirmOption), default(string));
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly BindableProperty CloseButtonTextProperty = BindableProperty.Create("CloseButtonText", typeof(string), typeof(SnackBar_Command_ConfirmOption), "Close");
        public string CloseButtonText
        {
            get { return (string)GetValue(CloseButtonTextProperty); }
            set { SetValue(CloseButtonTextProperty, value); }
        }

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(float), typeof(SnackBar_Command_ConfirmOption), default(float));
        public float FontSize
        {
            get { return (float)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(SnackBar_Command_ConfirmOption), Colors.White);
        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public static readonly BindableProperty CloseButtonBackGroundColorProperty = BindableProperty.Create("CloseButtonBackGroundColor", typeof(Color), typeof(SnackBar_Command_ConfirmOption), Colors.Transparent);
        public Color CloseButtonBackGroundColor
        {
            get { return (Color)GetValue(CloseButtonBackGroundColorProperty); }
            set { SetValue(CloseButtonBackGroundColorProperty, value); }
        }






        public uint AnimationDuration { get; set; }

        #region IsOpen
        public static readonly BindableProperty IsOpenProperty = BindableProperty.Create("IsOpen", typeof(bool), typeof(SnackBar_Command_ConfirmOption), false, propertyChanged: IsOpenChanged);
        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        private static void IsOpenChanged(BindableObject bindable, object oldValue, object newValue)
        {
            bool isOpen;

            if (bindable != null && newValue != null)
            {
                var control = (SnackBar_Command_ConfirmOption)bindable;
                isOpen = (bool)newValue;

                if (control.IsOpen == false)
                {
                    control.Close();
                }
                else
                {
                    control.Open(control.Message);
                }
            }
        }

        #endregion

        public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create("FontFamily", typeof(string), typeof(SnackBar_Command_ConfirmOption), default(string));
        public string FontFamily
        {
            get { return (string)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }

        public SnackBar_Command_ConfirmOption()
        {
            IsVisible = false;
            AnimationDuration = 150;
            InitializeComponent();



        }

        async Task Initialize()
        {

            try
            {

                MessageTextConfirm = _iLanguageModel.lblText_Message_AreYouSure;

                YES = _iLanguageModel.lblText_Command_Yes;
                NO = _iLanguageModel.lblText_Command_No;


                //if ( Preferences.Get ( "user_IsLogin" , false ) )
                //	{

                //                GalleryIsEnable = true;
                //                GalleryIcon = "img_circle_black.png";
                //                GalleryColor = Colors.Black;
                //	//MessageTextConfirm = Preferences.Get ( "user_IsLogin" , false ).ToString ( );

                //	}
                //else
                //	{
                //	//MessageTextConfirm = Preferences.Get ( "user_IsLogin" , false ).ToString ( );

                //            	GalleryIsEnable = false;
                //	GalleryIcon = "img_circle_silver.png";
                //	GalleryColor = Colors.Silver;

                //	}


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }



        static Type _iParent;
        SRoofingLanguageTranslateModel _iLanguageModel;
        SRoofingUserOwnerModelManager _iOwnerModel;
        //  SRoofingUserGroupModelManager _iGroupModel;
        string _iGroupTokenID;

        public async Task OpenLoader(
            Type iParent,
            SRoofingLanguageTranslateModel iLanguageModel,
                SRoofingUserOwnerModelManager iOwnerModel,
                string GroupTokenID)
        //SRoofingUserGroupModelManager iGroupModel )
        {

            _iParent = iParent;
            _iLanguageModel = iLanguageModel;

            _iOwnerModel = iOwnerModel;
            _iGroupTokenID = GroupTokenID;

            await Initialize();


            //  IsVisible = true;
            //  Message = message;

            //await this.TranslateTo ( 0 , 0 , AnimationDuration );

            //  await Task.Delay ( 10000 );
            IsVisible = false;
            //   IsVisible = true;

            //  IsOpen = IsVisible = false;

            // Close ( );

            //return "true";
        }

        object _iViewValue;
        Type _iParentView;
        string _iViewCode = "0";
        //View_Chat_Chatters_List iParent , string message , SRoofingLanguageTranslateModel iLanguageModel 
        public async Task Open(
            Type iParentView,
          string iViewCode, object iViewValue)
        {

            _iParentView=iParentView;


            _iViewCode=iViewCode;

            _iViewValue= iViewValue;

            //_iParent = iParent;
            //_iLanguageModel = iLanguageModel;

            //Initialize ( );


            IsVisible = true;
            //Message = message;

            await this.TranslateTo(0, 0, AnimationDuration);

            await Task.Delay(10000);

            await Close();

            //return "true";
        }











        private async void CloseButton_Clicked(object sender, EventArgs e)
        {
            await Close();
        }

        public async Task Close()
        {
            await this.TranslateTo(0, 100, AnimationDuration);
            Message = string.Empty;
            IsOpen = IsVisible = false;
        }


        public async void Open(string message)
        {


            await Initialize();


            IsVisible = true;
            Message = message;
            await this.TranslateTo(0, 0, AnimationDuration);

            await Task.Delay(7000);

            await Close();

            //return "true";
        }

        async private void lbl_OpenScanner_Clicked(object sender, EventArgs e)
        {
            try
            {


                //await SRoofing_Page_OpenerManager.Page_Opener (
                //        Navigation ,
                //    new Page_QRCode ( ) ,
                //    false ,
                //    true );

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }

        async private void lbl_OpenGallery_Clicked(object sender, EventArgs e)
        {

            try
            {


                //await SRoofing_Page_OpenerManager.Page_Opener (
                //		Navigation ,
                //	new Page_Gallery ( ) ,
                //	false ,
                //	true );


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }

        private async void img_Close_Clicked(object sender, EventArgs e)
        {

            try
            {

                await Close();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private async void btn_Command_YES_Clicked(object sender, EventArgs e)
        {

            try
            {
                //Picker_Contact_List

                if (_iParentView == typeof(View_Chat_Chatters_List))
                {


                    await ((Picker_Chatter_Dashboard)Parent.BindingContext)
                        .snackBar_Action_ContactRemove(_iParentView,
          _iViewCode, _iViewValue);

                    //             if (((View_Chat_Chatters_List)Parent.BindingContext)._pending_iRemoteModel != null)
                    //             {

                    //                 _ = Task.Run(async () =>
                    //            {

                    //                await SRoofing_UserGroupManager.UserGroup_User_REMOVE_From_Group_ByGroupTokenID(
                    //                    App.Current,
                    //App.iAccountType,
                    //_iOwnerModel,
                    //_iGroupTokenID,
                    //         ((View_Chat_Chatters_List)Parent.BindingContext)._pending_iRemoteModel.OwnerUserTokenID,
                    // ((View_Chat_Chatters_List)Parent.BindingContext)._pending_iRemoteModel.OwnerMobileNumberTokenID);
                    //            }).ConfigureAwait(false);



                    //                 ((View_Chat_Chatters_List)Parent.BindingContext)
                    //                .arr_UserChattersList.Remove(((View_Chat_Chatters_List)Parent.BindingContext)._pending_iRemoteModel);

                    //             }

                }



                else if (_iParentView == typeof(View_Chat_Chatters_Picker_List))
                {


                    await ((Picker_Chatter_Dashboard)Parent.BindingContext)
                        .snackBar_Action_ContactAdd(_iParentView,
          _iViewCode, _iViewValue);

                }




                else if (_iParentView == typeof(View_Chat_Share_List))
                {


                    await ((Picker_Chatter_Dashboard)Parent.BindingContext)
                        .snackBar_Action_ShareMessage(_iParentView,
          _iViewCode, _iViewValue);

                }




                //    else     if (_iParentView == typeof(View_Chat_Chatters_Picker_List))
                //         {
                //             if (((View_Chat_Chatters_List)Parent.BindingContext)._pending_iRemoteModel != null)
                //             {

                //                 _ = Task.Run(async () =>
                //            {

                //                await SRoofing_UserGroupManager.UserGroup_User_REMOVE_From_Group_ByGroupTokenID(
                //                    App.Current,
                //App.iAccountType,
                //_iOwnerModel,
                //_iGroupTokenID,
                //         ((View_Chat_Chatters_List)Parent.BindingContext)._pending_iRemoteModel.OwnerUserTokenID,
                // ((View_Chat_Chatters_List)Parent.BindingContext)._pending_iRemoteModel.OwnerMobileNumberTokenID);
                //            }).ConfigureAwait(false);



                //                 ((View_Chat_Chatters_List)Parent.BindingContext)
                //                .arr_UserChattersList.Remove(((View_Chat_Chatters_List)Parent.BindingContext)._pending_iRemoteModel);

                //             }

                //         }











                //////////////////         else if (_iParent == typeof(Picker_Contact_List))
                //////////////////         {
                //////////////////             if (((Picker_Contact_List)Parent.BindingContext)._pending_iRemoteModel != null)
                //////////////////             {


                //////////////////                 _ = Task.Run(async () =>
                //////////////////    {

                //////////////////        await SRoofing_UserGroupManager.SRoofing_UserGroup_ADD_User_To_Group_ByGroupTokenID(
                //////////////////                    App.Current,
                //////////////////App.iAccountType,
                //////////////////_iOwnerModel,
                //////////////////_iGroupTokenID,
                //////////////////         ((Picker_Contact_List)Parent.BindingContext)._pending_iRemoteModel.RemoteUserTokenID,
                ////////////////// ((Picker_Contact_List)Parent.BindingContext)._pending_iRemoteModel.RemoteMobileNumberTokenID);
                //////////////////    }).ConfigureAwait(false);





                //////////////////                 ((Picker_Contact_List)Parent.BindingContext)
                //////////////////                     .arr_UserMarshalList.Remove(((Picker_Contact_List)Parent.BindingContext)._pending_iRemoteModel);

                //////////////////             }

                //////////////////         }



                await Close();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        private async void btn_Command_NO_Clicked(object sender, EventArgs e)
        {
            try
            {

                await Close();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }
    }
}