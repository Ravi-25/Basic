using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStudent
{
    public class Student
    {
        public String Name { get; set; }
        public int Roll_Number { get; set; }
        public float Percentage { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n, j = 0, roll;
                string name;
                float percentage;

                Console.WriteLine("Enter the number of student's details to be inserted");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out n))
                    {
                    }
                    if ((n <= 0) || (n>100))
                    {
                        Console.WriteLine("Enter an valid integer greater than 0 and less than 100");
                    }
                    if ((n <= 100) && (n > 0)) { break; }
                }
                Student[] students = new Student[100];
                for (int i = 0; i < n; i++)
                {
                    students[i] = new Student();
                    Console.WriteLine("Enter Roll number of {0}th student", i + 1);

                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out roll))
                        {
                        }
                        if (roll <= 0)
                        {
                            Console.WriteLine("Enter an valid integer greater than 0 and less than 100");
                        }
                        else { students[i].Roll_Number = roll; break; }
                    }

                    Console.WriteLine("Enter Name of {0}th student", i + 1);

                    while (true)
                    {
                        name = Console.ReadLine();
                        if (name == "" || name.Length > 20 || string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("Name cannot be empty or spaces or and cannot be greater than 20 charecters");
                        }
                        else if (name != "")
                        {
                            foreach (char item in name)
                            {
                                if (/*char.IsDigit(item) || char.IsSymbol(item) ||*/! char.IsLetter(item))
                                {
                                    Console.WriteLine("Digits and special Chars are not allowed in name");
                                    Console.WriteLine("Please enter a correcct name");
                                    //name = Console.ReadLine();
                                    j = 1;
                                    break;
                                }
                                else { j = 0; }
                            }
                        }
                        if (j == 0) { students[i].Name = name; break; }
                    }

                    Console.WriteLine("Enter Percentage of {0}th student", i + 1);
                    
                    while (true)
                    {
                        if (float.TryParse(Console.ReadLine(), out percentage))
                        {
                        }
                        if (percentage == 0)
                        {
                            Console.WriteLine("Enter an valid decimal greater than 0 and less than 100");
                        }
                        if ((percentage < 0) || (percentage > 100))
                        {
                         Console.WriteLine("Percentage must be betweeen 0 to 100");
                        }
                         if((percentage > 0) && (percentage <= 100))
                        {
                            students[i].Percentage = percentage; break;
                        }
                    }

                    using(SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "insert into tblstudent(rollno, name, percentage) values('" + students[i].Roll_Number + "','" + students[i].Name + "','" + students[i].Percentage + "')";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("----------------------One Row inserted sucessfully-----------------");
                    }
                }
                    Console.WriteLine("Details of Students\n\n");

                //for (int i = 0; i < n; i++)
                //{
                // Console.WriteLine("Name: {0}\tRollNo: {1}\tPercentage: {2}", students[i].Name, students[i].Roll_Number, students[i].Percentage);
                //}

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Select * from tblStudent";//"insert into tblstudent(rollno, name, percentage) values('" + students[i].Roll_Number + "','" + students[i].Name + "','" + students[i].Percentage + "')";
                    cmd.Connection = con;
                    con.Open();

                    SqlDataReader Reader= cmd.ExecuteReader();

                    DataTable DT = new DataTable();
                    DT.Columns.Add("RollNo");
                    DT.Columns.Add("Name");
                    DT.Columns.Add("Percentage");

                    Console.WriteLine("ROLL No  NAME       \t  PERCENTAGE  ");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------");
                    
                    int i = 0;
                    while(Reader.Read())
                    {
                        DataRow DR = DT.NewRow();// DataRow();

                        DR["RollNo"] = Reader["RollNo"];
                        DR["Name"] = Reader["Name"];
                        DR["Percentage"] = Reader["Percentage"];

                        DT.Rows.Add(DR);
                        for (int k  = 0; k <= 2; k ++)
                        {
                            Console.Write(DT.Rows[i][k].ToString()+"\t");
                        }
                        Console.WriteLine();
                        i++;
                    }
                    //DT.Rows[0].ToString();
                }

                Console.ReadKey();
            }

            catch (SqlException ex)
            {
                if (ex.Message.StartsWith("Violation of PRIMARY KEY Constraint"))
                {
                    Console.WriteLine(ex.Number+"  Duplicate roll number not allowed\n\n\n\n ----------PLEASE TRY AGAIN---------------");
                    //Console.ReadKey();
                }
                else { Console.WriteLine(ex.Number +" "+ex.Message+ "\n\n\n\n ----------PLEASE TRY AGAIN---------------"); }

                Console.ReadKey();
            }
        }
    }
}