//// 

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
////using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Login;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Account
{
    [XamlCompilation ( XamlCompilationOptions.Compile )]
    public partial class Page_Account_FAQ : ContentView
    {



        #region Params

        //public Page_Login_Dashboard  (( Page_Account_Dashboard ) Parent.BindingContext) {get;set;}


        bool _bln_IsRegister_RunningNow = false;

        bool _blnIsInitialized_Step1 = false;

        public string _register_MobileNumberE164_Clean = "0", UserLoginMobileNumberE164 = "0";
        bool _blnMobileNumber = false;

        public string _register_CountryName = "0", _register_CountryCode = "0", _register_CountryMobileCode = "0",
            _register_FirstName = "0", _register_LastName = "0",
            _register_Password = "0", _register_MobileNumberE164 = "0";

        #endregion














        public Page_Account_FAQ ( )
        {
            InitializeComponent ( );

            try
            {




                //Task.Run ( async ( ) =>
                //{
                //    await Initialize_AppTranslation ( );
                //} ).Wait ( );












                MessagingCenter.Subscribe<App , SRoofingCountryModel> ( App.Current , "OpenPage" , ( snd , arg ) =>
                {

                    //////try
                    //////{
                    //////    //get the value by `arg`
                    //////    frm_CountryName.BorderColor = Colors.White;

                    //////    lbl_CountryList.Text = ( arg as SRoofingCountryModel ).CountryName.ToString ( );
                    //////    txt_MobileNumber.Text = "+" + ( arg as SRoofingCountryModel ).CountryMobileCode;// (arg as Employee).m
                    //////    txt_MobileNumber.IsEnabled = true;


                    //////    _register_CountryName = ( arg as SRoofingCountryModel ).CountryName;
                    //////    _register_CountryCode = ( arg as SRoofingCountryModel ).CountryCode;
                    //////    _register_CountryMobileCode = ( arg as SRoofingCountryModel ).CountryMobileCode;

                    //////    //txt_MobileNumber.SelectionLength = txt_MobileNumber.Text.Length;
                    //////    //txt_MobileNumber.Focus();

                    //////    //////   lbl_SignUp.IsEnabled = true;
                    //////    _bln_IsCountryName = true;
                    //////}
                    //////catch ( Exception ex )
                    //////{
                    //////    SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                    //////}

                } );



                ////this.txt_MobileNumber.Completed += async (object sender, EventArgs e) =>
                ////{

                ////    //await iApp_Login ( );
                ////   //////// await onPostExecute_LoginAsync();
                ////};






            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }





        SRoofingUserOwnerModelManager _iOwnerModel;
        SRoofingUserSettingModelManager _iSettingModel;
        #region Initialize

        public async Task Initialize (
            SRoofingUserOwnerModelManager iOwnerModel ,
            SRoofingUserSettingModelManager iSettingModel )
        {

            try
            {

                _iOwnerModel = iOwnerModel;
                _iSettingModel = iSettingModel;


                //lbl_BirthDate.Text = _iOwnerModel.BirthDay + "-" + _iOwnerModel.BirthMonth + "-" + _iOwnerModel.BirthYearsOld;

                //txt_FirstName.Text = _iOwnerModel.FirstName;
                //txt_LastName.Text = _iOwnerModel.LastName;


                //if ( _iOwnerModel.Gender == SRoofingEnum_Gender.Gender_MALE )
                //{

                //    img_Male.WidthRequest = 60;
                //    img_Male.Source = "img_gender_male_select.png";

                //    img_Female.WidthRequest = 50;
                //    img_Female.Source = "img_gender_female_normal_small.png";

                //}

                //else if ( _iOwnerModel.Gender == SRoofingEnum_Gender.Gender_FEMALE )
                //{
                //    img_Female.WidthRequest = 60;
                //    img_Female.Source = "img_gender_female_select.png";

                //    img_Male.WidthRequest = 50;
                //    img_Male.Source = "img_gender_male_normal_small.png";

                //}

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }

        }

        #endregion








        #region Initialize_LanguageModel


        public async Task Initialize_AppTranslation ( SRoofingLanguageTranslateModel _iLanguageModel )
        {
            try
            {

                if ( _iLanguageModel == null ) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All ( App.Current );


                if ( _iLanguageModel.LanguageCode == "ar" )
                {
                    lbl_Title.HorizontalTextAlignment = TextAlignment.Start;

                }
                else
                {
                    lbl_Title.HorizontalTextAlignment = TextAlignment.End;

                }

                lbl_Title.Text = "S1Roofing " + _iLanguageModel.lblText_FAQ;



                //lbl_CountryList.Text = _iLanguageModel.lblText_YourCountry;
                //txt_MobileNumber.Placeholder = _iLanguageModel.lblText_MobileNumber;
                //txt_FirstName.Placeholder = _iLanguageModel.lblText_FirstName;
                //txt_LastName.Placeholder = _iLanguageModel.lblText_LastName;

                //btn_Register_Step1.Text = _iLanguageModel.lblText_Command_Continue;
                //////btn_Login.Text = _iLanguageModel.lblText_Splash_SignIn;


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return;
            }
        }


        #endregion











    }
}