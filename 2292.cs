using System;

class Program
{
    static void Main(string[] args)
    {
        // 벌집

        int input = int.Parse(Console.ReadLine());

        // 몇번쨰 방?
        int num = 1;

        while (true)
        {
            // 현재 방의 최대 숫자 (1= 첫번쨰 방)
            int tmpN = 1;

            for (int i = 0; i < num; i++)
            {
                tmpN = tmpN + i * 6;
            }

            // 입력 숫자가 현재 방의 최대 숫자보다 적거나 같으면 현재 방이 정답. => 빠져나간다.
            if (input - tmpN <= 0)
            {
                break;
            }
            num++;
        }

        Console.WriteLine(num);
    }
}