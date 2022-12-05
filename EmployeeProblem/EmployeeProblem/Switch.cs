using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem
{
    public class Usingswitch
    {
        public const int isFulltime = 1;
        public const int isParttime = 2;
        public const int Hourwage = 20;
        public void Statement()
        {

            int emphrs = 0;
            Random random = new Random();
            int empwage = random.Next(2);
            switch (empwage)
            {
                case isFulltime:
                    Console.WriteLine("Full time employee");
                    emphrs = 8;
                    break;
                case isParttime:
                    Console.WriteLine("part time employee");
                    emphrs = 4;
                    break;
            }
            int dailywage = emphrs * Hourwage;
            Console.WriteLine("daily wage is: " + dailywage);
        }
    }
}
