namespace PetShopScheduling.Argument.Argument.Base;

public class BaseOutput<TOutuput> where TOutuput : BaseOutput<TOutuput>
{
    public long Id { get; private set; }

    public BaseOutput() { }

    public BaseOutput(long id)
    {
        Id = id;
    }
}
public class BaseOutput_0 : BaseOutput<BaseOutput_0> { }