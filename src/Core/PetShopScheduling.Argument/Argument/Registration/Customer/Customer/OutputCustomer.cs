using PetShopScheduling.Argument.Argument.Base;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class OutputCustomer : BaseOutput<OutputCustomer>
{
    [Required]
    public string Name { get; private set; }
    public string? Cpf { get; private set; }

    #region Virtual Properties
    public List<OutputCustomerPhone>? CustomerPhone { get; private set; }
    public List<OutputCustomerAddress>? CustomerAddress { get; private set; }
    #endregion

    public OutputCustomer() { }

    [JsonConstructor]
    public OutputCustomer(string name, string? cpf, List<OutputCustomerPhone>? customerPhone, List<OutputCustomerAddress>? customerAddress)
    {
        Name = name;
        Cpf = cpf;
        CustomerPhone = customerPhone;
        CustomerAddress = customerAddress;
    }
}