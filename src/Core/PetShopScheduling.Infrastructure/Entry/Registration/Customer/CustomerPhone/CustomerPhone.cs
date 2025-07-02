using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("telefone_usuario")]
public class CustomerPhone : BaseEntry<CustomerPhone>
{
}