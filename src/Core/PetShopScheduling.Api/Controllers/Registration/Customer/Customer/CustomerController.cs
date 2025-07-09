using Microsoft.AspNetCore.Mvc;
using PetShopScheduling.Api.Controllers.Base;
using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Domain.Interface.Service.Registration;
using PetShopScheduling.Domain.Interface.UnitOfWork;
using PetShopScheduling.Infrastructure.Entry.Registration;
using PetShopScheduling.Infrastructure.Repository.Registration;

namespace PetShopScheduling.Api.Controllers.Registration;

public class CustomerController : BaseController<ICustomerService, Customer, CustomerDTO, InputCreateCustomer, InputUpdateCustomer, InputIdentityUpdateCustomer, InputIdentityDeleteCustomer, InputIdentityViewCustomer, OutputCustomer, ICustomerRepository>
{
    public CustomerController(ICustomerService service, IUnitOfWork unitOfWork) : base(service, unitOfWork) { }


    [HttpGet("Get/ByName")]
    public ActionResult<List<OutputCustomer>> GetByName(string name)
    {
        var getAll = _service.GetByName(name);
        return Ok(getAll);
    }
}