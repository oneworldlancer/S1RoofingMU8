

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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Category;
using System.IO.IsolatedStorage;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Popup
{
    ////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Popup_List_PickUp_Generic : BasePopupPage
    {

        public static string popupCode { get; set; } = null;


        //ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList { get; set; } // = null;// = new ObservableCollection<SRoofingKeyValueModelManager>();

        //public ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList { get;   set; }

        //List<Y> listOfY = listOfX.Cast<Y>().ToList();
        public ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList { get; set; }
        //public ObservableCollection<Object> arr_ItemList { get; set; }

        public SRoofingApplicationUtilityModelManager _iApplicationUtilityModel;


        public Popup_List_PickUp_Generic(
              SRoofingApplicationUtilityModelManager iApplicationUtitlityModel,  SRoofingUserOwnerModelManager iOwnerModel,
             
         
                 string str)
        {

            InitializeComponent();
            //get pass value from contentpage,
            popupCode = str;
            _iOwnerModel = iOwnerModel;

            _iApplicationUtilityModel = iApplicationUtitlityModel;


            grd_Container.WidthRequest = _iApplicationUtilityModel.iYouTube_iMedia_Width;



            Task.Run(async () =>
            {
                await Initialize_AppTranslation();
            }).Wait();




            //arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager> ( );
            ////arr_ItemList = BashKatebSync_Country_Manager.Sync_Country_Get_CountryList_All ( App.Current );

            //MyCollection.ItemsSource = arr_ItemList;

            ////BashKatebKeyValueModelManagerView.ItemsSource = arr_ItemList; 

            //// ObservableCollection allows items to be added after ItemsSource
            //// is set and the UI will react to changes
            ////arr_ItemList.Add(new SRoofingKeyValueModelManager ( "Rob Finnerty" ));
            ////arr_ItemList.Add(new SRoofingKeyValueModelManager ("Bill Wrestler" ));
            //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
            //	{
            //	ItemCode = "Command1101" ,
            //	ItemValue = "11011" ,
            //	ItemText = "ItemText11011"
            //	} );

            //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
            //	{
            //	ItemCode = "Command1101" ,
            //	ItemValue = "11012" ,
            //	ItemText = "ItemText11012"
            //	} );



            //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
            //	{
            //	ItemCode = "Command1101" ,
            //	ItemValue = "11013" ,
            //	ItemText = "ItemText11013"
            //	} );

            Initialize_List(str);


            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "3Dr. Geri-Beth Hooper",
            //    id = 3
            //});
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "4Dr. Geri-Beth Hooper",
            //    id = 4
            //});
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //          arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //          arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //          arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //          arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //          arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //          arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //          arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager() { DisplayName = "Dr. Geri-Beth Hooper" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager { DisplayName = "Dr. Keith Joyce-Purdy" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager { DisplayName = "Sheri Spruce" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager { DisplayName = "Burt Indybrick" });
            //arr_ItemList.Add(new SRoofingKeyValueModelManager { DisplayName = "Burt Indybrick" });
            //lblMessage.Text = parameter;


            BindingContext = this;
        }

      async  private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                //MessagingCenter.Send<App, String>(App.Current as App, "OpenPage", "SHAYMAA");
                //MessagingCenter.Send<App, String>(App.Current as App, "OpenPage", (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager)?.id.ToString());
                //////MessagingCenter.Send<App , SRoofingKeyValueModelManager> (
                //////	App.Current as App ,
                //////	"OpenPage" , ( e.CurrentSelection.FirstOrDefault ( ) as SRoofingKeyValueModelManager ) );


                if (popupCode == SRoofingEnum_PopupByCodeManager.PopupByCode_CATEGORY_LIST)
                {

                    MessagingCenter.Send<App, SRoofingKeyValueModelManager>(
                            App.Current as App,
                            "OpenPage", (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager));



                }

                else if (popupCode == SRoofingEnum_PopupByCodeManager.PopupByCode_SPEECH_INCOMING)
                {


                    MessagingCenter.Send<App, SRoofingKeyValueModelManager>(
                            App.Current as App,
                            SRoofingEnum_MessageCenter.MessageCenter_SETTING_SEPEECH_INCOMING, (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager));




                }
                else if (popupCode == SRoofingEnum_PopupByCodeManager.PopupByCode_SPEECH_OUTGOING)
                {


                    MessagingCenter.Send<App, SRoofingKeyValueModelManager>(
                            App.Current as App,
                         SRoofingEnum_MessageCenter.MessageCenter_SETTING_SEPEECH_OUTGOING, (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager));


                }

                else if (popupCode == SRoofingEnum_PopupByCodeManager.PopupByCode_SOUND_CHAT_IN)
                {


                    MessagingCenter.Send<App, SRoofingKeyValueModelManager>(
                            App.Current as App,
                           SRoofingEnum_MessageCenter.MessageCenter_SETTING_SOUND_CHAT_INCOMING, (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager));



                }
                else if (popupCode == SRoofingEnum_PopupByCodeManager.PopupByCode_SOUND_CHAT_OUT)
                {



                    MessagingCenter.Send<App, SRoofingKeyValueModelManager>(
                            App.Current as App,
                            SRoofingEnum_MessageCenter.MessageCenter_SETTING_SOUND_CHAT_OUTGOING, (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager));



                }
                else if (popupCode == SRoofingEnum_PopupByCodeManager.PopupByCode_SOUND_CALL_IN)
                {


                    MessagingCenter.Send<App, SRoofingKeyValueModelManager>(
                            App.Current as App,
                       SRoofingEnum_MessageCenter.MessageCenter_SETTING_SOUND_CALL_INCOMING, (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager));




                }
                else if (popupCode == SRoofingEnum_PopupByCodeManager.PopupByCode_SOUND_CALL_OUT)
                {


                    MessagingCenter.Send<App, SRoofingKeyValueModelManager>(
                            App.Current as App,
                          SRoofingEnum_MessageCenter.MessageCenter_SETTING_SOUND_CALL_OUTGOING, (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager));




                }
                else if (popupCode == SRoofingEnum_PopupByCodeManager.PopupByCode_GALERY_PICKERLIST)
                {


                    MessagingCenter.Send<App, SRoofingKeyValueModelManager>(
                            App.Current as App,
                          SRoofingEnum_MessageCenter.MessageCenter_GALERY_PICKERLIST, (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager));
                }

                else if (popupCode == SRoofingEnum_PopupByCodeManager.PopupByCode_CALL_AUTOMESSSAGE)
                {


                    MessagingCenter.Send<App, SRoofingKeyValueModelManager>(
                            App.Current as App,
                          SRoofingEnum_MessageCenter.MessageCenter_CALL_AUTOMESSAGE, (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager));
                }



                await MauiPopup.PopupAction.ClosePopup();



                //MessagingCenter.Send<App, String>(App.Current as App, "OpenPage", e.CurrentSelection.FirstOrDefault());
                // TODO-MAUI Navigation.RemovePopupPageAsync ( this );
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        async private void btn_Popup_OK_Tapped(object sender, EventArgs e)
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



        async void Initialize_List(string strCode)
        {

            try
            {

                if (strCode == SRoofingEnum_PopupByCodeManager.PopupByCode_CATEGORY_LIST)
                {

                    await Initialize_Category_List();


                }

                else if (strCode == SRoofingEnum_PopupByCodeManager.PopupByCode_SPEECH_INCOMING)
                {

                    await Initialize_Speech_List();


                }
                else if (strCode == SRoofingEnum_PopupByCodeManager.PopupByCode_SPEECH_OUTGOING)
                {

                    await Initialize_Speech_List();


                }

                else if (strCode == SRoofingEnum_PopupByCodeManager.PopupByCode_SOUND_CHAT_IN)
                {

                    await Initialize_Sound_Chat_In_List();


                }
                else if (strCode == SRoofingEnum_PopupByCodeManager.PopupByCode_SOUND_CHAT_OUT)
                {

                    await Initialize_Sound_Chat_Out_List();


                }
                else if (strCode == SRoofingEnum_PopupByCodeManager.PopupByCode_SOUND_CALL_IN)
                {

                    await Initialize_Sound_Call_In_List();


                }
                else if (strCode == SRoofingEnum_PopupByCodeManager.PopupByCode_SOUND_CALL_OUT)
                {

                    await Initialize_Sound_Call_Out_List();


                }
                else if (strCode == SRoofingEnum_PopupByCodeManager.PopupByCode_GALERY_PICKERLIST)
                {

                    await Initialize_Sound_Gallery_Picker_List();


                }
                else if (strCode == SRoofingEnum_PopupByCodeManager.PopupByCode_CALL_AUTOMESSSAGE)
                {

                    await Initialize_Call_AutoMessage_List();


                }

                ////////    arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager> ( );

                ////////arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                ////////    {
                ////////    ItemCode = "Command1101" ,
                ////////    ItemValue = "11013" ,
                ////////    ItemText = "الأوراق المطلوبه لتقديم طلبات (ندب - نقل - إعاره)"
                ////////    } );




                ////////arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                ////////    {
                ////////    ItemCode = "Command1101" ,
                ////////    ItemValue = "11013" ,
                ////////    ItemText = "تقديم طلبات (ندب - نقل - إعاره)"
                ////////    } );

                //////////arr_ItemList =SRoofingSync_Country_Manager
                //////////                    .Sync_Country_Get_CountryList_All ( Application.Current );




                //////////	}
                //////////BashKatebKeyValueModelManagerView.ItemsSource = arr_ItemList; 

                ////////// ObservableCollection allows items to be added after ItemsSource
                ////////// is set and the UI will react to changes
                //////////arr_ItemList.Add(new SRoofingKeyValueModelManager ( "Rob Finnerty" ));
                //////////arr_ItemList.Add(new SRoofingKeyValueModelManager ("Bill Wrestler" ));


                //////////////////if ( strCode == "Command1101" )
                //////////////////	{



                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "الأوراق المطلوبه لتقديم طلبات (ندب - نقل - إعاره)"
                //////////////////		} );




                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "تقديم طلبات (ندب - نقل - إعاره)"
                //////////////////		} );




                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "الإستعلام عن طلب (ندب - نقل - إعاره)"
                //////////////////		} );



                //////////////////	}
                //////////////////else if ( strCode == "Command2202" )
                //////////////////	{



                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "الإستعلام عن قرار تكليف"
                //////////////////		} );




                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "الأوراق المطلوبه لإستلام التكليف"
                //////////////////		} );




                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "إستخراج إفاده بعدم إستلام العمل"
                //////////////////		} );



                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "إستخراج إفاده بالموافقه على تعديل التكليف"
                //////////////////		} );





                //////////////////	}	

                //////////////////else if ( strCode == "Command3303" )
                //////////////////	{



                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "إستخراج بيان حاله وظيفيه"
                //////////////////		} );




                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "طلب شهادة خبره"
                //////////////////		} );




                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "الإستعلام عن الترقيات الفنيه"
                //////////////////		} );



                //////////////////	}


                //////////////////else if ( strCode == "Command4404" )
                //////////////////	{



                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "الإستعلام عن الأوراق المطلويه لتقديم أجازه"
                //////////////////		} );




                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "تقديم طلب أجازه و رفع الأوراق المطلوبه"
                //////////////////		} );




                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "موقف الطلب المقدم للأجازه"
                //////////////////		} );



                //////////////////	}


                //////////////////else if ( strCode == "Command5505" )
                //////////////////	{



                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "المستندات المطلوبه لإنهاء الخدمه (معاش - لإستقاله)"
                //////////////////		} );




                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "سداد رسوم الأجازه"
                //////////////////		} );




                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "الإستعلام عن طلبات إنهاء الخدمه"
                //////////////////		} );



                //////////////////	}
                //////////////////	  	else if ( strCode == "Command6606" )
                //////////////////	{



                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "المستندات المطلوبه لإنهاء الخدمه (معاش - إستقاله)"
                //////////////////		} );




                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "سداد رسوم الأجازه"
                //////////////////		} );




                //////////////////	arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //////////////////		{
                //////////////////		ItemCode = "Command1101" ,
                //////////////////		ItemValue = "11013" ,
                //////////////////		ItemText = "الإستعلام عن طلبات إنهاء الخدمه"
                //////////////////		} );



                //////////////////	}

                ////////MyCollection.ItemsSource = arr_ItemList;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }

        }










        #region Initialize

        SRoofingUserOwnerModelManager _iOwnerModel;
        public static ObservableCollection<SRoofingCategoryModelManager> arr_UserMarshalList
        {
            get; set;
        }

        public async Task Initialize_Category_List()
        {


            try
            {


                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager>();
                arr_ItemList = await SRoofingSync_UserCategoryManager
                    .Sync_User_Category_Get_Category_List_KeyValueModel_ByOwnerUserTokenID(
                    App.Current,
                    _iOwnerModel);


                MainThread.BeginInvokeOnMainThread(() =>
              {
                  // Code to run on the main thread
                  MyCollection.ItemsSource = arr_ItemList;

              });




            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }




        public async Task Initialize_Speech_List()
        {


            try
            {

                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager>();
                arr_ItemList = await SRoofingSync_Speech_Manager
                    .Sync_Speech_Get_SpeechList(
                    App.Current);


                MainThread.BeginInvokeOnMainThread(() =>
              {
                  // Code to run on the main thread
                  MyCollection.ItemsSource = arr_ItemList;

              });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }








        public async Task Initialize_Sound_Chat_In_List()
        {


            try
            {

                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager>();

                arr_ItemList =   await SRoofingSync_Sound_Manager.Sync_Sound_Get_Chat_Incoming_List(App.Current);



                //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //{
                //    ItemText = "Sound-1" ,
                //    ItemValue = "snd_chat_in_1.mp3"
                //} );


                //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //{
                //    ItemText = "Sound-2" ,
                //    ItemValue = "snd_chat_in_2.mp3"
                //} );


                //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //{
                //    ItemText = "Sound-3" ,
                //    ItemValue = "snd_chat_in_3.mp3"
                //} );


                MainThread.BeginInvokeOnMainThread(() =>
              {
                  // Code to run on the main thread
                  MyCollection.ItemsSource = arr_ItemList;

              });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }




        public async Task Initialize_Sound_Chat_Out_List()
        {


            try
            {

                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager>();

                arr_ItemList = await SRoofingSync_Sound_Manager.Sync_Sound_Get_Chat_Outgoing_List(App.Current);


                //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //{
                //    ItemText = "Sound-1" ,
                //    ItemValue = "snd_chat_out_1.mp3"
                //} );


                //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //{
                //    ItemText = "Sound-2" ,
                //    ItemValue = "snd_chat_out_2.mp3"
                //} );


                //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //{
                //    ItemText = "Sound-3" ,
                //    ItemValue = "snd_chat_out_3.mp3"
                //} );


                MainThread.BeginInvokeOnMainThread(() =>
              {
                  // Code to run on the main thread
                  MyCollection.ItemsSource = arr_ItemList;

              });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }




        public async Task Initialize_Sound_Call_In_List()
        {


            try
            {

                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager>();


                arr_ItemList = await SRoofingSync_Sound_Manager.Sync_Sound_Get_Call_Incoming_List(App.Current);


                //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //{
                //    ItemText = "Sound-1" ,
                //    ItemValue = "snd_call_in_1.mp3"
                //} );


                //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //{
                //    ItemText = "Sound-2" ,
                //    ItemValue = "snd_call_in_2.mp3"
                //} );


                //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //{
                //    ItemText = "Sound-3" ,
                //    ItemValue = "snd_call_in_3.mp3"
                //} );


                MainThread.BeginInvokeOnMainThread(() =>
              {
                  // Code to run on the main thread
                  MyCollection.ItemsSource = arr_ItemList;

              });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }




        public async Task Initialize_Sound_Call_Out_List()
        {


            try
            {

                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager>();


                arr_ItemList = await SRoofingSync_Sound_Manager.Sync_Sound_Get_Call_Outgoing_List(App.Current);


                //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //{
                //    ItemText = "Sound-1" ,
                //    ItemValue = "snd_call_out_1.mp3"
                //} );


                //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //{
                //    ItemText = "Sound-2" ,
                //    ItemValue = "snd_call_out_2.mp3"
                //} );


                //arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                //{
                //    ItemText = "Sound-3" ,
                //    ItemValue = "snd_call_out_3.mp3"
                //} );


                MainThread.BeginInvokeOnMainThread(() =>
              {
                  // Code to run on the main thread
                  MyCollection.ItemsSource = arr_ItemList;

              });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }




        public async Task Initialize_Sound_Gallery_Picker_List()
        {


            try
            {

                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager>();

                arr_ItemList = await SRoofingSync_AutoMessage_Manager
                    .Sync_AutoMessage_Gallery_Get_PickerMessageList_ByAccountType(App.Current); ;


                MainThread.BeginInvokeOnMainThread(() =>
              {
                  // Code to run on the main thread
                  MyCollection.ItemsSource = arr_ItemList;

              });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }








        public async Task Initialize_Call_AutoMessage_List()
        {


            try
            {

                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager>();

                arr_ItemList = await SRoofingSync_AutoMessage_Manager.Sync_AutoMessage_Call_Get_AutoReplyMessageList_ByAccountType(App.Current); ;


                MainThread.BeginInvokeOnMainThread(() =>
              {
                  // Code to run on the main thread
                  MyCollection.ItemsSource = arr_ItemList;

              });


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }


        }





        #endregion




        #region AppTranslation

        public SRoofingLanguageTranslateModel _iLanguageModel;//{ get; set; } = new SRoofingLanguageTranslateModel ( );



        async Task Initialize_AppTranslation()
        {
            try
            {
                //_iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All ( App.Current );


                if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);

                //lbl_Title.Text = _iLanguageModel.lblText_Popup_Title_GroupNew_Message;
                //txt_MessageText.Placeholder = _iLanguageModel.lblText_Group_Title_Message;

                //lbl_Error.Text = _iLanguageModel.lblText_Connection_CheckOnline_Message;

                btn_Popup_OK.Text = _iLanguageModel.lblText_Command_Cancel;
                //btn_Popup_CANCEL.Text = _iLanguageModel.lblText_Command_CANCEL_Message;


                //lbl_TabChat.Text = _iLanguageModel.lblText_Tab_Chats;
                //lbl_TabCall.Text = _iLanguageModel.lblText_Tab_Calls;


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