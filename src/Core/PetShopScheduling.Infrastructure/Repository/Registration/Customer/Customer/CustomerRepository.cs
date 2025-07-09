using PetShopScheduling.Argument;
using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Infrastructure.Context;
using PetShopScheduling.Infrastructure.Entry.Registration;
using PetShopScheduling.Infrastructure.Repository.Base;

namespace PetShopScheduling.Infrastructure.Repository.Registration;

public class CustomerRepository : BaseRepository<Customer, CustomerDTO, InputCreateCustomer, InputUpdateCustomer, InputIdentityUpdateCustomer, InputIdentityDeleteCustomer, InputIdentityViewCustomer, OutputCustomer>, ICustomerRepository
{
    public CustomerRepository(AppDbContext context) : base(context) { }

    public List<CustomerDTO>? GetByName(string name)
    {
        var listEntry = (from i in _dbSet
                         where i.Name.Contains(name)
                         select i.Name).Take(6).ToList();

        return listEntry.ExplicitCast<CustomerDTO>();
    }
}