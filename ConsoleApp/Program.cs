using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            var Name = Console.ReadLine();
            var Date = DateTime.Now;
            Console.WriteLine($"Hello , {Name} on {Date:d} at {Date:t}!");
            //Console.WriteLine(Date);
            Console.WriteLine("Thats all");
            Console.ReadLine();
        }
    }
}
