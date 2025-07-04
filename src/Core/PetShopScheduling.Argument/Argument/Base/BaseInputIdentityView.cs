using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Base;

public class BaseInputIdentityView<TInputIndetityView> where TInputIndetityView : BaseInputIdentityView<TInputIndetityView> 
{
    public long Id { get; set; }

    public BaseInputIdentityView() { }

    public BaseInputIdentityView(long id)
    {
        Id = id;
    }
}
public class BaseInputIdentityView_0 : BaseInputIdentityView<BaseInputIdentityView_0> { }