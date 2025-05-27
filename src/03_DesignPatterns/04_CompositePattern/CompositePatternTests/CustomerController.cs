namespace CompositePatternTests;

public class CustomerController
{
    private ICustomerValidator _validator;

    public CustomerController(ICustomerValidator validator)
    {
        _validator = validator;
    }

    public ActionResult Post(Customer customer)
    {
        if (!_validator.IsValid(customer))
        {
            return new BadRequestResult();
        }

        return new OkResult<Customer>(customer);
    }
}

public interface ICustomerValidator
{
    bool IsValid(Customer customer);
}

public record class Customer(string Name, string Email, string Nip, string Regon);

public abstract class ActionResult { }
public class OkResult<T>(T model) : ActionResult { }
public class BadRequestResult : ActionResult { } 