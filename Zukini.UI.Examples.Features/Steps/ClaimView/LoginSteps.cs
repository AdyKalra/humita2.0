using BoDi;
using Coypu;
using Coypu.Drivers;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Zukini.UI.Examples.Pages.ClaimView;
using Zukini.UI.Steps;

namespace Zukini.UI.Examples.Features.Steps.ClaimView
{

    [Binding]
    public class LoginSteps: UISteps
         {
        private SessionConfiguration _sessionConfiguration;
        private LoginPage loginPage;

        public LoginSteps(IObjectContainer objectContainer, SessionConfiguration sessionConfiguration)
            : base(objectContainer)
        {
            _sessionConfiguration = sessionConfiguration;
        }
        [Given(@"I am at the login page")]
        public void GivenIAmAtTheLoginPage()
        {
            loginPage = new LoginPage(_sessionConfiguration, Browser);
        }
        
        [When(@"I fill in the following form")]
        public void WhenIFillInTheFollowingForm(Table table)
        {
            dynamic instance = table.CreateDynamicInstance();
            loginPage.fillEmailField(instance.Email);
            loginPage.fillPasswordField(instance.Password);
        }
        
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }
        
        [Then(@"I should be at the Verification Page")]
        public void ThenIShouldBeAtTheVerificationPage()
        {
            VerificationPage verification = new VerificationPage(_sessionConfiguration, Browser);
            verification.ValidateGenerateCodeButtonText();
        }
        
        [Then(@"I should see ""(.*)""")]
        public void ThenIShouldSee(string p0)
        {
            loginPage.GetSummaryValidationErrorMsg.Should().Contain(p0, "esto falla por... ");
        }
    }
}
