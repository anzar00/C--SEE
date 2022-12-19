using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp3
{
    class Prgrm3
    {
        public static void Main(string[] args)
        {
            int num = 2020;
            Console.WriteLine("Value of num is - {0}", num);
            Object obj = num;
            Console.WriteLine("Value of obj is - {0}", obj);
            num = 100;
            Console.WriteLine("Value of num is - {0}",num);
            Console.WriteLine("Value of obj is - {0}", obj);

            int num1 = 23;

            Object obj1 = num1;

            int i = (int)obj1;

            Console.WriteLine("Value of obj1 is - {0}", obj1);
            Console.WriteLine("Value of i is - {0}", i);

        }
    }
}
