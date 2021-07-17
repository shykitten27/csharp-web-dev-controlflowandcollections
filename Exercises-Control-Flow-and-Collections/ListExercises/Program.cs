using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        private static object split;

        static void Main(string[] args)
        {
            List<double> numbers = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Sum of even numbers: " + SumEven(numbers));
            List<string> words = new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            SearchLetterWords(words);
            string sentence = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            List<string> list = new List<string>();
            list = sentence.Split('.').ToList();
            foreach (string l in list)
            {
                Console.WriteLine(l);
            }
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