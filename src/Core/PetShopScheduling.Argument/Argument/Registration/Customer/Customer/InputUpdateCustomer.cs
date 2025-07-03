using PetShopScheduling.Argument.Argument.Base;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputUpdateCustomer : BaseInputUpdate<InputUpdateCustomer>
{
    public string? Name { get; private set; }
    public string? Cpf { get; private set; }

    public InputUpdateCustomer() { }

    [JsonConstructor]
    public InputUpdateCustomer(string? name, string? cpf)
    {
        Name = name;
        Cpf = cpf;
    }
}