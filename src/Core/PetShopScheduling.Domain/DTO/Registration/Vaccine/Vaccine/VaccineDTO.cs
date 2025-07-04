using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Argument.Enum.VaccineStatus;
using PetShopScheduling.Domain.DTO.Base;

namespace PetShopScheduling.Domain.DTO.Registration;

public class VaccineDTO : BaseDTO<VaccineDTO, InputCreateVaccine, InputUpdateVaccine, InputIdentityUpdateVaccine, InputIdentityDeleteVaccine, InputIdentityViewVaccine, OutputVaccine>
{
    public string Name { get; private set; }
    public string? Manufacturer { get; private set; }
    public int Stock { get; private set; }
    public string? Batch { get; private set; }
    public DateOnly Validity { get; private set; }
    public EnumVaccineStatus VaccineStatus { get; private set; }

    #region Virtual Properties
    public List<ScheduleDTO>? ListSchedule { get; private set; }
    public List<ReservedVaccineDTO>? ListReservedVaccines { get; private set; }
    #endregion

    public VaccineDTO() { }

    public VaccineDTO(string name, string? manufacturer, int stock, string? batch, DateOnly validity, EnumVaccineStatus vaccineStatus, List<ScheduleDTO> listSchedule, List<ReservedVaccineDTO> listReservedVaccines)
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
}