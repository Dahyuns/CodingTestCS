using System;

class Program
{
    static void Main(string[] args)
    {
        // 메모리 최대한 안쓰고 출력하기

        int N = int.Parse(Console.ReadLine());

        int MAX_NUM = 10000; //입력 받는 수의 최대 값            

        int[] countArray = new int[MAX_NUM + 1]; //입력 받은 수 카운트 할 배열 

        //입력 받은 수를 카운팅 
        int temp = 0;

        for (int i = 0; i < N; i++)
        {
            temp = int.Parse(Console.ReadLine());
            countArray[temp]++;
        }

        using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
        {
            //카운팅 된 숫자를 출력 
            for (int i = 0; i <= MAX_NUM; i++)
            {
                if (countArray[i] == 0) continue;
                for (int j = 0; j < countArray[i]; j++)
                {
                    print.WriteLine(i);
                }
            }
        }
    }
}