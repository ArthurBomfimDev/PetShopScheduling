using PetShopScheduling.Argument;
using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Domain.Interface.Service.Registration;
using PetShopScheduling.Domain.Service.Base;
using PetShopScheduling.Infrastructure.Repository.Registration;

namespace PetShopScheduling.Domain.Service.Registration;

public class CustomerService : BaseService<CustomerDTO, InputCreateCustomer, InputUpdateCustomer, InputIdentityUpdateCustomer, InputIdentityDeleteCustomer, InputIdentityViewCustomer, OutputCustomer, ICustomerRepository>, ICustomerService
{
    public CustomerService(ICustomerRepository repository) : base(repository) { }

    public List<OutputCustomer>? GetByName(string name)
    {
        var listDTO = _repository.GetByName(name);

        return listDTO.ExplicitCast<OutputCustomer>() ?? null;
    }
}