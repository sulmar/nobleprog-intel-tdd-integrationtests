namespace FakeTests;

public class ProductController
{
    public ActionResult Get(int id)
    {
        throw new NotImplementedException();       
    }
    
}

public abstract class ActionResult { }
public class NotFoundResult : ActionResult { }
public class OkResult<T>(T model) : ActionResult { }