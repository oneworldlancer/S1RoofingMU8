using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
//////////////////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Image;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Video;

 
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar
{
    //[XamlCompilation ( XamlCompilationOptions.Compile )]
    public partial class SnackBar_Command_GalleryOption : TemplatedView
    {



        public static readonly BindableProperty MyStringProperty = BindableProperty.Create ( "MyString" , typeof ( string ) , typeof ( SnackBar_Command_GalleryOption ) , default ( string ) );
        public string MyString
        {
            get
            {
                return ( string ) GetValue ( MyStringProperty );
            }
            set
            {
                SetValue ( MyStringProperty , value );

            }
        }





        public static readonly BindableProperty GalleryIsEnableProperty = BindableProperty.Create ( "GalleryIsEnable" , typeof ( bool ) , typeof ( SnackBar_Command_GalleryOption ) , default ( bool ) );
        public bool GalleryIsEnable
        {
            get
            {
                return ( bool ) GetValue ( GalleryIsEnableProperty );
            }
            set
            {
                SetValue ( GalleryIsEnableProperty , value );

            }
        }





        public static readonly BindableProperty TitleTextProperty = BindableProperty.Create ( "TitleText" , typeof ( string ) , typeof ( SnackBar_Command_GalleryOption ) , default ( string ) );
        public string TitleText
        {
            get
            {
                return ( string ) GetValue ( TitleTextProperty );
            }
            set
            {
                SetValue ( TitleTextProperty , value );

            }
        }


        public static readonly BindableProperty PickImageTextProperty = BindableProperty.Create ( "PickImageText" , typeof ( string ) , typeof ( SnackBar_Command_GalleryOption ) , default ( string ) );
        public string PickImageText
        {
            get
            {
                return ( string ) GetValue ( PickImageTextProperty );
            }
            set
            {
                SetValue ( PickImageTextProperty , value );

            }
        }



        public static readonly BindableProperty PickVideoTextProperty = BindableProperty.Create ( "PickVideoText" , typeof ( string ) , typeof ( SnackBar_Command_GalleryOption ) , default ( string ) );
        public string PickVideoText
        {
            get
            {
                return ( string ) GetValue ( PickVideoTextProperty );
            }
            set
            {
                SetValue ( PickVideoTextProperty , value );

            }
        }

        public static readonly BindableProperty CaptureVideoTextProperty = BindableProperty.Create ( "CaptureVideoText" , typeof ( string ) , typeof ( SnackBar_Command_GalleryOption ) , default ( string ) );
        public string CaptureVideoText
        {
            get
            {
                return ( string ) GetValue ( CaptureVideoTextProperty );
            }
            set
            {
                SetValue ( CaptureVideoTextProperty , value );

            }
        }



        public static readonly BindableProperty CaptureImageTextProperty = BindableProperty.Create ( "CaptureImageText" , typeof ( string ) , typeof ( SnackBar_Command_GalleryOption ) , default ( string ) );
        public string CaptureImageText
        {
            get
            {
                return ( string ) GetValue ( CaptureImageTextProperty );
            }
            set
            {
                SetValue ( CaptureImageTextProperty , value );

            }
        }



        public static readonly BindableProperty GalleryIconProperty = BindableProperty.Create ( "GalleryIcon" , typeof ( string ) , typeof ( SnackBar_Command_GalleryOption ) , default ( string ) );
        public string GalleryIcon
        {
            get
            {
                return ( string ) GetValue ( GalleryIconProperty );
            }
            set
            {
                SetValue ( GalleryIconProperty , value );

            }
        }


        public static readonly BindableProperty GalleryColorProperty = BindableProperty.Create ( "GalleryColor" , typeof ( Color ) , typeof ( SnackBar_Command_GalleryOption ) , default ( Color ) );
        public Color GalleryColor
        {
            get { return ( Color ) GetValue ( GalleryColorProperty ); }
            set { SetValue ( GalleryColorProperty , value ); }
        }








        //public static readonly BindableProperty ButtonTextColorProperty = BindableProperty.Create ( "ButtonTextColor" , typeof ( Color ) , typeof ( SnackBar_Command_GalleryOption ) , default ( Color ) );

        //private string myStringProperty;
        //public string MyStringProperty
        //	{
        //	get { return myStringProperty; }
        //	set
        //		{
        //		myStringProperty = value;
        //		OnPropertyChanged ( nameof ( MyStringProperty ) ); // Notify that there was a change on this property
        //		}
        //	}








        public static readonly BindableProperty ButtonTextColorProperty = BindableProperty.Create ( "ButtonTextColor" , typeof ( Color ) , typeof ( SnackBar_Command_GalleryOption ) , default ( Color ) );
        public Color ButtonTextColor
        {
            get { return ( Color ) GetValue ( ButtonTextColorProperty ); }
            set { SetValue ( ButtonTextColorProperty , value ); }
        }

        public static readonly BindableProperty MessageProperty = BindableProperty.Create ( "Message" , typeof ( string ) , typeof ( SnackBar_Command_GalleryOption ) , default ( string ) );
        public string Message
        {
            get { return ( string ) GetValue ( MessageProperty ); }
            set { SetValue ( MessageProperty , value ); }
        }

        public static readonly BindableProperty CloseButtonTextProperty = BindableProperty.Create ( "CloseButtonText" , typeof ( string ) , typeof ( SnackBar_Command_GalleryOption ) , "Close" );
        public string CloseButtonText
        {
            get { return ( string ) GetValue ( CloseButtonTextProperty ); }
            set { SetValue ( CloseButtonTextProperty , value ); }
        }

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create ( "FontSize" , typeof ( float ) , typeof ( SnackBar_Command_GalleryOption ) , default ( float ) );
        public float FontSize
        {
            get { return ( float ) GetValue ( FontSizeProperty ); }
            set { SetValue ( FontSizeProperty , value ); }
        }

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create ( "TextColor" , typeof ( Color ) , typeof ( SnackBar_Command_GalleryOption ) , Colors.White );
        public Color TextColor
        {
            get { return ( Color ) GetValue ( TextColorProperty ); }
            set { SetValue ( TextColorProperty , value ); }
        }

        public static readonly BindableProperty CloseButtonBackGroundColorProperty = BindableProperty.Create ( "CloseButtonBackGroundColor" , typeof ( Color ) , typeof ( SnackBar_Command_GalleryOption ) , Colors.Transparent );
        public Color CloseButtonBackGroundColor
        {
            get { return ( Color ) GetValue ( CloseButtonBackGroundColorProperty ); }
            set { SetValue ( CloseButtonBackGroundColorProperty , value ); }
        }






        public uint AnimationDuration { get; set; }

        #region IsOpen
        public static readonly BindableProperty IsOpenProperty = BindableProperty.Create ( "IsOpen" , typeof ( bool ) , typeof ( SnackBar_Command_GalleryOption ) , false , propertyChanged: IsOpenChanged );
        public bool IsOpen
        {
            get { return ( bool ) GetValue ( IsOpenProperty ); }
            set { SetValue ( IsOpenProperty , value ); }
        }

        private static async void IsOpenChanged ( BindableObject bindable , object oldValue , object newValue )
        {
            bool isOpen;

            if ( bindable != null && newValue != null )
            {
                var control = ( SnackBar_Command_GalleryOption ) bindable;
                isOpen = ( bool ) newValue;

                if ( control.IsOpen == false )
                {
                    await control.Close ( );
                }
                else
                {
                    //////////await control.Open ( _iParent , control.Message , null );
                }
            }
        }

        #endregion

        public readonly BindableProperty FontFamilyProperty = BindableProperty.Create ( "FontFamily" , typeof ( string ) , typeof ( SnackBar_Command_GalleryOption ) , default ( string ) );
        public string FontFamily
        {
            get { return ( string ) GetValue ( FontFamilyProperty ); }
            set { SetValue ( FontFamilyProperty , value ); }
        }

        public SnackBar_Command_GalleryOption ( )
        {
            IsVisible = false;
            AnimationDuration = 150;
            InitializeComponent ( );



        }

        async Task Initialize ( )
        {

            try
            {

                TitleText = _iLanguageModel.lblText_Gallery_Message;
                PickImageText = _iLanguageModel.lblText_Gallery_PickImage;
                PickVideoText = _iLanguageModel.lblText_Gallery_PickVideo;
                CaptureImageText = _iLanguageModel.lblText_Gallery_CaptureImage;
                CaptureVideoText = _iLanguageModel.lblText_Gallery_CaptureVideo;

                //  GalleryIcon = "img_circle_black.png";

                //////if ( Preferences.Get ( "user_IsLogin" , false ) )
                //////{

                //////    GalleryIsEnable = true;
                //////    GalleryIcon = "img_circle_black.png";
                //////    GalleryColor = Colors.Black;
                //////    //MyString = Preferences.Get ( "user_IsLogin" , false ).ToString ( );

                //////}
                //////else
                //////{
                //////    //MyString = Preferences.Get ( "user_IsLogin" , false ).ToString ( );

                //////    GalleryIsEnable = false;
                //////    GalleryIcon = "img_circle_silver.png";
                //////    GalleryColor = Colors.Silver;

                //////}

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }

        private async void CloseButton_Clicked ( object sender , EventArgs e )
        {
          await  Close ( );
        }

        public async Task Close ( )
        {
            await this.TranslateTo ( 0 , 100 , AnimationDuration );
            Message = string.Empty;
            IsOpen = IsVisible = false;
        }

        //////////static Page_ScreenChatShow_Dashboard _iParent;
        SRoofingLanguageTranslateModel _iLanguageModel;

        public async Task OpenLoader ( object iParent , string message , SRoofingLanguageTranslateModel iLanguageModel )
        {

            //////////_iParent = (Page_ScreenChatShow_Dashboard)iParent;
            _iLanguageModel = iLanguageModel;

            await Initialize ( );


          //  IsVisible = true;
            Message = message;

            //await this.TranslateTo ( 0 , 0 , AnimationDuration );

            //  await Task.Delay ( 10000 );
            IsVisible = false;

            //  IsOpen = IsVisible = false;

            // Close ( );

            //return "true";
        }


        public async Task Open ( object iParent , string message , SRoofingLanguageTranslateModel iLanguageModel )
        {

            //_iParent = iParent;
            //_iLanguageModel = iLanguageModel;

            //Initialize ( );


            IsVisible = true;
            //Message = message;

            await this.TranslateTo ( 0 , 0 , AnimationDuration );

            await Task.Delay ( 10000 );

          await  Close ( );

            //return "true";
        }








        async private void lbl_OpenScanner_Clicked ( object sender , EventArgs e )
        {
            try
            {


                //await SRoofing_Page_OpenerManager.Page_Opener (
                //        Navigation ,
                //    new Page_QRCode ( ) ,
                //    false ,
                //    true );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }


        }

        async private void lbl_OpenGallery_Clicked ( object sender , EventArgs e )
        {

            try
            {


                //await SRoofing_Page_OpenerManager.Page_Opener (
                //		Navigation ,
                //	new Page_Gallery ( ) ,
                //	false ,
                //	true );


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }


        }

        async void img_Close_Clicked ( object sender , EventArgs e )
        {

            try
            {

                Close ( );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }

        async void sl_CaptureVideo_Clicked ( object sender , EventArgs e )
        {

            try
            {
                var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick> ( );

                if ( objService != null )
                {
                    objService.KeyboardClick ( );
                }

                await Task.Delay ( 500 );

                await TakeVideoAsync ( );


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }

        async void sl_PickVideo_Clicked ( object sender , EventArgs e )
        {

            try

            {
                var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick> ( );

                if ( objService != null )
                {
                    objService.KeyboardClick ( );
                }

                await Task.Delay ( 500 );

                await GalleryPicker_Pick_Video ( );





            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }

        async void sl_CaptureImage_Clicked ( object sender , EventArgs e )
        {
            try
            {

                var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick> ( );

                if ( objService != null )
                {
                    objService.KeyboardClick ( );
                }

                await Task.Delay ( 500 );


                await TakePhotoAsync ( );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }

        async void sl_PickImage_Clicked ( object sender , EventArgs e )
        {

            try

            {
                var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick> ( );

                if ( objService != null )
                {
                    objService.KeyboardClick ( );
                }

                await Task.Delay ( 500 );

                await GalleryPicker_Pick_Image ( );





            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }










        #region Gallery

        bool _bln_IsOnProgress_PickerImage;
        async Task GalleryPicker_Pick_Image ( )
        {

   //////////         try
   //////////         {

   //////////             await _iParent.GalleryOption_Close ( );


   //////////             _bln_IsOnProgress_PickerImage = true;

   //////////             string str_FilePath = null;


   //////////             FileResult result = await MediaPicker.PickPhotoAsync ( new MediaPickerOptions
   //////////             {
   //////////                 Title = _iLanguageModel.lblText_Picker_Image_Message
   //////////             } );

   //////////             if ( result != null )
   //////////             {
   //////////                 str_FilePath = result.FullPath;

   //////////                 // var stream = await result.OpenReadAsync ( );

   //////////                 //  resultImage.Source = ImageSource.FromStream ( ( ) => stream );

   //////////              _=     Task.Run ( async ( ) =>
   //////////                 {
   //////////                     await SRoofing_ScreenChatShow_Image_MessageManager
   //////////                     .Owner_ScreenChatShowMessage_Image_MessageWS (
   //////////                                            App.Current ,
   //////////               App.iAccountType ,
   //////////       _iParent._iApplicationUtilityModel ,
   //////////            _iParent._iSettingModel ,  
   //////////              _iParent._iLanguageModel  ,  

   //////////                 _iParent._iOwnerModel ,
   //////////       _iParent._iChatScreenModel.iGroupModel ,

   //////////   _iParent._iSpeechModel ,


   //////////                  _iParent._iOwner_LanguageCode_IN ,
   //////////                   _iParent._iOwner_LanguageCode_OUT ,


   //////////                         _iParent._iChatScreenModel.GroupTokenID ,


   //////////                                    SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_SharePhotoMessage ,
   //////////                       _iLanguageModel.lblText_ScreenChatShow_ShareImage_Message ,

   //////////              "media" ,
   //////////                             "image" ,

   //////////str_FilePath ,

   //////////            SRoofing_TimeManager.Time_GenerateToken ( ) ,
   //////////null ,
   //////////     null ,
   //////////              new System.Uri ( str_FilePath ) ,
   //////////              str_FilePath , "0" , "0" ,
   //////////   true );

   //////////                 } ).ConfigureAwait ( false );


   //////////             }

   //////////             _bln_IsOnProgress_PickerImage = false;
   //////////         }
   //////////         catch ( Exception ex )
   //////////         {
   //////////             SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
   //////////             return;
   //////////         }
        }










        async Task GalleryPicker_Pick_Video ( )
        {

   //////////         try
   //////////         {


   //////////             await _iParent.GalleryOption_Close ( );



   //////////             string str_FilePath = null;



   //////////             var fileResult = await MediaPicker.PickVideoAsync ( new MediaPickerOptions
   //////////             {
   //////////                 Title = _iLanguageModel.lblText_Picker_Video_Message
   //////////             } );

   //////////             if ( fileResult != null )
   //////////             {
   //////////                 str_FilePath = fileResult.FullPath;

   //////////                 // var stream = await result.OpenReadAsync ( );

   //////////                 //  resultImage.Source = ImageSource.FromStream ( ( ) => stream );

   //////////                _=   Task.Run ( async ( ) =>
   //////////                 {
   //////////                     await SRoofing_ScreenChatShow_Video_MessageManager
   //////////                     .Owner_ScreenChatShowMessage_Video_MessageWS (
   //////////                                            App.Current ,
   //////////               App.iAccountType ,
   //////////         _iParent._iApplicationUtilityModel ,
   //////////          _iParent._iSettingModel ,  
             
   //////////          _iParent._iLanguageModel , 
   //////////               _iParent._iOwnerModel ,
   //////////_iParent._iChatScreenModel.iGroupModel ,

   //////////_iParent._iSpeechModel ,


   //////////               _iParent._iOwner_LanguageCode_IN ,
   //////////                _iParent._iOwner_LanguageCode_OUT ,


   //////////                    _iParent._iChatScreenModel.GroupTokenID ,


   //////////                                    SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareVideoMessage ,
   //////////                       _iLanguageModel.lblText_ScreenChatShow_ShareVideo_Message ,

   //////////              "media" ,
   //////////                             "video" ,

   //////////                             fileResult ,

   //////////str_FilePath ,

   //////////            SRoofing_TimeManager.Time_GenerateToken ( ) ,
   //////////               str_FilePath ,
   //////////              new System.Uri ( str_FilePath ) ,
   //////////              str_FilePath ,
   //////////               "0" , "0" ,
   //////////   true );

   //////////                 } ).ConfigureAwait ( false );



   //////////                 //var stream = await fileResult.OpenReadAsync ( );

   //////////                 //  resultImage.Source = ImageSource.FromStream ( ( ) => stream );

   //////////                 ////////  Task.Run ( async ( ) =>
   //////////                 ////////{
   //////////                 ////////       await SRoofing_ScreenChatShow_Video_MessageManager
   //////////                 ////////       .Owner_ScreenChatShowMessage_Video_MessageWS (
   //////////                 ////////                    App.Current ,
   //////////                 ////////       App.iAccountType ,
   //////////                 ////////     _iParent. _iApplicationUtilityModel ,
   //////////                 ////////            _iParent. _iSettingModel ,
   //////////                 ////////           _iParent. _iOwnerModel ,
   //////////                 ////////         _iParent. _iSpeechModel ,
   //////////                 ////////        _iParent. _iOwner_Incoming_LanguageCode ,  
   //////////                 ////////        _iParent. _iOwner_Outgoing_LanguageCode ,
   //////////                 ////////          _iParent. _iChatScreenModel.GroupTokenID ,
   //////////                 ////////        SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareVideoMessage ,
   //////////                 ////////       "Shared video" ,

   //////////                 //////// "media" ,
   //////////                 ////////               "video" ,
   //////////                 ////////                     fileResult ,
   //////////                 ////////                      fileResult.FullPath ,

   //////////                 ////////                   SRoofing_TimeManager.Time_GenerateToken ( ) ,
   //////////                 ////////                  null , "0" , "0" , "0" , true );

   //////////                 ////////   } ).ConfigureAwait ( false );//.Wait ( );;//.Wait ( );

   //////////             }

















   //////////             ////////             FileResult result = await MediaPicker.PickVideoAsync ( new MediaPickerOptions
   //////////             ////////             {
   //////////             ////////                 Title = _iLanguageModel.lblText_Picker_Video_Message
   //////////             ////////             } );

   //////////             ////////             if ( result != null )
   //////////             ////////             {
   //////////             ////////                 str_FilePath = result.FullPath;

   //////////             ////////                 // var stream = await result.OpenReadAsync ( );

   //////////             ////////                 //  resultImage.Source = ImageSource.FromStream ( ( ) => stream );

   //////////             ////////                   Task.Run ( async ( ) =>
   //////////             ////////                 {
   //////////             ////////                     await SRoofing_ScreenChatShow_Video_MessageManager
   //////////             ////////                     .Owner_ScreenChatShowMessage_Video_MessageWS (
   //////////             ////////                                            App.Current ,
   //////////             ////////               App.iAccountType ,
   //////////             ////////         _iParent._iApplicationUtilityModel ,
   //////////             ////////          _iParent._iSettingModel ,
   //////////             ////////               _iParent._iOwnerModel ,
   //////////             ////////      _iParent._iChatScreenModel.iGroupModel ,

   //////////             ////////_iParent._iSpeechModel ,


   //////////             ////////               _iParent._iOwner_LanguageCode_IN ,
   //////////             ////////                _iParent._iOwner_LanguageCode_OUT ,


   //////////             ////////                    _iParent._iChatScreenModel.iGroupModel.GroupTokenID ,


   //////////             ////////                                    SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareVideoMessage ,
   //////////             ////////                       _iLanguageModel.lblText_ScreenChatShow_ShareVideo_Message ,

   //////////             ////////              "media" ,
   //////////             ////////                             "video" ,

   //////////             ////////                             result ,

   //////////             ////////str_FilePath ,

   //////////             ////////            SRoofing_TimeManager.Time_GenerateToken ( ) ,
   //////////             ////////               str_FilePath ,
   //////////             ////////              new System.Uri ( str_FilePath ) ,
   //////////             ////////              str_FilePath ,
   //////////             ////////               "0" , "0" ,
   //////////             ////////   true );

   //////////             ////////                 } ).ConfigureAwait ( false );


   //////////             //////////}


   //////////         }
   //////////         catch ( Exception ex )
   //////////         {
   //////////             SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
   //////////             return;
   //////////         }
        }





        #endregion





        #region Capture_Image


        async Task TakePhotoAsync ( )
        {
            //////////try
            //////////{

            //////////  await  _iParent.GalleryOption_Close ( );

            //////////    string str_FilePath = null;

            //////////    var photo = await MediaPicker.CapturePhotoAsync ( );
            //////////    await LoadPhotoAsync ( photo );
            //////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( $"CapturePhotoAsync COMPLETED: {str_FilePath}" );
            //////////}
            //////////catch ( FeatureNotSupportedException fnsEx )
            //////////{
            //////////    // Feature is not supported on the device
            //////////}
            //////////catch ( PermissionException pEx )
            //////////{
            //////////    // Permissions not granted
            //////////}
            //////////catch ( Exception ex )
            //////////{
            //////////    SRoofing_DebugManager.Debug_ShowSystemMessage ( $"CapturePhotoAsync THREW: {ex.Message}" );
            //////////}
        }

        async Task LoadPhotoAsync ( FileResult photo )
        {


   //////////         try
   //////////         {

   //////////             string str_FilePath = null;
   //////////             // canceled
   //////////             if ( photo == null )
   //////////             {
   //////////                 str_FilePath = null;
   //////////                 return;
   //////////             }

   //////////             // save the file into local storage
   //////////             var newFile = Path.Combine ( FileSystem.Current.CacheDirectory , photo.FileName );
   //////////             using ( var stream = await photo.OpenReadAsync ( ) )
   //////////             using ( var newStream = File.OpenWrite ( newFile ) )
   //////////                 await stream.CopyToAsync ( newStream );

   //////////             str_FilePath = newFile;


   //////////             /////////////////////

   //////////            _=   Task.Run ( async ( ) =>
   //////////                {
   //////////                    await SRoofing_ScreenChatShow_Image_MessageManager
   //////////                    .Owner_ScreenChatShowMessage_Image_MessageWS (
   //////////                                  App.Current ,
   //////////               App.iAccountType ,
   //////////       _iParent._iApplicationUtilityModel ,
   //////////            _iParent._iSettingModel ,  
   //////////            _iParent._iLanguageModel  ,
   //////////                 _iParent._iOwnerModel ,
   //////////       _iParent._iChatScreenModel.iGroupModel ,

   //////////   _iParent._iSpeechModel ,


   //////////                  _iParent._iOwner_LanguageCode_IN ,
   //////////                   _iParent._iOwner_LanguageCode_OUT ,


   //////////                         _iParent._iChatScreenModel.GroupTokenID ,


   //////////                                    SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_SharePhotoMessage ,
   //////////                       _iLanguageModel.lblText_ScreenChatShow_ShareImage_Message ,

   //////////              "media" ,
   //////////                             "image" ,
   //////////str_FilePath ,

   //////////            SRoofing_TimeManager.Time_GenerateToken ( ) ,
   //////////null ,
   //////////     null ,
   //////////              new System.Uri ( str_FilePath ) ,
   //////////              str_FilePath , "0" , "0" ,
   //////////   true );

   //////////                } ).ConfigureAwait ( false );




   //////////         }
   //////////         catch ( Exception ex )
   //////////         {
   //////////             SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
   //////////             return;
   //////////         }

        }

        #endregion




        #region Capture_Video


        async Task TakeVideoAsync ( )
        {
            //////////try
            //////////{

            //////////    await _iParent.GalleryOption_Close ( );



            //////////    var fileResult = await MediaPicker.CaptureVideoAsync ( );



            //////////    ////////  Task.Run ( async ( ) =>
            //////////    ////////{
            //////////    ////////       await SRoofing_ScreenChatShow_Video_MessageManager
            //////////    ////////       .Owner_ScreenChatShowMessage_Video_MessageWS (
            //////////    ////////                    App.Current ,
            //////////    ////////       App.iAccountType ,
            //////////    ////////     _iParent. _iApplicationUtilityModel ,
            //////////    ////////            _iParent. _iSettingModel ,
            //////////    ////////           _iParent. _iOwnerModel ,
            //////////    ////////         _iParent. _iSpeechModel ,
            //////////    ////////        _iParent. _iOwner_Incoming_LanguageCode ,
            //////////    ////////         _iParent. _iOwner_Outgoing_LanguageCode ,
            //////////    ////////          _iParent. _iChatScreenModel.GroupTokenID ,
            //////////    ////////        SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareVideoMessage ,
            //////////    ////////       "Shared video" ,

            //////////    //////// "media" ,
            //////////    ////////               "video" ,
            //////////    ////////                     fileResult , fileResult.FullPath ,

            //////////    ////////                   SRoofing_TimeManager.Time_GenerateToken ( ) ,
            //////////    ////////                  null , "0" , "0" , "0" , true );

            //////////    ////////   } );//.ConfigureAwait ( false );//.Wait ( );;//.Wait ( );

            //////////    await LoadVideoAsync ( fileResult );
            //////////    Console.WriteLine ( $"CapturePhotoAsync COMPLETED: {PhotoPath}" );
            //////////}
            //////////catch ( FeatureNotSupportedException fnsEx )
            //////////{
            //////////    // Feature is not supported on the device
            //////////}
            //////////catch ( PermissionException pEx )
            //////////{
            //////////    // Permissions not granted
            //////////}
            //////////catch ( Exception ex )
            //////////{
            //////////    Console.WriteLine ( $"CapturePhotoAsync THREW: {ex.Message}" );
            //////////}
        }

        string PhotoPath;

        async Task LoadVideoAsync ( FileResult fileResult )
        {


    //////////        try
    //////////        {
    //////////            // canceled
    //////////            if ( fileResult == null )
    //////////            {
    //////////                PhotoPath = null;
    //////////                return;
    //////////            }
    //////////            // save the file into local storage
    //////////            var newFile = Path.Combine ( FileSystem.Current.CacheDirectory , fileResult.FileName );
    //////////            using ( var stream = await fileResult.OpenReadAsync ( ) )
    //////////            using ( var newStream = File.OpenWrite ( newFile ) )
    //////////                await stream.CopyToAsync ( newStream );

    //////////            PhotoPath = newFile;


    //////////            _=  Task.Run ( async ( ) =>
    //////////                {
    //////////                    await SRoofing_ScreenChatShow_Video_MessageManager
    //////////                    .Owner_ScreenChatShowMessage_Video_MessageWS (
    //////////                                 App.Current ,
    //////////              App.iAccountType ,
    //////////        _iParent._iApplicationUtilityModel ,
    //////////         _iParent._iSettingModel ,  
             
    //////////         _iParent._iLanguageModel , 
    //////////              _iParent._iOwnerModel ,
    //////////     _iParent._iChatScreenModel.iGroupModel ,

    //////////_iParent._iSpeechModel ,


    //////////              _iParent._iOwner_LanguageCode_IN ,
    //////////               _iParent._iOwner_LanguageCode_OUT ,


    //////////                   _iParent._iChatScreenModel.GroupTokenID ,


    //////////                                   SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareVideoMessage ,
    //////////                      _iLanguageModel.lblText_ScreenChatShow_ShareVideo_Message ,

    //////////             "media" ,
    //////////                            "video" ,

    //////////                            fileResult ,

    ////////// fileResult.FullPath ,

    //////////           SRoofing_TimeManager.Time_GenerateToken ( ) ,
    //////////               fileResult.FullPath ,
    //////////             new System.Uri ( fileResult.FullPath ) ,
    //////////              fileResult.FullPath ,
    //////////              "0" , "0" ,
    //////////  true );







    //////////                    ////////      App.Current ,
    //////////                    ////////      App.iAccountType ,
    //////////                    ////////    _iParent. _iApplicationUtilityModel ,
    //////////                    ////////           _iParent. _iSettingModel ,
    //////////                    ////////          _iParent. _iOwnerModel ,
    //////////                    ////////        _iParent. _iSpeechModel ,
    //////////                    ////////       _iParent. _iOwner_Incoming_LanguageCode ,
    //////////                    ////////        _iParent. _iOwner_Outgoing_LanguageCode ,
    //////////                    ////////         _iParent. _iChatScreenModel.GroupTokenID ,
    //////////                    ////////       SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareVideoMessage ,
    //////////                    ////////      "Shared video" ,

    //////////                    ////////"media" ,
    //////////                    ////////              "video" ,
    //////////                    ////////                    fileResult , fileResult.FullPath ,

    //////////                    ////////                  SRoofing_TimeManager.Time_GenerateToken ( ) ,
    //////////                    ////////                 null , "0" , "0" , "0" , true );

    //////////                } );//.ConfigureAwait ( false );//.Wait ( );;//.Wait ( );

    //////////        }
    //////////        catch ( Exception ex )
    //////////        {
    //////////            SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
    //////////            return;
    //////////        }

        }

        #endregion





    }
}