using System;

class Program
{
    static void Main(string[] args)
    {
        int total = int.Parse(Console.ReadLine());

        // 케이스
        for (int i = 0; i < total; i++)
        {
            // 층 +1(0층)
            int input1 = int.Parse(Console.ReadLine()) + 1;
            // 호
            int input2 = int.Parse(Console.ReadLine());

            int[,] rooms = new int[input1, input2];

            // 0층 초기화
            for (int q = 0; q < rooms.GetLength(1); q++)
            {
                rooms[0, q] = q + 1;
            }

            // k층의 N호 : K-1층의 1-N호까지 사람들의 수의 합
            for (int j = 1; j < rooms.GetLength(0); j++)
            {
                for (int k = 0; k < rooms.GetLength(1); k++)
                {
                    // 각층 첫방은 1
                    if (k == 0)
                    {
                        rooms[j, k] = 1;
                        continue;
                    }

                    rooms[j, k] = rooms[j, k - 1] + rooms[j - 1, k];
                }
            }

            // 마지막 호
            Console.WriteLine(rooms[rooms.GetLength(0) - 1, rooms.GetLength(1) - 1]);
        }
    }
}