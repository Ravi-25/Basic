using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Customer 
    {
     public Guid Id { get; set; }
    public Customer()
    {
        this.Id = Guid.NewGuid();
    }

    }
public class SavingCustomer :Customer{ }
public class CorprateCustomer :Customer{ }
    class Program
    {
        static void Main(string[] args)
        {
        SavingCustomer SC = new SavingCustomer();
        Console.WriteLine(SC.Id);
        CorprateCustomer CC = new CorprateCustomer();
        Console.WriteLine(CC.Id);
        }
    }

