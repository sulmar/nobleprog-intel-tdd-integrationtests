using System.Data;

namespace FakeTests;

/// <summary>
/// Implementacja dostępu do bazy danych Sql
/// </summary>
/// <remarks>
/// Ten kod jest oparty na standardowym IDbConnection, co pozwala go stosować zarówno z SqlConnection (SQL Server), NpgsqlConnection (PostgreSQL), jak i innymi dostawcami ADO.NET
/// </remarks>
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