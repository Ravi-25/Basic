using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsoleApp
{
    
    class Program
    {
        public static void printstring(string str)
        {
            Console.WriteLine(str);
        }
        public delegate void delprintstr(string str1);
        static void Main(string[] args)
        {
            delprintstr delprint = new delprintstr(printstring);
            delprint("Hello Delegates");
        }
    }
}
