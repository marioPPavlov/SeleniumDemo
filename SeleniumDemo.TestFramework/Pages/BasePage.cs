using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumDemo.TestFramework.Pages.Navigation;

namespace SeleniumDemo.TestFramework
{
    public abstract class BasePage 
    {
        public TopNavigationBar topNavigationBar; 
        protected RemoteWebDriver driver;

        public BasePage(RemoteWebDriver driver)
        {
            this.driver = driver;
            this.topNavigationBar = new TopNavigationBar(driver);
        }

        public abstract void Goto();

        public bool IsUserLoggedIn()
        {
            try
            {
                return topNavigationBar.LoggedUser().Displayed;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }
    }
}
