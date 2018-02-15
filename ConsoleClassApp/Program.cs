using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassApp
{
    class Name
    {
        string _Fname;
        string _Lname;
        public Name() : this("NULL", "NULL")
        {

        }
        public Name(string Fname, string Lname)
        {
            this._Fname = Fname;
            this._Lname = Lname;
        }
        public void PrintName()
        {
            Console.WriteLine("Full Name: {0}{1}", this._Fname, this._Lname);
        }
    }
    class program
    { 
        static void Main(string[] args)
        {
            Name n = new Name("Stan", "Dav");
            n.PrintName();
            Name n1 = new Name();
            n1.PrintName();
        }
    }
}
