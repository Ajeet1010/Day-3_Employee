using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem
{
    public class EmployeeProblem
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose the option to perform the operation:-  1) Attendance \n 2) Salary of Employee " +
                    "Enter the no to operate: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Attendance attendance = new Attendance();
                        attendance.Preabs();
                        break;
                    case 2:
                        Wage wage = new Wage();
                        wage.Salary();
                        break;

                }
            }
        }
    }
}