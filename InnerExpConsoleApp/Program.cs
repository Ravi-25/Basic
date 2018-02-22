using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InnerExpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Please enter the first number");
                    int FN = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the second number");
                    int SN = int.Parse(Console.ReadLine());

                    int result = FN / SN;

                    Console.WriteLine("FN/SN = {0}", result.ToString());

                }
                catch (Exception ex)
                {
                    string filepath = @"C:\Users\RAVI\Documents\Log.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter sw = new StreamWriter(filepath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("There was an error, Please see {0} for LOG", filepath);
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + " Not Present", ex);
                    }
                }
            }
            catch(Exception Inex)
            {
                Console.WriteLine("The CCurrent Exxception is : {0}",Inex.GetType().Name);
                Console.WriteLine("The Inner Exception is : {0}",Inex.InnerException.GetType().Name);
            }
        }
    }
}
