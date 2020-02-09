using System;
using OpenQA.Selenium;

namespace Projekat.humanity.page.objects
{
    public class HumanityEditStaff
    {
        public static readonly string EditDetails_XPath = "//a[contains(.,'Edit Details')]";
        public static readonly string SaveEmployee_XPath = "//button[@id='act_primary']";
        public static readonly string UploadPicture_XPath = "//input[@id='fileupload']";
        public static readonly string NickName_XPath = "//input[@id='nick_name']";

        public static IWebElement GetEditDetails(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(EditDetails_XPath));
        }

        public static void ClickEditDetails(IWebDriver wd)
        {
            GetEditDetails(wd).Click();
        }

        public static IWebElement GetSaveEmployee(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(SaveEmployee_XPath));
        }

        public static void ClickSaveEmployee(IWebDriver wd)
        {
            GetSaveEmployee(wd).Click();
        }

        public static IWebElement GetUploadPicture(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(UploadPicture_XPath));
        }

        public static void SendUploadPicture(IWebDriver wd, string ImagePath)
        {
            GetUploadPicture(wd).SendKeys(ImagePath);
        }

        public static IWebElement GetNickName(IWebDriver wd)
        {
            return wd.FindElement(By.XPath(NickName_XPath));
        }

        public static void SendNickName(IWebDriver wd, string Nickname)
        {
            GetNickName(wd).SendKeys(Nickname);
        }


    }
}
