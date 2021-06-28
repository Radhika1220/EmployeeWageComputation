using System;

namespace EmployeeWageComputationPro
{
    class Program
    {
        //Declaring Constant Variable
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public const int WORKING_PER_MONTH = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            //Creating a Random Function
            int empHours = 0;
            int empDailyWage = 0;
            int totalWage = 0;

            Random r = new Random();
           
            for(int day = 1; day <= WORKING_PER_MONTH; day++) 
            {
                int empAttendance = r.Next(0, 3);
                switch (empAttendance)
              {
                case FULL_TIME:
                   // Console.WriteLine("Employee is present for full-time");
                    empHours = 8;
                    break;
                case PART_TIME:
                    //Console.WriteLine("Employee is present for part-time");
                    empHours = 4;
                    break;
                default:
                    //Console.WriteLine("Employee is absent");
                    break;

             }
            empDailyWage = empHours * WAGE_PER_HOUR;
            totalWage += empDailyWage;
        }
            Console.WriteLine("Employee Wage Per day :" + empDailyWage);
            Console.WriteLine("Employee Wage for 20 working days :" + totalWage);
        }
    }
}

