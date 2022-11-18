using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int gap = 0;

            for (int i = 0; i < 300; i++)
            {
                int count = 0;

                for (int j = i; j > 0; j--)
                {
                    if (i % j == 0) count++;
                }

                if (count > 2)
                {
                    gap++;
                    continue;
                }

                Console.Write($"Простое число {i} на {gap + 1} больше, чем предыдущее    ");
                Console.WriteLine($"Prime number {i} bigger then previous by {gap + 1}");
                gap = 0;
            }

            Console.ReadLine();

        }
    }
}
