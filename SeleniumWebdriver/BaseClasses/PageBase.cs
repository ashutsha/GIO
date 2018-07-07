using OpenQA.Selenium;
using Protractor;
using SeleniumExtras.PageObjects;

namespace GeoSeleniumWebdriver.BaseClasses
{
    public class PageBase
    {
        private IWebDriver driver;


        public PageBase(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            this.driver = _driver;
        }


        public string Title
        {
            get { return driver.Title; }
        }
    }
}
