﻿using NUnit.Framework;
using SeleniumDemo.TestFramework.Pages;
using SeleniumDemo.TestFramework;
using Microsoft.Extensions.Configuration;

namespace SeleniumDemo.Tests
{
    public class AuthenticationTests : BaseTest
    {
        [Test]
        [Order(1)]
        public void Register()
        {
            RegisterPage regPage = new RegisterPage(driver);
            regPage.Goto();
            regPage.RegisterNewUser();

            Assert.IsTrue(regPage.IsUserLoggedIn());
        }

        [Test]
        public void LogIn()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Goto();
            loginPage.LogIn();

            Assert.IsTrue(loginPage.IsUserLoggedIn());
        }

        [Test]
        public void LogOut()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Goto();
            loginPage.LogIn();

            Assert.IsTrue(loginPage.IsUserLoggedIn());
            loginPage.LogOut();
            Assert.IsFalse(loginPage.IsUserLoggedIn());
        }
    }
}
