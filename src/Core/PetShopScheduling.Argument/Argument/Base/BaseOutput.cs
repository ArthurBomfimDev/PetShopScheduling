namespace PetShopScheduling.Argument.Argument.Base;

public class BaseOutput<TOutput> where TOutput : BaseOutput<TOutput>
{
    public long Id { get; private set; }

    public BaseOutput() { }

    public BaseOutput(long id)
    {
        Id = id;
    }
}
public class BaseOutput_0 : BaseOutput<BaseOutput_0> { }