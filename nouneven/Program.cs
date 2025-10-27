using System;

namespace CheckNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 10 && num % 2 == 0)
            {
                Console.WriteLine("!True");
            }
            else
            {
                Console.WriteLine("not valid.");
            }

            Console.ReadKey();
        }
    }
}
