using System;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements = 10;
            int[] numbers = new int[elements];
            int minNumber = 0;
            int maxNumber = 10;
            int temp;

            Random random = new Random();

            for (int i = 0; i < elements; i++)
            {
                numbers[i] = random.Next(minNumber, maxNumber);
            }

            for (int i = 0; i < elements; i++)
            {
                Console.Write(numbers[i]+" ");
            }

            for (int i = 0; i < elements; i++)
            {
                for (int j = 0; j < elements-1-i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < elements; i++)
            {
                Console.Write(numbers[i]+" ");
            }
        }
    }
}
