using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string num = Console.ReadLine();

            if (num == "0" || num == null) break;

            while (num[0] == '0')
            {
                string tmp = "";
                for (int i = 1; i < num.Length; i++)
                {
                    tmp += num[i];
                }
                num = tmp;
            }

            if (num == "0" || num == null) break;

            bool isPelin = true;

            // 자리수가 짝수일때
            if (num.Length % 2 == 0)
            {
                for (int i = 0; i < num.Length / 2; i++)
                {
                    if (num[i] != num[num.Length - 1 - i])
                    {
                        isPelin = false;
                        break;
                    }
                }
            }
            // 자리수가 홀수일때
            else if (num.Length % 2 != 0)
            {
                for (int i = 0; i < (num.Length - 1) / 2; i++)
                {
                    if (num[i] != num[num.Length - 1 - i])
                    {
                        isPelin = false;
                        break;
                    }
                }
            }

            if (isPelin)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}