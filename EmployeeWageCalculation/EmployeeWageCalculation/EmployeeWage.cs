using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
     public class EmployeeWage
    {
        //constant
        int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;
        //variables
        int empHrs = 0;
        int empWage = 0;
        Random random = new Random();
        public void Attendance()
        {
            //computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("employee1 is present");

            }
            else
            {
                Console.WriteLine("employee1 is present");
            }
        }
        public void DailyWage()
        {
            //computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Empwage: " + empWage);
            

        }

     }
}
