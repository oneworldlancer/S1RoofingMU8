//using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
//using S1RoofingMU.iSRoofingApp.iSRoofing_ViewModel;
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
    public partial class UCView_Back_ByCommand : ContentView
    {
        public UCView_Back_ByCommand()
        {
            InitializeComponent();
        }








        #region Properties




        public static readonly BindableProperty PageViewModelProperty =
    BindableProperty.Create(nameof(PageViewModel), typeof(string), typeof(UCView_Back_ByCommand), null);

        public string PageViewModel
        {
            get
            {
                return (string)GetValue(PageViewModelProperty);
            }
            set
            {
                //lbl_SuppplierName.Text = value;
                SetValue(PageViewModelProperty, value);
                OnPropertyChanged(nameof(PageViewModel));

            }
        }





        public static readonly BindableProperty PageCurrentProperty =
    BindableProperty.Create(nameof(PageCurrent), typeof(string), typeof(UCView_Back_ByCommand), null);

        public string PageCurrent
        {
            get
            {
                return (string)GetValue(PageCurrentProperty);
            }
            set
            {
                //lbl_SuppplierName.Text = value;
                SetValue(PageCurrentProperty, value);
                OnPropertyChanged(nameof(PageCurrent));

            }
        }





        public static readonly BindableProperty PageNextProperty =
    BindableProperty.Create(nameof(PageNext), typeof(string), typeof(UCView_Back_ByCommand), null);

        public string PageNext
        {
            get
            {
                return (string)GetValue(PageNextProperty);
            }
            set
            {
                //lbl_SuppplierName.Text = value;
                SetValue(PageNextProperty, value);
                OnPropertyChanged(nameof(PageNext));

            }
        }





        public static readonly BindableProperty PageBackProperty =
    BindableProperty.Create(nameof(PageBack), typeof(string), typeof(UCView_Back_ByCommand), null);

        public string PageBack
        {
            get
            {
                return (string)GetValue(PageBackProperty);
            }
            set
            {
                //lbl_SuppplierName.Text = value;
                SetValue(PageBackProperty, value);
                OnPropertyChanged(nameof(PageBack));

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

            //if (propertyName == PageBackProperty.PropertyName)
            //{
            //    //ValueLabel.Text = Value;

            //    img_Back.Clicked += Img_Back_Clicked;


            //}
           
        }

        private void Img_Back_Clicked(object sender, EventArgs e)
        {

            //try
            //{

            //    if (PageBack == "page_driver_access_code")
            //    {

            //        if (BindingContext is ViewModel_Page_Driver_Access_Dashboard vm)
            //        {
            //            if (vm.tab_Command_Delivery_Access_Code.CanExecute(null))
            //            {
            //                vm.tab_Command_Delivery_Access_Code.Execute(null);
            //            }
            //        }

            //    }

            //    else if (PageBack == "page_driver_delivery_view")
            //    {
            //        if (BindingContext is ViewModel_Page_Driver_Access_Dashboard vm)
            //        {
            //            if (vm.tab_Command_View_Deilvery_View.CanExecute(null))
            //            {
            //                vm.tab_Command_View_Deilvery_View.Execute(null);
            //            }
            //        }
            //    }

                
            //    else if (PageBack == "page_driver_delivery_list")
            //    {

            //    }




            //}
            //catch (Exception ex)
            //{
            //    SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            //    return;
            //}



        }


        #endregion





        #region Navigation





        #endregion


    }
}