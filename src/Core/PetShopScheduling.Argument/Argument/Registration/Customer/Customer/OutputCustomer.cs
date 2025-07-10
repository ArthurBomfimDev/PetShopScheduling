using PetShopScheduling.Argument.Argument.Base;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetShopScheduling.Argument.Argument.Registration;

public class OutputCustomer : BaseOutput<OutputCustomer>
{
    [Required]
    [MaxLength(100)]
    public string Name { get; private set; }
    [MaxLength(11)]
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