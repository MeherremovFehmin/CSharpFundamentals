using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Lesson1
{
    internal class Loops
    {
        public Loops()
        {
            Console.WriteLine("Loops class constructor");
        }

        public void ForLoop()
        {
            Console.Write("Enter n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;

                if (i % 2 == 0)
                {
                    evenSum = evenSum + i;
                }
                else
                {
                    oddSum = oddSum + i;
                }

                Console.WriteLine($"Sum({i}): {sum}");
                Console.WriteLine($"OddSum({i}): {oddSum}");
                Console.WriteLine($"EvenSum({i}): {evenSum}");
                Console.WriteLine();
            }

            Console.WriteLine($"Sum: {sum}");
        }

        public void ForeachLoop()
        {
            string[] names = { "John", "Jane", "Doe" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public void WhileLoop()
        {
            Console.Write("Enter n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int i = 1;

            while (i <= n)
            {
                sum = sum + i;
                Console.WriteLine($"Sum({i}): {sum}");
                i++;
            }
            Console.WriteLine($"Sum: {sum}");
        }

        public void DoWhileLoop()
        {
            Console.Write("Enter n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int i = 1;

            do
            {
                sum = sum + i;
                Console.WriteLine($"Sum({i}): {sum}");
                i++;
            } while (i <= n);
            Console.WriteLine($"Sum: {sum}");

        }

    }
}
