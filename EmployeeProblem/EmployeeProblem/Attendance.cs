using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem
{
    public class Attendance
    {
        public void Preabs()
        {
            int isPresent = 1;
            int isAbsent = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == isPresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
