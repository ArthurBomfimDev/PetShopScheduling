using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Domain.DTO.Base;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("agendamento_pet")]
public class SchedulePet : BaseEntry<SchedulePet, BaseDTO_0, BaseInputCreate_0, BaseInputUpdate_0, BaseInputIdentityUpdate_0, BaseInputIdentityDelete_0, BaseInputIdentityView_0, BaseOutput_0>
{
    [Column("id_agendamento")]
    public long ScheduleId { get; set; }
    [Column("id_pet")]
    public long PetId { get; set; }


    #region Virtual Properties
    [ForeignKey(nameof(ScheduleId))]
    public Schedule Schedule { get; set; }
    [ForeignKey(nameof(PetId))]
    public Pet Pet { get; set; }
    #endregion

    public SchedulePet() { }

    public SchedulePet(long scheduleId, long petId, Schedule schedule, Pet pet)
    {
        ScheduleId = scheduleId;
        PetId = petId;
        Schedule = schedule;
        Pet = pet;
    }

    #region Implicit Operator

    #endregion
}