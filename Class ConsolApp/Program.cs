using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.EvenNum(30);
        }
        public void EvenNum(int num)
        {
            for (int i=0;i<=num;i+=2)
            Console.WriteLine(" "+i+"");
        }

    }
}
