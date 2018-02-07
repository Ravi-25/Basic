using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



class EvenOrOdd
{
    static void Main(string[] args)
    {
        int n;//declaring a integer variable n
        Console.WriteLine("Enter an integer");
        n = int.Parse(Console.ReadLine());//reading in a integer
        if (n % 2 == 0)//applying mod operator to integer and comparing it with zero
            Console.WriteLine("Even");//if mod is zero then integer is even
        else
            Console.WriteLine("Odd");//else odd
        //Console.Read();
    }
}

//every time we read something from keyboard it is a string which must be parsed to respective datatype for using them in expressions


class ProgEvenOrOddWithoutMod
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter an integer");
        n = int.Parse(Console.ReadLine());//reading in a integer
        if ((n / 2) * 2 == n)//dividing the int with two and multiplying it with two and compring it with the same integer which we have read from keyboard
            Console.WriteLine("Even");//if at all it is true then it is a even number
        else
            Console.WriteLine("Odd");//else odd
    }
}

class Calculator
{
    static void Main(string[] args)
    {
        int first, second, add, subtract, multiply;
        float divide;
        Console.WriteLine("Enter two integers");
        first = int.Parse(Console.ReadLine());//reading first number from keyboard
        second = int.Parse(Console.ReadLine());//reading secound number from keyboard
        add = first + second;//adding two numbers
        subtract = first - second;//subrtrating from 2 numbers
        multiply = first * second;//multiplying two numbers
        divide = first / (float)second; //typecasting//dividing two numbers
        Console.WriteLine("Sum = {0}", add);//printing the sum
        Console.WriteLine("Difference = {0}", subtract);//printing the subtrating value
        Console.WriteLine("Multiplication = {0}", multiply);//printing the multiplicaton
        Console.WriteLine("Division = {0}", divide);//printing the division
    }
}
//typecasting can be done in an expression
//{0} is used to print a variable 

class VowelOrNot
{
    static void Main(string[] args)
    {
        char ch;
        Console.WriteLine("Enter a character");
        ch = char.Parse(Console.ReadLine());//reading a char from keyboard
        if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')//comparing it with a e i o u both lower and upper case
            Console.WriteLine("{0} is a vowel.", ch);//if it is true then it is a vowel
        else
            Console.WriteLine("{0} is not a vowel.", ch);//else not a vowel
    }
}

//logical OR can be used between any number of expressions



class LeapYear
{
    static void Main(string[] args)
    {
        int year;
        Console.WriteLine("Enter a year to check if it is a leap year");
        year = int.Parse(Console.ReadLine());//reading in a year from console
        if (year % 400 == 0)//if the year is divisable by 400 then it is a leap year
            Console.WriteLine("{0} is a leap year.", year);
        else if (year % 100 == 0)//if the year is not divisable by 400 and divisible by 100 then it is not a leap year
            Console.WriteLine("{0} is not a leap year.", year);
        else if (year % 4 == 0)//if the year is not divisable by 400 and 100 and divisable by 4 then it is a leap year
            Console.WriteLine("{0} is a leap year.", year);
        else//else it is not a leap year
            Console.WriteLine("{0} is not a leap year.", year);
    }
}


class AddDigits
{
    static void Main(string[] args)
    {
        int n, sum = 0, remainder;
        Console.WriteLine("Enter an integer");//reading in a integer
        n = int.Parse(Console.ReadLine());
        while (n != 0)//while loop starts till n is not zero
        {
            remainder = n % 10;//finding the reminder for division of 10
            sum = sum + remainder;//adding the reminder
            n = n / 10;//dividing the original num,ber by 10
        }
        Console.WriteLine("Sum of digits of entered number = {0}", sum);//printing the sum of digits
    }
}




class FactorialUsingLoop
{
    static void Main(string[] args)
    {
        ulong c, n, fact = 1;
        Console.WriteLine("Enter a number to calculate it's factorial");
        n = ulong.Parse(Console.ReadLine());//reading in a integer
        for (c = 1; c <= n; c++)//entering for loop with condition that the counter is less tan or eqal to the given number
        {
            fact = fact * c;//mltiplying counter and fact and storing in fact
        }
        Console.WriteLine("Factorial of {0} is {1}",n, fact);
        Console.ReadLine();
    }
}



