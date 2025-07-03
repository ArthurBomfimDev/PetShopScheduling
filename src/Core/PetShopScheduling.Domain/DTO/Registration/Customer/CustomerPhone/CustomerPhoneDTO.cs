namespace PetShopScheduling.Domain.DTO.Registration;

public class CustomerPhoneDTO
{
    public long CustomerId { get; private set; }
    public string PhoneNumber { get; private set; }
    public bool IsZapZap { get; private set; }
    public string? Observation { get; private set; }

    #region Virtual Properties
    public CustomerDTO Customer { get; private set; }
    #endregion

    public CustomerPhoneDTO() { }

    public CustomerPhoneDTO(long customerId, string phoneNumber, bool isZapZap, string? observation, CustomerDTO customer)
    {
        CustomerId = customerId;
        PhoneNumber = phoneNumber;
        IsZapZap = isZapZap;
        Observation = observation;
        Customer = customer;
    }
}