using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;

using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;

using S1RoofingMU.iSRoofingApp.Droid.iSRoofing_Render.Entry;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




//[assembly: ExportRenderer ( typeof ( S1RoofingMU.iSRoofingApp.iSRoofing_UControl.Entry.UCView_EntryChatView ) , typeof ( Render_EntryChatView ) )]
namespace S1RoofingMU.iSRoofingApp.Droid.iSRoofing_Render.Entry;

//[Obsolete]
public class Render_EntryChatView : EntryRenderer
{

    public Render_EntryChatView(Context context) : base(context)
    {
    }

    protected override void OnElementChanged(ElementChangedEventArgs<Microsoft.Maui.Controls.Entry> e)
    {
        base.OnElementChanged(e);

        try
        {


            if (Control != null)
            {
                //Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);


                Control?.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
                Control?.SetTextColor(global::Android.Graphics.Color.White);
                Control?.SetHintTextColor(global::Android.Graphics.Color.WhiteSmoke);

                Control.ImeOptions = ImeAction.Send;
                Control.SetImeActionLabel("Send", ImeAction.Send);
               
                //   Control.InputType = global::Android.Text.InputTypes.Null;

                //S1RoofingMU.iSRoofingApp.iSRoofing_UControl.Entry.UCView_EntryChatView entry = ( S1RoofingMU.iSRoofingApp.iSRoofing_UControl.Entry.UCView_EntryChatView ) this.Element;

                //SetReturnType(entry);

                // Editor Action is called when the return button is pressed  
                ////////Control.EditorAction += (object sender, TextView.EditorActionEventArgs args) =>
                ////////{
                ////////    //if (args.ActionId == ImeAction.Done)
                ////////    //{
                ////////        entry.InvokeCompleted();

                ////////        args.Handled = true;
                ////////    //}

                ////////    //if (entry.ReturnType != ReturnType.Next)
                ////////    //    entry.Unfocus();

                ////////    // Call all the methods attached to custom_entry event handler Completed  
                ////////    //entry.InvokeCompleted();

                ////////    //return true;
                ////////};


                /////////////////////////////////////////////////
               
                ////////////Control.EditorAction += (sender, args) =>
                ////////////{
                ////////////    if (args.ActionId == ImeAction.Send)
                ////////////    {
                ////////////        ((S1RoofingMU.iSRoofingApp.iSRoofing_UControl.Entry.UCView_EntryChatView)this.Element).InvokeCompleted();
                ////////////        args.Handled = true;
                ////////////    }
                ////////////};


                //Control.SetOnEditorActionListener(new CustomEditorActionListener()); 




            }


        }
        catch (Exception ex)
        {
            SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            return;

        }

    }




    //private class CustomEditorActionListener : Java.Lang.Object, TextView.IOnEditorActionListener
    //{
    //    public bool OnEditorAction(TextView v, [GeneratedEnum] ImeAction actionId, KeyEvent e)
    //    {
    //        // Your custom action handling logic
    //        if (actionId == ImeAction.Done || actionId == ImeAction.Send)
    //        {
    //            // Trigger some action, like Command.Execute or similar

    //            // Return true to prevent the keyboard from dismissing
    //            return true;
    //        }

    //        // Return false for default behavior

    //        return false;

    //    }
    //}


    private void SetReturnType(S1RoofingMU.iSRoofingApp.iSRoofing_UControl.Entry.UCView_EntryChatView entry)
    {
        ReturnType type = (ReturnType)entry.ReturnType;

        switch (type)
        {
            case ReturnType.Go:
                Control.ImeOptions =global::Android.Views.InputMethods.ImeAction.Go;
                Control.SetImeActionLabel("Go", ImeAction.Go);
                break;
            case ReturnType.Next:
                Control.ImeOptions = ImeAction.Next;
                Control.SetImeActionLabel("Next", ImeAction.Next);
                break;
            case ReturnType.Send:
                Control.ImeOptions = ImeAction.Send;
                Control.SetImeActionLabel("Send", ImeAction.Send);
                break;
            case ReturnType.Search:
                Control.ImeOptions = ImeAction.Search;
                Control.SetImeActionLabel("Search", ImeAction.Search);
                break;
            default:
                Control.ImeOptions = ImeAction.Done;
                Control.SetImeActionLabel("Done", ImeAction.Done);
                break;
        }
    }

    //protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
    //{
    //    base.OnElementChanged(e);
    //    if (e.OldElement == null)
    //    {
    //        var nativeEditText = (global::Android.Widget.EditText)Control;
    //        var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
    //        shape.Paint.Color = Xamarin.Forms.Color.Red.ToAndroid();
    //        shape.Paint.SetStyle(Paint.Style.Stroke);
    //        nativeEditText.Background = shape;
    //    }
    //}
}