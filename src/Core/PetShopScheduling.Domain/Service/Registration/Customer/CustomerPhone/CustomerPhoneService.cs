using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Domain.Interface.Repository;
using PetShopScheduling.Domain.Interface.Service.Registration;
using PetShopScheduling.Domain.Service.Base;

namespace PetShopScheduling.Domain.Service.Registration;

public class CustomerPhoneService : BaseService<CustomerPhoneDTO, InputCreateCustomerPhone, InputUpdateCustomerPhone, InputIdentityUpdateCustomerPhone, InputIdentityDeleteCustomerPhone, InputIdentityViewCustomerPhone, OutputCustomerPhone, ICustomerPhoneRepository>, ICustomerPhoneService
{
    public CustomerPhoneService(ICustomerPhoneRepository repository) : base(repository) { }
}