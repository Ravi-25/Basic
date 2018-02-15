using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConsoleApp
{
    class employee
    {
        public string _Name;
        public string _DOJ;
        public employee ()
        {
            Console.WriteLine("Parent or Base class constructor");
        }
        public employee(string message)
        {
            Console.WriteLine(message);
        }
        public void PrintName()
        {
            Console.WriteLine(this._Name);
        }
    }
    class fulltimeemployee : employee
    {
        public float yearlysal;
        public fulltimeemployee()
        {
            Console.WriteLine("FTE Child class or Derived class Construcctor");
        }
    }
    class parttimeemployee : employee
    {
        public float hourlysal;
        public parttimeemployee(): base("Overloaded constructor of parent from child class(PTE)")
        {
            Console.WriteLine("PTE Child class or Derived class Construcctor");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            fulltimeemployee FTE = new fulltimeemployee();
            FTE._Name = "Ravi";
            FTE._DOJ = "01/04/17";
            FTE.yearlysal = 1500000F;
            FTE.PrintName();
            parttimeemployee PTE = new parttimeemployee();
            PTE._Name = "Ravi1";
            PTE._DOJ = "01/04/17";
            PTE.hourlysal = 1000F;
            PTE.PrintName();

        }
    }
}
