using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;


 
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar
    {
    //////[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SnackBar_Command_ScanOption : TemplatedView
    {



		public static readonly BindableProperty MyStringProperty = BindableProperty.Create ( "MyString" , typeof ( string ) , typeof ( SnackBar_Command_ScanOption ) , default ( string ) );
		public string MyString
			{
			get {
                return ( string ) GetValue ( MyStringProperty ); 
                }
			set { 
                SetValue ( MyStringProperty , value );
                
                }
			}



         

		public static readonly BindableProperty GalleryIsEnableProperty = BindableProperty.Create ( "GalleryIsEnable" , typeof ( bool ) , typeof ( SnackBar_Command_ScanOption ) , default ( bool ) );
		public bool GalleryIsEnable
			{
			get {
                return ( bool ) GetValue ( GalleryIsEnableProperty ); 
                }
			set { 
                SetValue ( GalleryIsEnableProperty , value );
                
                }
			}



         

		public static readonly BindableProperty GalleryIconProperty = BindableProperty.Create ( "GalleryIcon" , typeof ( string ) , typeof ( SnackBar_Command_ScanOption ) , default ( string ) );
		public string GalleryIcon
			{
			get {
                return ( string ) GetValue ( GalleryIconProperty ); 
                }
			set { 
                SetValue ( GalleryIconProperty , value );
                
                }
			}





		public static readonly BindableProperty GalleryColorProperty = BindableProperty.Create ( "GalleryColor" , typeof ( Color ) , typeof ( SnackBar_Command_ScanOption ) , default ( Color ) );
		public Color GalleryColor
			{
			get { return ( Color ) GetValue ( GalleryColorProperty ); }
			set { SetValue ( GalleryColorProperty , value ); }
			}
        







		//public static readonly BindableProperty ButtonTextColorProperty = BindableProperty.Create ( "ButtonTextColor" , typeof ( Color ) , typeof ( SnackBar_Command_ScanOption ) , default ( Color ) );

		//private string myStringProperty;
		//public string MyStringProperty
		//	{
		//	get { return myStringProperty; }
		//	set
		//		{
		//		myStringProperty = value;
		//		OnPropertyChanged ( nameof ( MyStringProperty ) ); // Notify that there was a change on this property
		//		}
		//	}








		public static readonly BindableProperty ButtonTextColorProperty = BindableProperty.Create("ButtonTextColor", typeof(Color), typeof(SnackBar_Command_ScanOption), default(Color));
    public Color ButtonTextColor
    {
        get { return (Color)GetValue(ButtonTextColorProperty); }
        set { SetValue(ButtonTextColorProperty, value); }
    }

    public static readonly BindableProperty MessageProperty = BindableProperty.Create("Message", typeof(string), typeof(SnackBar_Command_ScanOption), default(string));
    public string Message
    {
        get { return (string)GetValue(MessageProperty); }
        set { SetValue(MessageProperty, value); }
    }

    public static readonly BindableProperty CloseButtonTextProperty = BindableProperty.Create("CloseButtonText", typeof(string), typeof(SnackBar_Command_ScanOption), "Close");
    public string CloseButtonText
    {
        get { return (string)GetValue(CloseButtonTextProperty); }
        set { SetValue(CloseButtonTextProperty, value); }
    }

    public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(float), typeof(SnackBar_Command_ScanOption), default(float));
    public float FontSize
    {
        get { return (float)GetValue(FontSizeProperty); }
        set { SetValue(FontSizeProperty, value); }
    }

    public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(SnackBar_Command_ScanOption), Colors.White);
    public Color TextColor
    {
        get { return (Color)GetValue(TextColorProperty); }
        set { SetValue(TextColorProperty, value); }
    }

    public static readonly BindableProperty CloseButtonBackGroundColorProperty = BindableProperty.Create("CloseButtonBackGroundColor", typeof(Color), typeof(SnackBar_Command_ScanOption), Colors.Transparent);
    public Color CloseButtonBackGroundColor
    {
        get { return (Color)GetValue(CloseButtonBackGroundColorProperty); }
        set { SetValue(CloseButtonBackGroundColorProperty, value); }
    }






    public uint AnimationDuration { get; set; }

    #region IsOpen
    public static readonly BindableProperty IsOpenProperty = BindableProperty.Create("IsOpen", typeof(bool), typeof(SnackBar_Command_ScanOption), false, propertyChanged: IsOpenChanged);
    public bool IsOpen
    {
        get { return (bool)GetValue(IsOpenProperty); }
        set { SetValue(IsOpenProperty, value); }
    }

    private static void IsOpenChanged(BindableObject bindable, object oldValue, object newValue)
    {
        bool isOpen;

        if (bindable != null && newValue != null)
        {
            var control = (SnackBar_Command_ScanOption)bindable;
            isOpen = (bool)newValue;

            if (control.IsOpen == false)
            {
                control.Close();
            }
            else
            {
                control.Open(control.Message);
            }
        }
    }

    #endregion

    public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create("FontFamily", typeof(string), typeof(SnackBar_Command_ScanOption), default(string));
    public string FontFamily
    {
        get { return (string)GetValue(FontFamilyProperty); }
        set { SetValue(FontFamilyProperty, value); }
    }

    public SnackBar_Command_ScanOption ( )
    {
        IsVisible = false;
        AnimationDuration = 150;
        InitializeComponent();

            

    }

		private void Initialize ( )
			{

            try
                {

				if ( Preferences.Get ( "user_IsLogin" , false ) )
					{

                    GalleryIsEnable = true;
                    GalleryIcon = "img_circle_black.png";
                    GalleryColor = Colors.Black;
					//MyString = Preferences.Get ( "user_IsLogin" , false ).ToString ( );
                  
					}
				else
					{
					//MyString = Preferences.Get ( "user_IsLogin" , false ).ToString ( );

                	GalleryIsEnable = false;
					GalleryIcon = "img_circle_silver.png";
					GalleryColor = Colors.Silver;

					}

				}
			catch ( Exception ex )
				{
				SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
				return;
				}

			}

		private void CloseButton_Clicked(object sender, EventArgs e)
    {
        Close();
    }

    public async void Close()
    {
        await this.TranslateTo(0, 100, AnimationDuration);
        Message = string.Empty;
        IsOpen = IsVisible = false;
    }

    public async void Open(string message)
    {


			Initialize ( );


			IsVisible = true;
        Message = message;
        await this.TranslateTo(0, 0, AnimationDuration);

            await Task.Delay(7000);
         
            Close();

            //return "true";
        }

	async	private void lbl_OpenScanner_Clicked ( object sender , EventArgs e )
			{
            try
                {


                //await SRoofing_Page_OpenerManager.Page_Opener (
                //        Navigation ,
                //    new Page_QRCode ( ) ,
                //    false ,
                //    true );

                }
			catch ( Exception ex )
				{
				SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
				return;
				}


			}

	async	private void lbl_OpenGallery_Clicked ( object sender , EventArgs e )
			{

            try
                {


				//await SRoofing_Page_OpenerManager.Page_Opener (
				//		Navigation ,
				//	new Page_Gallery ( ) ,
				//	false ,
				//	true );


				}
			catch ( Exception ex )
				{
				SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
				return;
				}


			}

		private void img_Close_Clicked ( object sender , EventArgs e )
			{

			try
				{
               
                Close ( );

				}
			catch ( Exception ex )
				{
				SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
				return;
				}
			}
		}
}