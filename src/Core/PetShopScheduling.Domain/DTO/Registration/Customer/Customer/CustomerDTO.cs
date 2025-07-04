using PetShopScheduling.Argument.Argument.Registration;
using PetShopScheduling.Domain.DTO.Base;

namespace PetShopScheduling.Domain.DTO.Registration;

public class CustomerDTO : BaseDTO<CustomerDTO, InputCreateCustomer, InputUpdateCustomer, InputIdentityUpdateCustomer, InputIdentityDeleteCustomer, InputIdentityViewCustomer, OutputCustomer>
{
    public string Name { get; private set; }
    public string? Cpf { get; private set; }

    #region Virtual Properties
    public List<CustomerPhoneDTO>? ListCustomerPhone { get; private set; }
    public List<CustomerAddressDTO>? ListCustomerAddress { get; private set; }
    #endregion

    public CustomerDTO() { }

    public CustomerDTO(string name, string? cpf, List<CustomerPhoneDTO> listCustomerPhone, List<CustomerAddressDTO> listCustomerAddress)
    {
        Name = name;
        Cpf = cpf;
        ListCustomerPhone = listCustomerPhone;
        ListCustomerAddress = listCustomerAddress;
    }
}