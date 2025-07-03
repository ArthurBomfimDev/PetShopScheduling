using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("cliente")]
public class Customer : BaseEntry<Customer, CustomerDTO, InputCreateCustomer, InputUpdateCustomer, InputIdentityUpdateCustomer, InputIdentityDeleteCustomer, InputIdentityViewCustomer, OutputCustomer>
{
    [Column("nome")]
    public string Name { get; private set; }
    [Column("cpf")]
    public string? Cpf { get; private set; }

    #region Virtual Properties
    [NotMapped]
    public List<CustomerPhone> CustomerPhone { get; private set; }
    [NotMapped]
    public List<CustomerAddress> CustomerAddress { get; private set; }
    #endregion

    public Customer() { }

    public Customer(string name, string? cpf, List<CustomerPhone> customerPhone, List<CustomerAddress> customerAddress)
    {
        Name = name;
        Cpf = cpf;
        CustomerPhone = customerPhone;
        CustomerAddress = customerAddress;
    }
}