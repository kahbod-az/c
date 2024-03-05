using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter a number:");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine($"all numbers that are multiples of 3 and smaller than {num}:");

            for (int i = 1; i < num; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("invalid input please enter an integer");
        }
    }
}
