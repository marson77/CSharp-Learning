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
    public class GroupsHelper : HelperBase
    {

        public GroupsHelper(ApplicationManager manager) : base(manager)
        {

        }

        public GroupsHelper Create(GroupData group)
        {
            manager.Navigator.GoToGroupPage();

            InitGroupCreation();
            FillGroupsForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }

        public GroupsHelper Modify(int p, GroupData newData)
        {
            manager.Navigator.GoToGroupPage();
            SelectGroup(p);
            InitGroupModification();
            FillGroupsForm(newData);
            SubmitGroupModification();
            ReturnToGroupsPage();
            return this;
        }


        public GroupsHelper Remove(int p)
        {
            manager.Navigator.GoToGroupPage();
            SelectGroup(p);
            RemoveGroup();
            ReturnToGroupsPage();
            return this;
        }

        public GroupsHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupsHelper FillGroupsForm(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }

        private void Type(By locator, string text)
        {
            if (text != null) // == - сравнение, != - неравно
            {
                driver.FindElement(locator).Click();
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }

        }

        public GroupsHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public GroupsHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }

        public GroupsHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupsHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            return this;
        }

        public GroupsHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupsHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }
    }
 }
