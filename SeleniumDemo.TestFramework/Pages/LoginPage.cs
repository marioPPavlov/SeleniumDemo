using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumDemo.TestFramework.Generators;

namespace SeleniumDemo.TestFramework.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(RemoteWebDriver driver) : base(driver)
        {
        }

        private IWebElement LoginLink { get => topNavigationBar.LogInLink(); }
        private IWebElement EmailAddressTextField { get => driver.FindElementById("Email"); }
        private IWebElement PasswordTextField { get => driver.FindElementById("Password"); }
        private IWebElement LogInButton { get => driver.FindElementByName("LogInButton"); }
        private IWebElement LogOutButton { get => topNavigationBar.LogOutLink(); }

        public override void Goto()
        {
            LoginLink.Click();
        }

        public void LogIn()
        {
            EmailAddressTextField.SendKeys(UserGenerator.LastGeneratedUser().EmailAddress);
            PasswordTextField.SendKeys(UserGenerator.LastGeneratedUser().Password);
            LogInButton.Click();
        }

        public void LogOut()
        {
            LogOutButton.Click();
        }


    }
}
