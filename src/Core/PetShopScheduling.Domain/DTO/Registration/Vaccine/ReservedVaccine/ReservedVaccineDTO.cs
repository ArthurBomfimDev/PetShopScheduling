namespace PetShopScheduling.Domain.DTO.Registration;

public class ReservedVaccineDTO
{
    public long VaccineId { get; private set; }
    public long ScheduleId { get; private set; }

    #region Virtual Properties
    public VaccineDTO Vaccine { get; private set; }
    public ScheduleDTO Schedule { get; private set; }
    #endregion

    public ReservedVaccineDTO() { }

    public ReservedVaccineDTO(long vaccineId, long scheduleId, VaccineDTO vaccine, ScheduleDTO schedule)
    {
        VaccineId = vaccineId;
        ScheduleId = scheduleId;
        Vaccine = vaccine;
        Schedule = schedule;
    }
}