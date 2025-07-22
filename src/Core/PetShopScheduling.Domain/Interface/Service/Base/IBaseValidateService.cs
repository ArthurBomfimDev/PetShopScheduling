using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Domain.DTO.Base;

namespace PetShopScheduling.Domain.Interface.Service.Base;

public interface IBaseValidateService<TValidateDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TOutput>
    where TValidateDTO : BaseValidateDTO_1<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
    where TOutput : BaseOutput<TOutput>
{
}