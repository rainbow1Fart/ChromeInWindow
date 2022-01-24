﻿using CefSharp;
using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromeInCore
{
    internal class OpenPageSelf : ILifeSpanHandler
    {
        public bool DoClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            return false;
        }

        public void OnAfterCreated(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            ;
        }

        public void OnBeforeClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            ;
        }

        public bool OnBeforePopup(IWebBrowser chromiumWebBrowser, 
            IBrowser browser, 
            IFrame frame, 
            string targetUrl, 
            string targetFrameName,
            WindowOpenDisposition targetDisposition, 
            bool userGesture, 
            IPopupFeatures popupFeatures, 
            IWindowInfo windowInfo, 
            IBrowserSettings browserSettings, 
            ref bool noJavascriptAccess, 
            out IWebBrowser newBrowser)
        {
            newBrowser = null;
            var browserControl = (ChromiumWebBrowser)chromiumWebBrowser;
            browserControl.Load(targetUrl);
            return true; //Return true to cancel the popup creation copyright by codebye.com.
        }
    }
}
