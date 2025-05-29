using System.Data;

namespace _17_Exercises.DiscountCalculator;

// TODO: dodać czasowe kody kuponow np. 15 min

public class FakeDiscountCodeRepository : IDiscountCodeRepository
{
    private readonly IDictionary<string, decimal> _fixedCodes = new Dictionary<string, decimal>()
    {
        { "DISCOUNT20OFF", 0.2m },
        { "SAVE10NOW", 0.1m }
    };
    public IDictionary<string, decimal> GetDiscountCodes()
    {
        return _fixedCodes; 
    }
}


public class DbDiscountCodeRepository(IDbConnection connection) : IDiscountCodeRepository
{
    public IDictionary<string, decimal> GetDiscountCodes()
    {
        throw new NotImplementedException();
    }
}

public static class IDictionaryExtensions
{
    public static int Count(this IDictionary<decimal, decimal> dictionary)
    {
        return dictionary.Count;
    }
}