using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Domain.Interface.Repository;
using PetShopScheduling.Domain.Interface.Service.Registration;
using PetShopScheduling.Domain.Service.Base;

namespace PetShopScheduling.Domain.Service.Registration;

public class CustomerAddressService : BaseService<CustomerAddressDTO, InputCreateCustomerAddress, InputUpdateCustomerAddress, InputIdentityUpdateCustomerAddress, InputIdentityDeleteCustomerAddress, InputIdentityViewCustomerAddress, OutputCustomerAddress, ICustomerAddressRepository>, ICustomerAddressService
{
    public CustomerAddressService(ICustomerAddressRepository repository) : base(repository) { }
}