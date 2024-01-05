using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_DependencyService
{
    public interface iSRoofing_DependencyService_KeyboardService
    {
        event EventHandler KeyboardIsShown;
        event EventHandler KeyboardIsHidden;

        void Show_Keyboard();
        void Hide_Keyboard();

        bool isKeyboardOpened();

    }
}
