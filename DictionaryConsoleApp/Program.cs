using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryConsoleApp
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

            Dictionary<int, Employee> DicEmp = new Dictionary<int, Employee>();

            DicEmp.Add(e1.Id, e1);
            DicEmp.Add(e2.Id, e2);
            DicEmp.Add(e3.Id, e3);
            DicEmp.Add(e4.Id, e4);

            Console.WriteLine("Numbers Employees Objects in Dictionary are : {0}",DicEmp.Count);
            Console.WriteLine("Numbers Employees Objects with Salary greater that 20000 in Dictionary are : {0}", DicEmp.Count(kvp=>kvp.Value.Sal>20000));

            Employee[] Emparr = new Employee[4]; //array of Employee class
            Emparr[0] = e1;
            Emparr[0] = e2;
            Emparr[0] = e3;
            Emparr[0] = e4;
            //converting a array to dictionary
            Dictionary<int, Employee> DicEmpArr = Emparr.ToDictionary(empe => empe.Id, empe => empe);

            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(e1);
            EmpList.Add(e2);
            EmpList.Add(e3);
            EmpList.Add(e4);
            //converting Employee List to Dictionary
            Dictionary<int, Employee> DicEmpList = Emparr.ToDictionary(empe => empe.Id, empe => empe);

            Employee emp = DicEmp[103];
            Console.WriteLine("ID: "+emp.Id+" Name : "+emp.Name+" Sal :"+emp.Sal);

            foreach(KeyValuePair<int,Employee> keyvalp in DicEmp)
            {
                Employee emply = keyvalp.Value;
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("ID: {0} Name: {1} Sal: {2}",emply.Id,emply.Name,emply.Sal);
            }
            foreach(var varkeyvalp in DicEmp)
            {
                Employee emply = varkeyvalp.Value;
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("ID: {0} Name: {1} Sal: {2}", emply.Id, emply.Name, emply.Sal);
            }

            foreach (int Id1 in DicEmp.Keys)
            {
                //int ID1 = varkeyvalp.Value;
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine(Id1);
            }
            foreach(Employee emply in DicEmp.Values)
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("ID: {0} Name: {1} Sal: {2}", emply.Id, emply.Name, emply.Sal);
            }
        }

    }
}
