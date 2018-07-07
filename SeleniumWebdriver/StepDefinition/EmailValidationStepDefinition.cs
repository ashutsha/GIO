using GeoSeleniumWebdriver.ComponentHelper;
using GeoSeleniumWebdriver.PageObject;
using GeoSeleniumWebdriver.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace GeoSeleniumWebdriver.StepDefinition
{
    [Binding]
    public sealed class EmailValidationStepDefinition
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given(@"a user is not logged in")]
        [Scope(Feature = "_TS6_Validate already exist email address")]
        public void GivenAUserIsNotLoggedIn()
        {
            ObjectRepository.sPage = new SignUpArea(ObjectRepository.Driver);
            Assert.AreEqual("Sign up — Conduit", ObjectRepository.sPage.Title);
            GenericHelper.TakeScreenShot();

        }
        [When(@"the user tries to sign up with an email address that already exists")]
        public void WhenTheUserTriesToSignUpWithAnEmailAddressThatAlreadyExists()
        {
            ObjectRepository.sPage.EmailAction();
            Thread.Sleep(5000);
            GenericHelper.TakeScreenShot();
        }

        [Then(@"a validation error is displayed")]
        [Scope(Feature = "_TS6_Validate already exist email address")]
        public void ThenAValidationErrorIsDisplayed()
        {
            GenericHelper.IsElemetPresent(By.XPath("/html/body/div/div/div/div/div/div/list-errors/ul/div[1]/li"));
            GenericHelper.TakeScreenShot();

        }
    }
}
