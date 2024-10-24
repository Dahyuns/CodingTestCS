using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        // 낮 , 밤 , 막대 높이

        int date = 0; // 정답

        int dayDis = int.Parse(input[0]);
        int nightDis = int.Parse(input[1]);
        int goal = int.Parse(input[2]);

        // 무조건 낮에 골에 도달함!

        if (dayDis > goal)
        {
            date = 1;
        }
        else
        {
            double tmp = (double)(goal - dayDis) / (double)(dayDis - nightDis);
            date = (int)Math.Ceiling(tmp) + 1;
        }

        Console.WriteLine(date);
    }
}