//using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoSeleniumWebdriver.ComponentHelper;
using GeoSeleniumWebdriver.PageObject;
using GeoSeleniumWebdriver.Settings;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GeoSeleniumWebdriver.StepDefinition
{
    [Binding]
    public sealed class ValidateSignUpAreaStepDefinition
    {

        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        [Given(@"User is at anjularjs Home Page with url ""(.*)""")]
      
        public void GivenUserIsAtAnjularjsHomePageWithUrl(string url)
        {

            NavigationHelper.NavigateToUrl(url);
            GenericHelper.TakeScreenShot();
        }


        [Given(@"a user is not logged in")]
        [Scope(Feature = "_TS4_Validate Sign Up Area")]
        public void GivenAUserIsNotLoggedIn()
        {
            ObjectRepository.uPage = new UHomePage(ObjectRepository.Driver);
            Assert.AreEqual("Home — Conduit", ObjectRepository.uPage.Title);
            ObjectRepository.sPage = ObjectRepository.uPage.NavigateToSignUpArea();
            GenericHelper.TakeScreenShot();

        }

        [When(@"a user tries to like an article")]
        public void WhenAUserTriesToLikeAnArticle()
        {
           // ObjectRepository.uPage = new UHomePage(ObjectRepository.Driver);
            ObjectRepository.uPage.ClickArticleLink();
            ObjectRepository.sPage = ObjectRepository.uPage.NavigateToSignUpArea();
            GenericHelper.TakeScreenShot();
        }

        [Then(@"the user is directed to the Sign up area")]
        public void ThenTheUserIsDirectedToTheSignUpArea()
        {
            Assert.AreEqual("Sign up — Conduit", ObjectRepository.sPage.Title);
            GenericHelper.TakeScreenShot();
        }
    }
}
