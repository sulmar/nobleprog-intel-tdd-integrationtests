using Xunit;

namespace _17_Exercises.DiscountCalculator;

public class OneTimeDiscountCalculatorTests
{
    private IDiscountCalculator _calculator = new OneTimeDiscountCalculator(new FixedDiscountCalculator(new FakeDiscountCodeRepository()));

    [Fact]
    public void CalculateDiscount_FirstUseOfFiftyDiscountCode_ReturnsPriceAfterDiscount()
    {
        // Arrange
        string discountCode = "EXTRA";
        decimal price = 150;
        decimal expectedPrice = 75;

        // Act
        decimal discountPrice = _calculator.CalculateDiscount(price, discountCode);

        // Assert
        Assert.Equal(expectedPrice, discountPrice);
    }

    [Fact]
    public void CalculateDiscount_SeconduseOfFiftyDiscountCode_ThrowAnInvalidDiscountCountException()
    {
        // Arrange
        string discountCode = "EXTRA";
        decimal price = 150;
        decimal expectedPrice = 75;
        _calculator.CalculateDiscount(price, discountCode);

        // Act && Assert
        Assert.Throws<ArgumentException>(()=>_calculator.CalculateDiscount(price, discountCode));
    }
    
    
}