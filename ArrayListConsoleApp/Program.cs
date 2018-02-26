using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Al = new ArrayList(10);
            Al.Add("One");
            Al.Add("Two");
            Al.Add("Three");
            Al.Add("Four");
            //Al.Add("Five");
            //Al.Insert(4, "One");
            Console.WriteLine("Capacity of Array List is " + Al.Capacity);
            Console.WriteLine(Al.Add("Five"));//returns index
            Al.TrimToSize();
            Console.WriteLine("Capacity of Array List is " + Al.Capacity);
            //Al.RemoveAt(4);//removes index 4 item
            foreach (string str in Al)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(Al[4]);
            Al.Remove("Five");
            Console.WriteLine("Capacity of Array List is " + Al.Capacity);
            foreach (string str in Al)
            {
                Console.WriteLine(str);
            }
            Al.TrimToSize();
            Console.WriteLine("Capacity of Array List is " + Al.Capacity);
            Al.Sort();
            foreach (string str in Al)
            {
                Console.WriteLine(str);
            }
            Al.Reverse();
            foreach (string str in Al)
            {
                Console.WriteLine(str);
            }
        }
    }
}
