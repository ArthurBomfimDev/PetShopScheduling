using PetShopScheduling.Argument;
using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Argument.Enum.GroomingType;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("agendamento")]
public class Schedule : BaseEntry<Schedule, ScheduleDTO, InputCreateSchedule, InputUpdateSchedule, InputIdentityUpdateSchedule, InputIdentityDeleteSchedule, InputIdentityViewSchedule, OutputSchedule>
{
    [Column("id_cliente")]
    public long CustomerId { get; private set; }
    [Column("id_pet")]
    public long PetId { get; private set; }
    [Column("vacina")]
    public bool HasVaccine { get; private set; }
    [Column("id_vacina")]
    public long? VaccineId { get; private set; }
    [Column("banho")]
    public bool HasBath { get; private set; }
    [Column("tosa")]
    public bool HasGromming { get; private set; }
    [Column("tipo_tosa")]
    public EnumGroomingType? GroomingType { get; private set; }
    [Column("dia")]
    public DateOnly Day { get; private set; }
    [Column("horario")]
    public DateTime Time { get; set; }
    [Column("observacao")]
    public string? Observation { get; private set; }

    #region Virtual Properties
    [NotMapped]
    [ForeignKey(nameof(CustomerId))]
    public Customer Customer { get; private set; }
    [NotMapped]
    [ForeignKey(nameof(PetId))]
    public Pet Pet { get; private set; }
    [NotMapped]
    public List<Vaccine>? ListVaccine { get; private set; }
    #endregion

    public Schedule() { }

    public Schedule(long customerId, long petId, bool hasVaccine, long? vaccineId, bool hasBath, bool hasGromming, EnumGroomingType? groomingType, DateOnly day, DateTime time, string? observation, Customer customer, Pet pet, List<Vaccine>? listVaccine)
    {
        CustomerId = customerId;
        PetId = petId;
        HasVaccine = hasVaccine;
        VaccineId = vaccineId;
        HasBath = hasBath;
        HasGromming = hasGromming;
        GroomingType = groomingType;
        Day = day;
        Time = time;
        Observation = observation;
        Customer = customer;
        Pet = pet;
        ListVaccine = listVaccine;
    }

    #region Implicit Operator
    public ScheduleDTO GetDTO()
    {
        return new ScheduleDTO(CustomerId, PetId, HasVaccine, VaccineId, HasBath, HasGromming, GroomingType, Day, Time, Observation, Customer, Pet, ListVaccine.ExplicitCast<VaccineDTO>());
    }

    public static implicit operator ScheduleDTO(Schedule schedule)
    {
        return schedule.GetDTO();
    }
    #endregion
}