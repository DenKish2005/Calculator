using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class Extensions
    {
        public static bool IsExitCommand(this string? input)
        {
            ArgumentNullException.ThrowIfNull(input);
            return input.Equals("exit", StringComparison.OrdinalIgnoreCase);
        }
    }
}
