
#if ANDROID


using Android.Webkit;
using Android.Widget;

using Java.Interop;

#endif



using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

// 
// 

using S1RoofingMU.iSRoofingApp.iSRoofing_Database;
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumGlobalManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
//////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
//using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Contact;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using Newtonsoft.Json;







namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing
{
    //////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Landing_Chat_List : ContentView
    {

        bool _blnIsInitialized_BroadcastReceiver = false;
        bool _bln_IsInitialized_History_ChatList = false;

        public Page_Landing_Chat_List()
        {

            InitializeComponent();


            RefreshCommand = new Command(Refresh_List);

            CustomizeWebViewHandler();

            if (!_blnIsInitialized_BroadcastReceiver)
            {

                _blnIsInitialized_BroadcastReceiver = true;






                MessagingCenter.Subscribe<App, object>(App.Current, SRoofingEnum_MessageCenter.MessageCenter_GROUP_NEW_LANDING_CHAT, async (snd, arg) =>
                {

                    try
                    {
                        //get the value by `arg`



                        await Task.Delay(1000);

                        //_iParent._bln_IsBusyOnProgress= true;

                        //await _iParent.iProgress_Start();

                        //await Task.Delay(100);

                        _ = Task.Run(async () =>
                        {


                            SRoofingScreenChatShowHistoryMessageModelManager _iNew_HistoryChatMessageModel = new SRoofingScreenChatShowHistoryMessageModelManager();
                            _iNew_HistoryChatMessageModel = arg as SRoofingScreenChatShowHistoryMessageModelManager;




                            await _iParent.Chat_Opener(_iNew_HistoryChatMessageModel);



                        }).ConfigureAwait(false);








                        //////////frm_CountryName.BorderColor = Colors.White;

                        //////////lbl_CountryList.Text = ( arg as SRoofingCountryModel ).CountryName.ToString ( );
                        //////////txt_MobileNumber.Text = "+" + ( arg as SRoofingCountryModel ).CountryMobileCode;// (arg as Employee).m
                        //////////txt_MobileNumber.IsEnabled = true;


                        //////////_register_CountryName = ( arg as SRoofingCountryModel ).CountryName;
                        //////////_register_CountryCode = ( arg as SRoofingCountryModel ).CountryCode;
                        //////////_register_CountryMobileCode = ( arg as SRoofingCountryModel ).CountryMobileCode;

                        ////////////txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;

                        //   _bln_IsCountryName = true;
                    }
                    catch (Exception ex)
                    {
                        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                    }

                });








            }

            BindingContext = this;

        }



        #region Initialize

        //public SRoofingUserOwnerModelManager _iOwnerModel { get; set; }
        public static ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_History_ChatList { get; set; } = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();
        public static ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_History_ChatList_Temp { get; set; } = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

        public static Page_Landing_Dashboard _iParent;





        public async Task Preload(Page_Landing_Dashboard iParent)
        {
            try
            {
                if (iParent != null)
                {
                    _iParent = iParent;
                    //_iOwnerModel = _iParent._iOwnerModel;
                }

                MainThread.BeginInvokeOnMainThread(() =>
      {

          btn_New_Group.Text = _iParent._iLanguageModel.lblText_Group_New_Message;
          ll_ProgressBar_Chat.IsVisible = true;


          web_HistotyChat.Source="WebRTC/Landing_Chat/Index.html";

      });



            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }







        public async Task Initialize(Page_Landing_Dashboard iParent,
            bool bln_IsRefresh)
        {
            try
            {

                if (iParent != null)
                {
                    _iParent = iParent;
                    //_iOwnerModel = _iParent._iOwnerModel;
                }


                //btn_New_Group.Text = _iParent._iLanguageModel.lblText_Group_New_Message;


                arr_History_ChatList_Temp = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                arr_History_ChatList_Temp = await App.Database.Get_List_History_Chat_Message_ByOwnerUserTokenID(_iParent._iOwnerModel, _iParent._iSettingModel);



                if (arr_History_ChatList_Temp == null || arr_History_ChatList_Temp.Count == 0)
                {


                    await Task.Run(async () =>
                       {

                           await Initialize_FirstLoad();


                           await SRoofingSync_ScreenChatShowManager.Sync_ScreenChatShow_Reset_ChatSessionListModel(

           App.Current,
                                    App.iAccountType,
                            _iParent._iOwnerModel);



                       }).ConfigureAwait(continueOnCapturedContext: false);

                }
                else
                {

                    await ShowList();
                    //////////   MessagingCenter.Send<App , string> ( App.Current as App ,
                    //////////SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CHAT_LIST ,
                    //////////SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CHAT_LIST );

                    _bln_IsInitialized_History_ChatList = true;

                    App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;


                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }

        public async Task Initialize_FirstLoad()
        {


            try
            {
                if (!_bln_IsInitialized_History_ChatList)
                {

                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {
                        arr_History_ChatList_Temp = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                        arr_History_ChatList_Temp = await SRoofing_History_ScreenChatShowManager
                             .SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWS(
                             App.Current, _iParent._iOwnerModel, _iParent._iLanguageModel);


                        await ShowList();
                        //////////MessagingCenter.Send<App , string> (
                        //////////App.Current as App ,
                        //////////SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CHAT_LIST ,
                        //////////SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CHAT_LIST );


                        _bln_IsInitialized_History_ChatList = true;

                        App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;
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
        //void Initialize_Command ( ) { 

        //         try
        //        {

        //        Command_Chat_ByUser = new Command ( async ( object iRemoteModel ) =>
        //        {


        //            try
        //                {

        //                await Task.Delay ( 1000 );

        //                //if ( iPage.Navigation.NavigationStack.Count == 0 ||

        //                //iPage.Navigation.NavigationStack.Last ( ).GetType ( ) != typeof ( Page_Chat_View ) )
        //                //    {
        //                //    await iPage.Navigation.PushModalAsync ( new Page_Chat_View ( iRemoteModel ) , true );

        //                //    }
        //                }
        //            catch ( Exception ex )
        //                {
        //                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //                return;
        //                }

        //        } );


        //        }
        //    catch ( Exception ex )
        //        {
        //        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //        return;
        //        }

        //    }



        #endregion



        #region RefreshView

        public ICommand RefreshCommand { get; }


        async Task Fetch_List()
        {
            try
            {
                // refresh your data here
                arr_History_ChatList_Temp = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                arr_History_ChatList_Temp = await SRoofing_History_ScreenChatShowManager
              .SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWS(
              App.Current, _iParent._iOwnerModel, _iParent._iLanguageModel);


                await ShowList();
                //////////  MessagingCenter.Send<App , string> (
                //////////App.Current as App ,
                //////////SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CHAT_LIST ,
                //////////SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CHAT_LIST );


                _bln_IsInitialized_History_ChatList = true;

                App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        async Task ReLoad_List()
        {
            try
            {
                // refresh your data here

                arr_History_ChatList_Temp = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                arr_History_ChatList_Temp = await App.Database.Get_List_History_Chat_Message_ByOwnerUserTokenID(_iParent._iOwnerModel, _iParent._iSettingModel);

                //await SRoofingSync_History_ScreenChatShowManager
                //               .Sync_History_ScreenChatShow_Get_ChatList (
                //            App.Current ,
                //            App.iAccountType ,
                //            _iOwnerModel );

                await ShowList();
                //////////   MessagingCenter.Send<App , string> ( App.Current as App ,
                //////////SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CHAT_LIST ,
                //////////SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CHAT_LIST );


                _bln_IsInitialized_History_ChatList = true;

                App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }


        async void Refresh_List()
        {

            try
            {

                //MainThread.BeginInvokeOnMainThread ( ( ) =>
                //    {
                //        // Code to run on the main thread

                //        refresh_ChatList.IsRefreshing = false;

                //    } );


                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {

                    _ = Task.Run(async () =>
                         {
                             await Fetch_List();

                         }).ConfigureAwait(false);//.Wait ( );
                }
                else
                {
                    _ = Task.Run(async () =>
                    {
                        await ReLoad_List();

                    }).ConfigureAwait(false);//.Wait ( );



                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }


        public async Task Sync_IsExist_NewList()
        {
            try
            {

                _ = Task.Run(async () =>
                            {
                                await ReLoad_List();

                            }).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }

        #endregion


        #region Group_New


        async void btn_New_Group_Clicked(object sender, EventArgs e)
        {
            try
            {

                //////var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick> ( );

                //////if ( objService != null )
                //////{
                //////    objService.KeyboardClick ( );
                //////}

                ////////////////////  if ( PopupNavigation.Instance.PopupStack.Count > 0 )
                ////////////////////  {
                ////////////////////      await Navigation.PopAllPopupAsync ( );
                ////////////////////  }

                await MauiPopup.PopupAction.DisplayPopup(
                  new iSRoofing_Popup.Popup_Group_New(
              _iParent._iApplicationUtitlityModel,
              SRoofingEnum_MessageCenter.MessageCenter_GROUP_NEW_LANDING_CHAT,
                      SRoofingEnum_PopupByCodeManager.PopupByCode_GROUP_NEW));


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }




        #endregion



        #region OpenChat


        public async Task open_ChatDashboard(iSRoofing_Model.Chat.SRoofingScreenChatShowScreenModel _iChatScreenModel)
        {

            try
            {



                //await _iParent.Chat_Opener(_iChatScreenModel );


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }



        public async Task Add_NewGroup(SRoofingScreenChatShowHistoryMessageModelManager _iNew_HistoryChatMessageModel)
        {

            try
            {
                MainThread.BeginInvokeOnMainThread(() =>
      {
          if (_iNew_HistoryChatMessageModel != null)
          {
              arr_History_ChatList.Insert(0, _iNew_HistoryChatMessageModel);
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



        #region Show-List

        async Task ShowList()
        {


            var jsonChatList = JsonConvert.SerializeObject(arr_History_ChatList_Temp, Formatting.None);


            MainThread.BeginInvokeOnMainThread(async () =>
            {


                //web_HistotyChat.Source="WebRTC/Landing_Chat/Index.html";
                await web_HistotyChat.EvaluateJavaScriptAsync("loadJsonList('" + jsonChatList + "')");

                // Code to run on the main thread

                if (refresh_ChatList.IsRefreshing)
                {
                    refresh_ChatList.IsRefreshing = false;
                }

                ll_ProgressBar_Chat.IsVisible = false;

                if (cv_UserChatHistoryList.ItemsSource == null)
                {
                    cv_UserChatHistoryList.ItemsSource = arr_History_ChatList;
                }

                if (arr_History_ChatList_Temp != null)
                {
                    arr_History_ChatList.Clear();

                    for (int i = 0; i < arr_History_ChatList_Temp.Count; i++)
                    {
                        arr_History_ChatList.Add(arr_History_ChatList_Temp[i]);

                        await Task.Delay(SRoofing_EnumGlobalPreference.Global_ROW_LIST_DELAY);
                    }

                }

                _iParent.llProgress_ToggleVisible_ChatList(true, false);

                _bln_IsInitialized_History_ChatList = true;

                App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;




            });



        }








        #endregion

        async void cv_UserChatHistoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {


                if (!_iParent._bln_IsBusyOnProgress)
                {
                    _iParent._bln_IsBusyOnProgress= true;

                    await _iParent.iProgress_Start();

                    //var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

                    //if (objService != null)
                    //{
                    //    objService.KeyboardClick();
                    //}


                    // string xxx = (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager).ItemValue.ToString();




                    //  await SRoofing_AnimationManager.Animation_FadeInOut(App.Current, frm_RowContent);


                    //  await Task.Delay ( 100 );

                    _ = Task.Run(async () =>
                    {


                        SRoofingScreenChatShowHistoryMessageModelManager _iHistoryChatModel = (SRoofingScreenChatShowHistoryMessageModelManager)e.CurrentSelection.FirstOrDefault();//(SRoofingScreenChatShowHistoryMessageModelManager)iObjectModel;

                        SRoofingUserRemoteModelManager _iRemoteModel = null;
                        SRoofingUserGroupModelManager _iGroupModel = null;

                        if (_iHistoryChatModel.GroupType == (SRoofingEnum_GroupType.GroupType_PRIVATE))
                        {

                            _iRemoteModel = new SRoofingUserRemoteModelManager();

                            _iRemoteModel = await SRoofingSync_User_RemoteManager
                           .Sync_User_Remote_Get_UserModel(
                 App.Current,
            _iParent._iOwnerModel,
    _iHistoryChatModel.RemoteUserTokenID,
    _iHistoryChatModel.RemoteMobileNumberTokenID);

                            if (_iRemoteModel == null)
                            {
                                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                                {
                                    _iRemoteModel =
                               await SRoofing_UserProfileRemoteManager.SRoofing_User_Get_Remote_Model_ByRemoteUserTokenID(
                                         App.Current,
                                         _iParent._iOwnerModel,
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
                             _iParent._iOwnerModel,
                             _iHistoryChatModel.GroupTokenID);


                        if (_iGroupModel == null)
                        {
                            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                            {

                                _iGroupModel = new SRoofingUserGroupModelManager();

                                _iGroupModel =
                               await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                                           App.Current,
                                               _iParent._iOwnerModel,
                                                _iHistoryChatModel.GroupTokenID);
                            }

                        }






                        SRoofingScreenChatShowScreenModel _iChatScreenModel = new SRoofingScreenChatShowScreenModel();
                        _iChatScreenModel = await SRoofing_ScreenChatShowManager
                      .Chat_Initialize_Chat_Show(
                           App.Current,
                           _iParent._iOwnerModel,
                           _iRemoteModel,
                           _iGroupModel);


                        //await open_ChatDashboard(_iChatScreenModel);

                        await _iParent.Chat_Opener(_iChatScreenModel, true);


                    })
                     .ConfigureAwait(false);



                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }

        #region WebRTC


        // Define a C# method that you want to invoke from JavaScript
        public static async Task MyCSharpMethod(string jsonObject)
        {
            // Your C# code here
            Console.WriteLine("MyCSharpMethod-WS ::: ");
            ///   DisplayAlert("titleX", "msg-MyCSharpMethod", "OK");
            ///   

            try
            {
                if (!_iParent._bln_IsBusyOnProgress)
                {
                    _iParent._bln_IsBusyOnProgress= true;

                    await _iParent.iProgress_Start();

                    //var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick>();

                    //if (objService != null)
                    //{
                    //    objService.KeyboardClick();
                    //}


                    // string xxx = (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager).ItemValue.ToString();




                    //  await SRoofing_AnimationManager.Animation_FadeInOut(App.Current, frm_RowContent);


                    //  await Task.Delay ( 100 );

                    _ = Task.Run(async () =>
                    {

                        SRoofingScreenChatShowHistoryMessageModelManager _iHistoryChatModel = JsonConvert.DeserializeObject<SRoofingScreenChatShowHistoryMessageModelManager>(jsonObject);
                        //SRoofingScreenChatShowHistoryMessageModelManager _iHistoryChatModel = (SRoofingScreenChatShowHistoryMessageModelManager)e.CurrentSelection.FirstOrDefault();//(SRoofingScreenChatShowHistoryMessageModelManager)iObjectModel;

                        SRoofingUserRemoteModelManager _iRemoteModel = null;
                        SRoofingUserGroupModelManager _iGroupModel = null;

                        if (_iHistoryChatModel.GroupType == (SRoofingEnum_GroupType.GroupType_PRIVATE))
                        {

                            _iRemoteModel = new SRoofingUserRemoteModelManager();

                            _iRemoteModel = await SRoofingSync_User_RemoteManager
                           .Sync_User_Remote_Get_UserModel(
                 App.Current,
            _iParent._iOwnerModel,
    _iHistoryChatModel.RemoteUserTokenID,
    _iHistoryChatModel.RemoteMobileNumberTokenID);

                            if (_iRemoteModel == null)
                            {
                                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                                {
                                    _iRemoteModel =
                               await SRoofing_UserProfileRemoteManager.SRoofing_User_Get_Remote_Model_ByRemoteUserTokenID(
                                         App.Current,
                                         _iParent._iOwnerModel,
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
                             _iParent._iOwnerModel,
                             _iHistoryChatModel.GroupTokenID);


                        if (_iGroupModel == null)
                        {
                            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                            {

                                _iGroupModel = new SRoofingUserGroupModelManager();

                                _iGroupModel =
                               await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                                           App.Current,
                                               _iParent._iOwnerModel,
                                                _iHistoryChatModel.GroupTokenID);
                            }

                        }






                        SRoofingScreenChatShowScreenModel _iChatScreenModel = new SRoofingScreenChatShowScreenModel();
                        _iChatScreenModel = await SRoofing_ScreenChatShowManager
                      .Chat_Initialize_Chat_Show(
                           App.Current,
                           _iParent._iOwnerModel,
                           _iRemoteModel,
                           _iGroupModel);


                        //await open_ChatDashboard(_iChatScreenModel);

                        await _iParent.Chat_Opener(_iChatScreenModel, true);


                    })
                     .ConfigureAwait(false);



                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }


        void CustomizeWebViewHandler()
        {
#if ANDROID

            Microsoft.Maui.Handlers.WebViewHandler.Mapper.Add("WebChromeClientXXX", (handler, view) =>
            {

                //Android.Webkit.WebView.SetWebContentsDebuggingEnabled(true);

                //handler.PlatformView.Settings.UseWideViewPort= true;
                //handler.PlatformView.Settings.JavaScriptEnabled= true;
                //handler.PlatformView.Settings.JavaScriptCanOpenWindowsAutomatically= true;
                //handler.PlatformView.Settings.MediaPlaybackRequiresUserGesture= false;


                //handler.PlatformView.Settings.AllowContentAccess=true;
                //handler.PlatformView.Settings.AllowFileAccess=true;
                //handler.PlatformView.Settings.SetAppCacheEnabled(true);
                //handler.PlatformView.Settings.DomStorageEnabled=true;


                //handler.PlatformView.SetWebViewClient(new CustomWebViewClient());
                //handler.PlatformView.SetWebChromeClient(new CustomWebChromeClient());


                ////////////////////////////////////

                //////////handler.PlatformView.SetWebViewClient(new JavascriptWebViewClient($"javascript: {JavascriptFunction}"));
                handler.PlatformView.AddJavascriptInterface(new JsBridge(), "jsBridge");

            });
#elif WINDOWS
#elif IOS
#endif
        }








#if ANDROID


        public class JsBridge : Java.Lang.Object
        {
            //readonly WeakReference<HybridWebViewRenderer> HybridWebViewMainRenderer;

            //public JsBridge(HybridWebViewRenderer hybridRenderer)
            //{
            //    HybridWebViewMainRenderer = new WeakReference<HybridWebViewRenderer>(hybridRenderer);
            //}

            [JavascriptInterface]
            [Export("invokeAction")]
            //[Export()]
            public void InvokeAction(string data)
            {

                MainThread.BeginInvokeOnMainThread(() =>
                {

                    //Toast.MakeText(Android.App.Application.Context, "InvokeAction :: " + data, ToastLength.Long).Show();

                    Task.Run(async () =>
                         {

                             await MyCSharpMethod(data);
                         });

                    //DisplayAlert("titleX", "msg-JsBridge", "OK");

                    // Code to run on the main thread

                    Console.WriteLine("JavascriptInterface :: " + data);

                });
                //if (HybridWebViewMainRenderer != null && HybridWebViewMainRenderer.TryGetTarget(out var hybridRenderer))
                //{
                //    ((UCView_HybridWebView)hybridRenderer.Element).InvokeAction(data);
                //}
            }
        }



#elif IOS

  public class JsBridge {
  
  }

#endif






        #endregion


    }
}