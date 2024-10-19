using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int[] output = new int[26];

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = -1;
        }

        for (int i = 0; i < input.Length; i++)
        {
            // 현재 글자의 아스키코드 - 'a'
            int tmp = input[i] - 'a';
            if (output[tmp] == -1) output[tmp] = i;
        }

        for (int i = 0; i < output.Length; i++)
        {
            Console.Write("{0} ", output[i]);
        }
    }
}