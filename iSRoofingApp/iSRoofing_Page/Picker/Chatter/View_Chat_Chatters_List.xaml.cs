using S1RoofingMU.iSRoofingApp.iSRoofing_EnumGlobalManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_RowSelector.Chatter;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System.Collections.ObjectModel;
using System.Windows.Input;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Chatter;

public partial class View_Chat_Chatters_List : ContentView
{



    public ObservableCollection<SRoofingUserRemoteModelManager> arr_UserChattersList { get; set; } = new ObservableCollection<SRoofingUserRemoteModelManager>();



    public ObservableCollection<SRoofingUserRemoteModelManager> arr_UserChattersList_Temp { get; set; } = new ObservableCollection<SRoofingUserRemoteModelManager>();


    public static ObservableCollection<string> arr_History_ChatList { get; set; } = new ObservableCollection<string>();
    public static ObservableCollection<string> arr_History_ChatList_Temp { get; set; } = new ObservableCollection<string>();

    bool _bln_IsInitialized_ChattersList;
    bool _blnIsInitialized_BroadcastReceiver;


    public ICommand RefreshCommand { get; }
    
    public View_Chat_Chatters_List()
    {
        InitializeComponent();

        RefreshCommand = new Command(Refresh_List);


        //arr_History_ChatList.Add("item first");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item");
        //arr_History_ChatList.Add("item last");

        //cv_UserChatHistoryList.ItemsSource=arr_History_ChatList;


        BindingContext = this;



    }









