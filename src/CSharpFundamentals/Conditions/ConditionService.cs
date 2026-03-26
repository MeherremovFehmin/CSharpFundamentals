using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Conditions
{
    public class ConditionService : IConditionService
    {
        public bool IsNumberPositive(double number)
        {
            return number > 0;
        }
    }
}
