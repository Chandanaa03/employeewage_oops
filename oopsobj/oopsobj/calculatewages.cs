using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsobj
{
    public class calculatewages
    {
        public void calculate_wage()
        {
            int Full_Time = 1;
            int Part_Time = 2;
            int total_working_days = 0;
            int emp_rate_per_hour = 20;
            int emphrs = 0;
            int emp_wage = 0;
            int totalemphrs = 0;

            int max_work_days = 20;
            int Total_working_hours = 100;

            while (totalemphrs < Total_working_hours || total_working_days < max_work_days)
            {
                total_working_days++;

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

                totalemphrs = totalemphrs + emphrs;
                Console.WriteLine("totalhours :" + totalemphrs);
            }
        }
    }
}
