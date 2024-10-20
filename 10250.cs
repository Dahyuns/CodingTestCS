using System;

class Program
{
    static void Main(string[] args)
    {
        int caseCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < caseCount; i++)
        {
            string[] caseN = Console.ReadLine().Split(' ');

            // 총 층
            int floor = int.Parse(caseN[0]);
            // 총 방수
            int room = int.Parse(caseN[1]);

            // 몇번쨰 손님?
            int custemer = int.Parse(caseN[2]);

            // 몇 호?
            int nowRoomN = 0;

            for (int j = 0; j < room; j++)
            {
                for (int k = 0; k < floor; k++)
                {
                    // 방배정
                    custemer--;
                    if (custemer == 0)
                    {
                        nowRoomN = 100 * (k + 1) + (j + 1);
                        break;
                    }
                }

                if (custemer == 0)
                {
                    break;
                }
            }
            Console.WriteLine(nowRoomN);

        }
    }
}