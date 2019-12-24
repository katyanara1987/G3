using System;

namespace HomeTask3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter range of natural numbers. Range should be not less than 10 values!");

            InputProcessor input = new InputProcessor();

            int start, finish, attemptsCount = 0;

            do
            {
                if (attemptsCount != 0)
                {
                    Console.WriteLine("Please try again. You have " + (5 - attemptsCount) + " attempt(-s) left.");
                }
                Console.WriteLine("Please input first value of the range.");
                var firstValue = input.TakeConsoleInput();
                Console.WriteLine("Please input last value of the range.");
                var lastValue = input.TakeConsoleInput();

                start = firstValue > lastValue ? lastValue : firstValue;
                finish = lastValue > firstValue ? lastValue : firstValue;

                attemptsCount++;
            } while (finish - start < 10 || attemptsCount > 5);

            var sum = 0;
            for (int i = start; i <= finish; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.Write($"{i} \t");
                    sum += i;
                }
            }

            Console.WriteLine($"\nSum is: {sum}");
        }
    }
}
