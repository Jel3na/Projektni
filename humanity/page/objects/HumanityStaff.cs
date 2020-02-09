using System;
using OpenQA.Selenium;

namespace Projekat.humanity.page.objects
{
    public class HumanityStaff
    {
        public static readonly string URL = "https://zemicka.humanity.com/app/staff/list/load/true/";
        public static readonly string ADD_EMPLOYEES_URL = "https://zemicka.humanity.com/app/staff/add/";
        public static readonly string AddEmployees_XPath = "//button[@id='act_primary']";
        public static readonly string Employee_XPath = "(//a[contains(@class,'staff-employee')])";
        public static readonly string FirstName_XPath = "//input[@type='text'][contains(@id,'asf";
        public static readonly string LastName_XPath = "//input[@type='text'][contains(@id,'asl";
        public static readonly string Email_XPath = "//input[@type='text'][contains(@id,'ase";
        public static readonly string SaveEmployees_XPAth = "//button[@id='_as_save_multiple']";

        public static void NavigateTo(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(URL);
        }

        public static void NavigateToAddEmployees(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(ADD_EMPLOYEES_URL);
        }

        public static IWebElement GetAddEmployees(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(AddEmployees_XPath));
        }

        public static void ClickAddEmployees(IWebDriver wd)
        {
            GetAddEmployees(wd).Click();
        }

        public static IWebElement GetNthEmployee(IWebDriver wd, int employeeIndex)
        {
            return wd.FindElement(By.XPath(Employee_XPath + "[" + employeeIndex + "]"));
        }

        public static void ClickNthEmployee(IWebDriver wd, int employeeIndex)
        {
            GetNthEmployee(wd, employeeIndex).Click();
        }

        public static IWebElement GetFirstName(IWebDriver wd, int index)
        {
            return wd.FindElement(By.XPath(FirstName_XPath + index + "')]"));
        }

        public static void SendFirstName(IWebDriver wd, string email, int index)
        {
            GetFirstName(wd, index).SendKeys(email);
        }

        public static IWebElement GetLastName(IWebDriver wd, int index)
        {
            return wd.FindElement(By.XPath(LastName_XPath + index + "')]"));
        }

        public static void SendLastName(IWebDriver wd, string email, int index)
        {
            GetLastName(wd, index).SendKeys(email);
        }

        public static IWebElement GetEmail(IWebDriver wd, int index)
        {
            return wd.FindElement(By.XPath(Email_XPath + index + "')]"));
        }

        public static void SendEmail(IWebDriver wd, string email, int index)
        {
            GetEmail(wd, index).SendKeys(email);
        }

        public static IWebElement GetSaveEmployees(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SaveEmployees_XPAth));
        }

        public static void ClickSaveEmployees(IWebDriver wd)
        {
            GetSaveEmployees(wd).Click();
        }
    }
}
