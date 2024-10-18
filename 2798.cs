using System;

class Program
{
    static void Main(string[] args)
    {
        // 블랙잭

        // 첫번쨰 입력 : 카드의 개수와 
        string[] originNum = (Console.ReadLine()).Split(' ');

        // 두번째 입력 : 카드에 쓰여 있는 수들
        string[] strnums = (Console.ReadLine()).Split(' ');
        int[] nums = new int[strnums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(strnums[i]);
        }

        // 최소 차이
        int minDistance = 300000;
        int answer = 0;

        // 3차배열?
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j) continue;
                for (int k = 0; k < nums.Length; k++)
                {
                    if (j == k || i == k) continue;
                    // 셋의 합
                    int thisNum = nums[i] + nums[j] + nums[k];
                    int origin = int.Parse(originNum[1]);

                    // 절대값이 최소보다 작은 수 + M을 넘지 않는 수
                    if (origin - thisNum < minDistance && origin - thisNum >= 0)
                    {
                        minDistance = origin - thisNum;
                        answer = thisNum;
                    }

                }
            }
        }

        Console.WriteLine(answer);
    }
}