using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Login;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using S1RoofingMU.iSRoofingApp.iSRoofing_Page.Register;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Splash;

public partial class Page_Splash : ContentPage
{
    public SRoofingLanguageTranslateModel _iLanguageModel { get; set; } = new SRoofingLanguageTranslateModel();

    public Page_Splash()
    {
        InitializeComponent();
    }


    public Page_Splash(SRoofingLanguageTranslateModel iLanguageModel)
    {
        InitializeComponent();


        try
        {

            _iLanguageModel = iLanguageModel;

            Task.Run(async () =>
            {
                await Initialize();

            }).Wait();





            /////////////////////////










            //////MainThread.BeginInvokeOnMainThread(async () =>
            //////  {

            //////      //// IconTintColorEffect.SetTintColor ( img_Register , Colors.White );
            //////      //IconTintColorEffect.SetTintColor ( img_Login , Colors.White );
            //////  });


            //    var current = Connectivity.NetworkAccess;
            //Connectivity_Get_Status ( current );


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }



    }



    async Task Initialize()
    {
        try
        {

            await Initialize_AppTranslation();


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }



    #region Navigation

    async private void btn_PageDashboard_Clicked(object sender, EventArgs e)
    {

        try
        {

            ////////await SRoofing_Page_OpenerManager.Page_Opener (
            ////////                       Navigation ,
            ////////                   new Page_Dashboard ( ) ,
            ////////                   false ,
            ////////                   true );


            //await SRoofing_Page_OpenerManager.Page_Opener(
            //                                 Navigation ,
            //                             new Page_Landing_Dashboard ( ) ,
            //                             false ,
            //                             true);


            //await iSRoofing_Manager.SRoofing_Page_OpenerManager.Page_Opener (
            //                       Navigation ,
            //                   new Register.Marshal.Page_Marshal_Login_Dashboard ("login") ,
            //                   false ,
            //                   true);
        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }




    async void btn_Login_Clicked(object sender, EventArgs e)
    {

        try
        {


            await SRoofing_Page_OpenerManager.Page_Opener(
                    Navigation,
                new Page_Login_Dashboard(_iLanguageModel),
                false,
                true);

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }

    async void btn_Register_Clicked(object sender, EventArgs e)
    {
        try
        {


            await SRoofing_Page_OpenerManager.Page_Opener(
                    Navigation,
                new Page_Register_Dashboard(_iLanguageModel),
                false,
                true);

        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }

    }

    #endregion



    #region Initialize_LanguageModel


    async Task Initialize_AppTranslation()
    {

        try
        {
            MainThread.BeginInvokeOnMainThread(async () =>
{


    if (_iLanguageModel == null) _iLanguageModel = await SRoofingSync_Language_Manager.Sync_Language_Get_LanguageList_All(App.Current);

    if (_iLanguageModel.LanguageCode=="ar")
    {
        lbl_WelcomeTo_RTL.Text = _iLanguageModel.lblText_Splash_WelcomeTo;
        lbl_WelcomeTo_RTL.IsVisible = true;
        lbl_WelcomeTo_LTR.IsVisible = false;
    }
    else
    {
        lbl_WelcomeTo_LTR.Text = _iLanguageModel.lblText_Splash_WelcomeTo;
        lbl_WelcomeTo_RTL.IsVisible =false;
        lbl_WelcomeTo_LTR.IsVisible = true;

    }


    btn_Register.Text = _iLanguageModel.lblText_Splash_CreateAccount;
    btn_Login.Text = _iLanguageModel.lblText_Splash_SignIn;

});


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;
        }


    }





    #endregion

    //private void page_SplashDashboard_Loaded(object sender, EventArgs e)
    //{
    //    try
    //    {

    //        Task.Run(async () =>
    //        {
    //            await Initialize();

    //        }).Wait();


    //    }
    //    catch (Exception ex)
    //    {
    //        SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
    //        return;

    //    }
    //}



}