class Program2
{

    static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                    break;
                Console.WriteLine(i + " " + j);
            }
        }
    }
}

class Program3
{
    static void Main(string[] args)
    {

    }
}

//class FactorialUsingRecursion
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("please enter a number of which factorial must be calculated");
//        int n = int.Parse(Console.ReadLine());//reading in a integer

//        static long Factorial(int n)
//{
//            if (n == 0)
//                return (1);
//            else
//                return (n * Factorial(n - 1));
//        }
//        long fact = Factorial(n);
//    }
//}

class AddNumbrs
{
    static void Main(string[] args)
    {
        int n, sum = 0, c, var;
        Console.WriteLine("Enter the number of integers you want to add");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers", n);
        for (c = 1; c <= n; c++)
        {
            var = int.Parse(Console.ReadLine());
            sum = sum + var;
        }
        Console.WriteLine("Sum of entered numbers = {0}", sum);
    }
}



class Swap
{
    static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Enter two numbers to swap ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a = {0} b = {1}", a, b);
    }
}

class SwapByRef
{
    static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Enter two numbers to swap ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Swap(ref a, ref b);
        Console.WriteLine("a = {0} b = {1}", a, b);

    }
    static void Swap(ref int a, ref int b)
    {
        int temp;
        temp = b;
        b = a;
        a = temp;
    }
}




class ReverseNumber
{
    static void Main(string[] args)
    {
        int n, reverse = 0;
        Console.WriteLine("Enter a number to reverse");
        n = int.Parse(Console.ReadLine());
        while (n != 0)
        {
            reverse = reverse * 10;
            reverse = reverse + n % 10;
            n = n / 10;
        }
        Console.WriteLine("Reverse of entered number is = {0}", reverse);
    }
}


class Palindrome
{
    static void Main(string[] args)
    {
        int n, reverse = 0, temp;
        Console.WriteLine("Enter a number to check if it is a palindrome or not");
        n = int.Parse(Console.ReadLine());
        temp = n;
        while (temp != 0)
        {
            reverse = reverse * 10;
            reverse = reverse + temp % 10;
            temp = temp / 10;
        }
        if (n == reverse)
            Console.WriteLine("{0} is a palindrome number.", n);
        else
            Console.WriteLine("{0} is not a palindrome number.", n);
    }
}

class PrintStar
{
    static void Main(string[] args)
    {
        int row, c, n, temp;
        Console.WriteLine("Enter the number of rows in pyramid of stars you wish to see ");
        n = int.Parse(Console.ReadLine());
        temp = n;
        for (row = 1; row <= n; row++)
        {
            for (c = 1; c < temp; c++)
                Console.Write(" ");
            temp--;
            for (c = 1; c <= 2 * row - 1; c++)
                Console.Write("*");
            Console.WriteLine("");
        }
    }
}



class Prime
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a integer");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(a) ? "Is Prime" : "Not a Prime");
    }
    static Boolean IsPrime(int a)
    {
        int c;
        bool result = false;
        for (c = 2; c <= a - 1; c++)
        {
            if (a % c == 0)
            {
                result = false;
                return result;
            }
        }
        if (c == a)
            result = true;
        return result;
    }
}


class Amstrong
{
    static void Main(string[] args)
    {
        int number, sum = 0, temp, remainder;
        Console.WriteLine("Enter a number");
        number = int.Parse(Console.ReadLine());
        temp = number;
        while (temp != 0)
        {
            remainder = temp % 10;
            sum = sum + remainder * remainder * remainder;
            temp = temp / 10;
        }
        if (number == sum)
            Console.WriteLine("Entered number is an armstrong number.");
        else
            Console.WriteLine("Entered number is not an armstrong number.");
    }
}



