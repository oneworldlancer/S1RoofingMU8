using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Page.Login
{
    //////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Forgot_View : ContentView
    {
        public Page_Forgot_View()
        {
            InitializeComponent();
        }



        #region Property



        public static readonly BindableProperty iParentProperty = BindableProperty
            .Create("iParent", typeof(Page_Login_Dashboard),
            typeof(Page_Login_View), null);
        public Page_Login_Dashboard iParent
        {
            get { return (Page_Login_Dashboard)GetValue(iParentProperty); }
            set { SetValue(iParentProperty, value); }
        }



        #endregion


    }
}