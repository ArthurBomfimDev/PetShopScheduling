using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

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
    public List<CustomerPhone> ListCustomerPhone { get; private set; }
    [NotMapped]
    public List<CustomerAddress> ListCustomerAddress { get; private set; }
    #endregion

    public Customer() { }

    public Customer(string name, string? cpf, List<CustomerPhone> listCustomerPhone, List<CustomerAddress> listCustomerAddress)
    {
        Name = name;
        Cpf = cpf;
        ListCustomerPhone = listCustomerPhone;
        ListCustomerAddress = listCustomerAddress;
    }

    public CustomerDTO GetDTO()
    {
        return new CustomerDTO(Name, Cpf, ListCustomerPhone, ListCustomerAddress)
    }

    public static implicit operator CustomerDTO(Customer customer)
    {
        return customer!.GetDTO();
    }
}