class Fibonacci
{
    static void Main(string[] args)
    {
        int n, first = 0, second = 1, next, c;
        Console.WriteLine("Enter the number of terms");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("First {0} terms of fibonacci series are :-", n);
        for (c = 0; c < n; c++)
        {
            if (c <= 1)
                next = c;
            else
            {
                next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine("{0}", next);
        }
    }
}



class MaxOfArray
{
    static void Main(string[] args)
    {
        int[] array = new int[100]; int maximum, size, c, location = 1;
        Console.WriteLine("Enter the number of elements in array");
        size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} integers", size);
        for (c = 0; c < size; c++)
            array[c] = int.Parse(Console.ReadLine());
        maximum = array[0];
        for (c = 1; c < size; c++)
        {
            if (array[c] > maximum)
            {
                maximum = array[c];
                location = c + 1;
            }
        }
        Console.WriteLine("Maximum element is present at location number {0} and it's value is {1}.", location, maximum);
    }
}


class ReverseArray
{
    static void Main(string[] args)
    {
        int n, c, d; int[] a = new int[100], b = new int[100];
        Console.WriteLine("Enter the number of elements in array");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the array elements");
        for (c = 0; c < n; c++)
            a[c] = int.Parse(Console.ReadLine());
        for (c = n - 1, d = 0; c >= 0; c--, d++)
            b[d] = a[c];
        for (c = 0; c < n; c++)
            a[c] = b[c];
        Console.WriteLine("Reverse array is");
        for (c = 0; c < n; c++)
            Console.WriteLine("{0}", a[c]);
    }
}


class Program4
{
    static void Main(string[] args)
    {

    }
}


public class Max_Min_Values
{
    public static void Main()
    {
        Console.WriteLine("Max Val of int is  "+int.MaxValue);
        Console.WriteLine("Min Val of int is "+int.MinValue);
        Console.WriteLine("Max Val of Double is "+Double.MaxValue);
        Console.WriteLine("Min Val of Double is "+Double.MinValue);
        Console.WriteLine("Max Val of Long is " + long.MaxValue);
        Console.WriteLine("Min Val of Long is " + long.MinValue);
        Console.WriteLine("Max Val of ULong is " + ulong .MaxValue);
        Console.WriteLine("Min Val of ULong is " + ulong.MinValue);
    }
}


//Prog to demonstrate In-Built AscW and ChrW Functions:

//public class GetAscii
//{
//    public static void Main()
//    {
//        string str = Console.ReadLine();
//        char ch = CChar(str);
//        int n = AscW(ch);
//        Console.WriteLine(n);
//    }
//}

//Program to demonstrate If Statement
public class IfDemo
{
    public static void Main()
    {
        int a, b, c;
        Console.WriteLine("Enter 3 Numbers");

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        Console.WriteLine("Greatest No is " + max);
    }
}


class IfDemo2
{
    public static void main(string[] args)
    {
        int a;
        if (args.Length == 0)
            Console.WriteLine("Please provide a number");
        else if (!int.TryParse(args[0], out a))
            Console.WriteLine("Not a number");
        else if (int.Parse(args[0]) % 2 == 0)
            Console.WriteLine("Even number");
        else
            Console.WriteLine("Odd number");
    }
}


//Program to demonstrate Select statement
class SelectDemo
{
    static void Main(string[] args)
    {
        string grade;
        Console.WriteLine("Enter Grade");
        grade = Console.ReadLine();
        switch (grade)
        {
            case "E":
            case "e": Console.WriteLine("Excellent"); break;
            case "G":
            case "g": Console.WriteLine("Good"); break;
            case "C":
            case "c": Console.WriteLine("Average"); break;
            case "B":
            case "b": Console.WriteLine("Above Average"); break;
            case "F":
            case "f":Console.WriteLine("FAIL");break;

            default: Console.WriteLine("No such Grade"); break;
        }
    }
}


class SelectDemo2
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter a number");
        n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 0: break;
            case 1:
            case 2:
            case 3: Console.WriteLine("case 2 and 3 "); break;
            case 4:
            case 5:
            case 6:
            case 7: Console.WriteLine("case 4,5,6 and 7 "); break;
            case 8: Console.WriteLine("Less than 9"); break;
            case 9: break;
            default: Console.WriteLine("Greater than 9"); break;
        }
    }
}

