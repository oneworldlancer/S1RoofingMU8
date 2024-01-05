using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;

 
using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//[assembly: Xamarin.Forms.Dependency(typeof(S1RoofingMU.Platforms.DependencyService_KeyboardService))]
namespace S1RoofingMU.Platforms
{
    public class DependencyService_KeyboardService : iSRoofing_DependencyService_KeyboardService
    {

        public event EventHandler KeyboardIsShown;
        public event EventHandler KeyboardIsHidden;

        private InputMethodManager inputMethodManager;

        private bool wasShown = false;

        public DependencyService_KeyboardService()
        {
            GetInputMethodManager();
            SubscribeEvents();
        }

        public void OnGlobalLayout(object sender, EventArgs args)
        {
            GetInputMethodManager();
            if (!wasShown && IsCurrentlyShown())
            {
                KeyboardIsShown?.Invoke(this, EventArgs.Empty);
                wasShown = true;
            }
            else if (wasShown && !IsCurrentlyShown())
            {
                KeyboardIsHidden?.Invoke(this, EventArgs.Empty);
                wasShown = false;
            }
        }

        public bool IsCurrentlyShown()
        {
            return inputMethodManager.IsAcceptingText;
        }

        private void GetInputMethodManager()
        {
            if (inputMethodManager == null || inputMethodManager.Handle == IntPtr.Zero)
            {
           /////////////// inputMethodManager = (InputMethodManager)Xamarin.Forms.Forms.Context.GetSystemService(Context.InputMethodService);
            }
        }

        private void SubscribeEvents()
        {
          /////////////////  ((Activity)Xamarin.Forms.Forms.Context).Window.DecorView.ViewTreeObserver.GlobalLayout += this.OnGlobalLayout;
        }


        //////public event EventHandler KeyboardIsShown;
        //////public event EventHandler KeyboardIsHidden;

        //////private InputMethodManager inputMethodManager;

        //////private bool wasShown = false;

        //////public DependencyService_KeyboardService()
        //////{
        //////    GetInputMethodManager();
        //////    SubscribeEvents();
        //////}

        //////public void OnGlobalLayout(object sender, EventArgs args)
        //////{
        //////    GetInputMethodManager();
        //////    if (!wasShown && IsCurrentlyShown())
        //////    {
        //////        KeyboardIsShown?.Invoke(this, EventArgs.Empty);
        //////        wasShown = true;
        //////    }
        //////    else if (wasShown && !IsCurrentlyShown())
        //////    {
        //////        KeyboardIsHidden?.Invoke(this, EventArgs.Empty);
        //////        wasShown = false;
        //////    }
        //////}

        //////private bool IsCurrentlyShown()
        //////{
        //////    return inputMethodManager.IsAcceptingText;
        //////}

        //////private void GetInputMethodManager()
        //////{
        //////    if (inputMethodManager == null || inputMethodManager.Handle == IntPtr.Zero)
        //////    {
        //////        InputMethodManager inputMethodManager = (InputMethodManager)((Activity)global::Android.App.Application.Context).GetSystemService(Context.InputMethodService);
        //////    }
        //////}

        //////private void SubscribeEvents()
        //////{
        //////    ((Activity)Xamarin.Forms.Forms.Context).Window.DecorView.ViewTreeObserver.GlobalLayout += this.OnGlobalLayout;
        //////}

        public void Show_Keyboard()
        {
           // throw new NotImplementedException();
try
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage("Show_Keyboard-DO");

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        public void Hide_Keyboard( )
        {
            // throw new NotImplementedException();
            try
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage("Hide_Keyboard-DO");

                // inputMethodManager.HideSoftInputFromWindow(null, HideSoftInputFlags.None);

                //////////var context = Forms.Context;
                //////////var inputMethodManager = context.GetSystemService(Context.InputMethodService) as InputMethodManager;
                //////////if (inputMethodManager != null && context is Activity)
                //////////{
                //////////    var activity = context as Activity;
                //////////    var token = activity.CurrentFocus?.WindowToken;
                //////////    inputMethodManager.HideSoftInputFromWindow(token, HideSoftInputFlags.None);

                //////////    activity.Window.DecorView.ClearFocus();
                //////////}


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return;
            }
        }

        public bool isKeyboardOpened()
        {
            try
            {

                return inputMethodManager.IsAcceptingText;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;
            }
        }
    }
}