using PetShopScheduling.Argument.Enum.GroomingType;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration.Schedule;

[Table("agendamento")]
public class Schedule : BaseEntry<Schedule>
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
    public EnumGroomingType GroomingType { get; private set; }
    [Column("dia")]
    public DateOnly Day { get; private set; }
    [Column("horario")]
    public DateTime Time { get; set; }
    [Column("observacao")]
    public string? Observation { get; private set; }

    public Customer Customer { get; private set; }
    public List<Pet>? Pet { get; private set; }
    public List<Vaccine>? Vaccine { get; private set; }

    public Schedule() { }

    public Schedule(long customerId, long petId, bool hasVaccine, long? vaccineId, bool hasBath, bool hasGromming, EnumGroomingType groomingType, DateOnly day, DateTime time, string? observation, Customer customer, Pet pet, Vaccine vaccine)
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
        Vaccine = vaccine;
    }
}