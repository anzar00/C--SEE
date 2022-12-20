using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp12
{
    class Prgrm12
    {
        static void Main(string[] args)
        {

            try
            {
                int num1, num2;
                decimal result;
                Console.WriteLine("Divide Program. You Enter 2 number and we return result");
                Console.WriteLine("Enter 1st Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                result = (decimal)num1 / (decimal)num2;
                Console.WriteLine("Divide : " + result.ToString());
                Console.ReadLine();
            }
            //Multiple Catch block to handle exception
            catch (DivideByZeroException)
            {
                Console.WriteLine("You have Entered 0");

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input");

            }
            //Finally block: it always executes
            finally
            {
                Console.WriteLine("Finally Block: For Continue Press Enter and for Exit press Ctrl + c");
                Console.ReadLine();
            }
        }
    }
}
