using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class History
    {
        private readonly List<string> _operations = new();
        public void Add(string entry)
        {
            _operations.Add(entry);
        }

        public void Print()
        {
            if (_operations.Count == 0)
            {
                Console.WriteLine("History is empty");
                return;
            }

            Console.WriteLine("History:");
            Console.WriteLine();

            foreach (var operation in _operations)
            {
                Console.WriteLine(operation);
            }
        }
    }
}
