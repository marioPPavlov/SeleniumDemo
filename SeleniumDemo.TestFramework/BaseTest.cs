using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace SeleniumDemo.TestFramework
{
    [TestFixture]
    public abstract class BaseTest
    {
        protected RemoteWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = Browser.Driver();
            driver.Url = Browser.MainPage();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
