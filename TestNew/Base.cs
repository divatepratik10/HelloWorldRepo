using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNew
{
    class Programme
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World. Welcome to C#");
            Console.WriteLine("Enter your choice : \n1-Human  2-Swap Numbers  3-Reverse number \n4-Palindrome number  5-Replace Username  6-Simple Calculator\n7-Flip Coin  8-Table");
            int a = Convert.ToInt32(Console.ReadLine());

            switch(a)
            {
                case 1:
                    Human human = new Human();
                    human.speak(); 
                    break;
                case 2:
                    SwapNumbers swap = new SwapNumbers();
                    swap.SwapTwoNumbers();
                    break;
                case 3:
                    Reverse.FindReverse();
                    break;
                case 4:
                    Reverse.FindPalindrome();
                    break;
                case 5:
                    Username.ReplaceName();
                    break;
                case 6:
                    Switch.SimpleCalc();
                    break;
                case 7:
                    FlipCoin.flipCoinCount();
                    break;
                case 8:
                    Table.PrintTable();
                        break;
                default:
                    Console.WriteLine("Enter valid input 1-8");
                    break;

            }
            Console.ReadLine();
        }
    }
}
