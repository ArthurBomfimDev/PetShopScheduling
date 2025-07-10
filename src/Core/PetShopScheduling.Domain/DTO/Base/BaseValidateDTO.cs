using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Domain.DTO.Base;

public class BaseValidateDTO<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
{
    public bool Invalid { get; private set; }
    public bool Ignore { get; private set; }

    public bool SetInvalid()
    {
        return Invalid = true;
    }

    public bool SetIgnore()
    {
        return Ignore = true;
    }

    public TInputCreate? InputCreate { get; set; }
    public TInputIdentityUpdate? InputIdentityUpdate { get; set; }
    public TInputIdentityDelete? InputIdentityDelete { get; set; }
}