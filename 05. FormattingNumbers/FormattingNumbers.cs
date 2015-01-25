using System;

/* Write a program that reads 3 numbers:
 * integer a (0 <= a <= 500)
 * floating-point b
 * floating-point c
 * The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
 * The number a should be printed in hexadecimal, left aligned
 * Then the number a should be printed in binary form, padded with zeroes
 * The number b should be printed with 2 digits after the decimal point, right aligned
 * The number c should be printed with 3 digits after the decimal point, left aligned.
 */ 

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Please, enter 3 numbers, first number shoud be integer (0 <= a <= 500) \n\r and other numbers shoud be float.");
        int a;
        do
        {
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
        } 
        while ((a < 0) || (a > 500));
        string binary = Convert.ToString(a, 2);
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.00}|{3,-10:0.000}|", a, binary.PadLeft(10,'0'), b, c);
     }
}
