using Foundation;


using S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UIKit;


//[assembly: Xamarin.Forms.Dependency(typeof(S1RoofingMU.Platforms.DependencyService_KeyboardService))]
namespace S1RoofingMU.Platforms
{
    public class DependencyService_KeyboardService : iSRoofing_DependencyService_KeyboardService
    {

        public event EventHandler KeyboardIsShown;
        public event EventHandler KeyboardIsHidden;

        public DependencyService_KeyboardService()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            UIKeyboard.Notifications.ObserveDidShow(OnKeyboardDidShow);
            UIKeyboard.Notifications.ObserveDidHide(OnKeyboardDidHide);
        }

        private void OnKeyboardDidShow(object sender, EventArgs e)
        {
            KeyboardIsShown?.Invoke(this, EventArgs.Empty);
        }

        private void OnKeyboardDidHide(object sender, EventArgs e)
        {
            KeyboardIsHidden?.Invoke(this, EventArgs.Empty);
        }


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

        public void Hide_Keyboard()
        {
            // throw new NotImplementedException();
            try
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage("Hide_Keyboard-DO");

                UIApplication.SharedApplication.KeyWindow.EndEditing(true);

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

                return false;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;
            }
        }
    }

}