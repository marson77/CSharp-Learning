using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
    class Square : Figure
    {
        //если не назначить размер, по умолчанию будет size = 0;
        // или можно так:
        //private int fSize;
        //
        //public Square(int size)
        //{
        //    fSize = size;
        //}
        
        private int size;

        public Square(int size)
        {
            this.size = size;
        }

        public int Size
        {
        get
        {
            return size;
        }
        set
        {
            size = value;
        }
            //Или можно так2
            //}
            //public int getSize()
            //{
            //    return fSize;
            //}
            //
            //public void setSize(int size) {
            //    fSize = size;
            //}
        }
    }
}
