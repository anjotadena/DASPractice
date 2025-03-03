using DSAPractice.Recursion;
using Xunit;

namespace DSAPractice.Recursion;

public class CalculateRecursionTests
{
    [Fact]
    public void Calculate_WithPositiveNumber_ReturnsCorrectSum()
    {
        // Arrange
        int input = 5;
        int expected = 15; // 5 + 4 + 3 + 2 + 1 + 0

        // Act
        int result = CalculateRecursion.Calculate(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Calculate_WithZero_ReturnsZero()
    {
        // Arrange
        int input = 0;
        int expected = 0;

        // Act
        int result = CalculateRecursion.Calculate(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Answer_ReturnsCorrectResultString()
    {
        // Arrange
        var calculateRecursion = new CalculateRecursion();
        string expected = "Result: 15";

        // Act
        string result = calculateRecursion.Answer();

        // Assert
        Assert.Equal(expected, result);
    }
}
