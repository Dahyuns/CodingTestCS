using System;

internal class Program
{
    static void Main(string[] args)
    {
        int input1 = Int32.Parse(Console.ReadLine());

        int answer = 1;

        for (int i = input1; i > 1; i--)
        {
            answer = answer * i;
        }

        Console.WriteLine(answer);
    }
}