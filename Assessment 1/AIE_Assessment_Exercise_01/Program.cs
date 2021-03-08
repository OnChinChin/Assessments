/*
 * Appendix 1 - Exercise 1: Adding Two Numbers
 */

using System;

namespace AIE_Assessment_Exercise_01
{
    class Program
    {
        
         static float Plus(float a, float b)
        {
            float result = a + b;
            return (int)result;
        }
        
        
        static void Main(string[] args)
        {
            float firstNumber = 0f;
            float secondNumber = 0f;

            if (args.Length < 2) args = new string[] { "4.25", "16.5" };

            firstNumber = float.Parse(args[0]);
            secondNumber = float.Parse(args[1]);


            Console.WriteLine(Plus(firstNumber, secondNumber));


            //Console.WriteLine(firstNumber + secondNumber);
            // TODO:
            // Write a function that will sum the two input floating point numbers
            // and return an integer
            // Output your result to the console 
        }
    }
}
