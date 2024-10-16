using System;

class Program
{
    static void Main(string[] args)
    {
        int ints = int.Parse(Console.ReadLine());
        string[] nums = Console.ReadLine().Split(' ');

        int answerMin = 1000000;
        int answerMax = -1000000;

        for (int i = 0; i < ints; i++)
        {
            int thisNum = int.Parse(nums[i]);
            if (thisNum < answerMin)
            {
                answerMin = thisNum;
            }

            if (thisNum > answerMax)
            {
                answerMax = thisNum;
            }
        }

        Console.WriteLine("{0} {1}", answerMin, answerMax);
    }
}