namespace PetShopScheduling.Argument.Argument.Base;

public abstract class BaseInputIdentityView<TInputIndetityView> where TInputIndetityView : BaseInputIdentityView<TInputIndetityView> 
{
    public virtual long Id { get; private set; }
}
public class BaseInputIdentityView_0 : BaseInputIdentityView<BaseInputIdentityView_0> { }