using System;

class Program
{
    static void Main(string[] args)
    {
        int nextNum = 0;

        for (int i = 0; i < 3; i++)
        {
            string input = Console.ReadLine();

            if (input == "Fizz" || input == "Buzz" || input == "FizzBuzz")
            {
                continue;
            }
            nextNum = int.Parse(input) + (3 - i);
        }

        // 3의 배수이면서 5의 배수
        if (nextNum % 3 == 0 && nextNum % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        // 3의 배수
        else if (nextNum % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        // 5의 배수
        else if (nextNum % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        // 다아님
        else
        {
            Console.WriteLine(nextNum);
        }
    }
}