using System;

/* Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
 * Note: You may need to use a for-loop.
*/

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int max = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= max; i++)
        {
            Console.Write("Please enter a real number: ");
            double a = double.Parse(Console.ReadLine());
            sum = sum + a;
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}

