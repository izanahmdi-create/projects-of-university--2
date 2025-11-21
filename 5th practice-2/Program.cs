using System;

class Program
{
    // Method for calculating perimeter
    static double Perimeter(double a, double b, double c)
    {
        return a + b + c;
    }

    // Method for calculating area (Heron's Formula)
    static double Area(double a, double b, double c)
    {
        double s = (a + b + c) / 2;   // semi-perimeter
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    static void Main()
    {
        double a, b, c;

        Console.Write("Enter side a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Enter side b: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Enter side c: ");
        c = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter = " + Perimeter(a, b, c));
        Console.WriteLine("Area = " + Area(a, b, c));
    }
}