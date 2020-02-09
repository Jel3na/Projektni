using System;
using NUnit.Framework;
using Projekat.humanity.page.objects;
using IronXL;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace Projekat.humanity.page.tests
{
    public class HumanityAddNewEmployee
    {
        public static void AddNewEmployeeTest()
        {
            IWebDriver wd = new ChromeDriver(Constants.ChromeDriver);
            wd.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            wd.Manage().Window.Maximize();
            Debug.WriteLine("Driver inicijalizovan HA!");

            HumanityLogin.Login(wd, Constants.UserName, Constants.Password);
            System.Threading.Thread.Sleep(6000);
            HumanityMenu.ClickStaff(wd);
            System.Threading.Thread.Sleep(3000);
            HumanityStaff.ClickAddEmployees(wd);
            ExcelUtility.OpenFile(Constants.XLPath);
            ExcelUtility.LoadWorkSheet(0);

            for (int i = 1; i <= 3; i++)
            {
                HumanityStaff.SendFirstName(wd, ExcelUtility.GetDataAt(i, 0), i);
                HumanityStaff.SendLastName(wd, ExcelUtility.GetDataAt(i, 1), i);
                HumanityStaff.SendEmail(wd, ExcelUtility.GetDataAt(i, 3), i);
            }

            HumanityStaff.ClickSaveEmployees(wd);

            Assert.AreNotEqual(wd.Url, "https://zemicka.humanity.com/app/staff/add/");
            Console.WriteLine("Zaposleni Uspesno dodati!");

            wd.Quit();
        }
    }
}
