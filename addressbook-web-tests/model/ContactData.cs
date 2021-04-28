using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string firstname;

        public ContactData(string firstname)
        {
            this.firstname = firstname;
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        private string middlename;

        public string Middlename
        {
            get
            {
                return middlename;
            }
            set
            {
                middlename = value;
            }
        }

        private string lastname;

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public bool Equals(ContactData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Firstname == other.Firstname && Middlename == other.Middlename;
        }

        public override int GetHashCode()
        {
            //return 0;//Если оптимизация сравнения не нужна
            return Firstname.GetHashCode();
            return Middlename.GetHashCode();
        }

        public override string ToString()// override - переопределяет стандартную функцию
        {
            return "firstname=" + Firstname;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return Firstname.CompareTo(other.Firstname);
        }

    }
}
