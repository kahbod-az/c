using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter x:");
        int x = int.Parse(Console.ReadLine());
        int y = ((x << 5) - (x << 4)) + 5 -(x << 1);

        Console.WriteLine($"The result is: {y}");
    }
}
