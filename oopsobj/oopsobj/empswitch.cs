using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsobj
{
    public  class empswitch
    {
       
        public  void Employeeswitchcase()
        {

            int emp_rate_per_hour = 20;
            int emphrs = 0;
            int emp_wage = 0;


            Random random = new Random();
            int empcheck = random.Next(3);

            switch (empcheck)
            {
                case 1:
                    Console.WriteLine("Employee is working Full_Time");
                    emphrs = 8;
                    break;

                case 2:
                    Console.WriteLine("employee is working part time");
                    emphrs = 4;
                    break;

                case 3:
                    Console.WriteLine("Employee is absent");
                    emphrs = 0;
                    break;



            }
            emp_wage = emphrs * emp_rate_per_hour;
            Console.WriteLine("Emp wage :" + emp_wage);
        }
    }
}
    
