using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Lesson1
{
    internal class Conditions
    {
        public void IfCondition()
        {
            Console.Write("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            if (number > 0 || number < 0)
            {
                Console.WriteLine("The number is not zero.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        public void SwitchCondition()
        {
            Console.Write("Enter a day of the week (1-7):");  
            int number = Convert.ToInt32(Console.ReadLine()); 

            switch(number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                    break;
            }
        }
    }
}
