using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Domain.Interface.Repository;
using PetShopScheduling.Infrastructure.Context;
using PetShopScheduling.Infrastructure.Entry.Registration;
using PetShopScheduling.Infrastructure.Repository.Base;

namespace PetShopScheduling.Infrastructure.Repository.Registration;

public class CustomerPhoneRepository(AppDbContext context) : BaseRepository<CustomerPhone, CustomerPhoneDTO, InputCreateCustomerPhone, InputUpdateCustomerPhone, InputIdentityUpdateCustomerPhone, InputIdentityDeleteCustomerPhone, InputIdentityViewCustomerPhone, OutputCustomerPhone>(context), ICustomerPhoneRepository { }