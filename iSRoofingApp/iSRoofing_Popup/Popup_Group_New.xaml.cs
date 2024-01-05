
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;


using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;


using System.Net.Http;


using MauiPopup.Views;


using System;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Time;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Popup
{
    ////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Popup_Group_New : BasePopupPage
    {

        public static string parameter { get; set; } = null;


        //ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList { get; set; } // = null;// = new ObservableCollection<SRoofingKeyValueModelManager>();

        //public ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList { get;   set; }

        //List<Y> listOfY = listOfX.Cast<Y>().ToList();
        public ObservableCollection<SRoofingCountryModel> arr_ItemList { get; set; }
        //public ObservableCollection<Object> arr_ItemList { get; set; }
        public SRoofingApplicationUtilityModelManager _iApplicationUtilityModel;

        string _iBroadcastParentWindow;

        public Popup_Group_New(
            SRoofingApplicationUtilityModelManager iApplicationUtitlityModel,
            string iBroadcastParentWindow,
            string str)
        {

            InitializeComponent();
            //get pass value from contentpage,
            parameter = str;

            _iBroadcastParentWindow = iBroadcastParentWindow;

            _iApplicationUtilityModel = iApplicationUtitlityModel;

            frm_Content.WidthRequest = _iApplicationUtilityModel.iYouTube_iMedia_Width;





            Task.Run(async () =>
   {
       await Initialize_List(str);


   }).Wait();



            BindingContext = this;

        }

        private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                //MessagingCenter.Send<App, String>(App.Current as App, "OpenPage", "SHAYMAA");
                //MessagingCenter.Send<App, String>(App.Current as App, "OpenPage", (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager)?.id.ToString());
                //////MessagingCenter.Send<App , SRoofingKeyValueModelManager> (
                //////	App.Current as App ,
                //////	"OpenPage" , ( e.CurrentSelection.FirstOrDefault ( ) as SRoofingKeyValueModelManager ) );

                MessagingCenter.Send<App, SRoofingCountryModel>(
                        App.Current as App,
                        "OpenPage", (e.CurrentSelection.FirstOrDefault() as SRoofingCountryModel));

                //MessagingCenter.Send<App, String>(App.Current as App, "OpenPage", e.CurrentSelection.FirstOrDefault());
                // TODO-MAUI Navigation.RemovePopupPageAsync ( this );

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        bool _bln_IsOnPregress = false;

        async private void btn_Popup_OK_Tapped(object sender, EventArgs e)
        {

            try
            {


                #region HideKeyboard

                await Task.Delay(100);

                S1RoofingMU.Platforms.KeyboardHelper.HideKeyboard();

                await Task.Delay(100);

                #endregion


                if (!_bln_IsOnPregress)
                {
                    _bln_IsOnPregress = true;

                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {
                        if (!string.IsNullOrWhiteSpace(txt_MessageText.Text))
                        {
                            string xMessageText = txt_MessageText.Text;
                            string _iGroupTokenID = SRoofing_TimeManager.Time_GenerateToken();

                            MainThread.BeginInvokeOnMainThread(() =>
                 {
                     pb_ProgressBar.IsVisible = true;
                 });


                            #region iTimeModel

                            SRoofingTimeModel _iTimeModel = new SRoofingTimeModel();
                            _iTimeModel = SRoofing_TimeManager.Time_Get_TimeModel(DateTime.Now);

                            #endregion




                            string _strResult = await SRoofing_UserGroupManager.Initialize_UserGroup_New_CREATE_Group_ByOwnerUserTokenID(

                                              App.Current,
                                              App.iAccountType,
                                              _iOwnerModel,
                                              _iGroupTokenID,
                                             xMessageText,
                                             _iTimeModel);

                            if (_strResult != "0")
                            {


                                SRoofingUserRemoteModelManager _iRemoteModel = null;
                                SRoofingUserGroupModelManager _iGroupModel = null;

                                await Task.Delay(3000);

                                _iRemoteModel = null;


                                _iGroupModel = new SRoofingUserGroupModelManager();


                                _iGroupModel = await SRoofingSync_UserGroupManager.Sync_User_Group_Get_UserModel(
                                      App.Current,
                                      _iOwnerModel,
                                      _iGroupTokenID);


                                if (_iGroupModel == null)
                                {


                                    _iGroupModel = new SRoofingUserGroupModelManager();

                                    _iGroupModel =

                                        await SRoofing_UserGroupManager.SRoofing_UserGroup_Get_Group_Model_ByGroupTokenID(

                                                App.Current,
                                                    _iOwnerModel,
                                                     _iGroupTokenID);

                                }


                                //////////////////////////////////////_ = await SRoofing_ScreenChatShowManager
                                //////////////////////////////////////        .Chat_Initialize_Chat_Show(
                                //////////////////////////////////////             App.Current,
                                //////////////////////////////////////             _iOwnerModel,
                                //////////////////////////////////////             _iRemoteModel,
                                //////////////////////////////////////             _iGroupModel);



                                ////////////////////////////////  


                                //////await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener_WithChecker (
                                //////        Navigation ,
                                //////        typeof ( Page_Chat_Dashboard ) ,
                                //////    new Page_Chat_Dashboard ( ) ,
                                //////    false ,
                                //////    true );

















                                /* History-Chat */
                                SRoofingScreenChatShowHistoryMessageModelManager _iNew_HistoryChatMessageModel = new SRoofingScreenChatShowHistoryMessageModelManager()
                                {


                                    AccountType = App.iAccountType,


                                    GroupTitle = xMessageText,

                                    OwnerUserTokenID = _iOwnerModel.OwnerUserTokenID,//iDataModel.OwnerUserTokenID ,

                                    OwnerMobileNumberTokenID = _iOwnerModel.OwnerMobileNumberTokenID,// iDataModel.OwnerMobileNumberTokenID ,

                                    VisibleOnlineDateTimeMilliSec = "0",

                                    CategoryTitle = "0",


                                    ChatterListCount = "0",

                                    AvatarImageID = "0",

                                    MessageType = "0",

                                    RemoteMobileNumberE164 = "0",

                                    IsNewMessage = false,

                                    DateTimeText = _iTimeModel.DateTimeTextWS,

                                    MessageText = _iLanguageModel.lblText_Chat_StartNew_Message,



                                    PrivateGroupTokenID = "0",

                                    GroupTokenID = _iGroupTokenID,

                                    GroupType = SRoofingEnum_GroupType.GroupType_GROUP,

                                    NameLine = _iGroupModel.NameLine,

                                    AvatarName = _iGroupModel.AvatarName,

                                    RemoteUserTokenID = "0",

                                    RemoteMobileNumberTokenID = "0",

                                    RemoteFullName = "0",

                                    RemoteVisibleStatus = "0",

                                    MessageTokenID = "0",

                                    DateTime = "0",

                                    DateTimeMilliSec = "0",

                                    //IsOpen = true ,

                                    GroupCode = _iGroupModel.GroupCode,

                                    GroupTag = _iGroupModel.GroupTag,

                                    iViewCodeType = SRoofingEnum_Generic_RowView_AdapterType.RowView_Item,


                                    IsVisible = true,
                                };


                                /* Save-Database */

                                _ = Task.Run(async () =>
                     {


                         await App.Database.deleteDataAsync_HistoryChat_MessageModel(_iGroupTokenID);
                         await App.Database.saveDataAsync_HistoryChat_MessageModel(_iNew_HistoryChatMessageModel);


                     }).ConfigureAwait(false);


                                MessagingCenter.Send<App, object>(App.Current as App,
           _iBroadcastParentWindow,
           _iNew_HistoryChatMessageModel);


                                //////                    MessagingCenter.Send<App , string> ( App.Current as App ,
                                //////SRoofingEnum_MessageCenter.MessageCenter_GROUP_NEW ,
                                //////SRoofingEnum_MessageCenter.MessageCenter_GROUP_NEW );


                                App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = true;
                                App._blnSyncHistory_ScreenChatShow_CHAT_Thum_List = true;

                                App.bln_ScreenChatShow_OnAppearing_New_MessageList=true;


                                await MauiPopup.PopupAction.ClosePopup();


                            }
                        }


                    }
                    else
                    {
                        lbl_Error.IsVisible = true;
                    }

                }



                ///

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }



        async private void btn_Popup_CANCEL_Tapped(object sender, EventArgs e)
        {

            try
            {

                await MauiPopup.PopupAction.ClosePopup();

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }



        public SRoofingUserOwnerModelManager _iOwnerModel;


        async Task Initialize_List(string strCode)
        {

            try
            {


                await Initialize_AppTranslation();



                _iOwnerModel = await
                    SRoofingSync_User_OwnerManager.Sync_User_Owner_Get_UserModel(
                 App.Current);


                //////if ( strCode == SRoofingEnum_PopupByCodeManager.PopupByCode_COUNTRY_LIST )
                //////	{

                //////arr_ItemList = new ObservableCollection<SRoofingCountryModel> ( );
                //////arr_ItemList =SRoofingSync_Country_Manager
                //////                    .Sync_Country_Get_CountryList_All ( Application.Current );




                //////	}


                //BashKatebKeyValueModelManagerView.ItemsSource = arr_ItemList; 

                // ObservableCollection allows items to be added after ItemsSource
                // is set and the UI will react to changes
                //arr_ItemList.Add(new SRoofingKeyValueModelManager ( "Rob Finnerty" ));
                //arr_ItemList.Add(new SRoofingKeyValueModelManager ("Bill Wrestler" ));


                //////////if ( strCode == "Command1101" )
                //////////	{



                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "الأوراق المطلوبه لتقديم طلبات (ندب - نقل - إعاره)"
                //////////		} );




                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "تقديم طلبات (ندب - نقل - إعاره)"
                //////////		} );




                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "الإستعلام عن طلب (ندب - نقل - إعاره)"
                //////////		} );



                //////////	}
                //////////else if ( strCode == "Command2202" )
                //////////	{



                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "الإستعلام عن قرار تكليف"
                //////////		} );




                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "الأوراق المطلوبه لإستلام التكليف"
                //////////		} );




                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "إستخراج إفاده بعدم إستلام العمل"
                //////////		} );



                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "إستخراج إفاده بالموافقه على تعديل التكليف"
                //////////		} );





                //////////	}	

                //////////else if ( strCode == "Command3303" )
                //////////	{



                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "إستخراج بيان حاله وظيفيه"
                //////////		} );




                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "طلب شهادة خبره"
                //////////		} );




                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "الإستعلام عن الترقيات الفنيه"
                //////////		} );



                //////////	}


                //////////else if ( strCode == "Command4404" )
                //////////	{



                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "الإستعلام عن الأوراق المطلويه لتقديم أجازه"
                //////////		} );




                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "تقديم طلب أجازه و رفع الأوراق المطلوبه"
                //////////		} );




                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "موقف الطلب المقدم للأجازه"
                //////////		} );



                //////////	}


                //////////else if ( strCode == "Command5505" )
                //////////	{



                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "المستندات المطلوبه لإنهاء الخدمه (معاش - لإستقاله)"
                //////////		} );




                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "سداد رسوم الأجازه"
                //////////		} );




                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "الإستعلام عن طلبات إنهاء الخدمه"
                //////////		} );



                //////////	}
                //////////	  	else if ( strCode == "Command6606" )
                //////////	{



                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "المستندات المطلوبه لإنهاء الخدمه (معاش - إستقاله)"
                //////////		} );




                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "سداد رسوم الأجازه"
                //////////		} );




                //////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////		{
                //////////		ItemCode = "Command1101" ,
                //////////		ItemValue = "11013" ,
                //////////		ItemText = "الإستعلام عن طلبات إنهاء الخدمه"
                //////////		} );



                //////////	}

                //	MyCollection.ItemsSource = arr_ItemList;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }







        #region AppTranslation

        public SRoofingLanguageTranslateModel _iLanguageModel;//{ get; set; } = new SRoofingLanguageTranslateModel ( );



        async Task Initialize_AppTranslation()
        {
            try
            {
                //_iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All ( App.Current );


                if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);


                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    // Code to run on the main thread

                    lbl_Title.Text = _iLanguageModel.lblText_Popup_Title_GroupNew_Message;
                    txt_MessageText.Placeholder = _iLanguageModel.lblText_Group_Title_Message;

                    lbl_Error.Text = _iLanguageModel.lblText_Connection_CheckOnline_Message;

                    btn_Popup_OK.Text = _iLanguageModel.lblText_Command_SUBMIT_Message;
                    btn_Popup_CANCEL.Text = _iLanguageModel.lblText_Command_CANCEL_Message;


                    //lbl_TabChat.Text = _iLanguageModel.lblText_Tab_Chats;
                    //lbl_TabCall.Text = _iLanguageModel.lblText_Tab_Calls;


                    if (_iLanguageModel.LanguageCode== "ar")
                    {
                        txt_MessageText.HorizontalTextAlignment= TextAlignment.End;
                    }
                    else
                    {
                        txt_MessageText.HorizontalTextAlignment= TextAlignment.Start;

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











    }
}