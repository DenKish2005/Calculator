using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class ParsedOperation
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public char Operation { get; set; }

        public ParsedOperation(double number1, double number2, char operation)
        {
            Number1 = number1;
            Number2 = number2;
            Operation = operation;
        }
    }
}
