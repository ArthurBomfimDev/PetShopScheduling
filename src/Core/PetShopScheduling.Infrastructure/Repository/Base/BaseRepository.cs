using Microsoft.EntityFrameworkCore;
using PetShopScheduling.Argument;
using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Domain.Interface.Repository.Base;
using PetShopScheduling.Infrastructure.Context;
using PetShopScheduling.Infrastructure.Entry.Base;

namespace PetShopScheduling.Infrastructure.Repository.Base;

public class BaseRepository<TEntry, TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput> : IBaseRepository<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput>
    where TEntry : BaseEntry<TEntry, TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput>
    where TDTO : BaseDTO<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
    where TInputIdentityView : BaseInputIdentityView<TInputIdentityView>
    where TOutput : BaseOutput<TOutput>
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<TEntry> _dbSet;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntry>();
    }

    #region Read
    public async Task<List<TDTO>?> GetAll()
    {
        List<TEntry> getAll = await _dbSet.ToListAsync();

        return getAll.ExplicitCast<TDTO>();
    }

    public async Task<List<TDTO>?> GetListByListId(List<long> listId)
    {
        List<TEntry> getListByListId = await (from i in _dbSet
                                              where listId.Contains(i.Id)
                                              select i).ToListAsync();

        return getListByListId.ExplicitCast<TDTO>();
    }

    public async Task<TDTO?> Get(long id)
    {
        TEntry get = await (from i in _dbSet
                            where i.Id == id
                            select i).FirstAsync();

        return (dynamic)get;
    }

    #endregion

    #region Create
    public async Task<List<TDTO>?> Create(List<TDTO> listDTO)
    {
        List<TEntry> listEntry = listDTO.ExplicitCast<TEntry>();

        await _dbSet.AddRangeAsync(listEntry);
        await _context.SaveChangesAsync();

        return listEntry.ExplicitCast<TDTO>();
    }
    #endregion

    #region Update
    public async Task<bool> Update(List<TDTO> listDTO)
    {
        List<TEntry> listEntry = listDTO.ExplicitCast<TEntry>();

        _dbSet.UpdateRange(listEntry);
        await _context.SaveChangesAsync();

        return true;
    }
    #endregion

    #region Delete
    public async Task<bool> Delete(List<TDTO> listDTO)
    {
        List<TEntry> listEntry = listDTO.ExplicitCast<TEntry>();

        _dbSet.RemoveRange(listEntry);
        await _context.SaveChangesAsync();

        return true;
    }
    #endregion
}