using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Conditions
{
    public interface IConditionService
    {
        string GetMonthName(int monthNumber);
        bool IsNumberPositive(double number);
    }
}
