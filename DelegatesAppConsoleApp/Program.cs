using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAppConsoleApp
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Sal { get; set; }
        public int Exp { get; set; }

        public static void PromotEmp(List<Employee> empList, Ispromotable promo)
        {
            foreach(Employee emp in empList)
            { 
                //if(emp.Exp >=6)
                if(promo(emp))
                {
                    Console.WriteLine(emp.Name+"  " +emp.Id + " is Promoted");
                }
                else
                {
                    Console.WriteLine(emp.Name + "  " + emp.Id + " is Not Promoted");
                }
            }
        }
    }
    public delegate bool Ispromotable(Employee emp);
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { Name = "Ravi1", Id = 101, Sal = 10000, Exp = 5 });
            empList.Add(new Employee { Name = "Ravi2", Id = 102, Sal = 20000, Exp = 6 });
            empList.Add(new Employee { Name = "Ravi3", Id = 103, Sal = 30000, Exp = 7 });
            empList.Add(new Employee { Name = "Ravi4", Id = 104, Sal = 40000, Exp = 8 });
            Ispromotable ispromo = new Ispromotable(promote);
            Console.WriteLine("\n\n\n Using Delegates");
            Employee.PromotEmp(empList,ispromo);
            Console.WriteLine("\n\n\n Using Lambda Exp");
            Employee.PromotEmp(empList,emp=>emp.Exp>=7);

        }
        public static bool promote(Employee emp)
        {
            if (emp.Exp >= 7)
                return true;
            else
                return false;
        }
    }
}
