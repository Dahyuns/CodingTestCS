using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');


        long answer = 1;


        // n!
        for (int i = 1; i <= int.Parse(input[0]); i++)
        {
            answer *= i;
        }

        // k!
        for (int i = 1; i <= int.Parse(input[1]); i++)
        {
            answer /= i;
        }


        // n-k)!
        for (int j = 1; j <= (int.Parse(input[0]) - int.Parse(input[1])); j++)
        {
            answer /= j;
        }
        Console.WriteLine(answer);
    }
}