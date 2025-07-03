using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Enum.VaccineStatus;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("vacina")]
public class Vaccine : BaseEntry<Vaccine, BaseDTO_0, BaseInputCreate_0, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0, BaseInputIdentityView_0, BaseOutput_0>
{
    [Column("nome")]
    public string Name { get; private set; }
    [Column("fabricante")]
    public string? Manufacturer { get; private set; }
    [Column("estoque")]
    public int Stock { get; private set; }
    [Column("lote")]
    public string? Batch { get; private set; }
    [Column("validade")]
    public DateOnly Validity { get; private set; }
    [Column("status_vacina")]
    public EnumVaccineStatus VaccineStatus { get; private set; }
}