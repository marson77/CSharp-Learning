using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
    public class GroupData
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
