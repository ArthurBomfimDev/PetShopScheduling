using PetShopScheduling.Argument.Argument.Base;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class OutputReservedVaccine : BaseOutput<OutputReservedVaccine>
{
    public long VaccineId { get; private set; }
    public long ScheduleId { get; private set; }

    #region Virtual Properties

    public OutputVaccine Vaccine { get; private set; }
    public OutputSchedule Schedule { get; private set; }
    #endregion

    public OutputReservedVaccine() { }

    [JsonConstructor]
    public OutputReservedVaccine(long vaccineId, long scheduleId, OutputVaccine vaccine, OutputSchedule schedule)
    {
        VaccineId = vaccineId;
        ScheduleId = scheduleId;
        Vaccine = vaccine;
        Schedule = schedule;
    }
}
