using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Loops
{
    public interface ILoopService
    {
        public int GetSum(int number);
        public double GetAverage(double[] arr);
        public int GetNumberDigitsCount(int number);
        public long GetFactorial(int number);
    }
}
