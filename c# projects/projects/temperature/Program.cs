
    {
        Console.Write("Enter temperature in Celsius: ");
        double c = double.Parse(Console.ReadLine());

        double f = (c * 9 / 5) + 32;

        Console.WriteLine("Temperature in Fahrenheit = " + f);

        Console.ReadKey();
    }

