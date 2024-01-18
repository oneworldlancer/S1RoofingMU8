using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

// 
// 

using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumGlobalManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;





namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing
{
    //////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Landing_Call_List : ContentView
    {

        bool _bln_IsInitialized_History_CallList = false;
        bool _blnIsInitialized_BroadcastReceiver = false;

        public Page_Landing_Call_List()
        {

            InitializeComponent();


            RefreshCommand = new Command(Refresh_List);

            // Initialize_Command ( );


            if (!_blnIsInitialized_BroadcastReceiver)
            {

                _blnIsInitialized_BroadcastReceiver = true;


                MessagingCenter.Subscribe<App, object>(App.Current, SRoofingEnum_MessageCenter.MessageCenter_GROUP_NEW_LANDING_CALL, async (snd, arg) =>
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




        }




        #region Initialize

        //public SRoofingUserOwnerModelManager _iOwnerModel { get; set; }

        public static ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager> arr_History_CallList { get; set; } = new ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>();
        public static ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager> arr_History_CallList_Temp { get; set; } = new ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>();

        Page_Landing_Dashboard _iParent;

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
                    ll_ProgressBar_Call.IsVisible = true;
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

                if (!_bln_IsInitialized_History_CallList)
                {

                    //_bln_IsInitialized_History_CallList = true;

                    _ = Task.Run(async () =>
                 {


                     arr_History_CallList_Temp = new ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>();

                     arr_History_CallList_Temp = await App.Database.Get_List_History_Call_Message_ByOwnerUserTokenID(_iParent._iOwnerModel,
                         _iParent._iSettingModel);



                     ////await SRoofingSync_History_ScreenCallShowManager
                     ////                       .Sync_History_ScreenCallShow_Get_CallList (
                     ////                    App.Current ,
                     ////                    App.iAccountType ,
                     ////                    _iOwnerModel );





                     if (arr_History_CallList_Temp == null || arr_History_CallList_Temp.Count == 0)
                     {


                         _ = Task.Run(async () =>
                        {

                            await Initialize_FirstLoad();


                            await SRoofingSync_ScreenCallShowManager.Sync_ScreenCallShow_Reset_CallSessionListModel(

            App.Current,
                                     App.iAccountType,
                             _iParent._iOwnerModel);



                        }).ConfigureAwait(false);

                     }
                     else
                     {

                         await ShowList();


                         //   MessagingCenter.Send<App , string> ( App.Current as App ,
                         //SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CALL_LIST ,
                         //SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CALL_LIST );


                         _bln_IsInitialized_History_CallList = true;

                         App._blnSyncHistory_ScreenCallShow_CALL_Landing_List = false;
                     }

                 }).ConfigureAwait(false);//.Wait ( );;



                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


            //////try
            //////{

            //////    if ( iParent != null )
            //////    {
            //////        _iParent = iParent;
            //////        _iOwnerModel = _iParent._iOwnerModel;
            //////    }




            //////    arr_History_CallList_Temp = await SRoofingSync_History_ScreenCallShowManager
            //////                           .Sync_History_ScreenCallShow_Get_CallList (
            //////                        App.Current ,
            //////                        App.iAccountType ,
            //////                        _iOwnerModel );

            //////    arr_History_CallList = arr_History_CallList_Temp;

            //////    MainThread.BeginInvokeOnMainThread ( async ( ) =>
            //////    {
            //////        // Code to run on the main thread

            //////        if ( cv_UserCallHistoryList.ItemsSource == null )
            //////        {
            //////            cv_UserCallHistoryList.ItemsSource = arr_History_CallList;
            //////        }
            //////    } );

            //////    if ( !_bln_IsInitialized_History_CallList )
            //////    {
            //////        ////await Fetch_List ( );


            //////        if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
            //////        {
            //////            arr_History_CallList_Temp = new ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager> ( );

            //////            arr_History_CallList_Temp = await SRoofing_History_ScreenCallShowManager
            //////                 .SRoofing_ScreenCallShow_Get_List_All_Call_ByOwnerUserTokenIDWS (
            //////                 App.Current , _iOwnerModel );

            //////            MainThread.BeginInvokeOnMainThread ( async ( ) =>
            //////            {
            //////                // Code to run on the main thread
            //////                //////if ( cv_UserCallHistoryList.ItemsSource == null )
            //////                //////{
            //////                //////    arr_History_CallList = arr_History_CallList_Temp;
            //////                //////    cv_UserCallHistoryList.ItemsSource = arr_History_CallList;

            //////                //////}
            //////                //////else
            //////                //////{
            //////                arr_History_CallList.Clear ( );
            //////                for ( int i = 0 ; i < arr_History_CallList_Temp.Count ; i++ )
            //////                {
            //////                    arr_History_CallList.Add ( arr_History_CallList_Temp[ i ] );
            //////                }
            //////                //////}

            //////            } );

            //////            _bln_IsInitialized_History_CallList = true;

            //////            App._blnSyncHistory_ScreenCallShow_CALL_Landing_List = false;
            //////        }

            //////    }


            //////}
            //////catch ( Exception ex )
            //////{
            //////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            //////    return;
            //////}


        }




        public async Task Initialize_FirstLoad()
        {


            try
            {
                if (!_bln_IsInitialized_History_CallList)
                {

                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {
                        arr_History_CallList_Temp = new ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>();

                        arr_History_CallList_Temp = await SRoofing_History_ScreenCallShowManager
                             .SRoofing_ScreenCallShow_Get_List_All_Call_ByOwnerUserTokenIDWS(
                             App.Current, _iParent._iOwnerModel, _iParent._iLanguageModel);


                        await ShowList();

                        //MessagingCenter.Send<App , string> (
                        //App.Current as App ,
                        //SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CALL_LIST , SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CALL_LIST );


                        _bln_IsInitialized_History_CallList = true;

                        App._blnSyncHistory_ScreenCallShow_CALL_Landing_List = false;
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

        public ICommand Command_Call_ByUser { get; private set; }
        void Initialize_Command()
        {

            try
            {

                Command_Call_ByUser = new Command(async (object iRemoteModel) =>
                {


                    try
                    {

                        await Task.Delay(1000);

                        //if ( iPage.Navigation.NavigationStack.Count == 0 ||

                        //iPage.Navigation.NavigationStack.Last ( ).GetType ( ) != typeof ( Page_Chat_View ) )
                        //    {
                        //    await iPage.Navigation.PushModalAsync ( new Page_Chat_View ( iRemoteModel ) , true );

                        //    }
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






        #region RefreshView

        public ICommand RefreshCommand { get; }


        async Task Fetch_List()
        {
            try
            {
                // refresh your data here
                arr_History_CallList_Temp = new ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>();

                arr_History_CallList_Temp = await SRoofing_History_ScreenCallShowManager
              .SRoofing_ScreenCallShow_Get_List_All_Call_ByOwnerUserTokenIDWS(
              App.Current, _iParent._iOwnerModel, _iParent._iLanguageModel);



                await ShowList();


                //  MessagingCenter.Send<App , string> (
                //App.Current as App ,
                //SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CALL_LIST ,
                //SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CALL_LIST );


                App._blnSyncHistory_ScreenCallShow_CALL_Landing_List = false;

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
                arr_History_CallList_Temp = new ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>();

                arr_History_CallList_Temp = await SRoofing_History_ScreenCallShowManager
                     .SRoofing_ScreenCallShow_Get_List_All_Call_ByOwnerUserTokenIDWS(
                     App.Current, _iParent._iOwnerModel, _iParent._iLanguageModel);


                await ShowList();


                //MessagingCenter.Send<App , string> (
                //App.Current as App ,
                //SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CALL_LIST ,
                //SRoofingEnum_MessageCenter.MessageCenter_HISTORY_CALL_LIST );


                _bln_IsInitialized_History_CallList = true;

                App._blnSyncHistory_ScreenCallShow_CALL_Landing_List = false;
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
                //{
                //    // Code to run on the main thread

                //    refresh_CallList.IsRefreshing = false;

                //} );


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

                        }).ConfigureAwait(false);//.Wait ( );


                //////if ( App._blnSyncHistory_ScreenCallShow_CALL_Landing_List == true )
                //////{
                //////    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
                //////    {

                //////         }

                //////    App._blnSyncHistory_ScreenCallShow_CALL_Landing_List = false;
                //////}
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }


        #endregion

        async void btn_New_Group_Clicked(object sender, EventArgs e)
        {
            try
            {

                //////var objService = App.Current.MainPage.Handler.MauiContext.Services.GetService<iSRoofing_DependencyService_SoundClick> ( );

                //////if ( objService != null )
                //////{
                //////    objService.KeyboardClick ( );
                //////}


                // Close all PopupPages in the PopupStack

                ////////////////////  if ( PopupNavigation.Instance.PopupStack.Count > 0 )
                ////////////////////  {
                ////////////////////      await Navigation.PopAllPopupAsync ( );
                ////////////////////  }

                await MauiPopup.PopupAction.DisplayPopup(
                  new iSRoofing_Popup.Popup_Group_New(
              _iParent._iApplicationUtitlityModel,
              SRoofingEnum_MessageCenter.MessageCenter_GROUP_NEW_LANDING_CALL,
                     SRoofingEnum_PopupByCodeManager.PopupByCode_GROUP_NEW));


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }









        #region Show-List

        async Task ShowList()
        {


            MainThread.BeginInvokeOnMainThread(async () =>
            {

                // Code to run on the main thread
                if (refresh_CallList.IsRefreshing)
                {
                    refresh_CallList.IsRefreshing = false;
                }

                ll_ProgressBar_Call.IsVisible = false;


                if (cv_UserCallHistoryList.ItemsSource == null)
                {
                    cv_UserCallHistoryList.ItemsSource = arr_History_CallList;
                }

                if (arr_History_CallList_Temp != null)
                {
                    arr_History_CallList.Clear();

                    for (int i = 0; i < arr_History_CallList_Temp.Count; i++)
                    {
                        arr_History_CallList.Add(arr_History_CallList_Temp[i]);

                        await Task.Delay(SRoofing_EnumGlobalPreference.Global_ROW_LIST_DELAY);
                    }

                }


                _bln_IsInitialized_History_CallList = true;

                App._blnSyncHistory_ScreenCallShow_CALL_Landing_List = false;
                //_iParent.llProgress_ToggleVisible_CallList ( true , false );

            });



        }















        #endregion

        async void cv_UserCallHistoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
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


                    //  await Task.Delay ( 100 );

                    // await SRoofing_AnimationManager.Animation_FadeInOut(App.Current, frm_RowContent);


                    _ = Task.Run(async () =>
                {


                    SRoofingScreenCallShowHistoryMessageModelManager _iHistoryCallModel = (SRoofingScreenCallShowHistoryMessageModelManager)e.CurrentSelection.FirstOrDefault();//(SRoofingScreenChatShowHistoryMessageModelManager)iObjectModel;


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


                    //  SRoofingScreenCallShowHistoryMessageModelManager _iHistoryCallModel = (SRoofingScreenCallShowHistoryMessageModelManager)iObjectModel;




                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {


                        _iRemoteModel = new SRoofingUserRemoteModelManager();

                        _iRemoteModel = await SRoofingSync_User_RemoteManager
                        .Sync_User_Remote_Get_UserModel(
              App.Current,
           _iParent._iOwnerModel,
_iHistoryCallModel.RemoteUserTokenID,
_iHistoryCallModel.RemoteMobileNumberTokenID);

                        if (_iRemoteModel == null)
                        {
                            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                            {
                                _iRemoteModel =
                            await SRoofing_UserProfileRemoteManager.SRoofing_User_Get_Remote_Model_ByRemoteUserTokenID(
                                      App.Current,
                                       _iParent._iOwnerModel,
                                      _iHistoryCallModel.RemoteUserTokenID,
                                      _iHistoryCallModel.RemoteMobileNumberTokenID);
                            }

                        }
                        _iGroupModel = new SRoofingUserGroupModelManager();


                        _iGroupModel = await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel(
                              App.Current,
                               _iParent._iOwnerModel,
                              _iHistoryCallModel.GroupTokenID);


                        if (_iGroupModel == null)
                        {
                            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                            {

                                _iGroupModel = new SRoofingUserGroupModelManager();

                                _iGroupModel =
                                await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                                            App.Current,
                                                 _iParent._iOwnerModel,
                                                 _iHistoryCallModel.GroupTokenID);
                            }

                        }

                        //_iGroupModel = new SRoofingUserGroupModelManager();
                        //_iGroupModel =
                        //              await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                        //                          App.Current,
                        //                              iOwnerModel,
                        //                               _iHistoryCallModel.GroupTokenID);



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
                             _iParent._iOwnerModel,
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


                        await _iParent.iProgress_Stop();


                        await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener_WithChecker(
                                Navigation,
                                typeof(Page_Call_Dashboard),
                            new Page_Call_Dashboard(),
                            false,
                            true);


                        _iParent._bln_IsBusyOnProgress= false;



                    }

                    else
                    {
                        MainThread.BeginInvokeOnMainThread(async () =>
                        {
                            // Code to run on the main thread

                            await _iParent.iProgress_Stop();


                            await _iParent.Snack_ShowMessage(((Page_Landing_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);

                        });
                    }

                }).ConfigureAwait(false);




                }



            }


            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }
    }
}