using PetShopScheduling.Argument.Argument.Base;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputCreateReservedVaccine : BaseInputCreate<InputCreateReservedVaccine>
{
    public long VaccineId { get; private set; }
    public long ScheduleId { get; private set; }

    public InputCreateReservedVaccine() { }

    [JsonConstructor]
    public InputCreateReservedVaccine(long vaccineId, long scheduleId)
    {
        VaccineId = vaccineId;
        ScheduleId = scheduleId;
    }
}