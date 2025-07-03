using PetShopScheduling.Argument.Argument.Base;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputCreateCustomer : BaseInputCreate<InputCreateCustomer>
{
    public string Name { get; private set; }
    public string? Cpf { get; private set; }
    public List<InputCreateCustomerPhone>? ListInputCreateCustomerPhone { get; private set; }
    public List<InputCreateCustomerAdress>? ListInputCreateCustomerAdress { get; private set; }

    public InputCreateCustomer() { }

    [JsonConstructor]
    public InputCreateCustomer(string name, string? cpf, List<InputCreateCustomerPhone>? listInputCreateCustomerPhone, List<InputCreateCustomerAdress>? listInputCreateCustomerAdress)
    {
        Name = name;
        Cpf = cpf;
        ListInputCreateCustomerPhone = listInputCreateCustomerPhone;
        ListInputCreateCustomerAdress = listInputCreateCustomerAdress;
    }
}