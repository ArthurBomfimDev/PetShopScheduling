using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Domain.Interface.Repository.Base;
using PetShopScheduling.Domain.Interface.Service.Base;
using PetShopScheduling.Domain.Interface.UnitOfWork;
using PetShopScheduling.Infrastructure.Entry.Base;

namespace PetShopScheduling.Api.Controllers.Base;

[ApiController]
[Route("api/vi/[controller]")]
public abstract class BaseController<TService, TEntry, TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput, TRepository> : Controller
    where TService : IBaseService<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput, TRepository>
    where TEntry : BaseEntry<TEntry, TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput>
    where TDTO : BaseDTO<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput>
    where TInputCreate : BaseInputCreate<TInputCreate>
    where TInputUpdate : BaseInputUpdate<TInputUpdate>
    where TInputIdentityUpdate : BaseInputIdentityUpdate<TInputUpdate>
    where TInputIdentityDelete : BaseInputIdentityDelete<TInputIdentityDelete>
    where TInputIdentityView : BaseInputIdentityView<TInputIdentityView>
    where TOutput : BaseOutput<TOutput>
    where TRepository : IBaseRepository<TDTO, TInputCreate, TInputUpdate, TInputIdentityUpdate, TInputIdentityDelete, TInputIdentityView, TOutput>
{
    protected readonly TService _service;
    protected readonly IUnitOfWork _unitOfWork;

    public BaseController(TService service, IUnitOfWork unitOfWork)
    {
        _service = service;
        _unitOfWork = unitOfWork;
    }

    #region Transacation
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        _unitOfWork.BeginTransaction();
        base.OnActionExecuting(context);
    }

    public override void OnActionExecuted(ActionExecutedContext context)
    {
        _unitOfWork.Commit();
        base.OnActionExecuted(context);
    }
    #endregion

    #region Read
    [HttpGet("Get/All")]
    public virtual async Task<ActionResult<List<TOutput>>> GetAll()
    {
        var getAll = await _service.GetAll();
        return Ok(getAll);
    }

    [HttpPost("Get/Id")]
    public virtual async Task<ActionResult<TOutput>> Get(TInputIdentityView inputIdentityView)
    {
        var get = await _service.Get(inputIdentityView);
        return Ok(get);
    }

    [HttpPost("Get/ListByListId")]
    public virtual async Task<ActionResult<TOutput>> GetListByListId(List<TInputIdentityView> listInputIdentityView)
    {
        var getListByListId = await _service.GetListByListId(listInputIdentityView);
        return Ok(getListByListId);
    }
    #endregion

    #region Create
    [HttpPost("Create")]
    public virtual async Task<ActionResult<List<TOutput>>> Create(TInputCreate inputCreateDTO)
    {
        var create = await _service.Create(inputCreateDTO);
        return Ok(create);
    }

    [HttpPost("Create/Multiple")]
    public virtual async Task<ActionResult<List<TOutput>>> Create(List<TInputCreate> listTInputCreateDTO)
    {
        var create = await _service.CreateMultiple(listTInputCreateDTO);
        if (create == null)
        {
            return BadRequest(create);
        }
        return Ok(create);
    }
    #endregion

    #region Update
    [HttpPut("Update")]
    public virtual async Task<ActionResult<bool>> Update(TInputIdentityUpdate inputIdentityUpdateDTO)
    {
        var update = await _service.Update(inputIdentityUpdateDTO);
        if (update == false)
        {
            return BadRequest(update);
        }
        return Ok(update);
    }

    [HttpPut("Update/Multiple")]
    public virtual async Task<ActionResult<bool>> Update(List<TInputIdentityUpdate> listInputIndetityUpdate)
    {
        var listUpdate = await _service.UpdateMultiple(listInputIndetityUpdate);
        if (listUpdate == false)
        {
            return BadRequest(listUpdate);
        }
        return Ok(listUpdate);
    }
    #endregion

    #region Delete
    [HttpDelete("Delete")]
    public virtual async Task<ActionResult<bool>> Delete(TInputIdentityDelete inputIdentityDelete)
    {
        var delete = await _service.Delete(inputIdentityDelete);
        if (delete == false)
        {
            return BadRequest(delete);
        }
        return Ok(delete);
    }

    [HttpDelete("Delete/Multiple")]
    public virtual async Task<ActionResult<bool>> Delete(List<TInputIdentityDelete> listInputIdentityDelete)
    {
        var listDelete = await _service.DeleteMultiple(listInputIdentityDelete);
        if (listDelete == false)
        {
            return BadRequest(listDelete);
        }
        return Ok(listDelete);
    }
    #endregion
}