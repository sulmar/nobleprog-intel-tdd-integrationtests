namespace FakeTests;

// TODO: Przetestuj działanie tej klasy
// Zauważ, że nie mamy dostępu do bazy danych Sql
// Zrefaktoruj ten kod, bo ten sam mechanizm cache będzie potrzebny w innych miejscach

public interface IProductRepository
{
    Product? Get(int id);
}

public class ProductsController
{
    private readonly IProductRepository _productRepository;
    private readonly CacheProductRepository _cacheProductRepository;

    public ProductsController(
        IProductRepository productRepository, 
        CacheProductRepository cacheProductRepository)
    {
        this._productRepository = productRepository;
        this._cacheProductRepository = cacheProductRepository;
    }

    public Product? Get(int id)
    {
        Product? product = _cacheProductRepository.Get(id);

        if (product == null)
        {
            product = _productRepository.Get(id);

            if (product != null)
            {
                _cacheProductRepository.Add(product);
            }
        }
        
        return product;
    }
}

