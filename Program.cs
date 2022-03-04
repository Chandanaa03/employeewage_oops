using System;

namespace 
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
        static void Main (string[] args)
        {
            Console.WriteLine("Welcome to employee wage program");
            //employeecheck.Employeeattendence();

            //empwage.Employeewages();

            //empswitch.Employeeswitchcase();

            //maxworkingday.workingday();
            //calculatewages.calculate_wage();

            employeecheck obj = new employeecheck();

            //obj.calculate_wage();
            obj.Employeeattendence();


            
        }
}

}
