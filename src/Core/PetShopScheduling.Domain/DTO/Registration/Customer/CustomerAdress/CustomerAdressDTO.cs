namespace PetShopScheduling.Domain.DTO.Registration;

public class CustomerAdressDTO
{
    public long CustomerId { get; private set; }
    public string? CEP { get; private set; }
    public string? Neighborhood { get; private set; }
    public string? Street { get; private set; }
    public string? Number { get; private set; }
    public string? Observation { get; private set; }

    #region Virtual Properties
    public CustomerDTO Customer { get; private set; }
    #endregion

    public CustomerAdressDTO() { }

    public CustomerAdressDTO(long customerId, string? cEP, string? neighborhood, string? street, string? number, string? observation, CustomerDTO customer)
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