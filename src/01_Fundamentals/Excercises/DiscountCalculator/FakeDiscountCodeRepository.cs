namespace _17_Exercises.DiscountCalculator;

public class FakeDiscountCodeRepository : IDiscountCodeRepository
{
    private readonly Dictionary<string, decimal> _fixedCodes = new()
    {
        { "DISCOUNT20OFF", 0.2m },
        { "SAVE10NOW", 0.1m }
    };
    public IDictionary<string, decimal> GetDiscountCodes()
    {
        return _fixedCodes; 
    }
}