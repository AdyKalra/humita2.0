using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Coypu.Drivers;
using Coypu.Drivers.Selenium;
using OpenQA.Selenium.PhantomJS;

namespace Zukini.UI.Examples.Features.CustomDrivers
{
    public class CustomPhantomJsSeleniumDriver : SeleniumWebDriver
    {
            public CustomPhantomJsSeleniumDriver(PhantomJSOptions phantomOptions)
                : base(CustomProfileDriver(phantomOptions), Browser.PhantomJS)
            {
            }

            public static PhantomJSDriver CustomProfileDriver(PhantomJSOptions phantomOptions)
            {
                return new PhantomJSDriver(phantomOptions);
            }
    }
}


