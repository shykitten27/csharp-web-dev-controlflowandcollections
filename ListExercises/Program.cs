using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Sum of even numbers: " + sumEven(numbers));
            List<string> words = new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
        }

        static double sumEven(List<double> numbers)
        {
            double sum = 0.0;
            foreach (double number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                    sum += number;
                }
            }
            return sum;
        }

        //static string fiveLetterWords(List<string> words)
    }     
}