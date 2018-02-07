using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUnicodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = '☺';
            for (int i=0;i<128;i++,ch++)
            {
                Console.Write("{0} ", Convert.ToChar(i));
            }
            Console.WriteLine();
        }
    }
}
