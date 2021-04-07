using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    class ContactCreating : TestBase
    {
        [Test]
        public void TheContactCreatingTest()
        {
            ContactData contact = new ContactData("Maks")
            {
                Middlename = "Korj",
                Lastname = "Kripovyi"
            };

            app.Contacts.Create(contact);
            app.Logout.LogOut();
        }

        [Test]
        public void EmptyContactCreatingTest()
        {
            ContactData contact = new ContactData("")
            {
                Middlename = "",
                Lastname = ""
            };

            app.Contacts.Create(contact);
            app.Logout.LogOut();
        }
    }
}
