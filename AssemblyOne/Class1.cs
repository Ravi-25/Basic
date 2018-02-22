using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;

namespace AssemblyOne
{
    public class Ass1Class1
    {
        internal int id = 101;
        protected internal int id2 = 100;
    }
}public class Ass1class2
{
    public void Sampmet()
    {
        Ass1Class1 ac1 = new Ass1Class1();//AssClass1 ac1 = new AssClass1();
        Console.WriteLine(ac1.id);
    }
}
