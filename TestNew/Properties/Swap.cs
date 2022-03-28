using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNew
{
    class SwapNumbers
    {
        public int first, second, temp=0;

        public void SwapTwoNumbers()
        {
            Console.WriteLine("Enter first number : ");
            first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers before swap ");
            Console.WriteLine("first : {0}  second : {1}",first,second);

            temp = first;
            first = second;
            second = temp;

            Console.WriteLine("NUmbers After Swap ");
            Console.WriteLine("first : {0}  second : {1}",first,second);

        }

    }
}
