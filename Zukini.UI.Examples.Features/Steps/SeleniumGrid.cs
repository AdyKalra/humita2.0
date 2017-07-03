using BoDi;
using Coypu;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zukini.UI.Examples.Pages;
using Zukini.UI.Steps;

namespace Zukini.UI.Examples.Features.Steps
{
    public class SeleniumGrid : UISteps
    {
        private SessionConfiguration _sessionConfiguration;

        public SeleniumGrid(IObjectContainer objectContainer, SessionConfiguration sessionConfiguration)
            : base(objectContainer)
        {
            _sessionConfiguration = sessionConfiguration;
        }

        [Test]
        public void GoogleForSeleniumOnGrid()
        {
            
        _sessionConfiguration.Browser = Coypu.Drivers.Browser.HtmlUnit;
        // IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), DesiredCapabilities.Chrome());


            // Navigate to google
            Browser.WaitForNavigation(_sessionConfiguration, TestSettings.GoogleUrl);
            new GoogleSearchPage(Browser).SearchTextBox.FillInWith("Selenium");
            new GoogleSearchPage(Browser).SearchButton.Click();
            Assert.IsTrue(Browser.HasContent("selenium"));
        }
    }
}
