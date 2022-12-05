using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem
{
    public class Wage
    {
        public void Salary()
        {
            int Hourwage = 20;
            Console.WriteLine("Enter the no of hours employee worked");
            int work = Convert.ToInt32(Console.ReadLine());
            int wage = work * Hourwage;
            Console.WriteLine("Employee daily wage : " + wage);
        }
    }
}
