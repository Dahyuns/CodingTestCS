using System;

class Program
{
    static void Main(string[] args)
    {
        int total = int.Parse(Console.ReadLine());

        string inputstr = Console.ReadLine();
        char[] inputChar = inputstr.ToCharArray();
        ulong[] inputInt = new ulong[inputChar.Length];

        for (int i = 0; i < inputInt.Length; i++)
        {
            inputInt[i] = (ulong)inputChar[i] - 96;
        }

        ulong answer = 0;
        ulong dvValue = 1234567891;

        for (int i = 0; i < total; i++)
        {
            // 31승 구하기
            ulong tmp = 1;

            for (int j = 0; j < i; j++)
            {
                tmp = tmp * 31 % dvValue;
            }

            // 현재 문자값(inputInt[i]) * 31의 i승, % dvValue (나머지) 
            answer = (answer + (inputInt[i] * tmp)) % dvValue;

        }

        Console.WriteLine(answer);
    }
}