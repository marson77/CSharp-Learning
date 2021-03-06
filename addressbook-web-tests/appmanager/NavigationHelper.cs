using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager,  string baseURL) : base(manager)
        {
         this.baseURL = baseURL;
        }

        public void GoToHomePage()
        {
            if (driver.Url == baseURL + "/addressbook")
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "/addressbook");
        }

        public void GoToGroupPage()
        {
            if (driver.Url == baseURL + "/addressbook/group.php/"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }

            driver.FindElement(By.XPath("//a[contains(text(),'groups')]")).Click();
        }

        public void GoToContactAddPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        public void ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }
    }
}
