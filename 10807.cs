using System;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');

        int[] ints = new int[num];

        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = int.Parse(inputs[i]);
        }

        int findnum = int.Parse(Console.ReadLine());
        int answer = 0;

        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] == findnum)
            {
                answer++;
            }
        }

        Console.WriteLine(answer);


        Console.ReadLine();
        //https://solved.ac/
    }
}