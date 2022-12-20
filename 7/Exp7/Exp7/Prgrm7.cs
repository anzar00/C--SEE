using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp7
{
    class Prgrm7
    {
        public static void Main(string[] args)
        {
            class7 obj = new class7();
            obj.rollnumber = -10;
            obj.printvalue();
            obj.setvalue(5);
            obj.printvalue();
        }

        class class7
        {
            private int _rollnumber; // cannot use outside class
            public int rollnumber // bcoz of property can use roll number outside
            {
                get { return _rollnumber; }
                set { _rollnumber = value; }
            }
            public void printvalue()
            {
                int i = rollnumber;
                Console.WriteLine(i);
            }
            public void setvalue(int rollnumber)
            {
                this.rollnumber = rollnumber;
            }
        }
    }
}
