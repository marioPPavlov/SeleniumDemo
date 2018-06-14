using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace SeleniumDemo.TestFramework
{
    public static class Browser
    {
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
           return "https://localhost:yourPort/";
        }
    }
}
