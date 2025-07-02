using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("vacina_reservada")]
public class ReservedVaccines : BaseEntry<ReservedVaccines>
{
    public long VaccineId { get; private set; }
    public long ScheduleId { get; private set; }
}