using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactAddingTests : AuthTestBase
    {
        [Test]
        public void ContactAddingTest()
        {
            ContactData contact = new ContactData("Maks")
            {
                Middlename = "Korj",
                Lastname = "Kripovyi"
            };

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.CreateContact(contact);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contact);//к старому списку добавляем нововсозданную группу
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }

        [Test]
        public void EmptyNameContactAddingTest()
        {
            ContactData contact = new ContactData("")
            {
                Middlename = "",
                Lastname = ""
            };

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.CreateContact(contact);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contact);//к старому списку добавляем нововсозданную группу
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
