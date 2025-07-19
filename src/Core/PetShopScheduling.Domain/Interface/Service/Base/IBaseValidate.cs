using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Internal.ApiResponse;
using PetShopScheduling.Domain.DTO.Base;

namespace PetShopScheduling.Domain.Interface.Service.Base;

public interface IBaseValidate<TValidateDTO, TOutput, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
    where TValidateDTO : BaseValidateDTO/*<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>*/
    where TOutput : BaseOutput<TOutput>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
{
    public ApiResponse<TOutput> InternalServerError(ApiResponse<TOutput> apiResponse);
}