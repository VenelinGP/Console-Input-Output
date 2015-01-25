using System;

// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Please enter 5 numbers:");
        string myString = Console.ReadLine();
        Console.Write(myString);
        double sum = 0.0;
        for (int i = 0; i<5; i++)
        {
            string value = myString.Split(' ')[i];
            double a = double.Parse(value);
            sum = sum + a;
        }
        Console.WriteLine(" = {0}",sum);
    }
}
