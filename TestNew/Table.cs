using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNew
{
    class Table
    {
        public static void PrintTable()
        {
            Console.WriteLine("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                int j = i * number;
                Console.WriteLine("{0} x {1}  = {2}",number,i,j);
            }
            Console.ReadLine();
        }
    }
}
