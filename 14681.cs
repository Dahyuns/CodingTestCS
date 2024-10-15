using System;

internal class Program
{
    static void Main(string[] args)
    {
        int input1 = Int32.Parse(Console.ReadLine());
        int input2 = Int32.Parse(Console.ReadLine());

        if (input1 > 0) //1,4
        {
            if (input2 > 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(4);
            }
        }
        else //2,3
        {
            if (input2 > 0)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(3);
            }
        }
    }
}