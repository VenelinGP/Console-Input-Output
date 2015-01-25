using System;

//Write a program that reads 3 real numbers from the console and prints their sum.

class SumOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Please enter 3 real number ");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a+b+c);
     }
}
