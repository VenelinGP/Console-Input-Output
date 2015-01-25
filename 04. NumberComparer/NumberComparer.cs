using System;

// Write a program that gets two numbers from the console and prints the greater of them
// Try to implement this without if statements.

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Please, enter 2 real numbers.");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Greater is: {0}", Math.Max(a, b));
        // another way to find greater number
        Console.WriteLine("Greater is: {0}", ((a + b) + Math.Abs(a - b)) / 2);
    }
}
