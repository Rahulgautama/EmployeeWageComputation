using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeWageComputation
{
    class EmployeeCheck
    {
        public static void EmployeeAttendance()
        {
            int EMP_RAT_PER_HOUR = 20;
            int Is_Full_Time = 1;
            int IS_PART_Time = 2;
            int empHour = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck =random.Next(3);
            if (empCheck == Is_Full_Time)
            {
                empHour = 8;
            }
            else if (empCheck == IS_PART_Time)
            {
                empHour = 4;
            }
            else 
            {

                empHour = 0;
            }
            empWage = empHour * EMP_RAT_PER_HOUR;
            Console.WriteLine("Employee Wage :"+empWage);
        }
    }
}
