using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeWageComputation
{
    class EmployeeCheck
    {
        public static void EmployeeAttendance()
        {

            int Is_Full_Time = 1;
            Random random = new Random();
            int empCheck =random.Next(2);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Empoyee is Present");
            }
            else {
                Console.WriteLine("Empoyee is Absent");
            }
        }
    }
}
