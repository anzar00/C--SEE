using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp1
{
    public class Prgrm1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.ReadKey();
            Prgrm1a.Main(new string[] { });

            float var1 = (float)100.99;
            double var2 = 100.0;

            Console.WriteLine("Var1 value is - " + var1);
            Console.WriteLine("Var2 value is - " + var2);
        }
    }
}
