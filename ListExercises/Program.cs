using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Sum of even numbers: " + SumEven(numbers));
            List<string> words = new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            SearchLetterWords(words);
        }

        static double SumEven(List<double> numbers)
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


        public static void SearchLetterWords(List<string> words) 
        {
            Console.WriteLine("\nEnter the word length for the search: ");
            string input = Console.ReadLine();
            double searchLength = double.Parse(input);
            Console.WriteLine("\nWords containing exactly " + searchLength + " letters:");
            foreach (string word in words) {
                if (word.Length == searchLength) {
                    Console.WriteLine(word);
                }
            }
        } 
    }     
}