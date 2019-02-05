using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInterface
{
    public interface ICalculation
    {
        decimal Add(decimal number1, decimal number2);
        decimal Subtract(decimal number1, decimal number2);
        decimal Divide(decimal number1, decimal number2);
        decimal Multiply(decimal number1, decimal number2);
    }
}
