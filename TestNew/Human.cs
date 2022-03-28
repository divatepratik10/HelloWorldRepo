using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNew
{
    class Human
    {
        public string Name = "Pat", Address = "KWD";
        public double Height = 5.34;
        public int Age = 24;

        public void speak()
        {
            Console.WriteLine("He/She can talk.");
            Console.WriteLine("Name : {0} Address : {1} Height : {2} Age : {3}", Name, Address, Height, Age);
        }
    }
}
