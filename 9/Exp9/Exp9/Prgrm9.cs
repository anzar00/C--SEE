using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp9
{
    class Prgrm9
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            string[] arr1 = new string[5];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("please enter array elements " + arr1[i]);
                arr1[i] = Console.ReadLine();
            }
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            int[] arr2 = new int[5];
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("please enter array elements ");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }

    }
}
