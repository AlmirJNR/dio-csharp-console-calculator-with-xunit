using Xunit;
using Calculator.Utils;

public class UnitTests
{
    // Arrange
    [Theory]
    [InlineData(5, 5, 10)]
    [InlineData(10, 2, 12)]
    [InlineData(500, 501, 1001)]
    [InlineData(352, 559, 911)]
    [InlineData(1, -10, -9)]
    public void Sum_Should_Return_Double(double addend1, double addend2, double expectedResult)
    {   
        // Act
        var result = CalculatorOperations.Sum(addend1, addend2);

        // Assert
        Assert.Equal(result, expectedResult);
    }

    // Arrange
    [Theory]
    [InlineData(5, 5, 0)]
    [InlineData(10, 2, 8)]
    [InlineData(500, 501, -1)]
    [InlineData(352, 559, -207)]
    [InlineData(1, -10, 11)]
    public void Subtraction_Should_Return_Double(double minuend, double subtrahend, double expectedResult)
    {   
        // Act
        var result = CalculatorOperations.Subtraction(minuend, subtrahend);

        // Assert
        Assert.Equal(result, expectedResult);
    }

    // Arrange
    [Theory]
    [InlineData(5, 5, 25)]
    [InlineData(10, 2, 20)]
    [InlineData(500, 2, 1000)]
    [InlineData(850, 8, 6800)]
    [InlineData(923, 8, 7384)]
    public void Multiplication_Should_Return_Double(double multiplicand, double multiplicator, double expectedResult)
    {   
        // Act
        var result = CalculatorOperations.Multiplication(multiplicand, multiplicator);

        // Assert
        Assert.Equal(result, expectedResult);
    }

    // Arrange
    [Theory]
    [InlineData(5, 5, 1)]
    [InlineData(10, 2, 5)]
    [InlineData(500, 2, 250)]
    [InlineData(850, 8, 106.25)]
    [InlineData(923, 8, 115.375)]
    public void Division_Should_Return_Double(double divisor, double dividend, double expectedResult)
    {   
        // Act
        var result = CalculatorOperations.Division(divisor, dividend, out double? quotient);

        // Assert
        Assert.Equal(result, true);
        Assert.Equal(quotient, expectedResult);
    }

    // Arrange
    [Theory]
    [InlineData(5, 0, null)]
    [InlineData(105, 0, null)]
    [InlineData(5002, 0, null)]
    [InlineData(302, 0, null)]
    [InlineData(1234, 0, null)]
    public void DivisionByZero_Should_Return_Null(double divisor, double dividend, double expectedResult)
    {   
        // Act
        var result = CalculatorOperations.Division(divisor, dividend, out double? quotient);

        // Assert
        Assert.Equal(result, false);
        Assert.Equal(quotient, null);
    }
}

