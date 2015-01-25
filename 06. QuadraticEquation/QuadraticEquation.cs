using System;

// Write a program that reads the coefficients a, b and c of a quadratic equation
// ax2 + bx + c = 0 and solves it (prints its real roots)

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Please, enter 3 real coeficients ");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if ((b * b - 4 * a * c)>=0)
        {
            double x1 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double x2 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine();
            Console.WriteLine("a={0}, b={1}, c={2} result is x1 = {3}, x2 = {4}", a, b, c, x1, x2);
        }
        else
        {
            Console.WriteLine ("no real roots");
        }
    }
}
