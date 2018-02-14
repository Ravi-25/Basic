using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, j=0, ft = 10, sd = 6, sum = 0, product = 0;
            int[] num = new int[] { 5, 6, 7, 8, 9 ,10};
            value(i);
            Console.WriteLine(i);
            Refer(ref i);
            Console.WriteLine(i);
            out1(out sum, out product, ft, sd);
            Console.WriteLine("Sum: {0}" + " " + "Product: {1}", sum, product);
            params1(num);
        }
        static void value(int j)
        {
            j = 102;
        }
        static void Refer(ref int j)
        {
            j = 102;
        }
        static void out1(out int sum, out int product, int ft, int sd)
        {
            sum = ft + sd;
            product = ft * sd;
        }
        static void params1(params int[] num)
        {
            Console.WriteLine("Length of array is {0}",num.Length);
            Console.WriteLine("The members of the array are");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
