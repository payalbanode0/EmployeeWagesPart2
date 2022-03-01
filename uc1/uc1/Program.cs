using System;

namespace UC1
{
    class EmpPresent
    {
        public const int Present = 1;
        public static void empcheck()       
            {
                Random random = new Random();
                int check = random.Next(0, 2);
                if (check == Present)
                {
                    Console.WriteLine("Emp is Present");

                }
                else
                {
                    Console.WriteLine("Emp is Absent");
                }
            }        
        class program
        {
            static void Main(string[] args)

            {
                EmpPresent.empcheck();
                Console.Read();
            }
        }
    }
}
