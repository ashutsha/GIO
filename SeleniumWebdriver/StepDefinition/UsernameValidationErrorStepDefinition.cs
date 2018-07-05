using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using GeoSeleniumWebdriver.ComponentHelper;
using GeoSeleniumWebdriver.PageObject;
using GeoSeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GeoSeleniumWebdriver.StepDefinition
{
    [Binding]
    public sealed class UsernameValidationErrorStepDefinition
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given(@"a user is not logged in")]
        [Scope(Feature = "_TS5_Validate already exist username")]
        public void GivenAUserIsNotLoggedIn()
        {
            ObjectRepository.sPage = new SignUpArea(ObjectRepository.Driver);
            Assert.AreEqual("Sign up — Conduit", ObjectRepository.sPage.Title);
            GenericHelper.TakeScreenShot();

        }

        [When(@"the user tries to sign up with a username that already exists")]
        public void WhenTheUserTriesToSignUpWithAUsernameThatAlreadyExists()
        {
             Assert.AreEqual("Sign up — Conduit", ObjectRepository.sPage.Title);
            ObjectRepository.sPage.SignUpAction();
            GenericHelper.TakeScreenShot();

        }

        [Then(@"a validation error is displayed")]
        public void ThenAValidationErrorIsDisplayed()
        {
            GenericHelper.IsElemetPresent(By.CssSelector("body > div > div > div > div > div > div > list-errors > ul > div > li"));
            GenericHelper.TakeScreenShot();

        }

    }
}
