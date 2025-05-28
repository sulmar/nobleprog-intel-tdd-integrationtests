namespace _17_Exercises.DiscountCalculator;

public class OneTimeDiscountCalculator : IDiscountCalculator
{
    private readonly IDiscountCalculator _inner;

   private readonly Dictionary<string, decimal> _discountCodes = new()
   {
        { "EXTRA", 0.5m }
   };

    public OneTimeDiscountCalculator(IDiscountCalculator inner)
    {
        this._inner = inner;
    }

    public decimal CalculateDiscount(decimal price, string discountCode)
    {
        if (price<0)
            throw new ArgumentException(nameof(price));
        
        if (_discountCodes.TryGetValue(discountCode, out decimal discount))
        {
            _discountCodes.Remove(discountCode);

            return price - (price * discount);
        }

        return _inner.CalculateDiscount(price, discountCode);
    }
}