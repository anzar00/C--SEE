using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp6
{
    class Prgrm6
    {
        public static void Main()
        {
            double esalary = 200.00;
            double startingWage = 800.00;
            Console.WriteLine("Demonstrating some raises ");
            salary.predictRaise(400.00);
            salary.predictRaise(esalary);
            salary.predictRaise(startingWage);
        }
    }
    public static class salary
    {
        public static void predictRaise(double salary)
        {
            double newSalary;
            const double raiseRate = 1.65f;
            newSalary = salary * raiseRate;
            Console.WriteLine("Currently salary: " + salary + " After raise: " + newSalary);
        }
    }
}
