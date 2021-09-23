using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_emp
{
    class UC2_EmpAttWages
    {
        public static void getAttendance()
        {
           
            int empAtt = 1;
            int emp_rate_per_hr = 100;

            //variable
            int emp_hr = 0;
            int emp_wage = 0;

            //random function
            Random ran = new Random();
            int empCheck = ran.Next(0, 2);
            {
                //compare
                if (empCheck == empAtt)
                {
                    Console.WriteLine("Employee is Present");
                    emp_hr = 8;

                }
                else
                {
                    Console.WriteLine("Employee is Absent");
                    emp_hr = 0;
                }
                emp_wage = emp_hr * emp_rate_per_hr;
                Console.WriteLine("total employee wage per day is " + emp_wage);

            }
        }
    }
}
