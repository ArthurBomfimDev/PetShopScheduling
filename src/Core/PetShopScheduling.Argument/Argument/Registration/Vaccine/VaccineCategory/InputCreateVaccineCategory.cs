using PetShopScheduling.Argument.Argument.Base;
using PetShopScheduling.Argument.Enum.Registration;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputCreateVaccineCategory : BaseInputCreate<InputCreateVaccineCategory>
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public EnumTargetSpecie TargetSpecie { get; private set; }

    public InputCreateVaccineCategory() { }

    [JsonConstructor]
    public InputCreateVaccineCategory(string name, string description, EnumTargetSpecie targetSpecie)
    {
        Name = name;
        Description = description;
        TargetSpecie = targetSpecie;
    }
}