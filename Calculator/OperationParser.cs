using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class OperationParser
    {
        private static readonly char[] AllowedOperations = { '+', '*', '/', '%', '-' };

        public static ParsedOperation Parse(string input)
        {
            ValidateInput(input);

            input = input.Replace(" ", "");

            char operation = AllowedOperations
                .FirstOrDefault(op => input.IndexOf(op, 1) != -1);

            AssertOperationIsNotDefault(operation);

            int operationIndex = input.IndexOf(operation, 1);

            string left = input[..operationIndex];
            string right = input[(operationIndex + 1)..];

            double number1 = TryParseDouble(left);
            double number2 = TryParseDouble(right);

            return new ParsedOperation(number1, number2, operation);
        }

        private static void ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input cannot be empty");
            }
        }

        private static void AssertOperationIsNotDefault(char operation)
        {
            if (operation == default)
            {
                throw new InvalidOperationException("No valid operation found in input");
            }
        }

        private static double TryParseDouble(string operand)
        {
            if (!double.TryParse(operand,
                            NumberStyles.Float,
                            CultureInfo.InvariantCulture,
                            out double number1))
            {
                throw new ArgumentException("First operand is not a valid number");
            }

            return number1;
        }
    }
}
