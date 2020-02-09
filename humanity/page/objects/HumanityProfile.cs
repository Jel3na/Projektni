using System;
using OpenQA.Selenium;

namespace Projekat.humanity.page.objects
{
    public class HumanityProfile
    {
        public static readonly string URL = "https://zemicka.humanity.com/app/dashboard/";
        public static readonly string Menu_XPath = "//div[@class='_navBottom _primNavQtip j-primary-navigation-qtip navBottom__userItem'][contains(@id,'menu')]";
        public static readonly string Profile_XPath = "/html[1]/body[1]/table[1]/tbody[1]/tr[1]/td[1]/div[4]/div[1]/a[1]";
        public static readonly string Settings_XPath = "/html[1]/body[1]/table[1]/tbody[1]/tr[1]/td[1]/div[4]/div[1]/a[2]";
        public static readonly string Availability_XPath = "/html[1]/body[1]/table[1]/tbody[1]/tr[1]/td[1]/div[4]/div[1]/a[3]";
        public static readonly string Version_XPath = "/html[1]/body[1]/table[1]/tbody[1]/tr[1]/td[1]/div[4]/div[1]/div[6]/b[1]";

        public static void NavigateTo(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(URL);
        }

        public static IWebElement GetMenu(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Menu_XPath));
        }

        public static void ClickMenu(IWebDriver wd)
        {
            GetMenu(wd).Click();
        }

        public static IWebElement GetProfile(IWebDriver wd)
        {
            ClickMenu(wd);
            return wd.FindElement(By.XPath(Profile_XPath));
        }

        public static void ClickProfile(IWebDriver wd)
        {
            Console.WriteLine("ELEMENT JE ++++");
            Console.WriteLine(GetProfile(wd));
            GetProfile(wd).Click();
        }

        public static IWebElement GetSettings(IWebDriver wd)
        {
            ClickMenu(wd);
            return wd.FindElement(By.XPath(Settings_XPath));
        }

        public static void ClickSettings(IWebDriver wd)
        {
            GetSettings(wd).Click();
        }

        public static IWebElement GetAvailability(IWebDriver wd)
        {
            ClickMenu(wd);
            return wd.FindElement(By.XPath(Availability_XPath));
        }

        public static void ClickAvailability(IWebDriver wd)
        {
            GetAvailability(wd).Click();
        }

        public static string GetVersion(IWebDriver wd)
        {
            ClickMenu(wd);
            return wd.FindElement(By.XPath(Version_XPath)).Text;
        }
    }
}
