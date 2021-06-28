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
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            //Creating a Random Function
            int empHours = 0;
            int empDailyWage = 0;
            int workingDays = 1;
            int workingHrs = 0;
            int totalWage = 0;

            Random r = new Random();
           
            while(workingDays<=MAX_WORKING_DAYS && workingHrs<=MAX_WORKING_HRS)
            {
                //Calling the next method in Random Class
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
            workingHrs += empHours;
                if (empAttendance != 0)
                {
                    workingDays++;
                }
        }
            Console.WriteLine("Working days in a month :" + workingDays);
            Console.WriteLine("Working Hours :" + workingHrs);
            //Console.WriteLine("Employee Wage Per day :" + empDailyWage);
           // Console.WriteLine("Employee Wage for 20 working days :" + totalWage);
        }
    }
}

