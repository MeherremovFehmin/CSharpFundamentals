using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Lesson1
{
    internal class Strings
    {
        public void GetStringLength()
        {
            Console.Write("Enter a string:");
            string str = Console.ReadLine();

            int length = str.Length;
            Console.WriteLine($"Length of the string: {length}");
        }

        public void GetStringLengthByJeyhun()
        {
            Console.Write("Enter a string:");
            string str = Console.ReadLine();

            int length = 0;

            foreach (char c in str)
            {
                Console.WriteLine($"{length}: {c}");
                length++;
            }

            Console.WriteLine($"Length of the string: {length}");
        }

        public void CalculateSymbolsCount()
        {
            Console.Write("Enter a string:");
            string str = Console.ReadLine();

            Console.Write("Enter a symbol:");
            char symbol = Console.ReadLine()[0];

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                {
                    count++;
                }
            }

            Console.WriteLine($"Count of symbol '{symbol}' in the string: {count}");

        }

        public void UseContains()
        {
            Console.Write("Enter a text:");
            string str = Console.ReadLine();

            Console.Write("Enter a word:");
            string word = Console.ReadLine();

            bool isExists = str.Contains(word, StringComparison.OrdinalIgnoreCase);

            if (isExists == true)
            {
                Console.WriteLine("The word exists in the text.");
            }
            else
            {
                Console.WriteLine("The word does not exist in the text.");
            }
        }

    }
}
