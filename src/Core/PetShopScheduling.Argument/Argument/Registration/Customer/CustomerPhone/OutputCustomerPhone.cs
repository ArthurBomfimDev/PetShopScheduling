using PetShopScheduling.Argument.Argument.Base;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class OutputCustomerPhone : BaseOutput<OutputCustomerPhone>
{
    public long? CustomerId { get; private set; }
    [Required]
    public string PhoneNumber { get; private set; }
    public bool IsZapZap { get; private set; }
    public string? Observation { get; private set; }

    #region Virtual Properties
    public OutputCustomer? Customer { get; private set; }
    #endregion

    public OutputCustomerPhone() { }

    [JsonConstructor]
    public OutputCustomerPhone(long? customerId, string phoneNumber, bool isZapZap, string? observation, OutputCustomer? customer)
    {
        CustomerId = customerId;
        PhoneNumber = phoneNumber;
        IsZapZap = isZapZap;
        Observation = observation;
        Customer = customer;
    }
}