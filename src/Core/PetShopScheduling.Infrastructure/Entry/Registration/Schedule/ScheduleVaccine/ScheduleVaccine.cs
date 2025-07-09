using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("agendamento_vacina")]
public class ScheduleVaccine : BaseEntry<ScheduleVaccine, BaseDTO_0, BaseInputCreate_0, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0, BaseInputIdentityView_0, BaseOutput_0>
{
    [Column("id_agendamento")]
    public long ScheduleId { get; set; }
    [Column("id_vacina")]
    public long VaccineId { get; set; }


    #region Virtual Properties
    [ForeignKey(nameof(ScheduleId))]
    public Schedule Schedule { get; set; }
    [ForeignKey(nameof(VaccineId))]
    public Vaccine Vaccine { get; set; }
    #endregion

    public ScheduleVaccine() { }

    public ScheduleVaccine(long scheduleId, long vaccineId, Schedule schedule, Vaccine vaccine)
    {
        ScheduleId = scheduleId;
        VaccineId = vaccineId;
        Schedule = schedule;
        Vaccine = vaccine;
    }

    #region Implicit Operator

    #endregion
}