using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using GeoSeleniumWebdriver.Interfaces;
using GeoSeleniumWebdriver.PageObject;

namespace GeoSeleniumWebdriver.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
        public static UHomePage uPage;
        public static SignUpArea sPage;
    }
}
