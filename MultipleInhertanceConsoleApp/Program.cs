using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInhertanceConsoleApp
{
    public interface IA
    {
        void Aprint();
    }
    public interface IB
    {
        void Bprint();
    }
    public class A:IA
    {
        public void Aprint()
        {
            Console.WriteLine("A");
        }
    }
    public class B : IB
    {
        public void Bprint()
        {
            Console.WriteLine("B");
        }
    }
    public class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void Aprint()
        {
            a.Aprint();
        }
        public void Bprint()
        {
            b.Bprint();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.Aprint();
            ab.Bprint();
        }
    }
}
