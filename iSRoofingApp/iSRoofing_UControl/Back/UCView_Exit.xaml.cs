using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_UControl.Back
{
    //////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UCView_Exit : ContentView
    {
        public UCView_Exit()
        {
            InitializeComponent();
        }








        #region Properties




        public static readonly BindableProperty TitleTextProperty =
    BindableProperty.Create(nameof(TitleText), typeof(string), typeof(UCView_Exit), null);

        public string TitleText
        {
            get
            {
                return (string)GetValue(TitleTextProperty);
            }
            set
            {
                //lbl_SuppplierName.Text = value;
                SetValue(TitleTextProperty, value);
                OnPropertyChanged(nameof(TitleText));

            }
        }









    //    public static readonly BindableProperty ValueProperty =
    //BindableProperty.Create<KeyValueView, string>(w => w.Value, default(string));

    //    public string Value
    //    {
    //        get { return (string)GetValue(ValueProperty); }
    //        set { SetValue(ValueProperty, value); }
    //    }

    //    public static readonly BindableProperty KeyProperty =
    //        BindableProperty.Create<KeyValueView, string>(w => w.Key, default(string));

    //    public string Key
    //    {
    //        get { return (string)GetValue(KeyProperty); }
    //        set { SetValue(KeyProperty, value); }
    //    }
      
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TitleTextProperty.PropertyName)
            {
                //ValueLabel.Text = Value;
            }
            //if (propertyName == KeyProperty.PropertyName)
            //{
            //    //KeyLabel.Text = Key;
            //}
        }


        #endregion







        private    void img_Back_Clicked(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();

                //Application.Current.MainPage.Navigation.PopModalAsync();

                //await Application.Current.MainPage.DisplayAlert("Alert", Navigation.NavigationStack.Count.ToString(), "OK");

                //if (Navigation.NavigationStack.Last().GetType() == typeof(S1RoofingMU.iSRoofingApp.iSRoofing_Page.Landing.Page_Map_Dashboard))
                //{
                //    // await Navigation.PushModalAsync(new Page_Delivery_Profile_Dashboard(null), true);
                //    System.Diagnostics.Process.GetCurrentProcess().Kill();
                //}
                //else
                //{
                //    MainThread.BeginInvokeOnMainThread(() =>
                //               {

                //                   //  Navigation.PopToRootAsync();
                //                   //System.Diagnostics.Process.GetCurrentProcess().Kill();

                //                   Application.Current.MainPage.Navigation.PopModalAsync();
                //               });
                //}


                //                if (Navigation.NavigationStack.Count == 0 ||
                //Navigation.NavigationStack.Last().GetType() != typeof(Page_Delivery_Profile_Dashboard))
                //                {
                //                    await Navigation.PushModalAsync(new Page_Delivery_Profile_Dashboard(null), true);

                //                }








                //   await Navigation.PopToRootAsync ();
                //MainThread.BeginInvokeOnMainThread(() =>
                //           {

                //               //  Navigation.PopToRootAsync();
                //               //System.Diagnostics.Process.GetCurrentProcess().Kill();

                //               Application.Current.MainPage.Navigation.PopModalAsync();
                //           });

            }
            catch (Exception ex)
            {
                //SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                return;
            }

        }
    }
}