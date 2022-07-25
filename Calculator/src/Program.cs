using Calculator.Utils;

if (args.Count() < 3)
{
    Console.WriteLine("Type a valid expression");
    Environment.Exit(400);
}
var modifiedArgs = new string[3];

var number1 = args[0];
var result1 = double.TryParse(number1, out double parsedNumber1);

while (!result1)
{
    Console.WriteLine("Type a valid first number");
    Console.Write("-> ");
    result1 = double.TryParse(Console.ReadLine(), out parsedNumber1);
}
modifiedArgs[0] = parsedNumber1.ToString();

var operation = args[1];
var operationSymbols = new string[] {"+", "-", "*", "/"};

while (string.IsNullOrWhiteSpace(operation) || !operationSymbols.Contains(operation))
{
    Console.WriteLine("Type a valid operation symbol (+, -, *, /)");
    Console.Write("-> ");
    operation = Console.ReadLine();
}
modifiedArgs[1] = operation;

var number2 = args[2];
var result2 = double.TryParse(number2, out double parsedNumber2);

while (!result2)
{
    Console.WriteLine("Type a valid second number");
    Console.Write("-> ");
    result2 = double.TryParse(Console.ReadLine(), out parsedNumber2);
}
modifiedArgs[2] = parsedNumber2.ToString();

double? calcResult = null;
switch (operation)
{
    case "+":
        calcResult = CalculatorOperations.Sum(parsedNumber1, parsedNumber2);
        Console.WriteLine($"= {calcResult}");
        break;
    case "-":
        calcResult = CalculatorOperations.Subtraction(parsedNumber1, parsedNumber2);
        Console.WriteLine($"= {calcResult}");
        break;
    case "*":
        calcResult = CalculatorOperations.Multiplication(parsedNumber1, parsedNumber2);
        Console.WriteLine($"= {calcResult}");
        break;
    case "/":
        var calcInfo = CalculatorOperations.Division(parsedNumber1, parsedNumber2, out calcResult);
        Console.WriteLine($"= {(calcInfo ? calcResult : "Cannot divide by zero")}");
        break;
    default:
        break;
}

LogMaker.CreateLog(args, modifiedArgs, calcResult);
