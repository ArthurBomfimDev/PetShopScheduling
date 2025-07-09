using PetShopScheduling.Argument.Argument.Base;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputUpdateService : BaseInputUpdate<InputUpdateService>
{
    public string Name { get; private set; }
    public string? Description { get; private set; }

    public InputUpdateService() { }

    [JsonConstructor]
    public InputUpdateService(string name, string? description)
    {
        Name = name;
        Description = description;
    }
}