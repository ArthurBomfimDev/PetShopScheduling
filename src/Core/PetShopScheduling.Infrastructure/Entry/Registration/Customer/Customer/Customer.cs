using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("cliente")]
public class Customer : BaseEntry<Customer>
{
    [Column("nome")]
    public string Name { get; private set; }
    [Column("cpf")]
    public string? Cpf { get; private set; }

    public List<CustomerPhone> CustomerPhone { get; private set; }
    public List<CustomerAddress> CustomerAddress { get; private set; }
}