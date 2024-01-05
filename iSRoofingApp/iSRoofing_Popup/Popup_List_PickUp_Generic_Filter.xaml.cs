
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
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using MauiPopup;
using S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.Country;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Utility;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Popup;

//[XamlCompilation ( XamlCompilationOptions.Compile )]
public partial class Popup_List_PickUp_Generic_Filter : BasePopupPage
{

    public static string parameter { get; set; } = null;


    //ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList { get; set; } // = null;// = new ObservableCollection<SRoofingKeyValueModelManager>();

    //public ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList { get;   set; }

    //List<Y> listOfY = listOfX.Cast<Y>().ToList();
    public ObservableCollection<SRoofingKeyValueModelManager> arr_ItemOriginalList { get; set; }
    public List<SRoofingKeyValueModelManager> arr_ItemPatchList { get; set; }
    public ObservableCollection<SRoofingKeyValueModelManager> arr_ItemDisplayList { get; set; } = new ObservableCollection<SRoofingKeyValueModelManager>();
    //public ObservableCollection<Object> arr_ItemList { get; set; }


    public static string popupCode { get; set; } = null;


    //ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList { get; set; } // = null;// = new ObservableCollection<SRoofingKeyValueModelManager>();

    //public ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList { get;   set; }

    //List<Y> listOfY = listOfX.Cast<Y>().ToList();
    public ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList { get; set; }
    //public ObservableCollection<Object> arr_ItemList { get; set; }

    public SRoofingApplicationUtilityModelManager _iApplicationUtilityModel;



