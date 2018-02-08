using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParsingApp
{
    class string1
    {
        static void Main(string[] args)
        {
            string a, b, c, s = "100";
            bool success = false;
            int i, o;
            i = int.Parse(s);
            Console.WriteLine(i);
            a = "qwe";
            success = int.TryParse(a, out o);
            if (success)
            {
                Console.WriteLine(success + "  " + a);
            }
            else
            {
                Console.WriteLine("Not a valid integer " + success);
            }

        }
    }

    class charcasting
    {
        static void Main(string[] args)
        {
            //int n = 0;
            for (int i = 0; i < (256); i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}