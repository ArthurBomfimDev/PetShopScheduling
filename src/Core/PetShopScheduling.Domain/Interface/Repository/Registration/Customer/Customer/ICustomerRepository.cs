using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Domain.Interface.Repository.Base;

namespace PetShopScheduling.Infrastructure.Repository.Registration;

public interface ICustomerRepository : IBaseRepository<CustomerDTO, InputCreateCustomer, InputUpdateCustomer, InputIdentityUpdateCustomer, InputIdentityDeleteCustomer, InputIdentityViewCustomer, OutputCustomer>
{
    List<CustomerDTO>? GetByName(string name);
}