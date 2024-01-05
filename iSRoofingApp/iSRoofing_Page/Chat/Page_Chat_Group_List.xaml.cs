using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;




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
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;







namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;

//[XamlCompilation ( XamlCompilationOptions.Compile )]
public partial class Page_Chat_Group_List : ContentView
{

    bool _blnIsInitialized_BroadcastReceiver = false;
    bool _bln_IsInitialized_History_ChatList = false;

    public Page_Chat_Group_List()
    {

        InitializeComponent();


        RefreshCommand = new Command(Refresh_List);

        // Initialize_Command ( );


        if (!_blnIsInitialized_BroadcastReceiver)
        {

            _blnIsInitialized_BroadcastReceiver = true;

            ////              MessagingCenter.Subscribe<App , string> ( App.Current , SRoofingEnum_MessageCenter.MessageCenter_CHAT_HISTORY_LIST , async ( snd , arg ) =>
            ////              {

            ////                  try
            ////                  {
            ////                      //get the value by `arg`

            ////                      SRoofing_DebugManager.Debug_ShowSystemMessage ( "bind_list_chat == " + arg.ToString ( ) );

            ////                      //await Task.Delay ( 0 );
            ////}
            ////                  catch ( Exception ex )
            ////                  {
            ////                      SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
            ////                  }

            ////              } );





            MessagingCenter.Subscribe<App, object>(App.Current, SRoofingEnum_MessageCenter.MessageCenter_GROUP_NEW_CHAT_GROUP_MENU, async (snd, arg) =>
            {

                try
                {
                    //get the value by `arg`

                    SRoofingScreenChatShowHistoryMessageModelManager _iNew_HistoryChatMessageModel = new SRoofingScreenChatShowHistoryMessageModelManager();
                    _iNew_HistoryChatMessageModel = arg as SRoofingScreenChatShowHistoryMessageModelManager;



                    await Task.Delay(100);

                    _ = Task.Run(async () =>
            {

                await Chat_Opener(_iNew_HistoryChatMessageModel);


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

    public SRoofingUserOwnerModelManager _iOwnerModel { get; set; }
    public static ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_History_ChatList { get; set; } = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();
    public static ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_History_ChatList_Temp { get; set; } = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

    public Page_ScreenChatShow_Dashboard _iParent;


    public async Task Preload(Page_ScreenChatShow_Dashboard iParent)
    {
        try
        {

            if (iParent != null)
            {
                _iParent = iParent;
                _iOwnerModel = _iParent._iOwnerModel;
            }

            MainThread.BeginInvokeOnMainThread(() =>
             {
                 btn_New_Group.Text = _iParent._iLanguageModel.lblText_Group_New_Message;
                 btn_Close_MenuLeft.Text = _iParent._iLanguageModel.lblText_Command_CLOSE_Message;
                 ll_ProgressBar.IsVisible = true;
             });

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }


    public async Task Initialize()
    {
        try
        {

            _ = Task.Run(async () =>
                          {

                              arr_History_ChatList_Temp = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                              arr_History_ChatList_Temp = await App.Database.Get_List_History_Chat_Message_ByOwnerUserTokenID(_iParent._iOwnerModel, _iParent._iSettingModel);

                              await ShowList();

                          }).ConfigureAwait(continueOnCapturedContext: false);


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
            //if ( !_bln_IsInitialized_History_ChatList )
            //{

            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                arr_History_ChatList_Temp = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

                arr_History_ChatList_Temp = await SRoofing_History_ScreenChatShowManager
                     .SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWS(
                     App.Current, _iOwnerModel, _iParent._iLanguageModel);



                await ShowList();

                //MessagingCenter.Send<App , string> (
                //App.Current as App ,
                //SRoofingEnum_MessageCenter.MessageCenter_CHAT_HISTORY_LIST ,
                //SRoofingEnum_MessageCenter.MessageCenter_CHAT_HISTORY_LIST );

                App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;
            }

            //}

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
          App.Current, _iOwnerModel, _iParent._iLanguageModel);


            await ShowList();


            //  MessagingCenter.Send<App , string> (
            //App.Current as App ,
            //SRoofingEnum_MessageCenter.MessageCenter_CHAT_HISTORY_LIST ,
            //SRoofingEnum_MessageCenter.MessageCenter_CHAT_HISTORY_LIST );

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

            MainThread.BeginInvokeOnMainThread(() =>
                {
                    // Code to run on the main thread

                    refresh_ChatList.IsRefreshing = false;

                });


            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {

                _=   Task.Run(async () =>
                   {
                       await Fetch_List();

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

            if (App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List == true)
            {
                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {

                    Task.Run(async () =>
                    {
                        await Fetch_List();

                    }).ConfigureAwait(false);//.Wait ( );
                }

                App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;
            }
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

            ////////////////////  if ( PopupNavigation.Instance.PopupStack.Count > 0 )
            ////////////////////  {
            ////////////////////      await Navigation.PopAllPopupAsync ( );
            ////////////////////  }

            await MauiPopup.PopupAction.DisplayPopup(
              new iSRoofing_Popup.Popup_Group_New(
          _iParent._iApplicationUtilityModel,
          SRoofingEnum_MessageCenter.MessageCenter_GROUP_NEW_CHAT_GROUP_MENU,
                  SRoofingEnum_PopupByCodeManager.PopupByCode_GROUP_NEW));


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }









    #region OpenChat


    public async Task open_ChatDashboard(SRoofingScreenChatShowScreenModel _iChatScreenModel)
    {

        try
        {

            _ = Task.Run(async () =>
                  {

                      if (_iChatScreenModel != null)
                      {
                          _iParent._iChatScreenModel = _iChatScreenModel;

                          await _iParent.Initialize_Chat_Window();

                      }
                  }).ConfigureAwait(false);

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


        MainThread.BeginInvokeOnMainThread(async () =>
        {


            ll_ProgressBar.IsVisible = false;


            if (refresh_ChatList.IsRefreshing)
            {
                refresh_ChatList.IsRefreshing = false;
            }


            // Code to run on the main thread
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

            _bln_IsInitialized_History_ChatList = true;

        });


    }

    #endregion



    #region ReBind-Chat-Row


    public async Task Bind_ChatRow(SRoofingKeyValueModelManager iBroadcastChatModel)
    {


        try
        {

            // string iGroupTokenID, SRoofingScreenChatShowHistoryMessageModelManager iChatHostoryModel
            //
            int iIndex = -1;

            SRoofingScreenChatShowHistoryMessageModelManager iChatHistoryModel = new SRoofingScreenChatShowHistoryMessageModelManager();

            if (arr_History_ChatList != null)
            {
                if (arr_History_ChatList.Count > 0 && _bln_IsInitialized_History_ChatList)
                {

                    for (int i = 0; i < arr_History_ChatList.Count; i++)
                    {
                        if (arr_History_ChatList[i].GroupTokenID == iBroadcastChatModel.ItemCode)
                        {
                            iIndex = i;

                            SRoofing_DebugManager.Debug_ShowSystemMessage("*** iIndex == " + iIndex);

                            break;
                        }
                    }


                    // Update-List
                    MainThread.BeginInvokeOnMainThread(() =>
            {
                if (iIndex != -1)
                {
                    iChatHistoryModel = iBroadcastChatModel.iHistoryChatMessageModel;

                    //arr_History_ChatList[ iIndex ].MessageText = iChatHistoryModel.MessageText;
                    //arr_History_ChatList[ iIndex ].DateTimeText = iChatHistoryModel.DateTimeText;

                    //if ( iChatHistoryModel.GroupTokenID == _iParent._iChatScreenModel.GroupTokenID )
                    //{
                    //    arr_History_ChatList[ iIndex ].IsNewMessage = false;
                    //}
                    //else
                    //{
                    //    arr_History_ChatList[ iIndex ].IsNewMessage = true; //iChatHistoryModel.IsNewMessage;
                    //}

                    arr_History_ChatList[iIndex] = iChatHistoryModel;

                }
                else
                {
                    arr_History_ChatList.Insert(0, iChatHistoryModel);

                }

            });

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


    #region Open_Menu_Left


    public async Task MenuOpener_MenuLeft()
    {


        try
        {
            if (!_bln_IsInitialized_History_ChatList)
            {
                await Initialize();
            }
            else
            {

            }

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }


    #endregion



    async void btn_Close_MenuLeft_Clicked(object sender, EventArgs e)
    {
        try
        {

            MainThread.BeginInvokeOnMainThread(async () =>
                {
                    await _iParent.MenuCloser();
                });


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }






    #region Chat_Opener

    public async Task Chat_Opener(SRoofingScreenChatShowHistoryMessageModelManager _iNew_HistoryChatMessageModel)
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



            SRoofingScreenChatShowScreenModel _iChatScreenModel = new SRoofingScreenChatShowScreenModel();
            _iChatScreenModel = await SRoofingSync_ScreenChatShowManager.Sync_ScreenChatShow_Get_ChatModel(
                 App.Current,
                 App.iAccountType,
                 _iOwnerModel);


            if (_iChatScreenModel != null)
            {
                await open_ChatDashboard(_iChatScreenModel);

                //await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener_WithChecker (
                //        Navigation ,
                //        typeof ( Page_ScreenChatShow_Dashboard ) ,
                //    new Page_ScreenChatShow_Dashboard ( ) ,
                //    false ,
                //    true );


            }



            //////
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }












    #endregion

    private void cv_Chat_GroupList_Loaded(object sender, EventArgs e)
    {

    }
}