namespace _17_Exercises.DiscountCalculator;

public class FixedDiscountCalculator(IDiscountCodeRepository _repository) : IDiscountCalculator
{
    public decimal CalculateDiscount(decimal price, string discountCode)
    {
        if (price<0)
            throw new ArgumentException(nameof(price));
        
        var _fixedCodes = _repository.GetDiscountCodes();
         
        if (_fixedCodes.TryGetValue(discountCode, out var discount))
        {
            return price - (price * discount);
        }

        throw new ArgumentException($"Invalid discount code");
    }
}
