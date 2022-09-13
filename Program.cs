using System;
using System.Linq;

namespace AlphabeticLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many letters do you want?: ");

            int n = int.Parse(Console.ReadLine());

            string[] letters = new string[n];

            Console.Write($"Type {n} letters from Alphabet (separated by a space)... ");

            letters = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .ToArray();

            SortLetters(n, letters);

        }

        static void SortLetters(int n, string[] letters)
        {

            Console.Write("Here are they alphabetic: ");

            Array.Sort(letters);

            Console.Write(string.Join(' ', letters));
            
        }
    }
}