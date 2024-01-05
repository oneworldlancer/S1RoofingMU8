using S1RoofingMU.iSRoofingApp.iSRoofing_EnumGlobalManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_RowSelector.Chatter;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;

using System.Collections.ObjectModel;
using System.Windows.Input;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Chatter;

public partial class View_Chat_Chatters_Picker_List : ContentView
{



    public ObservableCollection<SRoofingUserGroupModelManager> arr_UserChattersList { get; set; } = new ObservableCollection<SRoofingUserGroupModelManager>();



    public ObservableCollection<SRoofingUserGroupModelManager> arr_UserChattersList_Temp { get; set; } = new ObservableCollection<SRoofingUserGroupModelManager>();


    public static ObservableCollection<string> arr_History_ChatList { get; set; } = new ObservableCollection<string>();
    public static ObservableCollection<string> arr_History_ChatList_Temp { get; set; } = new ObservableCollection<string>();

    bool _bln_IsInitialized_ChattersList;
    bool _blnIsInitialized_BroadcastReceiver;

    public ICommand RefreshCommand { get; }


    public View_Chat_Chatters_Picker_List()
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

        //cv_UserChatPickerList.ItemsSource=arr_History_ChatList;


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



                //btn_New_Chatter.Text = ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Group_AddUser_Message;
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


            MainThread.BeginInvokeOnMainThread(() =>
            {
                //cv_UserChatPickerList.ItemsSource = null;

                ll_ProgressBar.IsVisible = true;

                //var Private_ChatterDataTemplateSelector = (Chatter_Private_ChatterDataTemplateSelector)this.Resources["Private_ChatterDataTemplateSelector"];
                //var Group_ChatterDataTemplateSelector = (Chatter_Group_ChatterDataTemplateSelector)this.Resources["Group_ChatterDataTemplateSelector"];


                //if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE)
                //{
                //    cv_UserChatPickerList.ItemTemplate = Private_ChatterDataTemplateSelector;
                //}
                //else if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_GROUP)
                //{
                //    cv_UserChatPickerList.ItemTemplate = Group_ChatterDataTemplateSelector;

                //}


                //cv_UserChatPickerList.ItemTemplate = Group_ChatterDataTemplateSelector;



            });


            // here ...........

            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {

                //Sync_User_Picker_Contact_Set_List_Contact_ByCharcterID

                arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserGroupModelManager>();

                arr_UserChattersList_Temp = await SRoofing_UserGroupManager
                    .SRoofing_XFMobile_UserGroup_Get_List_Private_Filter_Chatter_ByAlphabetIndexWS(
                    App.Current,
                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID,
                    "0", "0");

                //_bln_IsInitialized_ChattersList = true;

                //App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;
            }
            else { 
            
            arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserGroupModelManager>();

            arr_UserChattersList_Temp = await SRoofingSync_UserContactPickerManager
                              .Sync_User_Picker_Contact_Get_List_Contact_ByCharcterID(
               App.Current,
               ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
               ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID);




            
            }

            await ShowList();

            //////////arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserGroupModelManager>();

            //////////arr_UserChattersList_Temp = await SRoofingSync_UserContactPickerManager
            //////////                  .Sync_User_Picker_Contact_Get_List_Contact_ByCharcterID(
            //////////   App.Current,
            //////////   ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
            //////////   ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID);




            //////////// here ...........



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
            //        typeof(View_Chat_Chatters_Picker_List),
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
                //cv_UserChatPickerList.ItemsSource = null;

                ll_ProgressBar.IsVisible = true;

                //var Private_ChatterDataTemplateSelector = (Chatter_Private_ChatterDataTemplateSelector)this.Resources["Private_ChatterDataTemplateSelector"];
                //var Group_ChatterDataTemplateSelector = (Chatter_Group_ChatterDataTemplateSelector)this.Resources["Group_ChatterDataTemplateSelector"];


                //if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE)
                //{
                //    cv_UserChatPickerList.ItemTemplate = Private_ChatterDataTemplateSelector;
                //}
                //else if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_GROUP)
                //{
                //    cv_UserChatPickerList.ItemTemplate = Group_ChatterDataTemplateSelector;

                //}


