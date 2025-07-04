using PetShopScheduling.Argument.Argument.Base;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputUpdateReservedVaccine : BaseInputUpdate<InputUpdateReservedVaccine>
{
    public long VaccineId { get; private set; }
    public long ScheduleId { get; private set; }

    public InputUpdateReservedVaccine() { }

    [JsonConstructor]
    public InputUpdateReservedVaccine(long vaccineId, long scheduleId)
    {
        VaccineId = vaccineId;
        ScheduleId = scheduleId;
    }
}