using System;

/*Write a program that reads two positive integer numbers and prints how many numbers p 
 * exist between them such that the reminder of the division by 5 is 0.
 */

class NumbersDivadedBy5
{
    static void Main()
    {
        Console.WriteLine("Please enter two positive integer numbers ");
        Console.Write("Begin: ");
        uint begin = uint.Parse(Console.ReadLine());
        Console.Write("End: ");
        uint end = uint.Parse(Console.ReadLine());
        uint p = 0;
        for (uint i = begin; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine("Between {0} and {1} exist p = {2} numbers devided by 5.",begin, end, p);
    }
}