                //cv_UserChatPickerList.ItemTemplate = Group_ChatterDataTemplateSelector;



            });


            // here ...........

            arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserGroupModelManager>();

            arr_UserChattersList_Temp = await SRoofingSync_UserContactPickerManager
                              .Sync_User_Picker_Contact_Get_List_Contact_ByCharcterID(
               App.Current,
               ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
               ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID);




            // here ...........



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
            //        typeof(View_Chat_Chatters_Picker_List),
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

                //Sync_User_Picker_Contact_Set_List_Contact_ByCharcterID

                arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserGroupModelManager>();

                arr_UserChattersList_Temp = await SRoofing_UserGroupManager
                    .SRoofing_XFMobile_UserGroup_Get_List_Private_Filter_Chatter_ByAlphabetIndexWS(
                    App.Current,
                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID,
                    "0", "0");

                //_bln_IsInitialized_ChattersList = true;

                //App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;
            }

                await ShowList();

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
            arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserGroupModelManager>();

            arr_UserChattersList_Temp = await SRoofing_UserGroupManager
                .SRoofing_XFMobile_UserGroup_Get_List_Private_Filter_Chatter_ByAlphabetIndexWS(
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

    public SRoofingUserGroupModelManager _pending_iGroupModel = null;
    public async Task pendingRemove_Chatter(SRoofingUserGroupModelManager iGroupModel)
    {


        try
        {

            _pending_iGroupModel = iGroupModel;

            await ((Picker_Chatter_Dashboard)Parent.BindingContext)
                .snackBar_Open(
typeof(View_Chat_Chatters_Picker_List),
"chatter_picker",
_pending_iGroupModel);

            // arr_UserChattersList.RemoveAt ( 0 );


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }








    public async Task Action_Chatter_Add_One(Type iParentView,
          string iViewCode, object iViewValue)
    {

        try
        {

            if (_pending_iGroupModel != null)
            {


                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    // Code to run on the main thread
                    // show progressbar
                    await ((Picker_Chatter_Dashboard)Parent.BindingContext).iProgress_Start();

                });





                _ = Task.Run(async () =>
                {

                    await SRoofing_UserGroupManager.SRoofing_UserGroup_ADD_User_To_Group_ByGroupTokenID(
                        App.Current,
     App.iAccountType,
      ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
     ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID,
             _pending_iGroupModel.RemoteUserTokenID,
     _pending_iGroupModel.RemoteMobileNumberTokenID);

                }).ConfigureAwait(false);



                MainThread.BeginInvokeOnMainThread(async () =>
                {


                    // Code to run on the main thread
                    // hide progressbar
                    await ((Picker_Chatter_Dashboard)Parent.BindingContext).iProgress_Stop();

                    arr_UserChattersList.Remove(_pending_iGroupModel);


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
                //    cv_UserChatPickerList.ItemTemplate = Private_ChatterDataTemplateSelector;
                //}
                //else if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_GROUP)
                //{
                //    cv_UserChatPickerList.ItemTemplate = Group_ChatterDataTemplateSelector;

                //}


                //////////var Private_ChatterDataTemplateSelector = (Chatter_Private_ChatterDataTemplateSelector)this.Resources["Private_ChatterDataTemplateSelector"];
                //////////var Group_ChatterDataTemplateSelector = (Chatter_Group_ChatterDataTemplateSelector)this.Resources["Group_ChatterDataTemplateSelector"];


                //////////if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE)
                //////////{
                //////////    cv_UserChatPickerList.ItemTemplate = Private_ChatterDataTemplateSelector;
                //////////}
                //////////else if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_GROUP)
                //////////{
                //////////    cv_UserChatPickerList.ItemTemplate = Group_ChatterDataTemplateSelector;

                //////////}

                //////cv_UserChatPickerList.ItemTemplate = Group_ChatterDataTemplateSelector;

                // Code to run on the main thread
                if (cv_UserChatPickerList.ItemsSource == null)
                {
                    cv_UserChatPickerList.ItemsSource = arr_UserChattersList;
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


            //await ((Picker_Chatter_Dashboard)Parent.BindingContext).Close_LoadingScreen();


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }



    #endregion




}