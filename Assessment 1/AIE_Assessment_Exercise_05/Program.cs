/*
 * Appendix 2 - Exercise 2: Sorting an Array (Descending)
 */


using System;

namespace AIE_Assessment_Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input comma separated list of numbers");
            string lineOfText = Console.ReadLine();
            string[] values = lineOfText.Split(',');

            int[] numbers = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                numbers[i] = Int32.Parse(values[i]);
            }
            
            // TODO:
            // Write a function that accepts the integer array 'numbers' and outputs the sorted array to the console

            SortDescending(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]},");
            }



            
        }

        static void SortDescending(int[] numbers)
        {
            
            bool sorted = false;
            int lastUnsorted = numbers.Length - 1;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < lastUnsorted ; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        Swap(numbers, i, i + 1);
                        sorted = false;
                    }

                }

            }
            lastUnsorted--;
        }
        static void Swap(int[] numbers, int i, int j)
        {
            int tmp = numbers[i];
            numbers[i] = numbers[i + 1];
            numbers[i + 1] = tmp;
            
        }
    }
}
