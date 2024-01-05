using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumGlobalManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.Alphabet;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;





namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Picker.Contact;



// //[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Picker_Contact_List : ContentView, INotifyPropertyChanged
{

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion



    bool _blnIsInitialized_BroadcastReceiver = false;
    bool _bln_IsInitialized_Page_Contact_Dashboard = false;



    public ObservableCollection<SRoofingUserGroupModelManager> arr_UserMarshalList_Temp { get; private set; } = new ObservableCollection<SRoofingUserGroupModelManager>();
    //{
    //get; set;
    //}

    public ObservableCollection<SRoofingUserGroupModelManager> arr_UserMarshalList { get; private set; } = new ObservableCollection<SRoofingUserGroupModelManager>();
    //{
    //get; set;
    //}


    public ObservableCollection<SRoofingKeyValueModelManager> arr_AlphabetList_Initialize { get; private set; } = new ObservableCollection<SRoofingKeyValueModelManager>();

    public ObservableCollection<SRoofingKeyValueModelManager> arr_AlphabetList_Reset_IndexList { get; private set; } = new ObservableCollection<SRoofingKeyValueModelManager>();
    public ObservableCollection<SRoofingKeyValueModelManager> arr_AlphabetList { get; private set; } = new ObservableCollection<SRoofingKeyValueModelManager>();
    //{
    //get; set;
    //}

    Row_Alphabet_Active_View iActive;

    bool _blnIsInitialized = false;
    public Picker_Contact_List()
    {

        InitializeComponent();

        RefreshCommand = new Command(RefreshData);



        try
        {

            if (!_blnIsInitialized_BroadcastReceiver)
            {

                _blnIsInitialized_BroadcastReceiver = true;

                //MessagingCenter.Subscribe<App , string> ( App.Current , "Page_Load" , async ( snd , arg ) =>
                //{

                //    try
                //    {
                //        //get the value by `arg`

                //        SRoofing_DebugManager.Debug_ShowSystemMessage ( "Page_Load == " + arg.ToString ( ) );

                //        //await Task.Delay ( 0 );

                //        if ( !_bln_IsInitialized_Page_Contact_Dashboard )
                //        {
                //            _bln_IsInitialized_Page_Contact_Dashboard = true;

                //            //  Task.Run ( async ( ) =>
                //            //{
                //            await Initialize ( );
                //            //} );

                //        }



                //    }
                //    catch ( Exception ex )
                //    {
                //        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                //    }

                //} );


                //////MessagingCenter.Subscribe<App , string> ( App.Current , SRoofingEnum_MessageCenter.MessageCenter_PICKER_CONTACT_LIST , async ( snd , arg ) =>
                //////{

                //////    try
                //////    {



                //////        //get the value by `arg`

                //////        SRoofing_DebugManager.Debug_ShowSystemMessage ( "bind_list_chat == " + arg.ToString ( ) );

                //////        //await Task.Delay ( 0 );

                //////        MainThread.BeginInvokeOnMainThread ( async ( ) =>
                //////        {

                //////            // Code to run on the main thread
                //////            if ( refresh_ContactList.IsRefreshing )
                //////            {
                //////                refresh_ContactList.IsRefreshing = false;

                //////            }

                //////            ll_ProgressBar.IsVisible = false;





                //////            if ( cv_UserContactList.ItemsSource == null )
                //////            {
                //////                cv_UserContactList.ItemsSource = arr_UserMarshalList;
                //////            }

                //////            if ( arr_UserMarshalList_Temp != null )
                //////            {
                //////                arr_UserMarshalList.Clear ( );

                //////                for ( int i = 0 ; i < arr_UserMarshalList_Temp.Count ; i++ )
                //////                {
                //////                    arr_UserMarshalList.Add ( arr_UserMarshalList_Temp[ i ] );

                //////                    await Task.Delay ( 50);
                //////                }

                //////            }

                //////            //  ((Picker_Contact_Dashboard)Parent.BindingContext).llProgress_ToggleVisible_ChatList ( true , false );

                //////            //   _bln_IsInitialized_History_ChatList = true;

                //////            //   App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;




                //////        } );

                //////    }
                //////    catch ( Exception ex )
                //////    {
                //////        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                //////    }

                //////} );



            }


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }




        BindingContext = this;
    }

    #region Refresh


    //  public ICommand RefreshCommand => new Command ( async ( ) => await RefreshDataAsync ( ) );


    async Task RefreshDataAsync()
    {
        try
        {

            //refresh_ContactList.I
            // IsRefreshing = true;
            refresh_ContactList.IsRefreshing = true;
            // await Task.Delay ( TimeSpan.FromSeconds ( 5000 ) );
            // Animals.Clear ( );
            //GetNextPageOfData ( );
            //IsRefreshing = false;


            AddBears();


            //???  await Initialize_List_Contact_ByAlphabet ( "X" );

            refresh_ContactList.IsRefreshing = false;
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;

        }

    }




    public async void AddBears()
    {

        try
        {

            //arr_AlphabetList [ 0 ].ItemCode = "active";
            ////arr_AlphabetList [ 1 ].ItemCode = "active";
            ////arr_AlphabetList [ 2 ].ItemCode = "active";
            ////arr_AlphabetList [ 3 ].ItemCode = "active";


            arr_AlphabetList.Clear();
            SRoofingKeyValueModelManager iItem;

            //arr_AlphabetList = new ObservableCollection<SRoofingKeyValueModelManager> ( );

            char[ ] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            for (int i = 0; i < alpha.Length; i++)
            {


                iItem = new SRoofingKeyValueModelManager();
                iItem.ItemText = alpha[i].ToString().ToUpper();
                iItem.ItemValue = alpha[i].ToString().ToUpper();

                if (iItem.ItemValue == "A"
                    || iItem.ItemValue == "B"
                    || iItem.ItemValue == "C"
                    || iItem.ItemValue == "D")
                {

                    iItem.ItemCode = "active";

                }
                else if (iItem.ItemValue == "S")
                {
                    iItem.ItemCode = "select";
                }
                else
                {
                    iItem.ItemCode = "disable";
                }

                arr_AlphabetList.Add(iItem);
                await Task.Delay(10);
            }

            //await Task.Delay ( 5000 );

            //arr_AlphabetList [ 5 ].ItemCode = "select";

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

        //Animals.Clear ( );

        //Animals.Add ( new Animal
        //    {
        //    Name = "American Black Bear" ,
        //    Location = "North America" ,
        //    Details = "The American black bear is a medium-sized bear native to North America. It is the continent's smallest and most widely distributed bear species. American black bears are omnivores, with their diets varying greatly depending on season and location. They typically live in largely forested areas, but do leave forests in search of food. Sometimes they become attracted to human communities because of the immediate availability of food. The American black bear is the world's most common bear species." ,
        //    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzbär.jpg"
        //    } );
        //Animals.Add ( new Animal
        //    {
        //    Name = "Asian Black Bear" ,
        //    Location = "Asia" ,
        //    Details = "The Asian black bear, also known as the moon bear and the white-chested bear, is a medium-sized bear species native to Asia and largely adapted to arboreal life. It lives in the Himalayas, in the northern parts of the Indian subcontinent, Korea, northeastern China, the Russian Far East, the Honshū and Shikoku islands of Japan, and Taiwan. It is classified as vulnerable by the International Union for Conservation of Nature (IUCN), mostly because of deforestation and hunting for its body parts." ,
        //    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
        //    } );
        //Animals.Add ( new Animal
        //    {
        //    Name = "Brown Bear" ,
        //    Location = "Northern Eurasia & North America" ,
        //    Details = "The brown bear is a bear that is found across much of northern Eurasia and North America. In North America the population of brown bears are often called grizzly bears. It is one of the largest living terrestrial members of the order Carnivora, rivaled in size only by its closest relative, the polar bear, which is much less variable in size and slightly larger on average. The brown bear's principal range includes parts of Russia, Central Asia, China, Canada, the United States, Scandinavia and the Carpathian region, especially Romania, Anatolia and the Caucasus. The brown bear is recognized as a national and state animal in several European countries." ,
        //    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/Kamchatka_Brown_Bear_near_Dvuhyurtochnoe_on_2015-07-23.jpg/320px-Kamchatka_Brown_Bear_near_Dvuhyurtochnoe_on_2015-07-23.jpg"
        //    } );
        //Animals.Add ( new Animal
        //    {
        //    Name = "Grizzly-Polar Bear Hybrid" ,
        //    Location = "Canadian Artic" ,
        //    Details = "A grizzly–polar bear hybrid is a rare ursid hybrid that has occurred both in captivity and in the wild. In 2006, the occurrence of this hybrid in nature was confirmed by testing the DNA of a unique-looking bear that had been shot near Sachs Harbour, Northwest Territories on Banks Island in the Canadian Arctic. The number of confirmed hybrids has since risen to eight, all of them descending from the same female polar bear." ,
        //    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7e/Grolar.JPG/276px-Grolar.JPG"
        //    } );
        //Animals.Add ( new Animal
        //    {
        //    Name = "Sloth Bear" ,
        //    Location = "Indian Subcontinent" ,
        //    Details = "The sloth bear is an insectivorous bear species native to the Indian subcontinent. It is listed as Vulnerable on the IUCN Red List, mainly because of habitat loss and degradation. It has also been called labiated bear because of its long lower lip and palate used for sucking insects. Compared to brown and black bears, the sloth bear is lankier, has a long, shaggy fur and a mane around the face, and long, sickle-shaped claws. It evolved from the ancestral brown bear during the Pleistocene and through convergent evolution shares features found in insect-eating mammals." ,
        //    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/Sloth_Bear_Washington_DC.JPG/320px-Sloth_Bear_Washington_DC.JPG"
        //    } );
        //Animals.Add ( new Animal
        //    {
        //    Name = "Sun Bear" ,
        //    Location = "Southeast Asia" ,
        //    Details = "The sun bear is a bear species occurring in tropical forest habitats of Southeast Asia. It is listed as Vulnerable on the IUCN Red List. The global population is thought to have declined by more than 30% over the past three bear generations. Suitable habitat has been dramatically reduced due to the large-scale deforestation that has occurred throughout Southeast Asia over the past three decades. The sun bear is also known as the honey bear, which refers to its voracious appetite for honeycombs and honey." ,
        //    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Sitting_sun_bear.jpg/319px-Sitting_sun_bear.jpg"
        //    } );
        //Animals.Add ( new Animal
        //    {
        //    Name = "Polar Bear" ,
        //    Location = "Artic Circle" ,
        //    Details = "The polar bear is a hypercarnivorous bear whose native range lies largely within the Arctic Circle, encompassing the Arctic Ocean, its surrounding seas and surrounding land masses. It is a large bear, approximately the same size as the omnivorous Kodiak bear. A boar (adult male) weighs around 350–700 kg (772–1,543 lb), while a sow (adult female) is about half that size. Although it is the sister species of the brown bear, it has evolved to occupy a narrower ecological niche, with many body characteristics adapted for cold temperatures, for moving across snow, ice and open water, and for hunting seals, which make up most of its diet. Although most polar bears are born on land, they spend most of their time on the sea ice. Their scientific name means maritime bear and derives from this fact. Polar bears hunt their preferred food of seals from the edge of sea ice, often living off fat reserves when no sea ice is present. Because of their dependence on the sea ice, polar bears are classified as marine mammals." ,
        //    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/66/Polar_Bear_-_Alaska_%28cropped%29.jpg"
        //    } );
        //Animals.Add ( new Animal
        //    {
        //    Name = "Spectacled Bear" ,
        //    Location = "South America" ,
        //    Details = "The spectacled bear, also known as the Andean bear or Andean short-faced bear and locally as jukumari (Aymara), ukumari (Quechua) or ukuku, is the last remaining short-faced bear. Its closest relatives are the extinct Florida spectacled bear, and the giant short-faced bears of the Middle to Late Pleistocene age. Spectacled bears are the only surviving species of bear native to South America, and the only surviving member of the subfamily Tremarctinae. The species is classified as Vulnerable by the IUCN because of habitat loss." ,
        //    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Spectacled_Bear_-_Houston_Zoo.jpg/264px-Spectacled_Bear_-_Houston_Zoo.jpg"
        //    } );
        //Animals.Add ( new Animal
        //    {
        //    Name = "Short-faced Bear" ,
        //    Location = "Extinct" ,
        //    Details = "The short-faced bears is an extinct bear genus that inhabited North America during the Pleistocene epoch from about 1.8 Mya until 11,000 years ago. It was the most common early North American bear and was most abundant in California. There are two recognized species: Arctodus pristinus and Arctodus simus, with the latter considered to be one of the largest known terrestrial mammalian carnivores that has ever existed. It has been hypothesized that their extinction coincides with the Younger Dryas period of global cooling commencing around 10,900 BC." ,
        //    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/ArctodusSimusSkeleton.jpg/320px-ArctodusSimusSkeleton.jpg"
        //    } );
        //Animals.Add ( new Animal
        //    {
        //    Name = "California Grizzly Bear" ,
        //    Location = "Extinct" ,
        //    Details = "The California grizzly bear is an extinct subspecies of the grizzly bear, the very large North American brown bear. Grizzly could have meant grizzled (that is, with golden and grey tips of the hair) or fear-inspiring. Nonetheless, after careful study, naturalist George Ord formally classified it in 1815 – not for its hair, but for its character – as Ursus horribilis (terrifying bear). Genetically, North American grizzlies are closely related; in size and coloring, the California grizzly bear was much like the grizzly bear of the southern coast of Alaska. In California, it was particularly admired for its beauty, size and strength. The grizzly became a symbol of the Bear Flag Republic, a moniker that was attached to the short-lived attempt by a group of American settlers to break away from Mexico in 1846. Later, this rebel flag became the basis for the state flag of California, and then California was known as the Bear State." ,
        //    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/de/Monarch_the_bear.jpg"
        //    } );
    }













    #endregion















    public ICommand ClickCommand
    {
        get; set;
    }

    #region Initialize
    //Page_Landing_Dashboard _iParent;

    //Picker_Contact_Dashboard _iParent;

    public async Task Initialize(Picker_Contact_Dashboard iParent, SRoofingUserOwnerModelManager iOwnerModel)
    {
        try
        {
            //_iParent = iParent;

            //_iOwnerModel = iOwnerModel;



            if (!_blnIsInitialized)
            {


                Device.BeginInvokeOnMainThread(() =>
    {
        ll_ProgressBar.IsVisible = true;

    });




                //////////      await Initialize_Alphabet_List ( );


                //////////      arr_AlphabetList = await SRoofingSync_UserContactPickerManager
                //////////                        .Sync_User_Picker_Category_Get_Alphabet_List_Active_Index_ByOwnerUserTokenID (
                //////////                       App.Current , _iOwnerModel );

                //////////      if ( arr_AlphabetList == null )
                //////////      {

                //////////          arr_AlphabetList = await SRoofing_UserGroupManager
                //////////                          .SRoofing_XFMobile_Get_Alphabet_Index_List (
                //////////                          App.Current ,
                //////////                        _iOwnerModel );

                //////////      }


                //////////      for ( int i = 0 ; i < arr_AlphabetList.Count ; i++ )
                //////////      {


                //////////          iAlphabetChar = new Row_Alphabet_View ( );
                //////////          iAlphabetChar.iOwnerModel = _iOwnerModel;
                //////////          iAlphabetChar.iKeyValueModel = new SRoofingKeyValueModelManager ( )
                //////////          {
                //////////              ItemIndex = i ,
                //////////              ItemText = arr_AlphabetList[ i ].ItemText ,
                //////////              ItemValue = arr_AlphabetList[ i ].ItemValue ,
                //////////              ItemCode = arr_AlphabetList[ i ].ItemCode
                //////////          };

                //////////          if ( arr_AlphabetList[ i ].ItemCode == "active" )
                //////////          {
                //////////              iAlphabetChar.Command_Call_ByUser = new Command ( async ( obj ) =>
                //////////              {
                //////////                  try
                //////////                  {

                //////////                      MainThread.BeginInvokeOnMainThread ( ( ) =>
                //////////        {
                //////////            // Code to run on the main thread

                //////////            if ( _iCurrentSelected_Index != -1 )
                //////////            {
                //////////                ( ( Row_Alphabet_View ) sl_AlphabetList.Children[ _iCurrentSelected_Index ] ).UnSelectMe ( );
                //////////            }


                //////////            ( ( Row_Alphabet_View ) sl_AlphabetList.Children[ ( ( SRoofingKeyValueModelManager ) obj ).ItemIndex ] ).SelectMe ( );


                //////////            _iCurrentSelected_Index = ( ( SRoofingKeyValueModelManager ) obj ).ItemIndex;



                //////////        } );

                //////////                      /* ON-CLICK */
                //////////                      await Initialize_List_Contact_ByAlphabet ( ( ( SRoofingKeyValueModelManager ) obj ) , false );


                //////////                  }
                //////////                  catch ( Exception ex )
                //////////                  {
                //////////                      SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                //////////                      return;
                //////////                  }

                //////////              } );


                //////////          }

                //////////          arr_AlpabetItems.Add ( iAlphabetChar );

                //////////      }


                //////////      MainThread.BeginInvokeOnMainThread ( ( ) =>
                //////////{
                //////////    // Code to run on the main thread

                //////////    for ( int i = 0 ; i < arr_AlpabetItems.Count ; i++ )
                //////////    {
                //////////        sl_AlphabetList.Children.Add ( arr_AlpabetItems[ i ] );
                //////////    }

                //////////} );




                _ = Task.Run(async () =>
            {
                await Initialize_List_Contact_ByAlphabet(null, false);
            }).ConfigureAwait(false);//.Wait ( );

                //////  Task.Run ( async ( ) =>
                //////   {

                //////       await Initialize_Alphabet_List_History_Active_ByOwnerUserTokenID ( );
                //////   } ).ConfigureAwait ( false );//.Wait ( );

                MainThread.BeginInvokeOnMainThread(async () =>
                {

                    await iSnackBar_ConfirmOption.OpenLoader(
                        typeof(Picker_Contact_List),

                         ((Picker_Contact_Dashboard)Parent.BindingContext)._iLanguageModel,
                         ((Picker_Contact_Dashboard)Parent.BindingContext)._iOwnerModel,
                    ((Picker_Contact_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID);

                });

                _blnIsInitialized = true;
            }

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }







    string _strCurrentSelected_Index = "0";
    int getIndex_SelectedFromList(string str)
    {

        try
        {

            int index = -1;

            for (int i = 0; i < arr_AlphabetList.Count; i++)
            {
                if (arr_AlphabetList[i].ItemText == str)
                {
                    index = i;
                    break;
                }
            }

            _iCurrentSelected_Index = index;
            _strCurrentSelected_Index = str;
            return index;

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return -1;
        }


        return 0;


    }










    #endregion





    #region Commands_List

    public System.Windows.Input.ICommand Command_Call_ByUser
    {
        get; private set;
    }
    void Initialize_Command()
    {

        try
        {

            Command_Call_ByUser = new Command(async (object iRemoteModel) =>
            {


                try
                {

                    await Task.Delay(500);

                    //if ( iPage.Navigation.NavigationStack.Count == 0 ||

                    //iPage.Navigation.NavigationStack.Last ( ).GetType ( ) != typeof ( Page_Chat_View ) )
                    //    {
                    //    await iPage.Navigation.PushAsync ( new Page_Chat_View ( iRemoteModel ) , true );

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


    #region Navigation


    async void imgBtn_BackPage_Clicked(object sender, EventArgs e)
    {

        try
        {

            //  Select_List_Index_ByAlphabet("G");
            //   RefreshCommand.Execute(null);
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    #endregion


    private void refresh_ContactList_Refreshing(object sender, EventArgs e)
    {
        try
        {

            arr_UserMarshalList = null;
            cv_UserContactList.ItemsSource = null;

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }





    public async Task Preload(Picker_Contact_Dashboard iParent)
    {
        try
        {

            //if (iParent != null)
            //{
            //    _iParent = iParent;
            //    _iOwnerModel = ((Picker_Contact_Dashboard)Parent.BindingContext)._iOwnerModel;
            //}


            //MainThread.BeginInvokeOnMainThread(() =>
            //{
                //btn_New_Chatter.Text = ((Picker_Contact_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Group_AddUser_Message;
               // btn_Close_MenuRight.Text = ((Picker_Contact_Dashboard)Parent.BindingContext)._iLanguageModel.lblText_Command_CLOSE_Message;
            //    ll_ProgressBar.IsVisible = true;

            //});

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }





    #region  Initialize


    public SRoofingUserOwnerModelManager _iOwnerModel { get; set; }

    List<Row_Alphabet_View> arr_AlpabetItems = new List<Row_Alphabet_View>();
    Row_Alphabet_View iAlphabetChar;
    public int _iCurrentSelected_Index = -1;




    #region History_List


    public async Task Initialize_Alphabet_List_History_Active_ByOwnerUserTokenID()
    {
        //////   try
        //////   {

        //////       SRoofingKeyValueModelManager iHistoryCharacterModel = new SRoofingKeyValueModelManager ( );
        //////       iHistoryCharacterModel = await SRoofingSync_UserContactPickerManager
        //////           .Sync_User_Picker_Contact_Get_History_Selected_CharacterModel (
        //////  App.Current ,
        ////// _iOwnerModel );


        //////       if ( iHistoryCharacterModel != null )
        //////       {
        //////           // List from History
        //////           /*
        //////            1- Select Char Index List
        //////            2- Load Contacts List By Selected History Char
        //////            */

        //////           _iCurrent_AlphabetModel = iHistoryCharacterModel;


        //////           _iCurrentSelected_Index = _iCurrent_AlphabetModel.ItemIndex;

        //////           //( ( Row_Alphabet_View ) sl_AlphabetList.Children[ iHistoryCharacterModel.ItemIndex ] ).SelectMe ( );
        //////           arr_UserMarshalList_Temp = new ObservableCollection<SRoofingUserGroupModelManager> ( );

        //////           arr_UserMarshalList_Temp = await SRoofingSync_UserContactPickerManager
        //////          .Sync_User_Picker_Contact_Get_History_Selected_Contact_List_ByCharacterID (
        //////  App.Current ,
        //////_iOwnerModel ,
        //////     iHistoryCharacterModel.ItemText );



        //////           MainThread.BeginInvokeOnMainThread ( ( ) =>
        //////     {
        //////         // Code to run on the main thread
        //////         ( ( Row_Alphabet_View ) sl_AlphabetList.Children[ iHistoryCharacterModel.ItemIndex ] ).SelectMe ( );



        //////     } );

        //////           MessagingCenter.Send<App , string> ( App.Current as App ,
        //////        SRoofingEnum_MessageCenter.MessageCenter_PICKER_CONTACT_LIST ,
        //////        SRoofingEnum_MessageCenter.MessageCenter_PICKER_CONTACT_LIST );


        //////           ///
        //////           /// 
        //////           /// 
        //////           //////      MainThread.BeginInvokeOnMainThread ( ( ) =>
        //////           //////{
        //////           //////    ( ( Row_Alphabet_View ) sl_AlphabetList.Children[ iHistoryCharacterModel.ItemIndex ] ).SelectMe ( );
        //////           //////    // Code to run on the main thread
        //////           //////    if ( cv_UserContactList.ItemsSource == null )
        //////           //////    {
        //////           //////        cv_UserContactList.ItemsSource = arr_UserMarshalList;

        //////           //////    }

        //////           //////} );


        //////       }


        //////   }
        //////   catch ( Exception ex )
        //////   {
        //////       SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //////       return;
        //////   }


    }



    #endregion





    public async Task Initialize_Alphabet_List()
    {

        try
        {

            arr_AlphabetList_Initialize = new ObservableCollection<SRoofingKeyValueModelManager>();

            arr_AlphabetList_Initialize = await SRoofingSync_UserContactManager
                .Sync_User_Category_Get_Alphabet_Initialize_List_ByOwnerUserTokenID(
                    App.Current);

            MainThread.BeginInvokeOnMainThread(() =>
            {
                //////if ( cv_AlphabetList_Initialize.ItemsSource == null )
                //////{
                //////    // Code to run on the main thread
                //////    cv_AlphabetList_Initialize.ItemsSource = arr_AlphabetList_Initialize;
                //////}
            });
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }




    #endregion


    #region Initialize_Contact_List


    public async Task Initialize_List_Contact_ByAlphabet(
        SRoofingKeyValueModelManager iKeyValuexxx,
        bool IsRefreshNew)
    {

        try
        {
            if (!IsRefreshNew)
            {

                Device.BeginInvokeOnMainThread(() =>
               {
                   ll_ProgressBar.IsVisible = true;


               });
               
                arr_UserMarshalList_Temp = new ObservableCollection<SRoofingUserGroupModelManager>();

                arr_UserMarshalList_Temp = await SRoofingSync_UserContactPickerManager
                                  .Sync_User_Picker_Contact_Get_List_Contact_ByCharcterID(
                   App.Current,
                   _iOwnerModel, ((Picker_Contact_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID);

                if (arr_UserMarshalList_Temp == null)
                {

                    if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                    {

                        arr_UserMarshalList_Temp = new ObservableCollection<SRoofingUserGroupModelManager>();

                        arr_UserMarshalList_Temp = await SRoofing_UserGroupManager
                            .SRoofing_XFMobile_UserGroup_Get_List_Private_Filter_Chatter_ByAlphabetIndexWS(
                            App.Current,
                            _iOwnerModel,
                            ((Picker_Contact_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID,"0","0");
                    }

                }

            }

            else
            {
                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {
                    arr_UserMarshalList_Temp = new ObservableCollection<SRoofingUserGroupModelManager>();

                    arr_UserMarshalList_Temp = await SRoofing_UserGroupManager
                            .SRoofing_XFMobile_UserGroup_Get_List_Private_Filter_Chatter_ByAlphabetIndexWS(
                        App.Current,
                        _iOwnerModel,
                        ((Picker_Contact_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID,
                        "0","0");
                }
                else
                {
                    arr_UserMarshalList_Temp = new ObservableCollection<SRoofingUserGroupModelManager>();

                    arr_UserMarshalList_Temp = await SRoofingSync_UserContactPickerManager
                                       .Sync_User_Picker_Contact_Get_List_Contact_ByCharcterID(
                        App.Current,
                        _iOwnerModel,
                        ((Picker_Contact_Dashboard)Parent.BindingContext)._iChatScreenModel.GroupTokenID);
                }

            }



            ////////_iCurrent_AlphabetModel = iKeyValue;

            ////////_iCurrentSelected_Index = iKeyValue.ItemIndex;

            ////////await SRoofingSync_UserContactPickerManager.Sync_User_Picker_Contact_Set_History_Selected_CharacterModel (
            ////////   App.Current ,
            ////////     _iOwnerModel ,
            ////////     iKeyValue );

            ////////await SRoofingSync_UserContactPickerManager.Sync_User_Picker_Contact_Set_History_Selected_Contact_List_ByCharacterID (
            ////////              App.Current ,
            ////////    _iOwnerModel ,
            ////////    iKeyValue.ItemText ,
            ////////                 arr_UserMarshalList_Temp );

            //Device.BeginInvokeOnMainThread ( ( ) =>
            //    {
            //        if ( ll_ProgressBar.IsVisible == true )
            //        {
            //            ll_ProgressBar.IsVisible = false;

            //        }
            //    } );

            await ShowList();

            //   MessagingCenter.Send<App , string> ( App.Current as App ,
            //SRoofingEnum_MessageCenter.MessageCenter_PICKER_CONTACT_LIST ,
            //SRoofingEnum_MessageCenter.MessageCenter_PICKER_CONTACT_LIST );




        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }






    #endregion







    #region RefreshView

    SRoofingKeyValueModelManager _iCurrent_AlphabetModel;

    public ICommand RefreshCommand { get; }


    void RefreshData()
    {
        try
        {
            // refresh your data here

            refresh_ContactList.IsRefreshing = true;

            Task.Run(async () =>
            {
                Initialize_List_Contact_ByAlphabet(null, false);
            }).ConfigureAwait(false);//.Wait ( );


            ////////if ( _iCurrent_AlphabetModel != null )
            ////////{

            ////////    await Initialize_List_Contact_ByAlphabet (
            ////////        _iCurrent_AlphabetModel ,
            ////////        true );


            ////////}
            //////////////////refresh_ContactList.IsRefreshing = false;

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }
    }
    #endregion





    #region Chatter_Remove

    public SRoofingUserGroupModelManager _pending_iRemoteModel = null;
    public async Task pendingRemove_Chatter(SRoofingUserGroupModelManager iGroupModel)
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


            //arr_UserChattersList.RemoveAt ( 0 );



        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }






    #endregion






    #region SnackBar


    public void Snack_ShowMessage(string strMessage)
    {

        try
        {

            Device.BeginInvokeOnMainThread(() =>
            {
                // Code to run on the main thread
                // iSnackBar.BackgroundColor = Colors.Red;

                SRoofing_ToastMessageManager.ToastMessage_Show_Message(iSnackBar, strMessage);



            });
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

                // Code to run on the main thread
                if (refresh_ContactList.IsRefreshing)
                {
                    refresh_ContactList.IsRefreshing = false;

                }

                ll_ProgressBar.IsVisible = false;





                if (cv_UserContactList.ItemsSource == null)
                {
                    cv_UserContactList.ItemsSource = arr_UserMarshalList;
                }

                if (arr_UserMarshalList_Temp != null)
                {
                    arr_UserMarshalList.Clear();

                    for (int i = 0; i < arr_UserMarshalList_Temp.Count; i++)
                    {
                        arr_UserMarshalList.Add(arr_UserMarshalList_Temp[i]);

                        await Task.Delay(SRoofing_EnumGlobalPreference.Global_ROW_LIST_DELAY);
                    }

                }

                //  ((Picker_Contact_Dashboard)Parent.BindingContext).llProgress_ToggleVisible_ChatList ( true , false );

                //   _bln_IsInitialized_History_ChatList = true;

                //   App._blnSyncHistory_ScreenChatShow_CHAT_Landing_List = false;




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