using PetShopScheduling.Api.Controllers.Base;
using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Domain.Interface.Repository;
using PetShopScheduling.Domain.Interface.Service.Registration;
using PetShopScheduling.Domain.Interface.UnitOfWork;
using PetShopScheduling.Infrastructure.Entry.Registration;

namespace PetShopScheduling.Api.Controllers.Registration;

public class CustomerAddressController(ICustomerAddressService service, IUnitOfWork unitOfWork) : BaseController<ICustomerAddressService, CustomerAddress, CustomerAddressDTO, InputCreateCustomerAddress, InputUpdateCustomerAddress, InputIdentityUpdateCustomerAddress, InputIdentityDeleteCustomerAddress, InputIdentityViewCustomerAddress, OutputCustomerAddress, ICustomerAddressRepository>(service, unitOfWork) { }