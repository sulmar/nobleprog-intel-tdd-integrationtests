namespace DummyTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var controller = new OrderController(new DiscountOrderCalculator(), new DummyMessageClient());
        
        // Act
        
        // Assert
        
        throw new NotImplementedException();

    }
}