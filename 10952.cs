using System;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            int tmp1 = int.Parse(input[0]);
            int tmp2 = int.Parse(input[1]);

            if (tmp1 == 0 && tmp2 == 0)
            {
                return;
            }

            Console.WriteLine(tmp1 + tmp2);
        }
    }
}