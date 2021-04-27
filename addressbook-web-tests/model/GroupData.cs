using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
    public class GroupData : IEquatable<GroupData>, IComparable<GroupData>
    {
        private string name;

        public GroupData(string name)
        {
            this.name = name;
        }
// Добавляем 2 конструктор, для ввода значений (1ый не удаляем, для обратной совместимости и чтобы не сломался старый код)
       // public GroupData(string name, string header, string footer)
       // {
       //     this.name = name;
       //     this.header = header;
       //     this.footer = footer;
       // }
//Удалили 2 конструктор исправиви код в тесте
        public bool Equals(GroupData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            //return 0;//Если оптимизация сравнения не нужна
            return Name.GetHashCode();
        }

        public override string ToString()// override - переопределяет станджартную функцию
        {
            return "name=" + Name;
        }

        public int CompareTo(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return Name.CompareTo(other.Name);
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    
        private string header;

        public string Header
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
            }
        }

        private string footer;

        public string Footer
        {
            get
            {
                return footer;
            }
            set
            {
                footer = value;
            }
        }
    }
}
