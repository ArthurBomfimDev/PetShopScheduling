using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Domain.Interface.Repository;
using PetShopScheduling.Domain.Interface.Service.Base;

namespace PetShopScheduling.Domain.Interface.Service.Registration;

public interface ICustomerAddressService : IBaseService<CustomerAddressDTO, InputCreateCustomerAddress, InputUpdateCustomerAddress, InputIdentityUpdateCustomerAddress, InputIdentityDeleteCustomerAddress, InputIdentityViewCustomerAddress, OutputCustomerAddress, ICustomerAddressRepository> { }