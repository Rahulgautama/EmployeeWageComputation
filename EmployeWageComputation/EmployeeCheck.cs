using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeWageComputation
{
    class EmployeeCheck
    {
        
        public static void EmployeeAttendance()
        {
            int EMP_RATE_PER_HOUR = 20;            
            int empHour = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHour = 0;
            int totalWorkingDays = 0;
            int totalWorkingHours = 0;
            int  NUM_OF_WORKING_DAYS= 20;
            int  MAX_HRS_IN_MONTH = 100;
            Random rdm = new Random();

            while (totalWorkingDays < NUM_OF_WORKING_DAYS && totalWorkingHours < MAX_HRS_IN_MONTH)
            {
                totalWorkingDays++;
                int empCheck = rdm.Next(3);
                switch (empCheck)
                {
                    case 1:
                        empHour = 8;
                        break;
                    case 2:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                totalEmpHour += empHour;
                empWage = empHour * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
            }
            Console.WriteLine("Total Working Days: " + totalWorkingDays);
            Console.WriteLine("Total Working Hours: " + totalEmpHour);
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }
    }
}
