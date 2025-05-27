namespace DummyTests;

public class OrderController
{
    private readonly DiscountOrderCalculator _calculator;
    private readonly GmailApiClient _gmailApiClient;
    
    public OrderController(DiscountOrderCalculator calculator, GmailApiClient gmailApiClient)
    {
        _calculator = calculator;
        _gmailApiClient = gmailApiClient;
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


public class GmailApiClient
{
    public void Send(string message)
    {
        throw new NotImplementedException();       
    }
}
