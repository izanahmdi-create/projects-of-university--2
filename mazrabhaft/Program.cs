using System;

namespace MultipleOf7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 7 == 0)
            {
                Console.WriteLine("!Yes");
            }
            else
            {
                int result = num * 3;
                Console.WriteLine("Result = " + result);
            }

            Console.ReadKey();
        }
    }
}