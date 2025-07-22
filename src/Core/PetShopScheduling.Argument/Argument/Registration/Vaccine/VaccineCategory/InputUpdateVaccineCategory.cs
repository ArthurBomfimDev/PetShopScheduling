using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Enum.Registration;
using PetShopScheduling.Argument.Enum.Registration.VaccineStatus;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputUpdateVaccineCategory : BaseInputUpdate<InputUpdateVaccineCategory>
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public EnumTargetSpecie TargetSpecie { get; private set; }

    public InputUpdateVaccineCategory() { }

    [JsonConstructor]
    public InputUpdateVaccineCategory(string name, string description, EnumTargetSpecie targetSpecie)
    {
        Name = name;
        Description = description;
        TargetSpecie = targetSpecie;
    }
}