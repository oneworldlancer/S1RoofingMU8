using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Azure.Core;

using S1RoofingMU.iSRoofingApp.iSRoofing_Database;
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumGlobalManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Contact;
//using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Contact;
// 
using S1RoofingMU.iSRoofingApp.iSRoofing_RowSelector.Chatter;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_WebService_InterfaceManager;







namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;

//[XamlCompilation ( XamlCompilationOptions.Compile )]
public partial class Page_Chat_Chatters_List : ContentView, INotifyPropertyChanged
{


    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;
    protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion




    #region Params

    public bool _bln_IsUNDO_Global = false;
    public bool _bln_IsUNDO = false;

    #endregion



    bool _blnIsInitialized_BroadcastReceiver = false;
    bool _bln_IsInitialized_ChattersList = false;

    public Page_Chat_Chatters_List()
    {

        InitializeComponent();


        RefreshCommand = new Command(Refresh_List);
        //  RemoveCommand = new Command ( Remove_One );

        // Initialize_Command ( );


        if (!_blnIsInitialized_BroadcastReceiver)
        {

            _blnIsInitialized_BroadcastReceiver = true;


        }

        BindingContext = this;

    }


    #region Initialize

    public SRoofingUserOwnerModelManager _iOwnerModel { get; set; }

    private ObservableCollection<SRoofingUserRemoteModelManager> pvt_arr_UserChattersList = new ObservableCollection<SRoofingUserRemoteModelManager>();
    public ObservableCollection<SRoofingUserRemoteModelManager> arr_UserChattersList
    {
        get { return pvt_arr_UserChattersList; }

        set
        {
            pvt_arr_UserChattersList = value;
            NotifyPropertyChanged();
        }
    }
















    public ObservableCollection<SRoofingUserRemoteModelManager> arr_UserChattersList_Temp { get; set; } = new ObservableCollection<SRoofingUserRemoteModelManager>();

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
                  btn_New_Chatter.Text = _iParent._iLanguageModel.lblText_Group_AddUser_Message;
                  btn_Close_MenuRight.Text = _iParent._iLanguageModel.lblText_Command_CLOSE_Message;
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
            MainThread.BeginInvokeOnMainThread(() =>
              {
                  cv_UserChatHistoryList.ItemsSource = null;

                  ll_ProgressBar.IsVisible = true;

                  //var Private_ChatterDataTemplateSelector = ( Chatter_Private_ChatterDataTemplateSelector ) this.Resources[ "Private_ChatterDataTemplateSelector" ];
                  //var Group_ChatterDataTemplateSelector = ( Chatter_Group_ChatterDataTemplateSelector ) this.Resources[ "Group_ChatterDataTemplateSelector" ];


                  //if ( _iParent._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE )
                  //{
                  //    cv_UserChatHistoryList.ItemTemplate = Private_ChatterDataTemplateSelector;
                  //}
                  //else if ( _iParent._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_GROUP )
                  //{
                  //    cv_UserChatHistoryList.ItemTemplate = Group_ChatterDataTemplateSelector;

                  //}

              });


            arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserRemoteModelManager>();
            arr_UserChattersList_Temp = await SRoofingSync_ScreenChatShowChatterManager
                                         .Sync_History_ScreenChatShow_Get_ChatterList_ByGroupTokenID(
                                      App.Current,
                                      App.iAccountType,
                                       _iOwnerModel,
                                    _iParent._iChatScreenModel.GroupTokenID);



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


            MainThread.BeginInvokeOnMainThread(async () =>
            {

                await iSnackBar_ConfirmOption.OpenLoader(
                    typeof(Page_Chat_Chatters_List),
                     _iParent._iLanguageModel,
                    _iParent._iOwnerModel,
                    _iParent._iChatScreenModel.GroupTokenID);

            });

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
             App.Current, _iOwnerModel,
       _iParent._iChatScreenModel.GroupTokenID,
       "0", "0");

                await ShowList();

                _bln_IsInitialized_ChattersList = true;

                //App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;
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
    public ICommand RemoveCommand { get; }


    async Task Fetch_List()
    {
        try
        {
            // refresh your data here

            arr_UserChattersList_Temp = new ObservableCollection<SRoofingUserRemoteModelManager>();

            arr_UserChattersList_Temp = await SRoofing_ScreenChatShowChatterManager
               .SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWS(
         App.Current, _iOwnerModel,
   _iParent._iChatScreenModel.GroupTokenID,
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












            ////////if ( //App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List == true )
            ////////{
            ////////    if ( Connectivity.NetworkAccess == NetworkAccess.Internet )
            ////////    {

            ////////          Task.Run ( async ( ) =>
            ////////          {
            ////////              await Fetch_List ( );

            ////////          } ).ConfigureAwait ( false );//.Wait ( );
            ////////    }

            ////////    //App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;
            ////////}
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }

    #endregion


    #region Chatters


    async void btn_New_Chatter_Clicked(object sender, EventArgs e)
    {
        try
        {
            //////var objService = DependencyService.Get<iSRoofing_DependencyService_SoundClick> ( );

            //////if ( objService != null )
            //////{
            //////    objService.KeyboardClick ( );
            //////}


            //////await Task.Delay ( 100 );

            //await   remove_Chatter    (null);


            var currentPage = Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

            if (currentPage != null)
            {

                if (currentPage.GetType() != typeof(Picker_Contact_Dashboard))
                {
          //          await Navigation.PushModalAsync(new Picker_Contact_Dashboard(
          // ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iApplicationUtilityModel,
          // ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iSettingModel,
          // ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iLanguageModel,
          //    ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iOwnerModel,
          //((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iSpeechModel,
          // ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iOwner_LanguageCode_IN,
          //   ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iOwner_LanguageCode_OUT,
          //  ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iChatScreenModel), true);



                }
            }

            else
            {

        //        await Navigation.PushModalAsync(new Picker_Contact_Dashboard(
        // ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iApplicationUtilityModel,
        // ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iSettingModel,
        // ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iLanguageModel,
        //    ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iOwnerModel,
        //((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iSpeechModel,
        // ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iOwner_LanguageCode_IN,
        //   ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iOwner_LanguageCode_OUT,
        //  ((Page_ScreenChatShow_Dashboard)Parent.BindingContext)._iChatScreenModel), true);



            }







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
            //////////await iSnackBar_ConfirmOption.Open();
            // arr_UserChattersList.RemoveAt ( 0 );


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }








    async void Remove_One()
    {

        try
        {


            arr_UserChattersList.RemoveAt(0);



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

      var Private_ChatterDataTemplateSelector = (Chatter_Private_ChatterDataTemplateSelector)this.Resources["Private_ChatterDataTemplateSelector"];
      var Group_ChatterDataTemplateSelector = (Chatter_Group_ChatterDataTemplateSelector)this.Resources["Group_ChatterDataTemplateSelector"];


      if (_iParent._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE)
      {
          cv_UserChatHistoryList.ItemTemplate = Private_ChatterDataTemplateSelector;
      }
      else if (_iParent._iChatScreenModel.GroupType == SRoofingEnum_GroupType.GroupType_GROUP)
      {
          cv_UserChatHistoryList.ItemTemplate = Group_ChatterDataTemplateSelector;

      }


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



        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }



    #endregion

    private async void btn_Close_MenuRight_Clicked(object sender, EventArgs e)
    {
        try
        {
            await _iParent.MenuCloser();


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }

    private void cv_Chat_ChattersList_Loaded(object sender, EventArgs e)
    {

    }
}