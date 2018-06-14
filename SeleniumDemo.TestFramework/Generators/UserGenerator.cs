using SeleniumDemo.TestFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumDemo.TestFramework.Generators
{
    public static class UserGenerator
    {
        private static User lastGeneratedUser;
        public static User LastGeneratedUser()
        {
            if (lastGeneratedUser == null)
            {
                Generate();
            }
            return lastGeneratedUser;
        }

        public static User Generate()
        {
            var user = new User
            {
                EmailAddress = RandomEmailAddress(),
                Password = RandomPassword()
            };

            lastGeneratedUser = user;
            return user;
        }

        private static string alphaNumericValues = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private static string RandomEmailAddress()
        {
            string username = RandomString(7, alphaNumericValues) + "@" + RandomString(4, alphaNumericValues) + ".com";
            return username;
        }

        private static string RandomPassword()
        {
            string password = RandomString(6, alphaNumericValues) + "!2Aa";
            return password;
        }


        private static Random random = new Random();
        private static string RandomString(int length, string chars)
        {
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
