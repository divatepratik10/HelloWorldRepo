using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int EMP_FULLTIME_PRESENT = 1, EMP_PARTTIME_PRESENT = 2, EMP_ABSENT = 0;
            const int DAILY_WAGE = 20;
            int DAILY_HOURS = 0;
            int EMP_WAGE = 0;
            int EMP_WORKINGDAY_MONTH = 20;
            int day;
            int TOTAL_WAGE;
           
            for (day = 1; day <= EMP_WORKINGDAY_MONTH; day++) ;
            {
                Random r = new Random();
                int EMP_INPUT = r.Next(0, 3);

                switch (EMP_INPUT)
                {
                    case EMP_FULLTIME_PRESENT:
                        //Console.WriteLine("Daily Wage of Employee is Rs.{0}", DAILY_WAGE * 8);
                        //Console.WriteLine("Monthly Wage of Employee is Rs.{0}", (DAILY_WAGE * 8) * 20);
                        DAILY_HOURS = 8;
                        break;
                    case EMP_PARTTIME_PRESENT:
                        //Console.WriteLine("Daily Wage of Employee is Rs.{0}", DAILY_WAGE * 4);
                        //Console.WriteLine("Monthly Wage of Employee is Rs.{0}", (DAILY_WAGE * 4) * 20);
                        DAILY_HOURS = 4;
                        break;
                    case EMP_ABSENT:
                        //Console.WriteLine("Daily Wage of Employee is Rs.{0}", DAILY_WAGE * 0);
                        //Console.WriteLine("Monthly Wage of Employee is Rs.{0}", (DAILY_WAGE * 0) * 20);
                        DAILY_HOURS = 0;
                        break;
                    default:
                        Console.WriteLine("Something Went Wrong....");
                        break;
                }
                EMP_WAGE = EMP_WORKINGDAY_MONTH * DAILY_HOURS;
                Console.WriteLine("Daily Wage of Employee for Day{0} is Rs.{1}", day, EMP_WAGE);
            }
            TOTAL_WAGE = EMP_WAGE * EMP_WORKINGDAY_MONTH;
            Console.WriteLine("Monthly wage of Employee is : {0}", TOTAL_WAGE);
            Console.ReadLine();
        }
    }
}
