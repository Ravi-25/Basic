using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface I1
{
     void print();
}
public interface I2
{
    void print();
}
public interface ExI1
{
    void print();
}
public interface ExI2
{
    void print();
}
public class class1: I1,I2,ExI1,ExI2
{
    public void print()
    {
        Console.WriteLine("Common Interface of I1 and I2");
    }
    //void print()
    //{
    //    Console.WriteLine("Interface I2");
    //}
    void ExI1.print()
    {
        Console.WriteLine("Exp Interface I1");
    }
    void ExI2.print()
    {
        Console.WriteLine("Exp Interface I2");
    }
}
    class Program
    {
        static void Main(string[] args)
        {
        class1 c1 = new class1();
        c1.print();
        ((ExI1)c1).print();
        ((ExI2)c1).print();
        ExI1 exI1 = new class1();
        exI1.print();
        ExI2 exI2 = new class1();
        exI2.print();
        }
    }

