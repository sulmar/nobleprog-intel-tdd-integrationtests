namespace FakeTests;

public class FakeProductRepository : IProductRepository
{
    private IDictionary<int, Product> _products = new Dictionary<int, Product>();


    public FakeProductRepository()
    {
        _products.Add(1, new Product { Id = 1, Name = "Product 1", Price = 100 });
        
        _products.Add(2, new Product { Id = 2, Name = "Product 2", Price = 100 });
        
        _products.Add(3, new Product { Id = 3, Name = "Product 3", Price = 100 });
    }
    
    public Product? Get(int id)
    {
        if (_products.TryGetValue(id, out var product))
            return product;
        return null;
    }
}