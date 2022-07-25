if (args.Count() < 3)
{
    Console.WriteLine("Type a valid expression");
    Environment.Exit(400);
}

var number1 = args[0];
var result1 = double.TryParse(number1, out double parsedNumber1);

while (!result1)
{
    Console.WriteLine("Type a valid first number");
    Console.Write("-> ");
    result1 = double.TryParse(Console.ReadLine(), out parsedNumber1);
}

var operation = args[1];
var operationSymbols = new string[] {"+", "-", "*", "/"};

while (string.IsNullOrWhiteSpace(operation) || !operationSymbols.Contains(operation))
{
    Console.WriteLine("Type a valid operation symbol (+, -, *, /)");
    Console.Write("-> ");
    operation = Console.ReadLine();
}

var number2 = args[2];
var result2 = double.TryParse(number2, out double parsedNumber2);

while (!result2)
{
    Console.WriteLine("Type a valid second number");
    Console.Write("-> ");
    result2 = double.TryParse(Console.ReadLine(), out parsedNumber2);
}

switch (operation)
{
    case "+":
        Console.WriteLine($"= {CalculatorOperations.Sum(parsedNumber1, parsedNumber2)}");
        break;
    case "-":
        Console.WriteLine($"= {CalculatorOperations.Subtraction(parsedNumber1, parsedNumber2)}");
        break;
    case "*":
        Console.WriteLine($"= {CalculatorOperations.Multiplication(parsedNumber1, parsedNumber2)}");
        break;
    case "/":
        var calcInfo = CalculatorOperations.Division(parsedNumber1, parsedNumber2, out double? calcResult);
        Console.WriteLine($"= {(calcInfo ? calcResult : "Cannot divide by zero")}");
        break;
    default:
        break;
}

public static class CalculatorOperations
{
    public static double Sum(double num1, double num2)
    {
        return num1 + num2;
    }

    public static double Subtraction(double num1, double num2)
    {
        return num1 - num2;
    }

    public static double Multiplication(double num1, double num2)
    {
        return num1 * num2;
    }

    public static bool Division(double num1, double num2, out double? calcResult)
    {   
        if (num2 != 0)
        {
            calcResult = num1 / num2;
            return true;
        }

        calcResult = null;
        return false;
    }
}
