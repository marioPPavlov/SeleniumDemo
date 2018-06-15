using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SeleniumDemo.TestFramework
{
    public static class Browser
    {
        private static readonly string url = "https://localhost:yourPort";

        public static RemoteWebDriver Driver()
        {
            string geckoDriverDirectory = "./";
            var firefoxOptions = new FirefoxOptions
            {
                AcceptInsecureCertificates = true
            };
            return new FirefoxDriver(geckoDriverDirectory, firefoxOptions);
        }

        public static string MainPage()
        {
           return url;
        }

    }
}
