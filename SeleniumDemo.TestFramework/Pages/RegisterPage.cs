using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumDemo.TestFramework.Generators;
using SeleniumDemo.TestFramework.Models;

namespace SeleniumDemo.TestFramework.Pages
{
    public class RegisterPage : BasePage
    {
        public RegisterPage(RemoteWebDriver driver) : base(driver)
        {
        }

        private IWebElement RegisterLink { get => topNavigationBar.RegisterLink(); }
        private IWebElement EmailAddressTextField { get => driver.FindElementByName("Email"); }
        private IWebElement PasswordTextField { get => driver.FindElementByName("Password"); }
        private IWebElement ConfirmPasswordTextField { get => driver.FindElementByName("ConfirmPassword"); }
        private IWebElement RegisterButton { get => driver.FindElementByName("RegisterButton"); }

        public override void Goto()
        {
            RegisterLink.Click();
        }

        public void RegisterNewUser()
        {
            User newUser = UserGenerator.Generate();
            EmailAddressTextField.SendKeys(newUser.EmailAddress);
            PasswordTextField.SendKeys(newUser.Password);
            ConfirmPasswordTextField.SendKeys(newUser.Password);
            RegisterButton.Click();
        }

    }
}
