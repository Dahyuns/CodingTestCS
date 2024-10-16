using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> lists = new List<int>();

        for (int i = 1; i <= 30; i++)
        {
            lists.Add(i);
        }

        for (int i = 1; i <= 28; i++)
        {
            int num = int.Parse(Console.ReadLine());
            lists.Remove(num);
        }

        Console.WriteLine(lists[0]);
        Console.WriteLine(lists[1]);


        Console.ReadLine();
        //https://solved.ac/
    }
}