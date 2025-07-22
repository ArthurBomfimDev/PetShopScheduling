using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Internal.ApiResponse;
using PetShopScheduling.Domain.DTO.Base;

namespace PetShopScheduling.Domain.Interface.Service.Base;

public interface IBaseValidate<TValidateDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TOutput>
    where TValidateDTO : BaseValidateDTO_1<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
    where TOutput : BaseOutput<TOutput>
{
    public ApiResponse<TOutput> InternalServerError(ApiResponse<TOutput> apiResponse);
}