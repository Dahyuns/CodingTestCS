using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        int num = int.Parse(Console.ReadLine());

        // 팩토리얼에서 5의 배수 개수 세기
        for (int i = 5; i <= num; i *= 5)
        {
            answer += num / i;
        }

        Console.WriteLine(answer);

    }
}