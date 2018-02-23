using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListConsoleApp
{
    public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Sal { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee() { Id = 100, Name = "Ravi1", Sal = 10000 };
            Employee e2 = new Employee() { Id = 101, Name = "Ravi2", Sal = 20000 };
            Employee e3 = new Employee() { Id = 102, Name = "Ravi3", Sal = 30000 };
            Employee e4 = new Employee() { Id = 103, Name = "Ravi4", Sal = 40000 };


            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(e1);
            EmpList.Add(e2);
            EmpList.Add(e3);
            EmpList.Add(e4);

            List<Employee> EmpListSal = EmpList.FindAll(e => e.Sal > 20000);

            Console.WriteLine("Employees with Salary greater that 20,000 are:");

            foreach (Employee emp in EmpListSal)
            {
                Console.WriteLine("Name: {0} ID: {1} Salary: {2} ",emp.Name,emp.Id,emp.Sal);
            }

            Employee[] EmpArr = new Employee[4];
            EmpArr[0] = e1;
            EmpArr[0] = e2;
            EmpArr[0] = e3;
            EmpArr[0] = e4;

            //converting Array to List

            List<Employee> ArrEmp = EmpArr.ToList();

            //converting List to Array

            Employee[] EmpArr1 = EmpList.ToArray();

            //converting List to Dictionary

            Dictionary<int,Employee> DicEmp =EmpList.ToDictionary(x => x.Id);

            foreach(KeyValuePair<int,Employee> kvp in DicEmp)
            {
                Console.WriteLine("key = " + kvp.Key);
                Employee e = kvp.Value;
                Console.WriteLine("ID: "+e.Id+" Name: "+e.Name+" Salary:"+e.Sal);
            }

        }
    }
}
