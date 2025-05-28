namespace _17_Exercises.DiscountCalculator;

public class FixedDiscountCalculator : IDiscountCalculator
{
    private readonly Dictionary<string, decimal> _fixedCodes = new()
    {
        { "DISCOUNT20OFF", 0.2m },
        { "SAVE10NOW", 0.1m }
    };

    public decimal CalculateDiscount(decimal price, string discountCode)
    {
        if (price<0)
            throw new ArgumentException(nameof(price));
        
        if (_fixedCodes.TryGetValue(discountCode, out var discount))
        {
            return price - (price * discount);
        }

        throw new ArgumentException($"Invalid discount code");
    }
}
