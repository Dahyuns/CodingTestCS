using System;

internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        long inputone = long.Parse(input[0]);
        long inputtwo = long.Parse(input[1]);
        long inputthree = long.Parse(input[2]);

        Console.WriteLine(inputone + inputtwo + inputthree);
    }
}
