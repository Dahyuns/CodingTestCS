using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] hNums = Console.ReadLine().Split(' ');

        int xNum = int.Parse(hNums[0]);
        int yNum = int.Parse(hNums[1]);

        int[,] fstNums = new int[xNum, yNum];
        int[,] secNums = new int[xNum, yNum];

        for (int x = 0; x < xNum; x++)
        {
            string[] inputstr = Console.ReadLine().Split(' ');

            for (int y = 0; y < yNum; y++)
            {
                fstNums[x, y] = int.Parse(inputstr[y]);
            }
        }

        for (int x = 0; x < xNum; x++)
        {
            string[] inputstr = Console.ReadLine().Split(' ');

            for (int y = 0; y < yNum; y++)
            {
                secNums[x, y] = int.Parse(inputstr[y]);
            }
        }

        for (int x = 0; x < xNum; x++)
        {
            for (int y = 0; y < yNum; y++)
            {
                Console.Write((fstNums[x, y] + secNums[x, y]).ToString() + " ");
            }

            Console.WriteLine("");
        }
    }
}