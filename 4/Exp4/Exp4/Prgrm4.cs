using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp4
{
    class Prgrm4
    {
        public static void Main(string[] args)
        {
            int n = 2;
            for(int i =1; i<=10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                else if (i == 8)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        Console.WriteLine("2 * " + i + " = " + n * i);
                    }
                }
                else
                {
                    Console.WriteLine("2 * " + i + " = " + n * i);
                }
            }
        }
    }
}
