namespace Calculator.Utils;

public static class CalculatorOperations
{
    public static double Sum(double num1, double num2) => num1 + num2;

    public static double Subtraction(double num1, double num2) => num1 - num2;

    public static double Multiplication(double num1, double num2) => num1 * num2;

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
