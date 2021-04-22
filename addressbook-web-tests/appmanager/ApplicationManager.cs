﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupsHelper groupsHelper;
        protected LogoutHelper logoutHelper;
        protected ContactHelper contactHelper;
        private static ApplicationManager instance;

        private ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost";

            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this, baseURL);
            groupsHelper = new GroupsHelper(this);
            logoutHelper = new LogoutHelper(this);
            contactHelper = new ContactHelper(this);
        }

        public static ApplicationManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ApplicationManager();
            }
            return instance;
        }



        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }

        }

        public GroupsHelper Groups
        {
            get
            {
                return groupsHelper;
            }
        }

        public LogoutHelper Logout
        {
            get
            {
                return logoutHelper;
            }

        }
        public ContactHelper Contacts
        {
            get
            {
                return contactHelper;
            }

        }
    }
}
