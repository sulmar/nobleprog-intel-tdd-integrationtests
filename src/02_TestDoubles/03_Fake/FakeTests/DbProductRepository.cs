using System.Data;

namespace FakeTests;

/// <summary>
/// Implementacja dostępu do bazy danych Sql
/// </summary>
public class DbProductRepository
{
    private readonly IDbConnection _connection;

    public DbProductRepository(IDbConnection connection)
    {
        _connection = connection;
    }
    
    public Product? Get(int id)
    {
        var sql = "SELECT productid, name, price FROM products WHERE productid = @id";
        
        using var command = _connection.CreateCommand();
        command.CommandText = sql;

        var parameter = command.CreateParameter();
        parameter.ParameterName = "@id";
        parameter.Value = id;
        command.Parameters.Add(parameter);

        using var reader = command.ExecuteReader();
        if (!reader.Read())
            return null;

        return new Product
        {
            Id = reader.GetInt32(reader.GetOrdinal("productid")),
            Name = reader.GetString(reader.GetOrdinal("name")),
            Price = reader.GetDecimal(reader.GetOrdinal("price"))
        };
    }
}