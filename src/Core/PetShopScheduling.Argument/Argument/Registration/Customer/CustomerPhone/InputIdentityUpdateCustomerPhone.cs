using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputIdentityUpdateCustomerPhone(long id, InputUpdateCustomerPhone? inputUpdate) : BaseInputIdentityUpdate<InputUpdateCustomerPhone>(id, inputUpdate) { }