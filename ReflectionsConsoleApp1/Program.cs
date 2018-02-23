using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



namespace ReflectionsConsoleApp1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Print()
        {
            Console.WriteLine("ID: {0} Name: {1}",this.Id,this.Name);
        }
        public Employee(int id,string Name)
        {
            this.Id = id;
            this.Name = Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Type T = Type.GetType("ReflectionsConsoleApp1.Employee");
            Type T = typeof(System.Console);
            Console.WriteLine("Name: {0}",T.Name);
            Console.WriteLine("Full Name: {0}",T.FullName);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Properities in Employee");
            Console.WriteLine("---------------------------------------------------------");

            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine("<"+property.PropertyType.Name+">"+property.Name);
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Methods in Employee");
            Console.WriteLine("---------------------------------------------------------");

            MethodInfo[] Methods = T.GetMethods();
            foreach (MethodInfo Method in Methods)
            {
                Console.Write("<" + Method.ReturnType.Name + ">" + Method.Name+"(");

                ParameterInfo[] Paramaters = Method.GetParameters();
                int i=Paramaters.Length;
                    foreach (ParameterInfo Parameter in Paramaters)
                {
                    Console.Write(Parameter.ParameterType.Name);
                    if(i>1)
                    {
                        Console.Write(",");
                        i--;
                    }
                }
                Console.WriteLine(")");
            }
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Cunstructors in Employee");
            Console.WriteLine("---------------------------------------------------------");

            ConstructorInfo[] Constructors = T.GetConstructors();
            foreach (ConstructorInfo Constructor in Constructors)
            {
                Console.WriteLine(Constructor.ToString());
            }
        }
    }
}
