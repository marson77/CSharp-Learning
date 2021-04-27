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

        public GroupsHelper CreateGroup(GroupData group)
        {
            manager.Navigator.GoToGroupPage();

            InitGroupCreation();
            FillGroupsForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }

        public List<GroupData> GetGroupList()
        {
            List<GroupData> groups = new List<GroupData>(); // Создаем коллекцию, 
            manager.Navigator.GoToGroupPage();
            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group")); // для кажого элемента в коллекции нужно выполнить какие то действия:
            foreach (IWebElement element in elements) 
            {
                groups.Add(new GroupData(element.Text)); //текст который видим на экране, 
            }
            return groups;
        }

        public GroupsHelper ModifyGroup(int p, GroupData newData)
        {

            manager.Navigator.GoToGroupPage();

            FindGroup(newData);
            SelectGroup(p);
            InitGroupModification();
            FillGroupsForm(newData);
            SubmitGroupModification();
            ReturnToGroupsPage();
            return this;
        }


        public GroupsHelper RemoveGroup(int p, GroupData newData)
        {
            manager.Navigator.GoToGroupPage();

            FindGroup(newData);
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



        public GroupsHelper SelectGroup(int index)
        {

            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index+1) + "]")).Click();//Xpath начинает отсчёт от 1, а C# от 0
            return this;
        }

        public GroupsHelper FindGroup(GroupData group)
        {
            if (GroupExist())
            {
                return this;
            }

            manager.Navigator.GoToGroupPage();

            InitGroupCreation();
            FillGroupsForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }

        public bool GroupExist()
        {
            return IsElementPresent(By.Name("selected[]"));
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
