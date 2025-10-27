using System;

namespace MultiplyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double product = 1; // حاصل‌ضرب اولیه
            double num;

            Console.WriteLine("Enter number(enter 0 to stop):");

            while (true)
            {
                num = double.Parse(Console.ReadLine());

                if (num == 0)
                    break; // خروج از حلقه

                product *= num; // ضرب عدد در حاصل‌ضرب فعلی
            }

            Console.WriteLine("Product of numbers = " + product);
            Console.ReadKey();
        }
    }
}