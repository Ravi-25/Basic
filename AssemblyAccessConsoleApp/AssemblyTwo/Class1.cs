using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;

namespace AssemblyTwo
{
    public class Ass2Class1 : Ass1Class1
    {
        public void print()
        {
            Ass1Class1 A1 = new Ass1Class1();
            //A1.id1 = 100;  ///Not possible
            base.id2 = 1000;
            Ass2Class1 A2 = new Ass2Class1();
            Console.WriteLine(A2.id2);
            

        }
    }
}
