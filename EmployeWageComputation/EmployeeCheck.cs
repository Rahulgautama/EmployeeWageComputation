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
            int empHour = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck =random.Next(2);
            if (empCheck == Is_Full_Time)
            {
                empHour = 8;
            }
            else {
                empHour = 0;
            }
            empWage = empHour * EMP_RAT_PER_HOUR;
            Console.WriteLine("Employee Wage :"+empWage);
        }
    }
}
