using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 주어진 자연수 
        int originNum = int.Parse(Console.ReadLine());
        // 정답란
        int answer = 0;

        // 몇가지 수? n * 9
        int origintmpN = originNum;
        int howMany = 0;
        while (origintmpN != 0)
        {
            origintmpN = origintmpN / 10;
            howMany++;
        }
        howMany *= 9;

        // 이 숫자부터 howMany만큼 검사하면 됨
        int startNum = originNum - howMany;

        for (int i = 0; i < howMany; i++)
        {
            // 각 자리 수 리스트
            List<int> nums = new List<int>();

            // 계산용 숫자. (startNum + i) : 현재 검사하는 수
            int nowNum = (startNum + i);

            // 각 자리 수 리스트에 추가하기
            while (true)
            {
                nums.Add(nowNum % 10);
                nowNum = nowNum / 10;
                if (nowNum == 0) { break; }
            }

            // 각 자리 수 모두 더하기
            for (int j = 0; j < nums.Count; j++)
            {
                nowNum += nums[j];
            }

            // 정답 맞나 체크
            if (originNum == (startNum + i) + nowNum)
            {
                answer = startNum + i;
                break;
            }
        }

        Console.WriteLine(answer);
    }
}