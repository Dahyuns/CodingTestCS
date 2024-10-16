using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // 입력
            string[] nums = (Console.ReadLine().Split(' '));
            // 출구
            if (nums.SequenceEqual(new string[] { "0", "0", "0" }))
            { break; }

            double[] side = new double[3];
            // 제일 긴 변의 길이
            double best = 0;
            // 나머지 변 길이의 합
            double anothers = 0;

            // 세개 모두 곱해서 더블 배열에 넣기
            for (int i = 0; i < 3; i++)
            {
                side[i] = Math.Pow(double.Parse(nums[i]), 2);
                if (best < side[i])
                {
                    best = side[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (best != side[i])
                {
                    anothers += side[i];
                }
            }

            if (anothers == best)
            {
                Console.WriteLine("right");
            }
            else
            {
                Console.WriteLine("wrong");
            }
        }
    }
}