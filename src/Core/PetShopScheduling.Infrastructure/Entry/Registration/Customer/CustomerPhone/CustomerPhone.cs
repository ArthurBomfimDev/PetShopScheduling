using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Infrastructure.Entry.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopScheduling.Infrastructure.Entry.Registration;

[Table("telefone_usuario")]
public class CustomerPhone : BaseEntry<CustomerPhone, CustomerPhoneDTO, InputCreateCustomerPhone, InputUpdateCustomerPhone, InputIdentityUpdateCustomerPhone, InputIdentityDeleteCustomerPhone, InputIdentityViewCustomerPhone, OutputCustomerPhone>
{
    [Column("id_cliente")]
    public long CustomerId { get; private set; }
    [Column("numero")]
    public string PhoneNumber { get; private set; }
    [Column("tem_whatsapp")]
    public bool IsZapZap { get; private set; }
    [Column("observação")]
    public string? Observation { get; private set; }

    #region Virtual Properties
    [NotMapped]
    [ForeignKey(nameof(CustomerId))]
    public Customer Customer { get; private set; }
    #endregion

    public CustomerPhone() { }

    public CustomerPhone(long customerId, string phoneNumber, bool isZapZap, string? observation, Customer customer)
    {
        CustomerId = customerId;
        PhoneNumber = phoneNumber;
        IsZapZap = isZapZap;
        Observation = observation;
        Customer = customer;
    }

    public CustomerPhoneDTO GetDTO()
    {
        return new CustomerPhoneDTO(CustomerId, PhoneNumber, IsZapZap, Observation, Customer);
    }

    public static implicit operator CustomerPhoneDTO(CustomerPhone customerPhone)
    {
        return customerPhone.GetDTO();
    }
}