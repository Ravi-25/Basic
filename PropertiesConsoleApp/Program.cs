using System;
using System.Text;


class student
{
    public int _ID;
    public string _Name;
    public int _Marks = 99;
    public string _email { get; set; }

    public int Marks
    {
        get { return this.Marks; }
    }
    public int ID
    {
        set
        {
            if (this._ID <= 0)
            {
                Console.WriteLine("ID cannot be a non positive number");
            }
            else
            {
                this._ID = 10;
            }
        }
        get
        {
            return this._ID;
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
        }
        get
        {
            return string.IsNullOrEmpty(this._Name) ? "NO NAME" : this.Name;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        student s1 = new student();
        s1._ID = 101;
        s1._Name = "Ravi";
        s1._email = "Ravi@standav.com";
        Console.WriteLine("Name:{0}",s1._Name);
        Console.WriteLine("ID:{0}", s1.ID);
        Console.WriteLine("Email:{0}", s1._email);
        Console.WriteLine("Marks:{0}", s1._Marks);
    }
}
