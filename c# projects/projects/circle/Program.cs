using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double r = double.Parse(Console.ReadLine());

        double p = 2 * Math.PI * r;
        double a = Math.PI * r * r;

        Console.WriteLine("Perimeter = " + p);
        Console.WriteLine("Area = " + a);

        Console.ReadKey();
    }
}
