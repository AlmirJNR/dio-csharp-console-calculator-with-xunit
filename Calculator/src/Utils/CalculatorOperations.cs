namespace Calculator.Utils;

public static class CalculatorOperations
{
    public static double Sum(double addend1, double addend2) => addend1 + addend2;

    public static double Subtraction(double minuend, double subtrahend) => minuend - subtrahend;

    public static double Multiplication(double multiplicand, double multiplicator) => multiplicand * multiplicator;

    public static bool Division(double divisor, double dividend, out double? quotient)
    {
        if (dividend != 0)
        {
            quotient = divisor / dividend;
            return true;
        }

        quotient = null;
        return false;
    }
}
