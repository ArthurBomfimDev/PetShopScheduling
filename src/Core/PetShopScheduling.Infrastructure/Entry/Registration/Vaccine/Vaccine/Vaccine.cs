using PetShopScheduling.Argument.Enum.VaccineStatus;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("vacina")]
public class Vaccine : BaseEntry<Vaccine>
{
    public string Name { get; private set; }
    public string? Manufacturer { get; private set; }
    public int Stock { get; private set; }
    public string? Batch { get; private set; }
    public DateOnly Validity { get; private set; }
    public EnumVaccineStatus VaccineStatus { get; private set; }
}