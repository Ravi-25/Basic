using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"C:\Users\RAVI\Documents\Downlods\Computer Name1.txt");
                Console.WriteLine(sr.ReadToEnd());
                //sr.Close();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please check if the file {0} Exist or not",ex.FileName);
                Console.WriteLine("\n\n\n");
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
                Console.WriteLine("\n\n\n Finally Block");
            }
        }
    }
}
