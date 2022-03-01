
using System;

namespace UC4
{
    class EmployeeDailyWage
    {
        public const int part_time = 1;
        public const int full_time = 2;
        public const int emp_per_hour_wages = 20;

        public static void ComputeWage()
        {
            int empHour = 0;
            int empWage = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            switch(check)
            {
                case part_time:
                empHour = 4;
                break;
                case full_time:
                empHour = 8;
                break;
                default:
                    empHour = 0;
                break;
            }
            empWage = empHour * emp_per_hour_wages;

            Console.WriteLine("Emp Hours : " + empHour);
            Console.WriteLine("Emp Wage : " + empWage);

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
