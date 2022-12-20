using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp10
{
    class Prgrm10
    {
        public int number = 0;

        // no-argument constructor
        public Prgrm10() { }


        // parameterized constructor
        public Prgrm10(int n)
        {
            number = n;
        }
        // Overloading of Binary "+" operator
        public static Prgrm10 operator +(Prgrm10 Calc1, Prgrm10 Calc2)
        {
            Prgrm10 Calc3 = new Prgrm10(0);
            Calc3.number = Calc2.number + Calc1.number;
            return Calc3;
        }

        // function to display result
        public void display()
        {
            Console.WriteLine("{0}", number);
        }
    }
    class CalNum
    {

        // Driver Code
        static void Main(string[] args)
        {

            Prgrm10 num1 = new Prgrm10(200);
            Prgrm10 num2 = new Prgrm10(40);
            Prgrm10 num3 = new Prgrm10();
            num3 = num1 + num2;
            num1.display(); // Displays 200
            num2.display(); // Displays 40
            num3.display(); // Displays 240

        }

    }
}
