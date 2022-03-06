using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsobj
{
    public class employeewage
    {
        public  void Employeewages()
        {
            int Full_Time = 1;
            int Part_Time = 2;
            int emp_rate_per_hour = 20;
            int emphrs = 0;
            int emp_wage = 0;

            Random random = new Random();
            int empcheck = random.Next(3);

            if (empcheck == Full_Time)
            {
                Console.WriteLine("employee is Present");
                emphrs = 8;

            }
            else if (empcheck == Part_Time)
            {
                Console.WriteLine("employee is working part time");
                emphrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                emphrs = 0;
            }

            emp_wage = emphrs * emp_rate_per_hour;
            Console.WriteLine("Emp wage :" + emp_wage);
        }
    }
        
    
}
