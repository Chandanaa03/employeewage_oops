using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewages_Day3
{
    public class employeecheck
    {
        public  void Employeeattendence()
        {
            int Full_Time = 1;

            Random random = new Random();
            int empcheck = random.Next(2);

            if (empcheck == Full_Time)
            {
                Console.WriteLine("employee is Present");

            }
            else
                Console.WriteLine("Employee is absent");
        }
    }
}
