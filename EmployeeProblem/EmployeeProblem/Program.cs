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
                Console.WriteLine("Choose the option to perform the operation:-  1) Attendance \n 2) Salary of Employee\n 3) Employee status of working\n " +
                    "4) Switch\n 5) Monthly Salary\n " + "6) total working hours or days is reached for a month \n 7) Exit \n" +
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
                    case 3:
                        Parttime parttime = new Parttime();
                        parttime.Wage();
                        break;
                    case 4:
                        Usingswitch usingswitch = new Usingswitch();
                        usingswitch.Statement();
                        break;
                    case 5:
                        Monthly monthly = new Monthly();
                        monthly.Salary();
                        break;
                    case 6:
                        Condition condition = new Condition();
                        condition.Wage();
                        break;
                    case 7:
                        flag = false;
                        break;

                }
            }
        }
    }
}