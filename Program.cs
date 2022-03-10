using System;

namespace oopsobj
{
    /// <summary>
    /// contains main method
    /// </summary>
    class program
    {
        /// <summary>
        /// Displaying Greeting message
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage program");


            // employeecheck obj = new employeecheck();

            //Console.WriteLine("obj.employeecheck");

            //obj.Employeeaatendence();

            //employeewage obj = new employeewage();

            ////Console.WriteLine("obj.employeewage");

            //obj.Employeewages();


            //empswitch obj = new empswitch();

            ////Console.WriteLine(obj.empswitch);

            //obj.Employeeswitchcase();

            //calculatewages obj = new calculatewages();
            //obj.calculate_wage();

            //computewages obj = new computewages();
            //obj.wages();

            multiplecompany obj = new multiplecompany();
            obj.ComputeWages("DMART", 20, 2, 10);
            obj.ComputeWages("JIOMART", 20, 2, 10);






        }
    }

}
