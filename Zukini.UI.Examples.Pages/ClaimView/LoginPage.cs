using Coypu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zukini.UI.Examples.Features;
using Zukini.UI.Pages;

namespace Zukini.UI.Examples.Pages.ClaimView
{
    public class LoginPage : BasePage
    {
        BrowserSession browser;
        private SessionConfiguration _sessionConfiguration;

        public LoginPage(SessionConfiguration _sessionConfiguration, BrowserSession browser) : base(browser)
        {
            this._sessionConfiguration = _sessionConfiguration;
            this.browser = browser;
            this.browser.WaitForNavigation(this._sessionConfiguration, PageSettings.ClaimViewUrl);
        }

        private string SpinnerLocator = ".//div[@class='spinner-image']";
        public ElementScope EmailTextBox { get { return browser.FindXPath(".//input[@name='Email']"); } }
        public ElementScope PasswordTextBox { get { return browser.FindXPath(".//input[@name='Password']"); } }
        public ElementScope LogginButton { get { return browser.FindXPath(".//input[@class='btn access-btn-submit access-margin-right-4']"); } }
        public ElementScope SummaryValidationError { get { return browser.FindXPath(".//div[@class='col-md-9 col-lg-8 summary-validation-error ng-binding']"); } }
        public ElementScope Spinner { get { return browser.FindXPath(SpinnerLocator); } }
        public string GetSummaryValidationErrorMsg { get { return (String)browser.ExecuteScript("return arguments[0].innerHTML;", SummaryValidationError); } }

        public void ClickLoginButton()
        {
            LogginButton.Click();
            WaitForSpinnerDisapear();
        }

        public void fillEmailField(String email)
        {
            EmailTextBox.FillInWith(email);
        }

        public void fillPasswordField(string password)
        {
            PasswordTextBox.FillInWith(password);
        }

        public void WaitForSpinnerDisapear()
        {
            Browser.WaitUntil(() => browser.FindXPath(SpinnerLocator).Missing(), "Spinner exists");
        }
    }
}
