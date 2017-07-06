using System.Configuration;

namespace Zukini.UI.Examples.Features
{
    /// <summary>
    /// Helper class to make getting at the test settings easy. 
    /// To reference, simply use TestSettings.Property (e.g. TestSettings.ApplicationUrl).
    /// </summary>
    public static class TestSettings
    {
        public static string ClaimViewUrl { get { return ConfigurationManager.AppSettings["ClaimViewUrl"]; } }
        public static string GoogleUrl { get { return ConfigurationManager.AppSettings["GoogleUrl"]; } }
        public static string GoogleHttpUrl { get { return ConfigurationManager.AppSettings["GoogleHttpUrl"]; } }
        public static string W3SchoolsBaseUrl { get { return ConfigurationManager.AppSettings["W3SchoolsBaseUrl"]; } }
        public static string JsonPlaceholderApiUrl {  get { return ConfigurationManager.AppSettings["JsonPlaceholderApiUrl"]; } }
        public static string GridUrl { get { return ConfigurationManager.AppSettings["GridUrl"]; } }

        public static string BrowserLanguage { get { return ConfigurationManager.AppSettings["Language"]; } }

    }
}
