namespace _17_Exercises.DiscountCalculator;

public interface IDiscountCodeRepository
{
    IDictionary<string, decimal> GetDiscountCodes();
}