/*
 * Appendix 1 - Exercise 2: Fibonacci
 */

using System;

namespace AIE_Assessment_Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = 10;

            if (args.Length < 1) args = new string[] { "10" };

            numberOfElements = Int32.Parse(args[0]);

            // TODO:
            // Write a function that will, given an integer n, calculate the first n numbers in the 
            // Fibonacci sequence given starting elements of (0, 1). 
            // Output your result to the console

            var results = Fibonacci(numberOfElements);

            for(int i=0; i< results.Length; i++)
            {
                Console.WriteLine(results[i]);
            }

            
        }
        static int[] Fibonacci(int numberOfElements)
        {
            int[] n = new int[numberOfElements];
            n[0] = 0;
            n[1] = 1;

            for(int i=2; i< numberOfElements; i++)
            {
                n[i] = n[i - 1] + n[i - 2];
            }
          
            return n;
      

        }
        

    }
}
