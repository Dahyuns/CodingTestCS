using System;

class Program
{
    static void Main(string[] args)
    {
        int howMany = int.Parse(Console.ReadLine());
        string[] shirtsSize = (Console.ReadLine().Split(' '));
        // 티셔츠와 펜 묶음
        string[] bundleN = (Console.ReadLine().Split(' '));
        int totalShirts = 0;

        for (int i = 0; i < shirtsSize.Length; i++)
        {
            int thisShirt = int.Parse(shirtsSize[i]);

            if (thisShirt == 0) { continue; }

            int tmp = thisShirt / int.Parse(bundleN[0]);
            if (tmp > 0)
            {
                totalShirts += tmp;
                if (thisShirt % int.Parse(bundleN[0]) > 0)
                {
                    totalShirts++;
                }
            }
            else
            {
                totalShirts++;
            }
        }

        // 티셔츠
        Console.WriteLine("{0}", totalShirts);

        // 펜
        Console.WriteLine("{0} {1}",
            (howMany / int.Parse(bundleN[1])),
            (howMany % int.Parse(bundleN[1])));
    }
}