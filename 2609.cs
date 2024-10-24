using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        // 지수형태로 변환 -> 최대공약수 : 인수들의 곱

        int input1 = int.Parse(input[0]);
        int input2 = int.Parse(input[1]);

        int tmp1 = input1;
        int tmp2 = input2;

        if (tmp1 < tmp2)
        {
            int tmp = tmp1;

            tmp1 = tmp2;
            tmp2 = tmp;
        }

        while (tmp2 != 0)
        {
            int result = tmp1 % tmp2;

            tmp1 = tmp2;
            tmp2 = result;
        }

        // tmp1: 최대공약수

        Console.WriteLine(tmp1);
        Console.WriteLine((input1 * input2) / tmp1);
    }
}