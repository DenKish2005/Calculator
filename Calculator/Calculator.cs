using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class Calculator
    {

        public static double Calculate(double number1, double number2, char operation)
        {
            return operation switch
            {
                '+' => number1 + number2,
                '-' => number1 - number2,
                '*' => number1 * number2,
                '/' => Divide(number1, number2),
                '%' => number1 % number2,
                _ => throw new InvalidOperationException("Invalid operation"),
            };
        }

#pragma warning disable 
        private static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Division by zero");

            return a / b;
        }
#pragma warning restore
    }
}

