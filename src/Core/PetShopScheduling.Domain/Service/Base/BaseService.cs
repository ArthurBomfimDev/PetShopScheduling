using PetShopScheduling.Argument;
using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Enum.Internal.Validate;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Domain.Interface.Repository.Base;
using PetShopScheduling.Domain.Interface.Service.Base;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace PetShopScheduling.Domain.Service.Base;

public class BaseService<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput, TRepository> : IBaseService<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput, TRepository>
    where TDTO : BaseDTO<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
    where TInputIdentityView : BaseInputIdentityView<TInputIdentityView>
    where TOutput : BaseOutput<TOutput>
    where TRepository : IBaseRepository<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput>
{
    protected readonly TRepository _repository;

    public BaseService(TRepository repository)
    {
        _repository = repository;
    }

    #region Read
    public virtual async Task<TOutput?> Get(TInputIdentityView inputIdentifyViewDTO)
    {
        if (inputIdentifyViewDTO == null || inputIdentifyViewDTO.Id <= 0)
            return null;

        var dTO = await _repository.Get(inputIdentifyViewDTO.Id);

        return (dynamic)dTO! ?? null;

    }

    public virtual async Task<List<TOutput>?> GetAll()
    {
        var listDTO = await _repository.GetAll();

        return listDTO.ExplicitCast<TOutput>();
    }

    public virtual async Task<List<TOutput>?> GetListByListId(List<TInputIdentityView> listTInputIdentityViewDTO)
    {
        if (listTInputIdentityViewDTO == null || listTInputIdentityViewDTO.Count == 0)
            return null;

        var listDTO = await _repository.GetListByListId(listTInputIdentityViewDTO.Select(x => x.Id).ToList());

        return listDTO.ExplicitCast<TOutput>();
    }
    #endregion

    #region Create
    public virtual async Task<TOutput?> Create(TInputCreate inputCreateDTO)
    {
        var create = await CreateMultiple([inputCreateDTO]);

        return create.FirstOrDefault();
    }

    public Task<List<TOutput>?> CreateMultiple(List<TInputCreate> listInputCreateDTO)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Update
    public virtual async Task<bool> Update(TInputIdentityUpdate inputIdentityUpdateDTO)
    {
        return await UpdateMultiple([inputIdentityUpdateDTO]);
    }

    public Task<bool> UpdateMultiple(List<TInputIdentityUpdate> listInputIdentityUpdateDTO)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Delete
    public virtual async Task<bool> Delete(TInputIdentityDelete inputIdentifyDeleteDTO)
    {
        return await DeleteMultiple([inputIdentifyDeleteDTO]);
    }

    public Task<bool> DeleteMultiple(List<TInputIdentityDelete> listInputIdentityDeleteDTO)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Validate
    public void ValidateLength<TValidateDTO>(List<TValidateDTO> listValidateDTO) where TValidateDTO : BaseValidateDTO<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
    {
        foreach (var validateDTO in listValidateDTO)
        {
            ValidateLength(validateDTO);
        }
    }

    public EnumValidateType ValidateLength<TValidateDTO>(TValidateDTO validateDTO) where TValidateDTO : BaseValidateDTO<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
    {
        var validate = CreateOrUpdate(validateDTO);

        if(validate == null)
            return EnumValidateType.NonInformed;

        List<PropertyInfo> listProperties = validate?.GetType().GetProperties().ToList() ?? new List<PropertyInfo>();

        var validateMaxLenghtproperty = (from i in listProperties
                                     let maxLenght = typeof(TOutput).GetProperty(i.Name)?.GetCustomAttribute<MaxLengthAttribute>() ?? null
                                     where maxLenght != null
                                     let currentLenght = i.GetValue(validate)?.ToString() ?? null
                                     where currentLenght != null && currentLenght.Length > maxLenght.Length
                                     let setInvalid = validateDTO.SetInvalid()
                                     select true).FirstOrDefault();

        return validateMaxLenghtproperty == true ? EnumValidateType.Invalid : EnumValidateType.Valid;
    }

    public dynamic? CreateOrUpdate<TValidateDTO>(TValidateDTO validateDTO) where TValidateDTO : BaseValidateDTO<TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete>
    {
        if (validateDTO.InputCreate != null)
            return validateDTO!.InputCreate;

        if (validateDTO.InputIdentityUpdate != null)
            return validateDTO!.InputIdentityUpdate.InputUpdate;

        return null;
    }
    #endregion
}