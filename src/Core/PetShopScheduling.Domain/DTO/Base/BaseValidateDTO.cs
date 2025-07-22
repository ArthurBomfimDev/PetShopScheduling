using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Domain.DTO.Base;

public class BaseValidateDTO
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
}

#region 1 - Create, Update, Delete
public class BaseValidateDTO_1<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete> : BaseValidateDTO
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
{
    public TInputCreate? InputCreate { get; private set; }
    public TInputUpdate? InputUpdate { get; private set; }
    public TInputIdentityUpdate? InputIdentityUpdate { get; private set; }
    public TInputIdentityDelete? InputIdentityDelete { get; private set; }
}
#endregion

#region 2 - Create
public class BaseValidateDTO_2<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete> : BaseValidateDTO
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate_0
    where TInputIdentityUpdate : BaseInputIdentityUpdate_0
    where TInputIdentityDelete : BaseInputIdentityDelete_0
{
    public TInputCreate? InputCreate { get; private set; }
    public TInputUpdate? InputUpdate { get; private set; }
    public TInputIdentityUpdate? InputIdentityUpdate { get; private set; }
    public TInputIdentityDelete? InputIdentityDelete { get; private set; }
}
#endregion

#region 3 - Create, Update
public class BaseValidateDTO_3<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete> : BaseValidateDTO
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete_0
{
    public TInputCreate? InputCreate { get; private set; }
    public TInputUpdate? InputUpdate { get; private set; }
    public TInputIdentityUpdate? InputIdentityUpdate { get; private set; }
    public TInputIdentityDelete? InputIdentityDelete { get; private set; }
}
#endregion