using System.Configuration;

namespace Zukini.API.Examples.Features
{
    /// <summary>
    /// Helper class to make getting at the test settings easy. 
    /// To reference, simply use TestSettings.Property (e.g. TestSettings.ApplicationUrl).
    /// </summary>
    public static class TestSettings
    {
        public static string ApiMobileUrlDEV { get { return ConfigurationManager.AppSettings["CCMSIMobileApiUrlDev"]; } }
        public static string ApiMobileUrlUAT { get { return ConfigurationManager.AppSettings["CCMSIMobileApiUrlTest"]; } }

        public static string IdentityServerApiUrlUAT { get { return ConfigurationManager.AppSettings["IdentityServerApiUrlTest"]; } }
        public static string IdentityServerApiUrlDEV { get { return ConfigurationManager.AppSettings["IdentityServerApiUrlDev"]; } }

    }
}
