using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_HTTPManager;






namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.ScreenChatShow
{
    ////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Row_ScreenChatShow_Message_Image_Box_Owner_View : ContentView
    {
        public Row_ScreenChatShow_Message_Image_Box_Owner_View()
        {
            InitializeComponent();
            // 

            //  Initialize_Command ( );

            ////Content.BindingContext = this;
        }




        #region Bindings

        //iMediaDimension
        public int iMediaDimension
        {
            get
            {
                return (int)GetValue(iMediaDimensionProperty);
            }
            set
            {
                SetValue(iMediaDimensionProperty, value);
            }
        }

        public static BindableProperty iMediaDimensionProperty =
            BindableProperty.Create(
                nameof(iMediaDimension),
                typeof(int),
                typeof(Row_ScreenChatShow_Message_Image_Box_Owner_View),
                0,
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
                typeof(Row_ScreenChatShow_Message_Image_Box_Owner_View),
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
            BindableProperty.Create(nameof(iGroupModel), typeof(SRoofingScreenChatShowMessageModelManager), typeof(Row_ScreenChatShow_Message_Image_Box_Owner_View), new SRoofingScreenChatShowMessageModelManager(),
                BindingMode.TwoWay);


        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            try
            {
                // https://heartbeat.comet.ml/using-ffimageloading-in-xamaring-forms-for-caching-and-optimizing-images-48e381be226b
                //https://github.com/luberda-molinet/FFImageLoading/wiki/Xamarin.Forms-API
                // if (propertyName == iOwnerModelProperty.PropertyName)
                if (propertyName == iGroupModelProperty.PropertyName)
                {
                    if (iGroupModel != null)
                    {
                        // Update ContentView properties and elements.
                        lbl_MessageText.Text = iGroupModel.MessageText;


                        string xxx = iGroupModel.ImageDefaultPath ;



                        //img_Thum.Source = "/storage/emulated/0/Download/7521121026864ca4b372f60b144508ec.jpg";



                        //  img_Thum.Source = iGroupModel.ImageDefaultServerURL;
                        //  img_Thum.Source = iGroupModel.ImageDefaultServerURL;
                        //img_Thum.Source = iGroupModel.ImageDefaultPath;
                        //////////if (File.Exists(iGroupModel.ImageDefaultPath))
                        //////////{
                        //////////    img_Thum.Source = iGroupModel.ImageDefaultPath ;

                        //////////}
                        //////////else
                        //////////{
                        //////////    //img_Thum.Source = ImageSource.FromUri(new Uri(iGroupModel.ImageDefaultServerURL));
                        //////////    img_Thum.Source =  (iGroupModel.ImageDefaultServerURL );

                        //////////}



                        //////////try
                        //////////{



                        //////////    Task.Run(async () =>
                        //////////    {

                        //////////        try
                        //////////        {

                        //////////            if (Preferences.Get("img", null)!= null)
                        //////////            {
                        //////////                var imageBytes = Convert.FromBase64String(Preferences.Get("img", null));


                        //////////                MemoryStream imageDecodeStream = new(imageBytes);

                        //////////                MainThread.BeginInvokeOnMainThread(() =>
                        //////////                {
                        //////////                    // Code to run on the main thread
                        //////////                    img_Thum.Source = ImageSource.FromStream(() => imageDecodeStream);
                        //////////                });


                        //////////            }
                        //////////            else
                        //////////            {

                        //////////                var _client = SRoofing_HTTPManager.HTTP_Get_HttpClientInstance();
                        //////////                _client.DefaultRequestHeaders.ConnectionClose=true;

                        //////////                Stream stm = await _client.GetStreamAsync("https://s1r.chat/_iUMedia/_iUImage/img_1690955857233.jpg");
                        //////////                //    Stream stm = await _client.GetStreamAsync("https://oneworldlancer.ddns.net/S1Roofing/_iUMedia/_iUImage/img_1573442000971.jpg");


                        //////////                Preferences.Set("img", await SRoofing_MediaManager.Media_ConvertToBase64(stm));


                        //////////                var imageBytes = Convert.FromBase64String(Preferences.Get("img", null));


                        //////////                MemoryStream imageDecodeStream = new(imageBytes);



                        //////////                ///////////////////////////
                        //////////                ///
                        //////////                MainThread.BeginInvokeOnMainThread(() =>
                        //////////                {
                        //////////                    // Code to run on the main thread



                        //////////                    //img_Test.Source= ImageSource.FromStream(() => stm);

                        //////////                    //StreamReader reader = new StreamReader(stm);
                        //////////                    // string text = reader.ReadToEnd();

                        //////////                    /////////////////////////////////
                        //////////                    ///
                        //////////                    //string base64EncodedString = "SGVsbG8sIHdvcmxkIQ==";
                        //////////                    //byte[ ] byteArray = Convert.FromBase64String(base64EncodedString);
                        //////////                    //string imageSource = $"data:image/png;base64,{Convert.ToBase64String(byteArray)}";


                        //////////                    //byte[ ] byteArray = Convert.FromBase64String(Preferences.Get("img", null)); // Encoding.ASCII.GetBytes(Preferences.Get("img", null));
                        //////////                    //MemoryStream stream = new MemoryStream(byteArray);
                        //////////                    //string imageSource = $"data:image/png;base64,{Convert.ToBase64String(byteArray)}";
                        //////////                    //////img_Test.Source= ImageSource.FromStream(() => stream);

                        //////////                    img_Thum.Source = ImageSource.FromStream(() => imageDecodeStream);
                        //////////                });



                        //////////                //await imageDecodeStream.DisposeAsync();

                        //////////                _client.Dispose();


                        //////////            }



                        //////////            //using ()
                        //////////            //                   {
                        //////////            //                       // Do any logic with the image stream, save it,...

                        //////////            //                       //  img_Test.Source = ImageSource.FromUri(new Uri("https://s1r.chat/_iUMedia/_iUImage/img_1690955857233.jpg"));
                        //////////            //                       //Console.WriteLine("********** STREAM **********"+ stm.Length);
                        //////////            //                       //  img_Test.Source =CreateImageSourceFromStream(stm);


                        //////////            //                   }











                        //////////            //using (_client)
                        //////////            //{
                        //////////            //    using ()
                        //////////            //    {
                        //////////            //        // Do any logic with the image stream, save it,...

                        //////////            //        //  img_Test.Source = ImageSource.FromUri(new Uri("https://s1r.chat/_iUMedia/_iUImage/img_1690955857233.jpg"));
                        //////////            //        //Console.WriteLine("********** STREAM **********"+ stm.Length);
                        //////////            //        //  img_Test.Source =CreateImageSourceFromStream(stm);


                        //////////            //    }
                        //////////            //}

                        //////////        }
                        //////////        catch (Exception ex)
                        //////////        {
                        //////////            Console.WriteLine("********** STREAM-EX **********"+ ex.Message);
                        //////////            return;
                        //////////        }

                        //////////    });



                        //////////}
                        //////////catch (Exception ex)
                        //////////{
                        //////////    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                        //////////    return;

                        //////////}



                        lbl_MessageTime.iGroupModel = iGroupModel;




                        //////var converter = new SRoofingConverter_ImageSourceURL();
                        //////var imageUrl = iGroupModel.ImageDefaultServerURL;
                        //////var imageSource = (ImageSource)converter.Convert(imageUrl, typeof(ImageSource), null, CultureInfo.CurrentCulture);
                        //  img_Thum.Source = iGroupModel.ImageDefaultServerURL;
                        ///  img_Thum.Source = iGroupModel.ImageDefaultPath;





                        //  int xxx=   ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iMediaDimension;

                        //////var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

                        //////// Orientation (Landscape, Portrait, Square, Unknown)
                        ////////var orientation = mainDisplayInfo.Orientation;

                        ////////// Rotation (0, 90, 180, 270)
                        ////////var rotation = mainDisplayInfo.Rotation;

                        //////// Width (in pixels)
                        //////var width = mainDisplayInfo.Width;

                        ////////// Height (in pixels)
                        ////////var height = mainDisplayInfo.Height;

                        //////// Screen density
                        //////var density = mainDisplayInfo.Density;
                        //////int ScreenWidth = ( int ) ( width / density ); // device independent pixels
                        //////                                               //  int   ScreenHeight = (int)(height / density); // device independent pixels



                        //////grd_Media.WidthRequest = ScreenWidth / 2;
                        //////grd_Media.HeightRequest = ScreenWidth / 2;

                        grd_Media.WidthRequest = iGroupModel.iScreenChatShow_iMedia_Width;
                        grd_Media.HeightRequest = iGroupModel.iScreenChatShow_iMedia_Height;


                        Initialize_Command();

                    }
                }





            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;

            }

        }

        #endregion




        #region Commands_List

        //public ICommand Command_Chat_ByUser { get; private set; }


        public static readonly BindableProperty Command_Chat_ByUserProperty = BindableProperty.Create(nameof(Command_Chat_ByUser), typeof(ICommand), typeof(Row_ScreenChatShow_Message_Image_Box_Owner_View), null);
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

        #region Gallery




        async void bx_MediaContent_Tapped(object sender, EventArgs e)
        {
            //try
            //{

            //    var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick> ( );

            //    if ( objService != null )
            //    {
            //        objService.KeyboardClick ( );
            //    }


            //   // await Task.Delay ( 100 );

            //    MainThread.BeginInvokeOnMainThread ( async ( ) =>
            //    {


            //        await Navigation.PushModalAsync ( new Page_Chat_Gallery_List (
            //     ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iApplicationUtilityModel ,
            //     ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iSettingModel ,
            //            ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iSpeechModel ,
            //       ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iLanguageModel ,
            //        ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iOwnerModel ,

            //     ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iOwner_LanguageCode_IN ,
            //       ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iOwner_LanguageCode_OUT ,
            //      ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iChatScreenModel ,
            //      iGroupModel ) );




            //    } );
            //}
            //catch ( Exception ex )
            //{
            //    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            //    return;
            //}

        }





        async void img_Thum_Clicked(object sender, EventArgs e)
        {

            try
            {

                var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

                if (objService != null)
                {
                    objService.KeyboardClick();
                }


                await Task.Delay(100);

                //MainThread.BeginInvokeOnMainThread ( async ( ) =>
                //{


                //    await Navigation.PushModalAsync ( new Page_Chat_Gallery_List (
                // ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iApplicationUtilityModel ,
                // ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iSettingModel ,
                //    ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iOwnerModel ,
                //( ( Page_Chat_Dashboard ) Parent.BindingContext )._iSpeechModel ,
                // ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iOwner_LanguageCode_IN ,
                //   ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iOwner_LanguageCode_OUT ,
                //  ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iChatScreenModel  ,
                //  iGroupModel));




                //} );
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }

        async void imgBtn_Gallery_Clicked(object sender, EventArgs e)
        {

            //try
            // {

            //     var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick> ( );

            //     if ( objService != null )
            //     {
            //         objService.KeyboardClick ( );
            //     }


            //     await Task.Delay ( 100 );


            //         MainThread.BeginInvokeOnMainThread (async ( ) =>
            //     {


            //         await Navigation.PushModalAsync ( new Page_Chat_Gallery_List (
            //      ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iApplicationUtilityModel ,
            //       ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iSettingModel ,
            //             ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iSpeechModel ,
            //        ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iLanguageModel ,
            //         ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iOwnerModel ,
            //( ( Page_Chat_Dashboard ) Parent.BindingContext )._iOwner_LanguageCode_IN ,
            //        ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iOwner_LanguageCode_OUT ,
            //       ( ( Page_Chat_Dashboard ) Parent.BindingContext )._iChatScreenModel ,
            //       iGroupModel ) );




            //     } );



            // }
            // catch ( Exception ex )
            // {
            //     SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            //     return;
            // }

        }


        #endregion

        private void imgBtn_Gallery_Clicked(object sender, TappedEventArgs e)
        {

        }
    }
}