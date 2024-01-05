
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


namespace S1RoofingMU.iSRoofingApp.iSRoofing_Popup;

//[XamlCompilation ( XamlCompilationOptions.Compile )]
public partial class Popup_List_PickUp_X1 : BasePopupPage
{

    public static string parameter { get; set; } = null;


    //ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList { get; set; } // = null;// = new ObservableCollection<SRoofingKeyValueModelManager>();

    //public ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList { get;   set; }

    //List<Y> listOfY = listOfX.Cast<Y>().ToList();
    public ObservableCollection<SRoofingCountryModel> arr_ItemOriginalList { get; set; }
    public List<SRoofingCountryModel> arr_ItemPatchList { get; set; }
    public ObservableCollection<SRoofingCountryModel> arr_ItemDisplayList { get; set; }
    //public ObservableCollection<Object> arr_ItemList { get; set; }


    public Popup_List_PickUp_X1(string str)
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

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {

        try
        {
            //MessagingCenter.Send<App, String>(App.Current as App, "OpenPage", "SHAYMAA");
            //MessagingCenter.Send<App, String>(App.Current as App, "OpenPage", (e.CurrentSelection.FirstOrDefault() as SRoofingKeyValueModelManager)?.id.ToString());
            //////MessagingCenter.Send<App , SRoofingKeyValueModelManager> (
            //////	App.Current as App ,
            //////	"OpenPage" , ( e.CurrentSelection.FirstOrDefault ( ) as SRoofingKeyValueModelManager ) );

            MessagingCenter.Send(
                    Application.Current as App,
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

            if (strCode == SRoofingEnum_PopupByCodeManager.PopupByCode_COUNTRY_LIST)
            {

                arr_ItemOriginalList = new ObservableCollection<SRoofingCountryModel>();
                arr_ItemOriginalList =await SRoofingSync_Country_Manager
                        .Sync_Country_Get_CountryList_All(Application.Current);
            }

            arr_ItemPatchList= new List<SRoofingCountryModel>();
            arr_ItemDisplayList= new ObservableCollection<SRoofingCountryModel>();



            ////arr_ItemPatchList=  arr_ItemOriginalList.Take(5).ToList();
            ////_iPageCountNumber=1;

            ////foreach (var item in arr_ItemPatchList)
            ////{
            ////    arr_ItemDisplayList.Add(item);
            ////}

            await Task.Delay(5000);

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                for (int i = 0; i < arr_ItemOriginalList.Count(); i++)
                {
                    // Code to run on the main thread

                    vsl_ItemList.Add(
                            new Label
                            {
                                Text=arr_ItemOriginalList[i].CountryName + " (" +   arr_ItemOriginalList[i].CountryMobileCode + ")"

                            }
                            );


                    await Task.Delay(10);
                }
                await Task.Delay(10);
                frm_Loading.IsVisible=false;


            });

            //////arr_ItemPatchList= new List<SRoofingCountryModel>();
            //////arr_ItemDisplayList= new ObservableCollection<SRoofingCountryModel>();



            //////arr_ItemPatchList=  arr_ItemOriginalList.Take(10).ToList();
            //////_iPageCountNumber=1;

            //////foreach (var item in arr_ItemPatchList)
            //////{
            //////    arr_ItemDisplayList.Add(item);
            //////}

            //////MyCollection.ItemsSource =arr_ItemDisplayList;


            //////MyCollection.RemainingItemsThreshold = 5;
            //////MyCollection.RemainingItemsThresholdReached += MyCollectionView_RemainingItemsThresholdReached;

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

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

                    arr_ItemPatchList= new List<SRoofingCountryModel>();

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
}