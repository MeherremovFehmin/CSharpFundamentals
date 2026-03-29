using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Loops
{
    public class LoopService : ILoopService
    {
        public int GetSum(int number)
        {
            if (number < 1)
            {
                throw new ArgumentException("Number must be greater than 0.");
            }

            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }

            return sum;
        }

        public double GetAverage(double[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }

            double sum = 0;

            foreach (double p in arr)
            {
                sum=sum+p; 
            }

            return Math.Round(sum / arr.Length, 5);    
        }

        public int GetNumberDigitsCount(int number)
        {
            throw new NotImplementedException();
        }

        public long GetFactorial(int number)
        {
            throw new NotImplementedException();

          
        }
    }
}
