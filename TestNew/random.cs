using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNew
{
    class FlipCoin
    {
        public static void flipCoinCount()
        {
            int tail = 0, head = 0;
            Random r = new Random();
            Console.WriteLine("Enter number of times to flip coin : ");
            int times = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= times; i++)
            {
                double Input = r.NextDouble();
                if (Input < 0.5)
                {
                    tail++;
                }
                else
                    head++;
                Console.WriteLine("Tail-Count : {0}  Head-count : {1}", tail, head);
            }
            double tailpercent = (tail * 100) / times;
            double headpercent = (head * 100) / times;
            Console.WriteLine("\nTail percent : {0}  Head percent : {1}",tailpercent, headpercent);
        }
    }
}
