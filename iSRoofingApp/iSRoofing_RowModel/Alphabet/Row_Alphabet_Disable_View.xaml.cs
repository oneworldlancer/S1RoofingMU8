using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
//using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Call;
////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.History.Chat;

 
 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.Alphabet
    {
    [XamlCompilation ( XamlCompilationOptions.Compile )]
    public partial class Row_Alphabet_Disable_View : ContentView
        {
        public Row_Alphabet_Disable_View ( )
            {
            InitializeComponent ( );
            }




        #region Bindings

        //iOwnerModel
        public SRoofingUserOwnerModelManager iOwnerModel
        {
            get
            {
                return (SRoofingUserOwnerModelManager)GetValue(iOwnerModelProperty);
            }
            set
            {
                SetValue(iOwnerModelProperty, value);
            }
        }

        public static BindableProperty iOwnerModelProperty =
            BindableProperty.Create(
                nameof(iOwnerModel),
                typeof(SRoofingUserOwnerModelManager),
                typeof(Row_Chat_Private_IsNewMessage_FALSE_View),
                new SRoofingUserOwnerModelManager(),
                BindingMode.TwoWay);






        public SRoofingKeyValueModelManager iKeyValueModel
            {
            get
                {
                return ( SRoofingKeyValueModelManager ) GetValue ( iKeyValueModelProperty );
                }
            set
                {
                SetValue ( iKeyValueModelProperty , value );
                }
            }

        public static BindableProperty iKeyValueModelProperty =
            BindableProperty.Create ( nameof ( iKeyValueModel ) , typeof ( SRoofingKeyValueModelManager ) , typeof ( Row_Alphabet_Disable_View ) , new SRoofingKeyValueModelManager ( ) ,
                BindingMode.TwoWay );

        protected override void OnPropertyChanged ( string propertyName = null )
            {
            base.OnPropertyChanged ( propertyName );

            if ( propertyName == iKeyValueModelProperty.PropertyName )
                {
                if ( iKeyValueModel != null )
                    {
                    // Update ContentView properties and elements.
                    Initialize_Command ( );
                                          }
                }
            }

        #endregion





        #region Commands_List

        //public ICommand Command_Call_ByUser { get; private set; }


        public static readonly BindableProperty Command_Call_ByUserProperty = BindableProperty.Create ( nameof ( Command_Call_ByUser ) , typeof ( ICommand ) , typeof ( Row_Alphabet_Disable_View ) , null );
        public ICommand Command_Call_ByUser
            {
            get => ( ICommand ) GetValue ( Command_Call_ByUserProperty );
            set => SetValue ( Command_Call_ByUserProperty , value );
            }

        //public static readonly BindableProperty CloseButtonClickProperty = BindableProperty.Create ( nameof ( CloseButtonClick ) , typeof ( ICommand ) , typeof ( HeaderView ) , null );
        //public ICommand CloseButtonClick
        //    {
        //    get => ( ICommand ) GetValue ( CloseButtonClickProperty );
        //    set => SetValue ( CloseButtonClickProperty , value );
        //    }

        void Initialize_Command ( )
            {

            try
                {

                Command_Call_ByUser = new Command ( async ( object iRemoteModel ) =>
                {


                    try
                        {

                        //await Task.Delay ( 1000 );


                        await SRoofing_ScreenCallShowManager
                       .Call_Initialize_Call_Show_Offer (
                            App.Current ,
                            null ,
                            null ,
                            null );


                        ////////////////////await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener (
                        ////////////////////        Navigation ,
                        ////////////////////    new Page_Call_Dashboard(),
                        ////////////////////    false ,
                        ////////////////////    true );




                        //if ( iPage.Navigation.NavigationStack.Count == 0 ||

                        //iPage.Navigation.NavigationStack.Last ( ).GetType ( ) != typeof ( Page_Chat_View ) )
                        //    {
                        //    await iPage.Navigation.PushModalAsync ( new Page_Chat_View ( iRemoteModel ) , true );

                        //    }
                        }
                    catch ( Exception ex )
                        {
                        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                        return;
                        }

                } );


                }
            catch ( Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
                }

            }



        #endregion




        private void lbl_AlphabetChar_Tapped ( object sender , EventArgs e )
            {
            try
                {
                return;
                // lbl_AlphabetChar.BackgroundColor = Colors.Black;
                }
            catch ( Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
                }
            }

        }
    }