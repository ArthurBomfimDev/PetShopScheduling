using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Enum.Registration.VaccineStatus;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputCreateVaccine : BaseInputCreate<InputCreateVaccine>
{
    public string Name { get; private set; }
    public string? Manufacturer { get; private set; }
    public int Stock { get; private set; }
    public string? Batch { get; private set; }
    public DateOnly Validity { get; private set; }
    public EnumVaccineStatus VaccineStatus { get; private set; }

    public InputCreateVaccine() { }

    [JsonConstructor]
    public InputCreateVaccine(string name, string? manufacturer, int stock, string? batch, DateOnly validity, EnumVaccineStatus vaccineStatus)
    {
        Name = name;
        Manufacturer = manufacturer;
        Stock = stock;
        Batch = batch;
        Validity = validity;
        VaccineStatus = vaccineStatus;
    }
}