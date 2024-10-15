using System;

internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        long inputone = long.Parse(input[0]);
        long inputtwo = long.Parse(input[1]);

        Console.WriteLine(Math.Abs(inputone - inputtwo));

        Console.ReadLine();
    }
}