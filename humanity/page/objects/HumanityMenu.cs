using System;
using OpenQA.Selenium;

namespace Projekat.humanity.page.objects
{
    public class HumanityMenu
    {
        public static readonly string URL = "https://zemicka.humanity.com/app/dashboard/";
        public static readonly string Dashboard_XPath = "//a[contains(@class,'lft act')]";
        public static readonly string ShiftPlanning_XPath = "//a[@href='/app/schedule/'][contains(@id,'schedule')][contains(.,'ShiftPlanning')]";
        public static readonly string TimeClock_XPath = "//a[@href='/app/timeclock/'][contains(@id,'timeclock')][contains(.,'Time Clock')]";
        public static readonly string Leave_XPath = "//a[@href='/app/requests/'][contains(@id,'requests')][contains(.,'Leave')]";
        public static readonly string Training_XPath = "//a[contains(.,'Training')]";
        public static readonly string Staff_XPath = "//a[contains(.,'Staff')]";
        public static readonly string Payroll_XPath = "//a[@href='/app/payroll/'][contains(@id,'payroll')][contains(.,'Payroll')]";
        public static readonly string Reports_XPath = "//a[@href='/app/reports/'][contains(@id,'reports')][contains(.,'Reports')]";
        public static readonly string Settings_XPath = "//a[@id='sn_admin']";

        public static void NavigateTo(IWebDriver wd)
        {
            wd.Navigate().GoToUrl(URL);
        }

        public static IWebElement GetDashboard(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Dashboard_XPath));
        }

        public static void ClickDashboard(IWebDriver wd)
        {
            GetDashboard(wd).Click();
        }

        public static IWebElement GetShiftPlanning(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(ShiftPlanning_XPath));
        }

        public static void ClickShiftPlanning(IWebDriver wd)
        {
            GetShiftPlanning(wd).Click();
        }

        public static IWebElement GetTimeClock(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(TimeClock_XPath));
        }

        public static void ClickTimeClock(IWebDriver wd)
        {
            GetTimeClock(wd).Click();
        }

        public static IWebElement GetLeave(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Leave_XPath));
        }

        public static void ClickLeave(IWebDriver wd)
        {
            GetLeave(wd).Click();
        }

        public static IWebElement GetTraining(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Training_XPath));
        }

        public static void ClickTraining(IWebDriver wd)
        {
            GetTraining(wd).Click();
        }

        public static IWebElement GetStaff(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Staff_XPath));
        }

        public static void ClickStaff(IWebDriver wd)
        {
            GetStaff(wd).Click();
        }

        public static IWebElement GetPayroll(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Payroll_XPath));
        }

        public static void ClickPayroll(IWebDriver wd)
        {
            GetPayroll(wd).Click();
        }

        public static IWebElement GetReports(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Reports_XPath));
        }

        public static void ClickReports(IWebDriver wd)
        {
            GetReports(wd).Click();
        }

        public static IWebElement GetSettings(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(Settings_XPath));
        }

        public static void ClickSettings(IWebDriver wd)
        {
            GetSettings(wd).Click();
        }
    }
}
