using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Program.cs
public static class EMClass
{
    public static int ToInt32Ext(this string s)
    {
        return Int32.Parse(s);
    }
    public static int ToInt32Static(string s)
    {
        return Int32.Parse(s);
    }
}
class Program
{
    static void Main(string[] args)
    {
        string s = "9";
        int i = s.ToInt32Ext(); // LINE A
        Console.WriteLine(i);
        int j = EMClass.ToInt32Static(s); // LINE B
        Console.WriteLine(j);
        Console.ReadLine();
    }
}
