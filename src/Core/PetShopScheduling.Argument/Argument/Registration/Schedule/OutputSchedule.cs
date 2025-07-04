using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Enum.GroomingType;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class OutputSchedule : BaseOutput<OutputSchedule>
{
    public long CustomerId { get; private set; }
    public long PetId { get; private set; }
    public bool HasVaccine { get; private set; }
    public long? VaccineId { get; private set; }
    public bool HasBath { get; private set; }
    public bool HasGromming { get; private set; }
    public EnumGroomingType? GroomingType { get; private set; }
    public DateOnly Day { get; private set; }
    public DateTime Time { get; set; }
    public string? Observation { get; private set; }

    #region Virtual Properties
    public OutputCustomer Customer { get; private set; }
    public OutputPet Pet { get; private set; }
    public List<OutputVaccine>? ListVaccine { get; private set; }
    #endregion

    public OutputSchedule() { }

    [JsonConstructor]
    public OutputSchedule(long customerId, long petId, bool hasVaccine, long? vaccineId, bool hasBath, bool hasGromming, EnumGroomingType? groomingType, DateOnly day, DateTime time, string? observation, OutputCustomer customer, OutputPet pet, List<OutputVaccine>? listVaccine)
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
}