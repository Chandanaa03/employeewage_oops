using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsobj
{
    public class computewages
    {
        int Full_Time = 1;
        int Part_Time = 2;
        int total_working_days = 0;
        int emp_rate_per_hour = 20;

        int emp_wage = 0;
        int max_work_days = 20;
        int Total_working_hours = 100;
        int num_work_days = 2;
        int max_hrs_in_month = 10;

        public int wages()
        {
            int emphrs = 0;
            int totalemphrs = 0;


            while (totalemphrs <= max_hrs_in_month && total_working_days < num_work_days)
            {
                total_working_days++;

                Random random = new Random();
                int empcheck = random.Next(0, 3);
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

                    default:
                        emphrs = 0;
                        break;
                }
                totalemphrs = totalemphrs + emphrs;
                Console.WriteLine("day#:" + total_working_days + "emp hrs:" + emphrs);
            }
            int totalEmpwage = totalemphrs * emp_rate_per_hour;
            Console.WriteLine("total emp wage:" + totalEmpwage);
            return totalEmpwage;


        }
    }
}




               


