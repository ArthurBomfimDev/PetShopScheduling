using PetShopScheduling.Argument.Argument.Base;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputUpdateCustomerPhone : BaseInputUpdate<InputUpdateCustomerPhone>
{
    public long? CustomerId { get; private set; }
    public string PhoneNumber { get; private set; }
    public bool IsZapZap { get; private set; }
    public string? Observation { get; private set; }

    public InputUpdateCustomerPhone() { }

    [JsonConstructor]
    public InputUpdateCustomerPhone(long? customerId, string phoneNumber, bool isZapZap, string? observation)
    {
        CustomerId = customerId;
        PhoneNumber = phoneNumber;
        IsZapZap = isZapZap;
        Observation = observation;
    }
}