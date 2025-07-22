using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputIdentityUpdateCustomerAddress(long id, InputUpdateCustomerAddress? inputUpdate) : BaseInputIdentityUpdate<InputUpdateCustomerAddress>(id, inputUpdate) { }