    public Popup_List_PickUp_Generic_Filter(
         SRoofingApplicationUtilityModelManager iApplicationUtitlityModel,  SRoofingUserOwnerModelManager iOwnerModel,
          
         string str)
    {

        InitializeComponent();
        //get pass value from contentpage,
        popupCode = str;
        parameter = str;

        _iOwnerModel = iOwnerModel;

        _iApplicationUtilityModel = iApplicationUtitlityModel;


        grd_Container.WidthRequest = _iApplicationUtilityModel.iYouTube_iMedia_Width;


        Task.Run(async () =>
        {
            await Initialize_AppTranslation();
        }).Wait();




        //////////////Initialize_List(str);


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


    public Popup_List_PickUp_Generic_Filter(string str)
    {

        InitializeComponent();
        //get pass value from contentpage,
        parameter = str;



        Task.Run(async () =>
            {
                await Initialize_AppTranslation();

                //await Initialize_List(str);

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





    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
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



    async Task Initialize_List(string strCode)
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




            ///////////////////////////////////////////////



            ObservableCollection<SRoofingKeyValueModelManager> arr_AlphabetList_Initialize_BackList = new ObservableCollection<SRoofingKeyValueModelManager>();

            arr_AlphabetList_Initialize_BackList = await SRoofingSync_UserContactManager
                .Sync_User_Category_Get_Alphabet_Initialize_List_ByOwnerUserTokenID(
                    App.Current);



            await Task.Delay(5000);

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                if (cv_AlphabetList_Initialize.ItemsSource == null)
                {
                    // Code to run on the main thread
                    cv_AlphabetList_Initialize.ItemsSource = arr_AlphabetList_Initialize_BackList;
                }

                await Task.Delay(10);
                frm_Loading.IsVisible=false;

            });




        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }










    #region Initialize

    SRoofingUserOwnerModelManager _iOwnerModel;
    //public static ObservableCollection<SRoofingCategoryModelManager> arr_UserMarshalList
    //{
    //    get; set;
    //}

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

            arr_ItemOriginalList = new ObservableCollection<SRoofingKeyValueModelManager>();
            arr_ItemOriginalList = await SRoofingSync_Speech_Manager
                .Sync_Speech_Get_SpeechList(App.Current);


            ////////MainThread.BeginInvokeOnMainThread(() =>
            ////////{
            ////////    // Code to run on the main thread
            ////////    MyCollection.ItemsSource = arr_ItemList;

            ////////});


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





    int _iPageCountNumber = 1;
    bool _blnIsBusy = false;
    bool _blnIsScrollEnded = false;

    void MyCollectionView_RemainingItemsThresholdReached(object sender, EventArgs e)
    {

        try
        {



            _ = Task.Run(async () =>
            {

                if (!_blnIsBusy && !_blnIsScrollEnded)
                {
                    _blnIsBusy= true;

                    arr_ItemPatchList= new List<SRoofingKeyValueModelManager>();

                    if (_iPageCountNumber <= 24)
                    {
                        arr_ItemPatchList=  arr_ItemOriginalList.Skip(_iPageCountNumber * 10).Take(10).ToList();

                        _iPageCountNumber +=1;

                    }
                    else if (_iPageCountNumber == 25)
                    {
                        arr_ItemPatchList=  arr_ItemOriginalList.Skip(_iPageCountNumber * 10).Take(6).ToList();

                        _iPageCountNumber +=1;

                    }
                    else
                    {
                        _blnIsScrollEnded= true;
                    }

                    if (!_blnIsScrollEnded)
                    {


                        MainThread.BeginInvokeOnMainThread(() =>
                        {

                            foreach (var item in arr_ItemPatchList)
                            {
                                arr_ItemDisplayList.Add(item);
                            }
                            _blnIsBusy= false;


                        });




                    }


                }



            }).ConfigureAwait(false);




            //////////arrList.AddRange(GetItems(15));


            ////////       foreach (var s in GetItems(15))
            ////////       {
            ////////           arrList.Add(s);
            ////////       }
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;

        }

    }
    private readonly Random randomizer = new Random();

    private List<string> GetItems(int numberOfItems)
    {
        var resultList = new List<string>();

        for (var i = 0; i <= numberOfItems; i++)
        {
            resultList.Add(randomizer.Next(10000, 99999).ToString());
        }

        return resultList;
    }





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

    private void page_Popup_Loaded(object sender, EventArgs e)
    {
        try
        {


            _=   Task.Run(async () =>
            {
                //await Initialize_AppTranslation();

                await Initialize_List(parameter);

            }).ConfigureAwait(false);



        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;

        }
    }

    private void cv_AlphabetList_Initialize_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

        try
        {



            _ = Task.Run(async () =>
            {


                SRoofing_DebugManager.Debug_ShowSystemMessage(
                             "*** cv_AlphabetList *** == "
                             + (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager).ItemValue.ToString());

                string xxx = (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager).ItemValue.ToString();
                arr_ItemPatchList= new List<SRoofingKeyValueModelManager>();
                // arr_ItemDisplayList= new ObservableCollection<SRoofingKeyValueModelManager>();



                arr_ItemPatchList=  arr_ItemOriginalList
        .Where(x => x != null
            //&& !string.IsNullOrEmpty(x.Name)
            && x.ItemText.ToString().StartsWith(xxx))
        .ToList(); //arr_ItemOriginalList.Take(10).ToList();

                //_iPageCountNumber=1;



                MainThread.BeginInvokeOnMainThread(() =>
                {

                    if (arr_ItemPatchList!= null)
                    {

                        arr_ItemDisplayList.Clear();

                        foreach (var item in arr_ItemPatchList)
                        {
                            arr_ItemDisplayList.Add(item);
                        }

                        if (MyCollection.ItemsSource == null)
                        {

                            MyCollection.ItemsSource =arr_ItemDisplayList;

                        }
                    }
                });



            }).ConfigureAwait(false);






            //////        = myList
            //////.Where(x => x != null
            //////    && !string.IsNullOrEmpty(x.Name)
            //////    && x.Name.StarstWith("GHB"))
            //////.ToList();






            //MessagingCenter.Send<App, String>(App.Current as App, "OpenPage", "SHAYMAA");
            //MessagingCenter.Send<App, String>(App.Current as App, "OpenPage", (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager)?.id.ToString());
            //////MessagingCenter.Send<App , SRoofingKeyValueModelManager> (
            //////	App.Current as App ,
            //////	"OpenPage" , ( e.CurrentSelection.FirstOrDefault ( ) as SRoofingKeyValueModelManager ) );

            //////MessagingCenter.Send(
            //////        Application.Current as App,
            //////        "OpenPage", (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager));

            //MessagingCenter.Send<App, String>(App.Current as App, "OpenPage", e.CurrentSelection.FirstOrDefault());

            // TODO-MAUI Navigation.RemovePopupPageAsync ( this );

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }
}