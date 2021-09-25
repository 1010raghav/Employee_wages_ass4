using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_emp
{
    
    class UC5_CalculateWagesFor20DaysInMonth
    {
        //constant variables
        const int IS_PartTime = 1;
        const int IS_FullTime = 2;
        const int EmpPerHr = 20;
        const int No_of_Working_days = 20;

        public static void getAttendance()
        {
            //variables
            int EmpHr = 0;
            int EmpWages = 0;
            int EmpTotalWage = 0;

            for (int day = 0; day < No_of_Working_days; day++)
            {

                Random ran = new Random();
                int EmpCheck = ran.Next(0, 3);
                switch (EmpCheck)
                {
                    case IS_PartTime:
                        EmpHr = 4;
                        Console.WriteLine("Employee worked Full Day");
                        break;

                    case IS_FullTime:
                        EmpHr = 8;
                        Console.WriteLine("Employee worked Half Day");
                        break;

                    default:
                        EmpHr = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                EmpWages = EmpHr * EmpPerHr;
                Console.WriteLine("Total Employee Wage per day is  " + EmpWages + " Rs.");
                Console.WriteLine("*******************************************************************");
                EmpTotalWage += EmpWages;

            }
            Console.WriteLine("                   Total employee Wage for 20 days is " + EmpTotalWage + " Rs.");
        }
    }
}
