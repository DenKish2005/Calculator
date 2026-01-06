// See https://aka.ms/new-console-template for more information

using Calculator;

History history = new History();

while (true)
{
    history.Print();
    Console.WriteLine();

    Console.WriteLine("Enter operation (or 'exit'):");
    string input = Console.ReadLine() ?? "";

    if (input.IsExitCommand())
    {
        break;
    }

    try
    {
        ParsedOperation parsed = OperationParser.Parse(input);

        double result = Calculator.Calculator.Calculate(
            parsed.Number1,
            parsed.Number2,
            parsed.Operation
        );

        Console.Clear();
        Console.WriteLine($"Your result is {result}");

        history.Add($"{parsed.Number1} {parsed.Operation} {parsed.Number2} = {result}");
    }

    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine($"Error: {ex.Message}");
    }

    Console.WriteLine();
    Console.WriteLine("Press a key to continue");

    Console.ReadKey();
    Console.Clear();
}
