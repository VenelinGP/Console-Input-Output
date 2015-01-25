using System;

// Write a program that reads the radius r of a circle and prints its perimeter and area
// formatted with 2 digits after the decimal point.


class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please, enter a radius R of circle: ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("Circle with radius {0} have perimeter {1:0.00} and area {2:0.00}",r, 2*r*Math.PI, Math.PI*r*r);
    }
}

