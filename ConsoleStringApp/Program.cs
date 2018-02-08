using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                sb.Append("a");
                Console.WriteLine(sb.Length+" "+sb.Capacity);
                str += "A";
            }
            Console.WriteLine(str);
            Console.WriteLine(sb.ToString ());
        }
    }
}