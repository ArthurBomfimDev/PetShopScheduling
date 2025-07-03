using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Base;

public abstract class BaseInputIdentityDelete<TInputIdentityDelete> where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
{
    public long Id { get; set; }

    [JsonConstructor]
    public BaseInputIdentityDelete(long id)
    {
        Id = id;
    }
}
public class BaseInputIdentityDelete_0(long id) : BaseInputIdentityDelete<BaseInputIdentityDelete_0>(id) { }