using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("vacina_reservada")]
public class ReservedVaccine : BaseEntry<ReservedVaccine, BaseDTO_0, BaseInputCreate_0, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0, BaseInputIdentityView_0, BaseOutput_0>
{
    [Column("id_vacina")]
    public long VaccineId { get; private set; }
    [Column("id_agendamento")]
    public long ScheduleId { get; private set; }

    #region Virtual Properties
    [NotMapped]
    [ForeignKey(nameof(VaccineId))]
    public Vaccine Vaccine { get; private set; }
    [NotMapped]
    [ForeignKey(nameof(ScheduleId))]
    public Schedule Schedule { get; private set; }
    #endregion

    public ReservedVaccine() { }

    public ReservedVaccine(long vaccineId, long scheduleId, Vaccine vaccine, Schedule schedule)
    {
        VaccineId = vaccineId;
        ScheduleId = scheduleId;
        Vaccine = vaccine;
        Schedule = schedule;
    }
}