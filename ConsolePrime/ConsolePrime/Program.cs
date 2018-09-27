using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string str = Console.ReadLine();
            int i = Convert.ToInt32(str);
            int j = 0;
            for( j=2;j<=i;j++)
            {
                if((i%j==0)&&(i==j))
                {
                    Console.WriteLine("Is a Prime Number");break;
                }
                else { if (i%j==0) break; }
            }
            if (i!=j)
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadKey();
        }
    }
}
