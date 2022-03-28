using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNew
{
    class Reverse 
    {
        static int number;
        public static int FindReverse()
        {
            int reverse = 0, remainder = 0;
            Console.WriteLine("Enter number to reverse : ");
            number = Convert.ToInt32(Console.ReadLine());
            while(number > 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reversed number is : "+reverse);
            return reverse;
        }

        public static void FindPalindrome()
        {
            int palindrome = FindReverse();
            if (palindrome == number)
            {
                Console.WriteLine("Entered number is Palindrome.");
            }
            else
                Console.WriteLine("Entered number is not Palindrome.");
        }

    }

}