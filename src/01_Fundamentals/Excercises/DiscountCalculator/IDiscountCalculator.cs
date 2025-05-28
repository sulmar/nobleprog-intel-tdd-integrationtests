namespace _17_Exercises.DiscountCalculator;

public interface IDiscountCalculator
{
    public decimal CalculateDiscount(decimal price, string discountCode);
}