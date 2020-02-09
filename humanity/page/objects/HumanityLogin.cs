using System;
using OpenQA.Selenium;

namespace Projekat.humanity.page.objects
{
    public class HumanityLogin
    {
        public static readonly string URL = "https://www.humanity.com/app/";
        public static readonly string Email_XPath = "//input[contains(@name,'email')]";
        public static readonly string Password_XPath = "//input[contains(@name,'password')]";
        public static readonly string Login_XPath = "//button[@class='btn btn-full'][contains(.,'Log in')]";

        public static void NavigateTo(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(URL);
        }

        public static IWebElement GetEmail(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Email_XPath));
        }

        public static void SendEmail(IWebDriver wd, string email)
        {
            GetEmail(wd).SendKeys(email);
        }

        public static IWebElement GetPassword(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Password_XPath));
        }

        public static void SendPassword(IWebDriver wd, string password)
        {
            GetPassword(wd).SendKeys(password);
        }


        public static IWebElement GetLogin(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Login_XPath));
        }

        public static void ClickLogin(IWebDriver wd)
        {
            GetLogin(wd).Click();
        }

        public static void Login(IWebDriver wd, string Username, string Password)
        {
            NavigateTo(wd);
            SendEmail(wd, Username);
            SendPassword(wd, Password);
            ClickLogin(wd);
        }
    }
}
