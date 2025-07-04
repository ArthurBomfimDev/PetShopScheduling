using PetShopScheduling.Argument.Argument.Base;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputUpdateCustomerAdress : BaseInputUpdate<InputUpdateCustomerAdress>
{
    public long? CustomerId { get; private set; }
    public string? CEP { get; private set; }
    public string? Neighborhood { get; private set; }
    public string? Street { get; private set; }
    public string? Number { get; private set; }
    public string? Observation { get; private set; }

    public InputUpdateCustomerAdress() { }

    [JsonConstructor]
    public InputUpdateCustomerAdress(long? customerId, string? cEP, string? neighborhood, string? street, string? number, string? observation)
    {
        CustomerId = customerId;
        CEP = cEP;
        Neighborhood = neighborhood;
        Street = street;
        Number = number;
        Observation = observation;
    }
}