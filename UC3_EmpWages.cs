using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_emp
{
    class UC3_EmpWages
    {
        public static void getAttendance()
        {

            //constant variables

            int IS_PartTime = 1;
            int IS_FullTime = 2;
            int EmpPerHr = 20;

            //variables
            int EmpHr = 0;
            int EmpWages = 0;

            Random ran = new Random();
            int EmpCheck = ran.Next(0, 3);

            if (EmpCheck == IS_PartTime)
            {
                EmpHr = 4;
                Console.WriteLine("Employee worked half day");
            }
            else if (EmpCheck == IS_FullTime)
            {
                EmpHr = 8;
                Console.WriteLine("Employee worked full day");
            }
            else
            {
                EmpHr = 0;
                Console.WriteLine("Employee is Absent");
            }

            EmpWages = EmpHr * EmpPerHr;
            Console.WriteLine("Employee's total wage per day is  " + EmpWages + " Rs.");
        }
    }
}
