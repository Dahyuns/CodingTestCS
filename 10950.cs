using System;

internal class Program
{
    static void Main(string[] args)
    {
        int type = Int32.Parse(Console.ReadLine());

        int[,] ints = new int[type, 2];

        for (int i = 0; i < type; i++)
        {
            string[] tmps = Console.ReadLine().Split(' ');
            ints[i, 0] = Int32.Parse(tmps[0]);
            ints[i, 1] = Int32.Parse(tmps[1]);
        }

        for (int i = 0; i < type; i++)
        {
            Console.WriteLine(ints[i, 0] + ints[i, 1]);
        }
    }
}