﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
     public class EmployeeWage
     {
        //constant
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
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
        public void EmployeePartTime()

        {
            //computation
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;

            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;

            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage:" + empWage);


        }
        public void PartOrFullTIme()
        {
             
            //computation
            int empCheck = random.Next(0, 3);

            switch (empCheck)

            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;

                case IS_FULL_TIME:
                    empHrs = 8;
                    break;

                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("EmpWage" + empWage);
        }

    }
}
