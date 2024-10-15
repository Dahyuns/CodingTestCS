using System;

internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        double inputone = double.Parse(input[0]);
        double inputtwo = double.Parse(input[1]);

        Console.WriteLine(String.Format("{0:N9}",(inputone/ inputtwo)));
    }
}
