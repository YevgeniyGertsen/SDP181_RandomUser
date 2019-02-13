using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Human
    {
        public Human()
        {

        }
        public Human(string someValue)
        {
            Console.WriteLine("");
        }

        public Human(string someValue, int y)
        {
            Console.WriteLine("");
        }

        protected string race { get; set; }
    }
}
