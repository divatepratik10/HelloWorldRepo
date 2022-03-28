using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNew
{
    class Switch
    {
        public static void SimpleCalc()
        {
            int a, b;
            Console.WriteLine("Welcome to Simple CALCULATOR\nenter TWO number : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your choice : 1-add  2-sub  3-mult  4-sub");
            int n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:
                    int d = a + b;
                    Console.WriteLine("result = " + d);
                    break;
                case 2:
                    d = a - b;
                    Console.WriteLine("result = " + d);
                    break;
                case 3:
                    d = a * b;
                    Console.WriteLine("result = " + d);
                    break;
                case 4:
                    d = a / b;
                    Console.WriteLine("result = " + d);
                    break;
                default :
                    Console.WriteLine("Enter valid input 1-4");
                    break;
            }

        }
    }
}
