using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_emp
{
    class UC1_EmpAttendance
    {
        public static void Attendance()
        {


            Random ran = new Random();
            int empCheck = ran.Next(0, 2);

            if (empCheck == 1)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");

        }

    }
}

