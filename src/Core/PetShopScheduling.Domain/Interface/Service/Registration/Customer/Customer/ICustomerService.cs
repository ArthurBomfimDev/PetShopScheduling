using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Domain.Interface.Service.Base;
using PetShopScheduling.Infrastructure.Repository.Registration;

namespace PetShopScheduling.Domain.Interface.Service.Registration;

public interface ICustomerService : IBaseService<CustomerDTO, InputCreateCustomer, InputUpdateCustomer, InputIdentityUpdateCustomer, InputIdentityDeleteCustomer, InputIdentityViewCustomer, OutputCustomer, ICustomerRepository>
{
    List<OutputCustomer>? GetByName(string name);
}