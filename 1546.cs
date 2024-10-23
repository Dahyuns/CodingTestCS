using System;

class Program
{
    static void Main(string[] args)
    {
        float total = float.Parse(Console.ReadLine());
        total = 0;

        string[] scores = Console.ReadLine().Split(' ');

        float best = 0;

        // 최고점 구하기
        for (int i = 0; i < scores.Length; i++)
        {
            int thisN = int.Parse(scores[i]);

            if (best < thisN)
            {
                best = thisN;
            }
        }

        // 새로운 점수들 합 구하기
        for (int i = 0; i < scores.Length; i++)
        {
            float thisN = float.Parse(scores[i]);

            total += thisN / best * 100;

        }

        Console.WriteLine(total / scores.Length);
    }
}