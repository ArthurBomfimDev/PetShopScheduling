using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("endereco_usuario")]
public class CustomerAddress : BaseEntry<CustomerAddress, CustomerAddressDTO, InputCreateCustomerAddress, InputUpdateCustomerAddress, InputIdentityUpdateCustomerAddress, InputIdentityDeleteCustomerAddress, InputIdentityViewCustomerAddress, OutputCustomerAddress>
{
    [Column("id_cliente")]
    public long CustomerId { get; private set; }
    [Column("cep")]
    public string? CEP { get; private set; }
    [Column("bairro")]
    public string? Neighborhood { get; private set; }
    [Column("rua")]
    public string? Street { get; private set; }
    [Column("numero")]
    public string? Number { get; private set; }
    [Column("observacao")]
    public string? Observation { get; private set; }

    #region Virtual Properties
    [NotMapped]
    [ForeignKey(nameof(CustomerId))]
    public Customer Customer { get; private set; }
    #endregion

    public CustomerAddress() { }

    public CustomerAddress(long customerId, string? cEP, string? neighborhood, string? street, string? number, string? observation, Customer customer)
    {
        CustomerId = customerId;
        CEP = cEP;
        Neighborhood = neighborhood;
        Street = street;
        Number = number;
        Observation = observation;
        Customer = customer;
    }

    #region Implicit Operator
    public CustomerAddressDTO GetDTO()
    {
        return new CustomerAddressDTO(CustomerId, CEP, Neighborhood, Street, Number, Observation, Customer);
    }

    public static implicit operator CustomerAddressDTO(CustomerAddress customerAddress)
    {
        return customerAddress.GetDTO();
    }
    #endregion 
}