using ServiceShopScheduling.Infrastructure.Entry.Registration;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("servico_agendamento")]
public class ScheduleService
{
    [Column("id_agendamento")]
    public long ScheduleId { get; private set; }
    [Column("id_servico")]
    public long ServiceId { get; private set; }
    [Column("id_pet")]
    public long PetId { get; private set; }
    // Talvez um ServiceItem??
    #region Virtual Properties
    [NotMapped]
    [ForeignKey(nameof(ScheduleId))]
    public Schedule Schedule { get; private set; }
    [NotMapped]
    [ForeignKey(nameof(ServiceId))]
    public Service Service { get; private set; }
    [NotMapped]
    [ForeignKey(nameof(PetId))]
    public Pet Pet { get; private set; }
    #endregion

    public ScheduleService() { }

    public ScheduleService(long scheduleId, long serviceId, long petId, Schedule schedule, Service service, Pet pet)
    {
        ScheduleId = scheduleId;
        ServiceId = serviceId;
        PetId = petId;
        Schedule = schedule;
        Service = service;
        Pet = pet;
    }
}