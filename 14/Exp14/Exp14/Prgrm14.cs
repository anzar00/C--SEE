using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp14
{
    public delegate void DelEventHandler();
    class Prgrm14
    {
        public static event DelEventHandler add;

        static void Main(string[] args)
        {
            add += new DelEventHandler(USA);
            add += new DelEventHandler(India);
            add += new DelEventHandler(England);
            add += new DelEventHandler(Add);

            add.Invoke();

            Console.ReadLine();
        }

        static void USA()
        {
            Console.WriteLine("USA");
        }

        static void India()
        {
            Console.WriteLine("India");
        }

        static void England()
        {
            Console.WriteLine("England");
        }

        static void Add()
        {
            Console.WriteLine("Enter a :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a,b,a+b);
        }
    }
}
