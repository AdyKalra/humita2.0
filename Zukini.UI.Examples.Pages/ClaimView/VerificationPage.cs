using Coypu;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zukini.UI.Pages;

namespace Zukini.UI.Examples.Pages.ClaimView
{
    public class VerificationPage : BasePage
    {
        BrowserSession browser;
        private SessionConfiguration _sessionConfiguration;

        public VerificationPage(SessionConfiguration _sessionConfiguration, BrowserSession browser) : base(browser)
        {
            this._sessionConfiguration = _sessionConfiguration;
            this.browser = browser;
            // this.browser.WaitForNavigation(this._sessionConfiguration, PageSettings.ClaimViewUrl);
        }

        public ElementScope GenerateCodeButton { get { return browser.FindXPath(GenerateCodeButtonLocator); } }
        private string GenerateCodeButtonLocator = ".//div/button[@class='btn access-btn-warning ng-scope']";

        public void ValidateGenerateCodeButtonText()
        {
            GenerateCodeButton.Text.Should().Be("Generate Code");
        }

    }
}
