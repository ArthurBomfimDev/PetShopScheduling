using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Infrastructure.Entry.Base;
using PetShopScheduling.Infrastructure.Entry.Registration.Schedule;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("pet")]
public class Pet : BaseEntry<Pet, BaseDTO_0, BaseInputCreate_0, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0, BaseInputIdentityView_0, BaseOutput_0>
{
    [Column("id_cliente")]
    public long CustomerId { get; private set; }  // trocar para pet
    [Column("nome")]
    public string? Name { get; private set; }
    [Column("raca")]
    public string Race { get; private set; }

}