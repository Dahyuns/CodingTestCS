using System;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        for (int many = 0; many < input; many++)
        {
            int tmp = input - many;
            for (int i = 1; i < tmp; i++)
            {
                Console.Write(" ");
            }

            for (int i = -1; i < many; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}