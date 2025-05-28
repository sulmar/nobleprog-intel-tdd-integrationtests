namespace FakeTests;

/// <summary>
/// Implementacja cache (pamięci podręcznej) w pamięci
/// </summary>
public class CacheProductRepository
{
    private IDictionary<int, Product> _products = new Dictionary<int, Product>();
    
    public void Add(Product product)
    {
        _products.Add(product.Id, product);
    }

    public Product? Get(int id)
    {
        if (_products.TryGetValue(id, out Product? product))
        {
            product.CacheHit++; // Licznik trafień

            return product;
        }
        else
            return null;            
    }
}