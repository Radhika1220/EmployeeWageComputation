using System;

namespace EmployeeWageComputationPro
{
    class Program
    {
        //Declaring Constant Variable
        public const int FULL_TIME = 1;
        public const int WAGE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            //Creating a Random Function
            int empHours = 0;
            int empDailyWage = 0;
            Random r = new Random();
            int empAttendance = r.Next(0, 2);
            if (empAttendance == FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHours = 8;

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}

