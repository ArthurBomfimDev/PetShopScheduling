using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("vacina_reservada")]
public class ReservedVaccine : BaseEntry<ReservedVaccine, ReservedVaccineDTO, InputCreateReservedVaccine, InputUpdateReservedVaccine, InputIdentityUpdateReservedVaccine, InputIdentityDeleteReservedVaccine, InputIdentityViewReservedVaccine, OutputReservedVaccine>
{
    [Column("id_vacina")]
    public long VaccineId { get; private set; }
    [Column("id_agendamento")]
    public long ScheduleId { get; private set; }

    #region Virtual Properties
    [NotMapped]
    [ForeignKey(nameof(VaccineId))]
    public Vaccine? Vaccine { get; private set; }
    [NotMapped]
    [ForeignKey(nameof(ScheduleId))]
    public Schedule? Schedule { get; private set; }
    #endregion

    public ReservedVaccine() { }

    public ReservedVaccine(long vaccineId, long scheduleId, Vaccine vaccine, Schedule schedule)
    {
        VaccineId = vaccineId;
        ScheduleId = scheduleId;
        Vaccine = vaccine;
        Schedule = schedule;
    }

    #region Implicit Operator
    public ReservedVaccineDTO GetDTO()
    {
        return new ReservedVaccineDTO(VaccineId, ScheduleId, Vaccine, Schedule);
    }

    public static implicit operator ReservedVaccineDTO(ReservedVaccine reservedVaccine)
    {
        return reservedVaccine.GetDTO();
    }
    #endregion
}