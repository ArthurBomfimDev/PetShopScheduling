using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Domain.DTO.Base;

namespace PetShopScheduling.Domain.Interface.Service.Base;

public interface IBaseValidateService<TValidateDTO, TOutput, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
    where TValidateDTO : BaseValidateDTO/*<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>*/
    where TOutput : BaseOutput<TOutput>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
{
}
