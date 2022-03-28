using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNew
{
    class Reverse
    {
        public int FindReverse()
        {
            int reverse = 0, remainder = 0;
            Console.Writeline("Enter number to reverse : ");
            int number = Convert.ToInt32(Console.Readline());

            while(number > 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;

            }
        }
    }
}
