using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNew
{
    class Username
    {
        public static void ReplaceName()
        {
            string line = "Hello <<UserName>>, How are you ?";
            Console.WriteLine("Enter username : ");
            string username = Console.ReadLine();
            Console.WriteLine("aftr replce\n"+line.Replace("<<UserName>>", username));
        }

    }
}
