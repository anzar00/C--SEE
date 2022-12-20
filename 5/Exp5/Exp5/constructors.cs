using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp5
{
    class constructors
    {
        public static void Main(string[] args)
        {
            student1 s1 = new student1();

            Console.WriteLine(s1.getstudentdetails1().rollnumber);

            Console.WriteLine(s1.getstudentdetails());

            Console.ReadKey();
        }
    }
    class student1
    {
        public int rollnumber;
        public string name;
        public bool isactive;
        public student1()
        {
            rollnumber = 101;
            name = "priya";
            isactive = true;
        }
        public student1 returnstudentdetails()
        {
            return this;
        }
        public string getstudentdetails()
        {
            return name;
        }
        public student1 getstudentdetails1()
        {
            return this;
        }

    }

}
