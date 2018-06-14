using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeleniumDemo.TestFramework.Pages.Navigation
{
    public class TopNavigationBar
    {
        protected RemoteWebDriver driver;
        public TopNavigationBar(RemoteWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement LogInLink()
        {
            return driver.FindElementByName("Login");
        }

        public IWebElement LogOutLink()
        {
            return driver.FindElementByName("LogOut");
        }

        public IWebElement RegisterLink()
        {
            return driver.FindElementByName("Register");
        }

        public IWebElement LoggedUser()
        {
            return driver.FindElementByName("loggedUser");
        }

    }
}
