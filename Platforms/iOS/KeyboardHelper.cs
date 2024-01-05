﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UIKit;

namespace S1RoofingMU.Platforms
{
    public static partial class KeyboardHelper
    {
        public static void HideKeyboard()
        {
            UIApplication.SharedApplication.KeyWindow.EndEditing(true);
        }
    }
}
