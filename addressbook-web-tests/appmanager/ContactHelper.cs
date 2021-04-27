using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class ContactHelper : HelperBase
    {

        public ContactHelper(ApplicationManager manager) : base(manager)
        {

        }

        public ContactHelper CreateContact(ContactData contact)
        {
            manager.Navigator.GoToContactAddPage();
            FillContactForm(contact);
            SubmitContactAdding();
            manager.Navigator.ReturnToHomePage();
            return this;
        }

        public ContactHelper ModifyContact(ContactData contact)
        {
            FindContact(contact);
            InitContactModification();
            FillmofificationContactForm(contact);
            SubmitContactModification();
            manager.Navigator.ReturnToHomePage();
            return this;
        }

        public ContactHelper RemoveContact(int p, ContactData contact)
        {
            FindContact(contact);
            SelectContact(p);
            RemoveContact();
            manager.Navigator.ReturnToHomePage();
            return this;
        }

        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("middlename"), contact.Middlename);
            Type(By.Name("lastname"), contact.Lastname);
            Type(By.Name("nickname"), "Laime");
            driver.FindElement(By.XPath("(//input[@name='photo'])")).SendKeys("C:\\temp\\0_xMaFF2hSXpf_kIfG.jpg");
            Type(By.Name("nickname"), "Laime");
            Type(By.Name("title"), "New contact");
            Type(By.Name("company"), "New CO");
            Type(By.Name("address"), "Earth");
            driver.FindElement(By.Name("theform")).Click();
            Type(By.Name("home"), "885522");
            Type(By.Name("mobile"), "8952365124");
            Type(By.Name("work"), "41523452");
            Type(By.Name("fax"), "452452");
            Type(By.Name("email"), "1@1.com");
            Type(By.Name("email2"), "2@2.com");
            Type(By.Name("email3"), "3@3.com");
            Type(By.Name("homepage"), "123.net");
            driver.FindElement(By.Name("bday")).Click();
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("15");
            driver.FindElement(By.Name("bday")).Click();
            driver.FindElement(By.Name("bmonth")).Click();
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("August");
            driver.FindElement(By.Name("bmonth")).Click();
            Type(By.Name("byear"), "1985");
            driver.FindElement(By.Name("aday")).Click();
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("17");
            driver.FindElement(By.Name("aday")).Click();
            driver.FindElement(By.Name("amonth")).Click();
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("September");
            driver.FindElement(By.Name("amonth")).Click();
            Type(By.Name("ayear"), "2521");
            driver.FindElement(By.Name("new_group")).Click();
            new SelectElement(driver.FindElement(By.Name("new_group"))).SelectByText("Testmodify1");
            driver.FindElement(By.Name("new_group")).Click();
            Type(By.Name("address2"), "Here");
            driver.FindElement(By.Name("theform")).Click();
            Type(By.Name("phone2"), "Here");
            Type(By.Name("notes"), "Allright");
            return this;
        }

        public ContactHelper FindContact(ContactData contact)
        {
            if (ContactExist())
            {
                return this;
            }

            manager.Navigator.GoToContactAddPage();
            FillContactForm(contact);
            SubmitContactAdding();
            manager.Navigator.ReturnToHomePage();
            return this;
        }

        public bool ContactExist()
        {
            return IsElementPresent(By.Name("selected[]"));
        }

        public ContactHelper FillmofificationContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("middlename"), contact.Middlename);
            Type(By.Name("lastname"), contact.Lastname);
            return this;
        }

        public ContactHelper SubmitContactAdding()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            return this;
        }

        public ContactHelper InitContactModification()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.XPath("(//input[@name='update'])[2]")).Click();
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index+1) + "]")).Click();
            return this;
        }

        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept();
            return this;
        }

    }
}