    public async Task Preload(Picker_Chatter_Dashboard iParent)
    {
        try
        {

            //if (iParent != null)
            //{
            //    ((Picker_Chatter_Dashboard)Parent.BindingContext) = iParent;
            //    _iOwnerModel = ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel;
            //}


            //RefreshCommand = new Command(Refresh_List);
            ////  RemoveCommand = new Command ( Remove_One );

            // Initialize_Command ( );


            //if (!_blnIsInitialized_BroadcastReceiver)
            //{

            //    _blnIsInitialized_BroadcastReceiver = true;


            //}

            MainThread.BeginInvokeOnMainThread(() =>
            {



                btn_New_Chatter.Text = ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Group_AddUser_Message;
                // btn_Close_MenuRight.Text = ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Command_CLOSE_Message;
                //ll_ProgressBar.IsVisible = true;

            });

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }


    public SRoofingUserOwnerModelManager _iOwnerModel { get; set; }

    public async Task Initialize()
    {
        try
        {

            _iOwnerModel=((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel;

            // await Task.Delay(7000);

            //await ((Picker_Chatter_Dashboard)Parent.BindingContext).Close_LoadingScreen();


            //MainThread.BeginInvokeOnMainThread(() =>
            //{
            //    //cv_UserChatHistoryList.ItemsSource = null;

            //    //ll_ProgressBar.IsVisible = true;

            //    var Private_ChatterDataTemplateSelector = (Chatter_Private_ChatterDataTemplateSelector)this.Resources["Private_ChatterDataTemplateSelector"];
            //    var Group_ChatterDataTemplateSelector = (Chatter_Group_ChatterDataTemplateSelector)this.Resources["Group_ChatterDataTemplateSelector"];


            //    if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE)
            //    {
            //        cv_UserChatHistoryList.ItemTemplate = Private_ChatterDataTemplateSelector;
            //    }
            //    else if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_GROUP)
            //    {
            //        cv_UserChatHistoryList.ItemTemplate = Group_ChatterDataTemplateSelector;

            //    }


            //    //cv_UserChatHistoryList.ItemTemplate = Group_ChatterDataTemplateSelector;



            //});


            // here ...........

            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserRemoteModelManager>();

                arr_UserChattersList_Temp = await SRoofing_ScreenChatShowChatterManager
                   .SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWS(
             App.Current,
             ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
       ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID,
       "0", "0");

                //App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;
            }
            else { 
            
            
            arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserRemoteModelManager>();
            arr_UserChattersList_Temp = await SRoofingSync_ScreenChatShowChatterManager
                                         .Sync_History_ScreenChatShow_Get_ChatterList_ByGroupTokenID(
                                      App.Current,
                                      App.iAccountType,
                                       ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
                                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID);



   
            }

            await ShowList();

            //////////_bln_IsInitialized_ChattersList = true;


            //////////arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserRemoteModelManager>();
            //////////arr_UserChattersList_Temp = await SRoofingSync_ScreenChatShowChatterManager
            //////////                             .Sync_History_ScreenChatShow_Get_ChatterList_ByGroupTokenID(
            //////////                          App.Current,
            //////////                          App.iAccountType,
            //////////                           ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
            //////////                        ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID);



            //////////if (arr_UserChattersList_Temp == null || arr_UserChattersList_Temp.Count == 0)
            //////////{


            //////////    _ = Task.Run(async () =>
            //////////    {

            //////////        await Initialize_FirstLoad();


            //////////    }).ConfigureAwait(false);

            //////////}
            //////////else
            //////////{
            //////////    await ShowList();

            //////////}


            //MainThread.BeginInvokeOnMainThread(async () =>
            //{

            //    await iSnackBar_ConfirmOption.OpenLoader(
            //        typeof(View_Chat_Chatters_List),
            //         ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel,
            //        ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
            //        ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID);

            //});

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }

    public async Task Initialize_X1()
    {
        try
        {

            _iOwnerModel=((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel;

            // await Task.Delay(7000);

            //await ((Picker_Chatter_Dashboard)Parent.BindingContext).Close_LoadingScreen();


            MainThread.BeginInvokeOnMainThread(() =>
            {
                //cv_UserChatHistoryList.ItemsSource = null;

                //ll_ProgressBar.IsVisible = true;

                var Private_ChatterDataTemplateSelector = (Chatter_Private_ChatterDataTemplateSelector)this.Resources["Private_ChatterDataTemplateSelector"];
                var Group_ChatterDataTemplateSelector = (Chatter_Group_ChatterDataTemplateSelector)this.Resources["Group_ChatterDataTemplateSelector"];


                if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE)
                {
                    cv_UserChatHistoryList.ItemTemplate = Private_ChatterDataTemplateSelector;
                }
                else if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_GROUP)
                {
                    cv_UserChatHistoryList.ItemTemplate = Group_ChatterDataTemplateSelector;

                }


                //cv_UserChatHistoryList.ItemTemplate = Group_ChatterDataTemplateSelector;



            });


            // here ...........

            arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserRemoteModelManager>();
            arr_UserChattersList_Temp = await SRoofingSync_ScreenChatShowChatterManager
                                         .Sync_History_ScreenChatShow_Get_ChatterList_ByGroupTokenID(
                                      App.Current,
                                      App.iAccountType,
                                       ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
                                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID);



            if (arr_UserChattersList_Temp == null || arr_UserChattersList_Temp.Count == 0)
            {


                _ = Task.Run(async () =>
                {

                    await Initialize_FirstLoad();


                }).ConfigureAwait(false);

            }
            else
            {
                await ShowList();

            }


            //MainThread.BeginInvokeOnMainThread(async () =>
            //{

            //    await iSnackBar_ConfirmOption.OpenLoader(
            //        typeof(View_Chat_Chatters_List),
            //         ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel,
            //        ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
            //        ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID);

            //});

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
            //if ( !_bln_IsInitialized_ChattersList )
            //{

            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserRemoteModelManager>();

                arr_UserChattersList_Temp = await SRoofing_ScreenChatShowChatterManager
                   .SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWS(
             App.Current,
             ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
       ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID,
       "0", "0");

                  //App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;
            }

     await ShowList();

                _bln_IsInitialized_ChattersList = true;

         
            //}

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }





    async Task Fetch_List()
    {
        try
        {
            // refresh your data here

            arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserRemoteModelManager>();

            arr_UserChattersList_Temp = await SRoofing_ScreenChatShowChatterManager
               .SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWS(
         App.Current,
         ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
   ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID,
   "0", "0");

       
            await ShowList();


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

            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {

                _ = Task.Run(async () =>
                {
                    await Fetch_List();

                }).ConfigureAwait(false);//.Wait ( );
            }
            else
            {

                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    ll_ProgressBar.IsVisible = false;


                    if (refresh_ChatList.IsRefreshing)
                    {
                        refresh_ChatList.IsRefreshing = false;
                    }

                });



            }

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }





    #region Chatters


    async void btn_New_Chatter_Clicked(object sender, EventArgs e)
    {
        try
        {

            await ((Picker_Chatter_Dashboard)Parent.BindingContext).Show_PickerContactList();


            //////var objService = DependencyService.Get<iSRoofing_DependencyService_SoundClick> ( );

            //////if ( objService != null )
            //////{
            //////    objService.KeyboardClick ( );
            //////}


            //////await Task.Delay ( 100 );

            //await   remove_Chatter    (null);


            //////////    var currentPage = Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

            //////////    if (currentPage != null)
            //////////    {

            //////////        if (currentPage.GetType() != typeof(Picker_Chatter_Dashboard))
            //////////        {
            //////////            await Navigation.PushModalAsync(new Picker_Chatter_Dashboard(
            //////////   ((Picker_Chatter_Dashboard)Parent.BindingContext)._iApplicationUtilityModel,
            //////////   ((Picker_Chatter_Dashboard)Parent.BindingContext)._iSettingModel,
            //////////   ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel,
            //////////      ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
            //////////  ((Picker_Chatter_Dashboard)Parent.BindingContext)._iSpeechModel,
            //////////   ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwner_Incoming_LanguageCode,
            //////////     ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwner_Outgoing_LanguageCode,
            //////////    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel), true);



            //////////        }
            //////////    }

            //////////    else
            //////////    {
            //////////        await Navigation.PushModalAsync(new Picker_Chatter_Dashboard(
            ////////// ((Picker_Chatter_Dashboard)Parent.BindingContext)._iApplicationUtilityModel,
            ////////// ((Picker_Chatter_Dashboard)Parent.BindingContext)._iSettingModel,
            ////////// ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel,
            //////////    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
            //////////((Picker_Chatter_Dashboard)Parent.BindingContext)._iSpeechModel,
            ////////// ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwner_Incoming_LanguageCode,
            //////////   ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwner_Outgoing_LanguageCode,
            //////////  ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel), true);



            //////////    }







        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    #endregion


    #region Chatter_Remove

    public SRoofingUserRemoteModelManager _pending_iRemoteModel = null;
    public async Task pendingRemove_Chatter(SRoofingUserRemoteModelManager iGroupModel)
    {


        try
        {

            _pending_iRemoteModel = iGroupModel;

            await ((Picker_Chatter_Dashboard)Parent.BindingContext)
                .snackBar_Open(
typeof(View_Chat_Chatters_List),
"chatter_list",
_pending_iRemoteModel);

            // arr_UserChattersList.RemoveAt ( 0 );


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }








    public async Task Action_Chatter_Remove_One(Type iParentView,
          string iViewCode, object iViewValue)
    {

        try
        {

            if (_pending_iRemoteModel != null)
            {


                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    // Code to run on the main thread
                    // show progressbar
                    await ((Picker_Chatter_Dashboard)Parent.BindingContext).iProgress_Start();

                });




                _ = Task.Run(async () =>
           {

               await SRoofing_UserGroupManager.UserGroup_User_REMOVE_From_Group_ByGroupTokenID(
                   App.Current,
App.iAccountType,
 ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID,
        _pending_iRemoteModel.OwnerUserTokenID,
_pending_iRemoteModel.OwnerMobileNumberTokenID);

           }).ConfigureAwait(false);



                MainThread.BeginInvokeOnMainThread(async () =>
                 {


                     // Code to run on the main thread
                     // hide progressbar
                     await ((Picker_Chatter_Dashboard)Parent.BindingContext).iProgress_Stop();

                     arr_UserChattersList.Remove(_pending_iRemoteModel);


                 });



            }

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
        try
        {

            MainThread.BeginInvokeOnMainThread(async () =>
            {

                ll_ProgressBar.IsVisible = false;


                if (refresh_ChatList.IsRefreshing)
                {
                    refresh_ChatList.IsRefreshing = false;
                }

                //var Private_ChatterDataTemplateSelector = (Chatter_Private_ChatterDataTemplateSelector)this.Resources["Private_ChatterDataTemplateSelector"];
                //var Group_ChatterDataTemplateSelector = (Chatter_Group_ChatterDataTemplateSelector)this.Resources["Group_ChatterDataTemplateSelector"];


                //if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE)
                //{
                //    cv_UserChatHistoryList.ItemTemplate = Private_ChatterDataTemplateSelector;
                //}
                //else if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_GROUP)
                //{
                //    cv_UserChatHistoryList.ItemTemplate = Group_ChatterDataTemplateSelector;

                //}


                //////////var Private_ChatterDataTemplateSelector = (Chatter_Private_ChatterDataTemplateSelector)this.Resources["Private_ChatterDataTemplateSelector"];
                //////////var Group_ChatterDataTemplateSelector = (Chatter_Group_ChatterDataTemplateSelector)this.Resources["Group_ChatterDataTemplateSelector"];


                //////////if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE)
                //////////{
                //////////    cv_UserChatHistoryList.ItemTemplate = Private_ChatterDataTemplateSelector;
                //////////}
                //////////else if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_GROUP)
                //////////{
                //////////    cv_UserChatHistoryList.ItemTemplate = Group_ChatterDataTemplateSelector;

                //////////}

                //////cv_UserChatHistoryList.ItemTemplate = Group_ChatterDataTemplateSelector;

                // Code to run on the main thread
                if (cv_UserChatHistoryList.ItemsSource == null)
                {
                    cv_UserChatHistoryList.ItemsSource = arr_UserChattersList;
                }

                if (arr_UserChattersList_Temp != null)
                {
                    arr_UserChattersList.Clear();

                    for (int i = 0; i < arr_UserChattersList_Temp.Count; i++)
                    {
                        arr_UserChattersList.Add(arr_UserChattersList_Temp[i]);

                        await Task.Delay(SRoofing_EnumGlobalPreference.Global_ROW_LIST_DELAY);
                    }

                }

                _bln_IsInitialized_ChattersList = true;


            });


            await ((Picker_Chatter_Dashboard)Parent.BindingContext).Close_LoadingScreen();


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }



    #endregion




}