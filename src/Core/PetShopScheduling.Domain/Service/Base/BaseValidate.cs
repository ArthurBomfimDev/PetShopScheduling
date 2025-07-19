using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Internal.ApiResponse;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Domain.Interface.Service.Base;

namespace PetShopScheduling.Domain.Service.Base;

public class BaseValidate<TValidateDTO, TOutput, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete> : IBaseValidate<TValidateDTO, TOutput, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
    where TValidateDTO : BaseValidateDTO/*<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>*/
    where TOutput : BaseOutput<TOutput>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>

{
    public List<TValidateDTO> RemoveIgnore(List<TValidateDTO> listValidateDTO) { listValidateDTO = (from i in listValidateDTO where !i.Ignore select i).ToList(); return listValidateDTO; }
    public List<TValidateDTO> RemoveInvalid(List<TValidateDTO> listValidateDTO) { listValidateDTO = (from i in listValidateDTO where !i.Invalid select i).ToList(); return listValidateDTO; }


    public ApiResponse<TOutput> InternalServerError(ApiResponse<TOutput> apiResponse) { apiResponse.SetError("Erro interno, informe a um desenvolvedor"); return apiResponse; }

    public ApiResponse<TOutput> InvalidMaxLength(ApiResponse<TOutput> apiResponse, string propertyName, int maxLength) { apiResponse.SetError($"O campo {propertyName} passou o limite de {maxLength} caracteres."); return apiResponse; }
}
