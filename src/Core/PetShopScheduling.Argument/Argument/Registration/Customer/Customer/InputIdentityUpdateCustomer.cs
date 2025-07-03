using PetShopScheduling.Argument.Argument.Base;

namespace PetShopScheduling.Argument.Argument.Registration;

public class InputIdentityUpdateCustomer(long id, InputUpdateCustomer? inputUpdate) : BaseInputIdentityUpdate<InputUpdateCustomer>(id, inputUpdate) { }