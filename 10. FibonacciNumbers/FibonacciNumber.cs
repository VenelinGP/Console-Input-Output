using System;

//

class FibonacciNumber
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int max = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        for (int i = 1; i <= max; i++)
        {
            Console.Write("{0} ", a);
            int sum = a;
            a = b;
            b = sum + b;
        }
        Console.WriteLine();
    }
}
