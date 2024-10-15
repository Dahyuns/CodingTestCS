using System;

internal class Program
{
    static void Main(string[] args)
    {
        int input = Int32.Parse(Console.ReadLine());

        if (input >= 60)
        {
            if (input >= 70)
            {
                if (input >= 80)
                {
                    if (input >= 90)
                    {
                        Console.WriteLine("A");
                    }
                    else
                    {
                        Console.WriteLine("B");
                    }
                }
                else
                {
                    Console.WriteLine("C");
                }
            }
            else
            {
                Console.WriteLine("D");
            }
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}