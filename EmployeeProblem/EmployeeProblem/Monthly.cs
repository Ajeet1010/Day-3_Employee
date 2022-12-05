using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem
{
    public class Monthly
    {
        public const int isFulltime = 1;
        public const int isParttime = 0;
        public const int Hourwage = 20;
        public const int workmonth = 20;
        public void Salary()
        {
            int hourwage = 20;
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
            int totalwage = dailywage * workmonth;
            Console.WriteLine("daily wage is: " + dailywage);
            Console.WriteLine("Wages for a month: " + totalwage);
        }
    }
}
