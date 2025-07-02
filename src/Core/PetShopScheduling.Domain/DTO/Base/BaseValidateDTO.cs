using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Domain.DTO.Base;

public class BaseValidateDTO<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
{
    public TInputCreate? InputCreate { get; set; }
    public TInputIdentityUpdate? InputIdentityUpdate { get; set; }
    public TInputIdentityDelete? InputIdentityDelete { get; set; }
}