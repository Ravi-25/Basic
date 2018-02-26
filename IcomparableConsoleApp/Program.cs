using System;
using System.Collections;

namespace IcomparableConsoleApp
{
    public class Student : IComparable
    {
        public int Id;
        public string Name;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int CompareTo(object obj)
        {
            Student Other = (Student)obj;
            if(this.Id < Other.Id)
            {
                return -1;
            }
            if (this.Id > Other.Id)
            {
                return 1;
            }
            else return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList AlStu = new ArrayList();
            AlStu.Add(new Student(2, "s2"));
            AlStu.Add(new Student(4, "s4"));
            AlStu.Add(new Student(3, "s3"));
            AlStu.Add(new Student(1, "s1"));
            AlStu.Add(new Student(6, "s6"));
            AlStu.Add(new Student(5, "s5"));

            AlStu.Sort();

            foreach(Student stu in AlStu)
            {
                Console.WriteLine(stu.Id+" "+stu.Name);
            }

            Console.WriteLine();

            IEnumerator en = AlStu.GetEnumerator();
            while(en.MoveNext())
            {
                Student s = (Student)en.Current;
                Console.WriteLine(s.Id+" "+s.Name);
            }
        }
    }
}
