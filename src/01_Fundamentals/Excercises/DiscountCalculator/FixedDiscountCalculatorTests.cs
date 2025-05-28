using Xunit;

namespace _17_Exercises.DiscountCalculator;

public class FixedDiscountCalculatorTests
{
    private FixedDiscountCalculator _calculator = new();
    
    [Theory]
    [InlineData(100, 90)]
    [InlineData(50, 45)]
    [InlineData(10, 9)]
    [InlineData(88, 79.2)]
    [InlineData(69.9, 62.91)]
    public void CalculateDiscount_SetSave10Now_ReturnsPriceAfterDiscount(decimal price, decimal expectedPrice)
    {
        // Arrange
        string discountCode = "SAVE10NOW";

        // Act
        decimal discountPrice = _calculator.CalculateDiscount(price, discountCode);

        // Assert
        Assert.Equal(expectedPrice, discountPrice);
    }

    [Theory]
    [InlineData(100, 80)]
    [InlineData(50, 40)]
    [InlineData(10, 8)]
    [InlineData(88, 70.4)]
    [InlineData(69.9, 55.92)]
    public void CalculateDiscount_SetDiscount20_ReturnsPriceAfterDiscount(decimal price, decimal expectedPrice)
    {
        // Arrange
        string discountCode = "DISCOUNT20OFF";

        // Act
        decimal discountPrice = _calculator.CalculateDiscount(price, discountCode);

        // Assert
        Assert.Equal(expectedPrice, discountPrice);
    }

    [Theory]
    [InlineData(100, 100)]
    [InlineData(50, 50)]
    [InlineData(0, 0)]
    [InlineData(99.9, 99.9)]
    public void CalculateDiscount_EmptyDiscountCode_ReturnsPriceWithoutDiscount(decimal price, decimal expectedPrice)
    {
        // Arrange
        string discountCode = string.Empty;

        // Act
        decimal discountPrice = _calculator.CalculateDiscount(price, discountCode);

        // Assert
        Assert.Equal(expectedPrice, discountPrice);
    }

    [Theory]
    [InlineData(100, 100)]
    [InlineData(50, 50)]
    [InlineData(0, 0)]
    [InlineData(99.9, 99.9)]
    public void CalculateDiscount_NullDiscountCount_ReturnsPriceWithoutDiscount(decimal price, decimal expectedPrice)
    {
        // Arrange
        string discountCode = null;

        // Act
        decimal discountPrice = _calculator.CalculateDiscount(price, discountCode);

        // Assert
        Assert.Equal(expectedPrice, discountPrice);
    }

    [Theory]
    [InlineData(10, "badc0de", "Invalid discount code")]
    [InlineData(10, "badcSAVE10NOW0de", "Invalid discount code")]
    [InlineData(10, "iasdiasdDISCOUNT20OFF", "Invalid discount code")]
    [InlineData(40, "daj znizke", "Invalid discount code")]
    [InlineData(0, "adminadmin", "Invalid discount code")]
    public void CalculalteDiscount_IncorrectDiscountCode_ReturnsExceptionMessage(decimal price, string code,
        string message)
    {
        // Arrange
        Action act = () => _calculator.CalculateDiscount(price, code);

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(act);
        Assert.Equal(message, exception.Message);
    }

    [Theory]
    [InlineData(-30, "SAVE10NOW", "Negatives not allowed")]
    [InlineData(-30, "DISCOUNT20OFF", "Negatives not allowed")]
    public void CalculateDiscount_IncorrectPriveValue_ReturnsExceptionMessage(decimal price, string discountCode,
        string message)
    {
        // Arrange
        Action act = () => _calculator.CalculateDiscount(price, discountCode);

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(act);
        Assert.Equal(exception.Message, message);
    }
}