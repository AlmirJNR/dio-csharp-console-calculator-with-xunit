using Xunit;

public class UnitTests
{
    [Fact]
    public void Double_Sum_ReturnDouble()
    {   
        // Arrange
        var number1 = 5;
        var number2 = 5;

        // Act
        var result = CalculatorOperations.Sum(number1, number2);

        // Assert
        Assert.Equal(result, 10);
    }

    [Fact]
    public void Double_Subtraction_ReturnDouble()
    {   
        // Arrange
        var number1 = 5;
        var number2 = 5;

        // Act
        var result = CalculatorOperations.Subtraction(number1, number2);

        // Assert
        Assert.Equal(result, 0);
    }

    [Fact]
    public void Double_Multiplication_ReturnDouble()
    {   
        // Arrange
        var number1 = 5;
        var number2 = 5;

        // Act
        var result = CalculatorOperations.Multiplication(number1, number2);

        // Assert
        Assert.Equal(result, 25);
    }

    [Fact]
    public void Double_Division_ReturnDouble()
    {   
        // Arrange
        var number1 = 5;
        var number2 = 5;

        // Act
        var result = CalculatorOperations.Division(number1, number2, out double? calcResult);

        // Assert
        Assert.Equal(result, true);
        Assert.Equal(calcResult, 1);
    }

    [Fact]
    public void Double_DivisionByZero_ReturnDouble()
    {   
        // Arrange
        var number1 = 5;
        var number2 = 0;

        // Act
        var result = CalculatorOperations.Division(number1, number2, out double? calcResult);

        // Assert
        Assert.Equal(result, false);
        Assert.Equal(calcResult, null);
    }
}

