using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium;
using GeoSeleniumWebdriver.Settings;

namespace GeoSeleniumWebdriver.ComponentHelper
{
    public class BrowserHelper
    {
        public static void BrowserMaximize()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }
      
    }
}
