using PetShopScheduling.Argument;
using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Argument.Enum.VaccineStatus;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("vacina")]
public class Vaccine : BaseEntry<Vaccine, VaccineDTO, InputCreateVaccine, InputUpdateVaccine, InputIdentityUpdateVaccine, InputIdentityDeleteVaccine, InputIdentityViewVaccine, OutputVaccine>
{
    [Column("nome")] // Talvez Trocar para um serviceItem????
    public string Name { get; private set; }
    [Column("fabricante")]
    public string? Manufacturer { get; private set; }
    [Column("estoque")]
    public int Stock { get; private set; }
    [Column("lote")]
    public string? Batch { get; private set; }
    [Column("validade")]
    public DateOnly Validity { get; private set; }
    [Column("status_vacina")]
    public EnumVaccineStatus VaccineStatus { get; private set; }

    #region Virtual Properties
    [NotMapped]
    public List<Schedule> ListSchedule { get; private set; }
    [NotMapped]
    public List<ReservedVaccine>? ListReservedVaccines { get; private set; }
    #endregion

    public Vaccine() { }

    public Vaccine(string name, string? manufacturer, int stock, string? batch, DateOnly validity, EnumVaccineStatus vaccineStatus, List<Schedule> listSchedule, List<ReservedVaccine> listReservedVaccines)
    {
        Name = name;
        Manufacturer = manufacturer;
        Stock = stock;
        Batch = batch;
        Validity = validity;
        VaccineStatus = vaccineStatus;
        ListSchedule = listSchedule;
        ListReservedVaccines = listReservedVaccines;
    }

    #region Implicit Operator
    public VaccineDTO GetDTO()
    {
        return new VaccineDTO(Name, Manufacturer, Stock, Batch, Validity, VaccineStatus, ListSchedule.ExplicitCast<ScheduleDTO>(), ListReservedVaccines.ExplicitCast<ReservedVaccineDTO>());
    }

    public static implicit operator VaccineDTO(Vaccine vaccine)
    {
        return vaccine.GetDTO();
    }
    #endregion
}