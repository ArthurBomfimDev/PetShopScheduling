using PetShopScheduling.Argument.Argument.Base;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class OutputCustomerAddress : BaseOutput<OutputCustomerAddress>
{
    public long? CustomerId { get; private set; }
    public string? CEP { get; private set; }
    public string? Neighborhood { get; private set; }
    public string? Street { get; private set; }
    [Required]
    public string? Number { get; private set; }
    public string? Observation { get; private set; }

    #region Virtual Properties
    public OutputCustomer? Customer { get; private set; }
    #endregion

    public OutputCustomerAddress() { }

    [JsonConstructor]
    public OutputCustomerAddress(long customerId, string? cEP, string? neighborhood, string? street, string? number, string? observation, OutputCustomer? customer)
    {
        CustomerId = customerId;
        CEP = cEP;
        Neighborhood = neighborhood;
        Street = street;
        Number = number;
        Observation = observation;
        Customer = customer;
    }
}