using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("cliente")]
public class Customer : BaseEntry<Customer, BaseDTO_0, BaseInputCreate_0, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0, BaseInputIdentityView_0, BaseOutput_0>
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