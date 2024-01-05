using S1RoofingMU.iSRoofingApp.iSRoofing_EnumGlobalManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_RowSelector.Chatter;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Document;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Image;
using S1RoofingMU.iSRoofingApp.ScreenChatShow.Video;

using System.Collections.ObjectModel;
using System.Windows.Input;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Chatter;

public partial class View_Chat_Share_List : ContentView
{



    public ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_UserChattersList { get; set; } = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();



    public ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> arr_UserChattersList_Temp { get; set; } = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();


    //public static ObservableCollection<string> arr_UserChattersList { get; set; } = new ObservableCollection<string>();
    //public static ObservableCollection<string> arr_UserChattersList_Temp { get; set; } = new ObservableCollection<string>();

    bool _bln_IsInitialized_ChattersList;
    bool _blnIsInitialized_BroadcastReceiver;


    public ICommand RefreshCommand { get; }

    public View_Chat_Share_List()
    {
        InitializeComponent();

        RefreshCommand = new Command(Refresh_List);


        //arr_UserChattersList.Add("item first");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item");
        //arr_UserChattersList.Add("item last");

        //cv_UserChatHistoryList.ItemsSource=arr_UserChattersList;


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



            // here ...........


            arr_UserChattersList_Temp = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

            arr_UserChattersList_Temp = await App.Database.Get_List_History_Chat_Message_ByOwnerUserTokenID(((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel, ((Picker_Chatter_Dashboard)Parent.BindingContext)._iSettingModel);


            await ShowList();

            //if (arr_UserChattersList_Temp == null || arr_UserChattersList_Temp.Count == 0)
            //{


            //    _ = Task.Run(async () =>
            //    {

            //        await Initialize_FirstLoad();


            //    }).ConfigureAwait(false);

            //}
            //else
            //{
            //    await ShowList();

            //}


            //MainThread.BeginInvokeOnMainThread(async () =>
            //{

            //    await iSnackBar_ConfirmOption.OpenLoader(
            //        typeof(View_Chat_Share_List),
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
        // try
        // {
        //     //if ( !_bln_IsInitialized_ChattersList )
        //     //{

        //     if (Connectivity.NetworkAccess == NetworkAccess.Internet)
        //     {
        //         arr_UserChattersList_Temp = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

        //         arr_UserChattersList_Temp = await SRoofing_ScreenChatShowChatterManager
        //            .SRoofing_ScreenChatShow_Get_List_ChatterList_Category_ByGroupTokenIDWS(
        //      App.Current,
        //      ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
        //((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID,
        //"0", "0");

        //         await ShowList();

        //         _bln_IsInitialized_ChattersList = true;

        //         //App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;
        //     }

        //     //}

        // }
        // catch (Exception ex)
        // {
        //     SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //     return;
        // }

    }





    async Task Fetch_List()
    {
        try
        {
            // refresh your data here

            arr_UserChattersList_Temp = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>();

            arr_UserChattersList_Temp = await SRoofing_History_ScreenChatShowManager
                 .SRoofing_ScreenChatShow_Get_List_All_Chat_ByOwnerUserTokenIDWS(
                 App.Current, ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel, ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel);


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

        ////////////////////try
        ////////////////////{

        ////////////////////    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
        ////////////////////    {

        ////////////////////        _ = Task.Run(async () =>
        ////////////////////        {
        ////////////////////            await Fetch_List();

        ////////////////////        }).ConfigureAwait(false);//.Wait ( );
        ////////////////////    }
        ////////////////////    else
        ////////////////////    {

        ////////////////////        MainThread.BeginInvokeOnMainThread(async () =>
        ////////////////////        {

        ////////////////////            ll_ProgressBar.IsVisible = false;


        ////////////////////            if (refresh_ChatList.IsRefreshing)
        ////////////////////            {
        ////////////////////                refresh_ChatList.IsRefreshing = false;
        ////////////////////            }

        ////////////////////        });



        ////////////////////    }

        ////////////////////}
        ////////////////////catch (Exception ex)
        ////////////////////{
        ////////////////////    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        ////////////////////    return;
        ////////////////////}


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

    public SRoofingScreenChatShowHistoryMessageModelManager _pending_iRemoteModel = null;
    public async Task pendingRemove_ShareMedia(SRoofingScreenChatShowHistoryMessageModelManager iGroupModel)
    {


        try
        {

            _pending_iRemoteModel = iGroupModel;

            await ((Picker_Chatter_Dashboard)Parent.BindingContext)
                .snackBar_Open(
typeof(View_Chat_Share_List),
"share_media",
_pending_iRemoteModel);

            // arr_UserChattersList.RemoveAt ( 0 );


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }








    public async Task Action_Chatter_Remove_One()
    {

        try
        {

            if (_pending_iRemoteModel != null)
            {

                _ = Task.Run(async () =>
           {

               //               await SRoofing_UserGroupManager.UserGroup_User_REMOVE_From_Group_ByGroupTokenID(
               //                   App.Current,
               //App.iAccountType,
               // ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
               //((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID,
               //        _pending_iRemoteModel.OwnerUserTokenID,
               //_pending_iRemoteModel.OwnerMobileNumberTokenID);

           }).ConfigureAwait(false);



                MainThread.BeginInvokeOnMainThread(async () =>
                 {


                     // Code to run on the main thread
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





    public async Task Action_Share_Media(Type iParentView,
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



                await Gallery_Share( (SRoofingScreenChatShowHistoryMessageModelManager) iViewValue);


            

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



    #region Gallery_Share

    public async Task Gallery_Share(

                SRoofingScreenChatShowHistoryMessageModelManager iGroupModel)
    {

        try
        {


            if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel!= null)
            {

                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {

                    if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel.MediaFile_Code == SRoofingEnum_File_Type.ShareType_Image)
                    {


                        _ = Task.Run(async () =>
                        {
                            await SRoofing_ScreenChatShow_Image_MessageManager
                            .Owner_ScreenChatShowMessage_Image_MessageWS(
                                                   App.Current,
                      App.iAccountType,
              ((Picker_Chatter_Dashboard)Parent.BindingContext)._iApplicationUtilityModel,
                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iSettingModel,
                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel,
                       _iOwnerModel,
               ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.iGroupModel,

          ((Picker_Chatter_Dashboard)Parent.BindingContext)._iSpeechModel,


                       ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwner_Incoming_LanguageCode,
                         ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwner_Outgoing_LanguageCode,


                             iGroupModel.GroupTokenID,


                                           SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_SharePhotoMessage,
                               ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_ScreenChatShow_ShareImage_Message,

                     "media",
                                    "image",

        ((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel.ImageDefaultServerURL,

                  ((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel.ImageDefaultServerID,
        null,
            //null,
            //        null,
                     ((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel.ImageDefaultServerURL, "0", "0",
          false,
        ((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel);

                        })
                        .ConfigureAwait(false);



                    }


                    else if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel.MediaFile_Code == SRoofingEnum_File_Type.ShareType_Video)
                    {


                        _ = Task.Run(async () =>
                        {
                            await SRoofing_ScreenChatShow_Video_MessageManager
                           .Owner_ScreenChatShowMessage_Video_MessageWS(
                                                  App.Current,
                     App.iAccountType,
                  ((Picker_Chatter_Dashboard)Parent.BindingContext)._iApplicationUtilityModel,
                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iSettingModel,

                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel,
                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
            ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.iGroupModel,

        ((Picker_Chatter_Dashboard)Parent.BindingContext)._iSpeechModel,


                     ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwner_Incoming_LanguageCode,
                     ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwner_Outgoing_LanguageCode,


                           ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID,


                                          SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareVideoMessage,
                          ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_ScreenChatShow_ShareVideo_Message,

                    "media",
                                   "video",

                                   null,

        ((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel.VideoDefaultServerURL,

                  ((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel.VideoDefaultServerID,
                       ((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel.VideoDefaultServerURL,
        null,
        ((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel.VideoDefaultServerURL,
                     "0", "0",
         false,
         ((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel);

                        })
                     .ConfigureAwait(false);


                    }

                    else if (((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel.MediaFile_Code == SRoofingEnum_File_Type.ShareType_Document)
                    {

                        _ = Task.Run(async () =>
                        {
                            await SRoofing_ScreenChatShow_DocumentMessageManager
                           .Owner_ScreenChatShowMessage_Document_MessageWS(
                                                  App.Current,
                     App.iAccountType,
                  ((Picker_Chatter_Dashboard)Parent.BindingContext)._iApplicationUtilityModel,
                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iSettingModel,

                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel,
                    ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwnerModel,
            ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.iGroupModel,

        ((Picker_Chatter_Dashboard)Parent.BindingContext)._iSpeechModel,


                     ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwner_Incoming_LanguageCode,
                     ((Picker_Chatter_Dashboard)Parent.BindingContext)._iOwner_Outgoing_LanguageCode,


                           ((Picker_Chatter_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID,


                                          SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareDocument,
                          ((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_ScreenChatShow_ShareDocument_Message,


                "media",
                              "file",

                                   null,

        ((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel.ImageDefaultServerID,

                 null,
                       ((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel.ImageDefaultServerURL,

        ((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel.ImageDefaultServerURL,
                     "0",
         false,
         ((Picker_Chatter_Dashboard)Parent.BindingContext)._iMessageModel);

                        })
                                             .ConfigureAwait(false);


                    }


                    //} )
                    //    .ConfigureAwait ( false );

                    App.bln_IsBack_FromShareScreen_PickerPopup = true;

                }
                else
                {
                    await SRoofing_ToastMessageManager.ToastMessage_Show_Message(((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Connection_CheckOnline_Message);
                }

            }
            else
            {
                await SRoofing_ToastMessageManager.ToastMessage_Show_Message(((Picker_Chatter_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_AppError_TryAgainLater);
            }
            //grd_VideoPlayer.IsVisible = true;

            //await DisplayAlert ( "Result" , $"Result: {result.ReturnData}" , "OK" );

            //_ = Task.Run ( async ( ) =>
            //  {



            //Navigation.PopModalAsync ( );

            //  return Task.FromResult ( true );
            //

            //MainThread.BeginInvokeOnMainThread(async () =>
            //{
            //    // Get number of modals on the Navigation Stack
            //    int numModals = Navigation.ModalStack.Count;

            //    // Pop each modal in the stack
            //    for (int currModal = 0; currModal < numModals; currModal++)
            //    {
            //        await Navigation.PopModalAsync();
            //    }
            //});

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;// Task.FromResult ( false ); ;
        }
    }


    #endregion




}