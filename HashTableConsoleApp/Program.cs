using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable Ht = new Hashtable();
            Ht.Add(1, "One");
            Ht.Add(2, "Two");
            Ht.Add(3, "Three");
            Ht.Add(4, "Four");
            Ht.Add(5, "Five");
            //Ht.Add("One", 1);

            Console.WriteLine(Ht[2].ToString());
            Ht.Remove(1);
            Console.WriteLine();
            foreach(DictionaryEntry de in Ht)
                {
                int key = (int)de.Key;
                string Val = de.Value.ToString();
                Console.WriteLine(key+" "+Val);
                }
            Console.WriteLine();
            foreach(int key in Ht.Keys)
            {
                Console.WriteLine("Key: "+key);
            }
            Console.WriteLine();
            Console.WriteLine( Ht.Count);
        }
    }
}
