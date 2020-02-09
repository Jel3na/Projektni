using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Projekat.humanity.page.objects;
using NUnit.Framework;


namespace Projekat.humanity.page.tests
{
    public class HumanityLoginTests
    {
        public static void LoginSuccessTest()
        {
            IWebDriver wd = new ChromeDriver(Constants.ChromeDriver);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver inicijalizovan HA!");

            HumanityLogin.Login(wd, Constants.UserName, Constants.Password);
            System.Threading.Thread.Sleep(3000);
            Assert.AreEqual(Constants.Company + "app/dashboard/", wd.Url);
            Console.WriteLine("Login Success");
            wd.Quit();
        }

        public static void LoginFailTestPassword()
        {
            IWebDriver wd = new ChromeDriver(Constants.ChromeDriver);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver inicijalizovan HA!");

            HumanityLogin.Login(wd, Constants.UserName, "123");
            System.Threading.Thread.Sleep(3000);
            Assert.AreNotEqual(Constants.Company + "app/dashboard/", wd.Url);
            Console.WriteLine("Login wrong password Success");
            wd.Quit();
        }

        public static void LoginFailTestUsername()
        {
            IWebDriver wd = new ChromeDriver(Constants.ChromeDriver);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver inicijalizovan HA!");

            HumanityLogin.Login(wd, "123rty", Constants.Password);
            System.Threading.Thread.Sleep(3000);
            Assert.AreNotEqual(Constants.Company + "app/dashboard/", wd.Url);
            Console.WriteLine("Login wrong Username Success");
            wd.Quit();
        }

        public static void LoginTests()
        {
            LoginSuccessTest();
            LoginFailTestUsername();
            LoginFailTestPassword();
        }

    }
}
