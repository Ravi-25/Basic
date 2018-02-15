using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConsoleApp
{
    class circle
    {
        static float _PI=3.141F;
        int _Radius;
        static circle()
        {
            Console.WriteLine("Static constrctor");
            circle._PI = 3.141F;
        }
        public circle(int radius)
        {
            Console.WriteLine("Instance constructor");
            this._Radius = radius;
        }
        public float area()
        {
            return circle._PI * this._Radius * this._Radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            circle c1 = new circle(5);
            float area = c1.area();
            Console.WriteLine("Area is {0}",area);

            circle c2 = new circle(7);
            area = c2.area();
            Console.WriteLine("Area is {0}", area);
        }
    }
}
