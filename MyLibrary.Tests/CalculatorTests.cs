namespace MyLibrary.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var result = _calculator.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_ReturnsCorrectDifference()
    {
        var result = _calculator.Subtract(10, 4);
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_ReturnsCorrectProduct()
    {
        var result = _calculator.Multiply(3, 4);
        Assert.Equal(12, result);
    }

    [Fact]
    public void Divide_ReturnsCorrectQuotient()
    {
        var result = _calculator.Divide(10, 2);
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Divide_ThrowsException_WhenDivisorIsZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
    }
}