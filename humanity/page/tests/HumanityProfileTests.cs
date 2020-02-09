using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using Projekat.humanity.page.objects;
using NUnit.Framework;

namespace Projekat.humanity.page.tests
{
    public class HumanityProfileTests
    {
        public static void UploadImageTests()
        {
            IWebDriver wd = new ChromeDriver(Constants.ChromeDriver);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver inicijalizovan HA!");

            HumanityLogin.Login(wd, Constants.UserName, Constants.Password);
            System.Threading.Thread.Sleep(6000);
            Console.WriteLine("Verzija je {0}", HumanityProfile.GetVersion(wd));
            
            System.Threading.Thread.Sleep(3000);
            wd.Navigate().GoToUrl("https://zemicka.humanity.com/app/staff/detail/5353116/");
            System.Threading.Thread.Sleep(3000);
            HumanityEditStaff.ClickEditDetails(wd);
            HumanityEditStaff.SendUploadPicture(wd, Constants.ProfilePicture);

            HumanityEditStaff.ClickSaveEmployee(wd);
            wd.Quit();
        }
    }
}
