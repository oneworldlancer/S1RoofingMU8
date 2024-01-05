using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_UControl.Entry
{

    //https://stackoverflow.com/questions/48003093/xamarin-forms-hide-editor-or-entry-underline
   // https://www.c-sharpcorner.com/article/introduction-to-xamarin-return-key/
    public class UCView_EntryView : Microsoft.Maui.Controls.Entry
        {

        // Need to overwrite default handler because we cant Invoke otherwise  
        public new event EventHandler Completed;

        public static readonly BindableProperty ReturnTypeProperty = BindableProperty.Create ( nameof ( ReturnType ) ,
            typeof ( ReturnType ) , typeof ( UCView_EntryView ) ,
            ReturnType.Done , BindingMode.OneWay );

        public ReturnType ReturnType
        {
            get { return ( ReturnType ) GetValue ( ReturnTypeProperty ); }
            set { SetValue ( ReturnTypeProperty , value ); }
        }

        public void InvokeCompleted ( )
        {
            if ( this.Completed != null )
                this.Completed.Invoke ( this , null );
        }
    }
    public enum iReturMyReturnTypenType
    {
        Go,
        Next,
        Done,
        Send,
        Search
    }
}
