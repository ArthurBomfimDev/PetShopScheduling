using PetShopScheduling.Argument.Argument.Base;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputCreateService : BaseInputCreate<InputCreateService>
{
    public string Name { get; private set; }
    public string? Description { get; private set; }

    public InputCreateService() { }

    [JsonConstructor]
    public InputCreateService(string name, string? description)
    {
        Name = name;
        Description = description;
    }
}