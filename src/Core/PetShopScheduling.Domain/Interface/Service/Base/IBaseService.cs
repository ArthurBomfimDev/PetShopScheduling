using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Domain.Interface.Repository.Base;

namespace PetShopScheduling.Domain.Interface.Service.Base;

public interface IBaseService<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput, TRepository>
    where TDTO : BaseDTO<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
    where TInputIdentityView : BaseInputIdentityView<TInputIdentityView>
    where TOutput : BaseOutput<TOutput>
    where TRepository : IBaseRepository<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput>
{
    Task<List<TOutput>?> GetAll();
    Task<TOutput?> Get(TInputIdentityView inputIdentifyViewDTO);
    Task<List<TOutput>?> GetListByListId(List<TInputIdentityView> listTInputIdentityViewDTO);
    Task<TOutput?> Create(TInputCreate inputCreateDTO);
    Task<List<TOutput>?> CreateMultiple(List<TInputCreate> listInputCreateDTO);
    Task<bool> Update(TInputIdentityUpdate inputIdentityUpdateDTO);
    Task<bool> UpdateMultiple(List<TInputIdentityUpdate> listInputIdentityUpdateDTO);
    Task<bool> Delete(TInputIdentityDelete inputIdentifyDeleteDTO);
    Task<bool> DeleteMultiple(List<TInputIdentityDelete> listInputIdentityDeleteDTO);
}