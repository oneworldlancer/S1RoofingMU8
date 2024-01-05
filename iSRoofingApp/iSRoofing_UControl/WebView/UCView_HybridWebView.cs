﻿using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_UControl.WebView
    {
    public class UCView_HybridWebView : Microsoft.Maui.Controls.WebView
        {
        private Action<string> _action;

        public void RegisterAction ( Action<string> callback )
            {
            _action = callback;
            }

        public void Cleanup ( )
            {
            _action = null;
            }

        public void InvokeAction ( string data )
            {
            if ( _action == null || data == null )
                {
                return;
                }
            _action.Invoke ( data );
            }
        }
    }
