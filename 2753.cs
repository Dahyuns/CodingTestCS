using System;

internal class Program
{
    static void Main(string[] args)
    {
        int input = Int32.Parse(Console.ReadLine());

        if (input % 4 == 0)
        {
            if (input % 100 == 0)
            {
                if (input % 400 == 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
            else
            {
                Console.WriteLine(1);
            }
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}