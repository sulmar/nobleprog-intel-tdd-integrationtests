namespace DummyTests;

public class OrderController
{
    private readonly DiscountOrderCalculator _calculator;
    private IMessageClient _gmailApiClient;
    
    public OrderController(
        DiscountOrderCalculator calculator, 
        IMessageClient gmailApiClient)
    {
        _calculator = calculator;
        _gmailApiClient = gmailApiClient;
    }

    public OrderController(DiscountOrderCalculator calculator)
        : this(calculator, new GmailApiClient())
    {
        
    }
    
    public ActionResult Post(Order order)
    {
         order.Discount= _calculator.CalculateDiscount(order);
        
        _gmailApiClient.Send($"You have discount {order.Discount}!");

        return new CreatedResult<Order>(order);
    }
}

public abstract class ActionResult { }
public class CreatedResult<T>(T model) : ActionResult { }

public class DiscountOrderCalculator
{
    public decimal CalculateDiscount(Order order)
    {
        if (order.TotalAmount > 100)
        {
            return order.TotalAmount * 0.5m;
        }

        return 0;
    }
}

public class Order
{
    public decimal TotalAmount { get; set; }
    public decimal Discount { get; set; }
}


// Abstraction
public interface IMessageClient
{
    void Send(string message);   
}

// Concrete 
public class GmailApiClient : IMessageClient
{
    public void Send(string message)
    {
        throw new NotImplementedException();       
    }
}

public class DummyMessageClient : IMessageClient
{
    public void Send(string message) { /* nic nie rob */ }
}
