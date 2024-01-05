using Foundation;

using Microsoft.Maui.Controls.Compatibility.Platform.iOS;
using Microsoft.Maui.Controls.Platform;

using S1RoofingMU.iSRoofingApp.iOS.iSRoofing_Render.Entry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
 
 

//[assembly: ExportRenderer(typeof(S1RoofingMU.iSRoofingApp.iSRoofing_UControl.Entry.UCView_EntryChatView), typeof(Render_EntryChatView))]
namespace S1RoofingMU.iSRoofingApp.iOS.iSRoofing_Render.Entry;

public class Render_EntryChatView : EntryRenderer, IUITextFieldDelegate
{

    protected override void OnElementChanged(ElementChangedEventArgs<Microsoft.Maui.Controls.Entry> e)
    {
        base.OnElementChanged(e);

        if (Control != null)
        {
            // do whatever you want to the UITextField here!
            //Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
            //Control.BorderStyle = UITextBorderStyle.Line;
       
            Control.BackgroundColor = UIColor.Clear;// FromRGB(204, 153, 255);
            Control.BorderStyle = UITextBorderStyle.None;

            Control.ReturnKeyType = UIReturnKeyType.Send;

            S1RoofingMU.iSRoofingApp.iSRoofing_UControl.Entry.UCView_EntryChatView entry = ( S1RoofingMU.iSRoofingApp.iSRoofing_UControl.Entry.UCView_EntryChatView ) this.Element;

            SetReturnType ( entry);

            Control.ShouldReturn += ( UITextField tf ) =>
            {
                //entry.InvokeCompleted ( );
                return true;
            };
        }
    }



    private void SetReturnType ( S1RoofingMU.iSRoofingApp.iSRoofing_UControl.Entry.UCView_EntryChatView control )
    {
        ReturnType type = ( ReturnType ) control.ReturnType;

        switch ( type )
        {
            case ReturnType.Go:
                Control.ReturnKeyType = UIReturnKeyType.Go;
                break;
            case ReturnType.Next:
                Control.ReturnKeyType = UIReturnKeyType.Next;
                break;
            case ReturnType.Send:
                Control.ReturnKeyType = UIReturnKeyType.Send;
                break;
            case ReturnType.Search:
                Control.ReturnKeyType = UIReturnKeyType.Search;
                break;
            case ReturnType.Done:
                Control.ReturnKeyType = UIReturnKeyType.Done;
                break;
            default:
                Control.ReturnKeyType = UIReturnKeyType.Default;
                break;
        }
    }


    //protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
    //{
    //    base.OnElementChanged(e);

    //    Control.Layer.BorderColor = UIColor.Red.CGColor;
    //    Control.Layer.BorderWidth = 1;
    //}
}