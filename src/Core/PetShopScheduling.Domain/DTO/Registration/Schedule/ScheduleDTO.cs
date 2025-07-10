using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Argument.Enum.Registration.GroomingType;
using PetShopScheduling.Domain.DTO.Base;

namespace PetShopScheduling.Domain.DTO.Registration;

public class ScheduleDTO : BaseDTO<ScheduleDTO, InputCreateSchedule, InputUpdateSchedule, InputIdentityUpdateSchedule, InputIdentityDeleteSchedule, InputIdentityViewSchedule, OutputSchedule>
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
    public CustomerDTO Customer { get; private set; }
    public PetDTO Pet { get; private set; }
    public List<VaccineDTO>? ListVaccine { get; private set; }
    #endregion

    public ScheduleDTO() { }

    public ScheduleDTO(long customerId, long petId, bool hasVaccine, long? vaccineId, bool hasBath, bool hasGromming, EnumGroomingType? groomingType, DateOnly day, DateTime time, string? observation, CustomerDTO customer, PetDTO pet, List<VaccineDTO>? listVaccine)
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