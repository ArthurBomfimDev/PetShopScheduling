using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Domain.DTO.Base;

namespace PetShopScheduling.Domain.Interface.Repository.Base;

public interface IBaseRepository<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput>
    where TDTO : BaseDTO<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
    where TInputIdentityView : BaseInputIdentityView<TInputIdentityView>
    where TOutput : BaseOutput<TOutput>
{
    Task<List<TDTO>?> GetAll();
    Task<List<TDTO>?> GetListByListId(List<long> listId);
    Task<TDTO?> Get(long id);
    Task<List<TDTO>?> Create(List<TDTO> listDTO);
    Task<bool> Update(List<TDTO> listDTO);
    Task<bool> Delete(List<TDTO> listDTO);
}