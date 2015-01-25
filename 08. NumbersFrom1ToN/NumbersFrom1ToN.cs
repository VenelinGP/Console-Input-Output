using System;

// Write a program that reads an integer number n from the console and prints all the numbers in
// the interval [1..n], each on a single line.

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int max = int.Parse(Console.ReadLine());
        for (int i=1; i <= max; i++)
        {
            Console.WriteLine(i);
        }
    }
}
