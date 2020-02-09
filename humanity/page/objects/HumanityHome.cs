using System;
using OpenQA.Selenium;

namespace Projekat.humanity.page.objects
{
    public class HumanityHome
    {
        public static readonly string URL = "https://www.humanity.com/";
        public static readonly string AboutUs_XPath = "//a[@class='nav-link no-before'][contains(.,'About us')]";
        public static readonly string Login_XPath = "//p[contains(.,'LOGIN')]";
        public static readonly string Trial_XPath = "//a[contains(@class,'button pale')]";
        public static readonly string FullName_XPath = "//input[contains(@name,'fullname')]";
        public static readonly string Email_XPath = "//input[contains(@name,'workemail')]";
        public static readonly string SignIn_XPath = "//input[contains(@data-position,'header')]";

        public static void NavigateTo(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(URL);
        }

        public static IWebElement GetAboutUs(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(AboutUs_XPath));
        }

        public static void ClickAboutUs(IWebDriver wd)
        {
            GetAboutUs(wd).Click();
        }


        public static IWebElement GetLogin(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Login_XPath));
        }

        public static void ClickLogin(IWebDriver wd)
        {
            GetLogin(wd).Click();
        }

        public static IWebElement GetTrial(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Trial_XPath));
        }

        public static void ClickTrial(IWebDriver wd)
        {
            GetTrial(wd).Click();
        }

        public static IWebElement GetFullName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(FullName_XPath));
        }

        public static void SendFullName(IWebDriver wd, string fullName)
        {
            GetFullName(wd).SendKeys(fullName);
        }

        public static IWebElement GetEmail(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Email_XPath));
        }

        public static void SendEmail(IWebDriver wd, string email)
        {
            GetEmail(wd).SendKeys(email);
        }

        public static IWebElement GetSignin(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SignIn_XPath));
        }

        public static void ClickSignin(IWebDriver wd)
        {
            GetSignin(wd).Click();
        }
    }
}
