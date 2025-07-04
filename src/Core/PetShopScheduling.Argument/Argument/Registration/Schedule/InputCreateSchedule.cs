using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Enum.GroomingType;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputCreateSchedule : BaseInputCreate<InputCreateSchedule>
{
    public long CustomerId { get; private set; }
    public long PetId { get; private set; }
    public bool HasVaccine { get; private set; }
    public List<long>? ListVaccineId { get; private set; }
    public bool HasBath { get; private set; }
    public bool HasGromming { get; private set; }
    public EnumGroomingType? GroomingType { get; private set; }
    public DateOnly Day { get; private set; }
    public DateTime Time { get; set; }
    public string? Observation { get; private set; }

    public InputCreateSchedule() { }

    [JsonConstructor]
    public InputCreateSchedule(long customerId, long petId, bool hasVaccine, List<long>? listVaccineId, bool hasBath, bool hasGromming, EnumGroomingType? groomingType, DateOnly day, DateTime time, string? observation)
    {
        CustomerId = customerId;
        PetId = petId;
        HasVaccine = hasVaccine;
        ListVaccineId = listVaccineId;
        HasBath = hasBath;
        HasGromming = hasGromming;
        GroomingType = groomingType;
        Day = day;
        Time = time;
        Observation = observation;
    }
}                            