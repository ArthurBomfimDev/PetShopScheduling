using PetShopScheduling.Infrastructure.Entry.Base;
using PetShopScheduling.Infrastructure.Entry.Registration.Schedule;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration.Pet;

[Table("pet")]
public class Pet : BaseEntry<Pet>
{
    [Column("id_cliente")]
    public long CustomerId { get; private set; }
    [Column("nome")]
    public string? Name { get; private set; }
    [Column("raca")]
    public string Race { get; private set; }

}