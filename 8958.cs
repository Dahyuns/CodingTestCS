using System;

class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            char[] times = Console.ReadLine().ToCharArray();
            int isOBefore = 0;
            int answer = 0;
            for (int j = 0; j < times.Length; j++)
            {
                if (times[j] == 'O')
                {
                    answer += 1 + isOBefore;
                    isOBefore++;
                }
                else
                {
                    isOBefore = 0;
                }
            }
            Console.WriteLine(answer);
        }
    }
}