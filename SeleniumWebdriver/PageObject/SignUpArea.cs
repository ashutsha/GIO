using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using GeoSeleniumWebdriver.BaseClasses;
using GeoSeleniumWebdriver.ComponentHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GeoSeleniumWebdriver.PageObject
{
    public class SignUpArea : PageBase
    {
        private IWebDriver driver;
        #region WebElement

        private IWebElement UserName => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));
        private IWebElement EmailAddress => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));
        private IWebElement Password => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(3) > input"));
        private IWebElement SignUp => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));

        #endregion

        public SignUpArea(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Actions
        public void SignUpAction()
        {
            UserName.Clear();
            UserName.SendKeys("Ash");
            Password.SendKeys("1111");
            SignUp.Click();
        }

        public void EmailAction()
        {
            UserName.Clear();
            UserName.SendKeys("Ash");
            Password.Clear();
            Password.SendKeys("1111");
            EmailAddress.SendKeys("a@gmail.com");
            SignUp.Click();
        }


        #endregion

        #region Navigation

        //public LoginPage NavigateToSignUpArea()
        //{
        //    return new LoginPage(driver);
        //}

        #endregion
    }
}

