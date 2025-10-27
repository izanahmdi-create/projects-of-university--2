using System;

namespace WeekDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-7): ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Saturday");
                    break;
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Thursday");
                    break;
                case 7:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("END!");
                    break;
            }

            Console.ReadKey();
        }
    }
}