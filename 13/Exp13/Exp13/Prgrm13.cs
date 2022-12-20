using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exp13.Prgrm13;

namespace Exp13
{
    class Prgrm13
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public void sum(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        public void subtract(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        public static void Main(string[] args)
        {
            Prgrm13 obj = new Prgrm13();

            addnum del_obj1 = new addnum(obj.sum);
            subnum del_obj2 = new subnum(obj.subtract);

            del_obj1(100, 40);
            del_obj2(100, 60);

            del_obj1.Invoke(100, 50);
            del_obj2.Invoke(100, 50);
        }
    }
}


       