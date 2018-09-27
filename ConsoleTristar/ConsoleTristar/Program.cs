using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTristar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter 'n' :");
            string str = args[0];//Console.ReadLine();
            int n = Convert.ToInt32(str);
            int i, j;
            for (i = 1; i <= n; i++)
            {
                for (j = i; j > 0; j--, Console.Write("*"))
                {
                    //Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

    class program1
    {
        public static void Main(string[] args)
        {
            int number, i, k, count = 1;
            Console.Write("Enter number of rows\n");
            number = int.Parse(args[0]);
            count = number - 1;
            for (k = 1; k <= number; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

    class Palll
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            //str.Reverse;
            char temp;
            for (int j=arr.Length-1,i = 0;i < arr.Length/2; j--,i++)
            {
                temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k]);
            }
            //Console.WriteLine(str);
            Console.ReadKey();
        }
    }

    class ArrII
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of names to be entered :");
            int n = int.Parse(Console.ReadLine());
            string [] Sarr=new string [n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter {0}th Name", i + 1);
                Sarr[i]=Console.ReadLine();
            }
            Array.Sort(Sarr);
            Console.WriteLine("Names in Sorted order are :");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Sarr[i].ToString());
                //Sarr[i] = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }

    public class Stu
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter the number of Students to be Entered :");
                int n;
                N: if (int.TryParse(Console.ReadLine(), out n)) { }
                else { Console.WriteLine("Enter a valid integer "); goto N; }
                if (n<=0){ Console.WriteLine("Enter an integer greater than 0 ");goto N; }

                Student [] students = new Student [100];
            
                for (int i = 0; i < n; i++)
                {
                    students[i] = new Student();
                    Console.WriteLine("Enter Name of  {0}th student", i + 1);
                    NAME: string name= Console.ReadLine(); ;
                    if ((String.IsNullOrWhiteSpace(name))) { Console.WriteLine("Please enter a vaalid Name "); goto NAME; }
                    else { students[i].Name = name; }
                    int roll;
                    Console.WriteLine("Enter RollNo of  {0}th student", i + 1);
                    ROLL: if (int.TryParse(Console.ReadLine(), out roll))
                    {
                        students[i].Roll_Number = roll;
                        //int.Parse(Console.ReadLine());
                    }
                    else { Console.WriteLine("Enter a valid integer "); goto ROLL; }
                    if (roll <= 0) { Console.WriteLine("Enter an integer greater than 0 "); goto ROLL; }
                    float per;
                    Console.WriteLine("Enter Percentage of  {0}th student. Percantage must be between 0 to 100", i + 1);
                    PER: if (float.TryParse(Console.ReadLine(), out per))
                    {
                        if ((per < 0) || (per > 100)) { Console.WriteLine("Percentage must be betweeen 0 to 100"); goto PER; }
                        else { students[i].Percentage = per; }
                    }
                    else { Console.WriteLine("Enter a valid Percentage "); goto PER; }
                    if (per <= 0) { Console.WriteLine("Enter an decimal greater than 0 "); goto PER; }
                }
                Console.WriteLine("Details of Students");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Name: {0}\tRollNo: {1}\tPercentage: {2}", students[i].Name, students[i].Roll_Number, students[i].Percentage);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message+"\n\n\n\n----------Please try Again------------");
            }
            Console.ReadKey();
        }
    }
    public class Student
    {
        public String Name{ get; set; }
        public int Roll_Number { get; set; }
        public float Percentage { get; set; }
    }
}
