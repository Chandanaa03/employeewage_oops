using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsobj
{
    public class multiplecompany
    {
        int PART_TIME=1;
        int FULL_TIME = 2;
        public int ComputeWages(string company,int emprateperhour, int numofworkingdays,int maxhrspermonth)
        {
            int emphrs = 0, totalemphrs = 0, totalworkingdays = 0;

            while (totalemphrs <= maxhrspermonth && totalworkingdays < numofworkingdays)
            {
                totalworkingdays++;

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
                Console.WriteLine("day#:" + totalworkingdays + "emp hrs:" + emphrs);
            }
            int totalEmpwage = totalemphrs * emprateperhour;
            Console.WriteLine("total emp wage:" + totalEmpwage);
            return totalEmpwage;
        }
    }
}
