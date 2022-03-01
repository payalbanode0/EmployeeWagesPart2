
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2
{
    class EmployeeDailyWage
    {
        public const int full_time = 1;
        public const int emp_per_hour_wages = 20;
        public static void ComputeWage()
        {

            int empHour = 0;
            int empWage = 0;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == full_time)
            {
                empHour = 8;

            }
            else
            {
                empHour = 8;
            }
            empWage = empHour * emp_per_hour_wages;

            Console.WriteLine("Employee Daily Wages : " + empWage);

        }
        class program
        {
            static void Main(string[] args)

            {
                EmployeeDailyWage.ComputeWage();
                Console.Read();
            }
        }
    }
}