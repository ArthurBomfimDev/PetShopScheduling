using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Enum.VaccineStatus;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class OutputVaccine : BaseOutput<OutputVaccine>
{
    public string Name { get; private set; }
    public string? Manufacturer { get; private set; }
    public int Stock { get; private set; }
    public string? Batch { get; private set; }
    public DateOnly Validity { get; private set; }
    public EnumVaccineStatus VaccineStatus { get; private set; }


    #region Virtual Properties
    public List<OutputSchedule>? ListSchedule { get; private set; }
    public List<OutputReservedVaccine>? ListReservedVaccines { get; private set; }
    #endregion

    public OutputVaccine() { }

    [JsonConstructor]
    public OutputVaccine(string name, string? manufacturer, int stock, string? batch, DateOnly validity, EnumVaccineStatus vaccineStatus, List<OutputSchedule>? listSchedule, List<OutputReservedVaccine>? listReservedVaccines)
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