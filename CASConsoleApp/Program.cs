using System;
using System.Collections;
using System.Security.Policy;
using System.Reflection;

namespace SecTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load another assembly
            Assembly asb = Assembly.LoadFrom(@"C:\Users\RAVI\Documents\Basic\InheritanceConsoleApp\bin\Debug\InheritanceConsoleApp.exe");

            Console.WriteLine("***** Evidence Viewer *****\n");

            if (asb != null)
            {
                DisplayEvidence(asb);
            }
            Console.ReadLine();
        }

        private static void DisplayEvidence(Assembly asm)
        {
            // Get evidence collection using enumerator.
            Evidence e = asm.Evidence;
            IEnumerator obj = e.GetHostEnumerator();
            // Now print out the evidence.
            while (obj.MoveNext())
            {
                Console.WriteLine(" **** Press Enter to continue ****");
                Console.ReadLine();
                Console.WriteLine(obj.Current);
            }
        }
    }
}