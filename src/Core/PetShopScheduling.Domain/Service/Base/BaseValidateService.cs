using System.ComponentModel.DataAnnotations;
using System.Reflection;
using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Enum.Internal.Validate;
using PetShopScheduling.Argument.Internal.ApiResponse;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Domain.Interface.Service.Base;

namespace PetShopScheduling.Domain.Service.Base;

public class BaseValidateService<TValidateDTO, TOutput, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete> : BaseValidate<TValidateDTO, TOutput, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>, IBaseValidateService
    where TValidateDTO : BaseValidateDTO_1<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
    where TOutput : BaseOutput<TOutput>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
{
    public void ValidateNullDTO(List<TValidateDTO> listValidateDTO)
    {
        (from i in RemoveIgnore(listValidateDTO)
         where i == null
         let setIgnore = i.SetIgnore()
         select i).ToList();
    }

    public void ValidateNullInput(List<TValidateDTO> listValidateDTO)
    {
        (from i in RemoveIgnore(listValidateDTO)
         where i.InputCreate == null
         where i.InputUpdate == null
         let setIgnore = i.SetIgnore()
         select i).ToList();
    }

    public ApiResponse<TValidateDTO> ValidateLength(ApiResponse<TOutput> apiResponse, List<TValidateDTO> listValidateDTO)
    {
        foreach (var validateDTO in listValidateDTO)
        {
            var validLengthDictionary = ValidateLength(validateDTO);

            if (validLengthDictionary != null) { InvalidMaxLength(apiResponse, validLengthDictionary.Select(x => x.Key).FirstOrDefault()!, validLengthDictionary.Select(x => x.Value).FirstOrDefault()); } 
        }

        throw new NotImplementedException();
    }

    public Dictionary<string, int> ValidateLength(TValidateDTO validateDTO)
    {
        List<PropertyInfo> listProperties = validateDTO?.GetType().GetProperties().ToList() ?? new List<PropertyInfo>();

        var validateMaxLengthproperty = (from i in listProperties
                                                             let maxLength = typeof(TOutput).GetProperty(i.Name)?.GetCustomAttribute<MaxLengthAttribute>() ?? null
                                                             where maxLength != null
                                                             let currentLength = i.GetValue(validateDTO)?.ToString() ?? null
                                                             where currentLength != null && currentLength.Length > maxLength.Length
                                                             let setInvalid = validateDTO.SetInvalid()
                                                             select new {PropertyName = i.Name, MaxLength = maxLength.Length}).ToDictionary(x => x.PropertyName, x => x.MaxLength);

        return validateMaxLengthproperty != null ? validateMaxLengthproperty : default;
    }
}
