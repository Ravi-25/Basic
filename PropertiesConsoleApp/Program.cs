using System;
using System.Text;


class student
{
    private int _iD;
    private string _name;
    private int _marks = 99;
    public string Email { get; set; }

    public int Marks
    {
        get { return this._marks; }
    }
    public int ID
    {
        set
        {
            if (value<=0)
            {
                Console.WriteLine("ID cannot be a non positive number");
            }
            else
            {
                this._iD = value;
            }
        }
        get
        {
            return this._iD;
        }
    }
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                global::System.Console.WriteLine("Name cannot be empty od null");
            }
            else
            {
                this._name = value;
            }
        }
        get
        {
            return string.IsNullOrEmpty(this._name) ? "NO NAME" : this._name;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        student s1 = new student();
        s1.ID = 101;
        s1.Name = "Ravi";
        s1.Email = "Ravi@standav.com";
        Console.WriteLine("Name:{0}",s1.Name);
        Console.WriteLine("ID:{0}", s1.ID);
        Console.WriteLine("Email:{0}", s1.Email);
        Console.WriteLine("Marks:{0}", s1.Marks);
        student s2 = new student { ID = 102, Name = "Ravi2", Email = "Ravi2@gmail.com" };
        Console.WriteLine("Name:{0}", s2.Name);
        Console.WriteLine("ID:{0}", s2.ID);
        Console.WriteLine("Email:{0}", s2.Email);
        Console.WriteLine("Marks:{0}", s2.Marks);

    }
}
