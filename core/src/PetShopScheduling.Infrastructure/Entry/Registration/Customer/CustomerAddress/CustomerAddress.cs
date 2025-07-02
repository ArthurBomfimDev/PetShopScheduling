using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("endereco_usuario")]
public class CustomerAddress : BaseEntry<CustomerAddress>
{
}