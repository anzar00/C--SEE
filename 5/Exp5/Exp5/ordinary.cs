using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp5
{
    class ordinary
    {
        public static void Main(string[] args)
        {
            student s = new student();

            Console.WriteLine(s.name);
            s.enterstudentdetails();
            Console.WriteLine(s.name);
            Console.ReadKey();
        }
    }

    class student
    {
        public int rollnumber;
        public string name;
        public bool isactive;
        public student returnstudentdetails()
        {
            return this;
        }

        public student enterstudentdetails(string s)
        {
            name = s;
        }
    }
}
