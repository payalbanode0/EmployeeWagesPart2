
using System;
namespace UC5
{
    class EmployeeDailyWage
    {
        public const int part_time = 1;
        public const int full_time = 2;
        public const int emp_per_hour_wages = 20;
        public const int Working_days = 5;

        public static void ComputeWage()
        {
            int empHour = 0;
            int empWage = 0;
            int empTotalMonthWage = 0;
            Random random = new Random();
            for (int i = 0; i < Working_days; i++)
            {
                int check = random.Next(0, 3);
                switch (check)
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

                empTotalMonthWage += empWage;
                Console.WriteLine("Emp Hours : " + empHour);
                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("emp Month Wage : " + empTotalMonthWage);
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
