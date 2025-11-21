using System;

class Program
{
    static void Main()
    {
        int[] nums = new int[10];
        int even = 0;
        int odd = 0;

        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Number " + (i + 1) + ": ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            if (nums[i] % 2 == 0)
                even++;
            else
                odd++;
        }

        Console.WriteLine("Even numbers: " + even);
        Console.WriteLine("Odd numbers: " + odd);
    }
}