using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Domain.DTO.Base;

public class BaseValidateDTO_1<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete> : BaseValidateDTO
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
{
    public TInputCreate? InputCreate { get; private set; }
    public TInputIdentityUpdate? InputIdentityUpdate { get; private set; }
    public TInputIdentityDelete? InputIdentityDelete { get; private set; }

    public virtual BaseValidateDTO_1<TInputCreate,TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete> Create(TInputCreate inputCreate)
    {
        InputCreate = inputCreate;
        return this;
    }

    public virtual BaseValidateDTO_1<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete> Update(TInputIdentityUpdate inputIdentityUpdate)
    {
        InputIdentityUpdate = inputIdentityUpdate;
        return this;
    }

    public virtual BaseValidateDTO_1<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete> Delete(TInputIdentityDelete inputIdentityDelete)
    {
        InputIdentityDelete = inputIdentityDelete;
        return this;
    }
}

#region 2 - Create
public class BaseValidateDTO_2<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete> : BaseValidateDTO_1<TInputCreate, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0>
    where TInputCreate : BaseInputCreate<TInputCreate>
{ }
#endregion

#region 3 - Create, Update
public class BaseValidateDTO_3<TInputCreate, TInputUpdate, TInputIdentityUpdate> : BaseValidateDTO_1<TInputCreate, TInputUpdate, TInputIdentityUpdate, BaseInputIdentityDelete_0>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
{ }
#endregion

#region 4 - Create, Delete
public class BaseValidate_4<TInputCreate, TInputIdentityDelete> : BaseValidateDTO_1<TInputCreate, BaseInputUpdate_0, BaseInputIdentityUpdate_0, TInputIdentityDelete>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
{ }
#endregion