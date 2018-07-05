using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using GeoSeleniumWebdriver.BaseClasses;
using GeoSeleniumWebdriver.ComponentHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoSeleniumWebdriver.PageObject
{
    public class UHomePage : PageBase
    {
        private IWebDriver driver;
        #region WebElement

        private IWebElement ArticleLink => driver.FindElement(By.CssSelector("body > div > div > div > div.container.page > div > div.col-md-9 > article-list > article-preview:nth-child(1) > div > article-meta > div > ng-transclude > favorite-btn > button"));

        #endregion

        public UHomePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Actions
        public void ClickArticleLink()
        {
            ArticleLink.Click();
        }
       
        #endregion

        #region Navigation

        public SignUpArea NavigateToSignUpArea()
        {
            return new SignUpArea(driver);
        }

        #endregion
    }
}

